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
            try
            {
                bool isPosition = CustomValidation.Instance.checkTextbox(
                    this.positionNameTxt,
                    this.errorPositionNameMsg,
                    this.nameLine,
                    new string[] { "required" , "name", "space" }
                );

                if (isPosition)
                {
                    if (updatePosition == null)
                    {
                        isPosition = CustomValidation.Instance.checkDuplicateName(
                            this.errorPositionNameMsg,
                            this.nameLine,
                            PositionBUS.Instance.checkDuplicateName(this.positionNameTxt.Text)
                        );
                    }
                    else
                    {
                        isPosition = CustomValidation.Instance.checkDuplicateName(
                            this.errorPositionNameMsg,
                            this.nameLine,
                            PositionBUS.Instance.checkDuplicateName(this.positionNameTxt.Text, updatePosition.MaChucVu)
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        private bool validateForm()
        {
            bool isPosition = CustomValidation.Instance.checkTextbox(
                this.positionNameTxt,
                this.errorPositionNameMsg,
                this.nameLine,
                new string[] { "required", "name" , "space" }
            );

            if (isPosition)
            {
                if (updatePosition == null)
                {
                    isPosition = CustomValidation.Instance.checkDuplicateName(
                        this.errorPositionNameMsg,
                        this.nameLine,
                        PositionBUS.Instance.checkDuplicateName(this.positionNameTxt.Text)
                    );
                }
                else
                {
                    isPosition = CustomValidation.Instance.checkDuplicateName(
                        this.errorPositionNameMsg,
                        this.nameLine,
                        PositionBUS.Instance.checkDuplicateName(this.positionNameTxt.Text, updatePosition.MaChucVu)
                    );
                }
            }

            return isPosition;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                bool isValid = this.validateForm();

                if (!isValid) return;

                string positionName = this.positionNameTxt.Text;
                float heSoLuong = float.Parse(this.heSoLuongTxt.Value.ToString());
                string desc = this.descTxt.Text == "" ? "Không có" : this.descTxt.Text;
                bool isActive = this.activeCkx.Checked;

                int id = updatePosition != null ? updatePosition.MaChucVu : 0;

                PositionDTO position = new PositionDTO(id, positionName, desc, isActive, heSoLuong);

                bool isSuccess = updatePosition != null ? PositionBUS.Instance.update(position) : PositionBUS.Instance.insert(position);


                if (isSuccess)
                {
                    this.isSubmitSuccess = isSuccess;
                    MessageBox.Show(updatePosition != null ? "Sửa thành công" : "Tạo thành công");
                    this.Close();
                    return;
                }

                this.isSubmitSuccess = isSuccess;

                MessageBox.Show(updatePosition != null ? "Sửa thất bại" : "Tạo thất bại");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void PositionModal_Load(object sender, EventArgs e)
        {
            try
            {
                this.Location = new Point(
                        (Screen.PrimaryScreen.Bounds.Size.Width / 2) - (this.Size.Width / 2),
                        (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (this.Size.Height / 2)
                    );

                if (updatePosition != null)
                {
                    this.positionNameTxt.Text = updatePosition.TenChucVu;
                    this.descTxt.Text = updatePosition.MoTa;
                    this.heSoLuongTxt.Value = Convert.ToDecimal(updatePosition.HeSoLuong.ToString());
                    this.activeCkx.Checked = updatePosition.TrangThai;
                    this.activeCkx.Enabled = (updatePosition.MaChucVu != 1 && updatePosition.MaChucVu != 7 && updatePosition.MaChucVu !=8);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void positionNameTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                submitBtn_Click(sender, e);
            }
        }
    }
}
