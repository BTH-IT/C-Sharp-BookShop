using LiveCharts.Wpf;
using LiveCharts;
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
using System.ComponentModel;

namespace QuanLyCuaHangBanSach.GUI.Manager
{
	public partial class RevenueStatisticGUI : Form
	{
		private int mode;

		private Dictionary<int, string> stringMonth = new Dictionary<int, string>
		{
			{ 1,  "Jan" },
			{ 2,  "Feb" },
			{ 3,  "Mar" },
			{ 4,  "Abr" },
			{ 5,  "May" },
			{ 6,  "Jun" },
			{ 7,  "Jul" },
			{ 8,  "Aug" },
			{ 9,  "Sep" },
			{ 10, "Oct" },
			{ 11, "Nov" },
			{ 12, "Dec" },
		};

		public RevenueStatisticGUI(int mode)
		{
			InitializeComponent();
			this.mode = mode;

			toDate.Value = DateTime.Now;

			//
			// Event Assign
			//
			revenueFrom.MouseLeave += searchInput_MouseLeave;
			revenueTo.MouseLeave += searchInput_MouseLeave;

			revenueFrom.TextChanged += searchInput_TextChanged;
			revenueTo.TextChanged += searchInput_TextChanged;

			revenueTo.KeyPress += revenueFrom_KeyPress;
		}

		private double RoundToNearestTenThousand(double money)
		{
			double remainder = money * 1.0 % 10000;

			if (remainder < 5000)
			{
				return money - remainder;
			}
			else
			{
				return money + (10000.0 - remainder);
			}
		}

		private void loadChartView()
		{
			try
			{
				// Chart
				DateTime now = DateTime.Now;
				int month = now.Month;
				List<int> months = new List<int>();
				List<string> strLabel = new List<string>();
				for (int m = month - 5; m <= month; m++)
				{
					months.Add(m);
					strLabel.Add(stringMonth[m]);
				}

				cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
				{
					Title = "Tháng",
					Labels = strLabel
				});
				List<CustomerBillDTO> billList = CustomerBillBUS.Instance.getAllInRange(now.Year.ToString(), (month - 5).ToString(), month.ToString());
				double tongTienBill = 0;
				foreach (CustomerBillDTO bill in billList)
				{
					tongTienBill += bill.TongTien;
				}
				double maxValRounded = RoundToNearestTenThousand(tongTienBill);

				List<string> strValueLabel = new List<string>();

				for (double i = 0; i <= maxValRounded; i += 50000)
				{
					strValueLabel.Add(i.ToString());
				}

				cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
				{
					Title = "Doanh thu",
					MinValue = 0,
					Labels = strValueLabel
				});
				cartesianChart1.Series.Clear();
				cartesianChart1.LegendLocation = LiveCharts.LegendLocation.Right;

				var gradientBrush = new LinearGradientBrush
				{
					StartPoint = new System.Windows.Point(0, 0),
					EndPoint = new System.Windows.Point(0, 1)
				};
				gradientBrush.GradientStops.Add(new GradientStop(System.Windows.Media.Color.FromRgb(153, 246, 228), 0));
				gradientBrush.GradientStops.Add(new GradientStop(Colors.Transparent, 1));

				ChartValues<double> chartVals = new ChartValues<double>();

				foreach (int m in months)
				{
					if (billList != null)
					{
						double doanhThu = 0;
						foreach (CustomerBillDTO bill in billList)
						{
							if (bill.NgayLap.Month == m)
							{
								doanhThu += bill.TongTien;
							}
						}
						chartVals.Add(doanhThu / 50000.0);
					}
					else
					{
						chartVals.Add(0);
					}
				}

				cartesianChart1.Series.Add(new LineSeries
				{
					Title = "Doanh thu",
					Values = chartVals,
					Stroke = new SolidColorBrush(System.Windows.Media.Color.FromRgb(45, 210, 192)),
					LineSmoothness = 0,
					Fill = gradientBrush,
					LabelPoint = point => ": " + string.Format("{0:N0} VNĐ", point.Y * 50000.0)
				});

				// Revenue
				double revenue = CustomerBillBUS.Instance.getRevenueInRange(now.Year.ToString(), (month - 5).ToString(), month.ToString());
				revenueLb.Text = string.Format("{0:N0} VNĐ", revenue);

