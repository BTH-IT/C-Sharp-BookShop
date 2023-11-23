using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;
using QuanLyCuaHangBanSach.GUI.Modal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyCuaHangBanSach.GUI.Manager
{
    public partial class AccountManageGUI : Form
    {
        private CheckBox headerCheckbox;
        public AccountManageGUI()
        {
            InitializeComponent();
			dgvAccount.StandardTab = true;

		}
        private void renderCheckBoxDgv()
        {
            int size = 25;

            Rectangle rect = this.dgvAccount.GetCellDisplayRectangle(0, -1, false);

            headerCheckbox = new CheckBox();

            headerCheckbox.BackColor = Color.FromArgb(45, 210, 192);
            headerCheckbox.Name = "chkHeader";
            headerCheckbox.Size = new Size(size, size);
			headerCheckbox.TabStop = false;

			rect.X = (rect.Width / 2) - (size / 4);
            rect.Y = (rect.Height / 2) - (size / 2);

            headerCheckbox.Location = rect.Location;


            this.dgvAccount.Controls.Add(headerCheckbox);
        }
        private void headerCheckBox_Clicked(object sender, EventArgs e)
        {
            try
            {
				foreach (DataGridViewRow row in this.dgvAccount.Rows)
				{
					row.Cells[0].Value = headerCheckbox.Checked;
					this.dgvAccount.RefreshEdit();
				}
			}
			catch
            {

            }
          
        }
        private void loadDataToDataGridView(List<AccountDTO> accounts)
        {
            this.dgvAccount.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 210, 192);
            this.dgvAccount.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
			this.dgvAccount.ColumnHeadersDefaultCellStyle.Font = new Font("#9Slide03 Cabin", 10, FontStyle.Regular);
			this.dgvAccount.Rows.Clear();
            try
            {
				if (accounts != null)
				{
					foreach (AccountDTO account in accounts)
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
            catch
            {

            }
            
        }
        private List<AccountDTO> handleFilter(string searchString)
        {
            try
            {
				List<AccountDTO> accounts = AccountBUS.Instance.search(searchString);
				return accounts;
            }
            catch
            {
				return null;
			}
            
           
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
			if (dgvAccount.Rows.Count <= 0)
			{
				MessageBox.Show("Bảng dữ liệu hiện tại chưa có dòng dữ liệu nào để xuất excel!");
				return;
			}
            try
            {
				string[] headerList = new string[] { "Nhân viên", "Email", "Mật khẩu" };
                DataTable dt = CustomExcel.Instance.ConvertDataGridViewToDataTable(dgvAccount);

                CustomExcel.Instance.ExportFileDatagridView(dt, "Book Manage", 1, "Cửa hàng bán sách", headerList);
            }
            catch
            {

            }
           
        }
        private void AccountMangeGUI_Load(object sender, EventArgs e)
        {
            this.Location = new Point(
               (Screen.PrimaryScreen.Bounds.Size.Width / 2) - (this.Size.Width / 2),
               (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (this.Size.Height / 2)
           );
            try
            {
				List<AccountDTO> accounts = AccountBUS.Instance.getAllData();
				this.loadDataToDataGridView(accounts);

				renderCheckBoxDgv();
				headerCheckbox.MouseClick += new MouseEventHandler(headerCheckBox_Clicked);
            }
            catch
            {

            }
           
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
				this.searchInput.Clear();
				List<AccountDTO> accounts = AccountBUS.Instance.getAllData();
				this.loadDataToDataGridView(accounts);
			}
            catch
            {

            }
          
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
				using (var modal = new AccountModal())
				{
					modal.ShowDialog();

					if (modal.isSubmitSuccess)
					{
						List<AccountDTO> accounts = handleFilter(this.searchInput.Text.Trim());
						this.loadDataToDataGridView(accounts);
					}
				}
			}
            catch
            {

            }
           
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
				if(this.dgvAccount.CurrentCell != null)
				{
					if (this.dgvAccount.CurrentCell.RowIndex < 0)
					{
						MessageBox.Show("Hãy chọn dòng dữ liệu muốn thao tác");
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
				else
				{
					MessageBox.Show("Bảng dữ liệu có thể chưa có dòng dữ liệu nào để chỉnh sửa");
				}	
			}
            catch
            {

            }
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                bool isHaveSelect = false;

                foreach (DataGridViewRow row in this.dgvAccount.Rows)
                {
                    if ((bool)row.Cells[0].Value)
                    {
                        isHaveSelect = true;
                    }
                }

                if (!isHaveSelect)
                {
                    MessageBox.Show("Bạn chưa chọn các tài khoản cần xóa");
                    return;
                }

                DialogResult result = MessageBox.Show(
					"Bạn có chắc rằng muốn xóa các tài khoản đã chọn",
					"Xác nhận",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.None
				);
				if (result == DialogResult.Yes)
				{
					bool isDeleted = false;
					foreach (DataGridViewRow row in this.dgvAccount.Rows)
					{
						if ((bool)row.Cells[0].Value)
						{
							AccountDTO account = AccountBUS.Instance.getById(row.Cells[2].Value.ToString());
							StaffDTO staff = StaffBUS.Instance.getById(account.MaNhanVien.ToString());
							if (staff.MaChucVu != 1) 
							{
								bool check = AccountBUS.Instance.delete(account.Email);
								isDeleted = true;
							}
							else
							{
								MessageBox.Show("Không thể xóa tài khoản của quản lí","Thông báo");
							}
						}
					}
					if (isDeleted) 
					{
						List<AccountDTO> accounts = handleFilter(this.searchInput.Text.Trim());
						this.loadDataToDataGridView(accounts);
						MessageBox.Show("Xóa thành công các tài khoản đã chọn");
					}
				}
			}
            catch
            {

            }
            

        }

        private void dgvAccountCell_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
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
            catch
            {

            }
           
        }

		private void searchInput_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<AccountDTO> account = handleFilter(this.searchInput.Text.Trim());
				loadDataToDataGridView(account);
			}
			catch
			{

			}
         
		}
	}
}
