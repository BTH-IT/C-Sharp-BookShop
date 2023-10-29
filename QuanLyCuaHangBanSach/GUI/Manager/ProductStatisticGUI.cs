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
using System.IO;

namespace QuanLyCuaHangBanSach.GUI.Manager
{
    public partial class ProductStatisticGUI : Form
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

        public ProductStatisticGUI(int mode)
		{
			InitializeComponent();
			this.mode = mode;

			//
			// Event Assign
			//

			lowSortInp.MouseLeave += searchInput_MouseLeave;
            highSortInp.MouseLeave += searchInput_MouseLeave;
            revenueFrom.MouseLeave += searchInput_MouseLeave;
            revenueTo.MouseLeave += searchInput_MouseLeave;

			lowSortInp.TextChanged += searchInput_TextChanged;
            highSortInp.TextChanged += searchInput_TextChanged;
            revenueFrom.TextChanged += searchInput_TextChanged;
            revenueTo.TextChanged += searchInput_TextChanged;

            highSortInp.KeyPress += highSortInp_KeyPress;
            revenueFrom.KeyPress += highSortInp_KeyPress;
            revenueTo.KeyPress += highSortInp_KeyPress;
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
				DataTable numberBookSoldDT = CustomerBillBUS.Instance.getBookSoldInRange(now.Year.ToString(), (month - 5).ToString(), month.ToString());
				int maxVal = 0;
				foreach (DataRow row in numberBookSoldDT.Rows)
				{
					maxVal = Math.Max(maxVal, Convert.ToInt32(row["soLuong"]));
				}
				int maxValRounded = (int)Math.Ceiling((double)maxVal / 10) * 10;

				List<string> strValueLabel = new List<string>();

				for (int i = 0; i <= maxValRounded; i += 10)
				{
					strValueLabel.Add(i.ToString());
				}

				cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
				{
					Title = "Số lượng sách",
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
					if (numberBookSoldDT != null)
					{
						bool found = false;
						foreach (DataRow row in numberBookSoldDT.Rows)
						{
							if (Convert.ToInt32(row["thang"]) == m)
							{
								found = true;
								chartVals.Add(Convert.ToInt32(row["soLuong"]) / 10.0);
								break;
							}
						}
						if (!found)
						{
							chartVals.Add(0);
						} 
					}
					else
					{
						chartVals.Add(0);
					}
				}

				cartesianChart1.Series.Add(new LineSeries
				{
					Title = "Số lượng",
					Values = chartVals,
					Stroke = new SolidColorBrush(System.Windows.Media.Color.FromRgb(45, 210, 192)),
					LineSmoothness = 0,
					Fill = gradientBrush,
					Margin = new System.Windows.Thickness(100),
					LabelPoint = point => ": " + Convert.ToInt32(point.Y * 10) + " quyển sách"
				});

				// Revenue
				double revenue = CustomerBillBUS.Instance.getRevenueInRange(now.Year.ToString(), (month - 5).ToString(), month.ToString());
				revenueLb.Text = string.Format("{0:N0} VNĐ", revenue);

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

        private void loadBookListToDataView(List<BookDTO> bookList)
		{
			try
			{
				dgvBook.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 210, 192);
				dgvBook.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

				dgvBook.Rows.Clear();

				if (bookList != null)
				{
					foreach (BookDTO book in bookList)
					{
						int daBan = CustomerBillBUS.Instance.getSoldQuantity(book.MaSach.ToString());
						double doanhThu = CustomerBillBUS.Instance.getRevenue(book.MaSach.ToString());

						dgvBook.Rows.Add(new object[] {
							book.MaSach,
							book.TenSach,
							book.HinhAnh,
							daBan,
							string.Format("{0:N0} VNĐ", doanhThu)
						});
					} 
				}
				dgvBook.Sort(dgvBook.Columns["Column6"], System.ComponentModel.ListSortDirection.Descending);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
		}

		private void dgvBook_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
		{
			if (e.Column.Index == dgvBook.Columns.Count - 1) // Check if sorting the last column
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
			stringValue = stringValue.Replace(",", "").Replace(" VNĐ", "");

            if (double.TryParse(stringValue, out double numericValue))
			{
				// Convert the numeric value to a sortable string
				return numericValue;
			}

			return 0;
		}

		private void ProductStatisticGUI_Load(object sender, EventArgs e)
		{
			try
			{
				List<BookDTO> bookList = BookBUS.Instance.getAllData();
				loadBookListToDataView(bookList);
				loadChartView();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
		}

		private DataTable handleFilter(string query)
		{
			try
			{
				DataTable bookListDT = CustomerBillBUS.Instance.getSoldQuantityAndRevenue(query);

				if (!string.IsNullOrEmpty(lowSortInp.Text))
				{
					List<DataRow> rowsToRemove = new List<DataRow>();

					foreach (DataRow row in bookListDT.Rows)
					{
						if (Convert.ToInt32(row["daBan"]) >= Convert.ToInt32(lowSortInp.Text))
						{
							rowsToRemove.Add(row);
						}
					}

					foreach (DataRow rowToRemove in rowsToRemove)
					{
						bookListDT.Rows.Remove(rowToRemove);
					}
				}

				if (!string.IsNullOrEmpty(highSortInp.Text))
				{
					List<DataRow> rowsToRemove = new List<DataRow>();

					foreach (DataRow row in bookListDT.Rows)
					{
						if (Convert.ToInt32(row["daBan"]) <= Convert.ToInt32(highSortInp.Text))
						{
							rowsToRemove.Add(row);
						}
					}

					foreach (DataRow rowToRemove in rowsToRemove)
					{
						bookListDT.Rows.Remove(rowToRemove);
					}
				}

				if (!string.IsNullOrEmpty(revenueFrom.Text) && string.IsNullOrEmpty(revenueTo.Text))
				{
					List<DataRow> rowsToRemove = new List<DataRow>();

					foreach (DataRow row in bookListDT.Rows)
					{
						if (Convert.ToDouble(row["doanhThu"]) <= Convert.ToInt32(revenueFrom.Text))
						{
							rowsToRemove.Add(row);
						}
					}

					foreach (DataRow rowToRemove in rowsToRemove)
					{
						bookListDT.Rows.Remove(rowToRemove);
					}
				}

				if (string.IsNullOrEmpty(revenueFrom.Text) && !string.IsNullOrEmpty(revenueTo.Text))
				{
					List<DataRow> rowsToRemove = new List<DataRow>();

					foreach (DataRow row in bookListDT.Rows)
					{
						if (Convert.ToDouble(row["doanhThu"]) >= Convert.ToInt32(revenueTo.Text))
						{
							rowsToRemove.Add(row);
						}
					}

					foreach (DataRow rowToRemove in rowsToRemove)
					{
						bookListDT.Rows.Remove(rowToRemove);
					}
				}

				if (!string.IsNullOrEmpty(revenueFrom.Text) && !string.IsNullOrEmpty(revenueTo.Text))
				{
					List<DataRow> rowsToRemove = new List<DataRow>();

					foreach (DataRow row in bookListDT.Rows)
					{
						if (!(Convert.ToDouble(row["doanhThu"]) >= Convert.ToInt32(revenueFrom.Text) && Convert.ToDouble(row["doanhThu"]) <= Convert.ToInt32(revenueTo.Text)))
						{
							rowsToRemove.Add(row);
						}
					}

					foreach (DataRow rowToRemove in rowsToRemove)
					{
						bookListDT.Rows.Remove(rowToRemove);
					}
				}

				return bookListDT;
			}
			catch (Exception)
			{
				return new DataTable();
			}
		}

		private List<BookDTO> convertTableToList(DataTable dt)
		{
			List<BookDTO> bookList = new List<BookDTO>();
            foreach (DataRow row in dt.Rows)
            {
				BookDTO book = BookBUS.Instance.getById(row["maSach"].ToString());
				bookList.Add(book);
            }

			if (bookList.Count == 0) return null;

            return bookList;
		}

		private void searchInput_TextChanged(object sender, EventArgs e)
		{
			try
			{
                List<BookDTO> bookList = convertTableToList(handleFilter(searchInput.Text));
				loadBookListToDataView(bookList);

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

				highSortCkb.Checked = false;
				lowSortCkb.Checked = false;

				List<BookDTO> bookList = BookBUS.Instance.getAllData();
				loadBookListToDataView(bookList);
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
				string[] headerList = new string[] { "Mã sách", "Tên sách", "Giá bán", "Giá nhập", "Đã bán", "Doanh thu" };

                DataTable dt = CustomExcel.Instance.ConvertDataGridViewToDataTable(dgvBook);

                CustomExcel.Instance.ExportFileDatagridView(dt, "Book Manage", 0, "Cửa hàng bán sách", headerList, 2);
            }
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
		}

		private void highSortCkb_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				if (highSortCkb.Checked == true)
				{
					lowSortCkb.Checked = false;
					highSortInp.Enabled = true;
				}
				else
				{
					highSortInp.Text = "";
					highSortInp.Enabled = false;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
		}

		private void lowSortCkb_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				if (lowSortCkb.Checked == true)
				{
					highSortCkb.Checked = false;
                    lowSortInp.Enabled = true;
				}
				else
				{
					lowSortInp.Text = "";
					lowSortInp.Enabled = false;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
		}

		private void highSortInp_KeyPress(object sender, KeyPressEventArgs e)
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

		private void closeBtn_Click(object sender, EventArgs e)
		{
			Hide();
		}
	}
}
