using Guna.UI2.WinForms.Suite;
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
using ZXing.QrCode.Internal;
using static Guna.UI2.Native.WinApi;

namespace QuanLyCuaHangBanSach.GUI.Vendor
{
    public partial class BookUserControl : UserControl
    {
        private int mode; // 0: Vendor; 1: Import
        private bool nameHover = false;
        private bool stockHover = false;
        private bool priceHover = false;
		private bool imageHover = false;
		private bool panelHover = false;
		public static bool clicked = false;
        public bool check = false;
        public static string ChoseId = "";
        public int Price = 0;
        public BookUserControl(int mode) 
        {
            InitializeComponent();
            this.mode = mode;

            NameLb.Click += BookUserControl_Click;
            StockLb.Click += BookUserControl_Click;
            PriceLb.Click += BookUserControl_Click;
            BookImage.Click += BookUserControl_Click;
		}

        public void details(BookDTO book)
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

            if (mode == 0)
            {
                PriceLb.Text = string.Format("{0:N0} VND", book.GiaBan);
                Price = Convert.ToInt32(book.GiaBan);
                StockLb.Text = "SL: " + book.SoLuongConLai;
                if (book.SoLuongConLai == 0)
                {
                    Cursor = Cursors.No;
                }
            }
            else
            {
                StockLb.Text = "SL: " + book.SoLuongConLai;
                PriceLb.Text = string.Format("{0:N0} VND", book.GiaNhap);
                Price = Convert.ToInt32(book.GiaNhap);
            }

            IdLb.Text = book.MaSach.ToString();
            NameLb.Text = book.TenSach;
            toolTip1.SetToolTip(NameLb, NameLb.Text);
        }

        private void BookUserControl_Click(object sender, EventArgs e)
        {
            if (mode == 0)
            {
                if (!StockLb.Text.Equals("SL: 0"))
                {
                    clicked = true;
                    ChoseId = IdLb.Text;
                } 
            }
            else
            {
                clicked = true;
                ChoseId = IdLb.Text;
            }
            check = true;
        }
        public void UncheckStatus()
        {
            this.check = false;
        }
        public int getId()
        {
            return Convert.ToInt32(IdLb.Text);
        }
        public int GetPrice()
        {
            return Price;
        }

		private void checkHover_Tick(object sender, EventArgs e)
		{
            if (nameHover || stockHover || priceHover || imageHover || panelHover)
            {
                BackColor = Color.Gainsboro;
			}
            else
            {
				BackColor = Color.White;
            }
        }

		private void NameLb_MouseHover(object sender, EventArgs e)
		{
            nameHover = true;
		}

		private void StockLb_MouseHover(object sender, EventArgs e)
		{
            stockHover = true;
		}

		private void PriceLb_MouseHover(object sender, EventArgs e)
		{
            priceHover = true;
		}

		private void BookImage_MouseHover(object sender, EventArgs e)
		{
			imageHover = true;
		}

		private void BookUserControl_MouseHover(object sender, EventArgs e)
		{
            panelHover = true;
		}

		private void NameLb_MouseLeave(object sender, EventArgs e)
		{
			nameHover = false;
		}

		private void StockLb_MouseLeave(object sender, EventArgs e)
		{
			stockHover = false;
		}

		private void PriceLb_MouseLeave(object sender, EventArgs e)
		{
			priceHover = false;
		}

		private void BookImage_MouseLeave(object sender, EventArgs e)
		{
			imageHover = false;
		}

		private void BookUserControl_MouseLeave(object sender, EventArgs e)
		{
			panelHover = false;
		}

	}
}
