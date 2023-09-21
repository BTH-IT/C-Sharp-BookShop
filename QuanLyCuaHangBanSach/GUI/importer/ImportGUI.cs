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
        private bool search = false;
        private bool PrintBtnAllowed = false;
        private int supplierID = 0;
        private double total = 0;
        private List<ImportBillDetailDTO> importBillDetails = new List<ImportBillDetailDTO>();

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
                    BookUserControl product = new BookUserControl(1);
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
                    BookUserControl product = new BookUserControl(1);
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
                    List<BookDTO> books = BookBUS.Instance.search(ProductSearchInp.Text);
                    foreach (var book in books)
                    {
                        BookUserControl product = new BookUserControl(1);
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

        private void NameInp_Enter(object sender, EventArgs e)
        {
            if (NameInp.Text.Equals("Supplier Name ..."))
            {
                NameInp.Text = "";
            }
        }

        private void NameInp_Leave(object sender, EventArgs e)
        {
            try
            {
                if (NameInp.Text.Length <= 0)
                {
                    NameInp.Text = "Supplier Name ...";
                    NameInp.ForeColor = Color.DarkGray;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }

        private void NameInp_TextChanged(object sender, EventArgs e)
        {
            try
            {
                NameInp.ForeColor = Color.Black;
                if (NameInp.Focused && !string.IsNullOrEmpty(NameInp.Text))
                {
                    NameResultContainer.Controls.Clear();
                    String query = NameInp.Text;
                    List<SupplierDTO> suppliers = SupplierBUS.Instance.search(query);
                    if (suppliers != null)
                    {
                        foreach (var supplier in suppliers)
                        {
                            SearchResultControl res = new SearchResultControl();
                            res.details_Import(supplier);
                            NameResultContainer.Controls.Add(res);
                        }
                    }
                    if (NameResultContainer.Controls.Count <= 4)
                    {
                        NameResultContainer.Width = 244;
                    }
                    else
                    {
                        NameResultContainer.Width = 261;
                    }
                    NameResultContainer.Height = NameResultContainer.Controls.Count * 45;
                }
                else
                {
                    NameResultContainer.Height = 0;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }

        private void QRScanBtn_Click(object sender, EventArgs e)
        {
            var modal = new ScannerModal();
            modal.ShowDialog();
        }

        private void checkUser_Tick(object sender, EventArgs e)
        {
            try
            {
                if (BookUserControl.clicked)
                {
                    int ChoseId_int = Convert.ToInt32(BookUserControl.ChoseId);
                    if (importBillDetails.Count == 0 || !importBillDetails.Any(item => item.MaSach == ChoseId_int))
                    {
                        BookDTO book = BookBUS.Instance.getById(BookUserControl.ChoseId);
                        ImportBillDetailDTO importBillDetail = new ImportBillDetailDTO(0, ChoseId_int, 1, book.GiaNhap);
                        importBillDetails.Add(importBillDetail);
                        CartProductUserControl product = new CartProductUserControl(1);
                        product.details(book);
                        CartContainer.Controls.Add(product);
                    }
                    else
                    {
                        int idx = 0;

                        foreach (var importBillDetail in importBillDetails)
                        {
                            if (importBillDetail.MaSach == ChoseId_int)
                            {
                                importBillDetail.SoLuong += 1;

                                CartProductUserControl cartProduct = CartContainer.Controls[idx] as CartProductUserControl;
                                cartProduct.AmountTxt.Text = (Convert.ToInt32(cartProduct.AmountTxt.Text) + 1).ToString();
                                break;
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

                    foreach (var importBillDetail in importBillDetails)
                    {
                        if (importBillDetail.MaSach == Convert.ToInt32(CartProductUserControl.deleteId))
                        {
                            importBillDetails.RemoveAt(idx);

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

                    foreach (var importBillDetail in importBillDetails)
                    {
                        if (importBillDetail.MaSach == Convert.ToInt32(CartProductUserControl.AmountChangedId))
                        {
                            CartProductUserControl cartProduct = CartContainer.Controls[idx] as CartProductUserControl;
                            importBillDetail.SoLuong = Convert.ToInt32(cartProduct.AmountTxt.Text);
                            break;
                        }
                        idx++;
                    }
                    CartHandler();
                    CartProductUserControl.AmountChanged = false;
                }

                if (SearchResultControl.clicked)
                {
                    supplierID = SearchResultControl.id;
                    SupplierDTO supplier = SupplierBUS.Instance.getById(SearchResultControl.id.ToString());
                    SupplierNameLb.Text = supplier.TenNhaCungCap;
                    NameResultContainer.Height = 0;
                    NameInp.Text = "Supplier Name ...";
                    NameInp.ForeColor = Color.DarkGray;
                    CartHandler();
                    SearchResultControl.clicked = false;
                }

                if (FilterUserControl.ApplyClicked)
                {
                    FilterContainer.Visible = false;
                    List<BookDTO> books = BookBUS.Instance.getAllDataFiltered(FilterUserControl.Sort, FilterUserControl.TypeID, FilterUserControl.AuthorID, FilterUserControl.PublisherID, true);
                    BookContainer.Controls.Clear();
                    foreach (var book in books)
                    {
                        BookUserControl product = new BookUserControl(1);
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
                total = 0;
                foreach (var importBillDetail in importBillDetails)
                {
                    total += importBillDetail.SoLuong * importBillDetail.DonGia;
                }

                TotalMoneyLb.Text = string.Format("{0:N0} VND", total);

                double shopPaid = 0;
                double arrear = 0;
                if (ShopPaidTxb.Text.Length > 0 && !ShopPaidTxb.Text.Equals("Shop Paid ...") && total > 0)
                {
                    shopPaid = Convert.ToDouble(ShopPaidTxb.Text);
                    if (shopPaid > total)
                    {
                        shopPaid = total;
                        ShopPaidTxb.Text = shopPaid.ToString();
                    }
                    arrear = total - shopPaid;
                }
                else
                {
                    arrear = -total;
                }
                ArrearMoneyLb.Text = string.Format("{0:N0} VND", arrear);

                if (CartContainer.Controls.Count > 0 && !String.IsNullOrEmpty(SupplierNameLb.Text) && ShopPaidTxb.Text.Length > 0 && arrear >= 0)
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
                if (ShopPaidTxb.Text.Equals("Shop Paid ..."))
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
                    ShopPaidTxb.Text = "Shop Paid ...";
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
                    ImportBillDTO importBill = new ImportBillDTO();
                    importBill.TongTien = total;
                    importBill.MaNhanVien = 1;
                    importBill.MaNhaCungCap = supplierID;
                    importBill.DaTra = Convert.ToDouble(ShopPaidTxb.Text);
                    importBill.NgayLap = DateTime.Now;

                    ImportBillDTO newImportBill = ImportBillBUS.Instance.insertReturnBill(importBill);

                    if (newImportBill == null)
                    {
                        MessageBox.Show("Failure");
                    }
                    else
                    {
                        foreach (var importBillDetail in importBillDetails)
                        {
                            ImportBillDetailDTO newImportBillDetail = new ImportBillDetailDTO(
                                newImportBill.MaDonNhapHang,
                                importBillDetail.MaSach,
                                importBillDetail.SoLuong,
                                importBillDetail.DonGia
                            );

                            ImportBillBUS.Instance.createImportBillDetail(newImportBillDetail);
                        }

                        MessageBox.Show("Success");
                    }

                    CartContainer.Controls.Clear();
                    importBillDetails.Clear();
                    ShopPaidTxb.Text = "Tiền đưa Nhà cung cấp ...";
                    ShopPaidTxb.ForeColor = Color.DarkGray;
                    SupplierNameLb.Text = "";
                    supplierID = 0;
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