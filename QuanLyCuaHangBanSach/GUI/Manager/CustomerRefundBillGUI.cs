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
		public CustomerRefundBillGUI()
		{
			InitializeComponent();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void CustomerRefundBillGUI_FormClosed(object sender, FormClosedEventArgs e)
		{
		}
	}
}
