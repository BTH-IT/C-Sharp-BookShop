using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Guna.UI.WinForms;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;
using QuanLyCuaHangBanSach.GUI.UserControls;

namespace QuanLyCuaHangBanSach.GUI.Modal
{
    public partial class AuthorizeModal : Form
    {
        private PositionDTO position;
        private List<AuthDetailDTO> authDetailList = new List<AuthDetailDTO>();
        public AuthorizeModal(int maChucVu)
        {
            InitializeComponent();

            this.position = PositionBUS.Instance.getById(maChucVu.ToString());
            this.title.Text = "Phân quyền cho chức vụ " + this.position.TenChucVu;
            this.authDetailList = AuthDetailBUS.Instance.getByPositionId(maChucVu.ToString());
        }

        private void AuthorizeModal_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (AuthDetailDTO authDetail in authDetailList)
                {
                    AuthorizeCkb checkBox = new AuthorizeCkb(
                        PermissionBUS.Instance.getById(authDetail.maQuyenHan.ToString()).tenQuyenHan,
                        authDetail.MaChucVu,
                        authDetail.maQuyenHan,
                        authDetail.TrangThai
                    );
                    this.authorizeList.Controls.Add(checkBox);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn với những sự thay đổi này chứ?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.None
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    foreach (Control control in this.authorizeList.Controls)
                    {
                        if (control is AuthorizeCkb)
                        {
                            AuthorizeCkb authCkb = (AuthorizeCkb)control;

                            authCkb.ckx_CheckedChanged();
                        }
                    }
                    MessageBox.Show("Phân quyền cho chức vụ thành công");
                    this.Close();
                } catch
                {
                    MessageBox.Show("Phân quyền cho chức vụ không thành công");
                }
            }
        }
    }
}
