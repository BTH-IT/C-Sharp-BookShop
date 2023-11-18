namespace QuanLyCuaHangBanSach.GUI.Modal
{
    partial class StaffModal
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
			this.panel10 = new System.Windows.Forms.Panel();
			this.birthYearTxt = new Guna.UI2.WinForms.Guna2TextBox();
			this.errorBirthYearMsg = new System.Windows.Forms.Label();
			this.birthYearLine = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.errorPositionMsg = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.positionCbx = new Guna.UI.WinForms.GunaComboBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.staffNameTxt = new Guna.UI2.WinForms.Guna2TextBox();
			this.errorStaffNameMsg = new System.Windows.Forms.Label();
			this.staffNameLine = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.errorGenderMsg = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.genderCbx = new Guna.UI.WinForms.GunaComboBox();
			this.panel7 = new System.Windows.Forms.Panel();
			this.phoneNumberTxt = new Guna.UI2.WinForms.Guna2TextBox();
			this.errorPhoneNumberMsg = new System.Windows.Forms.Label();
			this.phoneNumberLine = new System.Windows.Forms.Panel();
			this.label8 = new System.Windows.Forms.Label();
			this.panel12 = new System.Windows.Forms.Panel();
			this.salaryTxt = new Guna.UI2.WinForms.Guna2TextBox();
			this.errorSalaryMsg = new System.Windows.Forms.Label();
			this.salaryLine = new System.Windows.Forms.Panel();
			this.label10 = new System.Windows.Forms.Label();
			this.submitBtn = new Guna.UI.WinForms.GunaButton();
			this.cancelBtn = new Guna.UI.WinForms.GunaButton();
			this.label1 = new System.Windows.Forms.Label();
			this.panel10.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel12.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel10
			// 
			this.panel10.Controls.Add(this.birthYearTxt);
			this.panel10.Controls.Add(this.errorBirthYearMsg);
			this.panel10.Controls.Add(this.birthYearLine);
			this.panel10.Controls.Add(this.label4);
			this.panel10.Location = new System.Drawing.Point(3, 97);
			this.panel10.Name = "panel10";
			this.panel10.Size = new System.Drawing.Size(594, 88);
			this.panel10.TabIndex = 1;
			// 
			// birthYearTxt
			// 
			this.birthYearTxt.BackColor = System.Drawing.Color.Transparent;
			this.birthYearTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
			this.birthYearTxt.BorderThickness = 0;
			this.birthYearTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.birthYearTxt.DefaultText = "";
			this.birthYearTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.birthYearTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.birthYearTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.birthYearTxt.DisabledState.Parent = this.birthYearTxt;
			this.birthYearTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.birthYearTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.birthYearTxt.FocusedState.Parent = this.birthYearTxt;
			this.birthYearTxt.Font = new System.Drawing.Font("#9Slide03 Cabin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.birthYearTxt.ForeColor = System.Drawing.Color.Black;
			this.birthYearTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.birthYearTxt.HoverState.Parent = this.birthYearTxt;
			this.birthYearTxt.Location = new System.Drawing.Point(149, 7);
			this.birthYearTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.birthYearTxt.Name = "birthYearTxt";
			this.birthYearTxt.PasswordChar = '\0';
			this.birthYearTxt.PlaceholderText = "Nhập năm sinh";
			this.birthYearTxt.SelectedText = "";
			this.birthYearTxt.ShadowDecoration.Parent = this.birthYearTxt;
			this.birthYearTxt.Size = new System.Drawing.Size(425, 36);
			this.birthYearTxt.TabIndex = 0;
			this.birthYearTxt.Leave += new System.EventHandler(this.birthYearTxt_Leave);
			// 
			// errorBirthYearMsg
			// 
			this.errorBirthYearMsg.AutoSize = true;
			this.errorBirthYearMsg.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed SemiB", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.errorBirthYearMsg.ForeColor = System.Drawing.Color.Red;
			this.errorBirthYearMsg.Location = new System.Drawing.Point(163, 49);
			this.errorBirthYearMsg.Name = "errorBirthYearMsg";
			this.errorBirthYearMsg.Size = new System.Drawing.Size(0, 30);
			this.errorBirthYearMsg.TabIndex = 7;
			// 
			// birthYearLine
			// 
			this.birthYearLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
			this.birthYearLine.Location = new System.Drawing.Point(160, 45);
			this.birthYearLine.Name = "birthYearLine";
			this.birthYearLine.Size = new System.Drawing.Size(414, 1);
			this.birthYearLine.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label4.Location = new System.Drawing.Point(3, 3);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(127, 49);
			this.label4.TabIndex = 5;
			this.label4.Text = "Năm sinh:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.errorPositionMsg);
			this.panel2.Controls.Add(this.label13);
			this.panel2.Controls.Add(this.positionCbx);
			this.panel2.Location = new System.Drawing.Point(603, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(594, 88);
			this.panel2.TabIndex = 3;
			// 
			// errorPositionMsg
			// 
			this.errorPositionMsg.AutoSize = true;
			this.errorPositionMsg.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed SemiB", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.errorPositionMsg.ForeColor = System.Drawing.Color.Red;
			this.errorPositionMsg.Location = new System.Drawing.Point(163, 52);
			this.errorPositionMsg.Name = "errorPositionMsg";
			this.errorPositionMsg.Size = new System.Drawing.Size(0, 30);
			this.errorPositionMsg.TabIndex = 27;
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label13.Location = new System.Drawing.Point(3, 3);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(109, 49);
			this.label13.TabIndex = 9;
			this.label13.Text = "Chức vụ:";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// positionCbx
			// 
			this.positionCbx.BackColor = System.Drawing.Color.Transparent;
			this.positionCbx.BaseColor = System.Drawing.Color.White;
			this.positionCbx.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.positionCbx.BorderSize = 1;
			this.positionCbx.Cursor = System.Windows.Forms.Cursors.Hand;
			this.positionCbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.positionCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.positionCbx.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
			this.positionCbx.Font = new System.Drawing.Font("#9Slide03 Cabin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.positionCbx.ForeColor = System.Drawing.Color.Black;
			this.positionCbx.FormattingEnabled = true;
			this.positionCbx.ItemHeight = 30;
			this.positionCbx.Location = new System.Drawing.Point(160, 12);
			this.positionCbx.Name = "positionCbx";
			this.positionCbx.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.positionCbx.OnHoverItemForeColor = System.Drawing.Color.White;
			this.positionCbx.Radius = 6;
			this.positionCbx.Size = new System.Drawing.Size(408, 36);
			this.positionCbx.TabIndex = 2;
			this.positionCbx.SelectedIndexChanged += new System.EventHandler(this.positionCbx_SelectedIndexChanged);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.staffNameTxt);
			this.panel1.Controls.Add(this.errorStaffNameMsg);
			this.panel1.Controls.Add(this.staffNameLine);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(594, 88);
			this.panel1.TabIndex = 0;
			// 
			// staffNameTxt
			// 
			this.staffNameTxt.BackColor = System.Drawing.Color.Transparent;
			this.staffNameTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
			this.staffNameTxt.BorderThickness = 0;
			this.staffNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.staffNameTxt.DefaultText = "";
			this.staffNameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.staffNameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.staffNameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.staffNameTxt.DisabledState.Parent = this.staffNameTxt;
			this.staffNameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.staffNameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.staffNameTxt.FocusedState.Parent = this.staffNameTxt;
			this.staffNameTxt.Font = new System.Drawing.Font("#9Slide03 Cabin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.staffNameTxt.ForeColor = System.Drawing.Color.Black;
			this.staffNameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.staffNameTxt.HoverState.Parent = this.staffNameTxt;
			this.staffNameTxt.Location = new System.Drawing.Point(149, 8);
			this.staffNameTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.staffNameTxt.Name = "staffNameTxt";
			this.staffNameTxt.PasswordChar = '\0';
			this.staffNameTxt.PlaceholderText = "Nhập tên nhân viên";
			this.staffNameTxt.SelectedText = "";
			this.staffNameTxt.ShadowDecoration.Parent = this.staffNameTxt;
			this.staffNameTxt.Size = new System.Drawing.Size(425, 36);
			this.staffNameTxt.TabIndex = 2;
			this.staffNameTxt.Leave += new System.EventHandler(this.staffNameTxt_Leave);
			// 
			// errorStaffNameMsg
			// 
			this.errorStaffNameMsg.AutoSize = true;
			this.errorStaffNameMsg.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed SemiB", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.errorStaffNameMsg.ForeColor = System.Drawing.Color.Red;
			this.errorStaffNameMsg.Location = new System.Drawing.Point(163, 50);
			this.errorStaffNameMsg.Name = "errorStaffNameMsg";
			this.errorStaffNameMsg.Size = new System.Drawing.Size(0, 30);
			this.errorStaffNameMsg.TabIndex = 7;
			// 
			// staffNameLine
			// 
			this.staffNameLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
			this.staffNameLine.Location = new System.Drawing.Point(160, 45);
			this.staffNameLine.Name = "staffNameLine";
			this.staffNameLine.Size = new System.Drawing.Size(414, 1);
			this.staffNameLine.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label3.Location = new System.Drawing.Point(3, 3);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(127, 49);
			this.label3.TabIndex = 5;
			this.label3.Text = "Tên nhân viên:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoScroll = true;
			this.flowLayoutPanel1.AutoScrollMargin = new System.Drawing.Size(10, 10);
			this.flowLayoutPanel1.Controls.Add(this.panel1);
			this.flowLayoutPanel1.Controls.Add(this.panel2);
			this.flowLayoutPanel1.Controls.Add(this.panel10);
			this.flowLayoutPanel1.Controls.Add(this.panel3);
			this.flowLayoutPanel1.Controls.Add(this.panel7);
			this.flowLayoutPanel1.Controls.Add(this.panel12);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 69);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(1200, 297);
			this.flowLayoutPanel1.TabIndex = 1;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.errorGenderMsg);
			this.panel3.Controls.Add(this.label16);
			this.panel3.Controls.Add(this.genderCbx);
			this.panel3.Location = new System.Drawing.Point(603, 97);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(594, 88);
			this.panel3.TabIndex = 4;
			// 
			// errorGenderMsg
			// 
			this.errorGenderMsg.AutoSize = true;
			this.errorGenderMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.errorGenderMsg.ForeColor = System.Drawing.Color.Red;
			this.errorGenderMsg.Location = new System.Drawing.Point(163, 52);
			this.errorGenderMsg.Name = "errorGenderMsg";
			this.errorGenderMsg.Size = new System.Drawing.Size(0, 25);
			this.errorGenderMsg.TabIndex = 30;
			// 
			// label16
			// 
			this.label16.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed", 12F);
			this.label16.Location = new System.Drawing.Point(3, 3);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(109, 49);
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
			this.genderCbx.ItemHeight = 30;
			this.genderCbx.Location = new System.Drawing.Point(160, 12);
			this.genderCbx.Name = "genderCbx";
			this.genderCbx.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.genderCbx.OnHoverItemForeColor = System.Drawing.Color.White;
			this.genderCbx.Radius = 6;
			this.genderCbx.Size = new System.Drawing.Size(408, 36);
			this.genderCbx.TabIndex = 4;
			this.genderCbx.SelectedIndexChanged += new System.EventHandler(this.genderCbx_SelectedIndexChanged);
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.phoneNumberTxt);
			this.panel7.Controls.Add(this.errorPhoneNumberMsg);
			this.panel7.Controls.Add(this.phoneNumberLine);
			this.panel7.Controls.Add(this.label8);
			this.panel7.Location = new System.Drawing.Point(3, 191);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(594, 88);
			this.panel7.TabIndex = 2;
			// 
			// phoneNumberTxt
			// 
			this.phoneNumberTxt.BackColor = System.Drawing.Color.Transparent;
			this.phoneNumberTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
			this.phoneNumberTxt.BorderThickness = 0;
			this.phoneNumberTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.phoneNumberTxt.DefaultText = "";
			this.phoneNumberTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.phoneNumberTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.phoneNumberTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.phoneNumberTxt.DisabledState.Parent = this.phoneNumberTxt;
			this.phoneNumberTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.phoneNumberTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.phoneNumberTxt.FocusedState.Parent = this.phoneNumberTxt;
			this.phoneNumberTxt.Font = new System.Drawing.Font("#9Slide03 Cabin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.phoneNumberTxt.ForeColor = System.Drawing.Color.Black;
			this.phoneNumberTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.phoneNumberTxt.HoverState.Parent = this.phoneNumberTxt;
			this.phoneNumberTxt.Location = new System.Drawing.Point(149, 7);
			this.phoneNumberTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.phoneNumberTxt.Name = "phoneNumberTxt";
			this.phoneNumberTxt.PasswordChar = '\0';
			this.phoneNumberTxt.PlaceholderText = "Nhập số điện thoại";
			this.phoneNumberTxt.SelectedText = "";
			this.phoneNumberTxt.ShadowDecoration.Parent = this.phoneNumberTxt;
			this.phoneNumberTxt.Size = new System.Drawing.Size(425, 36);
			this.phoneNumberTxt.TabIndex = 5;
			this.phoneNumberTxt.Leave += new System.EventHandler(this.phoneNumberTxt_Leave);
			// 
			// errorPhoneNumberMsg
			// 
			this.errorPhoneNumberMsg.AutoSize = true;
			this.errorPhoneNumberMsg.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed SemiB", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.errorPhoneNumberMsg.ForeColor = System.Drawing.Color.Red;
			this.errorPhoneNumberMsg.Location = new System.Drawing.Point(163, 49);
			this.errorPhoneNumberMsg.Name = "errorPhoneNumberMsg";
			this.errorPhoneNumberMsg.Size = new System.Drawing.Size(0, 30);
			this.errorPhoneNumberMsg.TabIndex = 7;
			// 
			// phoneNumberLine
			// 
			this.phoneNumberLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
			this.phoneNumberLine.Location = new System.Drawing.Point(160, 45);
			this.phoneNumberLine.Name = "phoneNumberLine";
			this.phoneNumberLine.Size = new System.Drawing.Size(414, 1);
			this.phoneNumberLine.TabIndex = 8;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label8.Location = new System.Drawing.Point(3, 3);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(127, 49);
			this.label8.TabIndex = 5;
			this.label8.Text = "Số điện thoại";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel12
			// 
			this.panel12.Controls.Add(this.salaryTxt);
			this.panel12.Controls.Add(this.errorSalaryMsg);
			this.panel12.Controls.Add(this.salaryLine);
			this.panel12.Controls.Add(this.label10);
			this.panel12.Location = new System.Drawing.Point(603, 191);
			this.panel12.Name = "panel12";
			this.panel12.Size = new System.Drawing.Size(594, 88);
			this.panel12.TabIndex = 5;
			// 
			// salaryTxt
			// 
			this.salaryTxt.BackColor = System.Drawing.Color.Transparent;
			this.salaryTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
			this.salaryTxt.BorderThickness = 0;
			this.salaryTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.salaryTxt.DefaultText = "";
			this.salaryTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.salaryTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.salaryTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.salaryTxt.DisabledState.Parent = this.salaryTxt;
			this.salaryTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.salaryTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.salaryTxt.FocusedState.Parent = this.salaryTxt;
			this.salaryTxt.Font = new System.Drawing.Font("#9Slide03 Cabin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.salaryTxt.ForeColor = System.Drawing.Color.Black;
			this.salaryTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.salaryTxt.HoverState.Parent = this.salaryTxt;
			this.salaryTxt.Location = new System.Drawing.Point(149, 7);
			this.salaryTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.salaryTxt.Name = "salaryTxt";
			this.salaryTxt.PasswordChar = '\0';
			this.salaryTxt.PlaceholderText = "Nhập lương";
			this.salaryTxt.SelectedText = "";
			this.salaryTxt.ShadowDecoration.Parent = this.salaryTxt;
			this.salaryTxt.Size = new System.Drawing.Size(419, 36);
			this.salaryTxt.TabIndex = 6;
			this.salaryTxt.Leave += new System.EventHandler(this.salaryTxt_Leave);
			// 
			// errorSalaryMsg
			// 
			this.errorSalaryMsg.AutoSize = true;
			this.errorSalaryMsg.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed SemiB", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.errorSalaryMsg.ForeColor = System.Drawing.Color.Red;
			this.errorSalaryMsg.Location = new System.Drawing.Point(163, 49);
			this.errorSalaryMsg.Name = "errorSalaryMsg";
			this.errorSalaryMsg.Size = new System.Drawing.Size(0, 30);
			this.errorSalaryMsg.TabIndex = 7;
			// 
			// salaryLine
			// 
			this.salaryLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
			this.salaryLine.Location = new System.Drawing.Point(160, 45);
			this.salaryLine.Name = "salaryLine";
			this.salaryLine.Size = new System.Drawing.Size(408, 1);
			this.salaryLine.TabIndex = 8;
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label10.Location = new System.Drawing.Point(3, 3);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(109, 49);
			this.label10.TabIndex = 5;
			this.label10.Text = "Lương:";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.submitBtn.Location = new System.Drawing.Point(631, 407);
			this.submitBtn.Name = "submitBtn";
			this.submitBtn.OnHoverBaseColor = System.Drawing.Color.White;
			this.submitBtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.submitBtn.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.submitBtn.OnHoverImage = null;
			this.submitBtn.OnPressedColor = System.Drawing.Color.Black;
			this.submitBtn.Radius = 22;
			this.submitBtn.Size = new System.Drawing.Size(200, 50);
			this.submitBtn.TabIndex = 8;
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
			this.cancelBtn.Location = new System.Drawing.Point(397, 407);
			this.cancelBtn.Name = "cancelBtn";
			this.cancelBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.cancelBtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.cancelBtn.OnHoverForeColor = System.Drawing.Color.White;
			this.cancelBtn.OnHoverImage = null;
			this.cancelBtn.OnPressedColor = System.Drawing.Color.White;
			this.cancelBtn.Radius = 22;
			this.cancelBtn.Size = new System.Drawing.Size(200, 50);
			this.cancelBtn.TabIndex = 7;
			this.cancelBtn.Text = "Hủy";
			this.cancelBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("#9Slide03 Cabin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1222, 45);
			this.label1.TabIndex = 5;
			this.label1.Text = "Thêm Nhân Viên";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// StaffModal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1222, 489);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.submitBtn);
			this.Controls.Add(this.cancelBtn);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "StaffModal";
			this.Text = "Thêm nhân viên";
			this.Load += new System.EventHandler(this.StaffModal_Load);
			this.panel10.ResumeLayout(false);
			this.panel10.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel7.ResumeLayout(false);
			this.panel7.PerformLayout();
			this.panel12.ResumeLayout(false);
			this.panel12.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel10;
        private Guna.UI2.WinForms.Guna2TextBox birthYearTxt;
        private System.Windows.Forms.Label errorBirthYearMsg;
        private System.Windows.Forms.Panel birthYearLine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label errorPositionMsg;
        private System.Windows.Forms.Label label13;
        private Guna.UI.WinForms.GunaComboBox positionCbx;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox staffNameTxt;
        private System.Windows.Forms.Label errorStaffNameMsg;
        private System.Windows.Forms.Panel staffNameLine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel7;
        private Guna.UI2.WinForms.Guna2TextBox phoneNumberTxt;
        private System.Windows.Forms.Label errorPhoneNumberMsg;
        private System.Windows.Forms.Panel phoneNumberLine;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel12;
        private Guna.UI2.WinForms.Guna2TextBox salaryTxt;
        private System.Windows.Forms.Label errorSalaryMsg;
        private System.Windows.Forms.Panel salaryLine;
        private System.Windows.Forms.Label label10;
        private Guna.UI.WinForms.GunaButton submitBtn;
        private Guna.UI.WinForms.GunaButton cancelBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label errorGenderMsg;
        private System.Windows.Forms.Label label16;
        private Guna.UI.WinForms.GunaComboBox genderCbx;
    }
}