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
		private string orderBillId;
		private bool importExcel = false;
		private bool importNotEnough = false;
		private bool requestExcel = false;
		private bool manualImport = false;
		private int importBillId = Convert.ToInt32(ImportBillBUS.Instance.getLatestId()) + 1;
		private int requestBillId = Convert.ToInt32(OrderBillBUS.Instance.getLatestId()) + 1;
		private decimal total = 0;
		private List<ImportBillDetailDTO> importBillDetails = new List<ImportBillDetailDTO>();
		private List<OrderBillDetailDTO> orderBillDetails = new List<OrderBillDetailDTO>();

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

				List<OrderBillDTO> orderBills = OrderBillBUS.Instance.getAllNotImported() ?? new List<OrderBillDTO>();
				orderBills.Insert(0, new OrderBillDTO(0, 0, 0, new DateTime(), 0));
				RequestIdCb.DataSource = orderBills;
				RequestIdCb.DisplayMember = "maPhieuYeuCau";
				RequestIdCb.ValueMember = "maPhieuYeuCau";

				List<AuthDetailDTO> authDetails;
				authDetails = AuthDetailBUS.Instance.getByPositionId(MenuGUI.staff.MaChucVu.ToString());
				if (authDetails != null)
				{
					// check quyen Nhà Cung Cấp
					if (!authDetails.Any(c => c.maQuyenHan == 3 && c.TrangThai))
					{
						this.AddCustomerBtn.Enabled = false;
					}
					else
					{
						this.AddCustomerBtn.Enabled = true;
					}
					// check quyen Sách
					if (!authDetails.Any(c => c.maQuyenHan == 1 && c.TrangThai))
					{
						this.CreateBookBtn.Enabled = false;
					}
					else
					{
						this.CreateBookBtn.Enabled = true;
					}
				}
				else
				{
					this.AddCustomerBtn.Enabled = false;
					this.CreateBookBtn.Enabled = false;
				}
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

		private void AddProductToCart(BookDTO book, decimal importPrice = -1, int amount = 1, int max = -1, bool disabled = false)
		{
			try
			{
				if ((importBillDetails.Count == 0 || !importBillDetails.Any(item => item.MaSach == book.MaSach)) && (orderBillDetails.Count == 0 || !orderBillDetails.Any(item => item.MaSach == book.MaSach)))
				{
					ImportCartProductUserControl product = new ImportCartProductUserControl(importExcel || manualImport ? 1 : 0, max);
					product.details(book, amount);
					product.BillIdDetailLb.Text = importExcel ? importBillId.ToString() : requestBillId.ToString();

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
                    else if (manualImport)
                    {
						product.DeleteBtn.Enabled = false;
					}

					CartContainer.Controls.Add(product);

					if (importExcel || manualImport)
					{
						ImportBillDetailDTO importBillDetail = new ImportBillDetailDTO(0, book.MaSach, amount, Convert.ToDecimal(product.ImportPriceTxb.Text));
						importBillDetails.Add(importBillDetail);
					}
					else
					{
						OrderBillDetailDTO orderBillDetail = new OrderBillDetailDTO(0, book.MaSach, amount);
						orderBillDetails.Add(orderBillDetail);
					}
				}
				else
				{
					int idx = 0;

					foreach (var orderBillDetail in orderBillDetails)
					{
						if (orderBillDetail.MaSach == book.MaSach)
						{
							orderBillDetail.SoLuong += 1;
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

		private void checkUser_Tick(object sender, EventArgs e)
		{
			try
			{
				if (BookUserControl.clicked)
				{
					if (!importExcel && !requestExcel)
					{
						int ChoseId_int = Convert.ToInt32(BookUserControl.ChoseId);
						BookDTO book = BookBUS.Instance.getById(BookUserControl.ChoseId);
						AddProductToCart(book);
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

					foreach (var orderBillDetail in orderBillDetails)
					{
						if (orderBillDetail.MaSach == Convert.ToInt32(ImportCartProductUserControl.deleteId))
						{
							orderBillDetails.RemoveAt(idx);

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
                    if (manualImport)
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
					else
					{
						int idx = 0;

						foreach (var orderBillDetail in orderBillDetails)
						{
							if (orderBillDetail.MaSach == Convert.ToInt32(ImportCartProductUserControl.AmountChangedId))
							{
								ImportCartProductUserControl cartProduct = CartContainer.Controls[idx] as ImportCartProductUserControl;
								orderBillDetail.SoLuong = Convert.ToInt32(cartProduct.AmountTxt.Text);
								break;
							}
							idx++;
						}
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
				if (importExcel || manualImport)
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

		private void ExcelBtn_Click(object sender, EventArgs e)
		{
			try
			{
				ChooseExcelModal modal = new ChooseExcelModal();
				modal.ShowDialog();

				if (modal.isImport)
				{
					DataTable dt = CustomExcel.Instance.ImportFile();

					if (dt == null)
					{
						MessageBox.Show("Lỗi chưa chọn file hoặc file excel không đúng dữ liệu!");
						return;
					}

					List<OrderBillDetailDTO> orderBillDetailList = new List<OrderBillDetailDTO>();

					int count = 1;

					//Validate loop
					foreach (DataRow row in dt.Rows)
					{
						if (count == 1)
						{
							if (!int.TryParse(row[1].ToString(), out int maPhieuYeuCau) || !int.TryParse(row[3].ToString(), out int maNhaCungCap))
							{
								MessageBox.Show("Lỗi chưa chọn file hoặc file excel không đúng format dữ liệu nhập!");
								return;
							}

							orderBillDetailList = OrderBillBUS.Instance.getOrderBillDetailList(row[1].ToString());
							if (orderBillDetailList == null)
							{
								MessageBox.Show("Thất bại, không tìm thấy phiếu yêu cầu!");
								return;
							}

							OrderBillDTO orderBill = OrderBillBUS.Instance.getById(row[1].ToString());
							if (orderBill.TrangThai != 0)
							{
								MessageBox.Show("Thất bại, phiếu yêu cầu đã được nhập hoặc bị hủy!");
								return;
							}

							if (orderBill.MaNhaCungCap != Convert.ToInt32(row[3].ToString()))
							{
								MessageBox.Show("Thất bại, nhà cung cấp không giống phiếu yêu cầu!");
								return;
							}

							count++;
							continue;
						}

						if (count == 2)
						{
							count++;
							continue;
						}

						if (!int.TryParse(row[0].ToString(), out int maSach) || !int.TryParse(row[2].ToString(), out int soLuong) || !decimal.TryParse(row[3].ToString(), out decimal giaNhap))
						{
							MessageBox.Show("Lỗi chưa chọn file hoặc file excel không đúng format dữ liệu nhập!");
							return;
						}

						BookDTO book = BookBUS.Instance.getById(row[0].ToString());
						if (book == null)
						{
							MessageBox.Show("Không hợp lệ, phiếu nhập không tương đồng với phiếu yêu cầu!");
							return;
						}
						else
						{
							int foundIdx = orderBillDetailList.FindIndex(item => item.MaSach == Convert.ToInt32(row[0].ToString()));
							if (Convert.ToInt32(row[2].ToString()) > orderBillDetailList[foundIdx].SoLuong)
							{
								MessageBox.Show($@"Không hợp lệ, sách có mã là: {Convert.ToInt32(row[0].ToString())} có số lượng lớn hơn trong phiếu yêu cầu!");
								return;
							}
							else if (Convert.ToInt32(row[2].ToString()) < orderBillDetailList[foundIdx].SoLuong)
							{
								DialogResult result = MessageBox.Show($@"sách có mã là: {Convert.ToInt32(row[0].ToString())} có số lượng bé hơn trong phiếu yêu cầu, bạn có muốn nhập tiếp không?", "Cảnh báo", MessageBoxButtons.YesNo);
								if (result == DialogResult.No)
								{
									return;
								}
								importNotEnough = true;
							}
						}
					}

					CartContainer.Controls.Clear();
					importBillDetails.Clear();
					orderBillDetails.Clear();
					NameInp.Enabled = false;
					QRScanBtn.Enabled = false;
					QRScanBtn.Cursor = Cursors.No;
					importExcel = true;
					requestExcel = false;
					count = 1;

					//Add books loop
					foreach (DataRow row in dt.Rows)
					{
						if (count == 1)
						{
							orderBillId = row[1].ToString();
							SupplierDTO supplier = SupplierBUS.Instance.getById(row[3].ToString());
							supplierID = supplier.MaNhaCungCap;
							SupplierNameLb.Text = supplier.TenNhaCungCap;
							count++;
							continue;
						}

						if (count == 2)
						{
							count++;
							continue;
						}

						BookDTO book = BookBUS.Instance.getById(row[0].ToString());
						AddProductToCart(book, Convert.ToDecimal(row[3].ToString()), Convert.ToInt32(row[2].ToString()), disabled: true);
					}
				}
				else if (modal.isRequest)
				{
					DataTable dt = CustomExcel.Instance.ImportFile();

					if (dt == null)
					{
						MessageBox.Show("Lỗi chưa chọn file hoặc file excel không đúng dữ liệu!");
						return;
					}

					int count = 1;

					//Validate loop
					foreach (DataRow row in dt.Rows)
					{
						if (count == 1)
						{
							if (!int.TryParse(row[1].ToString(), out int maNhaCungCap) || int.TryParse(row[3].ToString(), out int nullVal))
							{
								MessageBox.Show("Lỗi chưa chọn file hoặc file excel không đúng format dữ liệu nhập!");
								return;
							}

							SupplierDTO supplier = SupplierBUS.Instance.getById(row[1].ToString());
							if (supplier == null)
							{
								MessageBox.Show("Thất bại, nhà cung cấp không tồn tại!");
								return;
							}

							count++;
							continue;
						}

						if (count == 2)
						{
							count++;
							continue;
						}

						if (!int.TryParse(row[0].ToString(), out int maSach) || !int.TryParse(row[2].ToString(), out int soLuong))
						{
							MessageBox.Show("Lỗi chưa chọn file hoặc file excel không đúng format dữ liệu nhập!");
							return;
						}

						BookDTO book = BookBUS.Instance.getById(row[0].ToString());
						if (book == null)
						{
							MessageBox.Show($@"Thất bại, sách có mã là: {Convert.ToInt32(row[0].ToString())} không tồn tại trong hệ thống!");
							return;
						}
					}

					CartContainer.Controls.Clear();
					importBillDetails.Clear();
					orderBillDetails.Clear();
					NameInp.Enabled = false;
					QRScanBtn.Enabled = false;
					QRScanBtn.Cursor = Cursors.No;
					importExcel = false;
					requestExcel = true;
					count = 1;

					//Add books loop
					foreach (DataRow row in dt.Rows)
					{
						if (count == 1)
						{
							SupplierDTO supplier = SupplierBUS.Instance.getById(row[1].ToString());
							supplierID = supplier.MaNhaCungCap;
							SupplierNameLb.Text = supplier.TenNhaCungCap;
							count++;
							continue;
						}

						if (count == 2)
						{
							count++;
							continue;
						}

						BookDTO book = BookBUS.Instance.getById(row[0].ToString());
						AddProductToCart(book, amount: Convert.ToInt32(row[2].ToString()), disabled: true);
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

		private void refresh(bool noRender=false)
		{
			CartContainer.Controls.Clear();
			importBillDetails.Clear();
			orderBillDetails.Clear();
			TotalLb.Visible = false;
			TotalMoneyLb.Visible = false;
			ProfitPercentTxb.Visible = false;
			PercentLb.Visible = false;
			PrintImportBtn.Cursor = Cursors.No;
			printImportBtnAllowed = false;
			ExcelBtn.Enabled = true;
			NameInp.Enabled = true;
			QRScanBtn.Enabled = true;
			label5.Visible = false;
			RequestIdCb.Visible = false;
			QRScanBtn.Cursor = Cursors.Hand;
			PrintImportBtn.BackColor = Color.Silver;
			PrintRequestBtn.Cursor = Cursors.No;
			printRequestBtnAllowed = false;
			PrintRequestBtn.BackColor = Color.Silver;
			SupplierNameLb.Text = "";
			ProfitPercentTxb.Text = "";
			supplierID = 0;
			importExcel = false;
			importNotEnough = false;
			requestExcel = false;
			manualImport = false;
			importBillId = Convert.ToInt32(ImportBillBUS.Instance.getLatestId()) + 1;
			requestBillId = Convert.ToInt32(OrderBillBUS.Instance.getLatestId()) + 1;
			CartHandler();
            if (!noRender)
            {
				RenderBookContainer();
            }
			List<OrderBillDTO> orderBills = OrderBillBUS.Instance.getAllNotImported() ?? new List<OrderBillDTO>();
			orderBills.Insert(0, new OrderBillDTO(0, 0, 0, new DateTime(), 0));
			RequestIdCb.DataSource = orderBills;
			RequestIdCb.DisplayMember = "maPhieuYeuCau";
			RequestIdCb.ValueMember = "maPhieuYeuCau";
			label1.Focus();
		}

		private void refreshBtn_Click(object sender, EventArgs e)
		{
			ManualImportBtn.Checked = false;
			refresh(false);
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
					importBill.MaPhieuYeuCau = Convert.ToInt32(orderBillId);

					ImportBillDTO newImportBill = ImportBillBUS.Instance.insertReturnBill(importBill);

					if (newImportBill == null)
					{
						MessageBox.Show("Thất bại");
						return;
					}
					else
					{
						List<OrderBillDetailDTO> orderBillDetailList = OrderBillBUS.Instance.getOrderBillDetailList(orderBillId.ToString());
						foreach (var importBillDetail in importBillDetails)
						{
                            if (manualImport)
                            {
								int amount = orderBillDetailList.Find(item => item.MaSach == importBillDetail.MaSach).SoLuong;
                                if (importBillDetail.SoLuong < amount)
                                {
									importNotEnough = true;
                                }
                            }

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

					OrderBillBUS.Instance.updateTrangThai(orderBillId, importNotEnough ? 2 : 1);
					ManualImportBtn.Checked = false;
					refresh(false);
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
					OrderBillDTO orderBill = new OrderBillDTO();
					orderBill.MaNhanVien = staffID;
					orderBill.MaNhaCungCap = supplierID;
					orderBill.NgayLap = DateTime.Now;
					orderBill.TrangThai = 0;

					OrderBillDTO newOrderBill = OrderBillBUS.Instance.insertReturnBill(orderBill);

					if (newOrderBill == null)
					{
						MessageBox.Show("Thất bại");
						return;
					}
					else
					{
						foreach (var orderBillDetail in orderBillDetails)
						{
							OrderBillDetailDTO newOrderBillDetail = new OrderBillDetailDTO(
								newOrderBill.MaPhieuYeuCau,
								orderBillDetail.MaSach,
								orderBillDetail.SoLuong
							);
							OrderBillBUS.Instance.createOrderBillDetail(newOrderBillDetail);
						}

						MessageBox.Show("Thành công");
					}

					using (OrderBillPrintForm orderBillPrintForm = new OrderBillPrintForm(newOrderBill.MaPhieuYeuCau))
					{
						orderBillPrintForm.ShowDialog();
					}

					refresh(false);
				}
				else
				{
					panel1.Focus();
				}
			}
			catch (Exception ex) { Console.WriteLine(ex); }
		}

		private void ManualImportBtn_CheckedChanged(object sender, EventArgs e)
		{
			if (ManualImportBtn.Checked)
			{
				refresh(true);
				ExcelBtn.Enabled = false;
				manualImport = true;
				RequestIdCb.Visible = true;
				label5.Visible = true;
				RequestIdCb.SelectedIndex = 0;
			}
			else
			{
				refresh(true);
			}
		}

		private void RequestIdCb_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (RequestIdCb.SelectedIndex != 0)
			{
				CartContainer.Controls.Clear();
				importBillDetails.Clear();
				orderBillDetails.Clear();
				NameInp.Enabled = false;
				orderBillId = RequestIdCb.SelectedValue.ToString();
				supplierID = OrderBillBUS.Instance.getById(orderBillId).MaNhaCungCap;
				SupplierDTO supplier = SupplierBUS.Instance.getById(supplierID.ToString());
				SupplierNameLb.Text = supplier.TenNhaCungCap;
				List<OrderBillDetailDTO> orderBillDetailList = OrderBillBUS.Instance.getOrderBillDetailList(orderBillId.ToString());
				foreach (OrderBillDetailDTO orderBillDetail in orderBillDetailList)
				{
					BookDTO book = BookBUS.Instance.getById(orderBillDetail.MaSach.ToString());
					AddProductToCart(book, book.GiaNhap, orderBillDetail.SoLuong, orderBillDetail.SoLuong, false);
				}
			}
            else if (manualImport)
            {
				CartContainer.Controls.Clear();
				importBillDetails.Clear();
				orderBillDetails.Clear();
				NameInp.Enabled = false;
				SupplierNameLb.Text = "";
				supplierID = 0;
				CartHandler();
			}
        }
	}
}
