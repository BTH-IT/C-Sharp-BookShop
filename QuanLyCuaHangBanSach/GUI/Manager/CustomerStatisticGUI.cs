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

namespace QuanLyCuaHangBanSach.GUI.Manager
{
    public partial class CustomerStatisticGUI : Form
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

        public CustomerStatisticGUI(int mode)
		{
			InitializeComponent();
			this.mode = mode;

			//
			// Event Assign
			//
            boughtFrom.MouseLeave += searchInput_MouseLeave;
            boughtTo.MouseLeave += searchInput_MouseLeave;

            boughtFrom.TextChanged += searchInput_TextChanged;
            boughtTo.TextChanged += searchInput_TextChanged;

            boughtTo.KeyPress += boughtFrom_KeyPress;
        }

		//private double RoundToNearestTenThousand(double money)
		//{
		//	double remainder = money * 1.0 % 10000;

		//	if (remainder < 5000)
		//	{
		//		return money - remainder;
		//	}
		//	else
		//	{
		//		return money + (10000.0 - remainder);
		//	}
		//}

		private void loadChartView()
		{
			//try
			//{
			//	// Chart
			//	DateTime now = DateTime.Now;
			//	int month = now.Month;
			//	List<int> months = new List<int>();
			//	List<string> strLabel = new List<string>();
			//	for (int m = month - 5; m <= month; m++)
			//	{
			//		months.Add(m);
			//		strLabel.Add(stringMonth[m]);
			//	}

			//	cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
			//	{
			//		Title = "Tháng",
			//		Labels = strLabel
			//	});
			//	List<CustomerDTO> customerList = CustomerBillBUS.Instance.getAllInRange(now.Year.ToString(), (month - 5).ToString(), month.ToString());
			//	double tongTienBill = 0;
			//	foreach (CustomerDTO customer in customerList)
   //             {
			//		tongTienBill += customer.TongTien;
   //             }
			//	double maxValRounded = RoundToNearestTenThousand(tongTienBill);

			//	List<string> strValueLabel = new List<string>();

			//	for (double i = 0; i <= maxValRounded; i += 50000)
			//	{
			//		strValueLabel.Add(i.ToString());
			//	}

			//	cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
			//	{
			//		Title = "Doanh thu",
			//		MinValue = 0,
			//		Labels = strValueLabel
			//	});
			//	cartesianChart1.Series.Clear();
			//	cartesianChart1.LegendLocation = LiveCharts.LegendLocation.Right;

			//	var gradientBrush = new LinearGradientBrush
			//	{
			//		StartPoint = new System.Windows.Point(0, 0),
			//		EndPoint = new System.Windows.Point(0, 1)
			//	};
			//	gradientBrush.GradientStops.Add(new GradientStop(System.Windows.Media.Color.FromRgb(153, 246, 228), 0));
			//	gradientBrush.GradientStops.Add(new GradientStop(Colors.Transparent, 1));

			//	ChartValues<double> chartVals = new ChartValues<double>();

			//	foreach (int m in months)
			//	{
			//		if (customerList != null)
			//		{
			//			double doanhThu = 0;
			//			foreach (CustomerDTO customer in customerList)
			//			{
			//				if (customer.NgayLap.Month == m)
			//				{
			//					doanhThu += customer.TongTien;
			//				}
			//			}
			//			chartVals.Add(doanhThu / 50000.0);
			//		}
			//		else
			//		{
			//			chartVals.Add(0);
			//		}
			//	}

			//	cartesianChart1.Series.Add(new LineSeries
			//	{
			//		Title = "Doanh thu",
			//		Values = chartVals,
			//		Stroke = new SolidColorBrush(System.Windows.Media.Color.FromRgb(45, 210, 192)),
			//		LineSmoothness = 0,
			//		Fill = gradientBrush,
			//		Margin = new System.Windows.Thickness(100),
			//		LabelPoint = point => ": " + string.Format("{0:N0} VNĐ", point.Y * 50000.0)
			//	});

			//	// Revenue
			//	double revenue = CustomerBillBUS.Instance.getRevenueInRange(now.Year.ToString(), (month - 5).ToString(), month.ToString());
			//	revenueLb.Text = string.Format("{0:N0} VNĐ", revenue);

			//	DataTable numberBookSoldDT = CustomerBillBUS.Instance.getBookSoldInRange(now.Year.ToString(), (month - 5).ToString(), month.ToString());
			//	int bookSold = 0;
			//	foreach (DataRow row in numberBookSoldDT.Rows)
			//	{
			//		bookSold += Convert.ToInt32(row["soLuong"]);
			//	}
			//	bookSoldLb.Text = $@"{bookSold} quyển sách";

			//	int customerNumber = CustomerBillBUS.Instance.getNumberCustomerInRange(now.Year.ToString(), (month - 5).ToString(), month.ToString());
			//	customerNumLb.Text = $@"{customerNumber} khách hàng";
			//}
			//catch (Exception ex)
			//{
			//	Console.WriteLine(ex);
			//}
		}

