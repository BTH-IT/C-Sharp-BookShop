using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;
using QuanLyCuaHangBanSach.GUI.Modal;
using static Guna.UI2.Native.WinApi;

namespace QuanLyCuaHangBanSach.GUI.Manager
{
    public partial class CustomerBillGUI : Form
    {
        private CheckBox headerCheckbox;

        public CustomerBillGUI()
        {
            InitializeComponent();
        }

        private void renderCheckBoxDgv()
        {
            int size = 25;
            DataGridViewCheckBoxColumn cbxColumn = new DataGridViewCheckBoxColumn();
            cbxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            cbxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            cbxColumn.MinimumWidth = 50;
            cbxColumn.ReadOnly = false;
            this.dgvCustomerBill.Columns.Insert(0, cbxColumn);

            Rectangle rect = this.dgvCustomerBill.GetCellDisplayRectangle(0, -1, false);


            headerCheckbox = new CheckBox();

            headerCheckbox.BackColor = Color.FromArgb(45, 210, 192);
            headerCheckbox.Name = "chkHeader";
            headerCheckbox.Size = new Size(size, size);

            rect.X = (rect.Width / 2) - (size / 4);
            rect.Y = (rect.Height / 2) - (size / 2);

            headerCheckbox.Location = rect.Location;


            this.dgvCustomerBill.Controls.Add(headerCheckbox);
        }

        private void loadCustomerBillListToDataView(List<CustomerBillDTO> customerBillList)
        {
            this.dgvCustomerBill.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 210, 192);
            this.dgvCustomerBill.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            this.dgvCustomerBill.Rows.Clear();

            CustomerDTO customer;
            SaleDTO sale;

            foreach (CustomerBillDTO customerBill in customerBillList)
            {
                customer = CustomerBUS.Instance.getById(customerBill.MaKhachHang.ToString());
                sale = SaleBUS.Instance.getById(customerBill.MaKhuyenMai.ToString());

                this.dgvCustomerBill.Rows.Add(new object[] {
                    customerBill.MaDonKhachHang,
                    customer.Ten,
                    customer.SoDienThoai,
                    StaffBUS.Instance.getById(customerBill.MaNhanVien.ToString()).Ten,
                    sale.TenKhuyenMai,
                    sale.PhanTram + "%",
                    customerBill.NgayLap.ToString(),
                    customerBill.TongTien,
                });
            }

        }

        private void loadCustomerCbx()
        {
            List<CustomerDTO> customerList = CustomerBUS.Instance.getAllData();

            customerList.Insert(0, new CustomerDTO(0, "Tất cả khách hàng", "", "", 0));

            this.customerCbx.ValueMember = "MaTacGia";
            this.customerCbx.DisplayMember = "TenTacGia";
            this.customerCbx.DataSource = customerList;

            this.customerCbx.SelectedIndex = 0;
        }

        private void loadBookTypeCbx()
        {
            List<BookTypeDTO> bookTypeList = BookTypeBUS.Instance.getAllData();

            bookTypeList.Insert(0, new BookTypeDTO(0, "Tất cả thể loại"));

            this.staffCbx.ValueMember = "MaTheLoai";
            this.staffCbx.DisplayMember = "TenTheLoai";
            this.staffCbx.DataSource = bookTypeList;
        }

        private void loadPublisherCbx()
        {
            List<PublisherDTO> publisherList = PublisherBUS.Instance.getAllData();

            publisherList.Insert(0, new PublisherDTO(0, "Tất cả nhà xuất bản", "", ""));

            this.saleCbx.ValueMember = "MaNhaXuatBan";
            this.saleCbx.DisplayMember = "TenNhaXuatBan";
            this.saleCbx.DataSource = publisherList;
        }

        private void BookManageGUI_Load(object sender, EventArgs e)
        {

            List<BookDTO> bookList = BookBUS.Instance.getAllData();
            this.loadBookListToDataView(bookList);

            this.loadCustomerCbx();
            this.loadBookTypeCbx();
            this.loadPublisherCbx();
            this.renderCheckBoxDgv();
            headerCheckbox.MouseClick += new MouseEventHandler(headerCheckbox_Clicked);
        }

        private void headerCheckbox_Clicked(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dgvCustomerBill.Rows)
            {
                row.Cells[0].Value = headerCheckbox.Checked;
            }

