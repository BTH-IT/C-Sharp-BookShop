using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;
using QuanLyCuaHangBanSach.GUI.Modal;

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

                if (sale == null)
                {
                    this.dgvCustomerBill.Rows.Add(new object[] {
                        false,
                        customerBill.MaDonKhachHang,
                        customer.Ten,
                        customer.SoDienThoai,
                        StaffBUS.Instance.getById(customerBill.MaNhanVien.ToString()).Ten,
                        "Không có",
                        "0",
                        customerBill.NgayLap.GetDateTimeFormats()[0],
                        customerBill.TongTien,
                    });
                } else
                {
                    this.dgvCustomerBill.Rows.Add(new object[] {
                        false,
                        customerBill.MaDonKhachHang,
                        customer.Ten,
                        customer.SoDienThoai,
                        StaffBUS.Instance.getById(customerBill.MaNhanVien.ToString()).Ten,
                        sale.TenKhuyenMai,
                        sale.PhanTram + "%",
                        customerBill.NgayLap.GetDateTimeFormats()[0],
                        customerBill.TongTien,
                    });
                }
            }

        }

        private void loadCustomerCbx()
        {
            List<CustomerDTO> customerList = CustomerBUS.Instance.getAllData();

            customerList.Insert(0, new CustomerDTO(0, "", "Tất cả khách hàng", "", 0));

            this.customerCbx.ValueMember = "Ma";
            this.customerCbx.DisplayMember = "SoDienThoai";
            this.customerCbx.DataSource = customerList;

            this.customerCbx.SelectedIndex = 0;
        }

        private void loadStaffCbx()
        {
            List<StaffDTO> staffList = StaffBUS.Instance.getAllData();

            staffList.Insert(0, new StaffDTO(0, "Tất cả nhân viên", "", "", 0, 0, ""));

            this.staffCbx.ValueMember = "Ma";
            this.staffCbx.DisplayMember = "Ten";
            this.staffCbx.DataSource = staffList;

            this.staffCbx.SelectedIndex = 0;
        }

        private void loadSaleCbx()
        {
            List<SaleDTO> saleList = SaleBUS.Instance.getAllData();

            saleList.Insert(0, new SaleDTO(0, "Tất cả khuyến mãi", 0, new DateTime(), new DateTime()));
            saleList.Insert(1, new SaleDTO(-1, "Không có khuyến mãi", 0, new DateTime(), new DateTime()));

            this.saleCbx.ValueMember = "MaKhuyenMai";
            this.saleCbx.DisplayMember = "TenKhuyenMai";
            this.saleCbx.DataSource = saleList;

            this.saleCbx.SelectedIndex = 0;
        }

        private void CustomerBillGUI_Load(object sender, EventArgs e)
        {
            this.dateTimeFrom.Enabled = this.filterCkx.Checked;
            this.dateTimeTo.Enabled = this.filterCkx.Checked;

            List<CustomerBillDTO> customerBillList = CustomerBillBUS.Instance.getAllData();
            this.loadCustomerBillListToDataView(customerBillList);

            this.loadCustomerCbx();
            this.loadStaffCbx();
            this.loadSaleCbx();
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

        private List<CustomerBillDTO> handleFilter(string searchText)
        {
            if (searchText == "Enter your search...")
            {
                searchText = "";
            }

            List<CustomerBillDTO> customerBillList = CustomerBillBUS.Instance.search(searchText);

            if (this.fromPriceTxt.Text.ToString() != "Enter price from"
                && this.toPriceTxt.Text.ToString() != "Enter price to"
                && this.fromPriceTxt.Text.ToString() != string.Empty
                && this.toPriceTxt.Text.ToString() != string.Empty)
            {
                try
                {
                    customerBillList = customerBillList.FindAll(
                        item => item.TongTien >= Convert.ToDouble(this.fromPriceTxt.Text.ToString())
                                && item.TongTien <= Convert.ToDouble(this.toPriceTxt.Text.ToString())
                    );
                }
                catch
                {
                    MessageBox.Show("Tổng tiền phải là số");
                }
            }

            if (DateTime.Compare(this.dateTimeFrom.Value, this.dateTimeTo.Value) <= 0 && this.filterCkx.Checked)
            {
                try
                {
                    customerBillList = customerBillList.FindAll(
                        item => (DateTime.Compare(item.NgayLap, this.dateTimeFrom.Value) >= 0)
                                && (DateTime.Compare(item.NgayLap, this.dateTimeTo.Value) <= 0)
                    );
                }
                catch
                {
                    MessageBox.Show("Lọc theo khoảng ngày không hợp lệ");
                }
            }

            int customerId = Convert.ToInt32(this.customerCbx.SelectedValue);
            int staffId = Convert.ToInt32(this.staffCbx.SelectedValue);
            int saleId = Convert.ToInt32(this.saleCbx.SelectedValue);

            List<CustomerBillDTO> newCustomerBillList = customerBillList.FindAll(customerBill =>
            {
                if (customerId != 0 && staffId != 0 && saleId != 0)
                {
                    return customerBill.MaKhachHang == customerId &&
                           customerBill.MaNhanVien == staffId &&
                           customerBill.MaKhuyenMai == saleId;
                }

                if (customerId == 0 && staffId != 0 && saleId != 0)
                {
                    return customerBill.MaNhanVien == staffId &&
                           customerBill.MaKhuyenMai == saleId;
                }

                if (customerId == 0 && staffId == 0 && saleId != 0)
                {
                    return customerBill.MaKhuyenMai == saleId;
                }

                if (customerId == 0 && staffId != 0 && saleId == 0)
                {
                    return customerBill.MaNhanVien == staffId;
                }

                if (customerId != 0 && staffId == 0 && saleId == 0)
                {
                    return customerBill.MaKhachHang == customerId;
                }

                if (customerId != 0 && staffId != 0 && saleId == 0)
                {
                    return customerBill.MaKhachHang == customerId &&
                           customerBill.MaNhanVien == staffId;
                }

                if (customerId != 0 && staffId == 0 && saleId != 0)
                {
                    return customerBill.MaKhachHang == customerId &&
                           customerBill.MaKhuyenMai == saleId;
                }

                return true;
            });


            return newCustomerBillList;
        }

        private void searchInput_TextChanged(object sender, EventArgs e)
        {
            this.searchInput.ForeColor = Color.Black;

            List<CustomerBillDTO> customerBillList = handleFilter(this.searchInput.Text.ToString());

            this.loadCustomerBillListToDataView(customerBillList);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            using (BookModal customerBillModal = new BookModal())
            {
                customerBillModal.ShowDialog();


                if (customerBillModal.isSubmitSuccess)
                {
                    List<CustomerBillDTO> customerBillList = handleFilter(this.searchInput.Text.ToString());

                    this.loadCustomerBillListToDataView(customerBillList);
                }
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
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

            this.filterCkx.Checked = false;
            this.dateTimeFrom.Enabled = false;
            this.dateTimeTo.Enabled = false;

            List<CustomerBillDTO> customerBillList = handleFilter("");

            this.loadCustomerBillListToDataView(customerBillList);
        }

        private void customerCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<CustomerBillDTO> customerBillList = handleFilter(this.searchInput.Text.ToString());

            this.loadCustomerBillListToDataView(customerBillList);
        }

        private void staffCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<CustomerBillDTO> customerBillList = handleFilter(this.searchInput.Text.ToString());

            this.loadCustomerBillListToDataView(customerBillList);
        }

        private void saleCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<CustomerBillDTO> customerBillList = handleFilter(this.searchInput.Text.ToString());

            this.loadCustomerBillListToDataView(customerBillList);
        }

        private void fromPriceTxt_TextChanged(object sender, EventArgs e)
        {
            this.fromPriceTxt.ForeColor = Color.Black;

            List<CustomerBillDTO> customerBillList = handleFilter(this.searchInput.Text.ToString());

            this.loadCustomerBillListToDataView(customerBillList);
        }

        private void toPriceTxt_TextChanged(object sender, EventArgs e)
        {
            this.toPriceTxt.ForeColor = Color.Black;

            List<CustomerBillDTO> customerBillList = handleFilter(this.searchInput.Text.ToString());

            this.loadCustomerBillListToDataView(customerBillList);
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            List<CustomerBillDTO> customerBillList = handleFilter(this.searchInput.Text.ToString());

            DataTable dataTable = CustomExcel.Instance.ConvertListToDataTable(customerBillList);

            string[] headerList = new string[] { "Mã sách", "Tên sách", "Tác giả", "Thể loại", "Nhà xuất bản", "Giá bán", "Giá nhập", "Năm xuất bản", "Còn lại" };

            CustomExcel.Instance.ExportFile(dataTable, "Customer Bill Manage", "Cửa hàng bán sách", headerList, 2);
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (this.dgvCustomerBill.CurrentCell.RowIndex < 0)
            {
                MessageBox.Show("Hãy chọn dòng dữ liệu muốn thao tác");
                return;
            }

            DataGridViewRow row = this.dgvCustomerBill.Rows[this.dgvCustomerBill.CurrentCell.RowIndex];
            
            using (CustomerBillModal customerBillModal = new CustomerBillModal(Convert.ToInt32(row.Cells[1].Value)))
            {
                BookDTO customerBill = BookBUS.Instance.getById(row.Cells[1].Value.ToString());

                customerBillModal.ShowDialog();

                /*if (customerBillModal.isSubmitSuccess)
                {
                    List<CustomerBillDTO> customerBillList = handleFilter(this.searchInput.Text.ToString());

                    this.loadCustomerBillListToDataView(customerBillList);
                }*/
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
                MessageBox.Show("Bạn chưa chọn những đơn hàng cần xóa");
                return;
            }

            DialogResult dlgResult = MessageBox.Show(
                "Bạn chắc chắn muốn xóa các đơn hàng đã chọn chứ chứ?",
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
                            List<CustomerBillDTO> customerBillList = handleFilter(this.searchInput.Text.ToString());

                            this.loadCustomerBillListToDataView(customerBillList);

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
        }

        private void dateTimeFrom_ValueChanged(object sender, EventArgs e)
        {
            bool isValid = DateTime.Compare(dateTimeFrom.Value, dateTimeTo.Value) > 0;

            if (isValid)
            {
                dateTimeFrom.Value = dateTimeTo.Value;
                MessageBox.Show("Bạn không thể chọn ngày lớn hơn ngày " + dateTimeTo.Value.GetDateTimeFormats()[0]);
                return;
            }

            List<CustomerBillDTO> customerBillList = handleFilter(this.searchInput.Text.ToString());

            this.loadCustomerBillListToDataView(customerBillList);
        }

        private void dateTimeTo_ValueChanged(object sender, EventArgs e)
        {
            bool isValid = DateTime.Compare(dateTimeTo.Value, dateTimeFrom.Value) < 0;

            if (isValid)
            {
                dateTimeTo.Value = dateTimeFrom.Value;
                MessageBox.Show("Bạn không thể chọn ngày nhỏ hơn ngày " + dateTimeFrom.Value.GetDateTimeFormats()[0]);
                return;
            }

            List<CustomerBillDTO> customerBillList = handleFilter(this.searchInput.Text.ToString());

            this.loadCustomerBillListToDataView(customerBillList);
        }

        private void filterCkx_CheckedChanged(object sender, EventArgs e)
        {
            this.dateTimeFrom.Enabled = this.filterCkx.Checked;
            this.dateTimeTo.Enabled = this.filterCkx.Checked;
        }
    }
}
