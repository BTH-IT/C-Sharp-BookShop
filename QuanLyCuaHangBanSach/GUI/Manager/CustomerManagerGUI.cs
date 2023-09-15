using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;
using QuanLyCuaHangBanSach.GUI.Modal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace QuanLyCuaHangBanSach.GUI.Manager
{
    public partial class CustomerManagerGUI : Form
    {
        private CheckBox headerCheckbox;
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

            if (customers != null )
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
                    customer.SoDienThoai

                    });
                }

            }
           
        }
        private void CustomerManagerGUI_Load(object sender, EventArgs e)
        {
            List<CustomerDTO> customerList  = CustomerBUS.Instance.getAllData();
            this.loadCustomerListToDataGridView(customerList);
            this.renderCheckBoxDgv();
            headerCheckbox.MouseClick += new MouseEventHandler(headerCheckbox_Clicked);
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
            if (this.dgvCustomer.CurrentCell.RowIndex < 0 )
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (CustomerModal modal =  new CustomerModal())
            {
                modal.ShowDialog();

                if(modal.isSubmitSuccess)
                {
                    List<CustomerDTO> customers =this.handleFilter(this.searchInput.Text.ToString());
                    this.loadCustomerListToDataGridView(customers);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult deleteDialogResult = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa các khách hàng đã chọn",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.None
                );
           if(deleteDialogResult == DialogResult.Yes)
            {
                
                foreach(DataGridViewRow row in this.dgvCustomer.Rows)
                {
                      if ((bool)row.Cells[0].Value)
                       {
                           CustomerBUS.Instance.delete(row.Cells[4].Value.ToString());
                       } 
                }
             
                List<CustomerDTO> customers = this.handleFilter(this.searchInput.Text.ToString()); ;
                this.loadCustomerListToDataGridView(customers);
                MessageBox.Show("Xóa khách hàng thành công");
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.searchInput.Clear();

            List<CustomerDTO> customers = CustomerBUS.Instance.getAllData();
            this.loadCustomerListToDataGridView(customers);
        }
        private List<CustomerDTO> handleFilter(string searchInput)
        {
            
            return CustomerBUS.Instance.Search(searchInput);
        }
        private void searchInput_TextChanged(object sender, EventArgs e)
        {
            this.searchInput.ForeColor = Color.Black;
            List<CustomerDTO> customers = handleFilter(this.searchInput.Text.ToString());
            this.loadCustomerListToDataGridView(customers);

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            List<CustomerDTO> customers = handleFilter(this.searchInput.Text.ToString());
            DataTable dataTable = CustomExcel.Instance.ConvertListToDataTable(customers);
            string[] headerList = new string[] { "Mã khách hàng","Tên khách hàng","SĐT","Giới tính","Năm sinh" };
            CustomExcel.Instance.ExportFile(dataTable, "Quản lý khách hàng", "Cửa hàng bán sách", headerList);
        }

        private void cellCustomer_DblClick(object sender, DataGridViewCellEventArgs e)
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
    }
}
