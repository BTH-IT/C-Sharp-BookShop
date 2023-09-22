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
using static Guna.UI2.Native.WinApi;

namespace QuanLyCuaHangBanSach.GUI.Vendor
{
    public partial class BookUserControl : UserControl
    {
        public BookUserControl()
        {
            InitializeComponent();
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

            IdLb.Text = book.MaSach.ToString();
            NameLb.Text = book.TenSach;
            StockLb.Text = "SL: " + book.SoLuongConLai;
            PriceLb.Text = string.Format("{0:N0} VND", book.GiaBan);
            toolTip1.SetToolTip(NameLb, NameLb.Text);
            if (book.SoLuongConLai == 0)
            {
                this.Cursor = Cursors.No;
            }
        }

        private void BookUserControl_Hover(object sender, EventArgs e)
        {
            this.BackColor = Color.Gainsboro;
        }

        private void BookUserControl_Leave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        public static bool clicked = false;
        public static string ChoseId = "";

        private void BookUserControl_Click(object sender, EventArgs e)
        {
            if (!StockLb.Text.Equals("SL: 0"))
            {
                clicked = true;
                ChoseId = IdLb.Text;
            }
        }
    }
}
