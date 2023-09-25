using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public ViewBookBill(string name, int amount, double price)
        {
            InitializeComponent();
            NameLb.Text = name;
            StockLb.Text = "SL: " + amount;
            PriceLb.Text = string.Format("{0:N0} VND", price);
        }
    }
}
