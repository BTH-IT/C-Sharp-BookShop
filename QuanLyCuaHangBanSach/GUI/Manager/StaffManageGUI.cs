using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;
using QuanLyCuaHangBanSach.GUI.Modal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangBanSach.GUI.Manager
{
    public partial class StaffManageGUI : Form
    {
        private CheckBox headerCheckbox;
        string[] genders = new string[] { "Tất cả giới tính", "Nam", "Nữ" };
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
            headerCheckbox.TabStop = false;

            rect.X = (rect.Width / 2) - (size / 4);
            rect.Y = (rect.Height / 2) - (size / 2);

            headerCheckbox.Location = rect.Location;


            this.dgvStaff.Controls.Add(headerCheckbox);
        }
        private void loadDataToDataGridView(List<StaffDTO> staffs)
        {
            this.dgvStaff.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 210, 192);
            this.dgvStaff.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dgvStaff.ColumnHeadersDefaultCellStyle.Font = new Font("#9Slide03 Cabin", 10, FontStyle.Regular);
			this.dgvStaff.Rows.Clear();
            try
            {
				if (staffs != null)
				{
					foreach (StaffDTO staff in staffs)
					{
                        PositionDTO position = PositionBUS.Instance.getById(staff.MaChucVu.ToString());
                        decimal luongChinh =Math.Round((staff.Luong * (decimal)position.HeSoLuong)/1000)*1000;
						this.dgvStaff.Rows.Add(
							new object[]
							{
								false,
								staff.Ma,
								staff.Ten,
								staff.NamSinh,
								staff.GioiTinh,
								staff.SoDienThoai,
                                string.Format("{0:N0} VNĐ", staff.Luong),
								position.TenChucVu,
                                string.Format("{0:N0} VNĐ", luongChinh)
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
				positions.Insert(0, new PositionDTO(0, "Lọc theo chức vụ", "", false, 0));
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
                headerCheckbox.MouseClick += new MouseEventHandler(headerCheckbox_Clicked);
                this.genderCbx.Items.AddRange(genders);
				this.genderCbx.SelectedIndex = 0;
				this.loadPositionCbx();

				this.loadDataToDataGridView(staffs);
			}
            catch
            {
            }
        }

        private void headerCheckbox_Clicked(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in this.dgvStaff.Rows)
                {
                    row.Cells[0].Value = headerCheckbox.Checked;
                }

                this.dgvStaff.RefreshEdit();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
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
            if (dgvStaff.Rows.Count <= 0)
            {
                MessageBox.Show("Bảng dữ liệu hiện tại chưa có dòng dữ liệu nào để xuất excel!");
                return;
            }
            try
            {
                string[] headerList = new string[] { "Mã nhân viên", "Tên nhân viên", "Năm sinh", "Giới tính", "SĐT",  "Lương", "Chức vụ" ,"Lương thực tế"};

                DataTable dt = CustomExcel.Instance.ConvertDataGridViewToDataTable(dgvStaff);

                CustomExcel.Instance.ExportFileDatagridView(dt, "Book Manage", 1, "Cửa hàng bán sách", headerList);
            }
            catch
            {

            }
            
        }
        private decimal tinhLuongChinhThuc(StaffDTO staff)
        {
			PositionDTO position = PositionBUS.Instance.getById(staff.MaChucVu.ToString());
			decimal luongChinh = Math.Round((staff.Luong * (decimal)position.HeSoLuong) / 1000) * 1000;

            return luongChinh;
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
						MessageBox.Show("Lương là một số");
					}
					else
					{
                        if (Convert.ToDecimal(this.salaryFrom.Text.ToString()) > Convert.ToDecimal(this.salaryTo.Text.ToString()))
                        {
                            MessageBox.Show("Lương đến phải bé hơn hoặc bằng lương từ");
							this.salaryFrom.Clear();
							this.salaryTo.Clear();
						}
                        else
                        {
                            staffs = staffs.Where(staff =>tinhLuongChinhThuc(staff) >= Convert.ToDecimal(this.salaryFrom.Text) && tinhLuongChinhThuc(staff) <= Convert.ToDecimal(this.salaryTo.Text)).ToList();
                        }
					}
				}

				string selectedGender = this.genderCbx.SelectedItem.ToString();
				int selectedPositionId = Convert.ToInt32(this.positionCbx.SelectedValue);

				if (staffs != null)
				{
					List<StaffDTO> newStaffs = staffs.FindAll(staff =>
					{
						if (selectedGender != "Tất cả giới tính" && selectedPositionId != 0)
						{
							return staff.GioiTinh == selectedGender && staff.MaChucVu == selectedPositionId;
						}
						if (selectedGender == "Tất cả giới tính" && selectedPositionId != 0)
						{
							return staff.MaChucVu == selectedPositionId;
						}
						if (selectedGender != "Tất cả giới tính" && selectedPositionId == 0)
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
						List<StaffDTO> staffs = handleFilter(this.searchInput.Text.Trim());
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
				List<StaffDTO> staffs = handleFilter(this.searchInput.Text.Trim());
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
				List<StaffDTO> staffs = handleFilter(this.searchInput.Text.Trim());
				loadDataToDataGridView(staffs);
			}
            catch
            {

            }
        }

        private readonly int debounceInterval = 500; // Đặt khoảng thời gian debounce là 500 milliseconds
        private DateTime lastTextChanged = DateTime.MinValue;
        private readonly object debounceLock = new object();

        private async void DebounceTextBox_TextChanged(object sender, EventArgs e)
        {
            lock (debounceLock)
            {
                lastTextChanged = DateTime.Now;
            }

            await Task.Delay(debounceInterval);

            lock (debounceLock)
            {
                var now = DateTime.Now;
                if ((now - lastTextChanged).TotalMilliseconds >= debounceInterval)
                {
                    List<StaffDTO> staffs = handleFilter(this.searchInput.Text.Trim());
                    loadDataToDataGridView(staffs);
                }
            }
        }

        private void salaryFrom_TextChanged(object sender, EventArgs e)
        {
            try
            {
				List<StaffDTO> staffs = handleFilter(this.searchInput.Text.Trim());
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
				List<StaffDTO> staffs = handleFilter(this.searchInput.Text.Trim());
				loadDataToDataGridView(staffs);
			}
            catch
            {

            }
   
        }
       
        private void editBtn_Click(object sender, EventArgs e)
        {
            try 
            {
                if(this.dgvStaff.CurrentCell != null)
                {
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
							List<StaffDTO> staffs = handleFilter(this.searchInput.Text.Trim());
							loadDataToDataGridView(staffs);
						}
					}
                }
                else
                {
                    MessageBox.Show("Bảng dữ liệu có thể chưa có dòng dữ liệu nào để chỉnh sửa");
                }    
				
			}
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                bool isHaveSelect = false;

                foreach (DataGridViewRow row in this.dgvStaff.Rows)
                {
                    if ((bool)row.Cells[0].Value)
                    {
                        isHaveSelect = true;
                    }
                }

                if (!isHaveSelect)
                {
                    MessageBox.Show("Bạn chưa chọn các nhân viên cần xóa");
                    return;
                }
                DialogResult result = MessageBox.Show(
			    "Bạn có chắc muốn xóa các nhân viên đã chọn?\n *Nếu xóa nhân viên tài khoản cũng sẽ bị xóa",
			    "Xác nhận",
				  MessageBoxButtons.YesNo,
				  MessageBoxIcon.None
			    );
				if (result == DialogResult.Yes)
				{
                        bool isDeleted = false;
						foreach (DataGridViewRow row in this.dgvStaff.Rows)
						{
							if ((bool)row.Cells[0].Value)
							{
                                StaffDTO staff = StaffBUS.Instance.getById(row.Cells[1].Value.ToString()); 
                                AccountDTO acc = AccountBUS.Instance.getByStaffId(row.Cells[1].Value.ToString());
                                if(staff.MaChucVu != 1)
                                {
								    if (acc != null)
								    {
									    AccountBUS.Instance.delete(acc.Email);
									    StaffBUS.Instance.delete(row.Cells[1].Value.ToString());
									    isDeleted = true;
								    }
								    else
								    {
									    StaffBUS.Instance.delete(row.Cells[1].Value.ToString());
                                        isDeleted = true;
								    }
                                }
                                else 
                                {
                                    MessageBox.Show("Không được xóa quản lí","Thông báo");
                                }    
							}
						}
                        if(isDeleted)
                        {
						    List<StaffDTO> staffs = handleFilter(this.searchInput.Text.Trim());
						    loadDataToDataGridView(staffs);
						    MessageBox.Show("Xóa thành công");
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
				List<StaffDTO> staffs = handleFilter(this.searchInput.Text.Trim());
				this.loadDataToDataGridView(staffs);
			}
			catch { 
			}	
            
        }

        private void dgvStaff_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
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
                        List<StaffDTO> staffs = handleFilter(this.searchInput.Text.Trim());
                        loadDataToDataGridView(staffs);
                    }
                }
            }
            catch { }
        }

        private void dgvStaff_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            if (e.Column.Index == dgvStaff.Columns.Count - 1 || e.Column.Index == dgvStaff.Columns.Count - 3) // Check if sorting the last column
            {
                // Extract the values for sorting from the cell values
                double value1 = GetSortingValue(e.CellValue1);
                double value2 = GetSortingValue(e.CellValue2);

                // Compare the extracted values
                e.SortResult = value1.CompareTo(value2);

                // Mark the comparison as handled to prevent default sorting
                e.Handled = true;
            }
        }

        private double GetSortingValue(object cellValue)
        {
            if (cellValue == null)
                return 0;

            // Extract the numerical value from the string (remove " VNĐ" and parse)
            string stringValue = cellValue.ToString();
            stringValue = stringValue.Replace(".", "").Replace(" VNĐ", "");

            if (double.TryParse(stringValue, out double numericValue))
            {
                // Convert the numeric value to a sortable string
                return numericValue;
            }

            return 0;
        }

        private void salaryFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn chặn ký tự nhập vào TextBox
            }
        }

        private void salaryTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn chặn ký tự nhập vào TextBox
            }
        }
    }
}
