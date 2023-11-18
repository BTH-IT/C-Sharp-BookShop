using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;
using QuanLyCuaHangBanSach.GUI.Modal;
using QuanLyCuaHangBanSach.GUI.Report;
using QuanLyCuaHangBanSach.GUI.UserControls;
using QuanLyCuaHangBanSach.GUI.Vendor;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyCuaHangBanSach.GUI.Importer
{
    public partial class ImportGUI : Form
    {
        private bool search = false;
        private bool PrintBtnAllowed = false;
        private int supplierID = 0;
        private int staffID;
        private double total = 0;
        private List<ImportBillDetailDTO> importBillDetails = new List<ImportBillDetailDTO>();

        public ImportGUI(int staffID)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            this.staffID = staffID;
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
                    product.TabStop = false;
					BookContainer.Controls.Add(product);

                }
                FilterUserControl filter = new FilterUserControl();
                filter.TabStop = false;
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
                    product.TabStop = false;
					BookContainer.Controls.Add(product);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }

        private void ProductSearchInp_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (ProductSearchInp.Focused && !string.IsNullOrEmpty(ProductSearchInp.Text))
                {
                    search = true;
                    BookContainer.Controls.Clear();
                    List<BookDTO> books = BookBUS.Instance.search(ProductSearchInp.Text);
                    foreach (var book in books)
                    {
                        BookUserControl product = new BookUserControl(1);
                        product.details(book);
                        product.TabStop = false;
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

        private void NameInp_TextChanged(object sender, EventArgs e)
        {
            try
            {
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
                            res.TabStop = false;
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

        private void AddSupplierBtn_Click(object sender, EventArgs e)
        {
            try
            {
                NameInp.Text = "";
                NameResultContainer.Height = 0;
                SupplierNameLb.Text = "";

                using (SupplierModal modal = new SupplierModal())
                {
                    modal.ShowDialog();
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
                if (importBillDetails.Count == 0 || !importBillDetails.Any(item => item.MaSach == book.MaSach))
                {
                    ImportBillDetailDTO importBillDetail = new ImportBillDetailDTO(0, book.MaSach, 1, book.GiaNhap);
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
                        if (importBillDetail.MaSach == book.MaSach)
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
                    NameInp.Text = "";
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
                        product.TabStop = false;
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

                if (CartContainer.Controls.Count > 0 && supplierID != 0)
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
		private void ProductSearchInp_MouseLeave(object sender, EventArgs e)
		{
			panel1.Focus();
		}

		private void PrintBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (PrintBtnAllowed)
                {
                    ImportBillDTO importBill = new ImportBillDTO();
                    importBill.TongTien = total;
                    importBill.MaNhanVien = staffID;
                    importBill.MaNhaCungCap = supplierID;
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

                    using (ImportBillPrintForm importBillPrintForm = new ImportBillPrintForm(newImportBill.MaDonNhapHang))
                    {
                        importBillPrintForm.ShowDialog();
                    }

                    CartContainer.Controls.Clear();
                    importBillDetails.Clear();
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
            MenuGUI menu = new MenuGUI(staffID);
            menu.Show();
        }

		private void ExcelImportBtn_Click(object sender, EventArgs e)
		{
			try
			{
				DataTable dt = CustomExcel.Instance.ImportFile();

				if (dt == null)
				{
					MessageBox.Show("Lỗi chưa chọn file hoặc file excel không đúng dữ liệu!");
					return;
				}

				ImportBillDTO newImportBill = new ImportBillDTO(0, 1, staffID, DateTime.Now, 0);

				ImportBillDTO importBill = ImportBillBUS.Instance.insertReturnBill(newImportBill);

				if (importBill != null)
				{
					double tongTien = 0;
					foreach (DataRow row in dt.Rows)
					{
						BookDTO book = BookBUS.Instance.getById(row[0].ToString());

						if (book == null) continue;

						ImportBillDetailDTO importBillDetail = new ImportBillDetailDTO(importBill.MaDonNhapHang, book.MaSach, Convert.ToInt32(row[2].ToString()), Convert.ToDouble(row[3].ToString()));

						if (ImportBillBUS.Instance.createImportBillDetail(importBillDetail))
						{
							book.SoLuongConLai += Convert.ToInt32(row[2].ToString());
							book.GiaNhap = Convert.ToDouble(row[3].ToString());

							BookBUS.Instance.update(book);

							tongTien += book.GiaNhap * Convert.ToInt32(row[2].ToString());
						};
					}

					importBill.TongTien = tongTien;

					ImportBillBUS.Instance.update(importBill);

					MessageBox.Show("Nhập hàng từ file excel thành công!");

					using (ImportBillPrintForm importBillPrintForm = new ImportBillPrintForm(importBill.MaDonNhapHang))
					{
						importBillPrintForm.ShowDialog();
					}

					try
					{
						CartContainer.Controls.Clear();
						importBillDetails.Clear();
						SupplierNameLb.Text = "";
						supplierID = 0;
						CartHandler();
						RenderBookContainer();
					}
					catch (Exception ex)
					{
						Console.WriteLine(ex);
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
		}

		private void NameInp_KeyPress(object sender, KeyPressEventArgs e)
		{
			try
			{
				if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
				{
					e.Handled = true; // Cancel the key press event
				}
			}
			catch (Exception ex) { Console.WriteLine(ex); }
		}
	}
}
