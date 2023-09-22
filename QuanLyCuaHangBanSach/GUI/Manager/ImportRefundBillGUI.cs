using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;
using QuanLyCuaHangBanSach.GUI.Modal;
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
	public partial class ImportRefundBillGUI : Form
	{
		private CheckBox headerCheckbox;
		private string[] status = {"Chọn trạng thái" ,"Mot", "Hai", "Ba" };
		public ImportRefundBillGUI()
		{
			InitializeComponent();
		}
		private void renderCheckBoxDgv()
		{
			int size = 25;

			Rectangle rect = this.dgvImportRefund.GetCellDisplayRectangle(0, -1, false);

			headerCheckbox = new CheckBox();

			headerCheckbox.BackColor = Color.FromArgb(45, 210, 192);
			headerCheckbox.Name = "chkHeader";
			headerCheckbox.Size = new Size(size, size);

			rect.X = (rect.Width / 2) - (size / 4);
			rect.Y = (rect.Height / 2) - (size / 2);

			headerCheckbox.Location = rect.Location;


			this.dgvImportRefund.Controls.Add(headerCheckbox);
		}
		private void closeBtn_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void ImportRefundBillGUI_FormClosed(object sender, FormClosedEventArgs e)
		{
	
		}
		private void loadDataToDGV(List<ImportRefundBillDTO> importRefundBills)
		{
				this.dgvImportRefund.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 210, 192);
				this.dgvImportRefund.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

				this.dgvImportRefund.Rows.Clear();
			if (importRefundBills != null)
				{
					foreach(var importRefundBill in importRefundBills)
					{
						dgvImportRefund.Rows.Add(new object[]
						{
							false,
							importRefundBill.MaPhieu,
							importRefundBill.MaDonNhapHang,
							importRefundBill.MaNhanVien,
							importRefundBill.LiDo,
							SupplierBUS.Instance.getById(importRefundBill.NhaCungCapDaTra.ToString()).TenNhaCungCap,
							importRefundBill.TongTien,
							importRefundBill.NgayLap,
						});
					}	
				}	
		}
		private void ImportRefundBillGUI_Load(object sender, EventArgs e)
		{
			renderCheckBoxDgv();
			this.dateTimeFrom.Enabled = this.filterCkx.Checked;
			this.dateTimeTo.Enabled = this.filterCkx.Checked;
			// load supplier cbx
			loadSupplierCbx();
			List<ImportRefundBillDTO> importRefundBills = ImportRefundBillBUS.Instance.getAllData();
			loadDataToDGV(importRefundBills);
		}
		private void loadSupplierCbx()
		{
			List<SupplierDTO> suppliers = SupplierBUS.Instance.getAllData();
			suppliers.Insert(0,new SupplierDTO(0,"Chọn nhà cung cấp","",""));
			this.supplierCbx.DisplayMember = "TenNhaCungCap";
			this.supplierCbx.ValueMember = "MaNhaCungCap";
			this.supplierCbx.DataSource = suppliers;

			this.supplierCbx.SelectedIndex = 0;
		}

		private void deleteBtn_Click(object sender, EventArgs e)
		{
			DialogResult deleteDialogResult = MessageBox.Show(
					"Bạn có chắc chắn muốn xóa các khách hàng đã chọn",
					"Xác nhận",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.None
				);
			if (deleteDialogResult == DialogResult.Yes)
			{
				foreach (DataGridViewRow row in dgvImportRefund.Rows)
				{
					if ((bool)row.Cells[0].Value)
					{
						try
						{
							ImportRefundBillBUS.Instance.delete(row.Cells[1].Value.ToString());
						}
						catch (Exception ex)
						{

						}
					}
				}
				List<ImportRefundBillDTO> importRefundBillDTOs = this.handleFilter(this.searchInput.Text);
				loadDataToDGV(importRefundBillDTOs);

			}
			
		}

		private void addBtn_Click(object sender, EventArgs e)
		{
			using (var modal = new ImportRefundBillModal())
			{
				modal.ShowDialog();
				if (modal.isSubmitSucces)
				{
					List<ImportRefundBillDTO> importRefundBills = this.handleFilter(this.searchInput.Text);
					loadDataToDGV(importRefundBills);
				}	
			}	
		}


		public List<ImportRefundBillDTO> handleFilter(string searchInput)
		{
			List<ImportRefundBillDTO> importRefundBills = ImportRefundBillBUS.Instance.search(searchInput);
			try
			{
				if (DateTime.Compare(dateTimeTo.Value, dateTimeFrom.Value) >= 0 && filterCkx.Checked)
				{
					try
					{
						importRefundBills = importRefundBills.Where(item =>

							 DateTime.Compare(item.NgayLap, dateTimeFrom.Value) >= 0 &&
							 DateTime.Compare(item.NgayLap, dateTimeTo.Value) <= 0
						).ToList();
					}
					catch
					{
						MessageBox.Show("Lọc theo khoảng thời gian không hợp lệ");
					}
				}
				if (supplierCbx.SelectedIndex != 0)
				{
					importRefundBills = importRefundBills.Where(item =>
								item.NhaCungCapDaTra == Convert.ToInt32( supplierCbx.SelectedValue)
						).ToList();
				}
			}
			catch (Exception ex) { }

			return importRefundBills;
		}
		private void btnRefresh_Click(object sender, EventArgs e)
		{
			this.searchInput.Clear();
			this.supplierCbx.SelectedIndex = 0;
			List<ImportRefundBillDTO> importRefundBills = ImportRefundBillBUS.Instance.getAllData();
			this.loadDataToDGV(importRefundBills);
		}

		private void detailsBtn_Click(object sender, EventArgs e)
		{
			if (this.dgvImportRefund.CurrentCell.RowIndex < 0)
			{
				MessageBox.Show("Hãy chọn khách hàng muốn chỉnh sửa");
				return;
			}
			using (var modal = new ImportRefundBillModal())
			{
				DataGridViewRow selectedRow = dgvImportRefund.Rows[dgvImportRefund.CurrentCell.RowIndex];
				ImportRefundBillDTO importRefundBill = ImportRefundBillBUS.Instance.getById(selectedRow.Cells[1].Value.ToString());
				modal.importRefundBill = importRefundBill;
				modal.ShowDialog();
			}
		}

		private void dgvImportRefund_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void filterCkx_CheckedChanged(object sender, EventArgs e)
		{
			this.dateTimeFrom.Enabled = this.filterCkx.Checked;
			this.dateTimeTo.Enabled = this.filterCkx.Checked;

			var importRefundBills = handleFilter(this.searchInput.Text);
			loadDataToDGV(importRefundBills);
		}

		private void dateTimeFrom_ValueChanged(object sender, EventArgs e)
		{
			bool validateFromTo = DateTime.Compare(dateTimeFrom.Value, dateTimeTo.Value) <= 0;
			if (!validateFromTo)
			{

				MessageBox.Show("Bạn không thể chọn ngày lớn hơn ngày " + dateTimeTo.Value.GetDateTimeFormats()[0]);
				dateTimeFrom.Value = dateTimeTo.Value;
				return;
			}
			List<ImportRefundBillDTO> importRefundBills = this.handleFilter(this.searchInput.Text);
			loadDataToDGV(importRefundBills);
		}

		private void dateTimeTo_ValueChanged(object sender, EventArgs e)
		{
			bool validateTimeTo = DateTime.Compare(dateTimeTo.Value, dateTimeFrom.Value) >= 0;
			if (!validateTimeTo)
			{

				MessageBox.Show("Bạn không thể chọn ngày nhỏ hơn ngày " + dateTimeFrom.Value.GetDateTimeFormats()[0]);
				dateTimeTo.Value = dateTimeFrom.Value;
				return;
			}
			List<ImportRefundBillDTO> importRefundBills = this.handleFilter(this.searchInput.Text);
			loadDataToDGV(importRefundBills);
		}

		private void supplierCbx_SelectedIndexChanged(object sender, EventArgs e)
		{
			var importRefundBills = this.handleFilter(this.searchInput.Text);
			loadDataToDGV(importRefundBills);
		}
	}
}
