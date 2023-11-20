using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;
using QuanLyCuaHangBanSach.GUI.UserControls;

namespace QuanLyCuaHangBanSach.GUI.Modal
{
    public partial class ViewImportBillModal : Form
    {

        public ViewImportBillModal(ImportBillDTO importBill)
        {
            InitializeComponent();

            List<ImportBillDetailDTO> customerBillDetailList = ImportBillBUS.Instance.getImportBillDetailList(importBill.MaDonNhapHang.ToString());

            StaffDTO staff = StaffBUS.Instance.getById(importBill.MaNhanVien.ToString());

            this.staffTxt.Text = staff.Ten;

            SupplierDTO supplier = SupplierBUS.Instance.getById(importBill.MaNhaCungCap.ToString());

            this.supplierTxt.Text = supplier.TenNhaCungCap;

            this.dateTxt.Text = importBill.NgayLap.GetDateTimeFormats()[0];
            this.benifitTxt.Text = importBill.PhanTramLoiNhuan + "%";

            BookDTO book;
            foreach (ImportBillDetailDTO customerBillDetail in customerBillDetailList)
            {
                book = BookBUS.Instance.getById(customerBillDetail.MaSach.ToString());

                ViewBookBill viewBook = new ViewBookBill(book.TenSach, customerBillDetail.SoLuong, customerBillDetail.DonGia, book.HinhAnh);

                this.bookList.Controls.Add(viewBook);
            }

            this.totalPriceTxt.Text = string.Format("{0:N0} VNĐ", importBill.TongTien);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
