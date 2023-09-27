using Guna.UI.WinForms;
using OfficeOpenXml.FormulaParsing.ExpressionGraph.FunctionCompilers;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;

namespace QuanLyCuaHangBanSach.GUI.Modal
{
    public partial class SaleModal : Form
    {
        public SaleDTO sale = null;
        public bool isSubmitSuccess;
        public SaleModal(string title = "Thêm khuyến mãi")
        {
            InitializeComponent();
            this.title.Text = title;
            this.Text = title;  
        }

        private void SaleModal_Load(object sender, EventArgs e)
        {
            this.Location = new Point(
               (Screen.PrimaryScreen.Bounds.Size.Width / 2) - (this.Size.Width / 2),
               (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (this.Size.Height / 2)
           );
            this.dateTimeFrom.Value = DateTime.Now;
            this.dateTimeTo.Value = DateTime.Now;
            try
            {
				if (sale != null)
				{
					this.saleNameTxt.Text = sale.TenKhuyenMai;
					this.phanTramTxt.Text = sale.PhanTram.ToString();
					this.dateTimeFrom.Value = sale.NgayBatDau;
					this.dateTimeTo.Value = sale.NgayKetThuc;
				}
				else
				{
					Console.WriteLine("null");
				}
			}
            catch
            {

            }
              
        }
        private bool validateSubmitForm()
        {
            try
            {
				bool isTenKhuyenMaiValid = CustomValidation.Instance.checkTextbox(
					this.saleNameTxt,
					this.errorSaleNameMsg,
					this.saleNameLine,
					new string[] { "required" }
				);
				bool isPhanTramValid = CustomValidation.Instance.checkTextbox(
						this.phanTramTxt,
						this.errorPhanTramMsg,
						this.phanTramLine,
						new string[] { "required", "positive-numbe" }
					);
				bool isDateTimeFrom = checkDateTimePicker(
				   this.dateTimeFrom,
				   this.errorDateTimeFromMsg,
				   this.dateTimeFromLine,
				   new string[] { "after" },
				   DateTime.Now
				   );
				bool DateFromGreaterOrEqual = checkDateTimePicker(
						this.dateTimeTo,
						this.errorDateTimeToMsg,
						this.dateTimeToLine,
						new string[] { "after" },
						this.dateTimeFrom.Value,
						"Thời gian kết thúc phải lớn hơn hoặc bằng thời \n gian bắt đầu"
					);
				return isPhanTramValid && isTenKhuyenMaiValid && isDateTimeFrom && DateFromGreaterOrEqual;
			}
            catch
            {
                return false;
            }
            
        }

        private bool checkDateTimePicker(GunaDateTimePicker guna , Label errorLabel, Panel errorLine, string[] requirements,DateTime dateTimeToCompare,string errorMessage = null)
        {
            try
            {
				foreach (string rule in requirements)
				{
					switch (rule)
					{
						case "after":
							if (DateTime.Compare(guna.Value, dateTimeToCompare) >= 0)
							{
								errorLabel.Text = "";
								errorLine.BackColor = Color.FromArgb(45, 212, 191);
								return true;
							}
							else
							{

								errorLabel.Text = errorMessage != null ? errorMessage : "Ngày giờ phải lớn hơn hoặc bằng thời gian hiện tại";
								errorLine.BackColor = Color.FromArgb(239, 68, 68);
								return false;
							}

						default:
							return false;
					}
				}
			}
            catch
            {

            }
        
            return false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
				if (this.validateSubmitForm())
				{
					string tenKhuyenMai = this.saleNameTxt.Text;
					byte phanTram = Convert.ToByte(this.phanTramTxt.Text.ToString());
					DateTime ngayBatDau = this.dateTimeFrom.Value;
					DateTime ngayKetThuc = this.dateTimeTo.Value;
					int maKhuyenMai = this.sale != null ? this.sale.MaKhuyenMai : 0;



					SaleDTO sale = new SaleDTO(maKhuyenMai: maKhuyenMai, tenKhuyenMai: tenKhuyenMai, phanTram: phanTram, ngayBatDau: ngayBatDau, ngayKetThuc: ngayKetThuc);

					bool isSuccess = maKhuyenMai != 0 ? SaleBUS.Instance.update(sale) : SaleBUS.Instance.insert(sale);

					if (isSuccess)
					{
						MessageBox.Show(maKhuyenMai != 0 ? "Cập nhật hoàn thành" : "Thêm mới hoàn thành");
						this.isSubmitSuccess = isSuccess;
						this.Close();
						return;
					}

				}
			}
            catch { }
         
        }
     
    }
}
