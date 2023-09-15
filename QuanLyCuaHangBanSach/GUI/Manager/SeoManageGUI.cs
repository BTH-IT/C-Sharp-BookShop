using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;
using QuanLyCuaHangBanSach.GUI.Modal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyCuaHangBanSach.GUI.Manager
{
    public partial class SeoManageGUI : Form
    {
        private CheckBox headerCheckbox;
        public SeoManageGUI()
        {
            InitializeComponent();
        }
        private void renderCheckBoxDgv()
        {
            int size = 25;

            Rectangle rect = this.dgvSale.GetCellDisplayRectangle(0, -1, false);

            headerCheckbox = new CheckBox();

            headerCheckbox.BackColor = Color.FromArgb(45, 210, 192);
            headerCheckbox.Name = "chkHeader";
            headerCheckbox.Size = new Size(size, size);

            rect.X = (rect.Width / 2) - (size / 4);
            rect.Y = (rect.Height / 2) - (size / 2);

            headerCheckbox.Location = rect.Location;


            this.dgvSale.Controls.Add(headerCheckbox);
        }
        private void loadDataToDataGridView(List<SaleDTO> sales)
        {
            this.dgvSale.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 210, 192);
            this.dgvSale.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dgvSale.Rows.Clear();

            if (sales != null ) 
            { 
                foreach( SaleDTO sale in sales)
                {
                    this.dgvSale.Rows.Add(new object[]
                    {
                        false,
                        sale.MaKhuyenMai,
                        sale.TenKhuyenMai,
                        sale.PhanTram,
                        sale.NgayBatDau,
                        sale.NgayKetThuc,
                    });
                }
            }
        }

        private void salesManagaer_Load(object sender, EventArgs e)
        {
      
            List<SaleDTO> sales = SaleBUS.Instance.getAllData();
            this.dateTimeFrom.Enabled = this.filterCkx.Checked;
            this.dateTimeTo.Enabled = this.filterCkx.Checked;   

            this.renderCheckBoxDgv();
            this.loadDataToDataGridView(sales);
            headerCheckbox.MouseClick += new MouseEventHandler(headerCheckBox_Clicked);
        }

        private void headerCheckBox_Clicked(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in this.dgvSale.Rows)
            {
                row.Cells[0].Value = headerCheckbox.Checked;
                this.dgvSale.RefreshEdit();
            }
        }

        private void filterCkx_CheckChanged(object sender, EventArgs e)
        {
            this.dateTimeFrom.Enabled = this.filterCkx.Checked;
            this.dateTimeTo.Enabled = this.filterCkx.Checked;
        }

        private void dateTimeTo_ValueChanged(object sender, EventArgs e)
        {
            bool validateTimeTo = DateTime.Compare(dateTimeTo.Value, dateTimeFrom.Value) >= 0;
            if(!validateTimeTo)
            {
             
                MessageBox.Show("Bạn không thể chọn ngày nhỏ hơn ngày " + dateTimeFrom.Value.GetDateTimeFormats()[0]);
                return;
            }
            List<SaleDTO> sales = handleFilter(searchInput.Text);
            loadDataToDataGridView(sales);
        }

        private void dateTimeFrom_Changed(object sender, EventArgs e)
        {
            bool validateFromTo = DateTime.Compare(dateTimeFrom.Value, dateTimeTo.Value) <= 0;
            if (!validateFromTo)
            {
               
                MessageBox.Show("Bạn không thể chọn ngày lơn hơn ngày " + dateTimeTo.Value.GetDateTimeFormats()[0]);
                return;
            }
            List<SaleDTO> sales = handleFilter(searchInput.Text);
            loadDataToDataGridView(sales);
        }

        private void dgvCell_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            using (SaleModal modal = new SaleModal("Sửa thông tin khuyến mãi"))
            {
                DataGridViewRow selectedRow = this.dgvSale.Rows[e.RowIndex];
                SaleDTO sale = SaleBUS.Instance.getById(selectedRow.Cells[1].Value.ToString());
            
                modal.sale = sale;

                modal.ShowDialog();

                if (modal.isSubmitSuccess)
                {
                   
                    List<SaleDTO> sales = handleFilter(this.searchInput.Text );
                    this.loadDataToDataGridView(sales);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.searchInput.Clear();
            this.filterCkx.Checked = false;

            List<SaleDTO> sales = SaleBUS.Instance.getAllData();
            this.loadDataToDataGridView(sales);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            
            List<SaleDTO> sales = handleFilter(this.searchInput.Text);
            DataTable dataTable = CustomExcel.Instance.ConvertListToDataTable(sales);
            string[] headerList = new string[] { "Mã Khuyến mãi", "Tên khuyến mãi", "Phẩn trăm", "Ngày bắt đầu", "Ngày kết thúc" };
            CustomExcel.Instance.ExportFile(dataTable: dataTable, sheetName: "Quản lý khuyến mãi", title: "Cửa hàng bán sách", headerList: headerList);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SaleModal modal = new SaleModal())
            {
                modal.ShowDialog();
                
                if (modal.isSubmitSuccess)
                { 
                    
                    List<SaleDTO> sales = handleFilter(this.searchInput.Text);
                    this.loadDataToDataGridView(sales);
                }
            }    
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.dgvSale.CurrentCell.RowIndex < 0)
            {
                MessageBox.Show("Hãy chọn khuyến mãi để chỉnh sửa");
                return;
            }
            using (SaleModal modal = new SaleModal("Sửa thông tin khuyến mãi"))
            {
                DataGridViewRow selectedRow = this.dgvSale.Rows[this.dgvSale.CurrentCell.RowIndex];
                SaleDTO sale = SaleBUS.Instance.getById(selectedRow.Cells[1].ToString());
                
                modal.sale = sale;

                modal.ShowDialog();

                if (modal.isSubmitSuccess)
                {
                    
                    List<SaleDTO> sales = handleFilter(this.searchInput.Text);
                    this.loadDataToDataGridView(sales);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                    "Bạn có chắc xóa những khuyến mãi đã chọn",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.None
                );
            if (dialogResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in this.dgvSale.Rows)
                {
                    if ((bool)row.Cells[0].Value)
                    {
                        SaleBUS.Instance.delete(row.Cells[1].Value.ToString());
                    }
                }
                MessageBox.Show("Bạn đã xóa thành công");
              
                List<SaleDTO> sales = handleFilter(this.searchInput.Text);
                this.loadDataToDataGridView(sales); 
            }    
        }
        private List<SaleDTO> handleFilter(string searchString)
        {
            List<SaleDTO> sales = SaleBUS.Instance.search(searchString);

            if (DateTime.Compare(dateTimeTo.Value,dateTimeFrom.Value) >= 0 && filterCkx.Checked)
            {
                try
                {
                    sales = sales.Where(item =>
                           (DateTime.Compare(item.NgayBatDau, dateTimeFrom.Value) >= 0) &&
                           (DateTime.Compare(dateTimeTo.Value, item.NgayKetThuc) <=0)

                    ).ToList();
                }
                catch
                {
                    MessageBox.Show("Lọc theo khoảng thời gian không hợp lệ");
                }
            }    
            return sales;
        }
        private void searchInput_TextChanged(object sender, EventArgs e)
        {
            this.searchInput.ForeColor = Color.Black;
            List<SaleDTO> sales = handleFilter(this.searchInput.Text);
            loadDataToDataGridView(sales);
        }
    }
}
