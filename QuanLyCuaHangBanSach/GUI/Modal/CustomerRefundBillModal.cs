using BookShop_CNPM.BUS;
using BookShop_CNPM.DTO;
using BookShop_CNPM.GUI.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace BookShop_CNPM.GUI.Modal
{
	public partial class CustomerRefundBillModal : Form
	{
		public bool isSubmitSuccess = false;
		public CustomerRefundBillDTO customerRefundBill = null;
		private int staffId;
        private int maKhachHang;
		public CustomerRefundBillModal(int staffId, string title = "Thêm phiếu trả bán hàng")
		{
			InitializeComponent();
			this.Text = title;
			this.staffId = staffId;
		}

		private void CustomerRefundBillModal_Load(object sender, EventArgs e)
		{
			try
			{
				this.Location = new Point(
							   (Screen.PrimaryScreen.Bounds.Size.Width / 2) - (this.Size.Width / 2),
							   (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (this.Size.Height / 2)
							);
				RefundBookControl.OnChangeRefundBookAmount = CaculateTotalMoney;
				RefundBookControl.OnDeleteRefundBook = DeleteRefundBook;
				if (customerRefundBill != null)
				{
					label4.Text = "Xem Chi Tiết Phiếu Trả Bán Hàng";
                    this.submitBtn.Visible = false;
					this.cancelBtn.Visible = false;
                    this.customerBillInput.Text = customerRefundBill.MaDonKhachHang.ToString();
					this.customerBillInput.Enabled = false;
					this.totalMoney.Text=customerRefundBill.TongTien.ToString();
					this.staffTxt.Text = StaffBUS.Instance.getById(customerRefundBill.MaNhanVien.ToString()).Ten;
					//this.supplierNameTxt.Text= SupplierBUS.Instance.getById(customerRefundBill.NhaCungCapDaTra.ToString()).TenNhaCungCap;
					this.dateTimeTo.Value = customerRefundBill.NgayLap;
					this.reasonTxt.Text = customerRefundBill.LiDo;
					this.reasonTxt.Enabled = false;
					List<CustomerBillDetailDTO> customerBillDetails = CustomerBillBUS.Instance.getCustomerBillDetailList(customerRefundBill.MaPhieu.ToString());
					loadDataToCustomerBillBookDetail(customerBillDetails);
					List<CustomerRefundBillDetailDTO> customerRefundBillDetail = CustomerRefundBillBUS.Instance.getCustomerRefundBillDetailList(customerRefundBill.MaPhieu.ToString());
					loadDataToBookDetailList(customerRefundBillDetail);
				}
				else
				{
					this.dateTimeTo.Value = DateTime.Now;
					this.staffTxt.Text = StaffBUS.Instance.getById(staffId.ToString()).Ten;
                    timer1.Start();
				}
			}
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

		private void loadDataToBookList(List<CustomerRefundBillDetailDTO> customerRefundBillDetails)
		{
			if (customerRefundBillDetails == null) return;
			try
			{
				if (customerRefundBillDetails.Count > 0)
				{

					foreach (var item in customerRefundBillDetails)
					{
						BookDTO book = BookBUS.Instance.getById(item.MaSach.ToString());
						Type targetType = typeof(RefundBookControl);
						List<RefundBookControl> bookControls = refundBookContainer.Controls.OfType<RefundBookControl>()
																.Where(i => targetType.IsAssignableFrom(i.GetType()))
																.ToList();
						if (!bookControls.Any(a => a.getId() == book.MaSach))
						{
							CustomerBillDetailDTO customerBillDetail = CustomerBillBUS.Instance.getCustomerBillDetailList(this.customerBillInput.Text).Where(c => c.MaSach == book.MaSach).FirstOrDefault();
							RefundBookControl control = new RefundBookControl();
							control.details(book,customerBillDetail.SoLuong,1);
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
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);

			}
		}

        private void loadDataToBookDetailList(List<CustomerRefundBillDetailDTO> customerRefundBillDetails)
        {
            if (customerRefundBillDetails == null) return;
            try
            {
                if (customerRefundBillDetails.Count > 0)
                {

                    foreach (var item in customerRefundBillDetails)
                    {
                        BookDTO book = BookBUS.Instance.getById(item.MaSach.ToString());
                        Type targetType = typeof(ImportBookControl);
                        List<ImportBookControl> bookControls = refundBookContainer.Controls.OfType<ImportBookControl>()
                                                                .Where(i => targetType.IsAssignableFrom(i.GetType()))
                                                                .ToList();
                        if (!bookControls.Any(a => a.getId() == book.MaSach))
                        {
                            CustomerRefundBillDetailDTO customerBillDetail = CustomerRefundBillBUS.Instance.getCustomerRefundBillDetailList(item.MaDon.ToString()).Where(c => c.MaSach == book.MaSach).FirstOrDefault();
                            ImportBookControl control = new ImportBookControl();
                            control.details(book, customerBillDetail.SoLuong, 1);
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        private void CaculateTotalMoney()
		{
			try
			{
				if (refundBookContainer.Controls.Count > 0)
				{
					double totalMoney = 0;
					foreach (RefundBookControl control in refundBookContainer.Controls)
					{
						int sl = control.GetBookAmount();
						totalMoney += control.getPrice() * sl;
					}
					this.totalMoney.Text = totalMoney.ToString();
				}
			}
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

		private void loadDataToCustomerBillBookDetail(List<CustomerBillDetailDTO> customerBillDetails)
		{
			try
			{
				customerBookContainer.Controls.Clear();
				if (customerBillDetails != null)
				{
					foreach (var customerBillDetailsDTO in customerBillDetails)
					{
						BookDTO book = BookBUS.Instance.getById(customerBillDetailsDTO.MaSach.ToString());
						ImportBookControl control = new ImportBookControl();
						control.details(book, customerBillDetailsDTO.SoLuong, 1);
						this.customerBookContainer.Controls.Add(control);
					}
				}
			}
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

		private void customerBillInput_TextChanged(object sender, EventArgs e)
		{
			try
			{
				List<CustomerBillDetailDTO> customerBillDetails;
				var customerBill = CustomerBillBUS.Instance.getById(this.customerBillInput.Text);
				if (customerBill != null)
				{
					customerBillDetails = CustomerBillBUS.Instance.getCustomerBillDetailList(customerBill.MaDonKhachHang.ToString());
					var customer = CustomerBUS.Instance.getById(customerBill.MaKhachHang.ToString());
					this.supplierNameTxt.Text = customer != null ? customer.Ten : "Vãn lai";
					this.maKhachHang = customerBill.MaDonKhachHang;
				}
				else
				{
					customerBillDetails = new List<CustomerBillDetailDTO>();
					this.supplierNameTxt.Text = "";
					this.totalMoney.Text = "0";
				}
				this.loadDataToCustomerBillBookDetail(customerBillDetails);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		private void DeleteRefundBook(string id)
		{
			try
			{
				ImportBookControl importControl = customerBookContainer.Controls.OfType<ImportBookControl>()
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

		private void timer1_Tick(object sender, EventArgs e)
		{
			try
			{
				List<CustomerRefundBillDetailDTO> listRefundBillDetail = new List<CustomerRefundBillDetailDTO>();
				if (this.customerBookContainer.Controls.Count > 0)
				{
					foreach (ImportBookControl control in customerBookContainer.Controls)
					{
						if (control.check)
						{
							BookDTO book = BookBUS.Instance.getById(control.getId().ToString());
							CustomerRefundBillDetailDTO customerRefundBillDetail = new CustomerRefundBillDetailDTO(0, book.MaSach, 1, book.GiaNhap);
							listRefundBillDetail.Add(customerRefundBillDetail);
						}
					}

				}
				loadDataToBookList(listRefundBillDetail);
			}
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

		private void cancelBtn_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private bool validateForm()
		{
			try
			{
				/*bool isCustomer = CustomValidation.Instance.checkTextbox(
								this.supplierNameTxt,
								this.supplierNameMsg,
								this.supplierNameLine,
								new string[] { "custom-supplier-required" }
							);*/
				bool isReasonValid = CustomValidation.Instance.checkTextbox(
						this.reasonTxt,
						this.reasonMsg,
						this.reasonLine,
						new string[] { "required" }
					);
				bool hasRefundBookSeletected = refundBookContainer.Controls.Count > 0 ? true : false;
				if (!hasRefundBookSeletected) MessageBox.Show("Vui lòng chọn ít nhất một sản phẩm để trả");
				return isReasonValid && hasRefundBookSeletected;
			}
			catch
			{
				return false;
			}
		}

		private void submitBtn_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.customerRefundBill == null)
				{
					if (validateForm())
					{
						CustomerRefundBillDTO importRefundBill = new CustomerRefundBillDTO(
								0,
								Convert.ToDouble(this.totalMoney.Text),
								this.reasonTxt.Text,
								Convert.ToInt32(this.customerBillInput.Text),
								this.dateTimeTo.Value,
                                 this.staffId
                            );
						CustomerRefundBillDTO newCustomerRefundBill = CustomerRefundBillBUS.Instance.insertReturnBill(importRefundBill);
						if (newCustomerRefundBill == null)
						{
							MessageBox.Show("Có lỗi xảy ra");
							this.isSubmitSuccess = false;
						}
						else
						{
							foreach (RefundBookControl control in this.refundBookContainer.Controls)
							{
								CustomerRefundBillDetailDTO item = new CustomerRefundBillDetailDTO(
											newCustomerRefundBill.MaPhieu,
											control.getId(),
											control.GetBookAmount(),
											control.getPrice()
									);
								CustomerRefundBillBUS.Instance.createCustomerRefundBillDetail(item);

							}
							this.isSubmitSuccess = true;
							this.Close();
						}
					}

				}
			}
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void reasonTxt_TextChanged(object sender, EventArgs e)
        {
            CustomValidation.Instance.checkTextbox(
                        this.reasonTxt,
                        this.reasonMsg,
                        this.reasonLine,
                        new string[] { "required" }
                    );
        }
    }
}
