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
            using (MemoryStream ms = new MemoryStream(book.HinhAnh))
            {
                Image image = Image.FromStream(ms);
                BookImage.Image = image;
            }
            IdLb.Text = book.MaSach.ToString();
            NameLb.Text = book.TenSach;
            StockLb.Text = "ST: " + book.SoLuongConLai;
            PriceLb.Text = string.Format("{0:N0} VND", book.GiaBan);
            toolTip1.SetToolTip(NameLb, NameLb.Text);
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
            clicked = true;
            ChoseId = IdLb.Text;
        }
    }
}
