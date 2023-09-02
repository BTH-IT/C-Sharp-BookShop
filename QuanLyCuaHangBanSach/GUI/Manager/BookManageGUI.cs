using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;
using QuanLyCuaHangBanSach.GUI.Modal;

namespace QuanLyCuaHangBanSach.GUI.Manager
{
    public partial class BookManageGUI : Form
    {
        private CheckBox headerCheckbox;
        public BookManageGUI()
        {
            InitializeComponent();
        }

        private void renderCheckBoxDgv()
        {
            int size = 25;

            Rectangle rect = this.dgvBook.GetCellDisplayRectangle(0, -1, false);

            headerCheckbox = new CheckBox();
            
            headerCheckbox.BackColor = Color.FromArgb(45, 210, 192);
            headerCheckbox.Name = "chkHeader";
            headerCheckbox.Size = new Size(size, size);

            rect.X = (rect.Width / 2) - (size / 4);
            rect.Y = (rect.Height / 2) - (size / 2);

            headerCheckbox.Location = rect.Location;


            this.dgvBook.Controls.Add(headerCheckbox);
        }

        private void loadBookListToDataView(List<BookDTO> bookList)
        {
            this.dgvBook.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 210, 192);
            this.dgvBook.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            this.dgvBook.Rows.Clear();

            foreach (BookDTO book in bookList)
            {
                this.dgvBook.Rows.Add(new object[] {
                    false,
                    book.MaSach,
                    book.TenSach,
                    book.HinhAnh,
                    AuthorBUS.Instance.getById(book.MaTacGia.ToString()).Ten,
                    BookTypeBUS.Instance.getById(book.MaTheLoai.ToString()).TenTheLoai,
                    PublisherBUS.Instance.getById(book.MaNhaXuatBan.ToString()).TenNhaXuatBan,
                    book.GiaBan,
                    book.GiaNhap,
                    book.NamXuatBan,
                    book.SoLuongConLai,
                });
            }

        }

        private void loadAuthorCbx()
        {
            List<AuthorDTO> authorList = AuthorBUS.Instance.getAllData();

            authorList.Insert(0, new AuthorDTO(0, "Tất cả tác giả", "", 0));

            this.authorCbx.ValueMember = "Ma";
            this.authorCbx.DisplayMember = "Ten";
            this.authorCbx.DataSource = authorList;

            this.authorCbx.SelectedIndex = 0;
        }

        private void loadBookTypeCbx()
        {
            List<BookTypeDTO> bookTypeList = BookTypeBUS.Instance.getAllData();

            bookTypeList.Insert(0, new BookTypeDTO(0, "Tất cả thể loại"));

            this.bookTypeCbx.ValueMember = "MaTheLoai";
            this.bookTypeCbx.DisplayMember = "TenTheLoai";
            this.bookTypeCbx.DataSource = bookTypeList;
        }

        private void loadPublisherCbx()
        {
            List<PublisherDTO> publisherList = PublisherBUS.Instance.getAllData();

            publisherList.Insert(0, new PublisherDTO(0, "Tất cả nhà xuất bản", "", ""));

            this.publisherCbx.ValueMember = "MaNhaXuatBan";
            this.publisherCbx.DisplayMember = "TenNhaXuatBan";
            this.publisherCbx.DataSource = publisherList;
        }

        private void BookManageGUI_Load(object sender, EventArgs e)
        {

            List<BookDTO> bookList = BookBUS.Instance.getAllData();
            this.loadBookListToDataView(bookList);

            this.loadAuthorCbx();
            this.loadBookTypeCbx();
            this.loadPublisherCbx();
            this.renderCheckBoxDgv();
            headerCheckbox.MouseClick += new MouseEventHandler(headerCheckbox_Clicked);
        }

        private void headerCheckbox_Clicked(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dgvBook.Rows)
            {
                row.Cells[0].Value = headerCheckbox.Checked;
            }

