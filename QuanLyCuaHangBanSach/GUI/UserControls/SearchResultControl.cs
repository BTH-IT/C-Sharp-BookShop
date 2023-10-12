using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.GUI.Vendor
{
    public partial class SearchResultControl : UserControl
    {
        int temp_id;
        public static int id;
        public SearchResultControl()
        {
            InitializeComponent();
        }

        public void details_Vendor(CustomerDTO customer)
        {
            NameLb.Text = customer.Ten;
            PhoneLb.Text = customer.SoDienThoai;
            temp_id = customer.Ma;
        }
        public void details_Import(SupplierDTO supplier)
        {
            NameLb.Text = supplier.TenNhaCungCap;
            PhoneLb.Text = supplier.SoDienThoai;
            temp_id = supplier.MaNhaCungCap;
        }

        private void PhoneSearchResultControl_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Gainsboro;
        }
        private void PhoneSearchResultControl_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
        }

        public static bool clicked = false;

        private void PhoneSearchResultControl_Click(object sender, EventArgs e)
        {
            clicked = true;
            id = temp_id;
        }

    }
}
