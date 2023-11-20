using System.Drawing;
using System.IO;
using System.Windows.Forms;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.GUI.UserControls
{
    public partial class BookBillV2 : UserControl
    {
        public BookBillV2()
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
            this.priceTxt.Text = donGia.ToString();
            this.pictureBook.Image = img;

            if (soLuong == 1)
            {
                this.minus.Enabled = false;
            }
        }

        private void priceTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn chặn ký tự nhập vào TextBox
            }
        }
    }
}
