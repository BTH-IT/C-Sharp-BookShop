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
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.GUI.UserControls
{
    public partial class BookBill : UserControl
    {
        public BookBill()
        {
            InitializeComponent();
        }

        public void addData(int maSach, int soLuong, decimal donGia)
        {
            BookDTO book = BookBUS.Instance.getById(maSach.ToString());

            MemoryStream ms = new MemoryStream(book.HinhAnh);
            Image img = Image.FromStream(ms);

            this.id.Text = "Mã : " + maSach;
            this.name.Text = book.TenSach;
            this.amountInput.Text = soLuong.ToString();
            this.price.Text = string.Format("{0:N0} VND", donGia);
            this.pictureBook.Image = img;

            if (soLuong == 1)
            {
                this.minus.Enabled = false;
            }
        }
    }
}
