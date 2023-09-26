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
		private test customerChangeBillFrm = new test() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None, };
		private test importChangeBillFrm = new test() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None, };
		private CustomerRefundBillGUI customerRefundFrm = new CustomerRefundBillGUI() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None, Visible = false};
		private ImportRefundBillGUI importRefundBillFrm = new ImportRefundBillGUI() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None,Visible = false };
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

		}

		private void importChangeBillPanel_Click(object sender, EventArgs e)
		{

		}

		private void customerRefundBillPanel_Click(object sender, EventArgs e)
		{
			try
			{
				customerRefundFrm.Show();
				customerRefundFrm.BringToFront();
				importChangeBillFrm.Hide();
				customerChangeBillFrm.Hide();
				importRefundBillFrm.Hide();
			}
			catch { 
			}
	

		}

		private void importRefundBillPanel_Click(object sender, EventArgs e)
		{
			try
			{
				importRefundBillFrm.Show();
				importRefundBillFrm.BringToFront();
				customerRefundFrm.Hide();
				importChangeBillFrm.Hide();
				customerChangeBillFrm.Hide();
			}catch { }
		}

		private void RefundFormMenuGUI_Load(object sender, EventArgs e)
		{
			try
			{
				//loadClickEvent(this.importChangeBillPanel,importChangeBillPanel_Click);
				//loadClickEvent(this.customerChangeBillPanel, customerChangeBillPanel_Click);
				loadClickEvent(this.customerRefundBillPanel, customerRefundBillPanel_Click);
				loadClickEvent(this.importRefundBillPanel, importRefundBillPanel_Click);
			}
			catch { }
			
		
		}

		private void loadClickEvent(GunaGradient2Panel panel, Action<object, EventArgs> ClickHandler)
		{
			try
			{
				foreach (Control control in panel.Controls)
				{
					control.Click += (s, ev) =>
					{
						ClickHandler.Invoke(s, ev);
					};
				}
			}
			catch { }
				
		}

		private void importRefundBillPanel_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
