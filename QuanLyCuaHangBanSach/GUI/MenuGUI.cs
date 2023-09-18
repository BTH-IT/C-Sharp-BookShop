using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.GUI
{
    public partial class MenuGUI : Form
    {
        private StaffDTO staff;

        public MenuGUI(int maNhanVien)
        {
            InitializeComponent();

            this.staff = StaffBUS.Instance.getById(maNhanVien.ToString());
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            List<AuthDetailDTO> authDetails = AuthDetailBUS.Instance.getByPositionId(this.staff.MaChucVu.ToString());

            foreach (AuthDetailDTO authDetail in authDetails)
            {
                if (authDetail.MaQuyenHang == 7)
                {
                    this.sell.Visible = authDetail.TrangThai;

                    if (this.sell.Visible)
                    {
                        this.Size = new System.Drawing.Size(this.Size.Width, this.Size.Height + 175);
                    }
                } else if (authDetail.MaQuyenHang == 8)
                {
                    this.import.Visible = authDetail.TrangThai;

                    if (this.import.Visible)
                    {
                        this.Size = new System.Drawing.Size(this.Size.Width, this.Size.Height + 175);
                    }
                } else if (authDetail.TrangThai && !this.manage.Visible)
                {
                    this.manage.Visible = true;
                    if (this.manage.Visible)
                    {
                        this.Size = new System.Drawing.Size(this.Size.Width, this.Size.Height + 175);
                    }
                }
            }

            this.Left += SystemInformation.VirtualScreen.Width / 2 - this.Width / 2;
            this.Top += SystemInformation.VirtualScreen.Height / 2 - this.Height / 2;
        }

        private void sell_Click(object sender, EventArgs e)
        {

        }

        private void manage_Click(object sender, EventArgs e)
        {

        }

        private void import_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
