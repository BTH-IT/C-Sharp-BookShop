using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;
using QuanLyCuaHangBanSach.GUI.UserControls;

namespace QuanLyCuaHangBanSach.GUI.Modal
{
    public partial class CustomerBillModal : Form
    {
        public bool isSubmitSuccess = false;
        private CustomerBillDTO customerBill;
        private List<CustomerBillDetailDTO> customerBillDetailList;

        public CustomerBillModal(int customerBillId)
        {
            InitializeComponent();

            this.customerBill = CustomerBillBUS.Instance.getById(customerBillId.ToString());
            this.customerBillDetailList = CustomerBillBUS.Instance.getCustomerBillDetailList(customerBillId.ToString());
        }

        private void loadCustomerCbx()
        {
            List<CustomerDTO> customerList = CustomerBUS.Instance.getAllData();

            customerList.Insert(0, new CustomerDTO(0, "", "Chọn khách hàng", "", 0));

            this.customerCbx.ValueMember = "Ma";
            this.customerCbx.DisplayMember = "SoDienThoai";
            this.customerCbx.DataSource = customerList;

            this.customerCbx.SelectedIndex = 0;
        }

        private void loadStaffCbx()
        {
            List<StaffDTO> staffList = StaffBUS.Instance.getAllData();

            staffList.Insert(0, new StaffDTO(0, "Chọn nhân viên", "", "", 0, 0, ""));

            this.staffCbx.ValueMember = "Ma";
            this.staffCbx.DisplayMember = "Ten";
            this.staffCbx.DataSource = staffList;

            this.staffCbx.SelectedIndex = 0;
        }

        private void loadSaleCbx()
        {
            List<SaleDTO> saleList = SaleBUS.Instance.getAllData();

            saleList.Insert(0, new SaleDTO(0, "Chọn khuyến mãi", 0, new DateTime(), new DateTime()));
            saleList.Insert(1, new SaleDTO(-1, "Không có khuyến mãi", 0, new DateTime(), new DateTime()));

            this.saleCbx.ValueMember = "MaKhuyenMai";
            this.saleCbx.DisplayMember = "TenKhuyenMai";
            this.saleCbx.DataSource = saleList;

            this.saleCbx.SelectedIndex = 0;
        }

        private void loadCustomerBillDetailList()
        {
            this.bookList.Controls.Clear();

            double total = 0;

            foreach (CustomerBillDetailDTO customerBillDetail in customerBillDetailList)
            {
                BookBill bookBill = new BookBill();
                
                int remain = BookBUS.Instance.getById(customerBillDetail.MaSach.ToString()).SoLuongConLai;

                total += customerBillDetail.SoLuong * customerBillDetail.DonGia;

                bookBill.addData(customerBillDetail.MaSach, customerBillDetail.SoLuong, customerBillDetail.DonGia);

                bookBill.close.MouseClick += (object sender, MouseEventArgs e) =>
                {
                    this.bookList.Controls.Remove(bookBill);

                    this.customerBillDetailList.Remove(customerBillDetail);

                    this.loadCustomerBillDetailList();
                };

                bookBill.plus.MouseClick += (object sender, MouseEventArgs e) =>
                {
                    bookBill.minus.Enabled = true;

                    int amount = Convert.ToInt32(bookBill.amountInput.Text.ToString());

                    if (amount < remain)
                    {
                        bookBill.plus.Enabled = true;
                        bookBill.amountInput.Text = (amount + 1).ToString();

                        int idx = this.customerBillDetailList.FindIndex(
                            book => book.MaSach == customerBillDetail.MaSach
                        );

                        this.customerBillDetailList[idx].SoLuong = amount + 1;

                        total += customerBillDetail.DonGia;

                        this.totalPriceTxt.Text = total.ToString();
                    }
                    else
                    {
                        bookBill.plus.Enabled = false;
                    }
                };

                bookBill.minus.MouseClick += (object sender, MouseEventArgs e) =>
                {
                    bookBill.plus.Enabled = true;

                    int amount = Convert.ToInt32(bookBill.amountInput.Text.ToString());

                    int idx = this.customerBillDetailList.FindIndex(
                        book => book.MaSach == customerBillDetail.MaSach
                    );

                    if (amount <= 2)
                    {
                        bookBill.minus.Enabled = false;
                    } else
                    {
                        bookBill.minus.Enabled = true;
                    }

                    bookBill.amountInput.Text = (amount - 1).ToString();

                    this.customerBillDetailList[idx].SoLuong = amount - 1;

                    total -= customerBillDetail.DonGia;

                    this.totalPriceTxt.Text = total.ToString();
                };

                bookBill.amountInput.MouseLeave += (object sender, EventArgs e) =>
                {
                    try
                    {
                        this.ActiveControl = null;

                        Regex isNum = new Regex(@"^\d+$");

                        int idx = this.customerBillDetailList.FindIndex(
                            book => book.MaSach == customerBillDetail.MaSach
                        );

                        if (!isNum.IsMatch(bookBill.amountInput.Text))
                        {
                            bookBill.amountInput.Text = this.customerBillDetailList[idx].SoLuong.ToString();
                            MessageBox.Show("Số lượng là một số");
                            return;
                        }

                        int amount = Convert.ToInt32(bookBill.amountInput.Text.ToString());
                        
                        if (amount < 1 || amount > remain || this.customerBillDetailList[idx].SoLuong == amount)
                        {
                            bookBill.amountInput.Text = this.customerBillDetailList[idx].SoLuong.ToString();
                            return;
                        }

                        if (amount == 1) bookBill.minus.Enabled = false;
                        else bookBill.minus.Enabled = true;

                        if (amount == remain) bookBill.plus.Enabled = false;
                        else bookBill.minus.Enabled = true;

                        total -= this.customerBillDetailList[idx].SoLuong * customerBillDetail.DonGia;

                        this.customerBillDetailList[idx].SoLuong = amount;

                        total += this.customerBillDetailList[idx].SoLuong * customerBillDetail.DonGia;

                        this.totalPriceTxt.Text = total.ToString();

                    } catch
                    {
                        MessageBox.Show("Số lượng là một số");
                    }
                };

                this.bookList.Controls.Add(bookBill);
            }

            this.totalPriceTxt.Text = total.ToString();
        }

