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
            this.customerBill = customerBill;

            this.loadCustomerCbx();
            this.loadSaleCbx();

            this.customerCbx.SelectedValue = 0;
            this.saleCbx.SelectedValue = 0;

            this.bookList.Controls.Clear();

            foreach (CustomerBillDetailDTO customerBillDetail in CustomerBillBUS.Instance.getCustomerBillDetailList(customerBill.MaDonKhachHang.ToString()))
            {
                BookDTO book = BookBUS.Instance.getById(customerBillDetail.MaSach.ToString());

                ViewBookBill viewBook = new ViewBookBill(book.TenSach, customerBillDetail.SoLuong, customerBillDetail.DonGia);

                this.bookList.Controls.Add(viewBook);
            }

            this.totalPriceTxt.Text = this.customerBill.TongTien.ToString();
        }

        private void loadCustomerCbx()
        {
            List<CustomerDTO> customerList = CustomerBUS.Instance.getAllData();

            customerList.Insert(0, new CustomerDTO(-1, "", "Chọn khách hàng", "", 0, 0));
            customerList.Insert(1, new CustomerDTO(0, "", "Không có khách hàng", "", 0, 0));

            this.customerCbx.ValueMember = "Ma";
            this.customerCbx.DisplayMember = "SoDienThoai";
            this.customerCbx.DataSource = customerList;

            this.customerCbx.SelectedIndex = 0;
        }

        private void loadSaleCbx()
        {
            List<SaleDTO> saleList = SaleBUS.Instance.getAllData();

            saleList.Insert(0, new SaleDTO(-1, "Chọn khuyến mãi", 0, new DateTime(), new DateTime()));
            saleList.Insert(1, new SaleDTO(0, "Không có khuyến mãi", 0, new DateTime(), new DateTime()));

            this.saleCbx.ValueMember = "MaKhuyenMai";
            this.saleCbx.DisplayMember = "TenKhuyenMai";
            this.saleCbx.DataSource = saleList;

            this.saleCbx.SelectedIndex = 0;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
