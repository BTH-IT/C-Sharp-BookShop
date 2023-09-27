using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangBanSach.GUI.Modal
{
    public partial class StaffModal : Form
    {
        public StaffDTO staff = null;
        public bool isSubmitSuccess = false;
        public StaffModal(string title = "Thêm thông tin nhân viên")
        {
            InitializeComponent();
            this.Text = title;
            this.label1.Text = title;   
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            try
            {
				if (this.validateSubmitForm())
				{
					string tenNhanVien = this.staffNameTxt.Text;
					double luong = Convert.ToDouble(this.salaryTxt.Text);
					string soDienThoai = this.phoneNumberTxt.Text;
					int namSinh = int.Parse(this.birthYearTxt.Text);
					int maChucVu = (int)this.positionCbx.SelectedValue;
					string gioiTinh = this.genderCbx.SelectedItem.ToString();

					int maNhanVien = this.staff != null ? this.staff.Ma : 0;

					StaffDTO staff = new StaffDTO(maNhanVien, tenNhanVien, soDienThoai, gioiTinh, namSinh, maChucVu, luong);

					bool isSubmitSuccess = this.staff != null ? StaffBUS.Instance.update(staff) : StaffBUS.Instance.insert(staff);

					if (isSubmitSuccess)
					{
						this.isSubmitSuccess = isSubmitSuccess;
						MessageBox.Show(this.staff != null ? "Cập nhật thành công" : "Thêm mới thành công");
						this.Close();
						return;
					}
				}
			}
            catch { 
            }
          
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
        
        private void StaffModal_Load(object sender, EventArgs e)
        {
            try
            {
				this.Location = new Point(
				(Screen.PrimaryScreen.Bounds.Size.Width / 2) - (this.Size.Width / 2),
				(Screen.PrimaryScreen.Bounds.Size.Height / 2) - (this.Size.Height / 2)
			);
				string[] genders = new string[] { "Chọn giới tính", "Nam", "Nữ" };
				this.genderCbx.Items.AddRange(genders);
				this.genderCbx.SelectedItem = genders[0];
				loadPositionCbx();
				if (staff != null)
				{
					this.staffNameTxt.Text = staff.Ten;
					this.birthYearTxt.Text = staff.NamSinh.ToString();
					this.salaryTxt.Text = staff.Luong.ToString();
					this.genderCbx.SelectedItem = staff.GioiTinh == "Nam" ? genders[1] : genders[2];
					this.phoneNumberTxt.Text = staff.SoDienThoai;

					this.positionCbx.SelectedValue = staff.MaChucVu;

				}
			}
            catch
            {

            }
             
        }
        private bool validateSubmitForm()
        {
            try
            {
				bool isStaffNameValid = CustomValidation.Instance.checkTextbox(
				   this.staffNameTxt,
				   this.errorStaffNameMsg,
				   this.staffNameLine,
				   new string[] { "required" }
			   );
				bool isBirthYearValid = CustomValidation.Instance.checkTextbox(
					 this.birthYearTxt,
					 this.errorBirthYearMsg,
					 this.birthYearLine,
					 new string[] { "required", "positive-number" }
				 );
				bool isSalaryValid = CustomValidation.Instance.checkTextbox(
						this.salaryTxt,
						this.errorSalaryMsg,
						this.salaryLine,
						new string[] { "required", "positive-number" }

					);
				bool isGenderValid = CustomValidation.Instance.checkCombobox(
						this.genderCbx,
						this.errorGenderMsg,
						new string[] { "required" }
					);
				bool isPositionValid = CustomValidation.Instance.checkCombobox(
					   this.positionCbx,
					   this.errorPositionMsg,
					   new string[] { "required" }
				   );
				bool isPhoneNumber = CustomValidation.Instance.checkTextbox(
						this.phoneNumberTxt,
						this.errorPhoneNumberMsg,
						this.phoneNumberLine,
						new string[] { "required", "phone-number" }
					);
				return isStaffNameValid && isSalaryValid && isGenderValid && isPhoneNumber && isBirthYearValid && isPositionValid ;
			}
            catch
            {
				return false;
            }
        }
        private void loadPositionCbx()
        {
			try
			{
				List<PositionDTO> positions = PositionBUS.Instance.getAllData();
				positions.Insert(0, new PositionDTO(0, "Chọn chức vụ", "", false));
				this.positionCbx.DisplayMember = "TenChucVu";
				this.positionCbx.ValueMember = "MaChucVu";
				this.positionCbx.DataSource = positions;
				this.positionCbx.SelectedIndex = 0;
			}
			catch
			{

			}
         
        }
    }

       
 }
