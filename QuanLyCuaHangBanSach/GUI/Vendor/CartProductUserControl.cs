using OfficeOpenXml.Drawing.Chart;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyCuaHangBanSach.GUI.Vendor
{
    public partial class CartProductUserControl : UserControl
    {
        public CartProductUserControl()
        {
            InitializeComponent();
        }

        private int stock = 0;

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
            stock = book.SoLuongConLai;
            PriceLb.Text = string.Format("{0:N0} đ", book.GiaBan);
            toolTip1.SetToolTip(NameLb, NameLb.Text);
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            AmountTxt.Text = (int.Parse(AmountTxt.Text) + 1).ToString();
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            if (!AmountTxt.Text.Equals("1"))
            {
                AmountTxt.Text = (int.Parse(AmountTxt.Text) - 1).ToString();
            }
        }

        private void AmountTxt_Validation(object sender, EventArgs e)
        {
            if (int.Parse(AmountTxt.Text) < 1)
            {
                AmountTxt.Text = "1";
            }
            if (int.Parse(AmountTxt.Text) > stock)
            {
                AmountTxt.Text = stock.ToString();
            }
        }
        private void AmountTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancel the key press event
            }
        }

        private void AmountTxt_Leave(object sender, EventArgs e)
        {
            AmountTxt_Validation(sender, e);
        }

        public static bool deletePress = false;
        public static string deleteId = "";

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            deletePress = true;
            deleteId = IdLb.Text;
        }
    }
}