            this.dgvBook.RefreshEdit();
        }

        private List<BookDTO> handleFilter(string searchText)
        {
            if (searchText == "Enter your search...")
            {
                searchText = "";
            }

            List<BookDTO> bookList = BookBUS.Instance.search(searchText);

            if (this.priceFrom.Text.ToString() != string.Empty
                && this.priceTo.Text.ToString() != string.Empty)
            {
                try
                {
                    bookList = bookList.FindAll(
                        item => item.GiaBan >= Convert.ToDouble(this.priceFrom.Text.ToString())
                                && item.GiaBan <= Convert.ToDouble(this.priceTo.Text.ToString()
                    ));
                } catch
                {
                    MessageBox.Show("Giá phải là số");
                }
            }

            int authorId = Convert.ToInt32(this.authorCbx.SelectedValue);
            int bookTypeId = Convert.ToInt32(this.bookTypeCbx.SelectedValue);
            int publisherId = Convert.ToInt32(this.publisherCbx.SelectedValue);

            List<BookDTO> newBookList = bookList.FindAll(book =>
            {
                if (authorId != 0 && bookTypeId != 0 && publisherId != 0)
                {
                    return book.MaTacGia == authorId &&
                           book.MaTheLoai == bookTypeId &&
                           book.MaNhaXuatBan == publisherId;
                }

                if (authorId == 0 && bookTypeId != 0 && publisherId != 0)
                {
                    return book.MaTheLoai == bookTypeId &&
                           book.MaNhaXuatBan == publisherId;
                }

                if (authorId == 0 && bookTypeId == 0 && publisherId != 0)
                {
                    return book.MaNhaXuatBan == publisherId;
                }

                if (authorId == 0 && bookTypeId != 0 && publisherId == 0)
                {
                    return book.MaTheLoai == bookTypeId;
                }

                if (authorId != 0 && bookTypeId == 0 && publisherId == 0)
                {
                    return book.MaTacGia == authorId;
                }

                if (authorId != 0 && bookTypeId != 0 && publisherId == 0)
                {
                    return book.MaTacGia == authorId &&
                           book.MaTheLoai == bookTypeId;
                }

                if (authorId != 0 && bookTypeId == 0 && publisherId != 0)
                {
                    return book.MaTacGia == authorId &&
                           book.MaNhaXuatBan == publisherId;
                }

                return true;
            });


            return newBookList;
        }

        private void searchInput_TextChanged(object sender, EventArgs e)
        {
            this.searchInput.ForeColor = Color.Black;

            List<BookDTO> bookList = handleFilter(this.searchInput.Text.ToString());

            this.loadBookListToDataView(bookList);
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            using (BookModal bookModal = new BookModal())
            {
                bookModal.ShowDialog();


                if (bookModal.isSubmitSuccess)
                {
                    List<BookDTO> bookList = handleFilter(this.searchInput.Text.ToString());

                    this.loadBookListToDataView(bookList);
                }
            }
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            this.searchInput.Clear();

            this.priceFrom.Clear();
            this.priceTo.Clear();

            this.authorCbx.SelectedIndex = 0;
            this.bookTypeCbx.SelectedIndex = 0;
            this.publisherCbx.SelectedIndex = 0;

            List<BookDTO> bookList = BookBUS.Instance.search("");
            this.loadBookListToDataView(bookList);
        }

        private void authorCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<BookDTO> bookList = handleFilter(this.searchInput.Text.ToString());

            this.loadBookListToDataView(bookList);
        }

        private void bookTypeCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<BookDTO> bookList = handleFilter(this.searchInput.Text.ToString());

            this.loadBookListToDataView(bookList);
        }

        private void publisherCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<BookDTO> bookList = handleFilter(this.searchInput.Text.ToString());

            this.loadBookListToDataView(bookList);
        }

        private void priceTo_TextChanged(object sender, EventArgs e)
        {
            List<BookDTO> bookList = handleFilter(this.searchInput.Text.ToString());

            this.loadBookListToDataView(bookList);
        }

        private void priceFrom_TextChanged(object sender, EventArgs e)
        {
            List<BookDTO> bookList = handleFilter(this.searchInput.Text.ToString());

            this.loadBookListToDataView(bookList);
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            List<BookDTO> bookList = handleFilter(this.searchInput.Text.ToString());

            DataTable dataTable = CustomExcel.Instance.ConvertListToDataTable(bookList);

            string[] headerList = new string[] { "Mã sách", "Tên sách", "Tác giả", "Thể loại", "Nhà xuất bản", "Giá bán", "Giá nhập", "Năm xuất bản", "Còn lại" };
            
            CustomExcel.Instance.ExportFile(dataTable, "Book Manage", "Cửa hàng bán sách", headerList, 2);
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (this.dgvBook.CurrentCell.RowIndex < 0)
            {
                MessageBox.Show("Hãy chọn dòng dữ liệu muốn thao tác");
                return;
            }

            using (BookModal bookModal = new BookModal("Sửa sách"))
            {
                DataGridViewRow row = this.dgvBook.Rows[this.dgvBook.CurrentCell.RowIndex];

                BookDTO book = BookBUS.Instance.getById(row.Cells[1].Value.ToString());

                bookModal.updateBook = book;

                if (bookModal.updateBook == null)
                {
                    MessageBox.Show("Đã xảy ra lỗi vui lòng thử lại sau!!");
                    return;
                }

                bookModal.ShowDialog();

                if (bookModal.isSubmitSuccess)
                {
                    List<BookDTO> bookList = handleFilter(this.searchInput.Text.ToString());

                    this.loadBookListToDataView(bookList);
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            bool isHaveSelect = false;

            foreach (DataGridViewRow row in this.dgvBook.Rows)
            {
                if ((bool)row.Cells[0].Value)
                {
                    isHaveSelect = true;
                }
            }

            if (!isHaveSelect)
            {
                MessageBox.Show("Bạn chưa chọn những sách cần xóa");
                return;
            }

            DialogResult dlgResult = MessageBox.Show(
                "Bạn chắc chắn muốn xóa các sách đã chọn chứ chứ?", 
                "Xác nhận", 
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, 
                MessageBoxDefaultButton.Button1
            );

            if (dlgResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in this.dgvBook.Rows)
                {
                    if ((bool)row.Cells[0].Value == true)
                    {
                        BookBUS.Instance.delete(row.Cells[1].Value.ToString());
                    }
                    
                }
                List<BookDTO> bookList = handleFilter(this.searchInput.Text.ToString());
                this.loadBookListToDataView(bookList);

                MessageBox.Show("Delete successful");
            }
        }

        private void dgvBook_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex <= 0)
            {
                return;
            }

            using (BookModal bookModal = new BookModal("Sửa sách"))
            {
                DataGridViewRow row = this.dgvBook.Rows[e.RowIndex];

                BookDTO book = BookBUS.Instance.getById(row.Cells[1].Value.ToString());

                bookModal.updateBook = book;

                if (bookModal.updateBook == null)
                {
                    MessageBox.Show("Đã xảy ra lỗi vui lòng thử lại sau!!");
                    return;
                }

                bookModal.ShowDialog();

                if (bookModal.isSubmitSuccess)
                {
                    List<BookDTO> bookList = handleFilter(this.searchInput.Text.ToString());

                    this.loadBookListToDataView(bookList);
                }
            }
        }
    }
}
