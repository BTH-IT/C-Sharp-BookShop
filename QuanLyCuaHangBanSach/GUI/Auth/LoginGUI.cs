using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.GUI
{
    public partial class LoginGUI : Form
    {

        public static bool isResetPassword = false;
        private bool isHiddenPwd = true;

        private static LoginGUI instance;

        public static LoginGUI Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoginGUI();
                }

                return LoginGUI.instance;
            }
            private set { LoginGUI.instance = value; }
        }

        public LoginGUI()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(2);
            
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

            pwdTxt.UseSystemPasswordChar = this.isHiddenPwd;
            this.pictureBox5.Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Instance.Close();
        }

        private bool validateForm()
        {
            bool isCheckTxt1 = CustomValidation.Instance.checkTextbox(
                this.emailTxt,
                this.errorMsg1,
                this.line1,
                new string[] { "required", "email" }
            );

            bool isCheckTxt2 = CustomValidation.Instance.checkTextbox(
                this.pwdTxt,
                this.errorMsg2,
                this.line2,
                new string[] { "required"}
            );

            return isCheckTxt1 && isCheckTxt2;
        }

        private void handleLogin()
        {
            bool isValid = this.validateForm();
            if (!isValid) return;

            AccountDTO account = AccountBUS.Instance.login(this.emailTxt.Text, this.pwdTxt.Text);

            if (account == null)
            {
                MessageBox.Show("Email hoặc mật khẩu không chính xác, vui lòng thử lại!!");
                checkBox1.Checked = false;
                return;
            }

            if (checkBox1.Checked == true)
            {
                Properties.Settings.Default.Email = this.emailTxt.Text;
                Properties.Settings.Default.Password = this.pwdTxt.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Email = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save();
            }

            MessageBox.Show("Đăng nhập thành công vào hệ thống!");

            MenuGUI menu = new MenuGUI(account.MaNhanVien);
            if (menu.isChecked == true)
            {
                this.Hide();
                menu.Show();
            }
		}

        private void customButton1_Click(object sender, EventArgs e)
        {
            this.handleLogin();
        }

        private void emailTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.handleLogin();
            }
        }

        private void pwdTxt_KeyDown(object sender, KeyEventArgs e)
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

        private void emailTxt_TextChanged(object sender, EventArgs e)
        {
            CustomValidation.Instance.checkTextbox(
                this.emailTxt,
                this.errorMsg1,
                this.line1,
                new string[] { "required", "email", "space" }
            );
        }

        private void pwdTxt_TextChanged(object sender, EventArgs e)
        {
            CustomValidation.Instance.checkTextbox(
                this.pwdTxt,
                this.errorMsg2,
                this.line2,
                new string[] { "required", "space" }
            );
        }

        private void pwdTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true; // Chặn ký tự nhập vào
            }
        }

        private void LoginGUI_Load(object sender, EventArgs e)
        {
            this.pwdTxt.UseSystemPasswordChar = isHiddenPwd;
            this.emailTxt.Text = Properties.Settings.Default.Email;
            this.pwdTxt.Text = Properties.Settings.Default.Password;

            if (Properties.Settings.Default.Email != string.Empty)
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }
        }

        private void LoginGUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.pwdTxt.UseSystemPasswordChar = isHiddenPwd;
            this.emailTxt.Text = Properties.Settings.Default.Email;
            this.pwdTxt.Text = Properties.Settings.Default.Password;

            if (Properties.Settings.Default.Email != string.Empty)
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }
        }
    }
}
