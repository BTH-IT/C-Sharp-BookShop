using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;
using QuanLyCuaHangBanSach.GUI.UserControls;

namespace QuanLyCuaHangBanSach.GUI.Modal
{
    public partial class ImportBillModal : Form
    {
        public bool isSubmitSuccess = false;
        private ImportBillDTO importBill;
        private List<ImportBillDetailDTO> importBillDetailList;

        public ImportBillModal(int importBillId)
        {
            InitializeComponent();

            this.importBill = ImportBillBUS.Instance.getById(importBillId.ToString());
            this.importBillDetailList = ImportBillBUS.Instance.getImportBillDetailList(importBillId.ToString());
        }

        private void loadSupplierCbx()
        {
            List<SupplierDTO> supplierList = SupplierBUS.Instance.getAllData();

            supplierList.Insert(0, new SupplierDTO(0, "Chọn nhà cung cấp", "", ""));

            this.supplierCbx.ValueMember = "MaNhaCungCap";
            this.supplierCbx.DisplayMember = "TenNhaCungCap";
            this.supplierCbx.DataSource = supplierList;

            this.supplierCbx.SelectedIndex = 0;
        }

        private void loadStaffCbx()
        {
            List<StaffDTO> staffList = StaffBUS.Instance.getAllData();

            staffList.Insert(0, new StaffDTO(0, "Chọn nhân viên", "", "", 0, 0, ""));

            this.staffCbx.ValueMember = "Ma";
            this.staffCbx.DisplayMember = "Ten";
            this.staffCbx.DataSource = staffList;

            this.staffCbx.SelectedIndex = 0;
        }

        private void loadImportBillDetailList()
        {
            this.bookList.Controls.Clear();

            double total = 0;

            foreach (ImportBillDetailDTO importBillDetail in importBillDetailList)
            {
                BookBill bookBill = new BookBill();

                int remain = BookBUS.Instance.getById(importBillDetail.MaSach.ToString()).SoLuongConLai;

                total += importBillDetail.SoLuong * importBillDetail.DonGia;

                bookBill.addData(importBillDetail.MaSach, importBillDetail.SoLuong, importBillDetail.DonGia);

                bookBill.close.MouseClick += (object sender, MouseEventArgs e) =>
                {
                    this.bookList.Controls.Remove(bookBill);

                    this.importBillDetailList.Remove(importBillDetail);

                    this.loadImportBillDetailList();
                };

                bookBill.plus.MouseClick += (object sender, MouseEventArgs e) =>
                {
                    bookBill.minus.Enabled = true;

                    int amount = Convert.ToInt32(bookBill.amountInput.Text.ToString());

                    bookBill.amountInput.Text = (amount + 1).ToString();

                    int idx = this.importBillDetailList.FindIndex(
                        book => book.MaSach == importBillDetail.MaSach
                    );

                    this.importBillDetailList[idx].SoLuong = amount + 1;

                    total += importBillDetail.DonGia;
                };

                bookBill.minus.MouseClick += (object sender, MouseEventArgs e) =>
                {
                    int amount = Convert.ToInt32(bookBill.amountInput.Text.ToString());

                    int idx = this.importBillDetailList.FindIndex(
                        book => book.MaSach == importBillDetail.MaSach
                    );

                    if (amount <= 2)
                    {
                        bookBill.minus.Enabled = false;
                    }
                    else
                    {
                        bookBill.minus.Enabled = true;
                    }

                    bookBill.amountInput.Text = (amount - 1).ToString();

                    this.importBillDetailList[idx].SoLuong = amount - 1;

                    total -= importBillDetail.DonGia;

                    this.totalPriceTxt.Text = total.ToString();
                };

                bookBill.amountInput.MouseLeave += (object sender, EventArgs e) =>
                {
                    try
                    {
                        this.ActiveControl = null;

                        Regex isNum = new Regex(@"^\d+$");

                        int idx = this.importBillDetailList.FindIndex(
                            book => book.MaSach == importBillDetail.MaSach
                        );

                        if (!isNum.IsMatch(bookBill.amountInput.Text))
                        {
                            bookBill.amountInput.Text = this.importBillDetailList[idx].SoLuong.ToString();
                            MessageBox.Show("Số lượng là một số");
                            return;
                        }

                        int amount = Convert.ToInt32(bookBill.amountInput.Text.ToString());

                        if (amount < 1 || amount > remain || this.importBillDetailList[idx].SoLuong == amount)
                        {
                            bookBill.amountInput.Text = this.importBillDetailList[idx].SoLuong.ToString();
                            return;
                        }

                        if (amount == 1) bookBill.minus.Enabled = false;
                        else bookBill.minus.Enabled = true;

                        if (amount == remain) bookBill.plus.Enabled = false;
                        else bookBill.minus.Enabled = true;

                        total -= this.importBillDetailList[idx].SoLuong * importBillDetail.DonGia;

                        this.importBillDetailList[idx].SoLuong = amount;

                        total += this.importBillDetailList[idx].SoLuong * importBillDetail.DonGia;

                        this.totalPriceTxt.Text = total.ToString();

                    }
                    catch
                    {
                        MessageBox.Show("Số lượng là một số");
                    }
                };

                bookBill.amountInput.KeyPress += (object sender, KeyPressEventArgs e) =>
                {
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                };

                this.bookList.Controls.Add(bookBill);
            }

            this.totalPriceTxt.Text = total.ToString();
        }

        private void ImportBillModal_Load(object sender, EventArgs e)
        {
            this.loadImportBillDetailList();
            this.loadSupplierCbx();
            this.loadStaffCbx();

            this.supplierCbx.SelectedValue = importBill.MaNhaCungCap;
            this.staffCbx.SelectedValue = importBill.MaNhanVien;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            using (AddBookToImportBillModal addBookToBillModal = new AddBookToImportBillModal(importBill))
            {
                addBookToBillModal.ShowDialog();

                foreach (ImportBillDetailDTO importBillDetail in addBookToBillModal.selectedImportBillDetailList)
                {
                    int idx = this.importBillDetailList.FindIndex(
                        book => book.MaSach == importBillDetail.MaSach
                    );

                    if (idx == -1)
                    {
                        this.importBillDetailList.Add(importBillDetail);
                        continue;
                    }

                    this.importBillDetailList[idx].SoLuong += importBillDetail.SoLuong;
                }

                this.loadImportBillDetailList();
            }
        }

        private bool validate()
        {
            bool isCheckCbx1 = CustomValidation.Instance.checkCombobox(
                this.supplierCbx,
                this.errorCustomerMsg,
                new string[] { "required" }
            );


            bool isCheckCbx2 = CustomValidation.Instance.checkCombobox(
                this.staffCbx,
                this.errorStaffMsg,
                new string[] { "required" }
            );

            return isCheckCbx1 && isCheckCbx2;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            bool isValid = this.validate();

            if (this.importBill == null || !isValid) return;

            this.importBill.TongTien = Convert.ToDouble(this.totalPriceTxt.Text);
            this.importBill.MaNhanVien = Convert.ToInt32(this.staffCbx.SelectedValue);
            this.importBill.MaNhaCungCap = Convert.ToInt32(this.supplierCbx.SelectedValue);

            if (ImportBillBUS.Instance.updateBillAndBillDetail(
                this.importBill,
                this.importBillDetailList)
            )
            {
                MessageBox.Show("Success");

                this.isSubmitSuccess = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Failure");
                this.isSubmitSuccess = false;
            }

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
