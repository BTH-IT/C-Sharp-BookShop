using QuanLyCuaHangBanSach.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangBanSach.GUI.UserControls
{
	public partial class RefundBookControl : UserControl
	{
		public static Action OnChangeRefundBookAmount;
		public static Action<string> OnDeleteRefundBook;
		private int stock = 100;
		public RefundBookControl()
		{
			InitializeComponent();
		}
		public void details(BookDTO book)
		{
			try
			{
				using (MemoryStream ms = new MemoryStream(book.HinhAnh))
				{
					Image image = Image.FromStream(ms);
					BookImage.Image = image;
				}
			
			}catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			IdLb.Text = book.MaSach.ToString();
			NameLb.Text = book.TenSach;
			StockLb.Text = book.SoLuongConLai.ToString();
			PriceLb.Text = string.Format("{0:N0} đ", book.GiaBan);
			toolTip1.SetToolTip(NameLb, NameLb.Text);

		}
		public bool checkValidStock()
		{
			return false;
		}
		public int getId()
		{
			return Convert.ToInt32(IdLb.Text);
		}
		public double getPrice()
		{
			return Convert.ToDouble(PriceLb.Text.Split(' ')[0]);	
		}
		private void PlusBtn_Click(object sender, EventArgs e)
		{
			if (Convert.ToInt32(AmountTxt.Text) < stock)
			{
				AmountTxt.Text = (int.Parse(AmountTxt.Text) + 1).ToString();
				ChangeAmount();
			}
		}

		private void ChangeAmount()
		{
			RefundBookControl.OnChangeRefundBookAmount();
		}
		public int GetBookAmount()
		{
			return Convert.ToInt32(this.AmountTxt.Text);
		}

		private void MinusBtn_Click(object sender, EventArgs e)
		{
			if (!AmountTxt.Text.Equals("1"))
			{
				AmountTxt.Text = (int.Parse(AmountTxt.Text) - 1).ToString();
				ChangeAmount();
			}
		}

		private void DeleteBtn_Click(object sender, EventArgs e)
		{
			RefundBookControl.OnDeleteRefundBook(this.IdLb.Text);
		}
	}
}
