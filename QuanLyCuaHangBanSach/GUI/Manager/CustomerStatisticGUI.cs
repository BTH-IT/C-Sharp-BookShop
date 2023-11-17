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
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading.Tasks;

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

		private void loadChartView()
		{
			DateTime now = DateTime.Now;
			int month = now.Month;

			pieChart1.Series = new LiveCharts.SeriesCollection();
			pieChart1.LegendLocation = LegendLocation.Bottom;
			
			List<CustomerDTO> customerList = CustomerBUS.Instance.loadCustomerChartData();
			bool pushed = false;
			foreach (CustomerDTO customer in customerList)
			{
                if (CustomerBillBUS.Instance.countBillByCustomerID(customer.Ma.ToString()) > 0)
                {
					pieChart1.Series.Add(new PieSeries
					{
						Title = customer.Ten,
						Values = new ChartValues<double> { CustomerBillBUS.Instance.getCustomerBoughtTotal(customer.Ma.ToString()) },
						PushOut = pushed ? 0 : 5,
						DataLabels = true,
						FontSize = 12,
						LabelPoint = chartPoint => string.Format("{0}: {1:P}", customer.Ten, chartPoint.Participation),
					});
					pushed = true;
                }
			}

			//	// Revenue
			double revenue = CustomerBillBUS.Instance.getRevenueInRange(now.Year.ToString(), (month - 5).ToString(), month.ToString());
			revenueLb.Text = string.Format("{0:N0} VNĐ", revenue);

			DataTable numberBookSoldDT = CustomerBillBUS.Instance.getBookSoldInRange(now.Year.ToString(), (month - 5).ToString(), month.ToString());
			int bookSold = 0;
            if (numberBookSoldDT != null)
            {
				foreach (DataRow row in numberBookSoldDT.Rows)
				{
					bookSold += Convert.ToInt32(row["soLuong"]);
				}
            }
			bookSoldLb.Text = $@"{bookSold} quyển sách";

			int customerNumber = CustomerBillBUS.Instance.getNumberCustomerInRange(now.Year.ToString(), (month - 5).ToString(), month.ToString());
			customerNumLb.Text = $@"{customerNumber} khách hàng";
		}

		private void loadBillListToDataView(List<CustomerDTO> customerList)
		{
			try
			{
				this.modeCheck.Start();
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
				dgvCustomer.Sort(dgvCustomer.Columns["Column1"], System.ComponentModel.ListSortDirection.Descending);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
		}

		private void dgvCustomer_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
		{
			if (e.Column.Index == dgvCustomer.Columns.Count - 1) // Check if sorting the last column
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
                    if (Convert.ToDouble(boughtFrom.Text) <= Convert.ToDouble(boughtTo.Text))
                    {
						customerList = customerList.FindAll(customer => CustomerBillBUS.Instance.getCustomerBoughtTotal(customer.Ma.ToString()) >= Convert.ToDouble(boughtFrom.Text)
														 && CustomerBillBUS.Instance.getCustomerBoughtTotal(customer.Ma.ToString()) <= Convert.ToDouble(boughtTo.Text));
                    }
					else
					{
						boughtFrom.Clear();
						boughtTo.Clear();
						MessageBox.Show("Đã mua từ phải nhỏ hơn hoặc bằng Đã mua đến");
					}
				}

				return customerList;
			}
			catch (Exception)
			{
				return new List<CustomerDTO>();
			}
		}

		private readonly int debounceInterval = 500; // Đặt khoảng thời gian debounce là 500 milliseconds
		private DateTime lastTextChanged = DateTime.MinValue;
		private readonly object debounceLock = new object();
		private async void searchInput_TextChanged(object sender, EventArgs e)
		{
			try
			{
				lock (debounceLock)
				{
					lastTextChanged = DateTime.Now;
				}

				await Task.Delay(debounceInterval);

				lock (debounceLock)
				{
					var now = DateTime.Now;
					if ((now - lastTextChanged).TotalMilliseconds >= debounceInterval)
					{
						List<CustomerDTO> customerList = handleFilter(searchInput.Text);
						loadBillListToDataView(customerList);
					}
				}
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
            if (dgvCustomer.Rows.Count <= 0)
            {
                MessageBox.Show("Bảng dữ liệu hiện tại chưa có dòng dữ liệu nào để xuất excel!");
                return;
            }
            try
			{
                string[] headerList = new string[] { "Mã khách hàng", "Tên khách hàng", "Số điện thoại", "Số lượng hóa đơn", "Đã mua" };

				DataTable dt = CustomExcel.Instance.ConvertDataGridViewToDataTable(dgvCustomer);

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

		private void closeBtn_Click(object sender, EventArgs e)
		{
			this.modeCheck.Stop();
			Hide();
		}
	}
}
