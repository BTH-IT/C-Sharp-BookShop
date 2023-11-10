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
        private CustomerBillDTO customerBill = null;

        public ViewCustomerBillModal(CustomerBillDTO customerBill)
        {
            InitializeComponent();
            try
            {
                this.customerBill = customerBill;

                this.loadCustomerCbx();
                this.loadSaleCbx();
                this.loadStaffCbx();

                this.customerCbx.SelectedValue = customerBill.MaKhachHang;
                this.saleCbx.SelectedValue = customerBill.MaKhuyenMai;
                this.staffCbx.SelectedValue = customerBill.MaNhanVien;

                this.bookList.Controls.Clear();

                foreach (CustomerBillDetailDTO customerBillDetail in CustomerBillBUS.Instance.getCustomerBillDetailList(customerBill.MaDonKhachHang.ToString()))
                {
                    BookDTO book = BookBUS.Instance.getById(customerBillDetail.MaSach.ToString());

                    ViewBookBill viewBook = new ViewBookBill(book.TenSach, customerBillDetail.SoLuong, customerBillDetail.DonGia, book.HinhAnh);

                    this.bookList.Controls.Add(viewBook);
                }

                this.totalPriceTxt.Text = this.customerBill.TongTien.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void loadCustomerCbx()
        {
            try
            {
                List<CustomerDTO> customerList = CustomerBUS.Instance.getAllData();

                customerList.Insert(0, new CustomerDTO(-1, "", "Chọn khách hàng", 0, "", 0));
                customerList.Insert(1, new CustomerDTO(0, "", "Không có khách hàng", 0, "", 0));

                this.customerCbx.ValueMember = "Ma";
                this.customerCbx.DisplayMember = "SoDienThoai";
                this.customerCbx.DataSource = customerList;

                this.customerCbx.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void loadSaleCbx()
        {
            try
            {
                List<SaleDTO> saleList = SaleBUS.Instance.getAllData();

                saleList.Insert(0, new SaleDTO(-1, "Chọn khuyến mãi", 0, new DateTime(), new DateTime()));
                saleList.Insert(1, new SaleDTO(0, "Không có khuyến mãi", 0, new DateTime(), new DateTime()));

                this.saleCbx.ValueMember = "MaKhuyenMai";
                this.saleCbx.DisplayMember = "TenKhuyenMai";
                this.saleCbx.DataSource = saleList;

                this.saleCbx.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void loadStaffCbx()
        {
            try
            {
                List<StaffDTO> staffList = StaffBUS.Instance.getAllData();

                this.staffCbx.ValueMember = "Ma";
                this.staffCbx.DisplayMember = "Ten";
                this.staffCbx.DataSource = staffList;

                this.staffCbx.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
