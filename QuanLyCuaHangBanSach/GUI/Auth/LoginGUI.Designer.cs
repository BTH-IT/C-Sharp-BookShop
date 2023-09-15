namespace QuanLyCuaHangBanSach.GUI
{
    partial class LoginGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            QuanLyCuaHangBanSach.CustomButton customButton1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginGUI));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorMsg1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.line1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.errorMsg2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.line2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.gradientPanel2 = new QuanLyCuaHangBanSach.GradientPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.emailTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.pwdTxt = new Guna.UI2.WinForms.Guna2TextBox();
            customButton1 = new QuanLyCuaHangBanSach.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // customButton1
            // 
            customButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            customButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            customButton1.BorderColor = System.Drawing.Color.Transparent;
            customButton1.BorderRadius = 30;
            customButton1.BorderSize = 0;
            customButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            customButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            customButton1.ForeColor = System.Drawing.Color.White;
            customButton1.Location = new System.Drawing.Point(535, 360);
            customButton1.Name = "customButton1";
            customButton1.Size = new System.Drawing.Size(238, 64);
            customButton1.TabIndex = 4;
            customButton1.Text = "Đăng nhập";
            customButton1.TextColor = System.Drawing.Color.White;
            customButton1.UseVisualStyleBackColor = false;
            customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(834, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLogin.Location = new System.Drawing.Point(525, 28);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(248, 68);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Đăng Nhập";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.emailTxt);
            this.panel1.Controls.Add(this.errorMsg1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.line1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(434, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 94);
            this.panel1.TabIndex = 0;
            // 
            // errorMsg1
            // 
            this.errorMsg1.AutoSize = true;
            this.errorMsg1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.errorMsg1.ForeColor = System.Drawing.Color.Red;
            this.errorMsg1.Location = new System.Drawing.Point(173, 57);
            this.errorMsg1.Name = "errorMsg1";
            this.errorMsg1.Size = new System.Drawing.Size(0, 20);
            this.errorMsg1.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(63, 49);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // line1
            // 
            this.line1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
            this.line1.Location = new System.Drawing.Point(170, 52);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(253, 1);
            this.line1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(58, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 40);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.pwdTxt);
            this.panel3.Controls.Add(this.pictureBox5);
            this.panel3.Controls.Add(this.errorMsg2);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.line2);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(434, 214);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(445, 93);
            this.panel3.TabIndex = 3;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::QuanLyCuaHangBanSach.Properties.Resources.hidden_eye_icon_new;
            this.pictureBox5.Location = new System.Drawing.Point(382, 22);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(41, 33);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // errorMsg2
            // 
            this.errorMsg2.AutoSize = true;
            this.errorMsg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.errorMsg2.ForeColor = System.Drawing.Color.Red;
            this.errorMsg2.Location = new System.Drawing.Point(171, 61);
            this.errorMsg2.Name = "errorMsg2";
            this.errorMsg2.Size = new System.Drawing.Size(0, 20);
            this.errorMsg2.TabIndex = 2;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(3, 14);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(63, 41);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // line2
            // 
            this.line2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.line2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
            this.line2.Location = new System.Drawing.Point(170, 56);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(253, 1);
            this.line2.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(58, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 43);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mật khẩu :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(12, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sách là một phép thuật di động độc đáo.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(68, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 49);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome Back!!";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(-16, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(516, 463);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(740, 309);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 30);
            this.label9.TabIndex = 5;
            this.label9.Text = "Quên mật khẩu?";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.checkBox1.Location = new System.Drawing.Point(455, 309);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(134, 30);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Nhớ tài khoản";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.ColorLeft = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.gradientPanel2.ColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(134)))), ((int)(((byte)(244)))));
            this.gradientPanel2.Controls.Add(this.label8);
            this.gradientPanel2.Controls.Add(this.label7);
            this.gradientPanel2.Controls.Add(this.pictureBox6);
            this.gradientPanel2.Location = new System.Drawing.Point(-1, -3);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(432, 461);
            this.gradientPanel2.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(56, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(255, 80);
            this.label8.TabIndex = 2;
            this.label8.Text = " Sống như đọc một cuốn sách\r\nCần phải biết...\r\nlật sang một trang mới khi cần thi" +
    "ết\r\n\r\n";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(67, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(293, 39);
            this.label7.TabIndex = 1;
            this.label7.Text = "Wellcome Back!!";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(-23, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(510, 458);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // emailTxt
            // 
            this.emailTxt.BackColor = System.Drawing.Color.Transparent;
            this.emailTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.emailTxt.BorderThickness = 0;
            this.emailTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTxt.DefaultText = "";
            this.emailTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTxt.DisabledState.Parent = this.emailTxt;
            this.emailTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTxt.FocusedState.Parent = this.emailTxt;
            this.emailTxt.Font = new System.Drawing.Font("#9Slide03 Cabin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxt.ForeColor = System.Drawing.Color.Black;
            this.emailTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTxt.HoverState.Parent = this.emailTxt;
            this.emailTxt.Location = new System.Drawing.Point(162, 19);
            this.emailTxt.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.PasswordChar = '\0';
            this.emailTxt.PlaceholderText = "Nhập email";
            this.emailTxt.SelectedText = "";
            this.emailTxt.ShadowDecoration.Parent = this.emailTxt;
            this.emailTxt.Size = new System.Drawing.Size(261, 30);
            this.emailTxt.TabIndex = 34;
            this.emailTxt.TextChanged += new System.EventHandler(this.emailTxt_TextChanged);
            this.emailTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.emailTxt_KeyDown);
            // 
            // pwdTxt
            // 
            this.pwdTxt.BackColor = System.Drawing.Color.Transparent;
            this.pwdTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.pwdTxt.BorderThickness = 0;
            this.pwdTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pwdTxt.DefaultText = "";
            this.pwdTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pwdTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pwdTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pwdTxt.DisabledState.Parent = this.pwdTxt;
            this.pwdTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pwdTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pwdTxt.FocusedState.Parent = this.pwdTxt;
            this.pwdTxt.Font = new System.Drawing.Font("#9Slide03 Cabin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwdTxt.ForeColor = System.Drawing.Color.Black;
            this.pwdTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pwdTxt.HoverState.Parent = this.pwdTxt;
            this.pwdTxt.Location = new System.Drawing.Point(162, 22);
            this.pwdTxt.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.pwdTxt.Name = "pwdTxt";
            this.pwdTxt.PasswordChar = '\0';
            this.pwdTxt.PlaceholderText = "Nhập mật khẩu";
            this.pwdTxt.SelectedText = "";
            this.pwdTxt.ShadowDecoration.Parent = this.pwdTxt;
            this.pwdTxt.Size = new System.Drawing.Size(212, 32);
            this.pwdTxt.TabIndex = 35;
            this.pwdTxt.TextChanged += new System.EventHandler(this.pwdTxt_TextChanged);
            this.pwdTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pwdTxt_KeyDown);
            // 
            // LoginGUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(customButton1);
            this.Controls.Add(this.gradientPanel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DangNhapGUI_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gradientPanel2.ResumeLayout(false);
            this.gradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel line1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label errorMsg1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label errorMsg2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel line2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox1;
        private GradientPanel gradientPanel2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private Guna.UI2.WinForms.Guna2TextBox emailTxt;
        private Guna.UI2.WinForms.Guna2TextBox pwdTxt;
    }
}