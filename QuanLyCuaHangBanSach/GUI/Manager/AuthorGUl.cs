﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;
using QuanLyCuaHangBanSach.GUI.Modal;
using QuanLyCuaHangBanSach;

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
            try
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
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }

        private void loadAuthorListToDataView(List<AuthorDTO> AuthorList)
        {
            try
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
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }

        }

        private void AuthorGUI_Load(object sender, EventArgs e)
        {
            try
            {
                List<AuthorDTO> AuthorList = AuthorBUS.Instance.getAllData();
                this.loadAuthorListToDataView(AuthorList);
                this.genderCbx.Items.AddRange(genders);
                this.genderCbx.SelectedIndex = 0;
                this.renderCheckBoxDgv();
                headerCheckbox.MouseClick += new MouseEventHandler(headerCheckbox_Clicked);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void headerCheckbox_Clicked(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in this.dgvAuthor.Rows)
                {
                    row.Cells[0].Value = headerCheckbox.Checked;
                }

                this.dgvAuthor.RefreshEdit();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }

        private void searchInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.searchInput.ForeColor = Color.Black;
                List<AuthorDTO> AuthorList = AuthorBUS.Instance.search(this.searchInput.Text.ToString());

                this.loadAuthorListToDataView(AuthorList);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                List<AuthorDTO> AuthorList = AuthorBUS.Instance.search(this.searchInput.Text.ToString());

                DataTable dataTable = CustomExcel.Instance.ConvertListToDataTable(AuthorList);

                string[] headerList = new string[] { "Mã tác giả", "Tên tác giả", "Giới tính", "Năm sinh" };

                CustomExcel.Instance.ExportFile(dataTable, "Author Manage", "Cửa hàng bán sách", headerList);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {

            try
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
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }

        private void dgvAuthor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
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
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.searchInput.Clear();
                this.genderCbx.SelectedIndex = 0;
                List<AuthorDTO> AuthorList = AuthorBUS.Instance.search("");
                this.loadAuthorListToDataView(AuthorList);
            }
            catch (Exception er)
            {

                Console.WriteLine(er);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }

        private void genderCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<AuthorDTO> AuthorList = handleFilter(this.searchInput.Text.ToString());
                this.loadAuthorListToDataView(AuthorList);
            }
            catch (Exception er)
            {

                Console.WriteLine(er);
            }
        }

        private List<AuthorDTO> handleFilter(string searchText)
        {
            try
            {
                List<AuthorDTO> authorDTOList = AuthorBUS.Instance.search(searchText);


                string selectedGender = this.genderCbx.SelectedItem.ToString();
                

                List<AuthorDTO> newAuthorList = authorDTOList.FindAll(authorList =>
                {
                    if (selectedGender != "Chọn giới tính")
                    {
                        return authorList.GioiTinh == selectedGender;
                    }
                    return true;
                }
                );
                return newAuthorList;
                }
            catch (Exception er)
            {

                return new List<AuthorDTO>();
            }
        }
    }
}
