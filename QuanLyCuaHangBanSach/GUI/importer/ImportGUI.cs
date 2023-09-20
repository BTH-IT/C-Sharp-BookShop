using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;
using QuanLyCuaHangBanSach.GUI.Modal;
using QuanLyCuaHangBanSach.GUI.UserControls;
using QuanLyCuaHangBanSach.GUI.Vendor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangBanSach.GUI.Importer
{
    public partial class ImportGUI : Form
    {
        public ImportGUI()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }
        private void panel4_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void Import_Load(object sender, EventArgs e)
        {
            try
            {
                List<BookDTO> books = BookBUS.Instance.getAllData();
                foreach (var book in books)
                {
                    BookUserControl product = new BookUserControl();
                    product.details(book);
                    BookContainer.Controls.Add(product);

                }
                FilterUserControl filter = new FilterUserControl();
                FilterContainer.Controls.Add(filter);
            }

            catch (Exception ex) { Console.WriteLine(ex); }
        }

        private void RenderBookContainer()
        {
            try
            {
                BookContainer.Controls.Clear();
                List<BookDTO> books = BookBUS.Instance.getAllData();
                foreach (var book in books)
                {
                    BookUserControl product = new BookUserControl();
                    product.details(book);
                    BookContainer.Controls.Add(product);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }

        private bool search = false;
        private void ProductSearchInp_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ProductSearchInp.ForeColor = Color.Black;
                if (ProductSearchInp.Focused && !string.IsNullOrEmpty(ProductSearchInp.Text))
                {
                    search = true;
                    BookContainer.Controls.Clear();
                    List<BookDTO> books = BookBUS.Instance.search(ProductSearchInp.Text);
                    foreach (var book in books)
                    {
                        BookUserControl product = new BookUserControl();
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
                if (PhoneInp.Text.Length <= 0)
                {
                    PhoneInp.Text = "Phone Number ...";
                    PhoneInp.ForeColor = Color.DarkGray;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }

        private void PhoneInp_TextChanged(object sender, EventArgs e)
        {
            try
            {
                PhoneInp.ForeColor = Color.Black;
                if (PhoneInp.Focused && !string.IsNullOrEmpty(PhoneInp.Text))
                {
                    PhoneResultContainer.Controls.Clear();
                    String query = PhoneInp.Text;
                    List<CustomerDTO> customers = CustomerBUS.Instance.SearchByPhoneNum(query);
                    if (customers != null)
                    {
                        foreach (var customer in customers)
                        {
                            PhoneSearchResultControl res = new PhoneSearchResultControl();
                            res.details(customer);
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
            catch (Exception ex) { Console.WriteLine(ex); }
        }

        private void QRScanBtn_Click(object sender, EventArgs e)
        {
            var modal = new ScannerModal();
            modal.ShowDialog();
        }

        private int customerID = -1;
        private List<CustomerBillDetailDTO> customerBillDetails = new List<CustomerBillDetailDTO>();
        private void checkUser_Tick(object sender, EventArgs e)
        {
            try
            {
                if (BookUserControl.clicked)
                {
                    int ChoseId_int = Convert.ToInt32(BookUserControl.ChoseId);
                    if (customerBillDetails.Count == 0 || !customerBillDetails.Any(item => item.MaSach == ChoseId_int))
                    {
                        BookDTO book = BookBUS.Instance.getById(BookUserControl.ChoseId);
                        CustomerBillDetailDTO customerBillDetail = new CustomerBillDetailDTO(0, ChoseId_int, 1, book.GiaBan);
                        customerBillDetails.Add(customerBillDetail);
                        CartProductUserControl product = new CartProductUserControl();
                        product.details(book);
                        CartContainer.Controls.Add(product);
                    }
                    else
                    {
                        int idx = 0;

                        foreach (var customerBillDetail in customerBillDetails)
                        {
                            if (customerBillDetail.MaSach == ChoseId_int)
                            {
                                int stock = BookBUS.Instance.getById(BookUserControl.ChoseId).SoLuongConLai;
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

                if (PhoneSearchResultControl.clicked)
                {
                    customerID = PhoneSearchResultControl.id;
                    CustomerDTO customer = CustomerBUS.Instance.getById(PhoneSearchResultControl.id.ToString());
                    ProviderNameLb.Text = customer.Ten;
                    PhoneResultContainer.Height = 0;
                    PhoneInp.Text = "Phone Number ...";
                    PhoneInp.ForeColor = Color.DarkGray;
                    CartHandler();
                    PhoneSearchResultControl.clicked = false;
                }

                if (FilterUserControl.ApplyClicked)
                {
                    FilterContainer.Visible = false;
                    List<BookDTO> books = BookBUS.Instance.getAllDataFiltered(FilterUserControl.Sort, FilterUserControl.TypeID, FilterUserControl.AuthorID, FilterUserControl.PublisherID);
                    BookContainer.Controls.Clear();
                    foreach (var book in books)
                    {
                        BookUserControl product = new BookUserControl();
                        product.details(book);
                        BookContainer.Controls.Add(product);
                    }
                    FilterUserControl.ApplyClicked = false;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }

        private bool PrintBtnAllowed = false;
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

                double shopPaid = 0;
                double arrear = 0;
                if (ShopPaidTxb.Text.Length > 0 && !ShopPaidTxb.Text.Equals("Tiền đưa Nhà cung cấp ...") && total > 0)
                {
                    shopPaid = Convert.ToDouble(ShopPaidTxb.Text);
                    arrear = shopPaid - total;
                }
                else
                {
                    arrear = -total;
                }
                ArrearMoneyLb.Text = string.Format("{0:N0} VND", arrear);

                if (CartContainer.Controls.Count > 0 && !String.IsNullOrEmpty(ProviderNameLb.Text) && ShopPaidTxb.Text.Length > 0 && arrear >= 0)
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

        private void ShopPaidTxb_Enter(object sender, System.EventArgs e)
        {
            try
            {
                if (ShopPaidTxb.Text.Equals("Tiền đưa Nhà cung cấp ..."))
                {
                    ShopPaidTxb.Text = "";
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }

        private void ShopPaidTxb_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ShopPaidTxb_MouseLeave(object sender, EventArgs e)
        {
            VndLb.Focus();
        }

        private void ShopPaidTxb_Leave(object sender, System.EventArgs e)
        {
            try
            {
                if (ShopPaidTxb.Text.Length <= 0)
                {
                    ShopPaidTxb.Text = "Tiền đưa nhà cung cấp ...";
                    ShopPaidTxb.ForeColor = Color.DarkGray;
                }
                else
                {
                    ShopPaidTxb.ForeColor = Color.Black;
                    CartHandler();
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (PrintBtnAllowed)
                {
                    CustomerBillDTO customerBill = new CustomerBillDTO();
                    customerBill.TongTien = finalTotalMoney;
                    customerBill.TienKhachDua = Convert.ToDouble(ShopPaidTxb.Text);
                    customerBill.MaNhanVien = 1;
                    customerBill.MaKhachHang = customerID;
                    customerBill.MaKhuyenMai = Convert.ToInt32(DiscountCb.SelectedValue);
                    customerBill.NgayLap = DateTime.Now;

                    CustomerBillDTO newCustomerBill = CustomerBillBUS.Instance.insertReturnBill(customerBill);

                    if (newCustomerBill == null)
                    {
                        MessageBox.Show("Failure");
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

                        MessageBox.Show("Success");
                    }

                    CartContainer.Controls.Clear();
                    foreach (var item in customerBillDetails)
                    {
                        Console.WriteLine(item.ToString());
                    }
                    customerBillDetails.Clear();
                    ShopPaidTxb.Text = "";
                    ShopPaidTxb.Text = "Khách đưa ...";
                    ShopPaidTxb.ForeColor = Color.DarkGray;
                    discount = 0;
                    DiscountMoneyLb.Text = "0 VND";
                    DiscountCb.SelectedIndex = 0;
                    RecipientNameLb.Text = string.Empty;
                    customerID = -1;
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