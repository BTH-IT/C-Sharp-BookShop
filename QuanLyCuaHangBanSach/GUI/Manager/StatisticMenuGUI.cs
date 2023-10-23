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
    public partial class StatisticMenuGUI : Form
    {
        private ProductStatisticGUI ProductStatisticFrm = new ProductStatisticGUI(1) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None, };
        private RevenueStatisticGUI RevenueStatisticFrm = new RevenueStatisticGUI(1) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None, };
        private CustomerStatisticGUI CustomerStatisticFrm = new CustomerStatisticGUI(1) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None, };
        private StaffStatisticGUI StaffStatisticFrm = new StaffStatisticGUI() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None, };
        public StatisticMenuGUI()
        {
            InitializeComponent();
            Controls.Add(ProductStatisticFrm);
            Controls.Add(RevenueStatisticFrm);
            Controls.Add(StaffStatisticFrm);
            Controls.Add(CustomerStatisticFrm);
        }

        private void ProductPanel_Click(object sender, EventArgs e)
        {
            try
            {
                ProductStatisticFrm.Show();
                ProductStatisticFrm.BringToFront();
                RevenueStatisticFrm.Hide();
                StaffStatisticFrm.Hide();
                CustomerStatisticFrm.Hide();
            }
            catch (Exception ex) { Console.WriteLine(ex); }
		}

		private void RevenuePanel_Click(object sender, EventArgs e)
        {
            try
            {
				RevenueStatisticFrm.Show();
				RevenueStatisticFrm.BringToFront();
				ProductStatisticFrm.Hide();
				StaffStatisticFrm.Hide();
                CustomerStatisticFrm.Hide();
            }
			catch (Exception ex) { Console.WriteLine(ex); }
        }

        private void StaffPanel_Click(object sender, EventArgs e)
        {
			try
			{
				StaffStatisticFrm.Show();
				StaffStatisticFrm.BringToFront();
				ProductStatisticFrm.Hide();
				RevenueStatisticFrm.Hide();
				CustomerStatisticFrm.Hide();
			}
			catch (Exception ex) { Console.WriteLine(ex); }
		}

        private void CustomerPanel_Click(object sender, EventArgs e)
        {
            try
            {
				CustomerStatisticFrm.Show();
				CustomerStatisticFrm.BringToFront();
				ProductStatisticFrm.Hide();
				StaffStatisticFrm.Hide();
				RevenueStatisticFrm.Hide();
            }
			catch (Exception ex) { Console.WriteLine(ex); }
        }
    }
}
