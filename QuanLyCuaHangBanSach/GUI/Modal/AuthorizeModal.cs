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
                        PermissionBUS.Instance.getById(authDetail.MaQuyenHang.ToString()).TenQuyenHang,
                        authDetail.MaChucVu,
                        authDetail.MaQuyenHang,
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
    }
}
