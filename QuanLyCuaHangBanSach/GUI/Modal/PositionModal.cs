﻿using System;
using System.Drawing;
using System.Windows.Forms;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.GUI.Modal
{
    public partial class PositionModal : Form
    {
        public PositionDTO updatePosition = null;
        public bool isSubmitSuccess = false;

        public PositionModal(string title = "Thêm chức vụ")
        {
            InitializeComponent();

            this.label1.Text = title;

            this.Text = title;
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void positionNameTxt_TextChanged(object sender, EventArgs e)
        {
            this.positionNameTxt.ForeColor = Color.Black;

            if (this.positionNameTxt.Text.Length > 0)
            {
                CustomValidation.Instance.checkTextbox(
                    this.positionNameTxt,
                    this.errorPositionNameMsg,
                    this.nameLine,
                    new string[] { "required" }
                );
            }
        }
        private bool validateForm()
        {
            bool isCheckTxt1 = CustomValidation.Instance.checkTextbox(
                this.positionNameTxt,
                this.errorPositionNameMsg,
                this.nameLine,
                new string[] { "required" }
            );

            return isCheckTxt1;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            bool isValid = this.validateForm();

            if (!isValid) return;

            string positionName = this.positionNameTxt.Text;
            string desc = this.descTxt.Text == "" ? "Không có" : this.descTxt.Text;
            bool isActive = this.activeCkx.Checked;

            int id = updatePosition != null ? updatePosition.MaChucVu : 0;

            PositionDTO position = new PositionDTO(id, positionName, desc, isActive);

            bool isSuccess = updatePosition != null ? PositionBUS.Instance.update(position) : PositionBUS.Instance.insert(position);


            if (isSuccess)
            {
                this.isSubmitSuccess = isSuccess;
                MessageBox.Show(updatePosition != null ? "Update Success" : "Insert Success");
                this.Close();
                return;
            }

            this.isSubmitSuccess = isSuccess;

            MessageBox.Show(updatePosition != null ? "Update Failure" : "Insert Failure");
        }

        private void PositionModal_Load(object sender, EventArgs e)
        {
            this.Location = new Point(
                (Screen.PrimaryScreen.Bounds.Size.Width / 2) - (this.Size.Width / 2),
                (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (this.Size.Height / 2)
            );

            if (updatePosition != null)
            {
                this.positionNameTxt.Text = updatePosition.TenChucVu;
                this.descTxt.Text = updatePosition.MoTa;
                this.activeCkx.Checked = updatePosition.TrangThai;
            }
        }
    }
}
