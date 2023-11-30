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

namespace QuanLyCuaHangBanSach.GUI.Vendor
{
    public partial class ImportCartProductUserControl : UserControl
    {
		private int mode;
		private int max;
		public static bool AmountChanged = false;
        public static bool deletePress = false;
        public static string AmountChangedId = "";
        public static string deleteId = "";

        public ImportCartProductUserControl(int mode, int max=-1) //1: import, 2: request
        {
            InitializeComponent();
            this.mode = mode;
            this.max = max;
		}

        public void details(BookDTO book, int amount = 1)
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
            
            StockLb.Text = "ST: " + book.SoLuongConLai;
            IdLb.Text = book.MaSach.ToString();
            if (mode == 1)
            {
                ImportPriceTxb.Text = book.GiaNhap.ToString();
            }
            else
            {
				ImportPriceTxb.Visible = false;
                VndLb.Visible = false;
			}
            NameLb.Text = book.TenSach;
            AmountTxt.Text = amount.ToString();
            toolTip1.SetToolTip(NameLb, NameLb.Text);
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            if (max == -1)
            {
                AmountTxt.Text = (int.Parse(AmountTxt.Text) + 1).ToString();
                ChangeAmount();
            }
            else if (int.Parse(AmountTxt.Text) < max)
            {
				AmountTxt.Text = (int.Parse(AmountTxt.Text) + 1).ToString();
				ChangeAmount();
			}
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            if (mode == 1)
            {
                if (!AmountTxt.Text.Equals("0"))
                {
                    AmountTxt.Text = (int.Parse(AmountTxt.Text) - 1).ToString();
                    ChangeAmount();
                }
            } else
            {
                if (!AmountTxt.Text.Equals("1"))
                {
                    AmountTxt.Text = (int.Parse(AmountTxt.Text) - 1).ToString();
                    ChangeAmount();
                }
            }
            
        }

        private void AmountTxt_Validation()
        {
            if (mode == 1)
            {
                if ((int.TryParse(AmountTxt.Text, out int re) && re < 0) || String.IsNullOrEmpty(AmountTxt.Text))
                {
                    AmountTxt.Text = "0";
                }
                else if (max != -1 && int.Parse(AmountTxt.Text) > max)
                {
                    AmountTxt.Text = max.ToString();
                }
            }
            else
            {
                if ((int.TryParse(AmountTxt.Text, out int re) && re <= 0) || String.IsNullOrEmpty(AmountTxt.Text))
                {
                    AmountTxt.Text = "1";
                }
                else if (max != -1 && int.Parse(AmountTxt.Text) > max)
                {
                    AmountTxt.Text = max.ToString();
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

		private void ImportPriceTxb_KeyPress(object sender, KeyPressEventArgs e)
		{
			try
			{
				if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
				{
					e.Handled = true; // Cancel the key press event
				}
			}
			catch (Exception ex) { Console.WriteLine(ex); }
		}
	}
}
