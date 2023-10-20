﻿using System;
using System.Linq;
using System.Windows.Forms;
using Guna.UI.WinForms;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;
using QuanLyCuaHangBanSach.GUI.Manager;
using QuanLyCuaHangBanTacGia.GUI.Manager;

namespace QuanLyCuaHangBanSach.GUI
{
    public partial class ManagerGUI : Form
    {
        public static StaffDTO currentStaff;
        public static Authorization authorization;
        private string contentActive;
        private StatisticMenuGUI statisticFrm = new StatisticMenuGUI() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle=FormBorderStyle.None, };
        private BookManageGUI bookFrm = new BookManageGUI() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle=FormBorderStyle.None, };
        private AuthorGUI authorFrm = new AuthorGUI() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle=FormBorderStyle.None, };
        private CustomerManagerGUI customerFrm = new CustomerManagerGUI() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle=FormBorderStyle.None, };
        private StaffManageGUI staffFrm = new StaffManageGUI() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle=FormBorderStyle.None, };
        private SupplierManagerGUI supplierFrm = new SupplierManagerGUI() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle=FormBorderStyle.None, };
        private ImportBillGUI importBillFrm = new ImportBillGUI() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle=FormBorderStyle.None, };
        private CustomerBillGUI customerBillFrm = new CustomerBillGUI() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle=FormBorderStyle.None, };
        private SeoManageGUI seoFrm = new SeoManageGUI() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle=FormBorderStyle.None, };
        private AccountManageGUI accountFrm = new AccountManageGUI() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle=FormBorderStyle.None, };
        private PositionManageGUI positionFrm = new PositionManageGUI() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle=FormBorderStyle.None, };
        private PermissionManageGUI permissionFrm = new PermissionManageGUI() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle=FormBorderStyle.None, };
        private BookTypeGUI bookTypeFrm = new BookTypeGUI() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle=FormBorderStyle.None, };
        private PublisherGUI publisherFrm = new PublisherGUI() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle=FormBorderStyle.None, };
        
        public ManagerGUI(int staffId)
        {
            InitializeComponent();

            currentStaff = StaffBUS.Instance.getById(staffId.ToString());

            authorization = new Authorization(staffId);

            foreach (var item in authorization.getPermissionObject())
            {
                bool isCheckPermission = authorization.checkAuthorize(Convert.ToInt32(item.Key));

                if (!isCheckPermission)
                {
                    switch (item.Key)
                    {
                        case "1":
                            this.navBar.Controls.Remove(this.bookBtn);
                            break;
                        case "2":
                            this.navBar.Controls.Remove(this.staffBtn);
                            break;
                        case "3":
                            this.navBar.Controls.Remove(this.supplierBtn);
                            break;
                        case "4":
                            this.navBar.Controls.Remove(this.bookTypeBtn);
                            break;
                        case "5":
                            this.navBar.Controls.Remove(this.publisherBtn);
                            break;
                        case "7":
                            this.navBar.Controls.Remove(this.customerBtn);
                            break;
                        case "8":
                            this.navBar.Controls.Remove(this.authorBtn);
                            break;
                        case "9":
                            this.navBar.Controls.Remove(this.seoBtn);
                            break;
                        case "10":
                            this.navBar.Controls.Remove(this.permissionBtn);
                            break;
                        case "11":
                            this.navBar.Controls.Remove(this.positionBtn);
                            break;
                        case "12":
                            this.navBar.Controls.Remove(this.billBtn);
                            break;
                        case "13":
                            this.navBar.Controls.Remove(this.importBilBtn);
                            break;
                        case "14":
                            this.navBar.Controls.Remove(this.accountBtn);
                            break;
                        case "15":
                            this.navBar.Controls.Remove(this.homeBtn);
                            break;
                    }
                } else
                {
                    switch (item.Key)
                    {
                        case "1":
                            this.manageContent.Controls.Add(this.bookFrm);
                            break;
                        case "2":
                            this.manageContent.Controls.Add(this.staffFrm);
                            break;
                        case "3":
                            this.manageContent.Controls.Add(this.supplierFrm);
                            break;
                        case "4":
                            this.manageContent.Controls.Add(this.bookTypeFrm);
                            break;
                        case "5":
                            this.manageContent.Controls.Add(this.publisherFrm);
                            break;
                        case "7":
                            this.manageContent.Controls.Add(this.customerFrm);
                            break;
                        case "8":
                            this.manageContent.Controls.Add(this.authorFrm);
                            break;
                        case "9":
                            this.manageContent.Controls.Add(this.seoFrm);
                            break;
                        case "10":
                            this.manageContent.Controls.Add(this.permissionFrm);
                            break;
                        case "11":
                            this.manageContent.Controls.Add(this.positionFrm);
                            break;
                        case "12":
                            this.manageContent.Controls.Add(this.customerBillFrm);
                            break;
                        case "13":
                            this.manageContent.Controls.Add(this.importBillFrm);
                            break;
                        case "14":
                            this.manageContent.Controls.Add(this.accountFrm);
                            break;
                        case "15":
                            this.manageContent.Controls.Add(this.statisticFrm);
                            break;
                    }
                }
            }

            GunaAdvenceButton btn = this.navBar.Controls.OfType<GunaAdvenceButton>().FirstOrDefault();
            Form frm = this.manageContent.Controls.OfType<Form>().FirstOrDefault();

            this.contentActive = btn.Name;

            btn.Checked = true;

            frm.Show();

            this.staffName.Text = currentStaff.Ten;
            this.staffPosition.Text = PositionBUS.Instance.getById(currentStaff.MaChucVu.ToString()).TenChucVu;

            if (currentStaff.GioiTinh == "Nam")
            {
                this.staffImg.Image = QuanLyCuaHangBanSach.Properties.Resources.male_circle;
            }
            else
            {
                this.staffImg.Image = QuanLyCuaHangBanSach.Properties.Resources.female;
            }
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            if (!contentActive.Equals("homeBtn")) {
                this.contentActive = "homeBtn";

                this.homeBtn.Checked = true;

                this.bookBtn.Checked = false;
                this.authorBtn.Checked = false;
                this.bookTypeBtn.Checked = false;
                this.customerBtn.Checked = false;
                this.staffBtn.Checked = false;
                this.supplierBtn.Checked = false;
                this.importBilBtn.Checked = false;
                this.billBtn.Checked = false;
                this.seoBtn.Checked = false;
                this.publisherBtn.Checked = false;
                this.accountBtn.Checked = false;
                this.positionBtn.Checked = false;
                this.permissionBtn.Checked = false;

                this.statisticFrm.Show();

                this.bookFrm.Hide();
                this.authorFrm.Hide();
                this.bookTypeFrm.Hide();
                this.customerFrm.Hide();
                this.staffFrm.Hide();
                this.supplierFrm.Hide();
                this.importBillFrm.Hide();
                this.customerBillFrm.Hide();
                this.seoFrm.Hide();
                this.publisherFrm.Hide();
                this.accountFrm.Hide();
                this.positionFrm.Hide();
                this.permissionFrm.Hide();
            }
        }

        private void bookBtn_Click(object sender, EventArgs e)
        {
            if (!contentActive.Equals("bookBtn"))
            {
                this.contentActive = "bookBtn";

                this.bookBtn.Checked = true;

                this.homeBtn.Checked = false;
                this.authorBtn.Checked = false;
                this.bookTypeBtn.Checked = false;
                this.customerBtn.Checked = false;
                this.staffBtn.Checked = false;
                this.supplierBtn.Checked = false;
                this.importBilBtn.Checked = false;
                this.billBtn.Checked = false;
                this.seoBtn.Checked = false;
                this.publisherBtn.Checked = false;
                this.accountBtn.Checked = false;
                this.positionBtn.Checked = false;
                this.permissionBtn.Checked = false;
                
                this.bookFrm.Show();

                this.statisticFrm.Hide();
                this.authorFrm.Hide();
                this.bookTypeFrm.Hide();
                this.customerFrm.Hide();
                this.staffFrm.Hide();
                this.supplierFrm.Hide();
                this.importBillFrm.Hide();
                this.customerBillFrm.Hide();
                this.seoFrm.Hide();
                this.publisherFrm.Hide();
                this.accountFrm.Hide();
                this.positionFrm.Hide();
                this.permissionFrm.Hide();
            }
        }

        private void authorBtn_Click(object sender, EventArgs e)
        {
            if (!contentActive.Equals("authorBtn"))
            {
                this.contentActive = "authorBtn";

                this.authorBtn.Checked = true;

                this.homeBtn.Checked = false;
                this.bookBtn.Checked = false;
                this.bookTypeBtn.Checked = false;
                this.customerBtn.Checked = false;
                this.staffBtn.Checked = false;
                this.supplierBtn.Checked = false;
                this.importBilBtn.Checked = false;
                this.billBtn.Checked = false;
                this.seoBtn.Checked = false;
                this.publisherBtn.Checked = false;
                this.accountBtn.Checked = false;
                this.positionBtn.Checked = false;
                this.permissionBtn.Checked = false;
                
                this.authorFrm.Show();

                this.bookFrm.Hide();
                this.statisticFrm.Hide();
                this.bookTypeFrm.Hide();
                this.customerFrm.Hide();
                this.staffFrm.Hide();
                this.supplierFrm.Hide();
                this.importBillFrm.Hide();
                this.customerBillFrm.Hide();
                this.seoFrm.Hide();
                this.publisherFrm.Hide();
                this.accountFrm.Hide();
                this.positionFrm.Hide();
                this.permissionFrm.Hide();
            }
        }

        private void bookTypeBtn_Click(object sender, EventArgs e)
        {
            if (!contentActive.Equals("bookTypeBtn"))
            {
                this.contentActive = "bookTypeBtn";

                this.bookTypeBtn.Checked = true;

                this.homeBtn.Checked = false;
                this.bookBtn.Checked = false;
                this.authorBtn.Checked = false;
                this.customerBtn.Checked = false;
                this.staffBtn.Checked = false;
                this.supplierBtn.Checked = false;
                this.importBilBtn.Checked = false;
                this.billBtn.Checked = false;
                this.seoBtn.Checked = false;
                this.publisherBtn.Checked = false;
                this.accountBtn.Checked = false;
                this.positionBtn.Checked = false;
                this.permissionBtn.Checked = false;

                this.bookTypeFrm.Show();

                this.bookFrm.Hide();
                this.authorFrm.Hide();
                this.statisticFrm.Hide();
                this.customerFrm.Hide();
                this.staffFrm.Hide();
                this.supplierFrm.Hide();
                this.importBillFrm.Hide();
                this.customerBillFrm.Hide();
                this.seoFrm.Hide();
                this.publisherFrm.Hide();
                this.accountFrm.Hide();
                this.positionFrm.Hide();
                this.permissionFrm.Hide();
            }
        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            if (!contentActive.Equals("customerBtn"))
            {
                this.contentActive = "customerBtn";

                this.customerBtn.Checked = true;

                this.homeBtn.Checked = false;
                this.bookBtn.Checked = false;
                this.authorBtn.Checked = false;
                this.bookTypeBtn.Checked = false;
                this.staffBtn.Checked = false;
                this.supplierBtn.Checked = false;
                this.importBilBtn.Checked = false;
                this.billBtn.Checked = false;
                this.seoBtn.Checked = false;
                this.publisherBtn.Checked = false;
                this.accountBtn.Checked = false;
                this.positionBtn.Checked = false;
                this.permissionBtn.Checked = false;
                
                this.customerFrm.Show();

                this.bookFrm.Hide();
                this.authorFrm.Hide();
                this.bookTypeFrm.Hide();
                this.statisticFrm.Hide();
                this.staffFrm.Hide();
                this.supplierFrm.Hide();
                this.importBillFrm.Hide();
                this.customerBillFrm.Hide();
                this.seoFrm.Hide();
                this.publisherFrm.Hide();
                this.accountFrm.Hide();
                this.positionFrm.Hide();
                this.permissionFrm.Hide();
            }
        }

        private void staffBtn_Click(object sender, EventArgs e)
        {
            if (!contentActive.Equals("staffBtn"))
            {
                this.contentActive = "staffBtn";

                this.staffBtn.Checked = true;

                this.homeBtn.Checked = false;
                this.bookBtn.Checked = false;
                this.authorBtn.Checked = false;
                this.bookTypeBtn.Checked = false;
                this.customerBtn.Checked = false;
                this.supplierBtn.Checked = false;
                this.importBilBtn.Checked = false;
                this.billBtn.Checked = false;
                this.seoBtn.Checked = false;
                this.publisherBtn.Checked = false;
                this.accountBtn.Checked = false;
                this.positionBtn.Checked = false;
                this.permissionBtn.Checked = false;
                
                this.staffFrm.Show();

                this.bookFrm.Hide();
                this.authorFrm.Hide();
                this.bookTypeFrm.Hide();
                this.customerFrm.Hide();
                this.statisticFrm.Hide();
                this.supplierFrm.Hide();
                this.importBillFrm.Hide();
                this.customerBillFrm.Hide();
                this.seoFrm.Hide();
                this.publisherFrm.Hide();
                this.accountFrm.Hide();
                this.positionFrm.Hide();
                this.permissionFrm.Hide();
            }
        }

        private void supplierBtn_Click(object sender, EventArgs e)
        {
            if (!contentActive.Equals("supplierBtn"))
            {
                this.contentActive = "supplierBtn";

                this.supplierBtn.Checked = true;

                this.homeBtn.Checked = false;
                this.bookBtn.Checked = false;
                this.authorBtn.Checked = false;
                this.bookTypeBtn.Checked = false;
                this.customerBtn.Checked = false;
                this.staffBtn.Checked = false;
                this.importBilBtn.Checked = false;
                this.billBtn.Checked = false;
                this.seoBtn.Checked = false;
                this.publisherBtn.Checked = false;
                this.accountBtn.Checked = false;
                this.positionBtn.Checked = false;
                this.permissionBtn.Checked = false;
                
                this.supplierFrm.Show();

                this.bookFrm.Hide();
                this.authorFrm.Hide();
                this.bookTypeFrm.Hide();
                this.customerFrm.Hide();
                this.staffFrm.Hide();
                this.statisticFrm.Hide();
                this.importBillFrm.Hide();
                this.customerBillFrm.Hide();
                this.seoFrm.Hide();
                this.publisherFrm.Hide();
                this.accountFrm.Hide();
                this.positionFrm.Hide();
                this.permissionFrm.Hide();
            }
        }

        private void importBilBtn_Click(object sender, EventArgs e)
        {
            if (!contentActive.Equals("importBilBtn"))
            {
                this.contentActive = "importBilBtn";

                this.importBilBtn.Checked = true;

                this.homeBtn.Checked = false;
                this.bookBtn.Checked = false;
                this.authorBtn.Checked = false;
                this.bookTypeBtn.Checked = false;
                this.customerBtn.Checked = false;
                this.staffBtn.Checked = false;
                this.supplierBtn.Checked = false;
                this.billBtn.Checked = false;
                this.seoBtn.Checked = false;
                this.publisherBtn.Checked = false;
                this.accountBtn.Checked = false;
                this.positionBtn.Checked = false;
                this.permissionBtn.Checked = false;

                this.importBillFrm.Show();

                this.bookFrm.Hide();
                this.authorFrm.Hide();
                this.bookTypeFrm.Hide();
                this.customerFrm.Hide();
                this.staffFrm.Hide();
                this.supplierFrm.Hide();
                this.statisticFrm.Hide();
                this.customerBillFrm.Hide();
                this.seoFrm.Hide();
                this.publisherFrm.Hide();
                this.accountFrm.Hide();
                this.positionFrm.Hide();
                this.permissionFrm.Hide();
            }
        }

        private void billBtn_Click(object sender, EventArgs e)
        {
            if (!contentActive.Equals("billBtn"))
            {
                this.contentActive = "billBtn";

                this.billBtn.Checked = true;

                this.homeBtn.Checked = false;
                this.bookBtn.Checked = false;
                this.authorBtn.Checked = false;
                this.bookTypeBtn.Checked = false;
                this.customerBtn.Checked = false;
                this.staffBtn.Checked = false;
                this.supplierBtn.Checked = false;
                this.importBilBtn.Checked = false;
                this.seoBtn.Checked = false;
                this.publisherBtn.Checked = false;
                this.accountBtn.Checked = false;
                this.positionBtn.Checked = false;
                this.permissionBtn.Checked = false;
                
                this.customerBillFrm.Show();

                this.bookFrm.Hide();
                this.authorFrm.Hide();
                this.bookTypeFrm.Hide();
                this.customerFrm.Hide();
                this.staffFrm.Hide();
                this.supplierFrm.Hide();
                this.importBillFrm.Hide();
                this.statisticFrm.Hide();
                this.seoFrm.Hide();
                this.publisherFrm.Hide();
                this.accountFrm.Hide();
                this.positionFrm.Hide();
                this.permissionFrm.Hide();
            }
        }

        private void seoBtn_Click(object sender, EventArgs e)
        {
            if (!contentActive.Equals("seoBtn"))
            {
                this.contentActive = "seoBtn";

                this.seoBtn.Checked = true;

                this.homeBtn.Checked = false;
                this.bookBtn.Checked = false;
                this.authorBtn.Checked = false;
                this.bookTypeBtn.Checked = false;
                this.customerBtn.Checked = false;
                this.staffBtn.Checked = false;
                this.supplierBtn.Checked = false;
                this.importBilBtn.Checked = false;
                this.billBtn.Checked = false;
                this.publisherBtn.Checked = false;
                this.accountBtn.Checked = false;
                this.positionBtn.Checked = false;
                this.permissionBtn.Checked = false;

                this.seoFrm.Show();

                this.bookFrm.Hide();
                this.authorFrm.Hide();
                this.bookTypeFrm.Hide();
                this.customerFrm.Hide();
                this.staffFrm.Hide();
                this.supplierFrm.Hide();
                this.importBillFrm.Hide();
                this.customerBillFrm.Hide();
                this.statisticFrm.Hide();
                this.publisherFrm.Hide();
                this.accountFrm.Hide();
                this.positionFrm.Hide();
                this.permissionFrm.Hide();
            }
        }

        private void publisherBtn_Click(object sender, EventArgs e)
        {
            if (!contentActive.Equals("publisherBtn"))
            {
                this.contentActive = "publisherBtn";

                this.publisherBtn.Checked = true;

                this.homeBtn.Checked = false;
                this.bookBtn.Checked = false;
                this.authorBtn.Checked = false;
                this.bookTypeBtn.Checked = false;
                this.customerBtn.Checked = false;
                this.staffBtn.Checked = false;
                this.supplierBtn.Checked = false;
                this.importBilBtn.Checked = false;
                this.billBtn.Checked = false;
                this.seoBtn.Checked = false;
                this.accountBtn.Checked = false;
                this.positionBtn.Checked = false;
                this.permissionBtn.Checked = false;

                this.publisherFrm.Show();

                this.bookFrm.Hide();
                this.authorFrm.Hide();
                this.bookTypeFrm.Hide();
                this.customerFrm.Hide();
                this.staffFrm.Hide();
                this.supplierFrm.Hide();
                this.importBillFrm.Hide();
                this.customerBillFrm.Hide();
                this.seoFrm.Hide();
                this.statisticFrm.Hide();
                this.accountFrm.Hide();
                this.positionFrm.Hide();
                this.permissionFrm.Hide();
            }
        }

        private void accountBtn_Click(object sender, EventArgs e)
        {
            if (!contentActive.Equals("accountBtn"))
            {
                this.contentActive = "accountBtn";

                this.accountBtn.Checked = true;

                this.homeBtn.Checked = false;
                this.bookBtn.Checked = false;
                this.authorBtn.Checked = false;
                this.bookTypeBtn.Checked = false;
                this.customerBtn.Checked = false;
                this.staffBtn.Checked = false;
                this.supplierBtn.Checked = false;
                this.importBilBtn.Checked = false;
                this.billBtn.Checked = false;
                this.seoBtn.Checked = false;
                this.publisherBtn.Checked = false;
                this.positionBtn.Checked = false;
                this.permissionBtn.Checked = false;

                this.accountFrm.Show();

                this.bookFrm.Hide();
                this.authorFrm.Hide();
                this.bookTypeFrm.Hide();
                this.customerFrm.Hide();
                this.staffFrm.Hide();
                this.supplierFrm.Hide();
                this.importBillFrm.Hide();
                this.customerBillFrm.Hide();
                this.seoFrm.Hide();
                this.publisherFrm.Hide();
                this.statisticFrm.Hide();
                this.positionFrm.Hide();
                this.permissionFrm.Hide();
            }
        }

        private void permissionBtn_Click(object sender, EventArgs e)
        {
            if (!contentActive.Equals("permissionBtn"))
            {
                this.contentActive = "permissionBtn";

                this.permissionBtn.Checked = true;

                this.homeBtn.Checked = false;
                this.bookBtn.Checked = false;
                this.authorBtn.Checked = false;
                this.bookTypeBtn.Checked = false;
                this.customerBtn.Checked = false;
                this.staffBtn.Checked = false;
                this.supplierBtn.Checked = false;
                this.importBilBtn.Checked = false;
                this.billBtn.Checked = false;
                this.seoBtn.Checked = false;
                this.publisherBtn.Checked = false;
                this.positionBtn.Checked = false;
                this.accountBtn.Checked = false;

                this.permissionFrm.Show();

                this.bookFrm.Hide();
                this.authorFrm.Hide();
                this.bookTypeFrm.Hide();
                this.customerFrm.Hide();
                this.staffFrm.Hide();
                this.supplierFrm.Hide();
                this.importBillFrm.Hide();
                this.customerBillFrm.Hide();
                this.seoFrm.Hide();
                this.publisherFrm.Hide();
                this.statisticFrm.Hide();
                this.positionFrm.Hide();
                this.accountFrm.Hide();
            }
        }

        private void positionBtn_Click(object sender, EventArgs e)
        {
            if (!contentActive.Equals("positionBtn"))
            {
                this.contentActive = "positionBtn";

                this.positionBtn.Checked = true;

                this.homeBtn.Checked = false;
                this.bookBtn.Checked = false;
                this.authorBtn.Checked = false;
                this.bookTypeBtn.Checked = false;
                this.customerBtn.Checked = false;
                this.staffBtn.Checked = false;
                this.supplierBtn.Checked = false;
                this.importBilBtn.Checked = false;
                this.billBtn.Checked = false;
                this.seoBtn.Checked = false;
                this.publisherBtn.Checked = false;
                
                this.accountBtn.Checked = false;
                this.permissionBtn.Checked = false;

                this.positionFrm.Show();

                this.bookFrm.Hide();
                this.authorFrm.Hide();
                this.bookTypeFrm.Hide();
                this.customerFrm.Hide();
                this.staffFrm.Hide();
                this.supplierFrm.Hide();
                this.importBillFrm.Hide();
                this.customerBillFrm.Hide();
                this.seoFrm.Hide();
                this.publisherFrm.Hide();
                this.statisticFrm.Hide();
                
                this.accountFrm.Hide();
                this.permissionFrm.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoginGUI.Instance.Close();
        }

        private void ManagerGUI_Load(object sender, EventArgs e)
        {
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MenuGUI menu = new MenuGUI(currentStaff.Ma);

            menu.Show();
            this.Close();
        }
    }
}
