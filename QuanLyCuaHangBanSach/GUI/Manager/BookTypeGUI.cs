using System;
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
    public partial class BookTypeGUI : Form
    {
        private CheckBox headerCheckbox;

        public BookTypeGUI()
        {
            InitializeComponent();
        }

        private void renderCheckBoxDgv()
        {
            try
            {
                int size = 25;

                Rectangle rect = this.dgvBookType.GetCellDisplayRectangle(0, -1, false);

                headerCheckbox = new CheckBox();

                headerCheckbox.BackColor = Color.FromArgb(45, 210, 192);
                headerCheckbox.Name = "chkHeader";
                headerCheckbox.Size = new Size(size, size);

                rect.X = (rect.Width / 2) - (size / 4);
                rect.Y = (rect.Height / 2) - (size / 2);

                headerCheckbox.Location = rect.Location;


                this.dgvBookType.Controls.Add(headerCheckbox);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }

        private void loadBookTypeListToDataView(List<BookTypeDTO> BookTypeList)
        {
            try
            {
                this.dgvBookType.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 210, 192);
                this.dgvBookType.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                this.dgvBookType.Rows.Clear();

                foreach (BookTypeDTO BookType in BookTypeList)
                {
                    this.dgvBookType.Rows.Add(new object[] {
                    false,
                    BookType.MaTheLoai,
                    BookType.TenTheLoai,
                    BookType.TrangThai ? "Đang hoạt động" : "Ngưng hoạt động",
                });
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }

        }

        private void BookTypeGUI_Load(object sender, EventArgs e)
        {
            try
            {
                List<BookTypeDTO> BookTypeList = BookTypeBUS.Instance.getAllData();
                this.loadBookTypeListToDataView(BookTypeList);
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
                foreach (DataGridViewRow row in this.dgvBookType.Rows)
                {
                    row.Cells[0].Value = headerCheckbox.Checked;
                }

                this.dgvBookType.RefreshEdit();
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
                List<BookTypeDTO> BookTypeList = BookTypeBUS.Instance.search(this.searchInput.Text.ToString());

                this.loadBookTypeListToDataView(BookTypeList);
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
                string[] headerList = new string[] { "Mã Thể Loại, Tên Thể Loại" };

                DataTable dt = CustomExcel.Instance.ConvertDataGridViewToDataTable(dgvBookType);

                CustomExcel.Instance.ExportFileDatagridView(dt, "Book Manage", 1, "Cửa hàng bán sách", headerList);
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
                if (this.dgvBookType.CurrentCell.RowIndex < 0)
                {

                    MessageBox.Show("Hãy chọn dòng dữ liệu muốn thao tác");
                    return;
                }

                using (BookTypeModal BookTypeModal = new BookTypeModal("Sửa thể loại"))
                {
                    DataGridViewRow row = this.dgvBookType.Rows[this.dgvBookType.CurrentCell.RowIndex];

                    BookTypeDTO BookType = BookTypeBUS.Instance.getById(row.Cells[1].Value.ToString());


                    BookTypeModal.updateBookType = BookType;

                    if (BookTypeModal.updateBookType == null)
                    {
                        MessageBox.Show("Đã xảy ra lỗi vui lòng thử lại sau!!");
                        return;
                    }

                    BookTypeModal.ShowDialog();

                    if (BookTypeModal.isSubmitSuccess)
                    {

                        List<BookTypeDTO> BookTypeList = BookTypeBUS.Instance.search(this.searchInput.Text.ToString());

                        this.loadBookTypeListToDataView(BookTypeList);
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }

        private void dgvBookType_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0 || e.ColumnIndex <= 0)
                {
                    return;
                }

                using (BookTypeModal BookTypeModal = new BookTypeModal("Sửa thể loại"))
                {
                    DataGridViewRow row = this.dgvBookType.Rows[e.RowIndex];

                    BookTypeDTO BookType = BookTypeBUS.Instance.getById(row.Cells[1].Value.ToString());

                    BookTypeModal.updateBookType = BookType;

                    if (BookTypeModal.updateBookType == null)
                    {
                        MessageBox.Show("Đã xảy ra lỗi vui lòng thử lại sau!!");
                        return;
                    }

                    BookTypeModal.ShowDialog();

                    if (BookTypeModal.isSubmitSuccess)
                    {
                        List<BookTypeDTO> BookTypeList = BookTypeBUS.Instance.search(this.searchInput.Text.ToString());

                        this.loadBookTypeListToDataView(BookTypeList);
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
                List<BookTypeDTO> BookTypeList = BookTypeBUS.Instance.search("");
                this.loadBookTypeListToDataView(BookTypeList);
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
                using (BookTypeModal BookTypeModal = new BookTypeModal())
                {
                    BookTypeModal.ShowDialog();


                    if (BookTypeModal.isSubmitSuccess)
                    {
                        List<BookTypeDTO> BookTypeList = BookTypeBUS.Instance.search(this.searchInput.Text.ToString());

                        this.loadBookTypeListToDataView(BookTypeList);
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }
    }
}
