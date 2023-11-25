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
        private bool printImportBtnAllowed = false;
		private bool printRequestBtnAllowed = false;
		private int supplierID = 0;
        private int staffID;
		private bool importExcel = false;
		private int importBillId = Convert.ToInt32(ImportBillBUS.Instance.getLatestId()) + 1;
		private decimal total = 0;
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
				label1.Focus();
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
				label1.Focus();
			}
			catch (Exception ex) { Console.WriteLine(ex); }
        }

        private void AddProductToCart(BookDTO book, decimal importPrice = -1, int amount = 1, bool disabled = false)
        {
            try
            {
                if (importBillDetails.Count == 0 || !importBillDetails.Any(item => item.MaSach == book.MaSach))
                {
					ImportCartProductUserControl product = new ImportCartProductUserControl(ManualImportToggleBtn.Checked || importExcel ? 1 : 0);
                    product.details(book, amount);
					product.BillIdDetailLb.Text = importBillId.ToString();

                    product.ImportPriceTxb.MouseLeave += (object sender, EventArgs e) =>
                    {
                        panel1.Focus();
                        ImportBillDetailDTO match = importBillDetails.Find(item => item.MaSach == Convert.ToInt32(product.IdLb.Text));
                        if (match != null)
                        {
                            match.DonGia = Convert.ToDecimal(product.ImportPriceTxb.Text);
                        }
                        CartHandler();
					};

                    if (importPrice != -1)
                    {
                        product.ImportPriceTxb.Text = importPrice.ToString();
					}

                    if (disabled)
                    {
                        product.amountPanel.Enabled = false;
                        product.ImportPriceTxb.Enabled = false;
                        product.DeleteBtn.Enabled = false;
					}

                    CartContainer.Controls.Add(product);

                    if (ManualImportToggleBtn.Checked || importExcel)
                    {
                        ImportBillDetailDTO importBillDetail = new ImportBillDetailDTO(0, book.MaSach, amount, Convert.ToDecimal(product.ImportPriceTxb.Text));
                        importBillDetails.Add(importBillDetail);
                    }
                    else
                    {
                        //tao don yeu cau
                    }
                    Console.WriteLine(importBillDetails.Count);
                }
                else
                {
                    int idx = 0;

                    foreach (var importBillDetail in importBillDetails)
                    {
                        if (importBillDetail.MaSach == book.MaSach)
                        {
                            importBillDetail.SoLuong += 1;
                            ImportCartProductUserControl cartProduct = CartContainer.Controls[idx] as ImportCartProductUserControl;
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

		private void QRScanBtn_Click(object sender, EventArgs e)
		{
			try
			{
				var modal = new ScannerModal();
				modal.ShowDialog();
				BookDTO book = modal.scannedBook;
				if (book != null)
				{
					AddProductToCart(book, 1);
				}
				label1.Focus();
			}
			catch (Exception ex) { Console.WriteLine(ex); }
		}

		private void ManualImportToggleBtn_CheckedChanged(object sender, EventArgs e)
		{
            if (ManualImportToggleBtn.Checked)
            {
                QRScanBtn.Enabled = true;
                QRScanBtn.Cursor = Cursors.Hand;
			}
            else
            {
                QRScanBtn.Enabled = false;
				QRScanBtn.Cursor = Cursors.No;
			}
            importBillDetails.Clear();
			importExcel = false;
			CartContainer.Controls.Clear();
            CartHandler();
		}

		private void checkUser_Tick(object sender, EventArgs e)
        {
            try
            {
                if (BookUserControl.clicked)
                {
                    if (!importExcel)
                    {
                        int ChoseId_int = Convert.ToInt32(BookUserControl.ChoseId);
                        BookDTO book = BookBUS.Instance.getById(BookUserControl.ChoseId);
                        AddProductToCart(book, book.GiaNhap);
						BookUserControl.clicked = false;
					}
					else
                    {
                        BookUserControl.clicked = false;
                    }
                }

                if (ImportCartProductUserControl.deletePress)
                {
                    int idx = 0;

                    foreach (var importBillDetail in importBillDetails)
                    {
                        if (importBillDetail.MaSach == Convert.ToInt32(ImportCartProductUserControl.deleteId))
                        {
                            importBillDetails.RemoveAt(idx);

                            ImportCartProductUserControl cartProduct = CartContainer.Controls[idx] as ImportCartProductUserControl;
                            CartContainer.Controls.RemoveAt(idx);
                            cartProduct.Dispose();
                            break;
                        }
                        idx++;
                    }

					CartHandler();
                    ImportCartProductUserControl.deleteId = "";
                    ImportCartProductUserControl.deletePress = false;
                }

                if (ImportCartProductUserControl.AmountChanged)
                {
                    int idx = 0;

                    foreach (var importBillDetail in importBillDetails)
                    {
                        if (importBillDetail.MaSach == Convert.ToInt32(ImportCartProductUserControl.AmountChangedId))
                        {
                            ImportCartProductUserControl cartProduct = CartContainer.Controls[idx] as ImportCartProductUserControl;
                            importBillDetail.SoLuong = Convert.ToInt32(cartProduct.AmountTxt.Text);
                            break;
                        }
                        idx++;
                    }
                    CartHandler();
                    ImportCartProductUserControl.AmountChanged = false;
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
                if (importExcel || ManualImportToggleBtn.Checked)
                {
                    TotalLb.Visible = true;
                    TotalMoneyLb.Visible = true;
                    ProfitPercentTxb.Visible = true;
                    PercentLb.Visible = true;

                    if (CartContainer.Controls.Count > 0 && supplierID != 0 && !string.IsNullOrEmpty(ProfitPercentTxb.Text) && Convert.ToInt32(ProfitPercentTxb.Text) <= 100)
                    {
                        PrintImportBtn.Cursor = Cursors.Hand;
                        printImportBtnAllowed = true;
                        PrintImportBtn.BackColor = Color.FromArgb(45, 210, 192);
						PrintRequestBtn.Cursor = Cursors.No;
						printRequestBtnAllowed = false;
						PrintRequestBtn.BackColor = Color.Silver;
					}
                    else
                    {
                        PrintImportBtn.Cursor = Cursors.No;
                        printImportBtnAllowed = false;
					    PrintImportBtn.BackColor = Color.Silver;
						PrintRequestBtn.Cursor = Cursors.No;
						printRequestBtnAllowed = false;
						PrintRequestBtn.BackColor = Color.Silver;
					}
                }
                else
                {
					TotalLb.Visible = false;
					TotalMoneyLb.Visible = false;
					ProfitPercentTxb.Visible = false;
					PercentLb.Visible = false;

					if (CartContainer.Controls.Count > 0 && supplierID != 0)
                    {
						PrintRequestBtn.Cursor = Cursors.Hand;
						printRequestBtnAllowed = true;
						PrintRequestBtn.BackColor = Color.FromArgb(45, 210, 192);
						PrintImportBtn.Cursor = Cursors.No;
						printImportBtnAllowed = false;
						PrintImportBtn.BackColor = Color.Silver;
					}
					else
					{
						PrintRequestBtn.Cursor = Cursors.No;
						printRequestBtnAllowed = false;
						PrintRequestBtn.BackColor = Color.Silver;
						PrintImportBtn.Cursor = Cursors.No;
						printImportBtnAllowed = false;
						PrintImportBtn.BackColor = Color.Silver;
					}
				}
			}
            catch (Exception ex) { Console.WriteLine(ex); }
        }
		private void ProductSearchInp_MouseLeave(object sender, EventArgs e)
		{
			panel1.Focus();
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

                foreach (DataRow row in dt.Rows)
                {
                    if (!int.TryParse(row[0].ToString(), out int maSach) || !int.TryParse(row[2].ToString(), out int soLuong) || !decimal.TryParse(row[3].ToString(), out decimal giaNhap))
                    {
                        MessageBox.Show("Lỗi chưa chọn file hoặc file excel không đúng format dữ liệu nhập!");
                        return;
                    }
                }

				CartContainer.Controls.Clear();
				importBillDetails.Clear();
                ManualImportToggleBtn.Checked = false;
                importExcel = true;
				foreach (DataRow row in dt.Rows)
				{
					BookDTO book = BookBUS.Instance.getById(row[0].ToString());
					if (book != null)
					{
						AddProductToCart(book, Convert.ToDecimal(row[3].ToString()), Convert.ToInt32(row[2].ToString()), true);
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

		private void ProfitPercentTxb_MouseLeave(object sender, EventArgs e)
		{
            panel1.Focus();
            if (ProfitPercentTxb.Text.Length > 6)
            {
                ProfitPercentTxb.Text = "100";
			}
            if (!string.IsNullOrEmpty(ProfitPercentTxb.Text))
            {
                ErrorLb.Visible = Convert.ToInt32(ProfitPercentTxb.Text) > 100;
            }
            CartHandler();
        }

		private void ProfitPercentTxb_KeyPress(object sender, KeyPressEventArgs e)
		{
			try
			{
				if (e.KeyChar == '\r')
				{
					panel1.Focus();
					return;
				}

				if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
				{
					e.Handled = true; // Cancel the key press event
				}
			}
			catch (Exception ex) { Console.WriteLine(ex); }
		}

		private void CreateBookBtn_Click(object sender, EventArgs e)
		{
            using (BookModal bookM = new BookModal())
            {
                bookM.ShowDialog();

				if (bookM.isSubmitSuccess)
				{
                    RenderBookContainer();
				}
			}
		}

        private void refresh()
        {
			CartContainer.Controls.Clear();
			importBillDetails.Clear();
			TotalLb.Visible = false;
			TotalMoneyLb.Visible = false;
			ProfitPercentTxb.Visible = false;
			PercentLb.Visible = false;
			PrintImportBtn.Cursor = Cursors.No;
			printImportBtnAllowed = false;
			PrintImportBtn.BackColor = Color.Silver;
			PrintRequestBtn.Cursor = Cursors.No;
			printRequestBtnAllowed = false;
			PrintRequestBtn.BackColor = Color.Silver;
            ManualImportToggleBtn.Checked = false;
			SupplierNameLb.Text = "";
			ProfitPercentTxb.Text = "";
			supplierID = 0;
			importExcel = false;
			importBillId = Convert.ToInt32(ImportBillBUS.Instance.getLatestId());
			CartHandler();
			RenderBookContainer();
			label1.Focus();
		}

		private void refreshBtn_Click(object sender, EventArgs e)
		{
            refresh();
		}

		private void PrintImportBtn_Click(object sender, EventArgs e)
		{
			try
			{
				if (printImportBtnAllowed)
				{
                    ImportBillDTO importBill = new ImportBillDTO();
                    importBill.TongTien = total;
                    importBill.MaNhanVien = staffID;
                    importBill.MaNhaCungCap = supplierID;
                    importBill.NgayLap = DateTime.Now;
                    importBill.PhanTramLoiNhuan = Convert.ToInt32(ProfitPercentTxb.Text);

                    ImportBillDTO newImportBill = ImportBillBUS.Instance.insertReturnBill(importBill);

                    if (newImportBill == null)
                    {
                        MessageBox.Show("Thất bại");
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
                            ImportBillBUS.Instance.createImportBillDetail(newImportBillDetail, importBill.PhanTramLoiNhuan);
                        }

                        MessageBox.Show("Thành công");
                    }

                    using (ImportBillPrintForm importBillPrintForm = new ImportBillPrintForm(newImportBill.MaDonNhapHang))
                    {
                        importBillPrintForm.ShowDialog();
                    }

                    refresh();
				}
				else
				{
					panel1.Focus();
				}
			}
			catch (Exception ex) { Console.WriteLine(ex); }
		}

		private void PrintRequestBtn_Click(object sender, EventArgs e)
		{
			try
			{
				if (printRequestBtnAllowed)
				{
					//ImportBillDTO importBill = new ImportBillDTO();
					//importBill.TongTien = total;
					//importBill.MaNhanVien = staffID;
					//importBill.MaNhaCungCap = supplierID;
					//importBill.NgayLap = DateTime.Now;
					//importBill.PhanTramLoiNhuan = Convert.ToInt32(ProfitPercentTxb.Text);

					//ImportBillDTO newImportBill = ImportBillBUS.Instance.insertReturnBill(importBill);

					//if (newImportBill == null)
					//{
					//	MessageBox.Show("Thất bại");
					//}
					//else
					//{
					//	foreach (var importBillDetail in importBillDetails)
					//	{
					//		ImportBillDetailDTO newImportBillDetail = new ImportBillDetailDTO(
					//			newImportBill.MaDonNhapHang,
					//			importBillDetail.MaSach,
					//			importBillDetail.SoLuong,
					//			importBillDetail.DonGia
					//		);
					//		ImportBillBUS.Instance.createImportBillDetail(newImportBillDetail, importBill.PhanTramLoiNhuan);
					//	}

					//	MessageBox.Show("Thành công");
					//}

					//using (ImportBillPrintForm importBillPrintForm = new ImportBillPrintForm(newImportBill.MaDonNhapHang))
					//{
					//	importBillPrintForm.ShowDialog();
					//}

					refresh();
				}
                else
                {
                    panel1.Focus();
				}
			}
			catch (Exception ex) { Console.WriteLine(ex); }
		}
	}
}
