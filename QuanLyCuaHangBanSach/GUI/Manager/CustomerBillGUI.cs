using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;
using QuanLyCuaHangBanSach.GUI.Modal;
using QuanLyCuaHangBanSach.GUI.Report;

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
                    if (customer == null)
                    {
                        this.dgvCustomerBill.Rows.Add(new object[] {
                            false,
                            customerBill.MaDonKhachHang,
                            "Không có",
                            "Không có",
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
                            "Không có",
                            "0",
                            customerBill.NgayLap.GetDateTimeFormats()[0],
                            customerBill.TongTien,
                        });
                    }
                } else
                {
                    if (customer == null)
                    {
                        this.dgvCustomerBill.Rows.Add(new object[] {
                            false,
                            customerBill.MaDonKhachHang,
                            "Không có",
                            "Không có",
                            StaffBUS.Instance.getById(customerBill.MaNhanVien.ToString()).Ten,
                            sale.TenKhuyenMai,
                            sale.PhanTram + "%",
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

        }

        private void loadCustomerCbx()
        {
            List<CustomerDTO> customerList = CustomerBUS.Instance.getAllData();

            customerList.Insert(0, new CustomerDTO(-1, "", "Tất cả khách hàng", "", 0, 0));
            customerList.Insert(1, new CustomerDTO(0, "", "Không có", "", 0, 0));

            this.customerCbx.ValueMember = "Ma";
            this.customerCbx.DisplayMember = "SoDienThoai";
            this.customerCbx.DataSource = customerList;

            this.customerCbx.SelectedIndex = 0;
        }

        private void loadStaffCbx()
        {
            List<StaffDTO> staffList = StaffBUS.Instance.getAllData();

            staffList.Insert(0, new StaffDTO(0, "Tất cả nhân viên", "", "", 0, 0, 0));

            this.staffCbx.ValueMember = "Ma";
            this.staffCbx.DisplayMember = "Ten";
            this.staffCbx.DataSource = staffList;

            this.staffCbx.SelectedIndex = 0;
        }

        private void loadSaleCbx()
        {
            List<SaleDTO> saleList = SaleBUS.Instance.getAllData();

            saleList.Insert(0, new SaleDTO(-1, "Tất cả khuyến mãi", 0, new DateTime(), new DateTime()));
            saleList.Insert(1, new SaleDTO(0, "Không có khuyến mãi", 0, new DateTime(), new DateTime()));

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
            List<CustomerBillDTO> customerBillList = CustomerBillBUS.Instance.search(searchText);

            if (this.fromPriceTxt.Text.ToString() != string.Empty
                && this.toPriceTxt.Text.ToString() != string.Empty)
            {
                Regex isNum = new Regex(@"^\d+$");

                if (!isNum.IsMatch(this.fromPriceTxt.Text.ToString()) || !isNum.IsMatch(this.toPriceTxt.Text.ToString()))
                {
                    this.fromPriceTxt.Clear();
                    this.toPriceTxt.Clear();
                    MessageBox.Show("Tổng tiền là một số dương");
                }
                else
                {
                    customerBillList = customerBillList.FindAll(
                        item => item.TongTien >= Convert.ToDouble(this.fromPriceTxt.Text.ToString())
                                && item.TongTien <= Convert.ToDouble(this.toPriceTxt.Text.ToString()
                    ));
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
                    MessageBox.Show("Lọc theo khoảng thời gian không hợp lệ");
                }
            }

            int customerId = Convert.ToInt32(this.customerCbx.SelectedValue);
            int staffId = Convert.ToInt32(this.staffCbx.SelectedValue);
            int saleId = Convert.ToInt32(this.saleCbx.SelectedValue);

            List<CustomerBillDTO> newCustomerBillList = customerBillList.FindAll(customerBill =>
            {
                if (customerId != -1 && staffId != 0 && saleId != -1)
                {
                    return customerBill.MaKhachHang == customerId &&
                           customerBill.MaNhanVien == staffId &&
                           customerBill.MaKhuyenMai == saleId;
                }

                if (customerId == -1 && staffId != 0 && saleId != -1)
                {
                    return customerBill.MaNhanVien == staffId &&
                           customerBill.MaKhuyenMai == saleId;
                }

                if (customerId == -1 && staffId == 0 && saleId != -1)
                {
                    return customerBill.MaKhuyenMai == saleId;
                }

                if (customerId == -1 && staffId != 0 && saleId == -1)
                {
                    return customerBill.MaNhanVien == staffId;
                }

                if (customerId != -1 && staffId == 0 && saleId == -1)
                {
                    return customerBill.MaKhachHang == customerId;
                }

                if (customerId != -1 && staffId != 0 && saleId == -1)
                {
                    return customerBill.MaKhachHang == customerId &&
                           customerBill.MaNhanVien == staffId;
                }

                if (customerId != -1 && staffId == 0 && saleId != -1)
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
            this.searchInput.Clear();
            this.fromPriceTxt.Clear();
            this.toPriceTxt.Clear();

            this.customerCbx.SelectedIndex = 0;
            this.staffCbx.SelectedIndex = 0;
            this.saleCbx.SelectedIndex = 0;

            this.filterCkx.Checked = false;
            this.dateTimeFrom.Enabled = false;
            this.dateTimeTo.Enabled = false;

            this.dateTimeFrom.Refresh();
            this.dateTimeTo.Refresh();

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
            List<CustomerBillDTO> customerBillList = handleFilter(this.searchInput.Text.ToString());

            this.loadCustomerBillListToDataView(customerBillList);
        }

        private void toPriceTxt_TextChanged(object sender, EventArgs e)
        {
            List<CustomerBillDTO> customerBillList = handleFilter(this.searchInput.Text.ToString());

            this.loadCustomerBillListToDataView(customerBillList);
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            List<CustomerBillDTO> customerBillList = handleFilter(this.searchInput.Text.ToString());

            DataTable dataTable = CustomExcel.Instance.ConvertListToDataTable(customerBillList);

            string[] headerList = new string[] { "Mã đơn", "Tên khách hàng", "Số điện thoại khách hàng", "Nhân Viên", "Khuyến mãi", "Giá bán", "Phần trăm", "Ngày lập", "Tổng tiền" };

            CustomExcel.Instance.ExportFile(dataTable, "Customer Bill Manage", "Cửa hàng bán sách", headerList);
        }

        private void viewMoreBtn_Click(object sender, EventArgs e)
        {
            if (this.dgvCustomerBill.CurrentCell.RowIndex < 0)
            {
                MessageBox.Show("Hãy chọn dòng dữ liệu muốn thao tác");
                return;
            }

            DataGridViewRow row = this.dgvCustomerBill.Rows[this.dgvCustomerBill.CurrentCell.RowIndex];

            CustomerBillDTO customerBill = CustomerBillBUS.Instance.getById(row.Cells[1].Value.ToString());
            
            using (ViewCustomerBillModal viewCustomerBillModal = new ViewCustomerBillModal(customerBill))
            {
                viewCustomerBillModal.ShowDialog();
            }
        }

        private bool isCheckSeletedRows()
        {
            foreach (DataGridViewRow row in this.dgvCustomerBill.Rows)
            {
                if ((bool)row.Cells[0].Value)
                {
                    return true;
                }
            }

            MessageBox.Show("Bạn chưa chọn những đơn hàng cần xóa");
            return false;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (!isCheckSeletedRows()) return;

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
                        BookBUS.Instance.delete(row.Cells[1].Value.ToString());
                    }

                }

                List<CustomerBillDTO> customerBillList = handleFilter(this.searchInput.Text.ToString());

                this.loadCustomerBillListToDataView(customerBillList);

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

        private void printPdfBtn_Click(object sender, EventArgs e)
        {
            if (this.dgvCustomerBill.CurrentCell.RowIndex < 0)
            {
                MessageBox.Show("Hãy chọn dòng dữ liệu muốn thao tác");
                return;
            }

            DataGridViewRow row = this.dgvCustomerBill.Rows[this.dgvCustomerBill.CurrentCell.RowIndex];

            using (CustomerBillPrintForm customerBillPrintForm = new CustomerBillPrintForm(Convert.ToInt32(row.Cells[1].Value)))
            {
                customerBillPrintForm.ShowDialog();
            }
        }
    }
}
