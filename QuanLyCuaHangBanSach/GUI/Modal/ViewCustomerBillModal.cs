using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;
using QuanLyCuaHangBanSach.GUI.UserControls;
using QuanLyCuaHangBanSach.GUI.Vendor;

namespace QuanLyCuaHangBanSach.GUI.Modal
{
    public partial class ViewCustomerBillModal : Form
    {
        public ViewCustomerBillModal(CustomerBillDTO customerBill)
        {
            InitializeComponent();
            
            this.noteTxt.Visible = false;

            List<CustomerBillDetailDTO> customerBillDetailList = CustomerBillBUS.Instance.getCustomerBillDetailList(customerBill.MaDonKhachHang.ToString());

            StaffDTO staff = StaffBUS.Instance.getById(customerBill.MaNhanVien.ToString());

            this.staffTxt.Text = staff.Ten;

            CustomerDTO customer = CustomerBUS.Instance.getById(customerBill.MaKhachHang.ToString());

            this.customerTxt.Text = customer == null ? "Vãng lai" : customer.Ten;

            SaleDTO sale = SaleBUS.Instance.getById(customerBill.MaKhuyenMai.ToString());

            this.saleTxt.Text = sale == null ? "Không có" : sale.TenKhuyenMai;
            this.percentTxt.Text = sale == null ? "0%" : sale.PhanTram + "%";

            this.paymentPriceTxt.Text = string.Format("{0:N0} VNĐ", customerBill.TienKhachDua);

            this.dateTxt.Text = customerBill.NgayLap.GetDateTimeFormats()[0];

            BookDTO book;
            decimal giaGoc = 0;
            foreach (CustomerBillDetailDTO customerBillDetail in customerBillDetailList)
            {
                book = BookBUS.Instance.getById(customerBillDetail.MaSach.ToString());

                ViewBookBill viewBook = new ViewBookBill(book.TenSach, customerBillDetail.SoLuong, customerBillDetail.DonGia, book.HinhAnh);

                this.bookList.Controls.Add(viewBook);

                giaGoc += customerBillDetail.ThanhTien;
            }

            decimal salePrice = sale == null ? 0 : Convert.ToDecimal((giaGoc * Convert.ToDecimal(sale.PhanTram / 100.0)).ToString().Split('.')[0]);

            decimal giaDaGiam = giaGoc - salePrice;

            if (customerBill.DoiDiem > 0)
            {
                decimal diem = customerBill.DoiDiem * 1000;
                giaDaGiam -= diem;

                this.noteTxt.Visible = true;
                this.noteTxt.Text = $"*Khách hàng đã đổi {customerBill.DoiDiem} điểm tương ứng với {string.Format("{0:N0} VNĐ", diem)} được giảm vào tổng đơn";
            }

            this.discountPriceTxt.Text = string.Format("{0:N0} VNĐ", (giaGoc - giaDaGiam));
            this.totalPriceTxt.Text = string.Format("{0:N0} VNĐ", customerBill.TongTien);
            this.changedPriceTxt.Text = string.Format("{0:N0} VNĐ", customerBill.TienKhachDua - customerBill.TongTien);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void totalPriceTxt_Click(object sender, EventArgs e)
        {

        }
    }
}
