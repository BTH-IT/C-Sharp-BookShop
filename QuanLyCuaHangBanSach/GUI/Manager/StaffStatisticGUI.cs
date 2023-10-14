using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Media;
using ZXing.QrCode.Internal;
using Color = System.Drawing.Color;
using QuanLyCuaHangBanSach.DAO;
using System.Windows.Ink;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyCuaHangBanSach.GUI.Manager
{
	public partial class StaffStatisticGUI : Form
	{
		public StaffStatisticGUI()
		{
			InitializeComponent();
			//
			// Event Assign
			//
			boughtFrom.MouseLeave += searchInput_MouseLeave;
			boughtTo.MouseLeave += searchInput_MouseLeave;

			boughtFrom.TextChanged += searchInput_TextChanged;
			boughtTo.TextChanged += searchInput_TextChanged;

			boughtTo.KeyPress += boughtFrom_KeyPress;
		}

		private void loadBillListToDataView(List<StaffDTO> staffList)
		{
			try
			{
				dgvStaff.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 210, 192);
				dgvStaff.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

				dgvStaff.Rows.Clear();

				if (staffList != null)
				{
					foreach (StaffDTO staff in staffList)
					{
						dgvStaff.Rows.Add(new object[] {
							staff.Ma,
							staff.Ten,
							staff.SoDienThoai,
							string.Format("{0:N0} VNĐ", StaffBUS.Instance.getSoldRevenue(staff.Ma.ToString()))
						});
					} 
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
		}

		private void dgvStaff_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
		{
			if (e.Column.Index == dgvStaff.Columns.Count - 1) // Check if sorting the last column
			{
				// Extract the values for sorting from the cell values
				double value1 = GetSortingValue(e.CellValue1);
				double value2 = GetSortingValue(e.CellValue2);

				// Compare the extracted values
				e.SortResult = value1.CompareTo(value2);

				// Mark the comparison as handled to prevent default sorting
				e.Handled = true;
			}
		}

		private double GetSortingValue(object cellValue)
		{
			if (cellValue == null)
				return 0;

			// Extract the numerical value from the string (remove " VNĐ" and parse)
			string stringValue = cellValue.ToString();
			stringValue = stringValue.Replace(".", "").Replace(" VNĐ", "");

			if (double.TryParse(stringValue, out double numericValue))
			{
				// Convert the numeric value to a sortable string
				return numericValue;
			}

			return 0;
		}

		private void StaffStatisticGUI_Load(object sender, EventArgs e)
		{ 	
			try
			{
				List<StaffDTO> staffList = StaffBUS.Instance.getAllData();
				loadBillListToDataView(staffList);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
		}

		private List<StaffDTO> handleFilter(string query)
		{
			try
			{
				List<StaffDTO> staffList = StaffBUS.Instance.search(query);

				if (!string.IsNullOrEmpty(boughtFrom.Text) && string.IsNullOrEmpty(boughtTo.Text))
				{
					staffList = staffList.FindAll(staff => StaffBUS.Instance.getSoldRevenue(staff.Ma.ToString()) >= Convert.ToDouble(boughtFrom.Text));
				}

				if (string.IsNullOrEmpty(boughtFrom.Text) && !string.IsNullOrEmpty(boughtTo.Text))
				{
					staffList = staffList.FindAll(staff => StaffBUS.Instance.getSoldRevenue(staff.Ma.ToString()) <= Convert.ToDouble(boughtTo.Text));
				}

				if (!string.IsNullOrEmpty(boughtFrom.Text) && !string.IsNullOrEmpty(boughtTo.Text))
				{
					staffList = staffList.FindAll(staff => StaffBUS.Instance.getSoldRevenue(staff.Ma.ToString()) >= Convert.ToDouble(boughtFrom.Text)
													 && StaffBUS.Instance.getSoldRevenue(staff.Ma.ToString()) <= Convert.ToDouble(boughtTo.Text));
				}

				return staffList;
			}
			catch (Exception)
			{
				return new List<StaffDTO>();
			}
		}

		private void searchInput_TextChanged(object sender, EventArgs e)
		{
			try
			{
                List<StaffDTO> staffList = handleFilter(searchInput.Text);
				loadBillListToDataView(staffList);

            }
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
		}

		private void refreshBtn_Click(object sender, EventArgs e)
		{
			try
			{
				searchInput.Clear();

				boughtFrom.Clear();
				boughtTo.Clear();


				List<StaffDTO> staffList = StaffBUS.Instance.getAllData();
				loadBillListToDataView(staffList);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
		}

		private void exportBtn_Click(object sender, EventArgs e)
		{
			try
			{
                string[] headerList = new string[] { "Mã nhân viên", "Tên nhân viên", "Số điện thoại", "Doanh thu" };

				DataTable dt = CustomExcel.Instance.ConvertDataGridViewToDataTable(dgvStaff);

				CustomExcel.Instance.ExportFileDatagridView(dt, "Book Manage", 0, "Cửa hàng bán sách", headerList);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
		}

		private void boughtFrom_KeyPress(object sender, KeyPressEventArgs e)
		{
			try
			{
				if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
				{
					e.Handled = true; // Cancel the key press event
				}
			}
			catch (Exception ex) { Console.WriteLine(ex); }
		}

        private void searchInput_MouseLeave(object sender, EventArgs e)
        {
			try
			{
				optionPanel.Focus();
			}
            catch (Exception ex) { Console.WriteLine(ex); }
        }

		private void closeBtn_Click(object sender, EventArgs e)
		{
			Hide();
		}
	}
}
