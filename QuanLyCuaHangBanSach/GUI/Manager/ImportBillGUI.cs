using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;
using QuanLyCuaHangBanSach.GUI.Modal;

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
            int size = 25;
            Rectangle rect = this.dgvImportBill.GetCellDisplayRectangle(0, -1, false);

            headerCheckbox = new CheckBox();

            headerCheckbox.BackColor = Color.FromArgb(45, 210, 192);
            headerCheckbox.Name = "chkHeader";
            headerCheckbox.Size = new Size(size, size);

            rect.X = (rect.Width / 2) - (size / 4);
            rect.Y = (rect.Height / 2) - (size / 2);

            headerCheckbox.Location = rect.Location;

            this.dgvImportBill.Controls.Add(headerCheckbox);
        }

        private void loadImportBillListToDataView(List<ImportBillDTO> importBillList)
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

        private void loadSupplierCbx()
        {
            List<SupplierDTO> supplierList = SupplierBUS.Instance.getAllData();

            supplierList.Insert(0, new SupplierDTO(0, "Tất cả nhà cung cấp", "", ""));

            this.supplierCbx.ValueMember = "MaNhaCungCap";
            this.supplierCbx.DisplayMember = "TenNhaCungCap";
            this.supplierCbx.DataSource = supplierList;

            this.supplierCbx.SelectedIndex = 0;
        }

        private void loadStaffCbx()
        {
            List<StaffDTO> staffList = StaffBUS.Instance.getAllData();

            staffList.Insert(0, new StaffDTO(0, "Tất cả nhân viên", "", "", 0, 0, 0,0));

            this.staffCbx.ValueMember = "Ma";
            this.staffCbx.DisplayMember = "Ten";
            this.staffCbx.DataSource = staffList;

            this.staffCbx.SelectedIndex = 0;
        }

        private void headerCheckbox_Clicked(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dgvImportBill.Rows)
            {
                row.Cells[0].Value = headerCheckbox.Checked;
            }

            this.dgvImportBill.RefreshEdit();
        }

        private List<ImportBillDTO> handleFilter(string searchText)
        {
            List<ImportBillDTO> importBillList = ImportBillBUS.Instance.search(searchText);

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
                    importBillList = importBillList.FindAll(
                        item => item.TongTien >= Convert.ToDouble(this.fromPriceTxt.Text.ToString())
                                && item.TongTien <= Convert.ToDouble(this.toPriceTxt.Text.ToString()
                    ));
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
                if (supplierId != 0 && staffId != 0 )
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

        private void searchInput_TextChanged(object sender, EventArgs e)
        {
            List<ImportBillDTO> importBillList = handleFilter(this.searchInput.Text.ToString());

            this.loadImportBillListToDataView(importBillList);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            using (BookModal importBillModal = new BookModal())
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

        private void supplierCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<ImportBillDTO> importBillList = handleFilter(this.searchInput.Text.ToString());

            this.loadImportBillListToDataView(importBillList);
        }

        private void staffCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<ImportBillDTO> importBillList = handleFilter(this.searchInput.Text.ToString());

            this.loadImportBillListToDataView(importBillList);
        }

        private void fromPriceTxt_TextChanged(object sender, EventArgs e)
        {
            List<ImportBillDTO> importBillList = handleFilter(this.searchInput.Text.ToString());

            this.loadImportBillListToDataView(importBillList);
        }

        private void toPriceTxt_TextChanged(object sender, EventArgs e)
        {
            List<ImportBillDTO> importBillList = handleFilter(this.searchInput.Text.ToString());

            this.loadImportBillListToDataView(importBillList);
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            List<ImportBillDTO> importBillList = handleFilter(this.searchInput.Text.ToString());

            DataTable dataTable = CustomExcel.Instance.ConvertListToDataTable(importBillList);

            string[] headerList = new string[] { "Mã điwn", "Nhà cung cấp", "Nhân viên", "Ngày lập", "Tổng tiền"};

            CustomExcel.Instance.ExportFile(dataTable, "Import Bill Manage", "Cửa hàng bán sách", headerList);
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (this.dgvImportBill.CurrentCell.RowIndex < 0)
            {
                MessageBox.Show("Hãy chọn dòng dữ liệu muốn thao tác");
                return;
            }

            DataGridViewRow row = this.dgvImportBill.Rows[this.dgvImportBill.CurrentCell.RowIndex];

            using (ImportBillModal importBillModal = new ImportBillModal(Convert.ToInt32(row.Cells[1].Value)))
            {
                BookDTO importBill = BookBUS.Instance.getById(row.Cells[1].Value.ToString());

                importBillModal.ShowDialog();

                if (importBillModal.isSubmitSuccess)
                {
                    List<ImportBillDTO> importBillList = handleFilter(this.searchInput.Text.ToString());

                    this.loadImportBillListToDataView(importBillList);
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
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
                foreach (DataGridViewRow row in this.dgvImportBill.Rows)
                {
                    if ((bool)row.Cells[0].Value == true)
                    {
                        if (BookBUS.Instance.delete(row.Cells[1].Value.ToString()))
                        {
                            List<ImportBillDTO> importBillList = handleFilter(this.searchInput.Text.ToString());

                            this.loadImportBillListToDataView(importBillList);

                            row.Cells[0].Value = false;
                        }
                    }

                }

                this.dgvImportBill.RefreshEdit();
                MessageBox.Show("Delete successful");
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

            List<ImportBillDTO> importBillList = handleFilter(this.searchInput.Text.ToString());

            this.loadImportBillListToDataView(importBillList);
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

            List<ImportBillDTO> importBillList = handleFilter(this.searchInput.Text.ToString());

            this.loadImportBillListToDataView(importBillList);
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
            this.dateTimeFrom.Enabled = this.filterCkx.Checked;
            this.dateTimeTo.Enabled = this.filterCkx.Checked;

            List<ImportBillDTO> importBillList = ImportBillBUS.Instance.getAllData();
            this.loadImportBillListToDataView(importBillList);

            this.loadSupplierCbx();
            this.loadStaffCbx();
            this.renderCheckBoxDgv();

            headerCheckbox.MouseClick += new MouseEventHandler(headerCheckbox_Clicked);
        }

        private void importExcelBtn_Click(object sender, EventArgs e)
        {
            DataTable dt = CustomExcel.Instance.ImportFile();

            ImportBillDTO newImportBill = new ImportBillDTO(0, 1, ManagerGUI.currentStaff.Ma, DateTime.Now, 0);

            ImportBillDTO importBill = ImportBillBUS.Instance.insertReturnBill(newImportBill);

            if (importBill != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    BookDTO book = BookBUS.Instance.getById(row[0].ToString());

                    if (book == null) continue;

                    ImportBillDetailDTO importBillDetail = new ImportBillDetailDTO(importBill.MaDonNhapHang, book.MaSach, Convert.ToInt32(row[2].ToString()), Convert.ToDouble(row[3].ToString()));

                    if (ImportBillBUS.Instance.createImportBillDetail(importBillDetail))
                    {
                        book.SoLuongConLai += Convert.ToInt32(row[2].ToString());
                        book.GiaNhap = Convert.ToDouble(row[3].ToString());

                        BookBUS.Instance.update(book);
                    };
                }
            }
        }
    }
}
