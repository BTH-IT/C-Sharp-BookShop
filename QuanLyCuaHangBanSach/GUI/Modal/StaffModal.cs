using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyCuaHangBanSach.GUI.Modal
{
    public partial class StaffModal : Form
    {
        public StaffDTO staff = null;
        public bool isSubmitSuccess = false;
        private bool isManager = false;
        public StaffModal(string title = "Thêm thông tin nhân viên")
        {
            InitializeComponent();
            this.Text = title;
            this.label1.Text = title;

            this.staffNameTxt.TextChanged += staffNameTxt_TextChanged;
            this.birthYearTxt.TextChanged += birthYearTxt_TextChanged;
            this.phoneNumberTxt.TextChanged += phoneNumberTxt_TextChanged;
            this.salaryTxt.TextChanged += salaryTxt_TextChanged;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            try
            {
				if (this.validateSubmitForm())
				{
					string tenNhanVien = this.staffNameTxt.Text;
					decimal luong = Convert.ToDecimal(this.salaryTxt.Text);
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
                    if (staff.MaChucVu == 1) isManager = true;
                    if (staff.Ma == 1) this.positionCbx.Enabled = false;
					this.staffNameTxt.Text = staff.Ten;
					this.birthYearTxt.Text = staff.NamSinh.ToString();
					this.salaryTxt.Text = staff.Luong.ToString();
					this.genderCbx.SelectedItem = staff.GioiTinh == "Nam" ? genders[1] : genders[2];
					this.phoneNumberTxt.Text = staff.SoDienThoai;

					this.positionCbx.SelectedValue = staff.MaChucVu;
				}
				List<AuthDetailDTO> authDetails;
				authDetails = AuthDetailBUS.Instance.getByPositionId(ManagerGUI.currentStaff.Ma.ToString());
                if (authDetails != null )
                {
                    if(!authDetails.Any(c=>c.maQuyenHan == 12))
                    {
						this.btnAddPosition.Enabled = false;
                    }
                    else
                    {
                        this.btnAddPosition.Enabled = true;
                    }
				}
                else
                {
                    this.btnAddPosition.Enabled = false;
                }
				this.genderCbx.SelectedIndexChanged += genderCbx_SelectedIndexChanged;
                this.genderCbx.TextChanged += genderCbx_SelectedIndexChanged;
                this.positionCbx.TextChanged += positionCbx_SelectedIndexChanged;
                this.positionCbx.SelectedIndexChanged += positionCbx_SelectedIndexChanged;
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
				   new string[] { "required", "name", "space" }
               );
				bool isBirthYearValid = CustomValidation.Instance.checkTextbox(
					 this.birthYearTxt,
					 this.errorBirthYearMsg,
					 this.birthYearLine,
					 new string[] { "required", "positive-number", "max-current-year", "space" , "age-restrict-staff" }
                 );
				bool isSalaryValid = CustomValidation.Instance.checkTextbox(
						this.salaryTxt,
						this.errorSalaryMsg,
						this.salaryLine,
						new string[] { "required", "positive-number", "space" }

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
                bool isPhone = CustomValidation.Instance.checkTextbox(
                    this.phoneNumberTxt,
                    this.errorPhoneNumberMsg,
                    this.phoneNumberLine,
                    new string[] { "required", "phone-number", "space" }
                );

                if (isPhone)
                {
                    if (staff == null)
                    {
                        isPhone = CustomValidation.Instance.checkDuplicateName(
                            this.errorPhoneNumberMsg,
                            this.phoneNumberLine,
                            StaffBUS.Instance.checkDuplicateName(this.phoneNumberTxt.Text),
                            "Số điện thoại đã có trong hệ thống"
                        );
                    } else
                    {
                        isPhone = CustomValidation.Instance.checkDuplicateName(
                            this.errorPhoneNumberMsg,
                            this.phoneNumberLine,
                            StaffBUS.Instance.checkDuplicateName(this.phoneNumberTxt.Text, staff.Ma),
                            "Số điện thoại đã có trong hệ thống"
                        );
                    }
                }
                return isStaffNameValid && isSalaryValid && isGenderValid && isPhone && isBirthYearValid && isPositionValid;
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

        private void staffNameTxt_TextChanged(object sender, EventArgs e)
        {
            CustomValidation.Instance.checkTextbox(
                this.staffNameTxt,
                this.errorStaffNameMsg,
                this.staffNameLine,
                new string[] { "required", "name", "space" }
            );
        }

        private void birthYearTxt_TextChanged(object sender, EventArgs e)
        {
            CustomValidation.Instance.checkTextbox(
                this.birthYearTxt,
                this.errorBirthYearMsg,
                this.birthYearLine,
                new string[] { "required", "positive-number", "max-current-year", "space" , "age-restrict-staff" }
            );
        }

        private void salaryTxt_TextChanged(object sender, EventArgs e)
        {
            CustomValidation.Instance.checkTextbox(
                this.salaryTxt,
                this.errorSalaryMsg,
                this.salaryLine,
                new string[] { "required", "positive-number", "space" }
            );
        }

        private void phoneNumberTxt_Leave(object sender, EventArgs e)
        {
            bool isPhone = CustomValidation.Instance.checkTextbox(
                this.phoneNumberTxt,
                this.errorPhoneNumberMsg,
                this.phoneNumberLine,
                new string[] { "required", "phone-number", "space" }
            );

            if (isPhone)
            {
                if (staff == null)
                {
                   CustomValidation.Instance.checkDuplicateName(
                        this.errorPhoneNumberMsg,
                        this.phoneNumberLine,
                        StaffBUS.Instance.checkDuplicateName(this.phoneNumberTxt.Text),
                        "Số điện thoại đã có trong hệ thống"
                    );
                }
                else
                {
                    CustomValidation.Instance.checkDuplicateName(
                        this.errorPhoneNumberMsg,
                        this.phoneNumberLine,
                        StaffBUS.Instance.checkDuplicateName(this.phoneNumberTxt.Text, staff.Ma),
                        "Số điện thoại đã có trong hệ thống"
                    );
                }
            }
        }

        private void salaryTxt_Leave(object sender, EventArgs e)
        {
            CustomValidation.Instance.checkTextbox(
                this.salaryTxt,
                this.errorSalaryMsg,
                this.salaryLine,
                new string[] { "required", "positive-number", "space" }
            );
        }

        private void staffNameTxt_Leave(object sender, EventArgs e)
        {
            CustomValidation.Instance.checkTextbox(
                this.staffNameTxt,
                this.errorStaffNameMsg,
                this.staffNameLine,
                new string[] { "required", "space" }
            );
        }

        private void birthYearTxt_Leave(object sender, EventArgs e)
        {
            CustomValidation.Instance.checkTextbox(
                this.birthYearTxt,
                this.errorBirthYearMsg,
                this.birthYearLine,
                new string[] { "required", "positive-number", "max-current-year", "space", "age-restrict-staff" }
            );
        }

		private void genderCbx_SelectedIndexChanged(object sender, EventArgs e)
		{
				CustomValidation.Instance.checkCombobox(
					this.genderCbx,
					this.errorGenderMsg,
					new string[] { "required" }
				);
		}
		private void phoneNumberTxt_TextChanged(object sender, EventArgs e)
        {
            bool isPhone = CustomValidation.Instance.checkTextbox(
                this.phoneNumberTxt,
                this.errorPhoneNumberMsg,
                this.phoneNumberLine,
                new string[] { "required", "phone-number", "space" }
            );

            if (isPhone)
            {
                if (staff == null)
                {
                    CustomValidation.Instance.checkDuplicateName(
                        this.errorPhoneNumberMsg,
                        this.phoneNumberLine,
                        StaffBUS.Instance.checkDuplicateName(this.phoneNumberTxt.Text),
                        "Số điện thoại đã có trong hệ thống"
                    );
                }
                else
                {
                    CustomValidation.Instance.checkDuplicateName(
                        this.errorPhoneNumberMsg,
                        this.phoneNumberLine,
                        StaffBUS.Instance.checkDuplicateName(this.phoneNumberTxt.Text, staff.Ma),
                        "Số điện thoại đã có trong hệ thống"
                    );
                }
            }
        }

        private void positionCbx_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool isPositionValid = CustomValidation.Instance.checkCombobox(
					   this.positionCbx,
					   this.errorPositionMsg,
					   new string[] { "required" }
				   );
		}

		private void btnAddPosition_Click(object sender, EventArgs e)
		{
			using (PositionModal positionModal = new PositionModal())
			{
				positionModal.ShowDialog();
                if(positionModal.isSubmitSuccess)
                {
                    loadPositionCbx();
                }    
			}
		}
	}
 }
