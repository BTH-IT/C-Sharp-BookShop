using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;
using QuanLyCuaHangBanSach.GUI.Modal;
using QuanLyCuaHangBanSach;
using MySqlX.XDevAPI.Relational;
using System.Linq;

namespace QuanLyCuaHangBanTacGia.GUI.Manager
{
    public partial class AuthorGUI : Form
    {
        private CheckBox headerCheckbox;
		string[] genders = new string[] { "Chọn giới tính", "Nam", "Nữ" };
		public AuthorGUI()
        {
            InitializeComponent();
        }

        private void renderCheckBoxDgv()
        {
            int size = 25;

            Rectangle rect = this.dgvAuthor.GetCellDisplayRectangle(0, -1, false);

            headerCheckbox = new CheckBox();

            headerCheckbox.BackColor = Color.FromArgb(45, 210, 192);
            headerCheckbox.Name = "chkHeader";
            headerCheckbox.Size = new Size(size, size);

            rect.X = (rect.Width / 2) - (size / 4);
            rect.Y = (rect.Height / 2) - (size / 2);

            headerCheckbox.Location = rect.Location;


            this.dgvAuthor.Controls.Add(headerCheckbox);
        }

        private void loadAuthorListToDataView(List<AuthorDTO> AuthorList)
        {
            this.dgvAuthor.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 210, 192);
            this.dgvAuthor.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dgvAuthor.Rows.Clear();


            foreach (AuthorDTO Author in AuthorList)
            {
                this.dgvAuthor.Rows.Add(new object[] {
                    false,
                    Author.Ma,
                    Author.Ten,
                    Author.GioiTinh,
                    Author.NamSinh,
                });
            }

        }

        private void AuthorGUI_Load(object sender, EventArgs e)
        {

            List<AuthorDTO> AuthorList = AuthorBUS.Instance.getAllData();
            this.loadAuthorListToDataView(AuthorList);
			this.genderCbx.Items.AddRange(genders);
			this.genderCbx.SelectedIndex = 0;
			this.renderCheckBoxDgv();
            headerCheckbox.MouseClick += new MouseEventHandler(headerCheckbox_Clicked);
        }

        private void headerCheckbox_Clicked(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dgvAuthor.Rows)
            {
                row.Cells[0].Value = headerCheckbox.Checked;
            }

            this.dgvAuthor.RefreshEdit();
        }


        private void searchInput_TextChanged(object sender, EventArgs e)
        {
            this.searchInput.ForeColor = Color.Black;

            List<AuthorDTO> AuthorList = AuthorBUS.Instance.search(this.searchInput.Text.ToString());
            string selectedGender = this.genderCbx.SelectedItem.ToString();
            if (selectedGender != genders[0])
			{
				AuthorList = AuthorList.Where(a => a.GioiTinh == selectedGender).ToList();
			}
			this.loadAuthorListToDataView(AuthorList);
        }

        
        

        // export excel
        private void exportBtn_Click(object sender, EventArgs e)
        {
            List<AuthorDTO> AuthorList = AuthorBUS.Instance.search(this.searchInput.Text.ToString());

            DataTable dataTable = CustomExcel.Instance.ConvertListToDataTable(AuthorList);

            string[] headerList = new string[] { "Mã tác giả", "Tên tác giả", "Giới tính", "Năm sinh"};

            CustomExcel.Instance.ExportFile(dataTable, "Author Manage", "Cửa hàng bán sách", headerList);
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            
            if (this.dgvAuthor.CurrentCell.RowIndex < 0)
            {
                
                MessageBox.Show("Hãy chọn dòng dữ liệu muốn thao tác");
                return;
            }
            
            using (AuthorModal AuthorModal = new AuthorModal("Sửa tác giả"))
            {
                DataGridViewRow row = this.dgvAuthor.Rows[this.dgvAuthor.CurrentCell.RowIndex];

                AuthorDTO Author = AuthorBUS.Instance.getById(row.Cells[1].Value.ToString());
                

                AuthorModal.updateAuthor = Author;

                if (AuthorModal.updateAuthor == null)
                {
                    MessageBox.Show("Đã xảy ra lỗi vui lòng thử lại sau!!");
                    return;
                }

                AuthorModal.ShowDialog();

                if (AuthorModal.isSubmitSuccess)
                {
                    
                    List<AuthorDTO> AuthorList = AuthorBUS.Instance.search(this.searchInput.Text.ToString());

                    this.loadAuthorListToDataView(AuthorList);
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            bool isHaveSelect = false;

            foreach (DataGridViewRow row in this.dgvAuthor.Rows)
            {
                if ((bool)row.Cells[0].Value)
                {
                    isHaveSelect = true;
                    break;
                }
            }

            if (!isHaveSelect)
            {
                MessageBox.Show("Bạn chưa chọn những tác giả cần xóa");
                return;
            }

            DialogResult dlgResult = MessageBox.Show(
                "Bạn chắc chắn muốn xóa các tác giả đã chọn chứ?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1
            );

            if (dlgResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in this.dgvAuthor.Rows)
                {
                    if ((bool)row.Cells[0].Value == true)
                    {
                        AuthorBUS.Instance.delete(row.Cells[1].Value.ToString());
                    }

                }
                List<AuthorDTO> AuthorList = AuthorBUS.Instance.search(this.searchInput.Text.ToString());

                this.loadAuthorListToDataView(AuthorList);

                MessageBox.Show("Delete successful");
            }
        }

        private void dgvAuthor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex <= 0)
            {
                return;
            }

            using (AuthorModal AuthorModal = new AuthorModal("Sửa sách"))
            {
                DataGridViewRow row = this.dgvAuthor.Rows[e.RowIndex];

                AuthorDTO Author = AuthorBUS.Instance.getById(row.Cells[1].Value.ToString());

                AuthorModal.updateAuthor = Author;

                if (AuthorModal.updateAuthor == null)
                {
                    MessageBox.Show("Đã xảy ra lỗi vui lòng thử lại sau!!");
                    return;
                }

                AuthorModal.ShowDialog();

                if (AuthorModal.isSubmitSuccess)
                {
                    List<AuthorDTO> AuthorList = AuthorBUS.Instance.search(this.searchInput.Text.ToString());

                    this.loadAuthorListToDataView(AuthorList);
                }
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            this.searchInput.Clear();
            this.genderCbx.SelectedIndex = 0;
            List<AuthorDTO> AuthorList = AuthorBUS.Instance.search("");
            this.loadAuthorListToDataView(AuthorList);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            using (AuthorModal AuthorModal = new AuthorModal())
            {
                AuthorModal.ShowDialog();


                if (AuthorModal.isSubmitSuccess)
                {
                    List<AuthorDTO> AuthorList = AuthorBUS.Instance.search(this.searchInput.Text.ToString());

                    this.loadAuthorListToDataView(AuthorList);
                }
            }
        }

        private void dgvAuthor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

		private void genderCbx_SelectedIndexChanged(object sender, EventArgs e)
		{
			List<AuthorDTO> authors = AuthorBUS.Instance.search(this.searchInput.Text.ToString());
            string selectedGender = this.genderCbx.SelectedItem.ToString();
            if (selectedGender != genders[0])
            {
                authors = authors.Where(a => a.GioiTinh == selectedGender).ToList();
            }    
            loadAuthorListToDataView(authors);
		}
	}
}
