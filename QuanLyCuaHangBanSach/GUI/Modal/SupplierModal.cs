﻿using System;
using System.Drawing;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.GUI.Modal
{
    public partial class SupplierModal : Form
    {
        public SupplierDTO updateSupplier = null;
        public bool isSubmitSuccess = false;
        public bool isGenderCbx = false;
        public SupplierModal(string title = "Thêm nhà cung cấp")
        {
            InitializeComponent();
            this.label1.Text = title;
            this.Text = title;

            this.Suppliertxt.TextChanged += supplierNameTxt_TextChanged;
            this.addressTxt.TextChanged += addressTxt_TextChanged;
            this.phoneNumbertxt.TextChanged += phoneNumbertxt_TextChanged;
        }

        private void supplierNameTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bool isSupplier = CustomValidation.Instance.checkTextbox(
                    this.Suppliertxt,
                    this.supplierNameMsg,
                    this.nameLine,
                    new string[] { "required", "name", "space" }
                );

                if (isSupplier)
                {
                    if (updateSupplier == null)
                    {
					    CustomValidation.Instance.checkDuplicateName(
                            this.supplierNameMsg,
                            this.nameLine,
                            SupplierBUS.Instance.checkDuplicateName(this.Suppliertxt.Text)
                        );
                    }
                    else
                    {
						isSupplier = CustomValidation.Instance.checkDuplicateName(
                            this.supplierNameMsg,
                            this.nameLine,
                            SupplierBUS.Instance.checkDuplicateName(this.Suppliertxt.Text, updateSupplier.MaNhaCungCap)
                        );
                    }
                }
            }
            catch (Exception er)
            {

                Console.WriteLine(er);
            }
        }

        private bool validateForm()
        {
            try
            {
                bool isSupplier = CustomValidation.Instance.checkTextbox(
                    this.Suppliertxt,
                    this.supplierNameMsg,
                    this.nameLine,
                    new string[] { "required", "name", "space" }
                );

                if (isSupplier)
                {
                    if (updateSupplier == null)
                    {
                        isSupplier = CustomValidation.Instance.checkDuplicateName(
                            this.supplierNameMsg,
                            this.nameLine,
                            SupplierBUS.Instance.checkDuplicateName(this.Suppliertxt.Text)
                        );
                    }
                    else
                    {
                        isSupplier = CustomValidation.Instance.checkDuplicateName(
                            this.supplierNameMsg,
                            this.nameLine,
                            SupplierBUS.Instance.checkDuplicateName(this.Suppliertxt.Text, updateSupplier.MaNhaCungCap)
                        );
                    }
                }

                bool isCheckTxt2 = CustomValidation.Instance.checkTextbox(
                        this.phoneNumbertxt,
                        this.phoneNumberMsg,
                        this.phoneNumberLine,
                        new string[] { "required", "phone-number", "space" }
                );
				if (isCheckTxt2)
				{
					if (updateSupplier == null)
					{
						isCheckTxt2 = CustomValidation.Instance.checkDuplicateName(
								this.phoneNumberMsg,
								this.phoneNumberLine,
								SupplierBUS.Instance.checkDupicatePhoneNumber(this.phoneNumbertxt.Text),
								"Số điện thoại đã có trong hệ thống"
							);
					}
					else
					{
						isCheckTxt2 = CustomValidation.Instance.checkDuplicateName(
								this.phoneNumberMsg,
								this.phoneNumberLine,
								SupplierBUS.Instance.checkDupicatePhoneNumber(this.phoneNumbertxt.Text, updateSupplier.MaNhaCungCap),
								"Số điện thoại đã có trong hệ thống"

							);
					}
				}
				bool isCheckTxt3 = CustomValidation.Instance.checkTextbox(
                        this.addressTxt,
                        this.addressMsg,
                        this.addressLine,
                        new string[] { "required", "space" }
                    );



                return isSupplier && isCheckTxt2 && isCheckTxt3;
            }
            catch (Exception)
            {

                return false;
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            try
            {
                bool isValid = this.validateForm();

                if (!isValid) return;

                string SupplierName = this.Suppliertxt.Text;
                string phoneNumbertxt = this.phoneNumbertxt.Text;
                string addressTxt = this.addressTxt.Text;

                int id = updateSupplier != null ? updateSupplier.MaNhaCungCap : 0;

                SupplierDTO book = new SupplierDTO(id, SupplierName, addressTxt, phoneNumbertxt);

                bool isSuccess = updateSupplier != null ? SupplierBUS.Instance.update(book) : SupplierBUS.Instance.insert(book);


                if (isSuccess)
                {
                    this.isSubmitSuccess = isSuccess;
                    MessageBox.Show(updateSupplier != null ? "Sửa thành công" : "Thêm thành công");
                    this.Close();
                    return;
                }

                this.isSubmitSuccess = isSuccess;

                MessageBox.Show(updateSupplier != null ? "Sửa thất bại" : "Thêm thất bại");
            }
            catch (Exception er)
            {

                Console.WriteLine(er);
            }
        }

        private void SupplierModal_Load(object sender, EventArgs e)
        {
            try
            {
                this.Location = new Point(
                       (Screen.PrimaryScreen.Bounds.Size.Width / 2) - (this.Size.Width / 2),
                       (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (this.Size.Height / 2)
                   );
                if (updateSupplier != null)
                {

                    this.Suppliertxt.Text = updateSupplier.TenNhaCungCap;
                    this.addressTxt.Text = updateSupplier.DiaChi;
                    this.phoneNumbertxt.Text = updateSupplier.SoDienThoai;

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

        private void addressTxt_TextChanged(object sender, EventArgs e)
        {
            CustomValidation.Instance.checkTextbox(
                this.addressTxt,
                this.addressMsg,
                this.addressLine,
                new string[] { "required", "space" }
            );
        }

        private void phoneNumbertxt_TextChanged(object sender, EventArgs e)
        {
            bool isPhoneNumberValid =CustomValidation.Instance.checkTextbox(
                this.phoneNumbertxt,
                this.phoneNumberMsg,
                this.phoneNumberLine,
                new string[] { "required", "phone-number", "space" }
            );
            if(isPhoneNumberValid)
            {
                if(updateSupplier == null)
                {
                    isPhoneNumberValid = CustomValidation.Instance.checkDuplicateName(
                            this.phoneNumberMsg,
                            this.phoneNumberLine,
                            SupplierBUS.Instance.checkDupicatePhoneNumber(this.phoneNumbertxt.Text),
							"Số điện thoại đã có trong hệ thống"
						) ;
                }
                else
                {
                    isPhoneNumberValid = CustomValidation.Instance.checkDuplicateName(
                            this.phoneNumberMsg,
                            this.phoneNumberLine,
                            SupplierBUS.Instance.checkDupicatePhoneNumber(this.phoneNumbertxt.Text,updateSupplier.MaNhaCungCap),
                            "Số điện thoại đã có trong hệ thống"
                        );
                }
            }
        }

        private void SupplierModal_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                gunaButton1_Click(sender, e);
            }
        }
	}
}
