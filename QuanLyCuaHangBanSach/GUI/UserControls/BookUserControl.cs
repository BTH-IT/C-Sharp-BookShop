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
        public static bool clicked = false;
        public static string ChoseId = "";
        public BookUserControl(int mode) 
        {
            InitializeComponent();
            this.mode = mode;
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
            }

            IdLb.Text = book.MaSach.ToString();
            NameLb.Text = book.TenSach;
            toolTip1.SetToolTip(NameLb, NameLb.Text);
        }

        private void BookUserControl_Hover(object sender, EventArgs e)
        {
            BackColor = Color.Gainsboro;
        }

        private void BookUserControl_Leave(object sender, EventArgs e)
        {
            BackColor = Color.White;
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
        }
    }
}
