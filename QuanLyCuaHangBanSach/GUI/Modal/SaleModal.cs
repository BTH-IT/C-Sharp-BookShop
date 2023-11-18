using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;
using System;
using System.Drawing;
using System.Windows.Forms;

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

            this.phanTramTxt.TextChanged += phanTramTxt_TextChanged;
            this.saleNameTxt.TextChanged += saleNameTxt_TextChanged;
            this.dateTimeFrom.TextChanged += dateTimeFrom_TextChanged;
            this.dateTimeTo.TextChanged += dateTimeTo_TextChanged;
        }

        private void SaleModal_Load(object sender, EventArgs e)
        {
            this.Location = new Point(
               (Screen.PrimaryScreen.Bounds.Size.Width / 2) - (this.Size.Width / 2),
               (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (this.Size.Height / 2)
           );
            this.dateTimeFrom.Value = DateTime.Now;
            this.dateTimeTo.Value = DateTime.Now.AddDays(1);
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
                bool isSale = CustomValidation.Instance.checkTextbox(
                    this.saleNameTxt,
                    this.errorSaleNameMsg,
                    this.saleNameLine,
                    new string[] { "required" , "space"}
                );

                if (isSale)
                {
                    if (sale == null)
                    {
                        CustomValidation.Instance.checkDuplicateName(
                            this.errorSaleNameMsg,
                            this.saleNameLine,
                            SaleBUS.Instance.checkDuplicateName(this.saleNameTxt.Text)
                        );
                    } else
                    {
                        CustomValidation.Instance.checkDuplicateName(
                            this.errorSaleNameMsg,
                            this.saleNameLine,
                            SaleBUS.Instance.checkDuplicateName(this.saleNameTxt.Text, sale.MaKhuyenMai)
                        );
                    }
                }

                bool isPhanTramValid = CustomValidation.Instance.checkTextbox(
                    this.phanTramTxt,
                    this.errorPhanTramMsg,
                    this.phanTramLine,
                    new string[] { "required", "positive-number", "space" }
                );

                if (isPhanTramValid)
                {
                    CustomValidation.Instance.checkTextboxMax(
                        this.phanTramTxt,
                        "Trường này phải bé hơn 100",
                        this.errorPhanTramMsg,
                        this.phanTramLine,
                        100
                    );
                }

                bool isDateTimeFrom = CustomValidation.Instance.checkDateTimePicker(
                    this.dateTimeFrom,
                    this.errorDateTimeFromMsg,
                    new string[] { "before" },
                    DateTime.Now,
                    "Thời gian bắt đầu phải nhỏ hơn hoặc bằng thời gian hiện tại"
                );

                bool DateFromGreaterOrEqual = CustomValidation.Instance.checkDateTimePicker(
				    this.dateTimeTo,
				    this.errorDateTimeToMsg,
				    new string[] { "after" },
				    this.dateTimeFrom.Value,
				    "Thời gian kết thúc phải lớn hơn thời gian bắt đầu"
			    );
				return isPhanTramValid && isSale && isDateTimeFrom && DateFromGreaterOrEqual;
            }
            catch
            {
                return false;
            }

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


        private void phanTramTxt_TextChanged(object sender, EventArgs e)
        {
            bool isChecked = CustomValidation.Instance.checkTextbox(
                this.phanTramTxt,
                this.errorPhanTramMsg,
                this.phanTramLine,
                new string[] { "required", "positive-number", "space" }
            );

            if (isChecked)
            {
                CustomValidation.Instance.checkTextboxMax(
                    this.phanTramTxt,
                    "Trường này phải bé hơn 100",
                    this.errorPhanTramMsg,
                    this.phanTramLine,
                    100
                );
            }
        }

        private void saleNameTxt_TextChanged(object sender, EventArgs e)
        {
            bool isSale = CustomValidation.Instance.checkTextbox(
                this.saleNameTxt,
                this.errorSaleNameMsg,
                this.saleNameLine,
                new string[] { "required" , "space" }
            );

            if (isSale)
            {
                if (sale == null)
                {
                    CustomValidation.Instance.checkDuplicateName(
                        this.errorSaleNameMsg,
                        this.saleNameLine,
                        SaleBUS.Instance.checkDuplicateName(this.saleNameTxt.Text)
                    );
                }
                else
                {
                    CustomValidation.Instance.checkDuplicateName(
                        this.errorSaleNameMsg,
                        this.saleNameLine,
                        SaleBUS.Instance.checkDuplicateName(this.saleNameTxt.Text, sale.MaKhuyenMai)
                    );
                }
            }
        }

        private void dateTimeFrom_TextChanged(object sender, EventArgs e)
        {
            CustomValidation.Instance.checkDateTimePicker(
                this.dateTimeFrom,
                this.errorDateTimeFromMsg,
                new string[] { "before" },
                DateTime.Now,
                "Thời gian bắt đầu phải nhỏ hơn hoặc bằng thời gian hiện tại"
            );
        }

        private void dateTimeTo_TextChanged(object sender, EventArgs e)
        {
            CustomValidation.Instance.checkDateTimePicker(
                this.dateTimeTo,
                this.errorDateTimeToMsg,
                new string[] { "after" },
                this.dateTimeFrom.Value,
                "Thời gian kết thúc phải lớn hơn hoặc bằng thời gian bắt đầu"
            );
        }

        private void dateTimeFrom_ValueChanged(object sender, EventArgs e)
        {
            CustomValidation.Instance.checkDateTimePicker(
                this.dateTimeFrom,
                this.errorDateTimeFromMsg,
                new string[] { "before" },
                DateTime.Now,
                "Thời gian bắt đầu phải nhỏ hơn hoặc bằng thời gian hiện tại"
            );
        }

        private void dateTimeTo_ValueChanged(object sender, EventArgs e)
        {
            CustomValidation.Instance.checkDateTimePicker(
                this.dateTimeTo,
                this.errorDateTimeToMsg,
                new string[] { "after" },
                this.dateTimeFrom.Value,
                "Thời gian kết thúc phải lớn hơn thời gian bắt đầu"
            );
        }
    }
}
