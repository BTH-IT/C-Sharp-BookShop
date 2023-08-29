﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCuaHangBanSach.GUI.Manager;
using QuanLyCuaHangBanSach.GUI.Modal;

namespace QuanLyCuaHangBanSach.GUI
{
    public partial class ManagerGUI : Form
    {
        private string contentActive = "homeBtn";
        private HomeManageGUI homeFrm = new HomeManageGUI() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle=FormBorderStyle.None, };
        private BookManageGUI bookFrm = new BookManageGUI() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle=FormBorderStyle.None, };
        private test authorFrm = new test() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle=FormBorderStyle.None, };
        private test bookTypeFrm = new test() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle=FormBorderStyle.None, };
        private test customerFrm = new test() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle=FormBorderStyle.None, };
        private test staffFrm = new test() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle=FormBorderStyle.None, };
        private test supplierFrm = new test() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle=FormBorderStyle.None, };
        private test importBillFrm = new test() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle=FormBorderStyle.None, };
        private test billFrm = new test() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle=FormBorderStyle.None, };
        private test seoFrm = new test() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle=FormBorderStyle.None, };
        private test publisherFrm = new test() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle=FormBorderStyle.None, };
        private test accountFrm = new test() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle=FormBorderStyle.None, };
        public ManagerGUI()
        {
            InitializeComponent();
            this.manageContent.Controls.Add(this.homeFrm);
            this.manageContent.Controls.Add(this.bookFrm);
            this.manageContent.Controls.Add(this.authorFrm);
            this.manageContent.Controls.Add(this.bookTypeFrm);
            this.manageContent.Controls.Add(this.customerFrm);
            this.manageContent.Controls.Add(this.staffFrm);
            this.manageContent.Controls.Add(this.supplierFrm);
            this.manageContent.Controls.Add(this.importBillFrm);
            this.manageContent.Controls.Add(this.billFrm);
            this.manageContent.Controls.Add(this.seoFrm);
            this.manageContent.Controls.Add(this.publisherFrm);
            this.manageContent.Controls.Add(this.accountFrm);
            this.homeFrm.Show();                                
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

                this.homeFrm.Show();

                this.bookFrm.Hide();
                this.authorFrm.Hide();
                this.bookTypeFrm.Hide();
                this.customerFrm.Hide();
                this.staffFrm.Hide();
                this.supplierFrm.Hide();
                this.importBillFrm.Hide();
                this.billFrm.Hide();
                this.seoFrm.Hide();
                this.publisherFrm.Hide();
                this.accountFrm.Hide();
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

                this.bookFrm.Show();

                this.homeFrm.Hide();
                this.authorFrm.Hide();
                this.bookTypeFrm.Hide();
                this.customerFrm.Hide();
                this.staffFrm.Hide();
                this.supplierFrm.Hide();
                this.importBillFrm.Hide();
                this.billFrm.Hide();
                this.seoFrm.Hide();
                this.publisherFrm.Hide();
                this.accountFrm.Hide();
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

                this.authorFrm.Show();

                this.bookFrm.Hide();
                this.homeFrm.Hide();
                this.bookTypeFrm.Hide();
                this.customerFrm.Hide();
                this.staffFrm.Hide();
                this.supplierFrm.Hide();
                this.importBillFrm.Hide();
                this.billFrm.Hide();
                this.seoFrm.Hide();
                this.publisherFrm.Hide();
                this.accountFrm.Hide();
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

                this.bookTypeFrm.Show();

                this.bookFrm.Hide();
                this.authorFrm.Hide();
                this.homeFrm.Hide();
                this.customerFrm.Hide();
                this.staffFrm.Hide();
                this.supplierFrm.Hide();
                this.importBillFrm.Hide();
                this.billFrm.Hide();
                this.seoFrm.Hide();
                this.publisherFrm.Hide();
                this.accountFrm.Hide();
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

                this.customerFrm.Show();

                this.bookFrm.Hide();
                this.authorFrm.Hide();
                this.bookTypeFrm.Hide();
                this.homeFrm.Hide();
                this.staffFrm.Hide();
                this.supplierFrm.Hide();
                this.importBillFrm.Hide();
                this.billFrm.Hide();
                this.seoFrm.Hide();
                this.publisherFrm.Hide();
                this.accountFrm.Hide();
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

                this.staffFrm.Show();

                this.bookFrm.Hide();
                this.authorFrm.Hide();
                this.bookTypeFrm.Hide();
                this.customerFrm.Hide();
                this.homeFrm.Hide();
                this.supplierFrm.Hide();
                this.importBillFrm.Hide();
                this.billFrm.Hide();
                this.seoFrm.Hide();
                this.publisherFrm.Hide();
                this.accountFrm.Hide();
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

                this.supplierFrm.Show();

                this.bookFrm.Hide();
                this.authorFrm.Hide();
                this.bookTypeFrm.Hide();
                this.customerFrm.Hide();
                this.staffFrm.Hide();
                this.homeFrm.Hide();
                this.importBillFrm.Hide();
                this.billFrm.Hide();
                this.seoFrm.Hide();
                this.publisherFrm.Hide();
                this.accountFrm.Hide();
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

                this.importBillFrm.Show();

                this.bookFrm.Hide();
                this.authorFrm.Hide();
                this.bookTypeFrm.Hide();
                this.customerFrm.Hide();
                this.staffFrm.Hide();
                this.supplierFrm.Hide();
                this.homeFrm.Hide();
                this.billFrm.Hide();
                this.seoFrm.Hide();
                this.publisherFrm.Hide();
                this.accountFrm.Hide();
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

                this.billFrm.Show();

                this.bookFrm.Hide();
                this.authorFrm.Hide();
                this.bookTypeFrm.Hide();
                this.customerFrm.Hide();
                this.staffFrm.Hide();
                this.supplierFrm.Hide();
                this.importBillFrm.Hide();
                this.homeFrm.Hide();
                this.seoFrm.Hide();
                this.publisherFrm.Hide();
                this.accountFrm.Hide();
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

                this.seoFrm.Show();

                this.bookFrm.Hide();
                this.authorFrm.Hide();
                this.bookTypeFrm.Hide();
                this.customerFrm.Hide();
                this.staffFrm.Hide();
                this.supplierFrm.Hide();
                this.importBillFrm.Hide();
                this.billFrm.Hide();
                this.homeFrm.Hide();
                this.publisherFrm.Hide();
                this.accountFrm.Hide();
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

                this.publisherFrm.Show();

                this.bookFrm.Hide();
                this.authorFrm.Hide();
                this.bookTypeFrm.Hide();
                this.customerFrm.Hide();
                this.staffFrm.Hide();
                this.supplierFrm.Hide();
                this.importBillFrm.Hide();
                this.billFrm.Hide();
                this.seoFrm.Hide();
                this.homeFrm.Hide();
                this.accountFrm.Hide();
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

                this.accountFrm.Show();

                this.bookFrm.Hide();
                this.authorFrm.Hide();
                this.bookTypeFrm.Hide();
                this.customerFrm.Hide();
                this.staffFrm.Hide();
                this.supplierFrm.Hide();
                this.importBillFrm.Hide();
                this.billFrm.Hide();
                this.seoFrm.Hide();
                this.publisherFrm.Hide();
                this.homeFrm.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManagerGUI_Load(object sender, EventArgs e)
        {
        }
    }
}