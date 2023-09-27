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
   
    public partial class AccountModal : Form
    {
        public bool isSubmitSuccess = false;
        private bool isStaffCbx = false;
        public AccountDTO account = null;

        public AccountModal(string title="Thêm tài khoản")
        {
            InitializeComponent();
            this.title.Text = title;
            this.Text = title;  
        }

        private void birthYearTxtBox_TextChanged(object sender, EventArgs e)
        {
                
        }
        private void loadStaffCbx()
        {
            try
            {
				List<StaffDTO> staffs = StaffBUS.Instance.getAllData();
				staffs.Insert(0, new StaffDTO(0, "Chọn nhân viên", "", "", 0, 0, 0));

				this.staffComboBox.ValueMember = "Ma";
				this.staffComboBox.DisplayMember = "Ten";
				this.staffComboBox.DataSource = staffs;

				this.staffComboBox.SelectedIndex = 0;
			}
            catch
            {

            }
          
        }
        private void AccountModal_Load(object sender, EventArgs e)
        {
            this.Location = new Point(
              (Screen.PrimaryScreen.Bounds.Size.Width / 2) - (this.Size.Width / 2),
              (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (this.Size.Height / 2)
            );
            this.loadStaffCbx();
            try {
				if (account != null)
				{
					StaffDTO staff = StaffBUS.Instance.getById(account.MaNhanVien.ToString());
					this.staffComboBox.SelectedValue = staff.Ma;
					this.staffComboBox.SelectedItem = staff;
					this.emailTxt.Text = account.Email;
					this.passwordTxt.Text = account.MatKhau;
					this.confirmPasswordTxt.Text = account.MatKhau;
				}


			}
			catch { }
           
        }
        private bool validateSubmitForm()
        {
            try {
              isStaffCbx = CustomValidation.Instance.checkCombobox(
                    this.staffComboBox,
                    this.staffLine,
                    new string[] {"required" }

                );
            bool isEmailValid = CustomValidation.Instance.checkTextbox(
                    this.emailTxt,
                    this.errorEmailMsg,
                    this.errorEmailLine,
                    new string[] { "required", "email"}
                );
            bool isPasswordValid = CustomValidation.Instance.checkTextbox(
                    this.passwordTxt,
                    this.errorPasswordMsg,
                    this.errorEmailLine,
                    new string[] { "required"}
                );
            Console.WriteLine(isPasswordValid);
            bool isConfirmPasswordValid = CustomValidation.Instance.checkTextboxMatchWithOtherTextBox(
                    this.confirmPasswordTxt,
                    this.passwordTxt,
                    "Mật khẩu nhập lại không chính xác",
                    this.errorConfirmPasswordMsg,
                    this.confirmPasswordLine
                );
				return isStaffCbx && isPasswordValid && isPasswordValid && isConfirmPasswordValid && isEmailValid;
			}
            catch
            {
                return false;

            }
          

           

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            try {
				if (this.validateSubmitForm())
				{
					string email = this.emailTxt.Text;
					string password = this.passwordTxt.Text;
					int maNhanVien = Convert.ToInt32(this.staffComboBox.SelectedValue);

					AccountDTO account = new AccountDTO(maNhanVien, email, password);
					bool isSuccess = this.account != null ? AccountBUS.Instance.update(account) : AccountBUS.Instance.insert(account);

					if (isSuccess)
					{
						this.isSubmitSuccess = isSuccess;
						MessageBox.Show(this.account != null ? "Cập nhật thành công" : "Thêm dữ liệu thành công");
						this.Close();
						return;
					}

				}
			}
            catch { }
              
        }

        private void staffComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

		private void title_Click(object sender, EventArgs e)
		{

		}
	}
}
