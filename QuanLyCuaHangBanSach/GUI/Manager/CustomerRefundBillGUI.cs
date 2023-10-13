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
	public partial class CustomerRefundBillGUI : Form
	{
		private CheckBox headerCheckbox;
		public CustomerRefundBillGUI()
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
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void CustomerRefundBillGUI_FormClosed(object sender, FormClosedEventArgs e)
		{
		}
		private void loadDataToDGV(List<CustomerRefundBillDTO> customerRefundBills)
		{
			try
			{
				this.dgvImportRefund.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 210, 192);
				this.dgvImportRefund.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

				this.dgvImportRefund.Rows.Clear();
				if (customerRefundBills != null)
				{
					foreach (var customerRefundBill in customerRefundBills)
					{
						CustomerBillDTO customerBillDTO = CustomerBillBUS.Instance.getById(customerRefundBill.MaDonKhachHang.ToString());
						dgvImportRefund.Rows.Add(new object[]
						{
							false,
							customerRefundBill.MaPhieu,
							customerRefundBill.MaDonKhachHang,
							StaffBUS.Instance.getById(customerRefundBill.MaNhanVien.ToString()).Ten,
							customerRefundBill.LiDo,
							customerRefundBill.TongTien,
							customerRefundBill.NgayLap
						});
					}
				}
			}
			catch { 
			}
			
		}
		private void CustomerRefundBillGUI_Load(object sender, EventArgs e)
		{
			try
			{
				renderCheckBoxDgv();
				this.dateTimeFrom.Enabled = this.filterCkx.Checked;
				this.dateTimeTo.Enabled = this.filterCkx.Checked;
				List<CustomerRefundBillDTO> customerRefundBills = CustomerRefundBillBUS.Instance.getAllData();
				loadDataToDGV(customerRefundBills);
			}
			catch
			{

			}
		}

		private void filterCkx_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				this.dateTimeFrom.Enabled = this.filterCkx.Checked;
				this.dateTimeTo.Enabled = this.filterCkx.Checked;

				var customerRefundBills = handleFilter(this.searchInput.Text);
				loadDataToDGV(customerRefundBills);

			}
			catch { 
			}	
		}

		private List<CustomerRefundBillDTO> handleFilter(string text)
		{
			List<CustomerRefundBillDTO> customerRefundBills = CustomerRefundBillBUS.Instance.search(text);
			try
			{
				if (DateTime.Compare(dateTimeTo.Value, dateTimeFrom.Value) >= 0 && filterCkx.Checked)
				{
					try
					{
						customerRefundBills = customerRefundBills.Where(item =>

							 DateTime.Compare(item.NgayLap, dateTimeFrom.Value) >= 0 &&
							 DateTime.Compare(item.NgayLap, dateTimeTo.Value) <= 0
						).ToList();
					}
					catch
					{
						MessageBox.Show("Lọc theo khoảng thời gian không hợp lệ");
					}
				}
			}
			catch
			{

			}
			return customerRefundBills;
		}

		private void dateTimeFrom_ValueChanged(object sender, EventArgs e)
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
				List<CustomerRefundBillDTO> customerRefundBills = this.handleFilter(this.searchInput.Text);
				loadDataToDGV(customerRefundBills);
			}
			catch 
			{
			}	
			
		}

		private void dateTimeTo_ValueChanged(object sender, EventArgs e)
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
				List<CustomerRefundBillDTO> customerRefundBills = this.handleFilter(this.searchInput.Text);
				loadDataToDGV(customerRefundBills);
			}
			catch
			{

			}
			
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			try
			{
				this.searchInput.Clear();
				this.filterCkx.Checked = false;
				List<CustomerRefundBillDTO> customerRefundBills = CustomerRefundBillBUS.Instance.getAllData();
				loadDataToDGV(customerRefundBills);
			}
			catch
			{

			}
			
		}

		private void addBtn_Click(object sender, EventArgs e)
		{
			try
			{
				using (var modal = new CustomerRefundBillModal())
				{
					modal.ShowDialog();
					if (modal.isSubmitSuccess)
					{
						List<CustomerRefundBillDTO> customerRefundBills = this.handleFilter(this.searchInput.Text);
						loadDataToDGV(customerRefundBills);
					}
				}
			}
			catch
			{

			}
			
		}

		private void detailsBtn_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.dgvImportRefund.CurrentCell.RowIndex < 0)
				{
					MessageBox.Show("Hãy chọn phiếu trả muốn xem");
					return;
				}
				using (var modal = new CustomerRefundBillModal("Xem chi tiết phiếu trả bán hàng"))
				{
					DataGridViewRow selectedRow = dgvImportRefund.Rows[dgvImportRefund.CurrentCell.RowIndex];
					CustomerRefundBillDTO customerRefundBill = CustomerRefundBillBUS.Instance.getById(selectedRow.Cells[1].Value.ToString());
					modal.customerRefundBill = customerRefundBill;
					modal.ShowDialog();
				}
			}
			catch 
			{ }
			
		}

		private void deleteBtn_Click(object sender, EventArgs e)
		{
			try
			{
				DialogResult deleteDialogResult = MessageBox.Show(
					"Bạn có chắc chắn muốn xóa các phiếu đã chọn",
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
								CustomerRefundBillBUS.Instance.delete(row.Cells[1].Value.ToString());
							}
							catch (Exception ex)
							{
								Console.WriteLine(ex.Message);
							}
						}
					}
					List<CustomerRefundBillDTO> customerRefundBills = this.handleFilter(this.searchInput.Text);
					loadDataToDGV(customerRefundBills);

				}
			}
			catch
			{

			}
			
		}

		private void closeBtn_Click(object sender, EventArgs e)
		{
			this.Hide();	
		}

        private void btnExport_Click(object sender, EventArgs e)
        {

        }
    }
}
