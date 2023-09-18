using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.GUI.Modal
{
    public partial class PaymentBillModal : Form
    {
        public bool isSubmitSuccess = false;
        public bool isTouchImportBillCbx = false;
        private int staffId;

        public PaymentBillModal(int staffId)
        {
            InitializeComponent();

            this.staffId = staffId;
        }

        private void loadImportBillCbx()
        {
            List<ImportBillDTO> importBillList = ImportBillBUS.Instance.getAllData();

            importBillList.Insert(0, new ImportBillDTO());

            this.importBillCbx.ValueMember = "MaDonNhapHang";
            this.importBillCbx.DisplayMember = "MaDonNhapHang";
            this.importBillCbx.DataSource = importBillList;

            this.importBillCbx.SelectedIndex = 0;
        }

        private void ImportBillBillModal_Load(object sender, EventArgs e)
        {
            this.loadImportBillCbx();

            this.importBillCbx.SelectedValue = 0;
        }

        private bool validate()
        {
            bool isCheckCbx1 = CustomValidation.Instance.checkCombobox(
                this.importBillCbx,
                this.errorImportBillMsg,
                new string[] { "required" }
            );

            bool isCheck1 = CustomValidation.Instance.checkTextbox(
                this.reasonTxt,
                this.errorReasonMsg,
                this.reasonLine,
                new string[] { "required" }
            );

            bool isCheck2 = CustomValidation.Instance.checkTextbox(
                this.totalPriceTxt,
                this.errorPriceTotalMsg,
                this.priceTotalLine,
                new string[] { "required" }
            );

            return isCheckCbx1 && isCheck1 && isCheck2;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            bool isValid = this.validate();

            if (!isValid) return;

            PaymentBillDTO paymentBill = new PaymentBillDTO(
                0,
                Convert.ToDouble(this.totalPriceTxt.Text),
                true,
                this.reasonTxt.Text,
                staffId,
                this.noteTxt.Text,
                DateTime.Now,
                Convert.ToInt32(this.importBillCbx.SelectedValue)
            );

            bool isSuccess = PaymentBillBUS.Instance.insert(paymentBill);

            if (!isSuccess)
            {

                MessageBox.Show("Failure");
                this.isSubmitSuccess = false;
            }
            else
            {
                MessageBox.Show("Success");

                this.isSubmitSuccess = true;
                this.Close();
            }

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reasonTxt_TextChanged(object sender, EventArgs e)
        {
            CustomValidation.Instance.checkTextbox(
                this.reasonTxt,
                this.errorReasonMsg,
                this.reasonLine,
                new string[] { "required" }
            );
        }

        private void totalPriceTxt_TextChanged(object sender, EventArgs e)
        {
            CustomValidation.Instance.checkTextbox(
                this.totalPriceTxt,
                this.errorPriceTotalMsg,
                this.priceTotalLine,
                new string[] { "required" }
            );
        }

        private void importBillCbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
