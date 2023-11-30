using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;
using QuanLyCuaHangBanSach.GUI.Importer;

namespace QuanLyCuaHangBanSach.GUI
{
    public partial class MenuGUI : Form
    {
        public static StaffDTO staff;
        
        public bool isChecked = false;
        private List<AuthDetailDTO> authDetails;
        public MenuGUI(int maNhanVien)
        {
            InitializeComponent();
            staff = StaffBUS.Instance.getById(maNhanVien.ToString());

            authDetails = AuthDetailBUS.Instance.getByPositionId(staff.MaChucVu.ToString());

            foreach (AuthDetailDTO authDetail in authDetails)
            {
                if (authDetail.TrangThai)
                {
                    isChecked = true;
                }
            }

            if (!isChecked)
            {
                MessageBox.Show("Nhân viên đang không có quyền gì trong hệ thống!");
                LoginGUI.Instance.Show();
                return;
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(this.Size.Width, this.Size.Height + this.manage.Height+ (this.manage.Height)/2);
            foreach (AuthDetailDTO authDetail in authDetails)
            {
                if (authDetail.maQuyenHan == 6 && !this.sell.Visible)
                {
                    this.sell.Visible = authDetail.TrangThai;

                    if (!this.sell.Visible)
                    {
                        this.menuFlow.Size = new System.Drawing.Size(this.menuFlow.Size.Width - this.sell.Width, this.menuFlow.Size.Height);
                        this.menuFlow.Left = (this.panel1.Width - this.menuFlow.Width) / 2;
                    }
                }
                else if (authDetail.maQuyenHan == 7 && !this.import.Visible)
                {
                    this.import.Visible = authDetail.TrangThai;

                    if (!this.import.Visible)
                    {
                        this.menuFlow.Size = new System.Drawing.Size(this.menuFlow.Size.Width - this.import.Width, this.menuFlow.Size.Height);
                        this.menuFlow.Left = (this.panel1.Width - this.menuFlow.Width) / 2;
                    }
                }
                else if (authDetail.TrangThai && !this.manage.Visible)
                {
                    this.manage.Visible = true;
                    if (!this.manage.Visible)
                    {
                        this.menuFlow.Size = new System.Drawing.Size(this.menuFlow.Size.Width - this.manage.Width, this.menuFlow.Size.Height);
                        this.menuFlow.Left = (this.panel1.Width - this.menuFlow.Width) / 2;
                    }
                }
            }
            if (!this.manage.Visible)
            {
                    this.menuFlow.Size = new System.Drawing.Size(this.menuFlow.Size.Width - this.manage.Width, this.menuFlow.Size.Height);
                    this.menuFlow.Left = (this.panel1.Width - this.menuFlow.Width) / 2;
            }
            this.Left += SystemInformation.VirtualScreen.Width / 2 - this.Width / 2;
            this.Top += SystemInformation.VirtualScreen.Height / 2 - this.Height / 2;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginGUI.Instance.Show();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();

            ManagerGUI managerGUI = new ManagerGUI(staff.Ma);

            managerGUI.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();

            ImportGUI importGUI = new ImportGUI(staff.Ma);

            importGUI.Show();
        }

        private void sell_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            VendorGUI vendorGUI = new VendorGUI(staff.Ma);

            vendorGUI.Show();
        }

        private void MenuGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
