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
            try
            {
				List<SaleDTO> sales = SaleBUS.Instance.getAllData();
				this.dateTimeFrom.Enabled = this.filterCkx.Checked;
				this.dateTimeTo.Enabled = this.filterCkx.Checked;

				this.renderCheckBoxDgv();
				this.loadDataToDataGridView(sales);
				headerCheckbox.MouseClick += new MouseEventHandler(headerCheckBox_Clicked);
			}
            catch
            {

            }
        }

        private void headerCheckBox_Clicked(object sender, EventArgs e)
        {
            try
            {
				foreach (DataGridViewRow row in this.dgvSale.Rows)
				{
					row.Cells[0].Value = headerCheckbox.Checked;
					this.dgvSale.RefreshEdit();
				}
			}
            catch
            {

            }
          
        }

        private void filterCkx_CheckChanged(object sender, EventArgs e)
        {
            try
            {
                this.dateTimeFrom.Enabled = this.filterCkx.Checked;
                this.dateTimeTo.Enabled = this.filterCkx.Checked;
           
				var sales = handleFilter(this.searchInput.Text);
                loadDataToDataGridView(sales);
            }
            catch
            {

            }
		}

        private void dateTimeTo_ValueChanged(object sender, EventArgs e)
        {
            try
            {
				bool validateTimeTo = DateTime.Compare(dateTimeTo.Value, dateTimeFrom.Value) >= 0;
				if (!validateTimeTo)
				{

					MessageBox.Show("Bạn không thể chọn ngày nhỏ hơn ngày " + dateTimeFrom.Value.GetDateTimeFormats()[0]);
					dateTimeTo.Value = dateTimeFrom.Value;
					return;
				}
				List<SaleDTO> sales = handleFilter(searchInput.Text);
				loadDataToDataGridView(sales);
			}
            catch
            {

            }
        }

        private void dateTimeFrom_Changed(object sender, EventArgs e)
        {
            try
            {
				bool validateFromTo = DateTime.Compare(dateTimeFrom.Value, dateTimeTo.Value) <= 0;
				if (!validateFromTo)
				{

					MessageBox.Show("Bạn không thể chọn ngày lớn hơn ngày " + dateTimeTo.Value.GetDateTimeFormats()[0]);
					dateTimeFrom.Value = dateTimeTo.Value;
					return;
				}
				List<SaleDTO> sales = handleFilter(searchInput.Text);
				loadDataToDataGridView(sales);
			}
            catch
            {

            }
         
        }

        private void dgvCell_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
				if (e.RowIndex < 0 || e.ColumnIndex <= 0)
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

						List<SaleDTO> sales = handleFilter(this.searchInput.Text);
						this.loadDataToDataGridView(sales);
					}
				}
			}
			catch 
            { }  
         
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try {
				this.searchInput.Clear();
				this.filterCkx.Checked = false;

				List<SaleDTO> sales = SaleBUS.Instance.getAllData();
				this.loadDataToDataGridView(sales);
			}
            catch { }
        
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
				string[] headerList = new string[] { "Mã Khuyến mãi", "Tên khuyến mãi", "Phẩn trăm", "Ngày bắt đầu", "Ngày kết thúc" };
                DataTable dt = CustomExcel.Instance.ConvertDataGridViewToDataTable(dgvSale);

                CustomExcel.Instance.ExportFileDatagridView(dt, "Book Manage", 1, "Cửa hàng bán sách", headerList);
            }
            catch
            {

            }
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
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
            catch
            {

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
				if (this.dgvSale.CurrentCell.RowIndex < 0)
				{
					MessageBox.Show("Hãy chọn khuyến mãi để chỉnh sửa");
					return;
				}
				using (SaleModal modal = new SaleModal("Sửa thông tin khuyến mãi"))
				{
					DataGridViewRow selectedRow = this.dgvSale.Rows[this.dgvSale.CurrentCell.RowIndex];
					SaleDTO sale = SaleBUS.Instance.getById(selectedRow.Cells[1].Value.ToString());
					modal.sale = sale;

					modal.ShowDialog();

					if (modal.isSubmitSuccess)
					{

						List<SaleDTO> sales = handleFilter(this.searchInput.Text);
						this.loadDataToDataGridView(sales);
					}
				}
			}
            catch
            {

            }
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
			{
				DialogResult dialogResult = MessageBox.Show(
					"Bạn có chắc xóa những khuyến mãi đã chọn",
					"Xác nhận",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.None
				);
				bool hasCheckedRow = false;
				foreach (DataGridViewRow row in this.dgvSale.Rows)
				{
					if ((bool)row.Cells[0].Value)
					{
						hasCheckedRow = true;
					}
				}
				if (dialogResult == DialogResult.Yes)
				{
					if(hasCheckedRow)
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
                    else
                    {
                        MessageBox.Show("Vui lòng chọn khuyến mãi để xóa", "Thông báo");
                    }  
					
				}

			}
            catch
            {

            }
             
        }
        private List<SaleDTO> handleFilter(string searchString)
        {
            try
            {
				List<SaleDTO> sales = SaleBUS.Instance.search(searchString);

				if (DateTime.Compare(dateTimeTo.Value, dateTimeFrom.Value) >= 0 && filterCkx.Checked)
				{
					try
					{
						sales = sales.Where(item =>

							 DateTime.Compare(item.NgayBatDau, dateTimeFrom.Value) >= 0 &&
							 DateTime.Compare(item.NgayKetThuc, dateTimeTo.Value) <= 0
						).ToList();
					}
					catch
					{
						MessageBox.Show("Lọc theo khoảng thời gian không hợp lệ");
					}
				}
				return sales;
			}
            catch
            {
                return null;

            }
        }
        private void searchInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
				this.searchInput.ForeColor = Color.Black;
				List<SaleDTO> sales = handleFilter(this.searchInput.Text);
				loadDataToDataGridView(sales);
			}
            catch
            {

            }
           
        }
    }
}
