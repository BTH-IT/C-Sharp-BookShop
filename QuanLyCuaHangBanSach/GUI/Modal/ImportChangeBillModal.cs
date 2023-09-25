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

        private void loadSupplierCbx()
        {
            List<SupplierDTO> supplierList = SupplierBUS.Instance.getAllData();

            supplierList.Insert(0, new SupplierDTO(0,"Chọn nhà cung cấp","","0"));

            this.supplierCbx.ValueMember = "MaNhaCungCap";
            this.supplierCbx.DisplayMember = "SoDienThoai";
            this.supplierCbx.DataSource = supplierList;
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
            this.loadSupplierCbx(); ;
            this.loadBookNeedChangeCbx();
            this.loadBookWantChangeCbx();

            this.supplierCbx.SelectedValue = 0;
            this.bookNeedChangeCbx.SelectedValue = 0;
            this.supplierCbx.SelectedValue = 0;
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

            ImportChangeBillDTO importChangeBillBill = new ImportChangeBillDTO();

            importChangeBillBill.MaNhanVien = this.staffId;
            importChangeBillBill.MaNhaCungCap = Convert.ToInt32(this.supplierCbx.SelectedValue);
            importChangeBillBill.SachCanDoi = Convert.ToInt32(this.bookNeedChangeCbx.SelectedValue);
            importChangeBillBill.SachMuonDoi = Convert.ToInt32(this.bookWantChangeCbx.SelectedValue);
            importChangeBillBill.LiDo = this.reasonTxt.Text;
            importChangeBillBill.TinhTrangSanPham = this.conditionTxt.Text;
            importChangeBillBill.NgayLap = DateTime.Now;

            ImportChangeBillDTO newImportChangeBill = ImportChangeBillBUS.Instance.insertReturnBill(importChangeBillBill);


            if (newImportChangeBill == null)
            {

                MessageBox.Show("Failure");
                this.isSubmitSuccess = false;
            }
            else
            {

                BookBUS.Instance.deleteBookAmount(importChangeBillBill.SachCanDoi.ToString(), 1);
                BookBUS.Instance.createBookAmount(importChangeBillBill.SachMuonDoi.ToString(), 1);
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
