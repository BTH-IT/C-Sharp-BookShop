using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Controls;
using System.Windows.Forms;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;
using QuanLyCuaHangBanSach.GUI.UserControls;
using QuanLyCuaHangBanSach.GUI.Vendor;
using static ZXing.QrCode.Internal.Mode;

namespace QuanLyCuaHangBanSach.GUI
{
    public partial class VendorGUI : Form
    {
        public VendorGUI()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void Vendor_Load(object sender, EventArgs e)
        {
            try
            {
                List<BookDTO> books = BookBUS.Instance.getAllData();
                foreach (var book in books)
                {
                    BookUserControl product = new BookUserControl();
                    product.details(book);
                    BookContainer.Controls.Add(product);

                    FilterUserControl filter = new FilterUserControl();
                    FilterContainer.Controls.Add(filter);
                }

                List<SaleDTO> discounts = SaleBUS.Instance.getAllNotExpired();
                discounts.Insert(0, new SaleDTO(0, "Không có khuyến mãi", 0, new DateTime(), new DateTime()));
                DiscountCb.DataSource = discounts;
                DiscountCb.DisplayMember = "tenKhuyenMai";
                DiscountCb.ValueMember = "phanTram";
                DiscountCb.SelectedIndex = 0;
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
                    List <BookDTO> books = BookBUS.Instance.search(ProductSearchInp.Text);
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

        private void ProductSearchInp_Click(object sender, System.EventArgs e)
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

        private void PhoneInp_Click(object sender, EventArgs e)
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
                if (PhoneInp.Focused && !string.IsNullOrEmpty(PhoneInp.Text)) {
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

        private List<int> cart = new List<int>();
        private void checkUser_Tick(object sender, EventArgs e)
        {
            try
            {
                if (BookUserControl.clicked)
                {
                    int ChoseId_int = int.Parse(BookUserControl.ChoseId);
                    if (cart.Count == 0 || !cart.Contains(ChoseId_int))
                    {
                        cart.Add(ChoseId_int);
                        BookDTO book = BookBUS.Instance.getById(BookUserControl.ChoseId);
                        CartProductUserControl product = new CartProductUserControl();
                        product.details(book);
                        CartContainer.Controls.Add(product);
                    }
                    else
                    {
                        foreach (System.Windows.Forms.Control ctrl in CartContainer.Controls)
                        {
                            if (ctrl is CartProductUserControl cartProduct && cartProduct.IdLb.Text.Equals(BookUserControl.ChoseId))
                            {
                                cartProduct.AmountTxt.Text = (int.Parse(cartProduct.AmountTxt.Text) + 1).ToString();
                            }
                        }
                    }

                    CartHandler();
                    BookUserControl.ChoseId = "";
                    BookUserControl.clicked = false;
                }

                if (CartProductUserControl.deletePress)
                {
                    for (int i = 0; i < CartContainer.Controls.Count; i++)
                    {
                        System.Windows.Forms.Control ctrl = CartContainer.Controls[i];
                        if (ctrl is CartProductUserControl cartProduct)
                        {
                            if (cartProduct.IdLb.Text.Equals(CartProductUserControl.deleteId))
                            {
                                cart.RemoveAt(i);
                                CartContainer.Controls.RemoveAt(i);
                                cartProduct.Dispose();
                            }
                        }
                    }
                    CartHandler();
                    CartProductUserControl.deleteId = "";
                    CartProductUserControl.deletePress = false;
                }

                if (PhoneSearchResultControl.clicked)
                {
                    CustomerDTO customer = CustomerBUS.Instance.getById(PhoneSearchResultControl.id.ToString());
                    RecipientNameLb.Text = customer.Ten;
                    PhoneResultContainer.Height = 0;
                    PhoneInp.Text = "Phone Number ...";
                    PhoneInp.ForeColor = Color.DarkGray;
                    CartHandler();
                    PhoneSearchResultControl.clicked = false;
                }

                if (CartProductUserControl.AmountChanged)
                {
                    CartHandler();
                    CartProductUserControl.AmountChanged = false;
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

        private bool PrintBtnAllowed;
        private void CartHandler()
        {
            try
            {
                double total = 0;
                for (int i = 0; i < CartContainer.Controls.Count; i++)
                {
                    System.Windows.Forms.Control ctrl = CartContainer.Controls[i];
                    if (ctrl is CartProductUserControl cartProduct)
                    {
                        BookDTO book = BookBUS.Instance.getById(cartProduct.IdLb.Text);
                        double price = book.GiaBan * int.Parse(cartProduct.AmountTxt.Text);
                        total += price;
                    }
                }
                TotalMoneyLb.Text = string.Format("{0:N0} VND", total);
                double finalTotalMoney = total - discount;
                DiscountMoneyLb.Text = string.Format("{0:N0} VND", discount);
                FinalTotalMoneyLb.Text = string.Format("{0:N0} VND", finalTotalMoney);

                double CustommerCash = 0;
                double Change = 0;
                if (CustomerCashTxb.Text.Length > 0 && !CustomerCashTxb.Text.Equals("Khách đưa ...") && total > 0)
                {
                    CustommerCash = double.Parse(CustomerCashTxb.Text);
                    Change = CustommerCash - finalTotalMoney;
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

        private double discount = 0;
        private void DiscountCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (DiscountCb.SelectedIndex != 0)
                {
                    double percent = double.Parse(DiscountCb.SelectedValue.ToString()) / 100;
                    double total = double.Parse(TotalMoneyLb.Text.Replace(".", "").Replace(" VND", ""));
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

        private void CustomerCashTxb_Click(object sender, System.EventArgs e)
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

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (PrintBtnAllowed)
                {
                    foreach (System.Windows.Forms.Control ctrl in CartContainer.Controls)
                    {
                        if (ctrl is CartProductUserControl cartProduct)
                        {
                            BookDTO book = BookBUS.Instance.getById(cartProduct.IdLb.Text);
                            book.SoLuongConLai -= int.Parse(cartProduct.AmountTxt.Text);
                            BookBUS.Instance.update(book);
                        }
                    }

                    CartContainer.Controls.Clear();
                    cart.Clear();
                    CustomerCashTxb.Text = "";
                    CustomerCashTxb.Text = "Khách đưa ...";
                    CustomerCashTxb.ForeColor = Color.DarkGray;
                    discount = 0;
                    DiscountMoneyLb.Text = "0 VND";
                    DiscountCb.SelectedIndex = 0;
                    RecipientNameLb.Text = string.Empty;
                    CartHandler();
                    RenderBookContainer();
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}