using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;
using QuanLyCuaHangBanSach.GUI.Modal;
using QuanLyCuaHangBanSach.GUI.Report;
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

namespace QuanLyCuaHangBanSach.GUI.Manager
{
	public partial class OrderBillManagerGUI : Form
	{
		public OrderBillManagerGUI()
		{
			InitializeComponent();
		}
		private void loadOrderBillListToDataView(List<OrderBillDTO> orderBillList)
		{
			try
			{
				this.dgvOrderBill.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 210, 192);
				this.dgvOrderBill.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				this.dgvOrderBill.ColumnHeadersDefaultCellStyle.Font = new Font("#9Slide03 Cabin", 10, FontStyle.Regular);
				this.dgvOrderBill.Rows.Clear();

				foreach (OrderBillDTO orderBill in orderBillList)
				{
					this.dgvOrderBill.Rows.Add(new object[] {
					orderBill.MaPhieuYeuCau,
					SupplierBUS.Instance.getById(orderBill.MaNhaCungCap.ToString()).TenNhaCungCap,
					StaffBUS.Instance.getById(orderBill.MaNhanVien.ToString()).Ten,
					orderBill.NgayLap.GetDateTimeFormats()[0],
					orderBill.TrangThai ? "Đã nhận" : "Chưa nhận"
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
		private void searchInput_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<OrderBillDTO> orderBillList = handleFilter(this.searchInput.Text.Trim());

				this.loadOrderBillListToDataView(orderBillList);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
		}

		private List<OrderBillDTO> handleFilter(string v)
		{
			try
			{
				List<OrderBillDTO> OrderBillList = OrderBillBUS.Instance.search(v);
				if (DateTime.Compare(this.dateTimeFrom.Value, this.dateTimeTo.Value) <= 0 && this.filterCkx.Checked)
				{
					try
					{
						OrderBillList = OrderBillList.FindAll(
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

				List<OrderBillDTO> newOrderBillList = OrderBillList.FindAll(OrderBill =>
				{
					if (supplierId != 0 && staffId != 0)
					{
						return OrderBill.MaNhaCungCap == supplierId &&
							   OrderBill.MaNhanVien == staffId;
					}

					if (supplierId == 0 && staffId != 0)
					{
						return OrderBill.MaNhanVien == staffId;
					}

					if (supplierId != 0 && staffId == 0)
					{
						return OrderBill.MaNhaCungCap == supplierId;
					}

					return true;
				});


				return newOrderBillList;
			}
			catch (Exception ex)
			{
				return new List<OrderBillDTO>();
			}
		}
		private void refreshBtn_Click(object sender, EventArgs e)
		{
			try
			{
				this.searchInput.Clear();

				this.supplierCbx.SelectedIndex = 0;
				this.staffCbx.SelectedIndex = 0;

				this.filterCkx.Checked = false;
				this.dateTimeFrom.Enabled = false;
				this.dateTimeTo.Enabled = false;

				this.dateTimeFrom.Refresh();
				this.dateTimeTo.Refresh();

				List<OrderBillDTO> orderBillList = handleFilter("");

				this.loadOrderBillListToDataView(orderBillList);
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
				List<OrderBillDTO> orderBillList = handleFilter("");

				this.loadOrderBillListToDataView(orderBillList);
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
				List<OrderBillDTO> orderBillList = handleFilter("");

				this.loadOrderBillListToDataView(orderBillList);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
		}
		private void exportBtn_Click(object sender, EventArgs e)
		{
			if (dgvOrderBill.Rows.Count <= 0)
			{
				MessageBox.Show("Bảng dữ liệu hiện tại chưa có dòng dữ liệu nào để xuất excel!");
				return;
			}

			try
			{
				string[] headerList = new string[] { "Mã phiếu yêu cầu", "Nhà cung cấp", "Nhân viên", "Ngày lập", "Trạng thái" };

				DataTable dt = CustomExcel.Instance.ConvertDataGridViewToDataTable(dgvOrderBill);

				CustomExcel.Instance.ExportFileDatagridView(dt, "Book Manage", 0, "Cửa hàng bán sách", headerList);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
		}
		private void dgvImportBill_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0 || e.ColumnIndex <= 0)
			{
				return;
			}

			DataGridViewRow row = this.dgvOrderBill.Rows[this.dgvOrderBill.CurrentCell.RowIndex];
			OrderBillDTO OrderBill = OrderBillBUS.Instance.getById(row.Cells[0].Value.ToString());

			using (ViewOrderBillModal viewOrderBillModal = new ViewOrderBillModal(OrderBill))
			{
				viewOrderBillModal.ShowDialog();
			}
		}
		private void viewMoreBtn_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.dgvOrderBill.CurrentCell != null)
				{
					if (this.dgvOrderBill.CurrentCell.RowIndex < 0)
					{
						MessageBox.Show("Hãy chọn dòng dữ liệu muốn thao tác");
						return;
					}

					DataGridViewRow row = this.dgvOrderBill.Rows[this.dgvOrderBill.CurrentCell.RowIndex];
					OrderBillDTO OrderBill = OrderBillBUS.Instance.getById(row.Cells[0].Value.ToString());

					using (ViewOrderBillModal viewOrderBillModal = new ViewOrderBillModal(OrderBill))
					{
						viewOrderBillModal.ShowDialog();
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
		private void OrderBillManagerGUI_Load(object sender, EventArgs e)
		{
			try
			{
				this.dateTimeFrom.Enabled = this.filterCkx.Checked;
				this.dateTimeTo.Enabled = this.filterCkx.Checked;
				List<OrderBillDTO> orderBillList = OrderBillBUS.Instance.getAllData();
				this.loadOrderBillListToDataView(orderBillList);
				this.loadSupplierCbx();
				this.loadStaffCbx();

			}
			
			catch{

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

				List<OrderBillDTO> orderBillList = handleFilter("");

				this.loadOrderBillListToDataView(orderBillList);
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

				List<OrderBillDTO> orderBillList = handleFilter("");

				this.loadOrderBillListToDataView(orderBillList);
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
			List<OrderBillDTO> orderBillList = handleFilter("");
			this.loadOrderBillListToDataView(orderBillList);
		}
		private void printPdfBtn_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.dgvOrderBill.CurrentCell != null)
				{
					if (this.dgvOrderBill.CurrentCell.RowIndex < 0 || this.dgvOrderBill.CurrentCell == null)
					{
						MessageBox.Show("Hãy chọn dòng dữ liệu muốn thao tác");
						return;
					}

					DataGridViewRow row = this.dgvOrderBill.Rows[this.dgvOrderBill.CurrentCell.RowIndex];
					// sửa lại
					using (OrderBillPrintForm orderBillPrintForm = new OrderBillPrintForm(Convert.ToInt32(row.Cells[0].Value)))
					{
						orderBillPrintForm.ShowDialog();
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
	}
}
