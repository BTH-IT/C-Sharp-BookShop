using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {
            try
            {
                textBox1.ForeColor = Color.Black;
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
            }
            catch
            {

            }
        }

        private void textBox1_Leave(object sender, System.EventArgs e)
        {
            if (textBox1.Text.Length <= 0)
            {
                textBox1.Text = "Enter your email";
                textBox1.ForeColor = Color.LightGray;
            }
        }

        private void textBox1_Click(object sender, System.EventArgs e)
        {
            if (textBox1.Text.Equals("Enter your email"))
            {
                textBox1.Text = "";
            }
        }

        private void textBox2_Leave(object sender, System.EventArgs e)
        {
            if (textBox2.Text.Length <= 0)
            {
                textBox2.Text = "Enter your code";
                textBox2.ForeColor = Color.LightGray;
            }
        }

        private void textBox2_Click(object sender, System.EventArgs e)
        {
            if (textBox2.Text == "Enter your code")
            {
                textBox2.Text = "";
            }
        }


        private bool validateEmail()
        {
            if (this.textBox1.Text.Equals("") || this.textBox1.Text.Equals("Enter your email"))
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

            if (!Regex.Match(textBox1.Text, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$").Success)
            {
                this.textBox1.Focus();
                this.errorMsg1.Text = "This field is an email field";
                this.line1.BackColor = Color.FromArgb(239, 68, 68);
                return false;
            }
            else
            {
                this.errorMsg1.Text = "";
                this.line1.BackColor = Color.FromArgb(45, 212, 191);
            }

            AccountDTO account = AccountBUS.Instance.getById(this.textBox1.Text);

            if (account == null)
            {
                this.textBox1.Focus();
                this.errorMsg1.Text = "This account isn't found in system!";
                this.line1.BackColor = Color.FromArgb(239, 68, 68);
                return false;
            }
            else
            {
                this.errorMsg1.Text = "";
                this.line1.BackColor = Color.FromArgb(45, 212, 191);
            }

            return true;
        }

        private void handleSendCode()
        {
            bool isValid = this.validateEmail();

            if (!isValid) return;

            string from, pass, msgBody;

            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
            MailMessage msg = new MailMessage();
            to = (this.textBox1.Text).ToString();

            from = "bookstorecsharp2023@gmail.com";
            pass = "eenbnmjukrklptce";
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
                MessageBox.Show("Code Successfully Send, Code will expire in 1 minute!");
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
                this.textBox2.Text = "Enter your code";
                this.line2.BackColor = Color.FromArgb(45, 212, 191);
                textBox2.ForeColor = Color.LightGray;

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
            if (this.textBox2.Text.Equals("") || this.textBox2.Text.Equals("Enter your code"))
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

            return true;
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            bool isValid = validateCode();

            if (!isValid) return;

            if (this.randomCode == this.textBox2.Text.ToString())
            {
                to = textBox1.Text.ToString();
                ResetPasswordGUI resetPassword = new ResetPasswordGUI();
                this.Hide();
                resetPassword.Show();
            } else
            {
                MessageBox.Show("Wrong code or expired code! Please try again!");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.randomCode = "";
            to = "";
            this.Hide();
            LoginGUI login = new LoginGUI();
            login.Show();
        }
    }
}
