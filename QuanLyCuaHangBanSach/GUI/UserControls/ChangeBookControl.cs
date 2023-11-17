using BookShop_CNPM.DTO;
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

namespace BookShop_CNPM.GUI.UserControls
{
    public partial class ChangeBookControl : UserControl
    {

        public static Action<string> OnDeleteRefundBook;
        public static Action<string> OnChangeAmount;
        public static bool AmountChanged = false;
        public static string AmountChangedId = "";
        private int stock1 = 100;
        private int Amount = 1;
        public ChangeBookControl()
        {
            InitializeComponent();
        }
        public void details(BookDTO book, int stock, int mode = 0)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream(book.HinhAnh))
                {
                    Image image = Image.FromStream(ms);
                    BookImage.Image = image;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            IdLb.Text = book.MaSach.ToString();
            NameLb.Text = book.TenSach;
            StockLb.Text = "SL: " +stock.ToString();
            stock1 = stock;
            PriceLb.Text = string.Format("{0:N0} đ", mode == 0 ? book.GiaBan : book.GiaNhap);
            toolTip1.SetToolTip(NameLb, NameLb.Text);
        }
        public bool checkValidStock()
        {
            return GetBookAmount() <= stock1;
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
            if (Convert.ToInt32(AmountTxt.Text) < stock1)
            {
                AmountTxt.Text = (int.Parse(AmountTxt.Text) + 1).ToString();
                Amount = (int.Parse(AmountTxt.Text));
                ChangeBookControl.OnChangeAmount(this.IdLb.Text);
                ChangeAmount();
            }
            else
            {
                MessageBox.Show("Không thể đổi quá số lượng sách đã đặt");
                AmountTxt.Text = stock1.ToString();
            }
        }

        private void ChangeAmount()
        {
            if (checkValidStock())
            {
                AmountChanged = true;
                AmountChangedId = IdLb.Text;
            }
        }
        public int GetBookAmount()
        {
            return Convert.ToInt32(this.AmountTxt.Text);
        }
        public String GetBookName()
        {
            return this.NameLb.Text;
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            if (!AmountTxt.Text.Equals("1"))
            {
                AmountTxt.Text = (int.Parse(AmountTxt.Text) - 1).ToString();
                Amount = (int.Parse(AmountTxt.Text));
                ChangeAmount();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            ChangeBookControl.OnDeleteRefundBook(this.IdLb.Text);
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
            if (String.IsNullOrEmpty(AmountTxt.Text))
            {
                AmountTxt.Text = "1";
            }
            if (int.Parse(AmountTxt.Text) > stock1)
            {
                MessageBox.Show("Không thể đổi quá số lượng sách đã đặt");
                AmountTxt.Text = Amount.ToString();
            }
            else
            {
                Amount = Convert.ToInt32(AmountTxt.Text);
                ChangeBookControl.OnChangeAmount(this.IdLb.Text);
                ChangeAmount();
            }
        }
    }
}
