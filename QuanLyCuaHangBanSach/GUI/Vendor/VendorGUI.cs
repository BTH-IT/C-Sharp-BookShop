﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Forms;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;
using QuanLyCuaHangBanSach.GUI.Modal;
using QuanLyCuaHangBanSach.GUI.UserControls;
using QuanLyCuaHangBanSach.GUI.Vendor;
using static ZXing.QrCode.Internal.Mode;

namespace QuanLyCuaHangBanSach.GUI
{
    public partial class VendorGUI : Form
    {
        private bool CustomerEnabled = false;
        private bool PointEnabled = false;
        private bool search = false;
        private bool PrintBtnAllowed = false;
        private int customerID = 0;
        private int staffID;
        private double finalTotalMoney = 0;
        private double discount = 0;
        private List<CustomerBillDetailDTO> customerBillDetails = new List<CustomerBillDetailDTO>();

        public VendorGUI(int staffID)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            this.staffID = staffID;
        }

        private void Vendor_Load(object sender, EventArgs e)
        {
            try
            {
                List<BookDTO> books = BookBUS.Instance.getAllData();
                foreach (var book in books)
                {
                    BookUserControl product = new BookUserControl(0);
                    product.details(book);
                    BookContainer.Controls.Add(product);

                }
                FilterUserControl filter = new FilterUserControl();
                FilterContainer.Controls.Add(filter);

                List<SaleDTO> discounts = SaleBUS.Instance.getAllNotExpired() ?? new List<SaleDTO>();
                discounts.Insert(0, new SaleDTO(0, "Không có khuyến mãi", 0, new DateTime(), new DateTime()));
                DiscountCb.DataSource = discounts;
                DiscountCb.DisplayMember = "tenKhuyenMai";
                DiscountCb.ValueMember = "maKhuyenMai";
                DiscountCb.SelectedIndex = 0;
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }

        private void CustomerToggleBtn_CheckedChanged(object sender, EventArgs e)
        {
            PhoneInp.Text = "Phone Number ...";
            CustomerEnabled = CustomerToggleBtn.Checked;
            PhoneInp.Enabled = CustomerEnabled;
            AddCustomerBtn.Enabled = CustomerEnabled;
            if (!CustomerEnabled)
            {
                RecipientNameLb.Text = "Vãng lai";
                PhoneInp.Text = "";
                PhoneResultContainer.Height = 0;
                PointToggleBtn.Checked = false;
            }
            else
            {
                PhoneInp.ForeColor = Color.DarkGray;
                RecipientNameLb.Text = "";
                PointToggleBtn.Enabled = false;
            }
        }

        private void RenderBookContainer()
        {
            try
            {
                BookContainer.Controls.Clear();
                List<BookDTO> books = BookBUS.Instance.getAllData();
                foreach (var book in books)
                {
                    BookUserControl product = new BookUserControl(0);
                    product.details(book);
                    BookContainer.Controls.Add(product);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }

        private void ProductSearchInp_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ProductSearchInp.ForeColor = Color.Black;
                if (ProductSearchInp.Focused && !string.IsNullOrEmpty(ProductSearchInp.Text))
                {
                    search = true;
                    BookContainer.Controls.Clear();
                    List <BookDTO> books = BookBUS.Instance.search(ProductSearchInp.Text);
                    foreach (var book in books)
                    {
                        BookUserControl product = new BookUserControl(0);
                        product.details(book);
                        BookContainer.Controls.Add(product);
                    }
                }
                else if (search)
                {
                    RenderBookContainer();
                    search = false;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }

        private void ProductSearchInp_Enter(object sender, System.EventArgs e)
        {
            try
            {
                if (ProductSearchInp.Text.Equals("Search ..."))
                {
                    ProductSearchInp.Text = "";
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }

        private void ProductSearchInp_Leave(object sender, System.EventArgs e)
        {
            try
            {
                if (ProductSearchInp.Text.Length <= 0)
                {
                    ProductSearchInp.Text = "Search ...";
                    ProductSearchInp.ForeColor = Color.DarkGray;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }

        private void FilterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!FilterContainer.Visible)
                {
                    FilterContainer.Visible = true;
                }
                else
                {
                    FilterContainer.Visible = false;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }

        }

        private void PhoneInp_Enter(object sender, EventArgs e)
        {
            if (PhoneInp.Text.Equals("Phone Number ..."))
            {
                PhoneInp.Text = "";
            }
        }

        private void PhoneInp_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true; // Cancel the key press event
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }

        private void PhoneInp_Leave(object sender, EventArgs e)
        {
            try
            {
                if (!CustomerToggleBtn.Focused)
                {
                    if (PhoneInp.Text.Length <= 0)
                    {
                        PhoneInp.Text = "Phone Number ...";
                        PhoneInp.ForeColor = Color.DarkGray;
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }

        private void PhoneInp_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (CustomerEnabled)
                {
                    PhoneInp.ForeColor = Color.Black;
                    if (PhoneInp.Focused && !string.IsNullOrEmpty(PhoneInp.Text)) {
                        PhoneResultContainer.Controls.Clear();
                        String query = PhoneInp.Text;
                        List<CustomerDTO> customers = CustomerBUS.Instance.SearchByPhoneNum(query);
                        if (customers != null)
                        {
                            foreach (var customer in customers)
                            {
                                SearchResultControl res = new SearchResultControl();
                                res.details_Vendor(customer);
                                PhoneResultContainer.Controls.Add(res);
                            }
                        }
                        if (PhoneResultContainer.Controls.Count <= 4)
                        {
                            PhoneResultContainer.Width = 244;
                        }
                        else
                        {
                            PhoneResultContainer.Width = 261;
                        }
                        PhoneResultContainer.Height = PhoneResultContainer.Controls.Count * 45;
                    }
                    else
                    {
                        PhoneResultContainer.Height = 0;
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }

        private void AddCustomerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                PhoneInp.Text = "Phone Number ...";
                PhoneInp.ForeColor = Color.DarkGray;
                PhoneResultContainer.Height = 0;
                RecipientNameLb.Text = "";
                PointToggleBtn.Checked = false;

                using (CustomerModal modal = new CustomerModal())
                {
                    modal.ShowDialog();

                    if (modal.isSubmitSuccess)
                    {
                        CustomerBUS.Instance.insert(modal.currentCustomer);
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }

        private void QRScanBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var modal = new ScannerModal();
                modal.ShowDialog();
                BookDTO book = modal.scannedBook;
                if (book != null)
                {
                    AddProductToCart(book);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }

        private void AddProductToCart(BookDTO book)
        {
            try
            {
                if (customerBillDetails.Count == 0 || !customerBillDetails.Any(item => item.MaSach == book.MaSach))
                {
                    CustomerBillDetailDTO customerBillDetail = new CustomerBillDetailDTO(0, book.MaSach, 1, book.GiaBan);
                    customerBillDetails.Add(customerBillDetail);
                    CartProductUserControl product = new CartProductUserControl(0);
                    product.details(book);
                    CartContainer.Controls.Add(product);
                }
                else
                {
                    int idx = 0;

                    foreach (var customerBillDetail in customerBillDetails)
                    {
                        if (customerBillDetail.MaSach == book.MaSach)
                        {
                            int stock = BookBUS.Instance.getById(book.MaSach.ToString()).SoLuongConLai;
                            if (customerBillDetail.SoLuong >= stock)
                            {
                                BookUserControl.ChoseId = "";
                                BookUserControl.clicked = false;
                                MessageBox.Show("Out of stock");
                                return;
                            }
                            else
                            {
                                customerBillDetail.SoLuong += 1;

                                CartProductUserControl cartProduct = CartContainer.Controls[idx] as CartProductUserControl;
                                cartProduct.AmountTxt.Text = (Convert.ToInt32(cartProduct.AmountTxt.Text) + 1).ToString();
                                break;
                            }
                        }
                        idx++;
                    }
                }

                CartHandler();
                BookUserControl.ChoseId = "";
                BookUserControl.clicked = false;
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }

        private void checkUser_Tick(object sender, EventArgs e)
        {
            try
            {
                if (BookUserControl.clicked)
                {
                    int ChoseId_int = Convert.ToInt32(BookUserControl.ChoseId);
                    BookDTO book = BookBUS.Instance.getById(BookUserControl.ChoseId);
                    AddProductToCart(book);
                }

                if (CartProductUserControl.deletePress)
                {
                    int idx = 0;

                    foreach (var customerBillDetail in customerBillDetails)
                    {
                        if (customerBillDetail.MaSach == Convert.ToInt32(CartProductUserControl.deleteId))
                        {
                            customerBillDetails.RemoveAt(idx);

                            CartProductUserControl cartProduct = CartContainer.Controls[idx] as CartProductUserControl;
                            CartContainer.Controls.RemoveAt(idx);
                            cartProduct.Dispose();
                            break;
                        }
                        idx++;
                    }

                    CartHandler();
                    CartProductUserControl.deleteId = "";
                    CartProductUserControl.deletePress = false;
                }

                if (CartProductUserControl.AmountChanged)
                {
                    int idx = 0;

                    foreach (var customerBillDetail in customerBillDetails)
                    {
                        if (customerBillDetail.MaSach == Convert.ToInt32(CartProductUserControl.AmountChangedId))
                        {
                            CartProductUserControl cartProduct = CartContainer.Controls[idx] as CartProductUserControl;
                            customerBillDetail.SoLuong = Convert.ToInt32(cartProduct.AmountTxt.Text);
                            break;
                        }
                        idx++;
                    }
                    CartHandler();
                    CartProductUserControl.AmountChanged = false;
                }

                if (SearchResultControl.clicked)
                {
                    customerID = SearchResultControl.id;
                    PointToggleBtn.Enabled = true;
                    CustomerDTO customer = CustomerBUS.Instance.getById(SearchResultControl.id.ToString());
                    RecipientNameLb.Text = customer.Ten;
                    PhoneResultContainer.Height = 0;
                    PhoneInp.Text = "Phone Number ...";
                    PhoneInp.ForeColor = Color.DarkGray;
                    CartHandler();
                    SearchResultControl.clicked = false;
                }

                if (FilterUserControl.ApplyClicked)
                {
                    FilterContainer.Visible = false;
                    List<BookDTO> books = BookBUS.Instance.getAllDataFiltered(FilterUserControl.Sort, FilterUserControl.TypeID, FilterUserControl.AuthorID, FilterUserControl.PublisherID, false);
                    BookContainer.Controls.Clear();
                    foreach (var book in books)
                    {
                        BookUserControl product = new BookUserControl(0);
                        product.details(book);
                        BookContainer.Controls.Add(product);
                    }
                    FilterUserControl.ApplyClicked = false;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }

        private void CartHandler()
        {
            try
            {
                double total = 0;
                foreach (var customerBillDetail in customerBillDetails)
                {
                    total += customerBillDetail.SoLuong * customerBillDetail.DonGia;
                }

                TotalMoneyLb.Text = string.Format("{0:N0} VND", total);
                double pointDiscount = 0;
                if (PointEnabled)
                {
                    pointDiscount = CustomerBUS.Instance.getById(customerID.ToString()).Diem * 1000;
                }
                Console.WriteLine(PointEnabled);
                Console.WriteLine(pointDiscount);
                finalTotalMoney = total - discount - pointDiscount;
                DiscountMoneyLb.Text = string.Format("{0:N0} VND", discount);
                FinalTotalMoneyLb.Text = string.Format("{0:N0} VND", finalTotalMoney);

                double CustommerCash = 0;
                double Change = 0;
                if (CustomerCashTxb.Text.Length > 0 && !CustomerCashTxb.Text.Equals("Khách đưa ...") && total > 0)
                {
                    CustommerCash = Convert.ToDouble(CustomerCashTxb.Text);
                    Change = CustommerCash - finalTotalMoney;
                }
                else
                {
                    Change = -finalTotalMoney;
                }
                ChangeMoneyLb.Text = string.Format("{0:N0} VND", Change);

                if (Change < 0)
                {
                    ChangeMoneyLb.ForeColor = Color.Red;
                }
                else
                {
                    ChangeMoneyLb.ForeColor = Color.Black;
                }

                if (CartContainer.Controls.Count > 0 && !String.IsNullOrEmpty(RecipientNameLb.Text) && CustomerCashTxb.Text.Length > 0 && Change >= 0)
                {
                    PrintBtn.Cursor = Cursors.Hand;
                    PrintBtnAllowed = true;
                }
                else
                {
                    PrintBtn.Cursor = Cursors.No;
                    PrintBtnAllowed = false;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }

        private void DiscountCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (DiscountCb.SelectedIndex != 0)
                {
                    string discountID = DiscountCb.SelectedValue.ToString();
                    double percent = SaleBUS.Instance.getById(discountID).PhanTram / 100;
                    double total = Convert.ToDouble(TotalMoneyLb.Text.Replace(".", "").Replace(" VND", ""));
                    discount = total * percent;
                    CartHandler();
                }
                else
                {
                    discount = 0;
                    CartHandler();
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }

        private void PointToggleBtn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (CustomerEnabled)
                {
                    PointEnabled = PointToggleBtn.Checked;
                }
                else
                {
                    PointEnabled = false;
                }

                CartHandler();
            }
            catch(Exception ex) { Console.WriteLine(ex); }
        }

        private void CustomerCashTxb_Enter(object sender, System.EventArgs e)
        {
            try
            {
                if (CustomerCashTxb.Text.Equals("Khách đưa ..."))
                {
                    CustomerCashTxb.Text = "";
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }

        private void CustomerCashTxb_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == '\r')
                {
                    TotalLb.Focus();
                    return;
                }

                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true; // Cancel the key press event
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }

        private void CustomerCashTxb_MouseLeave(object sender, EventArgs e)
        {
            VndLb.Focus();
        }

        private void CustomerCashTxb_Leave(object sender, System.EventArgs e)
        {
            try
            {
                if (CustomerCashTxb.Text.Length <= 0)
                {
                    CustomerCashTxb.Text = "Khách đưa ...";
                    CustomerCashTxb.ForeColor = Color.DarkGray;
                }
                else
                {
                    CustomerCashTxb.ForeColor = Color.Black;
                    CartHandler();
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        private double RoundMoney(double money)
        {
            double baseMoney = 50000; // Số tiền cơ sở để làm tròn
            return Convert.ToDouble(Math.Floor(money / baseMoney) * baseMoney);
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (PrintBtnAllowed)
                {
                    CustomerBillDTO customerBill = new CustomerBillDTO();
                    customerBill.TongTien = finalTotalMoney;
                    customerBill.TienKhachDua = Convert.ToDouble(CustomerCashTxb.Text);
                    customerBill.MaNhanVien = staffID;
                    customerBill.MaKhachHang = CustomerEnabled ? customerID : 0;
                    customerBill.MaKhuyenMai = Convert.ToInt32(DiscountCb.SelectedValue);
                    customerBill.NgayLap = DateTime.Now;

                    CustomerBillDTO newCustomerBill = CustomerBillBUS.Instance.insertReturnBill(customerBill);

                    if (newCustomerBill == null)
                    {
                        MessageBox.Show("Thất bại");
                    }
                    else
                    {
                        foreach (var customerBillDetail in customerBillDetails)
                        {
                            CustomerBillDetailDTO newCustomerBillDetail = new CustomerBillDetailDTO(
                                newCustomerBill.MaDonKhachHang,
                                customerBillDetail.MaSach,
                                customerBillDetail.SoLuong,
                                customerBillDetail.DonGia
                            );

                            CustomerBillBUS.Instance.createCustomerBillDetail(newCustomerBillDetail);
                        }

                        MessageBox.Show("Thành công");
                    }

                    if (CustomerEnabled)
                    {
                        if (PointEnabled)
                        {
                            CustomerDTO customer_resetPoint = CustomerBUS.Instance.getById(customerID.ToString());
                            customer_resetPoint.Diem = 0;
                            CustomerBUS.Instance.update(customer_resetPoint);
                        }

                        double baseMoney = 50000;
                        int point = Convert.ToInt32(RoundMoney(finalTotalMoney) / baseMoney);
                        CustomerDTO customer_addPoint = CustomerBUS.Instance.getById(customerID.ToString());
                        customer_addPoint.Diem += point;
                        CustomerBUS.Instance.update(customer_addPoint);
                        if (point > 0)
                        {
                            MessageBox.Show("Khách hàng " + customer_addPoint.Ten + " được cộng: " + point + " điểm");
                        }
                    }

                    CartContainer.Controls.Clear();
                    customerBillDetails.Clear();
                    CustomerEnabled = false;
                    PointEnabled = false;
                    PointToggleBtn.Checked = false;
                    PointToggleBtn.Enabled = false;
                    CustomerToggleBtn.Checked = false;
                    CustomerCashTxb.Text = "Khách đưa ...";
                    CustomerCashTxb.ForeColor = Color.DarkGray;
                    discount = 0;
                    DiscountMoneyLb.Text = "0 VND";
                    DiscountCb.SelectedIndex = 0;
                    RecipientNameLb.Text = string.Empty;
                    customerID = 0;
                    CartHandler();
                    RenderBookContainer();
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            Close();
            /*Application.Run(new LoginGUI());*/
        }
    }
}