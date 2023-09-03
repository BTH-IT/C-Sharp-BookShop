using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Controls;
using System.Windows.Forms;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;
using QuanLyCuaHangBanSach.GUI.Vendor;

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
            List<BookDTO> books = BookBUS.Instance.getAllData();
            foreach (var book in books)
            {
                BookUserControl product = new BookUserControl();
                product.details(book);
                BookContainer.Controls.Add(product);
            }
        }

        public bool search = false;
        private void ProductSearchInp_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ProductSearchInp.ForeColor = Color.Black;
                if (ProductSearchInp.Focused && !string.IsNullOrEmpty(ProductSearchInp.Text))
                {
                    BookContainer.Controls.Clear();
                    search = true;
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
                    BookContainer.Controls.Clear();
                    List<BookDTO> books = BookBUS.Instance.getAllData();
                    foreach (var book in books)
                    {
                        BookUserControl product = new BookUserControl();
                        product.details(book);
                        BookContainer.Controls.Add(product);
                        search = false;
                    }
                }
            }
            catch
            {
            }
        }

        private void ProductSearchInp_Click(object sender, System.EventArgs e)
        {
            if (ProductSearchInp.Text.Equals("Search ..."))
            {
                ProductSearchInp.Text = "";
            }
        }

        private void ProductSearchInp_Leave(object sender, System.EventArgs e)
        {
            if (ProductSearchInp.Text.Length <= 0)
            {
                ProductSearchInp.Text = "Search ...";
                ProductSearchInp.ForeColor = Color.DarkGray;
            }
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
            catch
            {
            }
        }

        private List<int> cart = new List<int>();

        private void checkUser_Tick(object sender, EventArgs e)
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

                CalculateTotal();
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
                CalculateTotal();
                CartProductUserControl.deleteId = "";
                CartProductUserControl.deletePress = false;
            }

            if (PhoneSearchResultControl.clicked)
            {
                CustomerDTO customer = CustomerBUS.Instance.getById(PhoneSearchResultControl.id.ToString());
                RecipientLb.Text = "Recipient: " + customer.Ten;
                PhoneResultContainer.Height = 0;
                PhoneInp.Text = "Phone Number ...";
                PhoneInp.ForeColor = Color.DarkGray;
                PhoneSearchResultControl.clicked = false;
            }

            if (CartProductUserControl.AmountChanged)
            {
                CalculateTotal();
                CartProductUserControl.AmountChanged = false;
            }
        }

        private void CalculateTotal()
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
            TotalMoneyLb.Text = string.Format("{0:N0} đ", total);
            if (total > 0)
            {
                PrintBtn.Cursor = Cursors.Hand;
            }
            else
            {
                PrintBtn.Cursor = Cursors.No;
            }
        }

        private void PhoneInp_Click(object sender, EventArgs e)
        {
            if (PhoneInp.Text.Equals("Phone Number ..."))
            {
                PhoneInp.Text = "";
            }
        }

        private void PhoneInp_Leave(object sender, EventArgs e)
        {
            if (PhoneInp.Text.Length <= 0)
            {
                PhoneInp.Text = "Phone Number ...";
                PhoneInp.ForeColor = Color.DarkGray;
            }
        }
    }
}