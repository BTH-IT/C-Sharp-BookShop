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
using QuanLyCuaHangBanSach.DTO;
using static Guna.UI2.Native.WinApi;

namespace QuanLyCuaHangBanSach.GUI.UserControls
{
    public partial class ViewBookBill : UserControl
    {
        public ViewBookBill(string name, int amount, decimal price, byte[] image)
        {
            InitializeComponent();
            NameLb.Text = name;
            StockLb.Text = "SL: " + amount;
            PriceLb.Text = string.Format("{0:N0} VND", price);

            MemoryStream ms = new MemoryStream(image);
            Image img = Image.FromStream(ms);

            this.BookImage.Image = img;

        }
    }
}
