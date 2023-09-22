using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;
using QuanLyCuaHangBanSach.GUI.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.TextFormatting;

namespace QuanLyCuaHangBanSach.GUI.Modal
{
	public partial class ImportRefundBillModal : Form
	{	
		public bool isSubmitSucces = false;
		public ImportRefundBillDTO importRefundBill = null;
		public int maNhaCungCap;
		public ImportRefundBillModal(string title ="Thêm phiếu trả nhập hàng")
		{
			InitializeComponent();
			this.Text = title;	
		}

		private void ImportRefundBillModal_Load(object sender, EventArgs e)
		{

		   this.Location = new Point(
			   (Screen.PrimaryScreen.Bounds.Size.Width / 2) - (this.Size.Width / 2),
			   (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (this.Size.Height / 2)
		   );
			RefundBookControl.OnChangeRefundBookAmount = CaculateTotalMoney;
			RefundBookControl.OnDeleteRefundBook = DeleteRefundBook;
			if(importRefundBill != null)
			{
				this.importBillInput.Text = importRefundBill.MaDonNhapHang.ToString();
				this.importBillInput.Enabled = false;
				this.staffTxt.Text = StaffBUS.Instance.getById(importRefundBill.MaNhanVien.ToString()).Ten;
				//this.supplierNameTxt.Text= SupplierBUS.Instance.getById(importRefundBill.NhaCungCapDaTra.ToString()).TenNhaCungCap;
				this.dateTimeTo.Value = importRefundBill.NgayLap;
				this.reasonTxt.Text = importRefundBill.LiDo;
				List<ImportBillDetailDTO> importBillDetail = ImportBillBUS.Instance.getImportBillDetailList(importRefundBill.MaDonNhapHang.ToString());
				loadDataToImportBookDetail(importBillDetail);
				List<ImportRefundBillDetailDTO> importRefundBillDetail = ImportRefundBillBUS.Instance.getImportRefundBillDetailList(importRefundBill.MaPhieu.ToString());
				loadDataToBookList(importRefundBillDetail);
			}
			else
			{
				this.dateTimeTo.Value = DateTime.Now;
				// tìm cách lấy thông tin user hiện tại đăng nhập
				this.staffTxt.Text = "Lê Toàn";
				timer1.Start();
			}
			
			
		}

		private void loadDataToImportBookDetail(List<ImportBillDetailDTO> importBillDetail)
		{
			importBookContainer.Controls.Clear();
			if (importBillDetail != null)
			{
				foreach (ImportBillDetailDTO importBillDetailDTO in importBillDetail) 
				 {
					BookDTO book = BookBUS.Instance.getById(importBillDetailDTO.MaSach.ToString());
					ImportBookControl control = new ImportBookControl();
					control.details(book, importBillDetailDTO.SoLuong);
					this.importBookContainer.Controls.Add(control);
				}
			}

		}

		private  void loadDataToBookList(List<ImportRefundBillDetailDTO> list)
		{
			if (list == null) return;
			try
			{
				if (list.Count > 0)
				{

					foreach (var item in list)
					{
						BookDTO book = BookBUS.Instance.getById(item.MaSach.ToString());
						Type targetType = typeof(RefundBookControl);
						List<RefundBookControl> bookControls = refundBookContainer.Controls.OfType<RefundBookControl>()
																.Where(i => targetType.IsAssignableFrom(i.GetType()))
																.ToList();
						if (!bookControls.Any(a => a.getId() == book.MaSach))
						{
							RefundBookControl control = new RefundBookControl();
							control.details(book);
							this.refundBookContainer.Controls.Add(control);
							CaculateTotalMoney();
						};

					}
				}
				else
				{
					refundBookContainer.Controls.Clear();
				}
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);

			}

		}

