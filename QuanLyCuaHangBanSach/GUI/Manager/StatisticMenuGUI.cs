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
        /*private RevenueStatisticGUI RevenueStatisticFrm = new RevenueStatisticGUI() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None, };
        private StaffStatisticGUI StaffStatisticFrm = new StaffStatisticGUI() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None, };
        private CustomerStatisticGUI CustomerStatisticFrm = new CustomerStatisticGUI() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None, };*/
        public StatisticMenuGUI()
        {
            InitializeComponent();
            Controls.Add(ProductStatisticFrm);
            /*this.Controls.Add(RevenueStatisticFrm);
            this.Controls.Add(StaffStatisticFrm);
            this.Controls.Add(CustomerStatisticFrm);*/
        }

        private void ProductPanel_Click(object sender, EventArgs e)
        {
            try
            {
                ProductStatisticFrm.Show();
                ProductStatisticFrm.BringToFront();
                /*RevenueStatisticFrm.Hide();
                StaffStatisticFrm.Hide();
                CustomerStatisticFrm.Hide();*/
            }
            catch { }
        }

        private void RevenuePanel_Click(object sender, EventArgs e)
        {

        }

        private void StaffPanel_Click(object sender, EventArgs e)
        {

        }

        private void CustomerPanel_Click(object sender, EventArgs e)
        {

        }
    }
}
