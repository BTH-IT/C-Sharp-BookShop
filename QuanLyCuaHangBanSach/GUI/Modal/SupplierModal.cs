﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Markup;
using Guna.UI2.WinForms.Suite;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;
using static Guna.UI2.Native.WinApi;

namespace QuanLyCuaHangBanSach.GUI.Modal
{
    public partial class SupplierModal : Form
    {
        public SupplierDTO updateSupplier = null;
        public bool isSubmitSuccess = false;
        public bool isGenderCbx = false;
        public SupplierModal(string title = "Thêm tác giả")
        {
            InitializeComponent();

            this.label1.Text = title;

            this.Text = title;
        }


        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bookNameTxt_TextChanged(object sender, EventArgs e)
        {
            this.Suppliertxt.ForeColor = Color.Black;

            if (this.Suppliertxt.Text.Length > 0)
            {
                CustomValidation.Instance.checkTextbox(
                    this.Suppliertxt,
                    this.supplierNameMsg,
                    this.nameLine,
                    new string[] { "required" }
                );
            }
        }




        private bool validateForm()
        {
            bool isCheckTxt1 = CustomValidation.Instance.checkTextbox(
                this.Suppliertxt,
                this.supplierNameMsg,
                this.nameLine,
                new string[] { "required" }
            );

            bool isCheckTxt2 = CustomValidation.Instance.checkTextbox(
                    this.phoneNumbertxt,
                    this.phoneNumberMsg,
                    this.phoneNumberLine,
                    new string[] { "required", "positive-number" }
            );

            bool isCheckTxt3 = CustomValidation.Instance.checkTextbox(
                    this.addressTxt,
                    this.addressMsg,
                    this.addressLine,
                    new string[] { "required" }
                );



            return isCheckTxt1 && isCheckTxt2 && isCheckTxt3;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
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
                MessageBox.Show(updateSupplier != null ? "Update Success" : "Insert Success");
                this.Close();
                return;
            }

            this.isSubmitSuccess = isSuccess;

            MessageBox.Show(updateSupplier != null ? "Update Failure" : "Insert Failure");
        }

        private void addressTxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Suppliertxt.ForeColor = Color.Black;

            if (this.Suppliertxt.Text.Length > 0)
            {
                CustomValidation.Instance.checkTextbox(
                    this.phoneNumbertxt,
                    this.phoneNumberMsg,
                    this.phoneNumberLine,
                    new string[] { "required", "positive-number" }
                );
            }
        }

        private void birthYear_TextChanged(object sender, EventArgs e)
        {
            this.phoneNumbertxt.ForeColor = Color.Black;

            if (this.phoneNumbertxt.Text.Length > 0)
            {
                CustomValidation.Instance.checkTextbox(
                    this.phoneNumbertxt,
                    this.phoneNumberMsg,
                    this.phoneNumberLine,
                    new string[] { "required", "positive-number" }
                );
            }
        }

        private void SupplierModal_Load(object sender, EventArgs e)
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
    }
}