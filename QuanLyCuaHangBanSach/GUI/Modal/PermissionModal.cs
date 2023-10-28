﻿using System;
using System.Drawing;
using System.Windows.Forms;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.GUI.Modal
{
    public partial class PermissionModal : Form
    {
        public PermissionDTO updatePermission = null;
        public bool isSubmitSuccess = false;

        public PermissionModal(string title = "Thêm quyền hạng")
        {
            InitializeComponent();

            this.label1.Text = title;

            this.Text = title;
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void permissionNameTxt_TextChanged(object sender, EventArgs e)
        {
            this.permissionNameTxt.ForeColor = Color.Black;

            if (this.permissionNameTxt.Text.Length > 0)
            {
                CustomValidation.Instance.checkTextbox(
                    this.permissionNameTxt,
                    this.errorPermissionNameMsg,
                    this.nameLine,
                    new string[] { "required" }
                );
            }
        }
        private bool validateForm()
        {
            bool isCheckTxt1 = CustomValidation.Instance.checkTextbox(
                this.permissionNameTxt,
                this.errorPermissionNameMsg,
                this.nameLine,
                new string[] { "required" }
            );

            return isCheckTxt1;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                bool isValid = this.validateForm();

                if (!isValid) return;

                string permissionName = this.permissionNameTxt.Text;
                bool isActive = this.statusSwitch.Checked;

                int id = updatePermission != null ? updatePermission.MaQuyenHan : 0;

                PermissionDTO permission = new PermissionDTO(id, permissionName, isActive);

                bool isSuccess = updatePermission != null ? PermissionBUS.Instance.update(permission) : PermissionBUS.Instance.insert(permission);


                if (isSuccess)
                {
                    this.isSubmitSuccess = isSuccess;
                    MessageBox.Show(updatePermission != null ? "Update Success" : "Insert Success");
                    this.Close();
                    return;
                }

                this.isSubmitSuccess = isSuccess;

                MessageBox.Show(updatePermission != null ? "Update Failure" : "Insert Failure");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
		private void PermissionModal_Load(object sender, EventArgs e)
        {
            try
            {
                this.Location = new Point(
                        (Screen.PrimaryScreen.Bounds.Size.Width / 2) - (this.Size.Width / 2),
                        (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (this.Size.Height / 2)
                    );

                if (updatePermission != null)
                {
                    this.permissionNameTxt.Text = updatePermission.TenQuyenHan;
                    this.statusSwitch.Checked = updatePermission.TrangThai;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

		private void statusSwitch_CheckedChanged_1(object sender, EventArgs e)
		{
			if (this.statusSwitch.Checked)
			{
				this.statusSwitch.CheckedState.FillColor = Color.FromArgb(45, 210, 192);
			}
		}
	}
}
