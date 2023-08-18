using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace QuanLyCuaHangBanSach.GUI
{
    public partial class DangNhapGUI : Form
    {
        private bool isHiddenPwd = true;
        public DangNhapGUI()
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
            textBox2.UseSystemPasswordChar = this.isHiddenPwd;
            this.pictureBox5.Refresh();
        }
    }
}
