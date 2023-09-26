using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCuaHangBanSach.GUI.Modal;
using QuanLyCuaHangBanSach.GUI.Report;

namespace QuanLyCuaHangBanSach.GUI.Manager
{
    public partial class CustomerChangeBillGUI : Form
    {
        private CheckBox headerCheckbox;
        public CustomerChangeBillGUI()
        {
            InitializeComponent();
        }
        private void renderCheckBoxDgv()
        {
            try
            {
                int size = 25;

                Rectangle rect = this.dgvCustomerChangeBill.GetCellDisplayRectangle(0, -1, false);

                headerCheckbox = new CheckBox();

                headerCheckbox.BackColor = Color.FromArgb(45, 210, 192);
                headerCheckbox.Name = "chkHeader";
                headerCheckbox.Size = new Size(size, size);

                rect.X = (rect.Width / 2) - (size / 4);
                rect.Y = (rect.Height / 2) - (size / 2);

                headerCheckbox.Location = rect.Location;


                this.dgvCustomerChangeBill.Controls.Add(headerCheckbox);
            }
            catch (Exception er)
            {

                Console.WriteLine(er);
            }
        }

        private void loadCustomerChangeBillListToDataView(List<CustomerChangeBillDTO> CustomerChangeBillList)
        {
            try
            {
                this.dgvCustomerChangeBill.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 210, 192);
                this.dgvCustomerChangeBill.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                this.dgvCustomerChangeBill.Rows.Clear();


                foreach (CustomerChangeBillDTO CustomerChangeBill in CustomerChangeBillList)
                {
                    this.dgvCustomerChangeBill.Rows.Add(new object[] {
                    false,
                    CustomerChangeBill.MaPhieu,
                    CustomerChangeBill.MaKhachHang,
                    CustomerChangeBill.SachCanDoi,
                    CustomerChangeBill.SachMuonDoi,
                    CustomerChangeBill.MaNhanVien,
                    CustomerChangeBill.TinhTrangSanPham,
                    CustomerChangeBill.LiDo,
                    CustomerChangeBill.NgayLap,
                });
                }
            }
            catch (Exception er)
            {

                Console.WriteLine(er);
            }
        }

        private void loadCustomerCbx()
        {
            try
            {
                List<CustomerDTO> customerList = CustomerBUS.Instance.getAllData();

                customerList.Insert(0, new CustomerDTO(0, "Tất cả khách hàng", "", "", 0, 0));

                this.customerCbx.ValueMember = "Ma";
                this.customerCbx.DisplayMember = "Ten";
                this.customerCbx.DataSource = customerList;

                this.customerCbx.SelectedIndex = 0;
            }
            catch (Exception er)
            {

                Console.WriteLine(er);
            }
        }

        private void loadBookNeedChangeCbx()
        {
            try
            {
                List<BookDTO> bookList = BookBUS.Instance.getAllData();

                bookList.Insert(0, new BookDTO(0, "Tất cả sách cần đổi", new byte[0], 0, 0, 0, 0, 0, 0));

                this.bookNeedChangeCbx.ValueMember = "MaSach";
                this.bookNeedChangeCbx.DisplayMember = "TenSach";
                this.bookNeedChangeCbx.DataSource = bookList;

                this.bookNeedChangeCbx.SelectedIndex = 0;
            }
            catch (Exception er)
            {

                Console.WriteLine(er);
            }
        }

        private void loadBookWantChangeCbx()
        {
            try
            {
                List<BookDTO> bookList = BookBUS.Instance.getAllData();

                bookList.Insert(0, new BookDTO(0, "Tất cả sách muốn đổi", new byte[0], 0, 0, 0, 0, 0, 0));

                this.bookWantChangeCbx.ValueMember = "MaSach";
                this.bookWantChangeCbx.DisplayMember = "TenSach";
                this.bookWantChangeCbx.DataSource = bookList;

                this.customerCbx.SelectedIndex = 0;
            }
            catch (Exception er)
            {

                Console.WriteLine(er);
            }
        }

        private void loadStaffCbx()
        {
            try
            {
                List<StaffDTO> staffList = StaffBUS.Instance.getAllData();

                staffList.Insert(0, new StaffDTO(0, "Tất cả nhân viên", "", "", 0, 0, 0, 0));

                this.staffCbx.ValueMember = "Ma";
                this.staffCbx.DisplayMember = "Ten";
                this.staffCbx.DataSource = staffList;

                this.staffCbx.SelectedIndex = 0;
            }
            catch (Exception er)
            {

                Console.WriteLine(er);
            }
        }

