using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;
using QuanLyCuaHangBanSach.GUI.Modal;

namespace QuanLyCuaHangBanSach.GUI.Manager
{
    public partial class BookManageGUI : Form
    {
        public BookManageGUI()
        {
            InitializeComponent();
        }

        private void loadBookListToDataView(List<BookDTO> bookList)
        {
            this.dgvBook.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 210, 192);
            this.dgvBook.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            this.dgvBook.Rows.Clear();

            foreach (BookDTO book in bookList)
            {
                this.dgvBook.Rows.Add(new object[] {
                    book.MaSach,
                    book.TenSach,
                    book.MaTacGia,
                    book.MaTheLoai,
                    book.MaNhaXuatBan,
                    book.GiaBan,
                    book.GiaNhap,
                    book.NamXuatBan,
                    book.SoLuongConLai,
                });
            }
        }

        private void BookManageGUI_Load(object sender, EventArgs e)
        {
            List<BookDTO> bookList = BookBUS.Instance.getAllData();
            this.loadBookListToDataView(bookList);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.searchInput.ForeColor = Color.Black;

            List<BookDTO> bookList = BookBUS.Instance.search(this.searchInput.Text.ToString());
            this.loadBookListToDataView(bookList);
        }

        private void searchInput_Click(object sender, EventArgs e)
        {
            if (this.searchInput.Text.Equals("Enter your search..."))
            {
                this.searchInput.Text = "";

            }
        }

        private void searchInput_Leave(object sender, EventArgs e)
        {
            if (this.searchInput.Text.Length <= 0)
            {
                this.searchInput.Text = "Enter your search...";
                this.searchInput.ForeColor = Color.LightGray;
                List<BookDTO> bookList = BookBUS.Instance.getAllData();
                this.loadBookListToDataView(bookList);
            }
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            using (AddBookModal addBookModal = new AddBookModal())
            {
                addBookModal.ShowDialog();
            }
        }
    }
}
