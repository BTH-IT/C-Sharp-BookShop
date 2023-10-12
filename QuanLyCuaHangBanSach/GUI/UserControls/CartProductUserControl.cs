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
        private int stock = 0;
        private int mode = 0; // 0: Vendor; 1: Import
        public static bool AmountChanged = false;
        public static bool deletePress = false;
        public static string AmountChangedId = "";
        public static string deleteId = "";

        public CartProductUserControl(int mode)
        {
            InitializeComponent();
            this.mode = mode;
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
            }
            catch (Exception ex) { Console.WriteLine(ex); }

            if (mode == 0)
            {
                StockLb.Text = "ST: " + book.SoLuongConLai;
                stock = book.SoLuongConLai;
                PriceLb.Text = string.Format("{0:N0} đ", book.GiaBan);
            }
            else
            {
                StockLb.Text = "SL: " + book.SoLuongConLai;
                PriceLb.Text = string.Format("{0:N0} đ", book.GiaNhap);
            }

            IdLb.Text = book.MaSach.ToString();
            NameLb.Text = book.TenSach;
            toolTip1.SetToolTip(NameLb, NameLb.Text);
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            if (mode == 0)
            {
                if (Convert.ToInt32(AmountTxt.Text) < stock)
                {
                    AmountTxt.Text = (int.Parse(AmountTxt.Text) + 1).ToString();
                    ChangeAmount();
                } 
            }
            else
            {
                AmountTxt.Text = (int.Parse(AmountTxt.Text) + 1).ToString();
                ChangeAmount();
            }
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            if (!AmountTxt.Text.Equals("1"))
            {
                AmountTxt.Text = (int.Parse(AmountTxt.Text) - 1).ToString();
                ChangeAmount();
            }
        }

        private void AmountTxt_Validation()
        {
            if (String.IsNullOrEmpty(AmountTxt.Text))
            {
                AmountTxt.Text = "1";
            }
            if (mode == 0)
            {
                if (int.Parse(AmountTxt.Text) > stock)
                {
                    AmountTxt.Text = stock.ToString();
                }
            }
        }

        private void AmountTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                NameLb.Focus();
                return;
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancel the key press event
            }
        }

        private void AmountTxt_MouseLeave(object sender, EventArgs e)
        {
            NameLb.Focus();
        }

        private void AmountTxt_Leave(object sender, EventArgs e)
        {
            AmountTxt_Validation();
            ChangeAmount();
        }

        private void ChangeAmount()
        {
            AmountChanged = true;
            AmountChangedId = IdLb.Text;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            deletePress = true;
            deleteId = IdLb.Text;
        }
    }
}
