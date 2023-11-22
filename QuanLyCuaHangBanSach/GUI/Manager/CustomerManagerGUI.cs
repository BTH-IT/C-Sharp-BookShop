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
        string[] genders = new string[] { "Tất cả giới tính", "Nam", "Nữ" };
        public CustomerManagerGUI()
        {
            InitializeComponent();
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
							customer.Ma,
							customer.Ten,
							customer.GioiTinh,
							customer.NamSinh,
							customer.SoDienThoai,
							customer.Diem
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
				this.loadCustomerListToDataGridView(customerList);
			}
            catch
            {

            }
           
        }
       
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.dgvCustomer.CurrentCell != null)
                {
					if (this.dgvCustomer.CurrentCell.RowIndex < 0)
					{
						MessageBox.Show("Hãy chọn khách hàng muốn chỉnh sửa");
						return;
					}
					using (CustomerModal modal = new CustomerModal("Sửa thông tin khách hàng"))
					{
						DataGridViewRow selectedRow = this.dgvCustomer.Rows[this.dgvCustomer.CurrentCell.RowIndex];

						CustomerDTO customer = CustomerBUS.Instance.getById(selectedRow.Cells[0].Value.ToString());

						if (customer == null)
						{
							MessageBox.Show("Đã có lỗi xảy ra vui lòng thử lại");
							return;
						}

						modal.currentCustomer = customer;
						modal.ShowDialog();

						if (modal.isSubmitSuccess)
						{

							List<CustomerDTO> customers = this.handleFilter(this.searchInput.Text.Trim());
							this.loadCustomerListToDataGridView(customers);
						}

					}
				}
                else
                {
					MessageBox.Show("Bảng dữ liệu có thể chưa có dòng dữ liệu nào để chỉnh sửa");
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
						List<CustomerDTO> customers = this.handleFilter(this.searchInput.Text.Trim());
						Console.WriteLine("SSS");
						this.loadCustomerListToDataGridView(customers);
					}
				}
			}
			catch { 
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
				DialogResult deleteDialogResult = MessageBox.Show(
				 "Bạn có chắc chắn muốn xóa các khách hàng đã chọn",
				 "Xác nhận",
				 MessageBoxButtons.YesNo,
				 MessageBoxIcon.None
			 );
				if (deleteDialogResult == DialogResult.Yes)
				{

					foreach (DataGridViewRow row in this.dgvCustomer.Rows)
					{
						if ((bool)row.Cells[0].Value)
						{
							CustomerBUS.Instance.delete(row.Cells[5].Value.ToString());

						}
					}

					List<CustomerDTO> customers = this.handleFilter(this.searchInput.Text.Trim());
					this.loadCustomerListToDataGridView(customers);
					MessageBox.Show("Xóa khách hàng thành công");
				}
			}
            catch
            {

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
                if (customers != null )
                {
					List<CustomerDTO> newCustomers = customers.FindAll(authorList =>
					{
						if (selectedGender != "Tất cả giới tính")
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
					return new List<CustomerDTO>();
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
				List<CustomerDTO> customers = handleFilter(this.searchInput.Text.Trim());
				this.loadCustomerListToDataGridView(customers);
            }
            catch
            {

            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.Rows.Count <= 0)
            {
                MessageBox.Show("Bảng dữ liệu hiện tại chưa có dòng dữ liệu nào để xuất excel!");
                return;
            }
            try
            {
				string[] headerList = new string[] { "Mã khách hàng", "Tên khách hàng", "SĐT", "Giới tính", "Năm sinh","Điểm" };
                DataTable dt = CustomExcel.Instance.ConvertDataGridViewToDataTable(dgvCustomer);

                CustomExcel.Instance.ExportFileDatagridView(dt, "Book Manage", 0, "Cửa hàng bán sách", headerList);
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

					CustomerDTO customer = CustomerBUS.Instance.getById(selectedRow.Cells[0].Value.ToString());

					if (customer == null)
					{
						MessageBox.Show("Đã có lỗi xảy ra vui lòng thử lại");
						return;
					}

					modal.currentCustomer = customer;
					modal.ShowDialog();

					if (modal.isSubmitSuccess)
					{
                        List<CustomerDTO> customers = this.handleFilter(this.searchInput.Text.Trim());
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
            List<CustomerDTO> customers = handleFilter(this.searchInput.Text.Trim());
            this.loadCustomerListToDataGridView(customers);
        }
	}
}
