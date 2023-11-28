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
            try
            {
                int size = 25;
                Rectangle rect = this.dgvCustomerBill.GetCellDisplayRectangle(0, -1, false);

                headerCheckbox = new CheckBox();

                headerCheckbox.BackColor = Color.FromArgb(45, 210, 192);
                headerCheckbox.Name = "chkHeader";
                headerCheckbox.Size = new Size(size, size);
                headerCheckbox.TabStop = false; ;

                rect.X = (rect.Width / 2) - (size / 4);
                rect.Y = (rect.Height / 2) - (size / 2);

                headerCheckbox.Location = rect.Location;

                this.dgvCustomerBill.Controls.Add(headerCheckbox);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void loadCustomerBillListToDataView(List<CustomerBillDTO> customerBillList)
        {
            try
            {
                this.dgvCustomerBill.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 210, 192);
                this.dgvCustomerBill.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				this.dgvCustomerBill.ColumnHeadersDefaultCellStyle.Font = new Font("#9Slide03 Cabin", 10, FontStyle.Regular);
				this.dgvCustomerBill.Rows.Clear();

                CustomerDTO customer;
                SaleDTO sale;

                foreach (CustomerBillDTO customerBill in customerBillList)
                {
                    customer = CustomerBUS.Instance.getById(customerBill.MaKhachHang.ToString());

                    sale = SaleBUS.Instance.getById(customerBill.MaKhuyenMai.ToString());

					this.dgvCustomerBill.Rows.Add(new object[] {
						false,
						customerBill.MaDonKhachHang,
						customer.Ten,
						customer.SoDienThoai == "0" ? "Không có" : customer.SoDienThoai,
						StaffBUS.Instance.getById(customerBill.MaNhanVien.ToString()).Ten,
						sale.TenKhuyenMai,
						customerBill.PhanTramKhuyenMai + "%",
						customerBill.NgayLap.GetDateTimeFormats()[0],
						string.Format("{0:N0} VNĐ", customerBill.TongTien),
					});

				}
			}
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void loadCustomerCbx()
        {
            try
            {
                List<CustomerDTO> customerList = CustomerBUS.Instance.getAllData();
                
                customerList.Insert(0, new CustomerDTO(-1, "Tất cả khách hàng", "", 0, "Tất cả khách hàng", 0));
                 
                this.customerCbx.ValueMember = "Ma";
                this.customerCbx.DisplayMember = "Ten";
                this.customerCbx.DataSource = customerList;

                this.customerCbx.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void loadStaffCbx()
        {
            try
            {
                List<StaffDTO> staffList = StaffBUS.Instance.getAllData();

                staffList.Insert(0, new StaffDTO(0, "Tất cả nhân viên", "", "", 0, 0, 0));

                this.staffCbx.ValueMember = "Ma";
                this.staffCbx.DisplayMember = "Ten";
                this.staffCbx.DataSource = staffList;

                this.staffCbx.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void loadSaleCbx()
        {
            try
            {
                List<SaleDTO> saleList = SaleBUS.Instance.getAllData();

                saleList.Insert(0, new SaleDTO(-1, "Tất cả khuyến mãi", 0, new DateTime(), new DateTime()));
              

                this.saleCbx.ValueMember = "MaKhuyenMai";
                this.saleCbx.DisplayMember = "TenKhuyenMai";
                this.saleCbx.DataSource = saleList;

                this.saleCbx.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void CustomerBillGUI_Load(object sender, EventArgs e)
        {
            try
            {
                this.dateTimeFrom.Enabled = this.filterCkx.Checked;
                this.dateTimeTo.Enabled = this.filterCkx.Checked;

                this.fromPriceTxt.Enabled = this.gunaMediumCheckBox1.Checked;
                this.toPriceTxt.Enabled = this.gunaMediumCheckBox1.Checked;

                List<CustomerBillDTO> customerBillList = CustomerBillBUS.Instance.getAllData();
                this.loadCustomerBillListToDataView(customerBillList);

                this.loadCustomerCbx();
                this.loadStaffCbx();
                this.loadSaleCbx();
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
                foreach (DataGridViewRow row in this.dgvCustomerBill.Rows)
                {
                    row.Cells[0].Value = headerCheckbox.Checked;
                }

                this.dgvCustomerBill.RefreshEdit();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private List<CustomerBillDTO> handleFilter(string searchText)
        {
            try
            {
                List<CustomerBillDTO> customerBillList = CustomerBillBUS.Instance.search(searchText);

                if (this.fromPriceTxt.Text.ToString() != string.Empty
                    && this.toPriceTxt.Text.ToString() != string.Empty && this.gunaMediumCheckBox1.Checked)
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
                        if (Convert.ToDecimal(this.fromPriceTxt.Text.ToString()) > Convert.ToDecimal(this.toPriceTxt.Text.ToString()))
                        {
                            MessageBox.Show("Tổng tiền từ phải bé hơn hoặc bằng tổng tiền đến");
                            this.fromPriceTxt.Clear();
                            this.toPriceTxt.Clear();
                        }
                        else
                        {
                            customerBillList = customerBillList.FindAll(
                                item => item.TongTien >= Convert.ToDecimal(this.fromPriceTxt.Text.ToString())
                                        && item.TongTien <= Convert.ToDecimal(this.toPriceTxt.Text.ToString()
                            ));
                        }
                    }
                }

                if (DateTime.Compare(this.dateTimeFrom.Value, this.dateTimeTo.Value) <= 0 && this.filterCkx.Checked)
                {
          
					try
                    {
						DateTime dateTimeFromV = new DateTime(dateTimeFrom.Value.Year, dateTimeFrom.Value.Month, dateTimeFrom.Value.Day, 0, 0, 0);
						DateTime dateTimeToV = new DateTime(dateTimeTo.Value.Year, dateTimeTo.Value.Month, dateTimeTo.Value.Day, 0, 0, 0);
						customerBillList = customerBillList.FindAll(
                            item => (DateTime.Compare(item.NgayLap, dateTimeFromV) >= 0)
                                    && (DateTime.Compare(item.NgayLap,dateTimeToV) <= 0)
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
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return new List<CustomerBillDTO>();
            }
        }

        private void searchInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<CustomerBillDTO> customerBillList = handleFilter(this.searchInput.Text.Trim());

                this.loadCustomerBillListToDataView(customerBillList);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            using (CustomerBillModal customerBillModal = new CustomerBillModal(ManagerGUI.currentStaff.Ma))
            {
                customerBillModal.ShowDialog();


                if (customerBillModal.isSubmitSuccess)
                {
                    List<CustomerBillDTO> customerBillList = handleFilter(this.searchInput.Text.Trim());

                    this.loadCustomerBillListToDataView(customerBillList);
                }
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.gunaMediumCheckBox1.Checked = false;
                this.searchInput.Clear();
                this.fromPriceTxt.Clear();
                this.toPriceTxt.Clear();
                this.fromPriceTxt.Enabled = false;
                this.toPriceTxt.Enabled = false;

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
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void customerCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<CustomerBillDTO> customerBillList = handleFilter(this.searchInput.Text.Trim());

                this.loadCustomerBillListToDataView(customerBillList);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void staffCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<CustomerBillDTO> customerBillList = handleFilter(this.searchInput.Text.Trim());

                this.loadCustomerBillListToDataView(customerBillList);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void saleCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<CustomerBillDTO> customerBillList = handleFilter(this.searchInput.Text.Trim());

                this.loadCustomerBillListToDataView(customerBillList);
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
                    List<CustomerBillDTO> customerBillList = handleFilter(this.searchInput.Text.Trim());

                    this.loadCustomerBillListToDataView(customerBillList);
                }
            }
        }

        private void fromPriceTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<CustomerBillDTO> customerBillList = handleFilter(this.searchInput.Text.Trim());

                this.loadCustomerBillListToDataView(customerBillList);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void toPriceTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<CustomerBillDTO> customerBillList = handleFilter(this.searchInput.Text.Trim());

                this.loadCustomerBillListToDataView(customerBillList);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            if (dgvCustomerBill.Rows.Count <= 0)
            {
                MessageBox.Show("Bảng dữ liệu hiện tại chưa có dòng dữ liệu nào để xuất excel!");
                return;
            }

            try
            {

                string[] headerList = new string[] { "Mã đơn", "Tên khách hàng", "Số điện thoại khách hàng", "Nhân Viên", "Khuyến mãi", "Phần trăm", "Ngày lập", "Tổng tiền" };

                DataTable dt = CustomExcel.Instance.ConvertDataGridViewToDataTable(dgvCustomerBill);

                CustomExcel.Instance.ExportFileDatagridView(dt, "Book Manage", 1, "Cửa hàng bán sách", headerList);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void viewMoreBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.dgvCustomerBill.CurrentCell != null)
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
                else
                {
                    MessageBox.Show("Bảng dữ liệu có thể chưa có dòng dữ liệu nào để xem chi tiết");
                }  
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private bool isCheckSeletedRows()
        {
            try
            {
                foreach (DataGridViewRow row in this.dgvCustomerBill.Rows)
                {
                    if ((bool)row.Cells[0].Value)
                    {
                        return true;
                    }
                }

                MessageBox.Show("Bạn chưa chọn những đơn hàng cần xóa");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return false;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
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
                            CustomerBillBUS.Instance.delete(row.Cells[1].Value.ToString());
                        }

                    }

                    List<CustomerBillDTO> customerBillList = handleFilter(this.searchInput.Text.Trim());

                    this.loadCustomerBillListToDataView(customerBillList);

                    MessageBox.Show("Delete successful");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void dateTimeFrom_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                bool isValid = DateTime.Compare(dateTimeFrom.Value, dateTimeTo.Value) > 0;

                if (isValid)
                {
                    dateTimeFrom.Value = dateTimeTo.Value;
                    MessageBox.Show("Bạn không thể chọn ngày lớn hơn ngày " + dateTimeTo.Value.GetDateTimeFormats()[0]);
                    return;
                }

                List<CustomerBillDTO> customerBillList = handleFilter(this.searchInput.Text.Trim());

                this.loadCustomerBillListToDataView(customerBillList);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void dateTimeTo_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                bool isValid = DateTime.Compare(dateTimeTo.Value, dateTimeFrom.Value) < 0;

                if (isValid)
                {
                    dateTimeTo.Value = dateTimeFrom.Value;
                    MessageBox.Show("Bạn không thể chọn ngày nhỏ hơn ngày " + dateTimeFrom.Value.GetDateTimeFormats()[0]);
                    return;
                }

                List<CustomerBillDTO> customerBillList = handleFilter(this.searchInput.Text.Trim());

                this.loadCustomerBillListToDataView(customerBillList);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void filterCkx_CheckedChanged(object sender, EventArgs e)
        {
            this.dateTimeFrom.Enabled = this.filterCkx.Checked;
            this.dateTimeTo.Enabled = this.filterCkx.Checked;
			List<CustomerBillDTO> customerBillList = handleFilter(this.searchInput.Text.Trim());

			this.loadCustomerBillListToDataView(customerBillList);
		}

        private void printPdfBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.dgvCustomerBill.CurrentCell != null) 
                {
					if (this.dgvCustomerBill.CurrentCell.RowIndex < 0 || this.dgvCustomerBill.CurrentCell == null)
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
                else
                {
                    MessageBox.Show("Bảng dữ liệu có thể chưa có dòng dữ liệu nào để in");
                }
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void dgvCustomerBill_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            if (e.Column.Index == dgvCustomerBill.Columns.Count - 1) // Check if sorting the last column
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

            if (double.TryParse(stringValue, out double numericValue))
            {
                // Convert the numeric value to a sortable string
                return numericValue;
            }

            return 0;
        }

        private void dgvCustomerBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0 || e.ColumnIndex <= 0)
                {
                    return;
                }

                DataGridViewRow row = this.dgvCustomerBill.Rows[e.RowIndex];

                CustomerBillDTO customerBill = CustomerBillBUS.Instance.getById(row.Cells[1].Value.ToString());

                using (ViewCustomerBillModal viewCustomerBillModal = new ViewCustomerBillModal(customerBill))
                {
                    viewCustomerBillModal.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaMediumCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.fromPriceTxt.Enabled = this.gunaMediumCheckBox1.Checked;
            this.toPriceTxt.Enabled = this.gunaMediumCheckBox1.Checked;
            List<CustomerBillDTO> list = handleFilter(this.searchInput.Text);
            loadCustomerBillListToDataView(list);
        }

        private void fromPriceTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn chặn ký tự nhập vào TextBox
            }
        }

        private void toPriceTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn chặn ký tự nhập vào TextBox
            }
        }
    }
}
