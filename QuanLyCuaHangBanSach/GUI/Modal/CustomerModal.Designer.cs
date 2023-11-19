namespace QuanLyCuaHangBanSach.GUI.Modal
{
    partial class CustomerModal
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
            this.label16 = new System.Windows.Forms.Label();
            this.genderCbx = new Guna.UI.WinForms.GunaComboBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.phoneNumberTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.errorPhoneNumberMsg = new System.Windows.Forms.Label();
            this.phoneNumberLine = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customerNameTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.errorCustomerNameMsg = new System.Windows.Forms.Label();
            this.customerNameLine = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.birthYearTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.errorBirthYearMsg = new System.Windows.Forms.Label();
            this.birthYearLine = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.errorGenderMsg = new System.Windows.Forms.Label();
            this.submitBtn = new Guna.UI.WinForms.GunaButton();
            this.cancelBtn = new Guna.UI.WinForms.GunaButton();
            this.title = new System.Windows.Forms.Label();
            this.panel10.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("#9Slide03 Cabin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label16.Location = new System.Drawing.Point(3, 6);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(145, 36);
            this.label16.TabIndex = 28;
            this.label16.Text = "Giới tính:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // genderCbx
            // 
            this.genderCbx.BackColor = System.Drawing.Color.Transparent;
            this.genderCbx.BaseColor = System.Drawing.Color.White;
            this.genderCbx.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.genderCbx.BorderSize = 1;
            this.genderCbx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.genderCbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.genderCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderCbx.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
            this.genderCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderCbx.ForeColor = System.Drawing.Color.Black;
            this.genderCbx.FormattingEnabled = true;
            this.genderCbx.IntegralHeight = false;
            this.genderCbx.ItemHeight = 30;
            this.genderCbx.Location = new System.Drawing.Point(160, 6);
            this.genderCbx.MaxDropDownItems = 10;
            this.genderCbx.Name = "genderCbx";
            this.genderCbx.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.genderCbx.OnHoverItemForeColor = System.Drawing.Color.White;
            this.genderCbx.Radius = 6;
            this.genderCbx.Size = new System.Drawing.Size(408, 36);
            this.genderCbx.TabIndex = 4;
            this.genderCbx.Leave += new System.EventHandler(this.genderCbx_SelectedIndexChanged);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.phoneNumberTxtBox);
            this.panel10.Controls.Add(this.errorPhoneNumberMsg);
            this.panel10.Controls.Add(this.phoneNumberLine);
            this.panel10.Controls.Add(this.label4);
            this.panel10.Location = new System.Drawing.Point(603, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(594, 108);
            this.panel10.TabIndex = 1;
            // 
            // phoneNumberTxtBox
            // 
            this.phoneNumberTxtBox.BackColor = System.Drawing.Color.Transparent;
            this.phoneNumberTxtBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.phoneNumberTxtBox.BorderThickness = 0;
            this.phoneNumberTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneNumberTxtBox.DefaultText = "";
            this.phoneNumberTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phoneNumberTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phoneNumberTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneNumberTxtBox.DisabledState.Parent = this.phoneNumberTxtBox;
            this.phoneNumberTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneNumberTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneNumberTxtBox.FocusedState.Parent = this.phoneNumberTxtBox;
            this.phoneNumberTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberTxtBox.ForeColor = System.Drawing.Color.Black;
            this.phoneNumberTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneNumberTxtBox.HoverState.Parent = this.phoneNumberTxtBox;
            this.phoneNumberTxtBox.Location = new System.Drawing.Point(149, 7);
            this.phoneNumberTxtBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.phoneNumberTxtBox.Name = "phoneNumberTxtBox";
            this.phoneNumberTxtBox.PasswordChar = '\0';
            this.phoneNumberTxtBox.PlaceholderText = "Nhập số điện thoại";
            this.phoneNumberTxtBox.SelectedText = "";
            this.phoneNumberTxtBox.ShadowDecoration.Parent = this.phoneNumberTxtBox;
            this.phoneNumberTxtBox.Size = new System.Drawing.Size(425, 29);
            this.phoneNumberTxtBox.TabIndex = 2;
            this.phoneNumberTxtBox.TextChanged += new System.EventHandler(this.phoneNumberTxtBox_TextChanged);
            this.phoneNumberTxtBox.Leave += new System.EventHandler(this.phoneNumberTxtBox_TextChanged);
            // 
            // errorPhoneNumberMsg
            // 
            this.errorPhoneNumberMsg.AutoSize = true;
            this.errorPhoneNumberMsg.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.errorPhoneNumberMsg.ForeColor = System.Drawing.Color.Red;
            this.errorPhoneNumberMsg.Location = new System.Drawing.Point(163, 48);
            this.errorPhoneNumberMsg.Name = "errorPhoneNumberMsg";
            this.errorPhoneNumberMsg.Size = new System.Drawing.Size(0, 21);
            this.errorPhoneNumberMsg.TabIndex = 7;
            // 
            // phoneNumberLine
            // 
            this.phoneNumberLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
            this.phoneNumberLine.Location = new System.Drawing.Point(160, 38);
            this.phoneNumberLine.Name = "phoneNumberLine";
            this.phoneNumberLine.Size = new System.Drawing.Size(414, 1);
            this.phoneNumberLine.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("#9Slide03 Cabin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(3, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số điện thoại:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.customerNameTxtBox);
            this.panel1.Controls.Add(this.errorCustomerNameMsg);
            this.panel1.Controls.Add(this.customerNameLine);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 108);
            this.panel1.TabIndex = 0;
            // 
            // customerNameTxtBox
            // 
            this.customerNameTxtBox.BackColor = System.Drawing.Color.Transparent;
            this.customerNameTxtBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.customerNameTxtBox.BorderThickness = 0;
            this.customerNameTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customerNameTxtBox.DefaultText = "";
            this.customerNameTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.customerNameTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.customerNameTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerNameTxtBox.DisabledState.Parent = this.customerNameTxtBox;
            this.customerNameTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerNameTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerNameTxtBox.FocusedState.Parent = this.customerNameTxtBox;
            this.customerNameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameTxtBox.ForeColor = System.Drawing.Color.Black;
            this.customerNameTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerNameTxtBox.HoverState.Parent = this.customerNameTxtBox;
            this.customerNameTxtBox.Location = new System.Drawing.Point(168, 8);
            this.customerNameTxtBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.customerNameTxtBox.Name = "customerNameTxtBox";
            this.customerNameTxtBox.PasswordChar = '\0';
            this.customerNameTxtBox.PlaceholderText = "Nhập tên khách hàng";
            this.customerNameTxtBox.SelectedText = "";
            this.customerNameTxtBox.ShadowDecoration.Parent = this.customerNameTxtBox;
            this.customerNameTxtBox.Size = new System.Drawing.Size(406, 28);
            this.customerNameTxtBox.TabIndex = 1;
            this.customerNameTxtBox.TextChanged += new System.EventHandler(this.customerNameTxtBox_TextChanged);
            this.customerNameTxtBox.Leave += new System.EventHandler(this.customerNameTxtBox_TextChanged);
            // 
            // errorCustomerNameMsg
            // 
            this.errorCustomerNameMsg.AutoSize = true;
            this.errorCustomerNameMsg.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.errorCustomerNameMsg.ForeColor = System.Drawing.Color.Red;
            this.errorCustomerNameMsg.Location = new System.Drawing.Point(181, 52);
            this.errorCustomerNameMsg.Name = "errorCustomerNameMsg";
            this.errorCustomerNameMsg.Size = new System.Drawing.Size(0, 21);
            this.errorCustomerNameMsg.TabIndex = 7;
            // 
            // customerNameLine
            // 
            this.customerNameLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
            this.customerNameLine.Location = new System.Drawing.Point(179, 38);
            this.customerNameLine.Name = "customerNameLine";
            this.customerNameLine.Size = new System.Drawing.Size(395, 1);
            this.customerNameLine.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("#9Slide03 Cabin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên khách hàng:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel10);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(11, 53);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1200, 216);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.birthYearTxtBox);
            this.panel4.Controls.Add(this.errorBirthYearMsg);
            this.panel4.Controls.Add(this.birthYearLine);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(3, 117);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(594, 88);
            this.panel4.TabIndex = 2;
            // 
            // birthYearTxtBox
            // 
            this.birthYearTxtBox.BackColor = System.Drawing.Color.Transparent;
            this.birthYearTxtBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.birthYearTxtBox.BorderThickness = 0;
            this.birthYearTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.birthYearTxtBox.DefaultText = "";
            this.birthYearTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.birthYearTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.birthYearTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.birthYearTxtBox.DisabledState.Parent = this.birthYearTxtBox;
            this.birthYearTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.birthYearTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.birthYearTxtBox.FocusedState.Parent = this.birthYearTxtBox;
            this.birthYearTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthYearTxtBox.ForeColor = System.Drawing.Color.Black;
            this.birthYearTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.birthYearTxtBox.HoverState.Parent = this.birthYearTxtBox;
            this.birthYearTxtBox.Location = new System.Drawing.Point(168, 3);
            this.birthYearTxtBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.birthYearTxtBox.Name = "birthYearTxtBox";
            this.birthYearTxtBox.PasswordChar = '\0';
            this.birthYearTxtBox.PlaceholderText = "Nhập năm sinh";
            this.birthYearTxtBox.SelectedText = "";
            this.birthYearTxtBox.ShadowDecoration.Parent = this.birthYearTxtBox;
            this.birthYearTxtBox.Size = new System.Drawing.Size(406, 31);
            this.birthYearTxtBox.TabIndex = 3;
            this.birthYearTxtBox.TextChanged += new System.EventHandler(this.birthYearTxtBox_TextChanged);
            this.birthYearTxtBox.Leave += new System.EventHandler(this.birthYearTxtBox_TextChanged);
            // 
            // errorBirthYearMsg
            // 
            this.errorBirthYearMsg.AutoSize = true;
            this.errorBirthYearMsg.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.errorBirthYearMsg.ForeColor = System.Drawing.Color.Red;
            this.errorBirthYearMsg.Location = new System.Drawing.Point(177, 45);
            this.errorBirthYearMsg.Name = "errorBirthYearMsg";
            this.errorBirthYearMsg.Size = new System.Drawing.Size(0, 21);
            this.errorBirthYearMsg.TabIndex = 7;
            // 
            // birthYearLine
            // 
            this.birthYearLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
            this.birthYearLine.Location = new System.Drawing.Point(175, 36);
            this.birthYearLine.Name = "birthYearLine";
            this.birthYearLine.Size = new System.Drawing.Size(395, 1);
            this.birthYearLine.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("#9Slide03 Cabin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 31);
            this.label6.TabIndex = 5;
            this.label6.Text = "Năm sinh:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.errorGenderMsg);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.genderCbx);
            this.panel3.Location = new System.Drawing.Point(603, 117);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(594, 88);
            this.panel3.TabIndex = 3;
            // 
            // errorGenderMsg
            // 
            this.errorGenderMsg.AutoSize = true;
            this.errorGenderMsg.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.errorGenderMsg.ForeColor = System.Drawing.Color.Red;
            this.errorGenderMsg.Location = new System.Drawing.Point(164, 52);
            this.errorGenderMsg.Name = "errorGenderMsg";
            this.errorGenderMsg.Size = new System.Drawing.Size(0, 21);
            this.errorGenderMsg.TabIndex = 30;
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
            this.submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.ForeColor = System.Drawing.Color.White;
            this.submitBtn.Image = null;
            this.submitBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.submitBtn.Location = new System.Drawing.Point(621, 285);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.OnHoverBaseColor = System.Drawing.Color.White;
            this.submitBtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.submitBtn.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.submitBtn.OnHoverImage = null;
            this.submitBtn.OnPressedColor = System.Drawing.Color.Black;
            this.submitBtn.Radius = 22;
            this.submitBtn.Size = new System.Drawing.Size(200, 50);
            this.submitBtn.TabIndex = 6;
            this.submitBtn.Text = "Lưu";
            this.submitBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.submitBtn.Click += new System.EventHandler(this.btnSubmit_Click);
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
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.cancelBtn.Image = null;
            this.cancelBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.cancelBtn.Location = new System.Drawing.Point(404, 285);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.cancelBtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.cancelBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.cancelBtn.OnHoverImage = null;
            this.cancelBtn.OnPressedColor = System.Drawing.Color.White;
            this.cancelBtn.Radius = 22;
            this.cancelBtn.Size = new System.Drawing.Size(200, 50);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Hủy";
            this.cancelBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cancelBtn.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // title
            // 
            this.title.Dock = System.Windows.Forms.DockStyle.Top;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(1222, 50);
            this.title.TabIndex = 5;
            this.title.Text = "Thêm Khách hàng";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomerModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1222, 352);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.title);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CustomerModal";
            this.Text = "Thêm khách hàng";
            this.Load += new System.EventHandler(this.CustomerModal_Load);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label16;
        private Guna.UI.WinForms.GunaComboBox genderCbx;
        private System.Windows.Forms.Panel panel10;
        private Guna.UI2.WinForms.Guna2TextBox phoneNumberTxtBox;
        private System.Windows.Forms.Label errorPhoneNumberMsg;
        private System.Windows.Forms.Panel phoneNumberLine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox customerNameTxtBox;
        private System.Windows.Forms.Label errorCustomerNameMsg;
        private System.Windows.Forms.Panel customerNameLine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label errorGenderMsg;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2TextBox birthYearTxtBox;
        private System.Windows.Forms.Label errorBirthYearMsg;
        private System.Windows.Forms.Panel birthYearLine;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaButton submitBtn;
        private Guna.UI.WinForms.GunaButton cancelBtn;
        private System.Windows.Forms.Label title;
    }
}