using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
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
			dgvBook.StandardTab = true;
		}

		private void renderCheckBoxDgv()
        {
            try
            {
                int size = 25;

                Rectangle rect = this.dgvBook.GetCellDisplayRectangle(0, -1, false);

                headerCheckbox = new CheckBox();

                headerCheckbox.BackColor = Color.FromArgb(45, 210, 192);
                headerCheckbox.Name = "chkHeader";
                headerCheckbox.Size = new Size(size, size);
                headerCheckbox.TabStop = false;

                rect.X = (rect.Width / 2) - (size / 4);
                rect.Y = (rect.Height / 2) - (size / 2);

                headerCheckbox.Location = rect.Location;


                this.dgvBook.Controls.Add(headerCheckbox);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void loadBookListToDataView(List<BookDTO> bookList)
        {
            try
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
                    string.Format("{0:N0} VNĐ", book.GiaBan),
                    string.Format("{0:N0} VNĐ", book.GiaNhap),
                    book.NamXuatBan,
                    string.Format("{0:N0} Sách", book.SoLuongConLai),
                });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private void loadAuthorCbx()
        {
            try
            {
                List<AuthorDTO> authorList = AuthorBUS.Instance.getAllData();

                authorList.Insert(0, new AuthorDTO(0, "Tất cả tác giả", "", 0));

                this.authorCbx.ValueMember = "Ma";
                this.authorCbx.DisplayMember = "Ten";
                this.authorCbx.DataSource = authorList;

                this.authorCbx.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void loadBookTypeCbx()
        {
            try
            {
                List<BookTypeDTO> bookTypeList = BookTypeBUS.Instance.getAllData();

                bookTypeList.Insert(0, new BookTypeDTO(0, "Tất cả thể loại"));

                this.bookTypeCbx.ValueMember = "MaTheLoai";
                this.bookTypeCbx.DisplayMember = "TenTheLoai";
                this.bookTypeCbx.DataSource = bookTypeList;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void loadPublisherCbx()
        {
            try
            {
                List<PublisherDTO> publisherList = PublisherBUS.Instance.getAllData();

                publisherList.Insert(0, new PublisherDTO(0, "Tất cả nhà xuất bản", "", ""));

                this.publisherCbx.ValueMember = "MaNhaXuatBan";
                this.publisherCbx.DisplayMember = "TenNhaXuatBan";
                this.publisherCbx.DataSource = publisherList;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void BookManageGUI_Load(object sender, EventArgs e)
        {

            try
            {
                List<BookDTO> bookList = BookBUS.Instance.getAllData();
                this.loadBookListToDataView(bookList);

                this.loadAuthorCbx();
                this.loadBookTypeCbx();
                this.loadPublisherCbx();
                this.renderCheckBoxDgv();
                headerCheckbox.MouseClick += new MouseEventHandler(headerCheckbox_Clicked);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private readonly int debounceInterval = 500; // Đặt khoảng thời gian debounce là 500 milliseconds
        private DateTime lastTextChanged = DateTime.MinValue;
        private readonly object debounceLock = new object();

        private async void DebounceTextBox_TextChanged(object sender, EventArgs e)
        {
            lock (debounceLock)
            {
                lastTextChanged = DateTime.Now;
            }

            await Task.Delay(debounceInterval);

            lock (debounceLock)
            {
                var now = DateTime.Now;
                if ((now - lastTextChanged).TotalMilliseconds >= debounceInterval)
                {
                    List<BookDTO> bookList = handleFilter(this.searchInput.Text.Trim());

                    this.loadBookListToDataView(bookList);
                }
            }
        }

        private void headerCheckbox_Clicked(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in this.dgvBook.Rows)
                {
                    row.Cells[0].Value = headerCheckbox.Checked;
                }

                this.dgvBook.RefreshEdit();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private List<BookDTO> handleFilter(string searchText)
        {
            try
            {
                List<BookDTO> bookList = BookBUS.Instance.search(searchText);

                if (this.priceFrom.Text.ToString() != string.Empty
                    && this.priceTo.Text.ToString() != string.Empty)
                {
                    Regex isNum = new Regex(@"^\d+$");

                    if (!isNum.IsMatch(this.priceFrom.Text.ToString()) || !isNum.IsMatch(this.priceFrom.Text.ToString()))
                    {
                        this.priceFrom.Clear();
                        this.priceTo.Clear();
                        MessageBox.Show("Giá bán là một số");
                    }
                    else
                    {
                        if (Convert.ToDecimal(this.priceFrom.Text.ToString()) <= Convert.ToDecimal(this.priceTo.Text.ToString()))
                        {
                            bookList = bookList.FindAll(
                                item => item.GiaBan >= Convert.ToDecimal(this.priceFrom.Text.ToString())
                                        && item.GiaBan <= Convert.ToDecimal(this.priceTo.Text.ToString()
                            ));
                        } else
                        {
                            MessageBox.Show("Giá bán đến phải bé hơn hoặc bằng giá bán từ");
                        }
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
            catch (Exception)
            {
                return new List<BookDTO>();
            }
        }

        private void searchInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.searchInput.ForeColor = Color.Black;

                List<BookDTO> bookList = handleFilter(this.searchInput.Text.Trim());

                this.loadBookListToDataView(bookList);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            using (BookModal bookModal = new BookModal())
            {
                bookModal.ShowDialog();


                if (bookModal.isSubmitSuccess)
                {
                    List<BookDTO> bookList = handleFilter(this.searchInput.Text.Trim());

                    this.loadBookListToDataView(bookList);
                }
            }
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void authorCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<BookDTO> bookList = handleFilter(this.searchInput.Text.Trim());

                this.loadBookListToDataView(bookList);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void bookTypeCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<BookDTO> bookList = handleFilter(this.searchInput.Text.Trim());

                this.loadBookListToDataView(bookList);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void publisherCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<BookDTO> bookList = handleFilter(this.searchInput.Text.Trim());

                this.loadBookListToDataView(bookList);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void priceTo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<BookDTO> bookList = handleFilter(this.searchInput.Text.Trim());

                this.loadBookListToDataView(bookList);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void priceFrom_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<BookDTO> bookList = handleFilter(this.searchInput.Text.Trim());

                this.loadBookListToDataView(bookList);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            if (dgvBook.Rows.Count <= 0)
            {
                MessageBox.Show("Bảng dữ liệu hiện tại chưa có dòng dữ liệu nào để xuất excel!");
                return;
            }

            string[] headerList = new string[] { "Mã sách", "Tên sách", "Tác giả", "Thể loại", "Nhà xuất bản", "Giá bán", "Giá nhập", "Năm xuất bản", "Còn lại" };
            
            DataTable dt = CustomExcel.Instance.ConvertDataGridViewToDataTable(dgvBook);

            CustomExcel.Instance.ExportFileDatagridView(dt, "Book Manage", 1, "Cửa hàng bán sách", headerList, 3);
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            try
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
                        List<BookDTO> bookList = handleFilter(this.searchInput.Text.Trim());

                        this.loadBookListToDataView(bookList);
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

                foreach (DataGridViewRow row in this.dgvBook.Rows)
                {
                    if ((bool)row.Cells[0].Value)
                    {
                        isHaveSelect = true;
                        break;
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
                    List<BookDTO> bookList = handleFilter(this.searchInput.Text.Trim());
                    this.loadBookListToDataView(bookList);

                    MessageBox.Show("Delete successful");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void dgvBook_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
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
                        List<BookDTO> bookList = handleFilter(this.searchInput.Text.Trim());

                        this.loadBookListToDataView(bookList);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void dgvBook_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            if (e.Column.Index == 7 || e.Column.Index == 8 || e.Column.Index == 10) // Check if sorting the last column
            {
                // Extract the values for sorting from the cell values
                double value1 = GetSortingValue(e.CellValue1);
                double value2 = GetSortingValue(e.CellValue2);

                // Compare the extracted values
                e.SortResult = value1.CompareTo(value2);

                // Mark the comparison as handled to prevent default sorting
                e.Handled = true;
            }
        }

        private double GetSortingValue(object cellValue)
        {
            if (cellValue == null)
                return 0;

            // Extract the numerical value from the string (remove " VNĐ" and parse)
            string stringValue = cellValue.ToString();
            stringValue = stringValue.Replace(".", "").Replace(" VNĐ", "");
            stringValue = stringValue.Replace(".", "").Replace(" Sách", "");

            if (double.TryParse(stringValue, out double numericValue))
            {
                // Convert the numeric value to a sortable string
                return numericValue;
            }

            return 0;
        }

        private void priceFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn chặn ký tự nhập vào TextBox
            }
        }

        private void priceTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn chặn ký tự nhập vào TextBox
            }
        }

        private void gunaAdvenceButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvBook.CurrentCell.RowIndex < 0)
                {
                    MessageBox.Show("Hãy chọn dòng dữ liệu muốn thao tác");
                    return;
                }

                DataGridViewRow row = this.dgvBook.Rows[this.dgvBook.CurrentCell.RowIndex];

                using (PrintBarcodeModal printBarcodeModal = new PrintBarcodeModal(row.Cells[1].Value.ToString()))
                {
                    printBarcodeModal.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