		private void importBillInput_TextChanged(object sender, EventArgs e)
		{ 
			try
			{
				List<ImportBillDetailDTO> importBillDetail;
				var importBill = ImportBillBUS.Instance.getById(this.importBillInput.Text);
				if (importBill != null)
				{
					importBillDetail = ImportBillBUS.Instance.getImportBillDetailList(importBill.MaDonNhapHang.ToString());
					this.supplierNameTxt.Text = SupplierBUS.Instance.getById(importBill.MaNhaCungCap.ToString()).TenNhaCungCap;	
					this.maNhaCungCap = importBill.MaNhaCungCap;	
				}
				else
				{
					importBillDetail = new List<ImportBillDetailDTO>();
					this.supplierNameTxt.Text = "";
				}
				this.loadDataToImportBookDetail(importBillDetail);
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);

			}
		}
		private void timer1_Tick(object sender, EventArgs e)
		{
			List<ImportRefundBillDetailDTO> listRefundBillDetail = new List<ImportRefundBillDetailDTO>();
			if (this.importBookContainer.Controls.Count >0)
			{
				foreach(ImportBookControl control in importBookContainer.Controls)
				{
					if (control.check)
					{
						BookDTO book = BookBUS.Instance.getById(control.getId().ToString());
						ImportRefundBillDetailDTO importRefundBillDetail = new ImportRefundBillDetailDTO(0, book.MaSach, 1, book.GiaNhap);
						listRefundBillDetail.Add(importRefundBillDetail);
					}
				}	
			}
			loadDataToBookList(listRefundBillDetail);
		}

		private void cancelBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void submitBtn_Click(object sender, EventArgs e)
		{
			if (importRefundBill == null)
			{
				if(this.validateForm())
				{
					ImportRefundBillDTO importRefundBill = new ImportRefundBillDTO(
							0,
							Convert.ToDouble(this.totalMoney.Text),
							this.reasonTxt.Text,
							Convert.ToInt32(this.importBillInput.Text),
							this.dateTimeTo.Value,
							1
						);
					ImportRefundBillDTO newImportRefundBill = ImportRefundBillBUS.Instance.insertReturnBill(importRefundBill);
					if (newImportRefundBill == null)
					{
						MessageBox.Show("Có lỗi xảy ra");
						this.isSubmitSucces = false;
					}
					else
					{
						foreach (RefundBookControl control in this.refundBookContainer.Controls)
						{
							ImportRefundBillDetailDTO item = new ImportRefundBillDetailDTO(
										newImportRefundBill.MaPhieu,
										control.getId(),
										control.GetBookAmount(),
										control.getPrice()
								);
							ImportRefundBillBUS.Instance.createImportRefundBillDetail(item);
							
						}
						this.isSubmitSucces = true;
						this.Close();
					}

						
				}
			}
			else
			{
				this.Close();
			}
		}

		private bool validateForm()
		{
			bool isSupplier = CustomValidation.Instance.checkTextbox(
					this.supplierNameTxt,
					this.supplierNameMsg,
					this.supplierNameLine,
					new string[] {"custom-supplier-required"}
				);
			bool isReasonValid = CustomValidation.Instance.checkTextbox(
					this.reasonTxt,
					this.reasonMsg,
					this.reasonLine,
					new string[] {"required"}
				);
			bool hasRefundBookSeletected = refundBookContainer.Controls.Count > 0 ? true : false;
			if (!hasRefundBookSeletected)MessageBox.Show("Vui lòng chọn ít nhất một sản phẩm để trả");
			return isSupplier && isReasonValid && hasRefundBookSeletected;

		}
		private void CaculateTotalMoney()
		{
			if (refundBookContainer.Controls.Count > 0)
			{
				double totalMoney = 0;	
				foreach(RefundBookControl control in refundBookContainer.Controls)
				{
					BookDTO book = BookBUS.Instance.getById(control.getId().ToString());
					int sl = control.GetBookAmount();
					totalMoney += book.GiaNhap * sl;
				}
				this.totalMoney.Text = totalMoney.ToString();
			}
			else
			{
				this.totalMoney.Text = "0";
			}
		}
		private void DeleteRefundBook(string id)
		{
			ImportBookControl importControl = importBookContainer.Controls.OfType<ImportBookControl>()
				.Where(c => c.getId().ToString() == id)	
				.FirstOrDefault();
			if (importControl != null)
			{
				importControl.UncheckStatus();
			}	
			RefundBookControl bookControl = refundBookContainer.Controls.OfType<RefundBookControl>()
					.Where(c => c.getId().ToString() == id)
					.FirstOrDefault();
			refundBookContainer.Controls.Remove(bookControl);	
			refundBookContainer.Refresh();
			CaculateTotalMoney();
		}

	}
}
