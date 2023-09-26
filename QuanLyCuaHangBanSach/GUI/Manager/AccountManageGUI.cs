using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;
using QuanLyCuaHangBanSach.GUI.Modal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangBanSach.GUI.Manager
{
    public partial class AccountManageGUI : Form
    {
        private CheckBox headerCheckbox;
        public AccountManageGUI()
        {
            InitializeComponent();
        }
        private void renderCheckBoxDgv()
        {
            int size = 25;

            Rectangle rect = this.dgvAccount.GetCellDisplayRectangle(0, -1, false);

            headerCheckbox = new CheckBox();

            headerCheckbox.BackColor = Color.FromArgb(45, 210, 192);
            headerCheckbox.Name = "chkHeader";
            headerCheckbox.Size = new Size(size, size);

            rect.X = (rect.Width / 2) - (size / 4);
            rect.Y = (rect.Height / 2) - (size / 2);

            headerCheckbox.Location = rect.Location;


            this.dgvAccount.Controls.Add(headerCheckbox);
        }
        private void headerCheckBox_Clicked(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dgvAccount.Rows)
            {
                row.Cells[0].Value = headerCheckbox.Checked;
                this.dgvAccount.RefreshEdit();
            }
        }
        private void loadDataToDataGridView(List<AccountDTO> accounts)
        {
            this.dgvAccount.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 210, 192);
            this.dgvAccount.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dgvAccount.Rows.Clear();

            if (accounts != null)
            {
                foreach(AccountDTO account in accounts)
                {
                    StaffDTO STAFF = StaffBUS.Instance.getById(account.MaNhanVien.ToString());
                    if (STAFF != null)
                    {
					    this.dgvAccount.Rows.Add(new object[]
					     {
								    false,
									STAFF.Ten,
								    account.Email,
								    account.MatKhau
					      });
					}    
					
                } 
                    
            }    
        }
        private List<AccountDTO> handleFilter(string searchString)
        {
            List<AccountDTO> accounts = AccountBUS.Instance.search(searchString);
            return accounts;
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
           
            List<AccountDTO> accounts = handleFilter(this.searchInput.Text);
            DataTable dataTable = CustomExcel.Instance.ConvertListToDataTable(accounts);
            string[] headerList = new string[] { "Mã Nhân viên", "Email", "Mật khẩu" };
            CustomExcel.Instance.ExportFile(dataTable: dataTable, sheetName: "Quản lý tài khoản", title: "Cửa hàng bán sách", headerList: headerList);
        }
        private void AccountMangeGUI_Load(object sender, EventArgs e)
        {
            this.Location = new Point(
               (Screen.PrimaryScreen.Bounds.Size.Width / 2) - (this.Size.Width / 2),
               (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (this.Size.Height / 2)
           );
            List<AccountDTO> accounts = AccountBUS.Instance.getAllData();
            this.loadDataToDataGridView(accounts);

            renderCheckBoxDgv();
            headerCheckbox.MouseClick += new MouseEventHandler(headerCheckBox_Clicked);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.searchInput.Clear();
            List<AccountDTO> accounts = AccountBUS.Instance.getAllData();
            this.loadDataToDataGridView(accounts);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var modal = new AccountModal())
            {
                modal.ShowDialog();

                if (modal.isSubmitSuccess)
                {
                    List<AccountDTO> accounts = handleFilter(this.searchInput.Text);
                    this.loadDataToDataGridView(accounts);
                }    
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.dgvAccount.CurrentCell.RowIndex < 0)
            {
                MessageBox.Show("Hãy chọn dòng dữ liệu muốn thao tác");
                return;
            }

            using (AccountModal accountModal = new AccountModal("Sửa thông tin tài khoản"))
            {
                DataGridViewRow row = this.dgvAccount.Rows[this.dgvAccount.CurrentCell.RowIndex];

                AccountDTO account = AccountBUS.Instance.getById(row.Cells[2].Value.ToString()) ;

                accountModal.account = account; 

                if (accountModal.account == null)
                {
                    MessageBox.Show("Đã xảy ra lỗi vui lòng thử lại sau!!");
                    return;
                }

                accountModal.ShowDialog();

                if (accountModal.isSubmitSuccess)
                {
                    // 
                    List<AccountDTO> accounts = AccountBUS.Instance.getAllData();
                    this.loadDataToDataGridView(accounts);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                    "Bạn có chắc rằng muốn xóa các tài khoản đã chọn",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.None
                );
            if(result == DialogResult.Yes)
            {
                foreach(DataGridViewRow row in this.dgvAccount.Rows)
                {
                    if ((bool)row.Cells[0].Value)
                    {
                       bool check = AccountBUS.Instance.delete(row.Cells[2].Value.ToString());
                        Console.WriteLine(check);
                    }  
                }
                //
                List<AccountDTO> accounts = handleFilter(this.searchInput.Text);
                this.loadDataToDataGridView(accounts);
                MessageBox.Show("Xóa thành công các tài khoản đã chọn");
            }    

        }

        private void dgvAccountCell_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex <= 0)
            {
                return;
            }
            using (AccountModal accountModal = new AccountModal("Sửa thông tin tài khoản"))
            {
                DataGridViewRow row = this.dgvAccount.Rows[this.dgvAccount.CurrentCell.RowIndex];

                AccountDTO account = AccountBUS.Instance.getById(row.Cells[2].Value.ToString());

                accountModal.account = account;

                if (accountModal.account == null)
                {
                    MessageBox.Show("Đã xảy ra lỗi vui lòng thử lại sau!!");
                    return;
                }

                accountModal.ShowDialog();

                if (accountModal.isSubmitSuccess)
                {
                    // 
                    List<AccountDTO> accounts = AccountBUS.Instance.getAllData();
                    this.loadDataToDataGridView(accounts);
                }
            }
        }

		private void searchInput_TextChanged(object sender, EventArgs e)
		{
            List<AccountDTO> account = handleFilter(this.searchInput.Text);
            loadDataToDataGridView(account);
		}
	}
}
