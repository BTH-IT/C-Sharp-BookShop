using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;
using QuanLyCuaHangBanSach.GUI.Modal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangBanSach.GUI.Manager
{
    public partial class StaffManageGUI : Form
    {
        private CheckBox headerCheckbox;
        string[] genders = new string[] { "Chọn giới tính", "Nam", "Nữ" };
        public StaffManageGUI()
        {
            InitializeComponent();
        }
        private void renderCheckBoxDgv()
        {
            int size = 25;

            Rectangle rect = this.dgvStaff.GetCellDisplayRectangle(0, -1, false);

            headerCheckbox = new CheckBox();

            headerCheckbox.BackColor = Color.FromArgb(45, 210, 192);
            headerCheckbox.Name = "chkHeader";
            headerCheckbox.Size = new Size(size, size);

            rect.X = (rect.Width / 2) - (size / 4);
            rect.Y = (rect.Height / 2) - (size / 2);

            headerCheckbox.Location = rect.Location;


            this.dgvStaff.Controls.Add(headerCheckbox);
        }
        private void loadDataToDataGridView(List<StaffDTO> staffs)
        {
            this.dgvStaff.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 210, 192);
            this.dgvStaff.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            this.dgvStaff.Rows.Clear();
            try
            {
				if (staffs != null)
				{
					foreach (StaffDTO staff in staffs)
					{
						this.dgvStaff.Rows.Add(
								new object[]
								{
								false,
								staff.Ma,
								staff.Ten,
								staff.NamSinh,
								staff.GioiTinh,
								staff.SoDienThoai,
								staff.Luong.ToString() ,
								PositionBUS.Instance.getById(staff.MaChucVu.ToString()).TenChucVu
								}
							);
					}

				}
			}
            catch
            {

            }


        }
        private void loadPositionCbx()
        {
            try
            {
				List<PositionDTO> positions = PositionBUS.Instance.getAllData();
				positions.Insert(0, new PositionDTO(0, "Lọc theo chức vụ", "", false));
				this.positionCbx.DisplayMember = "TenChucVu";
				this.positionCbx.ValueMember = "MaChucVu";

				this.positionCbx.DataSource = positions;

				this.positionCbx.SelectedIndex = 0;
			}
            catch
            {

            }
           
        }
        private void StaffManageGUI_Load(object sender, EventArgs e)
        {
            try
            {
				List<StaffDTO> staffs = StaffBUS.Instance.getAllData();
				this.renderCheckBoxDgv();

				this.genderCbx.Items.AddRange(genders);
				this.genderCbx.SelectedIndex = 0;
				this.loadPositionCbx();

				this.loadDataToDataGridView(staffs);
			}
            catch
            {
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            try
            {
				this.searchInput.Clear();
				this.genderCbx.SelectedIndex = 0;
				this.positionCbx.SelectedIndex = 0;
				this.salaryFrom.Clear();
				this.salaryTo.Clear();
				List<StaffDTO> staffs = StaffBUS.Instance.getAllData();
				this.loadDataToDataGridView(staffs);
			}
            catch
            {

            }
            
            
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            try
            {
				List<StaffDTO> staff = handleFilter(this.searchInput.Text.ToString());

				DataTable dataTable = CustomExcel.Instance.ConvertListToDataTable(staff);

				string[] headerList = new string[] { "Mã nhân viên", "Tên nhân viên", "Năm sinh", "SĐT", "Giới tính", "Lương", "Số ngày nghỉ", "Mã chức vụ" };

				CustomExcel.Instance.ExportFile(dataTable, "Staff Manage", "Cửa hàng bán sách", headerList, 2);
			}
            catch
            {

            }
            
        }

        private List<StaffDTO> handleFilter(string searchInput)
        {
			List<StaffDTO> staffs = StaffBUS.Instance.search(searchInput);
			try
            {
				if (this.salaryFrom.Text.ToString() != string.Empty && this.salaryTo.Text.ToString() != string.Empty)
				{
					Regex isNum = new Regex(@"^\d+$");

					if (!isNum.IsMatch(this.salaryFrom.Text.ToString()) || !isNum.IsMatch(this.salaryTo.Text.ToString()))
					{
						this.salaryFrom.Clear();
						this.salaryTo.Clear();
						MessageBox.Show("Tổng tiền là một số");
					}
					else
					{
						staffs = staffs.Where(staff => staff.Luong >= Convert.ToDouble(this.salaryFrom.Text) && staff.Luong <= Convert.ToDouble(this.salaryTo.Text)).ToList();
					}
				}

				string selectedGender = this.genderCbx.SelectedItem.ToString();
				int selectedPositionId = Convert.ToInt32(this.positionCbx.SelectedValue);

				if (staffs != null)
				{
					List<StaffDTO> newStaffs = staffs.FindAll(staff =>
					{
						if (selectedGender != "Chọn giới tính" && selectedPositionId != 0)
						{
							return staff.GioiTinh == selectedGender && staff.MaChucVu == selectedPositionId;
						}
						if (selectedGender == "Chọn giới tính" && selectedPositionId != 0)
						{
							return staff.MaChucVu == selectedPositionId;
						}
						if (selectedGender != "Chọn giới tính" && selectedPositionId == 0)
						{
							return staff.GioiTinh == selectedGender;
						}
						return true;
					}

					);
					return newStaffs;
				}
				else
				{
					return staffs;

				}
			}
            catch
            {
                return staffs;
            }
           
  
            
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
				using (var modal = new StaffModal())
				{
					modal.ShowDialog();

					if (modal.isSubmitSuccess)
					{
						MessageBox.Show("Thêm nhân viên thành công");
						List<StaffDTO> staffs = handleFilter(this.searchInput.Text);
						this.loadDataToDataGridView(staffs);

					}
				}
			}
            catch
            {

            }
          
        }

        private void positionCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
				List<StaffDTO> staffs = handleFilter(this.searchInput.Text);
				loadDataToDataGridView(staffs);
			}
            catch
            {

            }
          
        }

        private void genderCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
				List<StaffDTO> staffs = handleFilter(this.searchInput.Text);
				loadDataToDataGridView(staffs);
			}
            catch
            {

            }
        }

        private void salaryFrom_TextChanged(object sender, EventArgs e)
        {
            try
            {
				List<StaffDTO> staffs = handleFilter(this.searchInput.Text);
				loadDataToDataGridView(staffs);
			}
            catch
            {

            }
         
        }

        private void salaryTo_TextChanged(object sender, EventArgs e)
        {
            try
            {
				List<StaffDTO> staffs = handleFilter(this.searchInput.Text);
				loadDataToDataGridView(staffs);
			}
            catch
            {

            }
   
        }
       
        private void editBtn_Click(object sender, EventArgs e)
        {
            try {
				if (this.dgvStaff.CurrentCell.RowIndex < 0)
				{
					MessageBox.Show("Vui lòng chọn một nhân viên");
					return;
				}
				using (StaffModal modal = new StaffModal("Sửa nhân viên"))
				{
					DataGridViewRow selectedRow = this.dgvStaff.Rows[this.dgvStaff.CurrentCell.RowIndex];

					StaffDTO staff = StaffBUS.Instance.getById(selectedRow.Cells[1].Value.ToString());

					modal.staff = staff;

					modal.ShowDialog();

					if (modal.isSubmitSuccess)
					{
						MessageBox.Show("Sửa nhân viên thành công");
						List<StaffDTO> staffs = handleFilter(this.searchInput.Text);
						loadDataToDataGridView(staffs);
					}
				}
			}
            catch { }
           
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
				DialogResult result = MessageBox.Show(
			 "Bạn có chắc muốn xóa các nhân viên đã chọn",
			 "Xác nhận",
				  MessageBoxButtons.YesNo,
				  MessageBoxIcon.None
			 );
				if (result == DialogResult.Yes)
				{
					foreach (DataGridViewRow row in this.dgvStaff.Rows)
					{
						if ((bool)row.Cells[0].Value)
						{
							var isExistAccount = AccountBUS.Instance.getAllData().Where(account => account.MaNhanVien == (int)row.Cells[1].Value).Any();
							if (isExistAccount)
							{
								MessageBox.Show("Vui lòng xóa tài khoản của " + row.Cells[2].Value.ToString() + "trước");
							}
							else
							{
								StaffBUS.Instance.delete(row.Cells[1].Value.ToString());
								List<StaffDTO> staffs = handleFilter(this.searchInput.Text);
								loadDataToDataGridView(staffs);
								MessageBox.Show("Xóa thành công");
							}
						}
					}

				}
			}
            catch
            {

            }
           
        }

        private void searchInput_TextChanged(object sender, EventArgs e)
        {
			try
			{
				List<StaffDTO> staffs = handleFilter(this.searchInput.Text);
				this.loadDataToDataGridView(staffs);
			}
			catch { 
			}	
            
        }
    }
}
