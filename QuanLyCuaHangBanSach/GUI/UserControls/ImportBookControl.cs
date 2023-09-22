using QuanLyCuaHangBanSach.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangBanSach.GUI.UserControls
{
	public partial class ImportBookControl : UserControl
	{
		public bool check = false;
		public ImportBookControl()
		{
			InitializeComponent();
		}
		
		public void details(BookDTO book,int soLuongMua)
		{
			try
			{
				using (var stream = new System.IO.MemoryStream(book.HinhAnh))
				{
					Bitmap bitmap = new Bitmap(stream);
					BookImage.Image = bitmap;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}

			IdLb.Text = book.MaSach.ToString();
			NameLb.Text = book.TenSach;
			StockLb.Text = "SL: " + soLuongMua;
			PriceLb.Text = string.Format("{0:N0} VND", book.GiaBan);
			toolTip1.SetToolTip(NameLb, NameLb.Text);
		}
		private void ImportBookControl_Click(object sender, EventArgs e)
		{
			CheckStatus();
	
		}

		private void CheckStatus()
		{
			this.check = true;
		}
		public void UncheckStatus()
		{
			this.check = false;
		}
		public bool getCheckStatus()
		{
			return this.check;
		}

		public int getId()
		{
			return Convert.ToInt32(IdLb.Text);	
		}
		
	}
}
