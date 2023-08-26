using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.GUI
{
    public partial class VendorGUI : Form
    {
        public VendorGUI()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void ProductSearchInp_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ProductSearchInp.ForeColor = Color.Black;
            }
            catch
            {
            }
        }

        private void ProductSearchInp_Click(object sender, System.EventArgs e)
        {
            if (ProductSearchInp.Text.Equals("Search ..."))
            {
                ProductSearchInp.Text = "";
            }
        }

        private void ProductSearchInp_Leave(object sender, System.EventArgs e)
        {
            if (ProductSearchInp.Text.Length <= 0)
            {
                ProductSearchInp.Text = "Search ...";
                ProductSearchInp.ForeColor = Color.DarkGray;
            }
        }

        private void PhoneInp_TextChanged(object sender, EventArgs e)
        {
            try
            {
                PhoneInp.ForeColor = Color.Black;
                if (!PhoneInp.Text.Equals("Phone Number ...") && !string.IsNullOrEmpty(PhoneInp.Text)) {
                    PhoneResultData.Visible = true;
                    PhoneResultData.Rows.Clear();
                    String query = PhoneInp.Text;
                    List<CustomerDTO> customers = CustomerBUS.Instance.SearchByPhoneNum(query);
                    if (customers != null)
                    {
                        foreach (var customer in customers)
                        {
                            PhoneResultData.Rows.Add(customer.SoDienThoai, customer.TenKhachHang);
                        }
                    }
                }
            }
            catch
            {
            }
        }

        private void PhoneInp_Click(object sender, EventArgs e)
        {
            if (PhoneInp.Text.Equals("Phone Number ..."))
            {
                PhoneInp.Text = "";
            }
        }

        private void PhoneInp_Leave(object sender, EventArgs e)
        {
            if (PhoneInp.Text.Length <= 0)
            {
                PhoneInp.Text = "Phone Number ...";
                PhoneInp.ForeColor = Color.DarkGray;
            }
        }

        private void PhoneResultData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = PhoneResultData.Rows[e.RowIndex];
            string name = selectedRow.Cells["name"].Value.ToString();
            RecipientLb.Text = "Recipient: " + name;
            PhoneInp.Text = "";
            PhoneResultData.Visible = false;
        }
    }
}