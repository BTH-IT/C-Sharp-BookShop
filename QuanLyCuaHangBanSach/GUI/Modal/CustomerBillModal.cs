﻿using System;
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
        private List<CustomerBillDetailDTO> customerBillDetailList = new List<CustomerBillDetailDTO>();
        private int staffId;

        public CustomerBillModal(int staffId)
        {
            InitializeComponent();

            this.staffId = staffId;
            customerBillDetailList = new List<CustomerBillDetailDTO>();
        }

        private void loadCustomerCbx()
        {
            try
            {
                List<CustomerDTO> customerList = CustomerBUS.Instance.getAllData();

                customerList.Insert(0, new CustomerDTO(-1, "", "", 0, "Chọn khách hàng", 0));
                customerList.Insert(1, new CustomerDTO(0, "", "", 0, "Không có khách hàng", 0));

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

        private void loadCustomerBillDetailList()
        {
            try
            {
                this.bookList.Controls.Clear();

                double total = 0;

                foreach (CustomerBillDetailDTO customerBillDetail in customerBillDetailList)
                {
                    BookBill bookBill = new BookBill();

                    total += customerBillDetail.SoLuong * customerBillDetail.DonGia;

                    bookBill.addData(customerBillDetail.MaSach, customerBillDetail.SoLuong, customerBillDetail.DonGia);

                    int remain = BookBUS.Instance.getById(customerBillDetail.MaSach.ToString()).SoLuongConLai + customerBillDetail.SoLuong;

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

                            if (amount == remain) bookBill.plus.Enabled = false;
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
                        }
                        else
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
                        }
                        catch
                        {
                            MessageBox.Show("Số lượng là một số");
                        }
                    };

                    bookBill.amountInput.KeyPress += (object sender, KeyPressEventArgs e) =>
                    {
                        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                        {
                            e.Handled = true;
                        }
                    };

                    this.bookList.Controls.Add(bookBill);
                }

                this.totalPriceTxt.Text = total.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void CustomerBillModal_Load(object sender, EventArgs e)
        {
            try
            {
                this.loadCustomerBillDetailList();
                this.loadCustomerCbx();
                this.loadSaleCbx();

                this.customerCbx.SelectedValue = 0;
                this.saleCbx.SelectedValue = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            try
            {
                List<CustomerBillDetailDTO> copiedList = new List<CustomerBillDetailDTO>();
                copiedList.AddRange(customerBillDetailList);
                using (AddBookToCustomerBillModal addBookToBillModal = new AddBookToCustomerBillModal(copiedList))
                {
                    addBookToBillModal.ShowDialog();

                    if (addBookToBillModal.isSaved)
                    {
                        customerBillDetailList = new List<CustomerBillDetailDTO>(addBookToBillModal.selectedCustomerBillDetailList);
                    }
                    this.loadCustomerBillDetailList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private bool validate()
        {
            try
            {
                bool isCheckCbx1 = CustomValidation.Instance.checkCombobox(
                        this.customerCbx,
                        this.errorCustomerMsg,
                        new string[] { "required" }
                    );

                bool isCheckCbx2 = CustomValidation.Instance.checkCombobox(
                    this.saleCbx,
                    this.errorSaleMsg,
                    new string[] { "required" }
                );

                if (this.customerBillDetailList.Count <= 0)
                {
                    this.errorBookListMsg.Text = "Danh sách sản phẩm không được để trống";
                    return false;
                }
                else
                {
                    this.errorBookListMsg.Text = "";
                }

                return isCheckCbx1 && isCheckCbx2;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                bool isValid = this.validate();

                if (!isValid) return;

                CustomerBillDTO customerBill = new CustomerBillDTO();

                customerBill.TongTien = Convert.ToDouble(this.totalPriceTxt.Text);
                customerBill.MaNhanVien = this.staffId;
                customerBill.MaKhachHang = Convert.ToInt32(this.customerCbx.SelectedValue);
                customerBill.MaKhuyenMai = Convert.ToInt32(this.saleCbx.SelectedValue);
                customerBill.NgayLap = DateTime.Now;

                CustomerBillDTO newCustomerBill = CustomerBillBUS.Instance.insertReturnBill(customerBill);

                if (newCustomerBill == null)
                {

                    MessageBox.Show("Failure");
                    this.isSubmitSuccess = false;
                }
                else
                {
                    foreach (CustomerBillDetailDTO customerBillDetail in this.customerBillDetailList)
                    {
                        CustomerBillDetailDTO newCustomerBillDetail = new CustomerBillDetailDTO(
                            newCustomerBill.MaDonKhachHang,
                            customerBillDetail.MaSach,
                            customerBillDetail.SoLuong,
                            customerBillDetail.DonGia
                        );

                        CustomerBillBUS.Instance.createCustomerBillDetail(newCustomerBillDetail);
                    }

                    MessageBox.Show("Success");

                    this.isSubmitSuccess = true;
                    this.Close();
                }
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