            this.dgvCustomerBill.RefreshEdit();
        }

        private List<BookDTO> handleFilter(string searchText)
        {
            if (searchText == "Enter your search...")
            {
                searchText = "";
            }

            List<BookDTO> bookList = BookBUS.Instance.search(searchText);

            if (this.fromPriceTxt.Text.ToString() != "Enter price from"
                && this.toPriceTxt.Text.ToString() != "Enter price to"
                && this.fromPriceTxt.Text.ToString() != string.Empty
                && this.toPriceTxt.Text.ToString() != string.Empty)
            {
                try
                {
                    bookList = bookList.FindAll(
                        item => item.GiaBan >= Convert.ToDouble(this.fromPriceTxt.Text.ToString())
                                && item.GiaBan <= Convert.ToDouble(this.toPriceTxt.Text.ToString()
                    ));
                }
                catch
                {
                    MessageBox.Show("Giá phải là số");
                }
            }

            int authorId = Convert.ToInt32(this.customerCbx.SelectedValue);
            int bookTypeId = Convert.ToInt32(this.staffCbx.SelectedValue);
            int publisherId = Convert.ToInt32(this.saleCbx.SelectedValue);

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

        private void searchInput_Click(object sender, EventArgs e)
        {
            if (this.searchInput.Text.Equals("Enter your search..."))
            {
                this.searchInput.Text = "";

            }
        }

        private void searchInput_Leave(object sender, EventArgs e)
        {
            if (this.searchInput.Text.Length <= 0)
            {
                this.searchInput.Text = "Enter your search...";
                this.searchInput.ForeColor = Color.LightGray;

                List<BookDTO> bookList = handleFilter(this.searchInput.Text.ToString());

                this.loadBookListToDataView(bookList);
            }
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
            this.searchInput.Text = "Enter your search...";
            this.searchInput.ForeColor = Color.LightGray;

            this.fromPriceTxt.Text = "Enter price from";
            this.fromPriceTxt.ForeColor = Color.LightGray;

            this.toPriceTxt.Text = "Enter price to";
            this.toPriceTxt.ForeColor = Color.LightGray;

            this.customerCbx.SelectedIndex = 0;
            this.staffCbx.SelectedIndex = 0;
            this.saleCbx.SelectedIndex = 0;

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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.fromPriceTxt.ForeColor = Color.Black;

            List<BookDTO> bookList = handleFilter(this.searchInput.Text.ToString());

            this.loadBookListToDataView(bookList);
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (this.fromPriceTxt.Text.Length <= 0)
            {
                this.fromPriceTxt.Text = "Enter price from";
                this.fromPriceTxt.ForeColor = Color.LightGray;

                List<BookDTO> bookList = handleFilter(this.searchInput.Text.ToString());

                this.loadBookListToDataView(bookList);
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (this.fromPriceTxt.Text.Equals("Enter price from"))
            {
                this.fromPriceTxt.Text = "";

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.toPriceTxt.ForeColor = Color.Black;

            List<BookDTO> bookList = handleFilter(this.searchInput.Text.ToString());

            this.loadBookListToDataView(bookList);
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (this.toPriceTxt.Text.Length <= 0)
            {
                this.toPriceTxt.Text = "Enter price to";
                this.toPriceTxt.ForeColor = Color.LightGray;

                List<BookDTO> bookList = handleFilter(this.searchInput.Text.ToString());

                this.loadBookListToDataView(bookList);
            }
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            if (this.toPriceTxt.Text.Equals("Enter price to"))
            {
                this.toPriceTxt.Text = "";

            }
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
            if (this.dgvCustomerBill.CurrentCell.RowIndex < 0)
            {
                MessageBox.Show("Hãy chọn dòng dữ liệu muốn thao tác");
                return;
            }

            using (BookModal bookModal = new BookModal("Sửa sách"))
            {
                DataGridViewRow row = this.dgvCustomerBill.Rows[this.dgvCustomerBill.CurrentCell.RowIndex];

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

            foreach (DataGridViewRow row in this.dgvCustomerBill.Rows)
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
                foreach (DataGridViewRow row in this.dgvCustomerBill.Rows)
                {
                    if ((bool)row.Cells[0].Value == true)
                    {
                        if (BookBUS.Instance.delete(row.Cells[1].Value.ToString()))
                        {

                            List<BookDTO> bookList = handleFilter(this.searchInput.Text.ToString());

                            this.loadBookListToDataView(bookList);

                            row.Cells[0].Value = false;
                        }
                    }

                }

                this.dgvCustomerBill.RefreshEdit();
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
                DataGridViewRow row = this.dgvCustomerBill.Rows[e.RowIndex];

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
