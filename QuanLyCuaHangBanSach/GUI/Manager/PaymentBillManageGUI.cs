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
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;
using QuanLyCuaHangBanSach.GUI.Modal;

namespace QuanLyCuaHangBanSach.GUI.Manager
{
    public partial class PaymentBillManageGUI : Form
    {
        private CheckBox headerCheckbox;

        public PaymentBillManageGUI()
        {
            InitializeComponent();
        }

        private void renderCheckBoxDgv()
        {
            int size = 25;
            Rectangle rect = this.dgvPaymentBill.GetCellDisplayRectangle(0, -1, false);

            headerCheckbox = new CheckBox();

            headerCheckbox.BackColor = Color.FromArgb(45, 210, 192);
            headerCheckbox.Name = "chkHeader";
            headerCheckbox.Size = new Size(size, size);

            rect.X = (rect.Width / 2) - (size / 4);
            rect.Y = (rect.Height / 2) - (size / 2);

            headerCheckbox.Location = rect.Location;

            this.dgvPaymentBill.Controls.Add(headerCheckbox);
        }

        private void loadPaymentBillListToDataView(List<PaymentBillDTO> paymentBillList)
        {
            this.dgvPaymentBill.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 210, 192);
            this.dgvPaymentBill.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            this.dgvPaymentBill.Rows.Clear();

            StaffDTO staff;

            foreach (PaymentBillDTO paymentBill in paymentBillList)
            {
                staff = StaffBUS.Instance.getById(paymentBill.MaNhanVien.ToString());

                this.dgvPaymentBill.Rows.Add(new object[] {
                    false,
                    paymentBill.MaPhieu,
                    staff.Ten,
                    paymentBill.MaDonNhapHang,
                    paymentBill.NgayLap.GetDateTimeFormats()[0],
                    paymentBill.LiDo,
                    paymentBill.GhiChu,
                    paymentBill.TongTien,
                });
            }

        }

        private void loadStaffCbx()
        {
            List<StaffDTO> staffList = StaffBUS.Instance.getAllData();

            staffList.Insert(0, new StaffDTO(0, "Tất cả nhân viên", "", "", 0, 0, 0, 0));

            this.staffCbx.ValueMember = "Ma";
            this.staffCbx.DisplayMember = "Ten";
            this.staffCbx.DataSource = staffList;

            this.staffCbx.SelectedIndex = 0;
        }

        private void PaymentBillGUI_Load(object sender, EventArgs e)
        {
            this.dateTimeFrom.Enabled = this.filterCkx.Checked;
            this.dateTimeTo.Enabled = this.filterCkx.Checked;

            List<PaymentBillDTO> paymentBillList = PaymentBillBUS.Instance.getAllData();
            this.loadPaymentBillListToDataView(paymentBillList);

            this.loadStaffCbx();
            this.renderCheckBoxDgv();

            headerCheckbox.MouseClick += new MouseEventHandler(headerCheckbox_Clicked);
        }

        private void headerCheckbox_Clicked(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dgvPaymentBill.Rows)
            {
                row.Cells[0].Value = headerCheckbox.Checked;
            }

