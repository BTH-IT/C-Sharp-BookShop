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
    public partial class ImportChangeBillModal : Form
    {
        public bool isSubmitSuccess = false;
        private int staffId;

        public ImportChangeBillModal(int staffId)
        {
            InitializeComponent();

            this.staffId = staffId;
        }

        private void loadCustomerCbx()
        {
            List<CustomerDTO> customerList = CustomerBUS.Instance.getAllData();

            customerList.Insert(0, new CustomerDTO(-1, "", "Chọn khách hàng", "", 0, 0));
            customerList.Insert(1, new CustomerDTO(0, "", "Không có khách hàng", "", 0, 0));

            this.supplierCbx.ValueMember = "Ma";
            this.supplierCbx.DisplayMember = "SoDienThoai";
            this.supplierCbx.DataSource = customerList;

            this.supplierCbx.SelectedIndex = 0;
        }

        private void loadBookNeedChangeCbx()
        {
            List<BookDTO> bookList = BookBUS.Instance.getAllData();

            bookList.Insert(0, new BookDTO(0, "Tất cả sách cần đổi", new byte[0], 0, 0, 0, 0, 0, 0));

            this.bookNeedChangeCbx.ValueMember = "MaSach";
            this.bookNeedChangeCbx.DisplayMember = "TenSach";
            this.bookNeedChangeCbx.DataSource = bookList;

            this.bookNeedChangeCbx.SelectedIndex = 0;
        }

        private void loadBookWantChangeCbx()
        {
            List<BookDTO> bookList = BookBUS.Instance.getAllData();

            bookList.Insert(0, new BookDTO(0, "Tất cả sách muốn đổi", new byte[0], 0, 0, 0, 0, 0, 0));

            this.bookWantChangeCbx.ValueMember = "MaSach";
            this.bookWantChangeCbx.DisplayMember = "TenSach";
            this.bookWantChangeCbx.DataSource = bookList;

            this.supplierCbx.SelectedIndex = 0;
        }

        private void ImportChangeBillModal_Load(object sender, EventArgs e)
        {
            this.loadCustomerCbx(); ;
            this.loadBookNeedChangeCbx();
            this.loadBookWantChangeCbx();

            this.supplierCbx.SelectedValue = 0;
            this.bookNeedChangeCbx.SelectedValue = 0;
            this.supplierCbx.SelectedValue = 0;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            /*using (AddBookToImportChangeBillModal addBookToBillModal = new AddBookToImportChangeBillModal(customerChangeBillDetailList))
            {
                addBookToBillModal.ShowDialog();


                foreach (ImportChangeBillDetailDTO customerChangeBillDetail in addBookToBillModal.selectedImportChangeBillDetailList)
                {
                    int idx = this.customerChangeBillDetailList.FindIndex(
                        book => book.MaSach == customerChangeBillDetail.MaSach
                    );

                    if (idx == -1)
                    {
                        this.customerChangeBillDetailList.Add(customerChangeBillDetail);
                        continue;
                    }

                    this.customerChangeBillDetailList[idx].SoLuong += customerChangeBillDetail.SoLuong;
                }

                this.loadImportChangeBillDetailList();
            }*/
        }

        private bool validate()
        {
            bool isCheckCbx1 = CustomValidation.Instance.checkCombobox(
                this.supplierCbx,
                this.errorSupplierMsg,
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
            bool isValid = this.validate();

            if (!isValid) return;

            ImportChangeBillDTO customerChangeBill = new ImportChangeBillDTO();

            customerChangeBill.MaNhanVien = this.staffId;
            customerChangeBill.MaNhaCungCap = Convert.ToInt32(this.supplierCbx.SelectedValue);
            customerChangeBill.SachCanDoi = Convert.ToInt32(this.bookNeedChangeCbx.SelectedValue);
            customerChangeBill.SachMuonDoi = Convert.ToInt32(this.bookWantChangeCbx.SelectedValue);
            customerChangeBill.LiDo = this.reasonTxt.Text;
            customerChangeBill.TinhTrangSanPham = this.conditionTxt.Text;
            customerChangeBill.NgayLap = DateTime.Now;

            ImportChangeBillDTO newImportChangeBill = ImportChangeBillBUS.Instance.insertReturnBill(customerChangeBill);


            if (newImportChangeBill == null)
            {

                MessageBox.Show("Failure");
                this.isSubmitSuccess = false;
            }
            else
            {

                BookBUS.Instance.deleteBookAmount(customerChangeBill.SachCanDoi.ToString(), 1);
                BookBUS.Instance.createBookAmount(customerChangeBill.SachMuonDoi.ToString(), 1);
                MessageBox.Show("Success");

                this.isSubmitSuccess = true;
                this.Close();
            }

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