        private void loadBillListToDataView(List<CustomerDTO> customerList)
		{
			try
			{
				dgvCustomer.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 210, 192);
				dgvCustomer.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

				dgvCustomer.Rows.Clear();

				if (customerList != null)
				{
					foreach (CustomerDTO customer in customerList)
					{
						dgvCustomer.Rows.Add(new object[] {
							customer.Ma,
							customer.Ten,
							customer.SoDienThoai,
							CustomerBillBUS.Instance.countBillByCustomerID(customer.Ma.ToString()),
							string.Format("{0:N0} VNĐ", CustomerBillBUS.Instance.getCustomerBoughtTotal(customer.Ma.ToString()))
						});
					} 
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
		}

		private void CustomerStatisticGUI_Load(object sender, EventArgs e)
		{
			try
			{
				List<CustomerDTO> customerList = CustomerBUS.Instance.getAllData();
				loadBillListToDataView(customerList);
				loadChartView();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
		}

		private List<CustomerDTO> handleFilter(string query)
		{
			try
			{
				List<CustomerDTO> customerList = CustomerBUS.Instance.Search(query);

				if (!string.IsNullOrEmpty(boughtFrom.Text) && string.IsNullOrEmpty(boughtTo.Text))
				{
					customerList = customerList.FindAll(customer => CustomerBillBUS.Instance.getCustomerBoughtTotal(customer.Ma.ToString()) >= Convert.ToDouble(boughtFrom.Text));
				}

				if (string.IsNullOrEmpty(boughtFrom.Text) && !string.IsNullOrEmpty(boughtTo.Text))
				{
					customerList = customerList.FindAll(customer => CustomerBillBUS.Instance.getCustomerBoughtTotal(customer.Ma.ToString()) <= Convert.ToDouble(boughtTo.Text));
				}

				if (!string.IsNullOrEmpty(boughtFrom.Text) && !string.IsNullOrEmpty(boughtTo.Text))
				{
					customerList = customerList.FindAll(customer => CustomerBillBUS.Instance.getCustomerBoughtTotal(customer.Ma.ToString()) >= Convert.ToDouble(boughtFrom.Text)
													 && CustomerBillBUS.Instance.getCustomerBoughtTotal(customer.Ma.ToString()) <= Convert.ToDouble(boughtTo.Text));
				}

				return customerList;
			}
			catch (Exception)
			{
				return new List<CustomerDTO>();
			}
		}

		private void searchInput_TextChanged(object sender, EventArgs e)
		{
			try
			{
                List<CustomerDTO> customerList = handleFilter(searchInput.Text);
				loadBillListToDataView(customerList);

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


				List<CustomerDTO> customerList = CustomerBUS.Instance.getAllData();
				loadBillListToDataView(customerList);
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
                List<CustomerDTO> customerList = handleFilter(searchInput.Text);

                DataTable dataTable = CustomExcel.Instance.ConvertListToDataTable(customerList);

                string[] headerList = new string[] { "Ngày lập hóa đơn", "Mã hóa đơn", "Khuyến mãi", "Doanh thu" };

                CustomExcel.Instance.ExportFile(dataTable, "Revenue Statistic", "Cửa hàng bán sách", headerList, 2);
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
			mode = 1;
        }

        private void chartBtn_Click(object sender, EventArgs e)
        {
			mode = 2;
        }
    }
}
