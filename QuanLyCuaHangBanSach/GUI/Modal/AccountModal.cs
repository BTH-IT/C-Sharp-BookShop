using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyCuaHangBanSach.GUI.Modal
{

    public partial class AccountModal : Form
    {
        public bool isSubmitSuccess = false;
        private bool isStaffCbx = false;
        public AccountDTO account = null;

        public AccountModal(string title = "Thêm tài khoản")
        {
            InitializeComponent();
            this.title.Text = title;
            this.Text = title;
        }
        private void loadStaffCbx()
        {
            try
            {
                List<StaffDTO> staffs = new List<StaffDTO>();
                if (account != null)
                {
                    staffs = StaffBUS.Instance.getAllNoAccountNotId(account.MaNhanVien);
                } else
                {
                    staffs = StaffBUS.Instance.getAllNoAccount();
                }
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
            staffComboBox.SelectedIndexChanged += staffComboBox_SelectedIndexChanged;   
            try
            {
                if (account != null)
                {
                    StaffDTO staff = StaffBUS.Instance.getById(account.MaNhanVien.ToString());
                    this.staffComboBox.SelectedValue = staff.Ma;
                    this.staffComboBox.SelectedItem = staff;
                    this.emailTxt.Text = account.Email;
                    this.passwordTxt.Text = account.MatKhau;
                    this.confirmPasswordTxt.Text = account.MatKhau;
                }

                this.staffComboBox.SelectedIndexChanged += staffComboBox_SelectedIndexChanged;


            }
            catch { }

        }
        private bool validateSubmitForm()
        {
            try
            {
                isStaffCbx = CustomValidation.Instance.checkCombobox(
                    this.staffComboBox,
                    this.staffLine,
                    new string[] { "required" }
                );

                bool isEmailValid = CustomValidation.Instance.checkTextbox(
                    this.emailTxt,
                    this.errorEmailMsg,
                    this.errorEmailLine,
                    new string[] { "required", "email" }
                );

                if (isEmailValid)
                {
                    if (account == null)
                    {
                        isEmailValid = CustomValidation.Instance.checkDuplicateName(
                            this.errorEmailMsg,
                            this.errorEmailLine,
                            AccountBUS.Instance.checkDuplicateName(this.emailTxt.Text)
                        );
                    }
                    else
                    {
                        isEmailValid = CustomValidation.Instance.checkDuplicateName(
                            this.errorEmailMsg,
                            this.errorEmailLine,
                            AccountBUS.Instance.checkDuplicateName(this.emailTxt.Text, account.MaNhanVien)
                        );
                    }
                }

                bool isPasswordValid = CustomValidation.Instance.checkTextbox(
                    this.passwordTxt,
                    this.errorPasswordMsg,
                    this.passwordLine,
                    new string[] { "password" }
                );

                bool isConfirmPasswordValid = CustomValidation.Instance.checkTextbox(
                    this.confirmPasswordTxt,
                    this.errorConfirmPasswordMsg,
                    this.confirmPasswordLine,
                    new string[] { "required" }
                );

                if (isConfirmPasswordValid)
                {
                    isConfirmPasswordValid = CustomValidation.Instance.checkTextboxMatchWithOtherTextBox(
                        this.confirmPasswordTxt,
                        this.passwordTxt,
                        "Mật khẩu nhập lại không chính xác",
                        this.errorConfirmPasswordMsg,
                        this.confirmPasswordLine
                    );
                }

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
            try
            {
                if (this.validateSubmitForm())
                {
                    string email = this.emailTxt.Text;
                    string password = this.passwordTxt.Text;
                    int maNhanVien = Convert.ToInt32(this.staffComboBox.SelectedValue);

                    bool isStaffHasAccount = AccountBUS.Instance.getByStaffId(maNhanVien.ToString()) != null ? true : false;
                    if (isStaffHasAccount && account == null)
                    {
                        MessageBox.Show("Nhân viên đã có tài khoản", "Thông báo");
                        return;
                    }
                    else
                    {
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
            }
            catch { }

        }

        private void staffComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            isStaffCbx = CustomValidation.Instance.checkCombobox(
                this.staffComboBox,
                this.staffLine,
                new string[] { "required" }
            );
        }

        private void emailTxt_TextChanged(object sender, EventArgs e)
        {
            bool isEmailValid = CustomValidation.Instance.checkTextbox(
                    this.emailTxt,
                    this.errorEmailMsg,
                    this.errorEmailLine,
                    new string[] { "required", "email", "space" }
                );

            if (isEmailValid)
            {
                if (account == null)
                {
                    CustomValidation.Instance.checkDuplicateName(
                        this.errorEmailMsg,
                        this.errorEmailLine,
                        AccountBUS.Instance.checkDuplicateName(this.emailTxt.Text)
                    );
                } else
                {
                    CustomValidation.Instance.checkDuplicateName(
                        this.errorEmailMsg,
                        this.errorEmailLine,
                        AccountBUS.Instance.checkDuplicateName(this.emailTxt.Text, account.MaNhanVien)
                    );
                }
            }
        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {
            CustomValidation.Instance.checkTextbox(
                this.passwordTxt,
                this.errorPasswordMsg,
                this.passwordLine,
                new string[] { "password", "space" }
            );
        }

        private void confirmPasswordTxt_TextChanged(object sender, EventArgs e)
        {
            bool isConfirmPasswordValid = CustomValidation.Instance.checkTextbox(
                    this.confirmPasswordTxt,
                    this.errorConfirmPasswordMsg,
                    this.confirmPasswordLine,
                    new string[] { "required", "space" }
                );

            if (isConfirmPasswordValid)
            {
                CustomValidation.Instance.checkTextboxMatchWithOtherTextBox(
                    this.confirmPasswordTxt,
                    this.passwordTxt,
                    "Mật khẩu nhập lại không chính xác",
                    this.errorConfirmPasswordMsg,
                    this.confirmPasswordLine
                );
            }
        }

        private void emailTxt_Leave(object sender, EventArgs e)
        {
            CustomValidation.Instance.checkTextbox(
                this.emailTxt,
                this.errorEmailMsg,
                this.errorEmailLine,
                new string[] { "required", "email", "space" }
            );
        }

        private void passwordTxt_Leave(object sender, EventArgs e)
        {
            CustomValidation.Instance.checkTextbox(
                this.passwordTxt,
                this.errorPasswordMsg,
                this.passwordLine,
                new string[] { "password" }
            );
        }

        private void confirmPasswordTxt_Leave(object sender, EventArgs e)
        {
            bool isConfirmPasswordValid = CustomValidation.Instance.checkTextbox(
                    this.confirmPasswordTxt,
                    this.errorConfirmPasswordMsg,
                    this.confirmPasswordLine,
                    new string[] { "required" }
                );

            if (isConfirmPasswordValid)
            {
                isConfirmPasswordValid = CustomValidation.Instance.checkTextboxMatchWithOtherTextBox(
                    this.confirmPasswordTxt,
                    this.passwordTxt,
                    "Mật khẩu nhập lại không chính xác",
                    this.errorConfirmPasswordMsg,
                    this.confirmPasswordLine
                );
            }
        }

        private void passwordTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true; // Chặn ký tự nhập vào
            }
        }

        private void confirmPasswordTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true; // Chặn ký tự nhập vào
            }
        }
    }
}