        private void CustomerBillModal_Load(object sender, EventArgs e)
        {
            this.loadCustomerBillDetailList();
            this.loadCustomerCbx();
            this.loadStaffCbx();
            this.loadSaleCbx();

            this.customerCbx.SelectedValue = customerBill.MaKhachHang;
            this.staffCbx.SelectedValue = customerBill.MaNhanVien;
            this.saleCbx.SelectedValue = customerBill.MaKhuyenMai;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            using (AddBookToCustomerBillModal addBookToBillModal = new AddBookToCustomerBillModal(customerBill))
            {
                addBookToBillModal.ShowDialog();

                foreach (CustomerBillDetailDTO customerBillDetail in addBookToBillModal.selectedCustomerBillDetailList)
                {
                    int idx = this.customerBillDetailList.FindIndex(
                        book => book.MaSach == customerBillDetail.MaSach
                    );

                    if (idx == -1)
                    {
                        this.customerBillDetailList.Add(customerBillDetail);
                        continue;
                    }
                    
                    this.customerBillDetailList[idx].SoLuong += customerBillDetail.SoLuong;
                }

                this.loadCustomerBillDetailList();
            }
        }

        private bool validate()
        {
            bool isCheckCbx1 = CustomValidation.Instance.checkCombobox(
                this.customerCbx,
                this.errorCustomerMsg,
                new string[] { "required" }
            );

            bool isCheckCbx2 = CustomValidation.Instance.checkCombobox(
                this.staffCbx,
                this.errorStaffMsg,
                new string[] { "required" }
            );

            bool isCheckCbx3 = CustomValidation.Instance.checkCombobox(
                this.saleCbx,
                this.errorSaleMsg,
                new string[] { "required" }
            );

            return isCheckCbx1 && isCheckCbx2 && isCheckCbx3;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            bool isValid = this.validate();

            if (this.customerBill == null || !isValid) return;

            this.customerBill.TongTien = Convert.ToDouble(this.totalPriceTxt.Text);
            this.customerBill.MaNhanVien = Convert.ToInt32(this.staffCbx.SelectedValue);
            this.customerBill.MaKhachHang = Convert.ToInt32(this.customerCbx.SelectedValue);
            this.customerBill.MaKhuyenMai = Convert.ToInt32(this.saleCbx.SelectedValue);

            if (CustomerBillBUS.Instance.updateBillAndBillDetail(
                this.customerBill, 
                this.customerBillDetailList)
            )
            {
                MessageBox.Show("Success");

                this.isSubmitSuccess = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Failure");
                this.isSubmitSuccess = false;
            }
            
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
