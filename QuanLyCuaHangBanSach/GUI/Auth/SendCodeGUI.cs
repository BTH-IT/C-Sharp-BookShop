using System;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.GUI
{
    public partial class SendCodeGUI : Form
    {
        private string randomCode;
        public static string to;
        public SendCodeGUI()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(2);
        }

        private void emailTxt_TextChanged(object sender, System.EventArgs e)
        {
            CustomValidation.Instance.checkTextbox(
                this.emailTxt,
                this.errorMsg1,
                this.line1,
                new string[] { "required", "email", "space" }
            );
        }

        private void codeTxt_TextChanged(object sender, System.EventArgs e)
        {
            CustomValidation.Instance.checkTextbox(
                this.codeTxt,
                this.errorMsg2,
                this.line2,
                new string[] { "required", "space" }
            );
        }


        private bool validateEmail()
        {
            bool isCheck = CustomValidation.Instance.checkTextbox(
                this.emailTxt,
                this.errorMsg1,
                this.line1,
                new string[] { "required", "email" , "space" }
            );

            if (isCheck)
            {
                AccountDTO account = AccountBUS.Instance.getById(this.emailTxt.Text);

                if (account == null)
                {
                    this.emailTxt.Focus();
                    this.errorMsg1.Text = "Email này không tồn tại trong hệ thống";
                    this.line1.BackColor = Color.FromArgb(239, 68, 68);
                    return false;
                }

                this.errorMsg1.Text = "";
                this.line1.BackColor = Color.FromArgb(45, 212, 191);
            }

            return isCheck;
        }

        private void handleSendCode()
        {
            bool isValid = this.validateEmail();

            if (!isValid) return;

            string from, pass, msgBody;

            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
            MailMessage msg = new MailMessage();
            to = (this.emailTxt.Text).ToString();

            from = "bookstorecsharp2023@gmail.com";
            pass = "uwbwyrynbqmkiyec";
            msgBody = $"Your Reset Code is: {randomCode}";

            msg.To.Add(to);
            msg.From = new MailAddress(from);
            msg.Body = msgBody;
            msg.Subject = "Password Reset Code From Book Store";

            /* Config Smtp Email */
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            
            try
            {
                smtp.Send(msg);
                this.customButton2.Enabled = false;

                this.handleRemoveCode();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            if (this.customButton2.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.customButton2.Text = text;
            }
        }

        private void handleRemoveCode()
        {
            int i = 60;
            var actionInterval = new Action(() => {
                SetText(i.ToString() + "s");
                i--;
            });

            var timer = CustomTimer.Instance.SetInterval(actionInterval, 1000);

            var actionTimeOut = new Action(() => {
                this.randomCode = "";
                CustomTimer.Instance.ClearInterval(timer);

                this.customButton2.Enabled = true;
                this.codeTxt.Refresh();

                SetText("Gửi mã");
            });

            CustomTimer.Instance.SetTimeout(actionTimeOut, 60000);
        }


        private void customButton2_Click(object sender, EventArgs e)
        {
            this.handleSendCode();
        }

        private bool validateCode()
        {
            return CustomValidation.Instance.checkTextbox(
                this.codeTxt,
                this.errorMsg2,
                this.line2,
                new string[] { "required", "space" }
            );
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            bool isValid = validateCode();

            if (!isValid) return;

            if (this.randomCode == this.codeTxt.Text.ToString())
            {
                to = emailTxt.Text.ToString();
                ResetPasswordGUI resetPassword = new ResetPasswordGUI();
                this.Hide();
                resetPassword.Show();
            } else
            {
                MessageBox.Show("Mã không hợp lệ hoặc đã hết hạn! Vui lòng thử lại!");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.randomCode = "";
            to = "";
            this.Hide();
            LoginGUI.Instance.Show();
        }
    }
}
