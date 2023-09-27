using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Markup;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;
using QuanLyCuaHangBanSach.GUI.UserControls;

namespace QuanLyCuaHangBanSach.GUI.Modal
{
    public partial class CustomerChangeBillModal : Form
    {
        public bool isSubmitSuccess = false;
        private int staffId;

        public CustomerChangeBillModal(int staffId)
        {
            InitializeComponent();

            this.staffId = staffId;
        }

        private void loadCustomerCbx()
        {
            try
            {
                List<CustomerDTO> customerList = CustomerBUS.Instance.getAllData();

                customerList.Insert(0, new CustomerDTO(-1, "", "Chọn khách hàng", "", 0, 0));
                customerList.Insert(1, new CustomerDTO(0, "", "Không có khách hàng", "", 0, 0));

                this.customerCbx.ValueMember = "Ma";
                this.customerCbx.DisplayMember = "SoDienThoai";
                this.customerCbx.DataSource = customerList;

                this.customerCbx.SelectedIndex = 0;
            }
            catch (Exception er)
            {

                Console.WriteLine(er);
            }
        }

        private void loadBookNeedChangeCbx()
        {
            try
            {
                List<BookDTO> bookList = BookBUS.Instance.getAllData();

                bookList.Insert(0, new BookDTO(0, "Tất cả sách cần đổi", new byte[0], 0, 0, 0, 0, 0, 0));

                this.bookNeedChangeCbx.ValueMember = "MaSach";
                this.bookNeedChangeCbx.DisplayMember = "TenSach";
                this.bookNeedChangeCbx.DataSource = bookList;

                this.bookNeedChangeCbx.SelectedIndex = 0;
            }
            catch (Exception er)
            {

                Console.WriteLine(er);
            }
        }

        private void loadBookWantChangeCbx()
        {
            try
            {
                List<BookDTO> bookList = BookBUS.Instance.getAllData();

                bookList.Insert(0, new BookDTO(0, "Tất cả sách muốn đổi", new byte[0], 0, 0, 0, 0, 0, 0));

                this.bookWantChangeCbx.ValueMember = "MaSach";
                this.bookWantChangeCbx.DisplayMember = "TenSach";
                this.bookWantChangeCbx.DataSource = bookList;

                this.customerCbx.SelectedIndex = 0;
            }
            catch (Exception er)
            {

                Console.WriteLine(er);
            }
        }

        private void CustomerChangeBillModal_Load(object sender, EventArgs e)
        {
            try
            {
                this.loadCustomerCbx(); ;
                this.loadBookNeedChangeCbx();
                this.loadBookWantChangeCbx();

                this.customerCbx.SelectedValue = 0;
                this.bookNeedChangeCbx.SelectedValue = 0;
                this.customerCbx.SelectedValue = 0;
            }
            catch (Exception er)
            {

                Console.WriteLine(er);
            }
        }

        private bool validate()
        {
            bool isCheckCbx1 = CustomValidation.Instance.checkCombobox(
                this.customerCbx,
                this.errorCustomerMsg,
                new string[] { "required" }
            );

            bool isCheckCbx2 = CustomValidation.Instance.checkCombobox(
                this.bookNeedChangeCbx,
                this.errorBookNeedChangeMsg,
                new string[] { "required" }
            );

            bool isCheckCbx3 = CustomValidation.Instance.checkCombobox(
                this.bookWantChangeCbx,
                this.errorBookWantChangeCbx4Msg,
                new string[] { "required" }
            );

            bool isCheckTxt1 = CustomValidation.Instance.checkTextbox(
                    this.reasonTxt,
                    this.errorReasonMsg,
                    this.reasonLine,
                    new string[] { "required" }
            );
            bool isCheckTxt2 = CustomValidation.Instance.checkTextbox(
                    this.conditionTxt,
                    this.errorConditionMsg,
                    this.conditionLine,
                    new string[] { "required" }
            );

            return isCheckCbx1 && isCheckCbx2 && isCheckCbx3 && isCheckTxt1 && isCheckTxt2;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                bool isValid = this.validate();

                if (!isValid) return;

                CustomerChangeBillDTO customerChangeBill = new CustomerChangeBillDTO();

                customerChangeBill.MaNhanVien = this.staffId;
                customerChangeBill.MaKhachHang = Convert.ToInt32(this.customerCbx.SelectedValue);
                customerChangeBill.SachCanDoi = Convert.ToInt32(this.bookNeedChangeCbx.SelectedValue);
                customerChangeBill.SachMuonDoi = Convert.ToInt32(this.bookWantChangeCbx.SelectedValue);
                customerChangeBill.LiDo = this.reasonTxt.Text;
                customerChangeBill.TinhTrangSanPham = this.conditionTxt.Text;
                customerChangeBill.NgayLap = DateTime.Now;

                CustomerChangeBillDTO newCustomerChangeBill = CustomerChangeBillBUS.Instance.insertReturnBill(customerChangeBill);


                if (newCustomerChangeBill == null)
                {

                    MessageBox.Show("Failure");
                    this.isSubmitSuccess = false;
                }
                else
                {

                    BookBUS.Instance.deleteBookAmount(customerChangeBill.SachMuonDoi.ToString(), 1);
                    BookBUS.Instance.createBookAmount(customerChangeBill.SachCanDoi.ToString(), 1);

                    MessageBox.Show("Success");

                    this.isSubmitSuccess = true;
                    this.Close();
                }
            }
            catch (Exception er)
            {

                Console.WriteLine(er);
            }

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
