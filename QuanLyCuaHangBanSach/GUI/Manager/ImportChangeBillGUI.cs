using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DAO;
using QuanLyCuaHangBanSach.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangBanSach.GUI.Manager
{
    public partial class ImportChangeBillGUI : Form
    {
        private CheckBox headerCheckbox;

        public ImportChangeBillGUI()
        {
            InitializeComponent();
        }

        private void renderCheckBoxDgv()
        {
            int size = 25;

            Rectangle rect = this.dgvImportChangeBill.GetCellDisplayRectangle(0, -1, false);

            headerCheckbox = new CheckBox();

            headerCheckbox.BackColor = Color.FromArgb(45, 210, 192);
            headerCheckbox.Name = "chkHeader";
            headerCheckbox.Size = new Size(size, size);

            rect.X = (rect.Width / 2) - (size / 4);
            rect.Y = (rect.Height / 2) - (size / 2);

            headerCheckbox.Location = rect.Location;


            this.dgvImportChangeBill.Controls.Add(headerCheckbox);
        }

        private void loadImportChangeBillListToDataView(List<ImportChangeBillDTO> ImportChangeBillList)
        {
            this.dgvImportChangeBill.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 210, 192);
            this.dgvImportChangeBill.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dgvImportChangeBill.Rows.Clear();


            foreach (ImportChangeBillDTO ImportChangeBill in ImportChangeBillList)
            {
                this.dgvImportChangeBill.Rows.Add(new object[] {
                    false,
                    ImportChangeBill.MaPhieu,
                    ImportChangeBill.MaNhaCungCap,
                    ImportChangeBill.SachCanDoi,
                    ImportChangeBill.SachMuonDoi,
                    ImportChangeBill.MaNhanVien,
                    ImportChangeBill.TinhTrangSanPham,
                    ImportChangeBill.LiDo,
                    ImportChangeBill.NgayLap,
                });
            }

        }

        private void loadSupplierCbx()
        {
            List<SupplierDTO> customerList = SupplierBUS.Instance.getAllData();

            customerList.Insert(0, new SupplierDTO(0, "Tất cả nhà cung cấp", "", ""));

            this.supplierCbx.ValueMember = "MaNhaCungCap";
            this.supplierCbx.DisplayMember = "TenNhaCungCap";
            this.supplierCbx.DataSource = customerList;

            this.supplierCbx.SelectedIndex = 0;
        }
        private void loadBookNeedChangeCbx()
        {
            List<BookDTO> bookList = BookBUS.Instance.getAllData();

            bookList.Insert(0, new BookDTO(0, "Tất cả sách cần đổi", new byte[0], 0, 0, 0, 0, 0, 0));

            this.bookNeedChangeCbx.ValueMember = "MaSach";
            this.bookNeedChangeCbx.DisplayMember = "TenSach";
            this.bookNeedChangeCbx.DataSource = bookList;

            this.bookNeedChangeCbx.SelectedIndex = 0;
        }
        private void loadBookWantChangeCbx()
        {
            List<BookDTO> bookList = BookBUS.Instance.getAllData();

            bookList.Insert(0, new BookDTO(0, "Tất cả sách muốn đổi", new byte[0], 0, 0, 0, 0, 0, 0));

            this.bookWantChangeCbx.ValueMember = "MaSach";
            this.bookWantChangeCbx.DisplayMember = "TenSach";
            this.bookWantChangeCbx.DataSource = bookList;

            this.supplierCbx.SelectedIndex = 0;
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

        private void ImportChangeBillGUI_Load(object sender, EventArgs e)
        {

            List<ImportChangeBillDTO> ImportChangeBillList = ImportChangeBillBUS.Instance.getAllData();
            this.loadImportChangeBillListToDataView(ImportChangeBillList);
            this.loadSupplierCbx();
            this.loadBookNeedChangeCbx();
            this.loadBookWantChangeCbx();
            this.loadStaffCbx();
            this.renderCheckBoxDgv();
            headerCheckbox.MouseClick += new MouseEventHandler(headerCheckbox_Clicked);
        }

        private void headerCheckbox_Clicked(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dgvImportChangeBill.Rows)
            {
                row.Cells[0].Value = headerCheckbox.Checked;
            }

            this.dgvImportChangeBill.RefreshEdit();
        }


        private void searchInput_TextChanged(object sender, EventArgs e)
        {
            this.searchInput.ForeColor = Color.Black;

            List<ImportChangeBillDTO> ImportChangeBillList = ImportChangeBillBUS.Instance.search(this.searchInput.Text.ToString());

            this.loadImportChangeBillListToDataView(ImportChangeBillList);
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            this.searchInput.Clear();
            this.supplierCbx.SelectedIndex = 0;
            this.bookNeedChangeCbx.SelectedIndex = 0;
            this.bookWantChangeCbx.SelectedIndex = 0;
            this.staffCbx.SelectedIndex = 0;
            List<ImportChangeBillDTO> ImportChangeBillList = ImportChangeBillBUS.Instance.search("");
            this.loadImportChangeBillListToDataView(ImportChangeBillList);
        }

        // export excel
        private void exportBtn_Click(object sender, EventArgs e)
        {
            List<ImportChangeBillDTO> ImportChangeBillList = ImportChangeBillBUS.Instance.search(this.searchInput.Text.ToString());

            DataTable dataTable = CustomExcel.Instance.ConvertListToDataTable(ImportChangeBillList);

            string[] headerList = new string[] { "Mã phiếu", "Mã nhà cung cấp", "Mã sách cần đổi", "Mã sách muốn đổi", "Mã nhân viên", "Tình trạng đổi hàng", "Lý do", "Ngày lập" };

            CustomExcel.Instance.ExportFile(dataTable, "ImportChangeBill Manage", "Cửa hàng bán sách", headerList);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            bool isHaveSelect = false;

            foreach (DataGridViewRow row in this.dgvImportChangeBill.Rows)
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
                foreach (DataGridViewRow row in this.dgvImportChangeBill.Rows)
                {
                    if ((bool)row.Cells[0].Value == true)
                    {
                        ImportChangeBillBUS.Instance.delete(row.Cells[1].Value.ToString());
                    }

                }
                List<ImportChangeBillDTO> ImportChangeBillList = ImportChangeBillBUS.Instance.search(this.searchInput.Text.ToString());

                this.loadImportChangeBillListToDataView(ImportChangeBillList);

                MessageBox.Show("Delete successful");
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            /*using (ImportChangeBillModal ImportChangeBillModal = new ImportChangeBillModal())
            {
                ImportChangeBillModal.ShowDialog();


                if (ImportChangeBillModal.isSubmitSuccess)
                {
                    List<ImportChangeBillDTO> ImportChangeBillList = ImportChangeBillBUS.Instance.search(this.searchInput.Text.ToString());

                    this.loadImportChangeBillListToDataView(ImportChangeBillList);
                }
            }*/
        }

        private void printPdfBtn_Click(object sender, EventArgs e)
        {

        }

        private void dgvImportChangeBill_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (e.RowIndex < 0 || e.ColumnIndex <= 0)
            {
                return;
            }

            using (ImportChangeBillModal ImportChangeBillModal = new ImportChangeBillModal("Sửa sách"))
            {
                DataGridViewRow row = this.dgvImportChangeBill.Rows[e.RowIndex];

                ImportChangeBillDTO ImportChangeBill = ImportChangeBillBUS.Instance.getById(row.Cells[1].Value.ToString());

                ImportChangeBillModal.updateImportChangeBill = ImportChangeBill;

                if (ImportChangeBillModal.updateImportChangeBill == null)
                {
                    MessageBox.Show("Đã xảy ra lỗi vui lòng thử lại sau!!");
                    return;
                }

                ImportChangeBillModal.ShowDialog();

                if (ImportChangeBillModal.isSubmitSuccess)
                {
                    List<ImportChangeBillDTO> ImportChangeBillList = ImportChangeBillBUS.Instance.search(this.searchInput.Text.ToString());

                    this.loadImportChangeBillListToDataView(ImportChangeBillList);
                }
            }*/
        }

        private List<ImportChangeBillDTO> handleFilter(string searchText)
        {
            List<ImportChangeBillDTO> importChangeBillList = ImportChangeBillBUS.Instance.search(searchText);

            if (DateTime.Compare(this.dateTimeFrom.Value, this.dateTimeTo.Value) <= 0 && this.filterCkx.Checked)
            {
                try
                {
                    importChangeBillList = importChangeBillList.FindAll(
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
            int bookNeedChangeId = Convert.ToInt32(this.bookNeedChangeCbx.SelectedValue);
            int bookWantChangeId = Convert.ToInt32(this.bookWantChangeCbx.SelectedValue);
            int staffId = Convert.ToInt32(this.staffCbx.SelectedValue);

            List<ImportChangeBillDTO> newImportChangeBillList = importChangeBillList.FindAll(importChangeBill =>
            {
                if (supplierId != 0 && bookNeedChangeId != 0 && bookWantChangeId != 0 && staffId != 0)
                {
                    return importChangeBill.MaNhaCungCap == supplierId &&
                           importChangeBill.SachCanDoi == bookNeedChangeId &&
                           importChangeBill.SachMuonDoi == bookWantChangeId &&
                           importChangeBill.MaNhanVien == staffId;
                }

                if (supplierId == 0 && bookNeedChangeId != 0 && bookWantChangeId != 0 && staffId != 0)
                {
                    return importChangeBill.SachCanDoi == bookNeedChangeId &&
                           importChangeBill.SachMuonDoi == bookWantChangeId &&
                           importChangeBill.MaNhanVien == staffId;
                }

                if (supplierId == 0 && bookNeedChangeId == 0 && bookWantChangeId != 0 && staffId != 0)
                {
                    return importChangeBill.SachMuonDoi == bookWantChangeId &&
                           importChangeBill.MaNhanVien == staffId;
                }

                if (supplierId == 0 && bookNeedChangeId == 0 && bookWantChangeId == 0 && staffId != 0)
                {
                    return importChangeBill.MaNhanVien == staffId;
                }

                if (supplierId != 0 && bookNeedChangeId == 0 && bookWantChangeId != 0 && staffId != 0)
                {
                    return importChangeBill.MaNhaCungCap == supplierId &&
                           importChangeBill.SachMuonDoi == bookWantChangeId &&
                           importChangeBill.MaNhanVien == staffId;
                }

                if (supplierId != 0 && bookNeedChangeId == 0 && bookWantChangeId == 0 && staffId != 0)
                {
                    return importChangeBill.MaNhaCungCap == supplierId &&
                           importChangeBill.MaNhanVien == staffId;
                }
                
                if (supplierId != 0 && bookNeedChangeId == 0 && bookWantChangeId == 0 && staffId == 0)
                {
                    return importChangeBill.MaNhaCungCap == supplierId;
                }
                
                if (supplierId != 0 && bookNeedChangeId != 0 && bookWantChangeId == 0 && staffId != 0)
                {
                    return importChangeBill.MaNhaCungCap == supplierId &&
                           importChangeBill.SachCanDoi == bookNeedChangeId &&
                           importChangeBill.MaNhanVien == staffId;
                }
                
                if (supplierId != 0 && bookNeedChangeId != 0 && bookWantChangeId == 0 && staffId == 0)
                {
                    return importChangeBill.MaNhaCungCap == supplierId &&
                           importChangeBill.SachCanDoi == bookNeedChangeId;
                }
                
                if (supplierId != 0 && bookNeedChangeId != 0 && bookWantChangeId != 0 && staffId == 0)
                {
                    return importChangeBill.MaNhaCungCap == supplierId &&
                           importChangeBill.SachCanDoi == bookNeedChangeId &&
                           importChangeBill.SachMuonDoi == bookWantChangeId;
                }
                
                if (supplierId == 0 && bookNeedChangeId == 0 && bookWantChangeId != 0 && staffId == 0)
                {
                    return importChangeBill.SachMuonDoi == bookWantChangeId;
                }

                if (supplierId == 0 && bookNeedChangeId != 0 && bookWantChangeId == 0 && staffId == 0)
                {
                    return importChangeBill.SachCanDoi == bookNeedChangeId;
                }

                if (supplierId != 0 && bookNeedChangeId == 0 && bookWantChangeId != 0 && staffId == 0)
                {
                    return importChangeBill.MaNhaCungCap == supplierId &&
                           importChangeBill.SachMuonDoi == bookWantChangeId;
                }

                if (supplierId == 0 && bookNeedChangeId != 0 && bookWantChangeId != 0 && staffId == 0)
                {
                    return importChangeBill.SachCanDoi == bookNeedChangeId &&
                           importChangeBill.SachMuonDoi == bookWantChangeId;
                }

                if (supplierId == 0 && bookNeedChangeId != 0 && bookWantChangeId == 0 && staffId != 0)
                {
                    return importChangeBill.SachCanDoi == bookNeedChangeId &&
                           importChangeBill.MaNhanVien == staffId;
                }

                return true;
            });


            return newImportChangeBillList;
        }

        private void bookNeedChangeCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<ImportChangeBillDTO> importChangeBillList = handleFilter(this.searchInput.Text.ToString());

            this.loadImportChangeBillListToDataView(importChangeBillList);
        }

        private void bookWantChangeCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<ImportChangeBillDTO> importChangeBillList = handleFilter(this.searchInput.Text.ToString());

            this.loadImportChangeBillListToDataView(importChangeBillList);
        }
        private void supplierCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<ImportChangeBillDTO> importChangeBillList = handleFilter(this.searchInput.Text.ToString());

            this.loadImportChangeBillListToDataView(importChangeBillList);
        }

        private void staffCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<ImportChangeBillDTO> importChangeBillList = handleFilter(this.searchInput.Text.ToString());

            this.loadImportChangeBillListToDataView(importChangeBillList);
        }

        private void filterCkx_CheckedChanged(object sender, EventArgs e)
        {
            this.dateTimeFrom.Enabled = this.filterCkx.Checked;
            this.dateTimeTo.Enabled = this.filterCkx.Checked;
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

            List<ImportChangeBillDTO> importChangeBillList = handleFilter(this.searchInput.Text.ToString());

            this.loadImportChangeBillListToDataView(importChangeBillList);
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

            List<ImportChangeBillDTO> importChangeBillList = handleFilter(this.searchInput.Text.ToString());

            this.loadImportChangeBillListToDataView(importChangeBillList);
        }
    }
}
