using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using LiveCharts;
using LiveCharts.Wpf;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.GUI.Manager
{
    public partial class HomeManageGUI : Form
    {
        public HomeManageGUI()
        {
            InitializeComponent();

            cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Tháng",
                Labels = new string[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
            });

            cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Doanh thu",
                Labels = new string[] { "0", "1", "2", "3", "4", "5", "6" }
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

            cartesianChart1.Series.Add(new LineSeries
            {
                Values = new ChartValues<int> { 3, 4, 6, 3, 2, 6 },
                Stroke = new SolidColorBrush(System.Windows.Media.Color.FromRgb(45, 210, 192)),
                Fill = gradientBrush,
            });

            List<AccountDTO> list = AccountBUS.Instance.getAllData();

            foreach (AccountDTO account in list)
            {
                this.gunaDataGridView1.Rows.Add(new object[] { account.MaNhanVien, account.Email, account.MatKhau });
            }
        }
    }
}
