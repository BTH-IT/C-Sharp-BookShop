using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;
using static System.Net.Mime.MediaTypeNames;

namespace QuanLyCuaHangBanSach.GUI
{
    public partial class LoginGUI : Form
    {
        private bool isHiddenPwd = true;
        public LoginGUI()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(2);
            
            if (Properties.Settings.Default.Email != string.Empty) {
                this.textBox1.Text = Properties.Settings.Default.Email;
                this.textBox2.Text = Properties.Settings.Default.Password;
                checkBox1.Checked = true;
            } else
            {
                checkBox1.Checked = false;
            }
        }

        #region xử lý border form
        private GraphicsPath GetRoundedPath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void FormRegionAndBorder(Form form, float radius, Graphics graph, Color borderColor, float borderSize)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                using (GraphicsPath roundPath = GetRoundedPath(form.ClientRectangle, radius))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                using (Matrix transform = new Matrix())
                {
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    form.Region = new Region(roundPath);
                    if (borderSize >= 1)
                    {
                        Rectangle rect = form.ClientRectangle;
                        float scaleX = 1.0F - ((borderSize + 1) / rect.Width);
                        float scaleY = 1.0F - ((borderSize + 1) / rect.Height);

                        transform.Scale(scaleX, scaleY);
                        transform.Translate(borderSize / 1.6F, borderSize / 1.6F);

                        graph.Transform = transform;
                        graph.DrawPath(penBorder, roundPath);
                    }
                }
            }
        }

        private void DangNhapGUI_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            FormRegionAndBorder(this, 30, e.Graphics, Color.White, 2);
        }
        #endregion

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {
            try
            {
                textBox1.ForeColor = Color.Black;
            } catch
            {

            }
        }

        private void textBox2_TextChanged(object sender, System.EventArgs e)
        {
            try
            {
                textBox2.ForeColor = Color.Black;
                textBox2.UseSystemPasswordChar = this.isHiddenPwd;
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
            if (this.isHiddenPwd)
            {
                this.pictureBox5.Image = QuanLyCuaHangBanSach.Properties.Resources.eye_icon;
                this.isHiddenPwd = false;
            } else
            {
                this.pictureBox5.Image = QuanLyCuaHangBanSach.Properties.Resources.hidden_eye_icon_new;
                this.isHiddenPwd = true;
            }

            if (!this.textBox2.Text.Equals("Enter your password"))
            {
                textBox2.UseSystemPasswordChar = this.isHiddenPwd;
            }
            this.pictureBox5.Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool validateForm()
        {
            if (this.textBox1.Text.Equals("") || this.textBox1.Text.Equals("Enter your email"))
            {
                this.textBox1.Focus();
                this.errorMsg1.Text = "This field is a required field";
                this.line1.BackColor = Color.FromArgb(239, 68, 68);
                return false;
            } else
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
            } else
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
            } else
            {
                this.errorMsg2.Text = "";
                this.line2.BackColor = Color.FromArgb(45, 212, 191);
            }

            
            return true;
        }

        private void handleLogin()
        {
            bool isValid = this.validateForm();

            if (!isValid) return;

            AccountDTO account = AccountBUS.Instance.login(this.textBox1.Text, this.textBox2.Text);

            if (account == null)
            {
                MessageBox.Show("Email or password is invalid, please try again!!");
                checkBox1.Checked = false;
                return;
            }

            if (checkBox1.Checked == true)
            {
                Properties.Settings.Default.Email = this.textBox1.Text;
                Properties.Settings.Default.Password = this.textBox2.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Email = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save();
            }
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            this.handleLogin();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.handleLogin();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.handleLogin();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            SendCodeGUI sendCode = new SendCodeGUI();
            sendCode.Show();
        }
    }
}