            this.dgvPaymentBill.RefreshEdit();
        }

        private List<PaymentBillDTO> handleFilter(string searchText)
        {
            List<PaymentBillDTO> paymentBillList = PaymentBillBUS.Instance.search(searchText);

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
                    paymentBillList = paymentBillList.FindAll(
                        item => item.TongTien >= Convert.ToDouble(this.fromPriceTxt.Text.ToString())
                                && item.TongTien <= Convert.ToDouble(this.toPriceTxt.Text.ToString()
                    ));
                }
            }

            if (DateTime.Compare(this.dateTimeFrom.Value, this.dateTimeTo.Value) <= 0 && this.filterCkx.Checked)
            {
                try
                {
                    paymentBillList = paymentBillList.FindAll(
                        item => (DateTime.Compare(item.NgayLap, this.dateTimeFrom.Value) >= 0)
                                && (DateTime.Compare(item.NgayLap, this.dateTimeTo.Value) <= 0)
                    );
                }
                catch
                {
                    MessageBox.Show("Lọc theo khoảng thời gian không hợp lệ");
                }
            }

            int paymentId = Convert.ToInt32(this.paymentCbx.SelectedValue);
            int staffId = Convert.ToInt32(this.staffCbx.SelectedValue);
            int saleId = Convert.ToInt32(this.saleCbx.SelectedValue);

            List<PaymentBillDTO> newPaymentBillList = paymentBillList.FindAll(paymentBill =>
            {
                if (paymentId != 0 && staffId != 0 && saleId != 0)
                {
                    return paymentBill.MaKhachHang == paymentId &&
                           paymentBill.MaNhanVien == staffId &&
                           paymentBill.MaKhuyenMai == saleId;
                }

                if (paymentId == 0 && staffId != 0 && saleId != 0)
                {
                    return paymentBill.MaNhanVien == staffId &&
                           paymentBill.MaKhuyenMai == saleId;
                }

                if (paymentId == 0 && staffId == 0 && saleId != 0)
                {
                    return paymentBill.MaKhuyenMai == saleId;
                }

                if (paymentId == 0 && staffId != 0 && saleId == 0)
                {
                    return paymentBill.MaNhanVien == staffId;
                }

                if (paymentId != 0 && staffId == 0 && saleId == 0)
                {
                    return paymentBill.MaKhachHang == paymentId;
                }

                if (paymentId != 0 && staffId != 0 && saleId == 0)
                {
                    return paymentBill.MaKhachHang == paymentId &&
                           paymentBill.MaNhanVien == staffId;
                }

                if (paymentId != 0 && staffId == 0 && saleId != 0)
                {
                    return paymentBill.MaKhachHang == paymentId &&
                           paymentBill.MaKhuyenMai == saleId;
                }

                return true;
            });


            return newPaymentBillList;
        }

        private void searchInput_TextChanged(object sender, EventArgs e)
        {
            List<PaymentBillDTO> paymentBillList = handleFilter(this.searchInput.Text.ToString());

            this.loadPaymentBillListToDataView(paymentBillList);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            using (BookModal paymentBillModal = new BookModal())
            {
                paymentBillModal.ShowDialog();


                if (paymentBillModal.isSubmitSuccess)
                {
                    List<PaymentBillDTO> paymentBillList = handleFilter(this.searchInput.Text.ToString());

                    this.loadPaymentBillListToDataView(paymentBillList);
                }
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            this.searchInput.Clear();
            this.fromPriceTxt.Clear();
            this.toPriceTxt.Clear();

            this.paymentCbx.SelectedIndex = 0;
            this.staffCbx.SelectedIndex = 0;
            this.saleCbx.SelectedIndex = 0;

            this.filterCkx.Checked = false;
            this.dateTimeFrom.Enabled = false;
            this.dateTimeTo.Enabled = false;

            this.dateTimeFrom.Refresh();
            this.dateTimeTo.Refresh();

            List<PaymentBillDTO> paymentBillList = handleFilter("");

            this.loadPaymentBillListToDataView(paymentBillList);
        }

        private void paymentCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<PaymentBillDTO> paymentBillList = handleFilter(this.searchInput.Text.ToString());

            this.loadPaymentBillListToDataView(paymentBillList);
        }

        private void staffCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<PaymentBillDTO> paymentBillList = handleFilter(this.searchInput.Text.ToString());

            this.loadPaymentBillListToDataView(paymentBillList);
        }

        private void saleCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<PaymentBillDTO> paymentBillList = handleFilter(this.searchInput.Text.ToString());

            this.loadPaymentBillListToDataView(paymentBillList);
        }

        private void fromPriceTxt_TextChanged(object sender, EventArgs e)
        {
            List<PaymentBillDTO> paymentBillList = handleFilter(this.searchInput.Text.ToString());

            this.loadPaymentBillListToDataView(paymentBillList);
        }

        private void toPriceTxt_TextChanged(object sender, EventArgs e)
        {
            List<PaymentBillDTO> paymentBillList = handleFilter(this.searchInput.Text.ToString());

            this.loadPaymentBillListToDataView(paymentBillList);
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            List<PaymentBillDTO> paymentBillList = handleFilter(this.searchInput.Text.ToString());

            DataTable dataTable = CustomExcel.Instance.ConvertListToDataTable(paymentBillList);

            string[] headerList = new string[] { "Mã đơn", "Tên khách hàng", "Số điện thoại khách hàng", "Nhân Viên", "Khuyến mãi", "Giá bán", "Phần trăm", "Ngày lập", "Tổng tiền" };

            CustomExcel.Instance.ExportFile(dataTable, "Payment Bill Manage", "Cửa hàng bán sách", headerList);
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (this.dgvPaymentBill.CurrentCell.RowIndex < 0)
            {
                MessageBox.Show("Hãy chọn dòng dữ liệu muốn thao tác");
                return;
            }

            DataGridViewRow row = this.dgvPaymentBill.Rows[this.dgvPaymentBill.CurrentCell.RowIndex];

            using (PaymentBillModal paymentBillModal = new PaymentBillModal(Convert.ToInt32(row.Cells[1].Value)))
            {
                BookDTO paymentBill = BookBUS.Instance.getById(row.Cells[1].Value.ToString());

                paymentBillModal.ShowDialog();

                if (paymentBillModal.isSubmitSuccess)
                {
                    List<PaymentBillDTO> paymentBillList = handleFilter(this.searchInput.Text.ToString());

                    this.loadPaymentBillListToDataView(paymentBillList);
                }
            }
        }

        private bool isCheckSeletedRows()
        {
            foreach (DataGridViewRow row in this.dgvPaymentBill.Rows)
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
                foreach (DataGridViewRow row in this.dgvPaymentBill.Rows)
                {
                    if ((bool)row.Cells[0].Value == true)
                    {
                        BookBUS.Instance.delete(row.Cells[1].Value.ToString());
                    }

                }

                List<PaymentBillDTO> paymentBillList = handleFilter(this.searchInput.Text.ToString());

                this.loadPaymentBillListToDataView(paymentBillList);

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

            List<PaymentBillDTO> paymentBillList = handleFilter(this.searchInput.Text.ToString());

            this.loadPaymentBillListToDataView(paymentBillList);
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

            List<PaymentBillDTO> paymentBillList = handleFilter(this.searchInput.Text.ToString());

            this.loadPaymentBillListToDataView(paymentBillList);
        }

        private void filterCkx_CheckedChanged(object sender, EventArgs e)
        {
            this.dateTimeFrom.Enabled = this.filterCkx.Checked;
            this.dateTimeTo.Enabled = this.filterCkx.Checked;
        }

        private void printPdfBtn_Click(object sender, EventArgs e)
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
                foreach (DataGridViewRow row in this.dgvPaymentBill.Rows)
                {
                    if ((bool)row.Cells[0].Value == true)
                    {
                        int maSach = Convert.ToInt32(row.Cells[1].Value.ToString());
                    }

                }

                List<PaymentBillDTO> paymentBillList = handleFilter(this.searchInput.Text.ToString());

                this.loadPaymentBillListToDataView(paymentBillList);

                MessageBox.Show("Print PDF successful");
            }
        }
    }
}