        private void CustomerChangeBillGUI_Load(object sender, EventArgs e)
        {

            try
            {
                List<CustomerChangeBillDTO> CustomerChangeBillList = CustomerChangeBillBUS.Instance.getAllData();
                this.loadCustomerChangeBillListToDataView(CustomerChangeBillList);
                this.loadCustomerCbx();
                this.loadBookNeedChangeCbx();
                this.loadBookWantChangeCbx();
                this.loadStaffCbx();
                this.renderCheckBoxDgv();
                headerCheckbox.MouseClick += new MouseEventHandler(headerCheckbox_Clicked);
            }
            catch (Exception er)
            {

                Console.WriteLine(er);
            }
        }

        private void headerCheckbox_Clicked(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in this.dgvCustomerChangeBill.Rows)
                {
                    row.Cells[0].Value = headerCheckbox.Checked;
                }

                this.dgvCustomerChangeBill.RefreshEdit();
            }
            catch(Exception er)
{

                Console.WriteLine(er);
            }
        }

        private void searchInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.searchInput.ForeColor = Color.Black;

                List<CustomerChangeBillDTO> CustomerChangeBillList = CustomerChangeBillBUS.Instance.search(this.searchInput.Text.ToString());

                this.loadCustomerChangeBillListToDataView(CustomerChangeBillList);
            }
            catch (Exception er)
            {

                Console.WriteLine(er);
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.searchInput.Clear();
                this.customerCbx.SelectedIndex = 0;
                this.bookNeedChangeCbx.SelectedIndex = 0;
                this.bookWantChangeCbx.SelectedIndex = 0;
                this.staffCbx.SelectedIndex = 0;
                List<CustomerChangeBillDTO> CustomerChangeBillList = CustomerChangeBillBUS.Instance.search("");
                this.loadCustomerChangeBillListToDataView(CustomerChangeBillList);
            }
            catch (Exception er)
            {

                Console.WriteLine(er);
            }
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                List<CustomerChangeBillDTO> CustomerChangeBillList = CustomerChangeBillBUS.Instance.search(this.searchInput.Text.ToString());

                DataTable dataTable = CustomExcel.Instance.ConvertListToDataTable(CustomerChangeBillList);

                string[] headerList = new string[] { "Mã phiếu", "Mã khách hàng", "Mã sách cần đổi", "Mã sách muốn đổi", "Mã nhân viên", "Tình trạng đổi hàng", "Lý do", "Ngày lập" };

                CustomExcel.Instance.ExportFile(dataTable, "CustomerChangeBill Manage", "Cửa hàng bán sách", headerList);
            }
            catch (Exception er)
            {

                Console.WriteLine(er);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                bool isHaveSelect = false;

                foreach (DataGridViewRow row in this.dgvCustomerChangeBill.Rows)
                {
                    if ((bool)row.Cells[0].Value)
                    {
                        isHaveSelect = true;
                        break;
                    }
                }

                if (!isHaveSelect)
                {
                    MessageBox.Show("Bạn chưa chọn những phiếu cần xóa");
                    return;
                }

                DialogResult dlgResult = MessageBox.Show(
                    "Bạn chắc chắn muốn xóa các phiếu đã chọn chứ?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1
                );

                if (dlgResult == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in this.dgvCustomerChangeBill.Rows)
                    {
                        if ((bool)row.Cells[0].Value == true)
                        {
                            CustomerChangeBillBUS.Instance.delete(row.Cells[1].Value.ToString());
                        }

                    }
                    List<CustomerChangeBillDTO> CustomerChangeBillList = CustomerChangeBillBUS.Instance.search(this.searchInput.Text.ToString());

                    this.loadCustomerChangeBillListToDataView(CustomerChangeBillList);

                    MessageBox.Show("Delete successful");
                }
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
                using (CustomerChangeBillModal CustomerChangeBillModal = new CustomerChangeBillModal(1))
                {
                    CustomerChangeBillModal.ShowDialog();


                    if (CustomerChangeBillModal.isSubmitSuccess)
                    {
                        List<CustomerChangeBillDTO> CustomerChangeBillList = CustomerChangeBillBUS.Instance.search(this.searchInput.Text.ToString());

                        this.loadCustomerChangeBillListToDataView(CustomerChangeBillList);
                    }
                }
            }
            catch (Exception er)
            {

                Console.WriteLine(er);
            }
        }

        private bool isCheckSeletedRows()
        {
            try
            {
                foreach (DataGridViewRow row in this.dgvCustomerChangeBill.Rows)
                {
                    if ((bool)row.Cells[0].Value)
                    {
                        return true;
                    }
                }

                MessageBox.Show("Bạn chưa chọn những đơn hàng cần xóa");
                return false;
            }
            catch (Exception er)
            {

                return false;
            }
        }

        private void printPdfBtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (this.dgvCustomerChangeBill.CurrentCell.RowIndex < 0)
                {
                    MessageBox.Show("Hãy chọn dòng dữ liệu muốn thao tác");
                    return;
                }

                DataGridViewRow row = this.dgvCustomerChangeBill.Rows[this.dgvCustomerChangeBill.CurrentCell.RowIndex];

                using (CustomerChangeBillPrintForm customerChangeBillPrintForm = new CustomerChangeBillPrintForm(Convert.ToInt32(row.Cells[1].Value)))
                {

                    customerChangeBillPrintForm.ShowDialog();

                }
            }
            catch (Exception er)
            {

                Console.WriteLine(er);
            }
        }

        private void customerCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<CustomerChangeBillDTO> customerChangeBillList = handleFilter(this.searchInput.Text.ToString());

                this.loadCustomerChangeBillListToDataView(customerChangeBillList);
            }
            catch (Exception er)
            {

                Console.WriteLine(er);
            }
        }

        private List<CustomerChangeBillDTO> handleFilter(string searchText)
        {
            try
            {
                List<CustomerChangeBillDTO> customerChangeBillList = CustomerChangeBillBUS.Instance.search(searchText);

                if (DateTime.Compare(this.dateTimeFrom.Value, this.dateTimeTo.Value) <= 0 && this.filterCkx.Checked)
                {
                    try
                    {
                        customerChangeBillList = customerChangeBillList.FindAll(
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
                int bookNeedChangeId = Convert.ToInt32(this.bookNeedChangeCbx.SelectedValue);
                int bookWantChangeId = Convert.ToInt32(this.bookWantChangeCbx.SelectedValue);
                int staffId = Convert.ToInt32(this.staffCbx.SelectedValue);

                List<CustomerChangeBillDTO> newCustomerChangeBillList = customerChangeBillList.FindAll(customerChangeBill =>
                {
                    if (customerId != 0 && bookNeedChangeId != 0 && bookWantChangeId != 0 && staffId != 0)
                    {
                        return customerChangeBill.MaKhachHang == customerId &&
                               customerChangeBill.SachCanDoi == bookNeedChangeId &&
                               customerChangeBill.SachMuonDoi == bookWantChangeId &&
                               customerChangeBill.MaNhanVien == staffId;
                    }

                    if (customerId == 0 && bookNeedChangeId != 0 && bookWantChangeId != 0 && staffId != 0)
                    {
                        return customerChangeBill.SachCanDoi == bookNeedChangeId &&
                               customerChangeBill.SachMuonDoi == bookWantChangeId &&
                               customerChangeBill.MaNhanVien == staffId;
                    }

                    if (customerId == 0 && bookNeedChangeId == 0 && bookWantChangeId != 0 && staffId != 0)
                    {
                        return customerChangeBill.SachMuonDoi == bookWantChangeId &&
                               customerChangeBill.MaNhanVien == staffId;
                    }

                    if (customerId == 0 && bookNeedChangeId == 0 && bookWantChangeId == 0 && staffId != 0)
                    {
                        return customerChangeBill.MaNhanVien == staffId;
                    }

                    if (customerId != 0 && bookNeedChangeId == 0 && bookWantChangeId != 0 && staffId != 0)
                    {
                        return customerChangeBill.MaKhachHang == customerId &&
                               customerChangeBill.SachMuonDoi == bookWantChangeId &&
                               customerChangeBill.MaNhanVien == staffId;
                    }

                    if (customerId != 0 && bookNeedChangeId == 0 && bookWantChangeId == 0 && staffId != 0)
                    {
                        return customerChangeBill.MaKhachHang == customerId &&
                               customerChangeBill.MaNhanVien == staffId;
                    }

                    if (customerId != 0 && bookNeedChangeId == 0 && bookWantChangeId == 0 && staffId == 0)
                    {
                        return customerChangeBill.MaKhachHang == customerId;
                    }

                    if (customerId != 0 && bookNeedChangeId != 0 && bookWantChangeId == 0 && staffId != 0)
                    {
                        return customerChangeBill.MaKhachHang == customerId &&
                               customerChangeBill.SachCanDoi == bookNeedChangeId &&
                               customerChangeBill.MaNhanVien == staffId;
                    }

                    if (customerId != 0 && bookNeedChangeId != 0 && bookWantChangeId == 0 && staffId == 0)
                    {
                        return customerChangeBill.MaKhachHang == customerId &&
                               customerChangeBill.SachCanDoi == bookNeedChangeId;
                    }

                    if (customerId != 0 && bookNeedChangeId != 0 && bookWantChangeId != 0 && staffId == 0)
                    {
                        return customerChangeBill.MaKhachHang == customerId &&
                               customerChangeBill.SachCanDoi == bookNeedChangeId &&
                               customerChangeBill.SachMuonDoi == bookWantChangeId;
                    }

                    if (customerId == 0 && bookNeedChangeId == 0 && bookWantChangeId != 0 && staffId == 0)
                    {
                        return customerChangeBill.SachMuonDoi == bookWantChangeId;
                    }

                    if (customerId == 0 && bookNeedChangeId != 0 && bookWantChangeId == 0 && staffId == 0)
                    {
                        return customerChangeBill.SachCanDoi == bookNeedChangeId;
                    }

                    if (customerId != 0 && bookNeedChangeId == 0 && bookWantChangeId != 0 && staffId == 0)
                    {
                        return customerChangeBill.MaKhachHang == customerId &&
                               customerChangeBill.SachMuonDoi == bookWantChangeId;
                    }

                    if (customerId == 0 && bookNeedChangeId != 0 && bookWantChangeId != 0 && staffId == 0)
                    {
                        return customerChangeBill.SachCanDoi == bookNeedChangeId &&
                               customerChangeBill.SachMuonDoi == bookWantChangeId;
                    }

                    if (customerId == 0 && bookNeedChangeId != 0 && bookWantChangeId == 0 && staffId != 0)
                    {
                        return customerChangeBill.SachCanDoi == bookNeedChangeId &&
                               customerChangeBill.MaNhanVien == staffId;
                    }


                    return true;
                });

                return newCustomerChangeBillList;
            }
            catch (Exception er)
            {

                return new List<CustomerChangeBillDTO>();
            }
        }

        private void bookNeedChangeCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<CustomerChangeBillDTO> customerChangeBillList = handleFilter(this.searchInput.Text.ToString());

                this.loadCustomerChangeBillListToDataView(customerChangeBillList);
            }
            catch (Exception er)
            {

                Console.WriteLine(er);
            }
        }

        private void bookWantChangeCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<CustomerChangeBillDTO> customerChangeBillList = handleFilter(this.searchInput.Text.ToString());

                this.loadCustomerChangeBillListToDataView(customerChangeBillList);
            }
            catch (Exception er)
            {

                Console.WriteLine(er);
            }
        }

        private void staffCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<CustomerChangeBillDTO> customerChangeBillList = handleFilter(this.searchInput.Text.ToString());

                this.loadCustomerChangeBillListToDataView(customerChangeBillList);
            }
            catch (Exception er)
            {

                Console.WriteLine(er);
            }
        }

        private void filterCkx_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                this.dateTimeFrom.Enabled = this.filterCkx.Checked;
                this.dateTimeTo.Enabled = this.filterCkx.Checked;
            }
            catch (Exception er)
            {

                Console.WriteLine(er);
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

                List<CustomerChangeBillDTO> customerChangeBillList = handleFilter(this.searchInput.Text.ToString());

                this.loadCustomerChangeBillListToDataView(customerChangeBillList);
            }
            catch (Exception er)
            {

                Console.WriteLine(er);
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

                List<CustomerChangeBillDTO> customerChangeBillList = handleFilter(this.searchInput.Text.ToString());

                this.loadCustomerChangeBillListToDataView(customerChangeBillList);
            }
            catch (Exception er)
            {

                Console.WriteLine(er);
            }
        }
    }
}
