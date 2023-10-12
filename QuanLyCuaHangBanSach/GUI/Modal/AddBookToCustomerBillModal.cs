using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.GUI.Modal
{
    public partial class AddBookToCustomerBillModal : Form
    {
        private bool isSaved = false;
        private CheckBox headerCheckbox;
        private CheckBox headerCheckboxBillList;
        private List<BookDTO> bookList = BookBUS.Instance.getAllData();

        public List<CustomerBillDetailDTO> selectedCustomerBillDetailList = new List<CustomerBillDetailDTO>();

        public AddBookToCustomerBillModal(List<CustomerBillDetailDTO> customerBillDetailList)
        {
            InitializeComponent();

            this.selectedCustomerBillDetailList.Clear();
            this.selectedCustomerBillDetailList = customerBillDetailList;
        }

        private void renderCheckBoxDgvBook()
        {
            try
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
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        
        private void renderCheckBoxDgvBookBillList()
        {
            try
            {
                int size = 25;

                Rectangle rect = this.dgvBook.GetCellDisplayRectangle(0, -1, false);

                headerCheckboxBillList = new CheckBox();

                headerCheckboxBillList.BackColor = Color.FromArgb(45, 210, 192);
                headerCheckboxBillList.Name = "chkHeader";
                headerCheckboxBillList.Size = new Size(size, size);

                rect.X = (rect.Width / 2) - (size / 4);
                rect.Y = (rect.Height / 2) - (size / 2);

                headerCheckboxBillList.Location = rect.Location;

                this.dgvAddBookToBillList.Controls.Add(headerCheckboxBillList);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void loadBookListToDataView(string searchText)
        {
            try
            {
                this.dgvBook.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 210, 192);
                this.dgvBook.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                this.dgvBook.Rows.Clear();

                List<BookDTO> filterBookList = handleFilter(searchText);

                foreach (BookDTO book in filterBookList)
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
                    book.SoLuongConLai,
                });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void loadAddBookBillListToDataView()
        {
            try
            {
                this.dgvAddBookToBillList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 210, 192);
                this.dgvAddBookToBillList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                this.dgvAddBookToBillList.Rows.Clear();

                foreach (CustomerBillDetailDTO customerBillDetail in this.selectedCustomerBillDetailList)
                {
                    this.dgvAddBookToBillList.Rows.Add(new object[] {
                    false,
                    customerBillDetail.MaSach,
                    customerBillDetail.SoLuong,
                    customerBillDetail.DonGia,
                    customerBillDetail.SoLuong * customerBillDetail.DonGia,
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

        private void headerCheckboxBillList_Clicked(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in this.dgvAddBookToBillList.Rows)
                {
                    row.Cells[0].Value = headerCheckbox.Checked;
                }

                this.dgvAddBookToBillList.RefreshEdit();
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
                List<BookDTO> newBookList = this.bookList.FindAll(
                        (book) => book.TenSach.Contains(searchText) || book.MaSach.ToString().Contains(searchText)
                    );

                if (this.priceFrom.Text.ToString() != string.Empty
                    && this.priceTo.Text.ToString() != string.Empty)
                {
                    Regex isNum = new Regex(@"^\d+$");

                    if (!isNum.IsMatch(this.priceFrom.Text.ToString()) || !isNum.IsMatch(this.priceFrom.Text.ToString()))
                    {
                        this.priceFrom.Clear();
                        this.priceTo.Clear();
                        MessageBox.Show("Giá là một số");
                    }
                    else
                    {
                        newBookList = newBookList.FindAll(
                            item => item.GiaBan >= Convert.ToDouble(this.priceFrom.Text.ToString())
                                    && item.GiaBan <= Convert.ToDouble(this.priceTo.Text.ToString()
                        ));
                    }
                }

                int authorId = Convert.ToInt32(this.authorCbx.SelectedValue);
                int bookTypeId = Convert.ToInt32(this.bookTypeCbx.SelectedValue);
                int publisherId = Convert.ToInt32(this.publisherCbx.SelectedValue);

                List<BookDTO> filterBookList = newBookList.FindAll(book =>
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


                return filterBookList;
            }
            catch (Exception ex)
            {

                return new List<BookDTO>();
            }
        }

        private void searchInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.searchInput.ForeColor = Color.Black;

                this.loadBookListToDataView(this.searchInput.Text.ToString());
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
                this.searchInput.ForeColor = Color.Black;

                this.loadBookListToDataView(this.searchInput.Text.ToString());
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
                this.searchInput.ForeColor = Color.Black;

                this.loadBookListToDataView(this.searchInput.Text.ToString());
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
                this.searchInput.ForeColor = Color.Black;

                this.loadBookListToDataView(this.searchInput.Text.ToString());
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
                this.searchInput.ForeColor = Color.Black;

                this.loadBookListToDataView(this.searchInput.Text.ToString());
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
                this.searchInput.ForeColor = Color.Black;

                this.loadBookListToDataView(this.searchInput.Text.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void AddBookToBillModal_Load(object sender, EventArgs e)
        {
            try
            {
                this.loadBookListToDataView("");
                this.loadAddBookBillListToDataView();

                this.loadAuthorCbx();
                this.loadBookTypeCbx();
                this.loadPublisherCbx();
                this.renderCheckBoxDgvBook();
                headerCheckbox.MouseClick += new MouseEventHandler(headerCheckbox_Clicked);

                this.renderCheckBoxDgvBookBillList();
                headerCheckboxBillList.MouseClick += new MouseEventHandler(headerCheckboxBillList_Clicked);
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

                this.priceFrom.Clear();
                this.priceTo.Clear();

                this.authorCbx.SelectedIndex = 0;
                this.bookTypeCbx.SelectedIndex = 0;
                this.publisherCbx.SelectedIndex = 0;

                this.loadBookListToDataView("");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void barcodeBtn_Click(object sender, EventArgs e)
        {
            using(ScannerModal scannerModal = new ScannerModal())
            {
                scannerModal.ShowDialog();

                if (scannerModal.scannedBook != null)
                {
                    try
                    {
                        int idx = this.selectedCustomerBillDetailList.FindIndex(
                                        book => book.MaSach == scannerModal.scannedBook.MaSach
                                    );

                        if (idx == -1)
                        {
                            CustomerBillDetailDTO customerBillDetail = new CustomerBillDetailDTO(
                                0,
                                scannerModal.scannedBook.MaSach,
                                1,
                                scannerModal.scannedBook.GiaBan
                            );

                            this.selectedCustomerBillDetailList.Add(customerBillDetail);
                        }
                        else
                        {

                            this.selectedCustomerBillDetailList[idx].SoLuong += 1;
                        }

                        foreach (DataGridViewRow row in this.dgvBook.Rows)
                        {
                            if (Convert.ToInt32(row.Cells[1].Value) == scannerModal.scannedBook.MaSach)
                            {
                                this.handleSubtractRemain(row, 1);
                                break;
                            }
                        }

                        MessageBox.Show("Đã thêm sách có mã " + scannerModal.scannedBook.MaSach + " vào danh sách thêm");
                        this.loadAddBookBillListToDataView();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
            }
        }

        private void handleSubtractRemain(DataGridViewRow row, int amount)
        {
            try
            {
                int idx = this.bookList.FindIndex(
                    book => book.MaSach == Convert.ToInt32(row.Cells[1].Value)
                );

                if (idx >= 0)
                {
                    this.bookList[idx].SoLuongConLai -= amount;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void handleAddRemain(DataGridViewRow row, int amount)
        {
            try
            {
                int idx = this.bookList.FindIndex(
                    book => book.MaSach == Convert.ToInt32(row.Cells[1].Value)
                );

                if (idx >= 0)
                {
                    this.bookList[idx].SoLuongConLai += amount;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void addToProductList_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Bạn chưa chọn những sách cần thêm vào danh sách sản phẩm cả");
                    return;
                }

                DialogResult dlgResult = MessageBox.Show(
                    "Bạn chắc chắn muốn thêm các sách đã chọn vào danh sách sản phẩm chứ?",
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
                            int maSach = Convert.ToInt32(row.Cells[1].Value.ToString());
                            double giaBan = Convert.ToDouble(row.Cells[7].Value.ToString());

                            int idx = this.selectedCustomerBillDetailList.FindIndex(
                                book => book.MaSach == maSach
                            );

                            if (idx == -1)
                            {
                                CustomerBillDetailDTO customerBillDetail = new CustomerBillDetailDTO(
                                    0,
                                    maSach,
                                    1,
                                    giaBan
                                );

                                this.selectedCustomerBillDetailList.Add(customerBillDetail);
                            }
                            else
                            {
                                this.selectedCustomerBillDetailList[idx].SoLuong += 1;
                            }

                            this.handleSubtractRemain(row, 1);

                        }
                    }

                    this.loadBookListToDataView((this.searchInput.Text.ToString()));
                    this.loadAddBookBillListToDataView();

                    headerCheckbox.Checked = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.isSaved = true;
            this.Close();
        }

        private void dgvAddBookToBillList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dgvAddBookToBillList.Columns[e.ColumnIndex].Name == "soLuong")
                {
                    BookDTO book = this.bookList.Find(
                        (b) => b.MaSach == Convert.ToInt32(this.dgvAddBookToBillList.Rows[e.RowIndex].Cells[1].Value)
                    );

                    Regex isNum = new Regex(@"^\d+$");

                    if (!isNum.IsMatch(this.dgvAddBookToBillList[e.ColumnIndex, e.RowIndex].Value.ToString()))
                    {
                        this.dgvAddBookToBillList[e.ColumnIndex, e.RowIndex].Value = this.selectedCustomerBillDetailList[e.RowIndex].SoLuong;
                        this.dgvAddBookToBillList.RefreshEdit();
                        MessageBox.Show("Số lượng là một số");
                        return;
                    }

                    int soLuong = Convert.ToInt32(this.dgvAddBookToBillList[e.ColumnIndex, e.RowIndex].Value);

                    if (soLuong <= 0 || book.SoLuongConLai < soLuong)
                    {
                        this.dgvAddBookToBillList[e.ColumnIndex, e.RowIndex].Value = this.selectedCustomerBillDetailList[e.RowIndex].SoLuong;
                        this.dgvAddBookToBillList.RefreshEdit();
                        return;
                    }

                    int tmp = this.selectedCustomerBillDetailList[e.RowIndex].SoLuong;

                    this.selectedCustomerBillDetailList[e.RowIndex].SoLuong = soLuong;

                    foreach (DataGridViewRow row in this.dgvBook.Rows)
                    {
                        if (Convert.ToInt32(row.Cells[1].Value) == book.MaSach)
                        {
                            this.handleAddRemain(row, tmp);
                            this.handleSubtractRemain(row, soLuong);
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void AddBookToBillModal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.isSaved)
            {
                this.selectedCustomerBillDetailList.Clear();
            }
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            try
            {
                bool isHaveSelect = false;

                foreach (DataGridViewRow row in this.dgvAddBookToBillList.Rows)
                {
                    if ((bool)row.Cells[0].Value)
                    {
                        isHaveSelect = true;
                        break;
                    }
                }

                if (!isHaveSelect)
                {
                    MessageBox.Show("Bạn chưa chọn những sách cần xóa khỏi danh sách mua hàng");
                    return;
                }

                DialogResult dlgResult = MessageBox.Show(
                    "Bạn chắc chắn muốn xóa các sách đã chọn khỏi danh sách mua hàng chứ?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1
                );

                if (dlgResult == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in this.dgvAddBookToBillList.Rows)
                    {
                        if ((bool)row.Cells[0].Value == true)
                        {
                            this.dgvAddBookToBillList.Rows.Remove(row);

                            int idx = this.selectedCustomerBillDetailList.FindIndex(
                                book => book.MaSach == Convert.ToInt32(row.Cells[1].Value)
                            );

                            if (idx >= 0)
                            {
                                this.selectedCustomerBillDetailList.RemoveAt(idx);

                                this.handleAddRemain(row, Convert.ToInt32(row.Cells[2].Value));
                            }
                        }
                    }

                    this.loadBookListToDataView((this.searchInput.Text.ToString()));

                    headerCheckbox.Checked = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
