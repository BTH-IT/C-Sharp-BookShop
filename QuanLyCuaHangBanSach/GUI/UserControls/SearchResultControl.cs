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
        private bool nameHover = false;
        private bool numberHover = false;
        private bool imageHover = false;
        private bool panelHover = false;
		public static int id;
        public SearchResultControl()
        {
            InitializeComponent();
			NameLb.Click += PhoneSearchResultControl_Click;
			PhoneLb.Click += PhoneSearchResultControl_Click;
			gunaCirclePictureBox1.Click += PhoneSearchResultControl_Click;
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

        public static bool clicked = false;

        private void PhoneSearchResultControl_Click(object sender, EventArgs e)
        {
            clicked = true;
            id = temp_id;
        }

		private void PhoneSearchResultControl_MouseHover(object sender, EventArgs e)
		{
			panelHover = true;
		}
		private void PhoneSearchResultControl_MouseLeave(object sender, EventArgs e)
		{
			panelHover = false;
		}

		private void gunaCirclePictureBox1_MouseHover(object sender, EventArgs e)
		{
            imageHover = true;
		}

		private void gunaCirclePictureBox1_MouseLeave(object sender, EventArgs e)
		{
			imageHover = false;
		}

		private void NameLb_MouseHover(object sender, EventArgs e)
		{
			nameHover = true;
		}
		private void NameLb_MouseLeave(object sender, EventArgs e)
		{
			nameHover = false;
		}

		private void PhoneLb_MouseHover(object sender, EventArgs e)
		{
			numberHover = true;
		}

		private void PhoneLb_MouseLeave(object sender, EventArgs e)
		{
			numberHover = false;
		}

		private void checkHover_Tick(object sender, EventArgs e)
		{
			if (nameHover || numberHover || imageHover || panelHover)
			{
				BackColor = Color.Gainsboro;
			}
			else
			{
				BackColor = Color.WhiteSmoke;
			}
		}
	}
}