				DataTable numberBookSoldDT = CustomerBillBUS.Instance.getBookSoldInRange(now.Year.ToString(), (month - 5).ToString(), month.ToString());
				int bookSold = 0;
				foreach (DataRow row in numberBookSoldDT.Rows)
				{
					bookSold += Convert.ToInt32(row["soLuong"]);
				}
				bookSoldLb.Text = $@"{bookSold} quyển sách";

				int customerNumber = CustomerBillBUS.Instance.getNumberCustomerInRange(now.Year.ToString(), (month - 5).ToString(), month.ToString());
				customerNumLb.Text = $@"{customerNumber} khách hàng";
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
		}

		private double DiscountMoneyCal(int phanTramKM, double tongTien)
		{
			double km = (100 - phanTramKM * 1.0) / 100.0;
			return tongTien / km;
		}

		private void loadBillListToDataView(List<CustomerBillDTO> billList)
		{
			try
			{
				this.modeCheck.Start();
				dgvBill.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 210, 192);
				dgvBill.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

				dgvBill.Rows.Clear();

				if (billList != null)
				{
					foreach (CustomerBillDTO bill in billList)
					{
						int phanTramKM = bill.MaKhuyenMai != 0 ? SaleBUS.Instance.getById(bill.MaKhuyenMai.ToString()).PhanTram : 0;
						dgvBill.Rows.Add(new object[] {
							bill.NgayLap,
							bill.MaDonKhachHang,
							bill.MaKhuyenMai != 0 ? string.Format("{0:N0} VNĐ", DiscountMoneyCal(phanTramKM, bill.TongTien)) : "Không khuyến mãi",
							string.Format("{0:N0} VNĐ", bill.TongTien)
						});
					}
				}
				dgvBill.Sort(dgvBill.Columns["Column6"], System.ComponentModel.ListSortDirection.Descending);
			}

			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
		}

		private void dgvBill_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
		{
			if (e.Column.Index == dgvBill.Columns.Count - 1) // Check if sorting the last column
			{
				// Extract the values for sorting from the cell values
				double value1 = GetRevenueSortingValue(e.CellValue1);
				double value2 = GetRevenueSortingValue(e.CellValue2);

				// Compare the extracted values
				e.SortResult = value1.CompareTo(value2);

				// Mark the comparison as handled to prevent default sorting
				e.Handled = true;
			}
			if (e.Column.Index == dgvBill.Columns.Count - 2)
			{
				// Extract the values for sorting from the cell values
				double value1 = GetDiscountSortingValue(e.CellValue1);
				double value2 = GetDiscountSortingValue(e.CellValue2);

				// Compare the extracted values
				e.SortResult = value1.CompareTo(value2);

				// Mark the comparison as handled to prevent default sorting
				e.Handled = true;
			}
		}

		private double GetRevenueSortingValue(object cellValue)
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
		private double GetDiscountSortingValue(object cellValue)
		{
			if (cellValue == null)
				return 0;

			// Extract the numerical value from the string (remove " VNĐ" and parse)
			string stringValue = cellValue.ToString();
			if (stringValue.Equals("Không khuyến mãi"))
			{
				return 0;
			}

			stringValue = stringValue.Replace(".", "").Replace(" VNĐ", "");

			if (double.TryParse(stringValue, out double numericValue))
			{
				// Convert the numeric value to a sortable string
				return numericValue;
			}

			return 0;
		}

		private void RevenueStatisticGUI_Load(object sender, EventArgs e)
		{
			try
			{
				List<CustomerBillDTO> billList = CustomerBillBUS.Instance.getAllData();
				loadBillListToDataView(billList);
				loadChartView();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
		}

		private List<CustomerBillDTO> handleFilter(string query)
		{
			try
			{
				List<CustomerBillDTO> billList = CustomerBillBUS.Instance.search(query);

                if (fromDateCkb.Checked && !toDateCkb.Checked)
                {
					DateTime fromDateVal = new DateTime(fromDate.Value.Year, fromDate.Value.Month, fromDate.Value.Day);
					billList = billList.FindAll(bill => bill.NgayLap >= fromDateVal);
				}

				if (!fromDateCkb.Checked && toDateCkb.Checked)
				{
					DateTime toDateVal = new DateTime(toDate.Value.Year, toDate.Value.Month, toDate.Value.Day);
					billList = billList.FindAll(bill => bill.NgayLap <= toDateVal);
				}

				if (fromDateCkb.Checked && toDateCkb.Checked)
				{
					DateTime fromDateVal = new DateTime(fromDate.Value.Year, fromDate.Value.Month, fromDate.Value.Day);
					DateTime toDateVal = new DateTime(toDate.Value.Year, toDate.Value.Month, toDate.Value.Day);
					billList = billList.FindAll(bill => bill.NgayLap >= fromDateVal && bill.NgayLap <= toDateVal);
				}

				if (!string.IsNullOrEmpty(revenueFrom.Text) && string.IsNullOrEmpty(revenueTo.Text))
				{
					billList = billList.FindAll(bill => bill.TongTien >= Convert.ToDouble(revenueFrom.Text));
				}

				if (string.IsNullOrEmpty(revenueFrom.Text) && !string.IsNullOrEmpty(revenueTo.Text))
				{
					billList = billList.FindAll(bill => bill.TongTien <= Convert.ToDouble(revenueTo.Text));
				}

				if (!string.IsNullOrEmpty(revenueFrom.Text) && !string.IsNullOrEmpty(revenueTo.Text))
				{
					billList = billList.FindAll(bill => bill.TongTien >= Convert.ToDouble(revenueFrom.Text)
													 && bill.TongTien <= Convert.ToDouble(revenueTo.Text));
				}

				return billList;
			}
			catch (Exception)
			{
				return new List<CustomerBillDTO>();
			}
		}

		private void searchInput_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<CustomerBillDTO> billList = handleFilter(searchInput.Text);
				loadBillListToDataView(billList);

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

				revenueFrom.Clear();
				revenueTo.Clear();


				List<CustomerBillDTO> billList = CustomerBillBUS.Instance.getAllData();
				loadBillListToDataView(billList);
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
				string[] headerList = new string[] { "Ngày lập hóa đơn", "Mã hóa đơn", "Khuyến mãi", "Doanh thu" };

				DataTable dt = CustomExcel.Instance.ConvertDataGridViewToDataTable(dgvBill);

				CustomExcel.Instance.ExportFileDatagridView(dt, "Book Manage", 0, "Cửa hàng bán sách", headerList);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
		}

		private void revenueFrom_KeyPress(object sender, KeyPressEventArgs e)
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

		private void modeCheck_Tick(object sender, EventArgs e)
		{
			if (mode == 1)
			{
				tablePanel.BringToFront();
				tableBtn.Checked = true;
				tableBtn.Cursor = Cursors.No;
				chartBtn.Checked = false;
				chartBtn.Cursor = Cursors.Default;
				refreshBtn.Checked = false;
				refreshBtn.Cursor = Cursors.Default;
				exportBtn.Checked = false;
				exportBtn.Cursor = Cursors.Default;
			}
			else
			{
				chartPanel.BringToFront();
				tableBtn.Checked = false;
				tableBtn.Cursor = Cursors.Default;
				chartBtn.Checked = true;
				chartBtn.Cursor = Cursors.No;
				refreshBtn.Checked = true;
				refreshBtn.Cursor = Cursors.No;
				exportBtn.Checked = true;
				exportBtn.Cursor = Cursors.No;
			}
		}

		private void tableBtn_Click(object sender, EventArgs e)
		{
			if (!this.modeCheck.Enabled) this.modeCheck.Start();
			mode = 1;
		}

		private void chartBtn_Click(object sender, EventArgs e)
		{
			if (!this.modeCheck.Enabled) this.modeCheck.Start();
			mode = 2;
		}

		private void fromDateCkb_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				fromDate.Enabled = fromDate.Enabled ? false : true;
				List<CustomerBillDTO> billList = handleFilter(searchInput.Text);
				loadBillListToDataView(billList);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
		}

		private void toDateCkb_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				toDate.Enabled = toDate.Enabled ? false : true;
				List<CustomerBillDTO> billList = handleFilter(searchInput.Text);
				loadBillListToDataView(billList);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
		}

		private void fromDate_ValueChanged(object sender, EventArgs e)
		{
			try
			{
				List<CustomerBillDTO> billList = handleFilter(searchInput.Text);
				loadBillListToDataView(billList);

			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
		}

		private void toDate_ValueChanged(object sender, EventArgs e)
		{
			try
			{
				List<CustomerBillDTO> billList = handleFilter(searchInput.Text);
				loadBillListToDataView(billList);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
		}

		private void closeBtn_Click(object sender, EventArgs e)
		{
			this.modeCheck.Stop();
			Hide();
		}
	}
}
