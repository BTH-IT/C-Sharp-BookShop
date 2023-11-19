namespace QuanLyCuaHangBanSach.GUI.Modal
{
	partial class AccountModal
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
			this.title = new System.Windows.Forms.Label();
			this.passwordTxt = new Guna.UI2.WinForms.Guna2TextBox();
			this.errorPasswordMsg = new System.Windows.Forms.Label();
			this.passwordLine = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.emailTxt = new Guna.UI2.WinForms.Guna2TextBox();
			this.errorEmailMsg = new System.Windows.Forms.Label();
			this.errorEmailLine = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.staffLine = new System.Windows.Forms.Label();
			this.staffComboBox = new Guna.UI.WinForms.GunaComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.confirmPasswordPanel = new System.Windows.Forms.Panel();
			this.confirmPasswordTxt = new Guna.UI2.WinForms.Guna2TextBox();
			this.errorConfirmPasswordMsg = new System.Windows.Forms.Label();
			this.confirmPasswordLine = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.submitBtn = new Guna.UI.WinForms.GunaButton();
			this.cancelBtn = new Guna.UI.WinForms.GunaButton();
			this.panel4.SuspendLayout();
			this.panel1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.confirmPasswordPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// title
			// 
			this.title.AutoSize = true;
			this.title.Font = new System.Drawing.Font("#9Slide03 Cabin SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.title.Location = new System.Drawing.Point(211, 2);
			this.title.Name = "title";
			this.title.Size = new System.Drawing.Size(224, 45);
			this.title.TabIndex = 9;
			this.title.Text = "Thêm Tài khoản";
			// 
			// passwordTxt
			// 
			this.passwordTxt.BackColor = System.Drawing.Color.Transparent;
			this.passwordTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
			this.passwordTxt.BorderThickness = 0;
			this.passwordTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.passwordTxt.DefaultText = "";
			this.passwordTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.passwordTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.passwordTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.passwordTxt.DisabledState.Parent = this.passwordTxt;
			this.passwordTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.passwordTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.passwordTxt.FocusedState.Parent = this.passwordTxt;
			this.passwordTxt.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passwordTxt.ForeColor = System.Drawing.Color.Black;
			this.passwordTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.passwordTxt.HoverState.Parent = this.passwordTxt;
			this.passwordTxt.Location = new System.Drawing.Point(171, 4);
			this.passwordTxt.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
			this.passwordTxt.Name = "passwordTxt";
			this.passwordTxt.PasswordChar = '\0';
			this.passwordTxt.PlaceholderText = "Nhập mật khẩu";
			this.passwordTxt.SelectedText = "";
			this.passwordTxt.ShadowDecoration.Parent = this.passwordTxt;
			this.passwordTxt.Size = new System.Drawing.Size(379, 35);
			this.passwordTxt.TabIndex = 3;
			this.passwordTxt.TextChanged += new System.EventHandler(this.passwordTxt_TextChanged);
			this.passwordTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordTxt_KeyPress);
			this.passwordTxt.Leave += new System.EventHandler(this.passwordTxt_Leave);
			// 
			// errorPasswordMsg
			// 
			this.errorPasswordMsg.AutoSize = true;
			this.errorPasswordMsg.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.errorPasswordMsg.ForeColor = System.Drawing.Color.Red;
			this.errorPasswordMsg.Location = new System.Drawing.Point(179, 47);
			this.errorPasswordMsg.Name = "errorPasswordMsg";
			this.errorPasswordMsg.Size = new System.Drawing.Size(0, 26);
			this.errorPasswordMsg.TabIndex = 7;
			// 
			// passwordLine
			// 
			this.passwordLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
			this.passwordLine.Location = new System.Drawing.Point(178, 39);
			this.passwordLine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.passwordLine.Name = "passwordLine";
			this.passwordLine.Size = new System.Drawing.Size(372, 1);
			this.passwordLine.TabIndex = 8;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(3, 4);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(168, 35);
			this.label6.TabIndex = 5;
			this.label6.Text = "Mật khẩu:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.emailTxt.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.emailTxt.ForeColor = System.Drawing.Color.Black;
			this.emailTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.emailTxt.HoverState.Parent = this.emailTxt;
			this.emailTxt.Location = new System.Drawing.Point(171, 10);
			this.emailTxt.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
			this.emailTxt.Name = "emailTxt";
			this.emailTxt.PasswordChar = '\0';
			this.emailTxt.PlaceholderText = "Nhập Email";
			this.emailTxt.SelectedText = "";
			this.emailTxt.ShadowDecoration.Parent = this.emailTxt;
			this.emailTxt.Size = new System.Drawing.Size(379, 26);
			this.emailTxt.TabIndex = 2;
			this.emailTxt.TextChanged += new System.EventHandler(this.emailTxt_TextChanged);
			this.emailTxt.Leave += new System.EventHandler(this.emailTxt_TextChanged);
			// 
			// errorEmailMsg
			// 
			this.errorEmailMsg.AutoSize = true;
			this.errorEmailMsg.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.errorEmailMsg.ForeColor = System.Drawing.Color.Red;
			this.errorEmailMsg.Location = new System.Drawing.Point(182, 49);
			this.errorEmailMsg.Name = "errorEmailMsg";
			this.errorEmailMsg.Size = new System.Drawing.Size(0, 26);
			this.errorEmailMsg.TabIndex = 7;
			// 
			// errorEmailLine
			// 
			this.errorEmailLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
			this.errorEmailLine.Location = new System.Drawing.Point(178, 39);
			this.errorEmailLine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.errorEmailLine.Name = "errorEmailLine";
			this.errorEmailLine.Size = new System.Drawing.Size(373, 1);
			this.errorEmailLine.TabIndex = 8;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.passwordTxt);
			this.panel4.Controls.Add(this.errorPasswordMsg);
			this.panel4.Controls.Add(this.passwordLine);
			this.panel4.Controls.Add(this.label6);
			this.panel4.Location = new System.Drawing.Point(3, 219);
			this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(570, 120);
			this.panel4.TabIndex = 9;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(3, 10);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(146, 26);
			this.label3.TabIndex = 5;
			this.label3.Text = "Email:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.errorEmailMsg);
			this.panel1.Controls.Add(this.emailTxt);
			this.panel1.Controls.Add(this.errorEmailLine);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Location = new System.Drawing.Point(3, 104);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(570, 107);
			this.panel1.TabIndex = 0;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoScroll = true;
			this.flowLayoutPanel1.AutoScrollMargin = new System.Drawing.Size(10, 10);
			this.flowLayoutPanel1.Controls.Add(this.panel3);
			this.flowLayoutPanel1.Controls.Add(this.panel1);
			this.flowLayoutPanel1.Controls.Add(this.panel4);
			this.flowLayoutPanel1.Controls.Add(this.confirmPasswordPanel);
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(29, 51);
			this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(578, 441);
			this.flowLayoutPanel1.TabIndex = 12;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.staffLine);
			this.panel3.Controls.Add(this.staffComboBox);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Location = new System.Drawing.Point(3, 4);
			this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(570, 92);
			this.panel3.TabIndex = 13;
			// 
			// staffLine
			// 
			this.staffLine.AutoSize = true;
			this.staffLine.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.staffLine.ForeColor = System.Drawing.Color.Red;
			this.staffLine.Location = new System.Drawing.Point(187, 56);
			this.staffLine.Name = "staffLine";
			this.staffLine.Size = new System.Drawing.Size(0, 26);
			this.staffLine.TabIndex = 27;
			// 
			// staffComboBox
			// 
			this.staffComboBox.BackColor = System.Drawing.Color.Transparent;
			this.staffComboBox.BaseColor = System.Drawing.Color.White;
			this.staffComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.staffComboBox.BorderSize = 1;
			this.staffComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
			this.staffComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.staffComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.staffComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
			this.staffComboBox.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.staffComboBox.ForeColor = System.Drawing.Color.Black;
			this.staffComboBox.FormattingEnabled = true;
			this.staffComboBox.ItemHeight = 30;
			this.staffComboBox.Location = new System.Drawing.Point(178, 11);
			this.staffComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.staffComboBox.Name = "staffComboBox";
			this.staffComboBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.staffComboBox.OnHoverItemForeColor = System.Drawing.Color.White;
			this.staffComboBox.Radius = 6;
			this.staffComboBox.Size = new System.Drawing.Size(375, 36);
			this.staffComboBox.TabIndex = 1;
			this.staffComboBox.Leave += new System.EventHandler(this.staffComboBox_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(3, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(149, 36);
			this.label1.TabIndex = 6;
			this.label1.Text = "Nhân viên:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// confirmPasswordPanel
			// 
			this.confirmPasswordPanel.Controls.Add(this.confirmPasswordTxt);
			this.confirmPasswordPanel.Controls.Add(this.errorConfirmPasswordMsg);
			this.confirmPasswordPanel.Controls.Add(this.confirmPasswordLine);
			this.confirmPasswordPanel.Controls.Add(this.label2);
			this.confirmPasswordPanel.Location = new System.Drawing.Point(3, 347);
			this.confirmPasswordPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.confirmPasswordPanel.Name = "confirmPasswordPanel";
			this.confirmPasswordPanel.Size = new System.Drawing.Size(570, 79);
			this.confirmPasswordPanel.TabIndex = 10;
			// 
			// confirmPasswordTxt
			// 
			this.confirmPasswordTxt.BackColor = System.Drawing.Color.Transparent;
			this.confirmPasswordTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
			this.confirmPasswordTxt.BorderThickness = 0;
			this.confirmPasswordTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.confirmPasswordTxt.DefaultText = "";
			this.confirmPasswordTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.confirmPasswordTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.confirmPasswordTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.confirmPasswordTxt.DisabledState.Parent = this.confirmPasswordTxt;
			this.confirmPasswordTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.confirmPasswordTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.confirmPasswordTxt.FocusedState.Parent = this.confirmPasswordTxt;
			this.confirmPasswordTxt.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.confirmPasswordTxt.ForeColor = System.Drawing.Color.Black;
			this.confirmPasswordTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.confirmPasswordTxt.HoverState.Parent = this.confirmPasswordTxt;
			this.confirmPasswordTxt.Location = new System.Drawing.Point(171, 1);
			this.confirmPasswordTxt.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
			this.confirmPasswordTxt.Name = "confirmPasswordTxt";
			this.confirmPasswordTxt.PasswordChar = '\0';
			this.confirmPasswordTxt.PlaceholderText = "Nhập xác nhận mật khẩu";
			this.confirmPasswordTxt.SelectedText = "";
			this.confirmPasswordTxt.ShadowDecoration.Parent = this.confirmPasswordTxt;
			this.confirmPasswordTxt.Size = new System.Drawing.Size(380, 36);
			this.confirmPasswordTxt.TabIndex = 4;
			this.confirmPasswordTxt.TextChanged += new System.EventHandler(this.confirmPasswordTxt_TextChanged);
			this.confirmPasswordTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.confirmPasswordTxt_KeyPress);
			this.confirmPasswordTxt.Leave += new System.EventHandler(this.confirmPasswordTxt_Leave);
			// 
			// errorConfirmPasswordMsg
			// 
			this.errorConfirmPasswordMsg.AutoSize = true;
			this.errorConfirmPasswordMsg.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.errorConfirmPasswordMsg.ForeColor = System.Drawing.Color.Red;
			this.errorConfirmPasswordMsg.Location = new System.Drawing.Point(182, 47);
			this.errorConfirmPasswordMsg.Name = "errorConfirmPasswordMsg";
			this.errorConfirmPasswordMsg.Size = new System.Drawing.Size(0, 26);
			this.errorConfirmPasswordMsg.TabIndex = 7;
			// 
			// confirmPasswordLine
			// 
			this.confirmPasswordLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
			this.confirmPasswordLine.Location = new System.Drawing.Point(180, 37);
			this.confirmPasswordLine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.confirmPasswordLine.Name = "confirmPasswordLine";
			this.confirmPasswordLine.Size = new System.Drawing.Size(369, 1);
			this.confirmPasswordLine.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(3, 1);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(168, 36);
			this.label2.TabIndex = 5;
			this.label2.Text = "Xác nhận mật khẩu:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// submitBtn
			// 
			this.submitBtn.Animated = true;
			this.submitBtn.AnimationHoverSpeed = 0.05F;
			this.submitBtn.AnimationSpeed = 0.05F;
			this.submitBtn.BackColor = System.Drawing.Color.Transparent;
			this.submitBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.submitBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.submitBtn.BorderSize = 2;
			this.submitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.submitBtn.DialogResult = System.Windows.Forms.DialogResult.None;
			this.submitBtn.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
			this.submitBtn.Font = new System.Drawing.Font("#9Slide03 Cabin Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.submitBtn.ForeColor = System.Drawing.Color.White;
			this.submitBtn.Image = null;
			this.submitBtn.ImageSize = new System.Drawing.Size(20, 20);
			this.submitBtn.Location = new System.Drawing.Point(342, 500);
			this.submitBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.submitBtn.Name = "submitBtn";
			this.submitBtn.OnHoverBaseColor = System.Drawing.Color.White;
			this.submitBtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.submitBtn.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.submitBtn.OnHoverImage = null;
			this.submitBtn.OnPressedColor = System.Drawing.Color.Black;
			this.submitBtn.Radius = 22;
			this.submitBtn.Size = new System.Drawing.Size(175, 47);
			this.submitBtn.TabIndex = 29;
			this.submitBtn.Text = "Lưu";
			this.submitBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
			// 
			// cancelBtn
			// 
			this.cancelBtn.Animated = true;
			this.cancelBtn.AnimationHoverSpeed = 0.05F;
			this.cancelBtn.AnimationSpeed = 0.05F;
			this.cancelBtn.BackColor = System.Drawing.Color.Transparent;
			this.cancelBtn.BaseColor = System.Drawing.Color.White;
			this.cancelBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.cancelBtn.BorderSize = 2;
			this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.None;
			this.cancelBtn.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
			this.cancelBtn.Font = new System.Drawing.Font("#9Slide03 Cabin Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.cancelBtn.Image = null;
			this.cancelBtn.ImageSize = new System.Drawing.Size(20, 20);
			this.cancelBtn.Location = new System.Drawing.Point(124, 500);
			this.cancelBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.cancelBtn.Name = "cancelBtn";
			this.cancelBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.cancelBtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.cancelBtn.OnHoverForeColor = System.Drawing.Color.White;
			this.cancelBtn.OnHoverImage = null;
			this.cancelBtn.OnPressedColor = System.Drawing.Color.White;
			this.cancelBtn.Radius = 22;
			this.cancelBtn.Size = new System.Drawing.Size(175, 47);
			this.cancelBtn.TabIndex = 28;
			this.cancelBtn.Text = "Hủy";
			this.cancelBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
			// 
			// AccountModal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(646, 578);
			this.Controls.Add(this.submitBtn);
			this.Controls.Add(this.cancelBtn);
			this.Controls.Add(this.title);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Font = new System.Drawing.Font("#9Slide03 Cabin", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "AccountModal";
			this.Text = "AccountModal";
			this.Load += new System.EventHandler(this.AccountModal_Load);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.confirmPasswordPanel.ResumeLayout(false);
			this.confirmPasswordPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label title;
		private Guna.UI2.WinForms.Guna2TextBox passwordTxt;
		private System.Windows.Forms.Label errorPasswordMsg;
		private System.Windows.Forms.Panel passwordLine;
		private System.Windows.Forms.Label label6;
		private Guna.UI2.WinForms.Guna2TextBox emailTxt;
		private System.Windows.Forms.Label errorEmailMsg;
		private System.Windows.Forms.Panel errorEmailLine;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Panel confirmPasswordPanel;
		private Guna.UI2.WinForms.Guna2TextBox confirmPasswordTxt;
		private System.Windows.Forms.Label errorConfirmPasswordMsg;
		private System.Windows.Forms.Panel confirmPasswordLine;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label staffLine;
		private Guna.UI.WinForms.GunaComboBox staffComboBox;
        private Guna.UI.WinForms.GunaButton submitBtn;
        private Guna.UI.WinForms.GunaButton cancelBtn;
    }
}
