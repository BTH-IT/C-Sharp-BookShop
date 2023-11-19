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
    public partial class ImportBillGUI : Form
    {
        public ImportBillGUI()
        {
            InitializeComponent();
        }

        private CheckBox headerCheckbox;

        private void renderCheckBoxDgv()
        {
            try
            {
                int size = 25;
                Rectangle rect = this.dgvImportBill.GetCellDisplayRectangle(0, -1, false);

                headerCheckbox = new CheckBox();

                headerCheckbox.BackColor = Color.FromArgb(45, 210, 192);
                headerCheckbox.Name = "chkHeader";
                headerCheckbox.Size = new Size(size, size);
                headerCheckbox.TabStop = false;

                rect.X = (rect.Width / 2) - (size / 4);
                rect.Y = (rect.Height / 2) - (size / 2);

                headerCheckbox.Location = rect.Location;

                this.dgvImportBill.Controls.Add(headerCheckbox);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void loadImportBillListToDataView(List<ImportBillDTO> importBillList)
        {
            try
            {
                this.dgvImportBill.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 210, 192);
                this.dgvImportBill.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                this.dgvImportBill.Rows.Clear();

                foreach (ImportBillDTO importBill in importBillList)
                {
                    this.dgvImportBill.Rows.Add(new object[] {
                    false,
                    importBill.MaDonNhapHang,
                    SupplierBUS.Instance.getById(importBill.MaNhaCungCap.ToString()).TenNhaCungCap,
                    StaffBUS.Instance.getById(importBill.MaNhanVien.ToString()).Ten,
                    importBill.NgayLap.GetDateTimeFormats()[0],
                    importBill.TongTien,
                });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void loadSupplierCbx()
        {
            try
            {
                List<SupplierDTO> supplierList = SupplierBUS.Instance.getAllData();

                supplierList.Insert(0, new SupplierDTO(0, "Tất cả nhà cung cấp", "", ""));

                this.supplierCbx.ValueMember = "MaNhaCungCap";
                this.supplierCbx.DisplayMember = "TenNhaCungCap";
                this.supplierCbx.DataSource = supplierList;

                this.supplierCbx.SelectedIndex = 0;
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

        private void headerCheckbox_Clicked(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in this.dgvImportBill.Rows)
                {
                    row.Cells[0].Value = headerCheckbox.Checked;
                }

                this.dgvImportBill.RefreshEdit();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private List<ImportBillDTO> handleFilter(string searchText)
        {
            try
            {
                List<ImportBillDTO> importBillList = ImportBillBUS.Instance.search(searchText);

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
                            MessageBox.Show("Tổng tiền đến phải bé hơn hoặc bằng tổng tiền từ");
                        }
                        else
                        {
                            importBillList = importBillList.FindAll(
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
                        importBillList = importBillList.FindAll(
                            item => (DateTime.Compare(item.NgayLap, this.dateTimeFrom.Value) >= 0)
                                    && (DateTime.Compare(item.NgayLap, this.dateTimeTo.Value) <= 0)
                        );
                    }
                    catch
                    {
                        MessageBox.Show("Lọc theo khoảng thời gian không hợp lệ");
                    }
                }

                int supplierId = Convert.ToInt32(this.supplierCbx.SelectedValue);
                int staffId = Convert.ToInt32(this.staffCbx.SelectedValue);

                List<ImportBillDTO> newImportBillList = importBillList.FindAll(importBill =>
                {
                    if (supplierId != 0 && staffId != 0)
                    {
                        return importBill.MaNhaCungCap == supplierId &&
                               importBill.MaNhanVien == staffId;
                    }

                    if (supplierId == 0 && staffId != 0)
                    {
                        return importBill.MaNhanVien == staffId;
                    }

                    if (supplierId != 0 && staffId == 0)
                    {
                        return importBill.MaNhaCungCap == supplierId;
                    }

                    return true;
                });


                return newImportBillList;
            }
            catch (Exception ex)
            {
                return new List<ImportBillDTO>();
            }
        }

        private void searchInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<ImportBillDTO> importBillList = handleFilter(this.searchInput.Text.ToString());

                this.loadImportBillListToDataView(importBillList);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            using (ImportBillModal importBillModal = new ImportBillModal(ManagerGUI.currentStaff.Ma))
            {
                importBillModal.ShowDialog();

                if (importBillModal.isSubmitSuccess)
                {
                    List<ImportBillDTO> importBillList = handleFilter(this.searchInput.Text.ToString());

                    this.loadImportBillListToDataView(importBillList);
                }
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.searchInput.Clear();
                this.fromPriceTxt.Clear();
                this.toPriceTxt.Clear();

                this.supplierCbx.SelectedIndex = 0;
                this.staffCbx.SelectedIndex = 0;

                this.filterCkx.Checked = false;
                this.dateTimeFrom.Enabled = false;
                this.dateTimeTo.Enabled = false;

                this.dateTimeFrom.Refresh();
                this.dateTimeTo.Refresh();

                List<ImportBillDTO> importBillList = handleFilter("");

                this.loadImportBillListToDataView(importBillList);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void supplierCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<ImportBillDTO> importBillList = handleFilter(this.searchInput.Text.ToString());

                this.loadImportBillListToDataView(importBillList);
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
                List<ImportBillDTO> importBillList = handleFilter(this.searchInput.Text.ToString());

                this.loadImportBillListToDataView(importBillList);
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
                    List<ImportBillDTO> importBillList = handleFilter(this.searchInput.Text.ToString());

                    this.loadImportBillListToDataView(importBillList);
                }
            }
        }

        private void fromPriceTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<ImportBillDTO> importBillList = handleFilter(this.searchInput.Text.ToString());

                this.loadImportBillListToDataView(importBillList);
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
                List<ImportBillDTO> importBillList = handleFilter(this.searchInput.Text.ToString());

                this.loadImportBillListToDataView(importBillList);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            if (dgvImportBill.Rows.Count <= 0)
            {
                MessageBox.Show("Bảng dữ liệu hiện tại chưa có dòng dữ liệu nào để xuất excel!");
                return;
            }

            try
            {
                string[] headerList = new string[] { "Mã điwn", "Nhà cung cấp", "Nhân viên", "Ngày lập", "Tổng tiền" };

                DataTable dt = CustomExcel.Instance.ConvertDataGridViewToDataTable(dgvImportBill);

                CustomExcel.Instance.ExportFileDatagridView(dt, "Book Manage", 1, "Cửa hàng bán sách", headerList);
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

                foreach (DataGridViewRow row in this.dgvImportBill.Rows)
                {
                    if ((bool)row.Cells[0].Value)
                    {
                        isHaveSelect = true;
                    }
                }

                if (!isHaveSelect)
                {
                    MessageBox.Show("Bạn chưa chọn những đơn nhập hàng cần xóa");
                    return;
                }

                DialogResult dlgResult = MessageBox.Show(
                    "Bạn chắc chắn muốn xóa các đơn nhập hàng đã chọn chứ?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1
                );

                if (dlgResult == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in this.dgvImportBill.Rows)
                    {
                        if ((bool)row.Cells[0].Value == true)
                        {
                            ImportBillBUS.Instance.delete(row.Cells[1].Value.ToString());
                        }

                    }
                    List<ImportBillDTO> importBillList = handleFilter(this.searchInput.Text.ToString());

                    this.loadImportBillListToDataView(importBillList);
                    this.dgvImportBill.RefreshEdit();
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

                List<ImportBillDTO> importBillList = handleFilter(this.searchInput.Text.ToString());

                this.loadImportBillListToDataView(importBillList);
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

                List<ImportBillDTO> importBillList = handleFilter(this.searchInput.Text.ToString());

                this.loadImportBillListToDataView(importBillList);
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
        }

        private void dgvImportBill_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex <= 0)
            {
                return;
            }
        }

        private void ImportBillGUI_Load_1(object sender, EventArgs e)
        {
            try
            {
                this.dateTimeFrom.Enabled = this.filterCkx.Checked;
                this.dateTimeTo.Enabled = this.filterCkx.Checked;

                this.fromPriceTxt.Enabled = this.gunaMediumCheckBox1.Checked;
                this.toPriceTxt.Enabled = this.gunaMediumCheckBox1.Checked;

                List<ImportBillDTO> importBillList = ImportBillBUS.Instance.getAllData();
                this.loadImportBillListToDataView(importBillList);

                this.loadSupplierCbx();
                this.loadStaffCbx();
                this.renderCheckBoxDgv();

                headerCheckbox.MouseClick += new MouseEventHandler(headerCheckbox_Clicked);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void importExcelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = CustomExcel.Instance.ImportFile();

                if (dt == null)
                {
                    MessageBox.Show("Lỗi chưa chọn file hoặc file excel không đúng format dữ liệu nhập!");
                    return;
                }

                foreach (DataRow row in dt.Rows)
                {
                    if (!int.TryParse(row[0].ToString(), out int maSach) || !int.TryParse(row[2].ToString(), out int soLuong) || !decimal.TryParse(row[3].ToString(), out decimal giaNhap))
                    {
                        MessageBox.Show("Lỗi chưa chọn file hoặc file excel không đúng format dữ liệu nhập!");
                        return;
                    }
                }


                ImportBillDTO newImportBill = new ImportBillDTO(0, 1, ManagerGUI.currentStaff.Ma, DateTime.Now, 0);

                ImportBillDTO importBill = ImportBillBUS.Instance.insertReturnBill(newImportBill);

                if (importBill != null)
                {
                    decimal tongTien = 0;
                    foreach (DataRow row in dt.Rows)
                    {
                        BookDTO book = BookBUS.Instance.getById(row[0].ToString());

                        if (book == null) continue;

                        ImportBillDetailDTO importBillDetail = new ImportBillDetailDTO(importBill.MaDonNhapHang, book.MaSach, Convert.ToInt32(row[2].ToString()), Convert.ToDecimal(row[3].ToString()));

                        if (ImportBillBUS.Instance.createImportBillDetail(importBillDetail))
                        {
                            book.SoLuongConLai += Convert.ToInt32(row[2].ToString());
                            book.GiaNhap = Convert.ToDecimal(row[3].ToString());

                            BookBUS.Instance.update(book);

                            tongTien += book.GiaNhap * Convert.ToInt32(row[2].ToString());
                        };
                    }

                    importBill.TongTien = tongTien;

                    ImportBillBUS.Instance.update(importBill);

                    MessageBox.Show("Nhập từ file excel thành công!");

                    try
                    {
                        this.searchInput.Clear();
                        this.fromPriceTxt.Clear();
                        this.toPriceTxt.Clear();

                        this.supplierCbx.SelectedIndex = 0;
                        this.staffCbx.SelectedIndex = 0;

                        this.filterCkx.Checked = false;
                        this.dateTimeFrom.Enabled = false;
                        this.dateTimeTo.Enabled = false;

                        this.dateTimeFrom.Refresh();
                        this.dateTimeTo.Refresh();

                        List<ImportBillDTO> importBillList = handleFilter("");

                        this.loadImportBillListToDataView(importBillList);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
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
                if (this.dgvImportBill.CurrentCell.RowIndex < 0)
                {
                    MessageBox.Show("Hãy chọn dòng dữ liệu muốn thao tác");
                    return;
                }

                DataGridViewRow row = this.dgvImportBill.Rows[this.dgvImportBill.CurrentCell.RowIndex];

                ImportBillDTO importBill = ImportBillBUS.Instance.getById(row.Cells[1].Value.ToString());

                using (ViewImportBillModal viewImportBillModal = new ViewImportBillModal(importBill))
                {
                    viewImportBillModal.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void dgvImportBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0 || e.ColumnIndex <= 0)
                {
                    return;
                }

                DataGridViewRow row = this.dgvImportBill.Rows[this.dgvImportBill.CurrentCell.RowIndex];

                ImportBillDTO importBill = ImportBillBUS.Instance.getById(row.Cells[1].Value.ToString());

                using (ViewImportBillModal viewImportBillModal = new ViewImportBillModal(importBill))
                {
                    viewImportBillModal.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void gunaMediumCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.fromPriceTxt.Enabled = this.gunaMediumCheckBox1.Checked;
            this.toPriceTxt.Enabled = this.gunaMediumCheckBox1.Checked;
        }

        private void printPdfBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvImportBill.CurrentCell.RowIndex < 0 || this.dgvImportBill.CurrentCell == null)
                {
                    MessageBox.Show("Hãy chọn dòng dữ liệu muốn thao tác");
                    return;
                }

                DataGridViewRow row = this.dgvImportBill.Rows[this.dgvImportBill.CurrentCell.RowIndex];

                using (ImportBillPrintForm importBillPrintForm = new ImportBillPrintForm(Convert.ToInt32(row.Cells[1].Value)))
                {
                    importBillPrintForm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
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
