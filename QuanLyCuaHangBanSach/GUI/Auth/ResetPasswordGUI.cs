using System;
using System.Drawing;
using System.Windows.Forms;
using QuanLyCuaHangBanSach.BUS;

namespace QuanLyCuaHangBanSach.GUI
{
    public partial class ResetPasswordGUI : Form
    {
        private string email = SendCodeGUI.to;
        private bool isHiddenNewPwd = true;
        private bool isHiddenConfirmPwd = true;
        public ResetPasswordGUI()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {
            try
            {
                textBox1.ForeColor = Color.Black;
                textBox1.UseSystemPasswordChar = isHiddenNewPwd;

            }
            catch
            {

            }
        }

        private void textBox2_TextChanged(object sender, System.EventArgs e)
        {
            try
            {
                textBox2.ForeColor = Color.Black;
                textBox2.UseSystemPasswordChar = isHiddenConfirmPwd;
            }
            catch
            {

            }
        }

        private void textBox1_Leave(object sender, System.EventArgs e)
        {
            if (textBox1.Text.Length <= 0)
            {
                textBox1.Text = "Enter your password";
                textBox1.ForeColor = Color.LightGray;
                textBox1.UseSystemPasswordChar = false;
            }
        }

        private void textBox1_Click(object sender, System.EventArgs e)
        {
            if (textBox1.Text.Equals("Enter your password"))
            {
                textBox1.Text = "";
            }
        }

        private void textBox2_Leave(object sender, System.EventArgs e)
        {
            if (textBox2.Text.Length <= 0)
            {
                textBox2.Text = "Enter your password";
                textBox2.ForeColor = Color.LightGray;
                textBox2.UseSystemPasswordChar = false;
            }
        }

        private void textBox2_Click(object sender, System.EventArgs e)
        {
            if (textBox2.Text == "Enter your password")
            {
                textBox2.Text = "";
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (this.isHiddenNewPwd)
            {
                this.pictureBox5.Image = QuanLyCuaHangBanSach.Properties.Resources.eye_icon;
                this.isHiddenNewPwd = false;
            }
            else
            {
                this.pictureBox5.Image = QuanLyCuaHangBanSach.Properties.Resources.hidden_eye_icon_new;
                this.isHiddenNewPwd = true;
            }
            
            if (!this.textBox1.Text.Equals("Enter your password"))
            {
                textBox1.UseSystemPasswordChar = this.isHiddenNewPwd;
            }

            this.pictureBox5.Refresh();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (this.isHiddenConfirmPwd)
            {
                this.pictureBox6.Image = QuanLyCuaHangBanSach.Properties.Resources.eye_icon;
                this.isHiddenConfirmPwd = false;
            }
            else
            {
                this.pictureBox6.Image = QuanLyCuaHangBanSach.Properties.Resources.hidden_eye_icon_new;
                this.isHiddenConfirmPwd = true;
            }

            if (!this.textBox2.Text.Equals("Enter your password"))
            {
                textBox2.UseSystemPasswordChar = this.isHiddenNewPwd;
            }
            this.pictureBox6.Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.email = "";
            this.Hide();
            LoginGUI login = new LoginGUI();
            login.Show();
        }

        private bool validateForm()
        {
            if (this.textBox1.Text.Equals("") || this.textBox1.Text.Equals("Enter your password"))
            {
                this.textBox1.Focus();
                this.errorMsg1.Text = "This field is a required field";
                this.line1.BackColor = Color.FromArgb(239, 68, 68);
                return false;
            }
            else
            {
                this.errorMsg1.Text = "";
                this.line1.BackColor = Color.FromArgb(45, 212, 191);
            }

            if (this.textBox2.Text.Equals("") || this.textBox2.Text.Equals("Enter your password"))
            {
                this.textBox2.Focus();
                this.errorMsg2.Text = "This field is a required field";
                this.line2.BackColor = Color.FromArgb(239, 68, 68);
                return false;
            }
            else
            {
                this.errorMsg2.Text = "";
                this.line2.BackColor = Color.FromArgb(45, 212, 191);
            }

            if (!this.textBox2.Text.Equals(this.textBox1.Text) && !this.textBox2.Text.Equals("Enter your password"))
            {
                this.textBox2.Focus();
                this.errorMsg2.Text = "This field must match the new password field";
                this.line2.BackColor = Color.FromArgb(239, 68, 68);
                return false;
            }
            else
            {
                this.errorMsg2.Text = "";
                this.line2.BackColor = Color.FromArgb(45, 212, 191);
            }


            return true;
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            bool isValid = this.validateForm();

            if (!isValid) return;

            bool isSuccess = AccountBUS.Instance.resetPassword(this.email, this.textBox1.Text);

            if (isSuccess)
            {
                MessageBox.Show("Reset password successfully");
            } else
            {
                MessageBox.Show("Reset password failure");
            }

            this.email = "";
            this.Hide();
            LoginGUI login = new LoginGUI();
            login.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.email = "";
            this.Hide();
            SendCodeGUI sendCode = new SendCodeGUI();
            sendCode.Show();
        }
    }
}
