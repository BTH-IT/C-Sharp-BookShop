using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Windows.Forms;

namespace QuanLyCuaHangBanSach.GUI.Manager
{
	public partial class RefundFormMenuGUI : Form
	{
		private CustomerChangeBillGUI customerChangeBillFrm = new CustomerChangeBillGUI() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None, };
		private ImportChangeBillGUI importChangeBillFrm = new ImportChangeBillGUI() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None, };
		private CustomerRefundBillGUI customerRefundFrm = new CustomerRefundBillGUI() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None, };
		private ImportRefundBillGUI importRefundBillFrm = new ImportRefundBillGUI() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None, };
		public RefundFormMenuGUI()
		{
			InitializeComponent();
			this.Controls.Add(importRefundBillFrm);
			this.Controls.Add(customerRefundFrm);
			this.Controls.Add(importChangeBillFrm);
			this.Controls.Add(customerChangeBillFrm);
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
		private void customerChangeBillPanel_Click(object sender, EventArgs e)
		{
			customerChangeBillFrm.Show();
			customerChangeBillFrm.BringToFront();
			importChangeBillFrm.Hide();
			customerRefundFrm.Hide();
			importRefundBillFrm.Hide();

		}

		private void importChangeBillPanel_Click(object sender, EventArgs e)
		{
			importChangeBillFrm.Show();
			importChangeBillFrm.BringToFront();
			customerRefundFrm.Hide();
			customerChangeBillFrm.Hide();
			importRefundBillFrm.Hide();
		}

		private void customerRefundBillPanel_Click(object sender, EventArgs e)
		{

			customerRefundFrm.Show();
			customerRefundFrm.BringToFront();
			importChangeBillFrm.Hide();
			customerChangeBillFrm.Hide();
			importRefundBillFrm.Hide();

		}

		private void importRefundBillPanel_Click(object sender, EventArgs e)
		{

			importRefundBillFrm.Show();
			importRefundBillFrm.BringToFront();
			customerRefundFrm.Hide();
			importChangeBillFrm.Hide();
			customerChangeBillFrm.Hide();


		}

		private void RefundFormMenuGUI_Load(object sender, EventArgs e)
		{
			loadClickEvent(this.importChangeBillPanel, importChangeBillPanel_Click);
			loadClickEvent(this.customerChangeBillPanel, customerChangeBillPanel_Click);
			loadClickEvent(this.customerRefundBillPanel, customerRefundBillPanel_Click);
			loadClickEvent(this.importRefundBillPanel, importRefundBillPanel_Click);

		}

		private void loadClickEvent(GunaGradient2Panel panel, Action<object, EventArgs> ClickHandler)
		{
			foreach (Control control in panel.Controls)
			{
				control.Click += (s, ev) =>
				{
					ClickHandler.Invoke(s, ev);
				};
			}
		}

		private void importRefundBillPanel_Paint(object sender, PaintEventArgs e)
		{

		}
    }
}
