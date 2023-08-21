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

namespace QuanLyCuaHangBanSach.GUI.Manager
{
    public partial class BookManageGUI : Form
    {
        public BookManageGUI()
        {
            InitializeComponent();
        }

        private void loadBookListToDataView()
        {
            this.dgvBook.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 210, 192);
            this.dgvBook.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            this.dgvBook.Rows.Clear();

            List<BookDTO> bookList = BookBUS.Instance.getAllData();

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
            this.loadBookListToDataView();
        }
    }
}
