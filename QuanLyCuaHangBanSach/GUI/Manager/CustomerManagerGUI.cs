using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;
using QuanLyCuaHangBanSach.GUI.Modal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyCuaHangBanSach.GUI.Manager
{
	public partial class CustomerManagerGUI : Form
    {
        private CheckBox headerCheckbox;
        string[] genders = new string[] { "Chọn giới tính", "Nam", "Nữ" };
        public CustomerManagerGUI()
        {
            InitializeComponent();
        }
        private void renderCheckBoxDgv()
        {
            int size = 25;

            Rectangle rect = this.dgvCustomer.GetCellDisplayRectangle(0, -1, false);

            headerCheckbox = new CheckBox();

            headerCheckbox.BackColor = Color.FromArgb(45, 210, 192);
            headerCheckbox.Name = "chkHeader";
            headerCheckbox.Size = new Size(size, size);

            rect.X = (rect.Width / 2) - (size / 4);
            rect.Y = (rect.Height / 2) - (size / 2);

            headerCheckbox.Location = rect.Location;


            this.dgvCustomer.Controls.Add(headerCheckbox);
        }
        private void loadCustomerListToDataGridView(List<CustomerDTO> customers)
        {
            this.dgvCustomer.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 210, 192);
            this.dgvCustomer.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            this.dgvCustomer.Rows.Clear();
            try {
				if (customers != null)
				{
					foreach (CustomerDTO customer in customers)
					{
						this.dgvCustomer.Rows.Add(new object[]
						{
							false,
							customer.Ma,
							customer.Ten,
							customer.GioiTinh,
							customer.NamSinh,
							customer.SoDienThoai,
							customer.Diem,
							customer.TrangThai ? "Đang hoạt động" : "Ngưng hoạt động",
                        });
					}

				}
			}
            catch
            {

            }
        }
        private void CustomerManagerGUI_Load(object sender, EventArgs e)
        {
            try
            {
				List<CustomerDTO> customerList = CustomerBUS.Instance.getAllData();

				this.loadCustomerListToDataGridView(customerList);
                this.genderCbx.Items.AddRange(genders);
                this.genderCbx.SelectedIndex = 0;
                this.renderCheckBoxDgv();
				headerCheckbox.MouseClick += new MouseEventHandler(headerCheckbox_Clicked);
			}
            catch
            {

            }
           
        }
        private void headerCheckbox_Clicked(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dgvCustomer.Rows)
            {
                row.Cells[0].Value = headerCheckbox.Checked;
            }

            this.dgvCustomer.RefreshEdit();
        }
        private void publisherCbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
				if (this.dgvCustomer.CurrentCell.RowIndex < 0)
				{
					MessageBox.Show("Hãy chọn khách hàng muốn chỉnh sửa");
					return;
				}
				using (CustomerModal modal = new CustomerModal("Sửa thông tin khách hàng"))
				{
					DataGridViewRow selectedRow = this.dgvCustomer.Rows[this.dgvCustomer.CurrentCell.RowIndex];

					CustomerDTO customer = CustomerBUS.Instance.getById(selectedRow.Cells[1].Value.ToString());

					if (customer == null)
					{
						MessageBox.Show("Đã có lỗi xảy ra vui lòng thử lại");
						return;
					}

					modal.currentCustomer = customer;
					modal.ShowDialog();

					if (modal.isSubmitSuccess)
					{

						List<CustomerDTO> customers = this.handleFilter(this.searchInput.Text.ToString());
						this.loadCustomerListToDataGridView(customers);
					}

				}
			}
            catch
            {

            }
              
        }   

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
				using (CustomerModal modal = new CustomerModal())
				{
					modal.ShowDialog();

					if (modal.isSubmitSuccess)
					{
						List<CustomerDTO> customers = this.handleFilter(this.searchInput.Text.ToString());
						this.loadCustomerListToDataGridView(customers);
					}
				}
			}
			catch { 
            }
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
				this.searchInput.Clear();
                this.genderCbx.SelectedIndex = 0;
                List<CustomerDTO> customers = CustomerBUS.Instance.getAllData();
				this.loadCustomerListToDataGridView(customers);
			}
            catch
            {

            }
        }
        private List<CustomerDTO> handleFilter(string searchInput)
        {
            try
            {
				var customers = CustomerBUS.Instance.Search(searchInput);

                string selectedGender = this.genderCbx.SelectedItem.ToString();

                if (customers != null)
                {
					List<CustomerDTO> newCustomers = customers.FindAll(authorList =>
					{
						if (selectedGender != "Chọn giới tính")
						{
							return authorList.GioiTinh == selectedGender;
						}
						return true;
					}
			         );
					return newCustomers;
                }
                else
                {
                    return customers;
                }   
              
            }
            catch
            {
                return new List<CustomerDTO>();
            }
         
        }
        private void searchInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
				this.searchInput.ForeColor = Color.Black;
				List<CustomerDTO> customers = handleFilter(this.searchInput.Text.ToString());
				this.loadCustomerListToDataGridView(customers);
            }
            catch
            {

            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                List<CustomerDTO> customers = CustomerBUS.Instance.getAllData();
				//List<CustomerDTO> customers = handleFilter(this.searchInput.Text.ToString());
				DataTable dataTable = CustomExcel.Instance.ConvertListToDataTable(customers);
				string[] headerList = new string[] { "Mã khách hàng", "Tên khách hàng", "SĐT", "Giới tính", "Năm sinh" };
                DataTable dt = CustomExcel.Instance.ConvertDataGridViewToDataTable(dgvCustomer);

                CustomExcel.Instance.ExportFileDatagridView(dt, "Book Manage", 1, "Cửa hàng bán sách", headerList);
            }
            catch
            {

            }
           
        }

        private void cellCustomer_DblClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
				if (e.RowIndex < 0 || e.ColumnIndex < 0)
				{
					return;
				}
				using (CustomerModal modal = new CustomerModal("Sửa thông tin khách hàng"))
				{
					DataGridViewRow selectedRow = this.dgvCustomer.Rows[this.dgvCustomer.CurrentCell.RowIndex];

					CustomerDTO customer = CustomerBUS.Instance.getById(selectedRow.Cells[1].Value.ToString());

					if (customer == null)
					{
						MessageBox.Show("Đã có lỗi xảy ra vui lòng thử lại");
						return;
					}

					modal.currentCustomer = customer;
					modal.ShowDialog();

					if (modal.isSubmitSuccess)
					{
						List<CustomerDTO> customers = CustomerBUS.Instance.getAllData();
						this.loadCustomerListToDataGridView(customers);
					}

				}
			}
            catch
            {

            }
           
        }

		private void genderCbx_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				List<CustomerDTO> customerList = handleFilter(this.searchInput.Text.ToString());
				this.loadCustomerListToDataGridView(customerList);
			}
			catch (Exception er)
			{

				Console.WriteLine(er);
			}
		}
    }
}
