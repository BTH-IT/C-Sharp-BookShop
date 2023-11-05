using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;
using QuanLyCuaHangBanSach.GUI.Modal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyCuaHangBanSach.GUI.Manager
{
    public partial class SupplierManagerGUI : Form
    {
        private CheckBox headerCheckbox;
        public SupplierManagerGUI()
        {
            InitializeComponent();
        }
        private void renderCheckBoxDgv()
        {
            try
            {
                int size = 25;

                Rectangle rect = this.dgvSupplier.GetCellDisplayRectangle(0, -1, false);
                headerCheckbox = new CheckBox();

                headerCheckbox.BackColor = Color.FromArgb(45, 210, 192);
                headerCheckbox.Name = "chkHeader";
                headerCheckbox.Size = new Size(size, size);

                rect.X = (rect.Width / 2) - (size / 4);
                rect.Y = (rect.Height / 2) - (size / 2);

                headerCheckbox.Location = rect.Location;

                this.dgvSupplier.Controls.Add(headerCheckbox);
            }
            catch (Exception er)
            {

                Console.WriteLine(er);
            }
        }

        private void loadSupplierListToDataView(List<SupplierDTO> SupplierList)
        {
            try
            {
                this.dgvSupplier.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 210, 192);
                this.dgvSupplier.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                this.dgvSupplier.Rows.Clear();

                foreach (SupplierDTO Supplier in SupplierList)
                {
                    this.dgvSupplier.Rows.Add(new object[] {
                    false,
                    Supplier.MaNhaCungCap,
                    Supplier.TenNhaCungCap,
                    Supplier.DiaChi,
                    Supplier.SoDienThoai,
                    Supplier.TrangThai ? "Đang hoạt động" : "Ngưng hoạt động",
                });
                }
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
                foreach (DataGridViewRow row in this.dgvSupplier.Rows)
                {
                    row.Cells[0].Value = headerCheckbox.Checked;
                }

                this.dgvSupplier.RefreshEdit();
            }
            catch (Exception er)
            {

                Console.WriteLine(er);
            }
        }

        private void searchInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.searchInput.ForeColor = Color.Black;
                List<SupplierDTO> SupplierList = SupplierBUS.Instance.search(this.searchInput.Text.ToString());
                this.loadSupplierListToDataView(SupplierList);
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
                string[] headerList = new string[] { "Mã nhà cung cấp", "Tên nhà cung cấp", "Địa chỉ", "Số điện thoại" };
                DataTable dt = CustomExcel.Instance.ConvertDataGridViewToDataTable(dgvSupplier);

                CustomExcel.Instance.ExportFileDatagridView(dt, "Book Manage", 1, "Cửa hàng bán sách", headerList);
            }
            catch (Exception er)
            {

                Console.WriteLine(er);
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvSupplier.CurrentCell.RowIndex < 0)
                {
                    MessageBox.Show("Hãy chọn dòng dữ liệu muốn thao tác");
                    return;
                }

                using (SupplierModal SupplierModal = new SupplierModal("Sửa nhà cung cấp"))
                {
                    DataGridViewRow row = this.dgvSupplier.Rows[this.dgvSupplier.CurrentCell.RowIndex];

                    SupplierDTO Supplier = SupplierBUS.Instance.getById(row.Cells[1].Value.ToString());

                    SupplierModal.updateSupplier = Supplier;

                    if (SupplierModal.updateSupplier == null)
                    {
                        MessageBox.Show("Đã xảy ra lỗi vui lòng thử lại sau!!");
                        return;
                    }

                    SupplierModal.ShowDialog();

                    if (SupplierModal.isSubmitSuccess)
                    {
                        List<SupplierDTO> SupplierList = SupplierBUS.Instance.search(this.searchInput.Text.ToString());

                        this.loadSupplierListToDataView(SupplierList);
                    }
                }
            }
            catch (Exception er)
            {

                Console.WriteLine(er);
            }
        }

        private void dgvSupplier_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0 || e.ColumnIndex <= 0)
                {
                    return;
                }

                using (SupplierModal SupplierModal = new SupplierModal("Sửa nhà cung cấp"))
                {
                    DataGridViewRow row = this.dgvSupplier.Rows[e.RowIndex];

                    SupplierDTO Supplier = SupplierBUS.Instance.getById(row.Cells[1].Value.ToString());

                    SupplierModal.updateSupplier = Supplier;
                    if (SupplierModal.updateSupplier == null)
                    {
                        MessageBox.Show("Đã xảy ra lỗi vui lòng thử lại sau!!");
                        return;
                    }

                    SupplierModal.ShowDialog();

                    if (SupplierModal.isSubmitSuccess)
                    {
                        List<SupplierDTO> SupplierList = SupplierBUS.Instance.search(this.searchInput.Text.ToString());

                        this.loadSupplierListToDataView(SupplierList);
                    }
                }
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

                List<SupplierDTO> SupplierList = SupplierBUS.Instance.search("");
                this.loadSupplierListToDataView(SupplierList);
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
                using (SupplierModal SupplierModal = new SupplierModal())
                {
                    SupplierModal.ShowDialog();


                    if (SupplierModal.isSubmitSuccess)
                    {
                        List<SupplierDTO> SupplierList = SupplierBUS.Instance.search(this.searchInput.Text.ToString());

                        this.loadSupplierListToDataView(SupplierList);
                    }
                }
            }
            catch (Exception er)
            {

                Console.WriteLine(er);
            }
        }

        private void SupplierManagerGUI_Load(object sender, EventArgs e)
        {
            try
            {
                List<SupplierDTO> SupplierList = SupplierBUS.Instance.getAllData();
                this.loadSupplierListToDataView(SupplierList);

                this.renderCheckBoxDgv();
                headerCheckbox.MouseClick += new MouseEventHandler(headerCheckbox_Clicked);
            }
            catch (Exception er)
            {

                Console.WriteLine(er);
            }
        }
    }
}
