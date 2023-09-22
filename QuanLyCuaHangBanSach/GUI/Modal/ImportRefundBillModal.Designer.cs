namespace QuanLyCuaHangBanSach.GUI.Modal
{
	partial class ImportRefundBillModal
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
			this.components = new System.ComponentModel.Container();
			this.panel1 = new System.Windows.Forms.Panel();
			this.importBookContainer = new System.Windows.Forms.FlowLayoutPanel();
			this.label2 = new System.Windows.Forms.Label();
			this.importBillInput = new Guna.UI.WinForms.GunaLineTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.supplierNameTxt = new Guna.UI2.WinForms.Guna2TextBox();
			this.supplierNameMsg = new System.Windows.Forms.Label();
			this.supplierNameLine = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.staffTxt = new Guna.UI2.WinForms.Guna2TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.panel6 = new System.Windows.Forms.Panel();
			this.dateTimeTo = new Guna.UI.WinForms.GunaDateTimePicker();
			this.dateTimeToLine = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.reasonTxt = new Guna.UI2.WinForms.Guna2TextBox();
			this.reasonMsg = new System.Windows.Forms.Label();
			this.reasonLine = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.totalMoney = new Guna.UI2.WinForms.Guna2TextBox();
			this.panel9 = new System.Windows.Forms.Panel();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.refundBookContainer = new System.Windows.Forms.FlowLayoutPanel();
			this.submitBtn = new Guna.UI.WinForms.GunaButton();
			this.cancelBtn = new Guna.UI.WinForms.GunaButton();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.panel1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel8.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.importBookContainer);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.importBillInput);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(1140, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(400, 602);
			this.panel1.TabIndex = 0;
			// 
			// importBookContainer
			// 
			this.importBookContainer.AutoScroll = true;
			this.importBookContainer.Location = new System.Drawing.Point(0, 197);
			this.importBookContainer.Margin = new System.Windows.Forms.Padding(4);
			this.importBookContainer.Name = "importBookContainer";
			this.importBookContainer.Size = new System.Drawing.Size(400, 388);
			this.importBookContainer.TabIndex = 21;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("#9Slide03 Cabin Bold", 16F, System.Drawing.FontStyle.Bold);
			this.label2.Location = new System.Drawing.Point(14, 131);
			this.label2.Margin = new System.Windows.Forms.Padding(27, 37, 4, 6);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(253, 40);
			this.label2.TabIndex = 3;
			this.label2.Text = "Danh sách sản phẩm";
			// 
			// importBillInput
			// 
			this.importBillInput.BackColor = System.Drawing.SystemColors.Window;
			this.importBillInput.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.importBillInput.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.importBillInput.Font = new System.Drawing.Font("#9Slide03 Cabin", 12F);
			this.importBillInput.ForeColor = System.Drawing.Color.DarkGray;
			this.importBillInput.LineColor = System.Drawing.Color.Black;
			this.importBillInput.LineSize = 1;
			this.importBillInput.Location = new System.Drawing.Point(21, 50);
			this.importBillInput.Margin = new System.Windows.Forms.Padding(4);
			this.importBillInput.Name = "importBillInput";
			this.importBillInput.PasswordChar = '\0';
			this.importBillInput.SelectedText = "";
			this.importBillInput.Size = new System.Drawing.Size(325, 49);
			this.importBillInput.TabIndex = 2;
			this.importBillInput.TextChanged += new System.EventHandler(this.importBillInput_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("#9Slide03 Cabin Bold", 16F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(14, 9);
			this.label1.Margin = new System.Windows.Forms.Padding(27, 37, 4, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(147, 40);
			this.label1.TabIndex = 0;
			this.label1.Text = "Phiếu nhập";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoScroll = true;
			this.flowLayoutPanel1.AutoScrollMargin = new System.Drawing.Size(10, 10);
			this.flowLayoutPanel1.Controls.Add(this.panel2);
			this.flowLayoutPanel1.Controls.Add(this.panel3);
			this.flowLayoutPanel1.Controls.Add(this.panel4);
			this.flowLayoutPanel1.Controls.Add(this.panel6);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(25, 12);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(1094, 211);
			this.flowLayoutPanel1.TabIndex = 3;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Controls.Add(this.supplierNameTxt);
			this.panel2.Controls.Add(this.supplierNameMsg);
			this.panel2.Controls.Add(this.supplierNameLine);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Location = new System.Drawing.Point(5, 10);
			this.panel2.Margin = new System.Windows.Forms.Padding(5, 10, 5, 20);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(505, 88);
			this.panel2.TabIndex = 1;
			// 
			// supplierNameTxt
			// 
			this.supplierNameTxt.BackColor = System.Drawing.Color.Transparent;
			this.supplierNameTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
			this.supplierNameTxt.BorderThickness = 0;
			this.supplierNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.supplierNameTxt.DefaultText = "";
			this.supplierNameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.supplierNameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.supplierNameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.supplierNameTxt.DisabledState.Parent = this.supplierNameTxt;
			this.supplierNameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.supplierNameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.supplierNameTxt.FocusedState.Parent = this.supplierNameTxt;
			this.supplierNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.supplierNameTxt.ForeColor = System.Drawing.Color.Black;
			this.supplierNameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.supplierNameTxt.HoverState.Parent = this.supplierNameTxt;
			this.supplierNameTxt.Location = new System.Drawing.Point(168, 8);
			this.supplierNameTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.supplierNameTxt.Name = "supplierNameTxt";
			this.supplierNameTxt.PasswordChar = '\0';
			this.supplierNameTxt.PlaceholderText = "Nhà cung cấp";
			this.supplierNameTxt.ReadOnly = true;
			this.supplierNameTxt.SelectedText = "";
			this.supplierNameTxt.ShadowDecoration.Parent = this.supplierNameTxt;
			this.supplierNameTxt.Size = new System.Drawing.Size(332, 36);
			this.supplierNameTxt.TabIndex = 32;
			// 
			// supplierNameMsg
			// 
			this.supplierNameMsg.AutoSize = true;
			this.supplierNameMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.supplierNameMsg.ForeColor = System.Drawing.Color.Red;
			this.supplierNameMsg.Location = new System.Drawing.Point(12, 52);
			this.supplierNameMsg.Name = "supplierNameMsg";
			this.supplierNameMsg.Size = new System.Drawing.Size(0, 25);
			this.supplierNameMsg.TabIndex = 7;
			// 
			// supplierNameLine
			// 
			this.supplierNameLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
			this.supplierNameLine.Location = new System.Drawing.Point(168, 45);
			this.supplierNameLine.Name = "supplierNameLine";
			this.supplierNameLine.Size = new System.Drawing.Size(300, 1);
			this.supplierNameLine.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label3.Location = new System.Drawing.Point(3, 3);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(188, 49);
			this.label3.TabIndex = 5;
			this.label3.Text = "Tên nhà cung cấp";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.White;
			this.panel4.Controls.Add(this.panel5);
			this.panel4.Controls.Add(this.staffTxt);
			this.panel4.Controls.Add(this.label5);
			this.panel4.Location = new System.Drawing.Point(5, 128);
			this.panel4.Margin = new System.Windows.Forms.Padding(5, 10, 5, 20);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(518, 60);
			this.panel4.TabIndex = 3;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
			this.panel5.Location = new System.Drawing.Point(152, 45);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(250, 1);
			this.panel5.TabIndex = 34;
			// 
			// staffTxt
			// 
			this.staffTxt.BackColor = System.Drawing.Color.Transparent;
			this.staffTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
			this.staffTxt.BorderThickness = 0;
			this.staffTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.staffTxt.DefaultText = "";
			this.staffTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.staffTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.staffTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.staffTxt.DisabledState.Parent = this.staffTxt;
			this.staffTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.staffTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.staffTxt.FocusedState.Parent = this.staffTxt;
			this.staffTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.staffTxt.ForeColor = System.Drawing.Color.Black;
			this.staffTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.staffTxt.HoverState.Parent = this.staffTxt;
			this.staffTxt.Location = new System.Drawing.Point(145, 10);
			this.staffTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.staffTxt.Name = "staffTxt";
			this.staffTxt.PasswordChar = '\0';
			this.staffTxt.PlaceholderText = "Nhân viên lập";
			this.staffTxt.SelectedText = "";
			this.staffTxt.ShadowDecoration.Parent = this.staffTxt;
			this.staffTxt.Size = new System.Drawing.Size(257, 36);
			this.staffTxt.TabIndex = 33;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label5.Location = new System.Drawing.Point(3, 3);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(167, 49);
			this.label5.TabIndex = 5;
			this.label5.Text = "Nhân viên lập:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.White;
			this.panel6.Controls.Add(this.dateTimeTo);
			this.panel6.Controls.Add(this.dateTimeToLine);
			this.panel6.Controls.Add(this.label7);
			this.panel6.Location = new System.Drawing.Point(533, 128);
			this.panel6.Margin = new System.Windows.Forms.Padding(5, 10, 5, 20);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(394, 60);
			this.panel6.TabIndex = 4;
			// 
			// dateTimeTo
			// 
			this.dateTimeTo.BackColor = System.Drawing.Color.Transparent;
			this.dateTimeTo.BaseColor = System.Drawing.Color.White;
			this.dateTimeTo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.dateTimeTo.BorderSize = 1;
			this.dateTimeTo.CustomFormat = null;
			this.dateTimeTo.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
			this.dateTimeTo.Enabled = false;
			this.dateTimeTo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.dateTimeTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.dateTimeTo.ForeColor = System.Drawing.Color.Black;
			this.dateTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimeTo.Location = new System.Drawing.Point(160, 7);
			this.dateTimeTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.dateTimeTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.dateTimeTo.Name = "dateTimeTo";
			this.dateTimeTo.OnHoverBaseColor = System.Drawing.Color.White;
			this.dateTimeTo.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.dateTimeTo.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.dateTimeTo.OnPressedColor = System.Drawing.Color.Black;
			this.dateTimeTo.Size = new System.Drawing.Size(154, 39);
			this.dateTimeTo.TabIndex = 10;
			this.dateTimeTo.Text = "9/10/2023";
			this.dateTimeTo.Value = new System.DateTime(2023, 9, 10, 15, 52, 49, 679);
			// 
			// dateTimeToLine
			// 
			this.dateTimeToLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
			this.dateTimeToLine.Location = new System.Drawing.Point(160, 45);
			this.dateTimeToLine.Name = "dateTimeToLine";
			this.dateTimeToLine.Size = new System.Drawing.Size(150, 1);
			this.dateTimeToLine.TabIndex = 8;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label7.Location = new System.Drawing.Point(3, 3);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(167, 49);
			this.label7.TabIndex = 5;
			this.label7.Text = "Ngày lập:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.White;
			this.panel3.Controls.Add(this.reasonTxt);
			this.panel3.Controls.Add(this.reasonMsg);
			this.panel3.Controls.Add(this.reasonLine);
			this.panel3.Controls.Add(this.label6);
			this.panel3.Location = new System.Drawing.Point(520, 10);
			this.panel3.Margin = new System.Windows.Forms.Padding(5, 10, 5, 20);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(492, 88);
			this.panel3.TabIndex = 4;
			// 
			// reasonTxt
			// 
			this.reasonTxt.BackColor = System.Drawing.Color.Transparent;
			this.reasonTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
			this.reasonTxt.BorderThickness = 0;
			this.reasonTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.reasonTxt.DefaultText = "";
			this.reasonTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.reasonTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.reasonTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.reasonTxt.DisabledState.Parent = this.reasonTxt;
			this.reasonTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.reasonTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.reasonTxt.FocusedState.Parent = this.reasonTxt;
			this.reasonTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.reasonTxt.ForeColor = System.Drawing.Color.Black;
			this.reasonTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.reasonTxt.HoverState.Parent = this.reasonTxt;
			this.reasonTxt.Location = new System.Drawing.Point(168, 8);
			this.reasonTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.reasonTxt.Name = "reasonTxt";
			this.reasonTxt.PasswordChar = '\0';
			this.reasonTxt.PlaceholderText = "Nhập lý do...";
			this.reasonTxt.SelectedText = "";
			this.reasonTxt.ShadowDecoration.Parent = this.reasonTxt;
			this.reasonTxt.Size = new System.Drawing.Size(305, 36);
			this.reasonTxt.TabIndex = 32;
			// 
			// reasonMsg
			// 
			this.reasonMsg.AutoSize = true;
			this.reasonMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.reasonMsg.ForeColor = System.Drawing.Color.Red;
			this.reasonMsg.Location = new System.Drawing.Point(163, 50);
			this.reasonMsg.Name = "reasonMsg";
			this.reasonMsg.Size = new System.Drawing.Size(0, 25);
			this.reasonMsg.TabIndex = 7;
			// 
			// reasonLine
			// 
			this.reasonLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
			this.reasonLine.Location = new System.Drawing.Point(168, 45);
			this.reasonLine.Name = "reasonLine";
			this.reasonLine.Size = new System.Drawing.Size(300, 1);
			this.reasonLine.TabIndex = 8;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label6.Location = new System.Drawing.Point(3, 3);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(188, 49);
			this.label6.TabIndex = 5;
			this.label6.Text = "Lý do:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.White;
			this.panel8.Controls.Add(this.totalMoney);
			this.panel8.Controls.Add(this.panel9);
			this.panel8.Controls.Add(this.label9);
			this.panel8.Location = new System.Drawing.Point(1140, 627);
			this.panel8.Margin = new System.Windows.Forms.Padding(5, 10, 5, 20);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(400, 88);
			this.panel8.TabIndex = 5;
			// 
			// totalMoney
			// 
			this.totalMoney.BackColor = System.Drawing.Color.Transparent;
			this.totalMoney.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
			this.totalMoney.BorderThickness = 0;
			this.totalMoney.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.totalMoney.DefaultText = "0 ";
			this.totalMoney.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.totalMoney.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.totalMoney.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.totalMoney.DisabledState.Parent = this.totalMoney;
			this.totalMoney.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.totalMoney.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.totalMoney.FocusedState.Parent = this.totalMoney;
			this.totalMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.totalMoney.ForeColor = System.Drawing.Color.Black;
			this.totalMoney.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.totalMoney.HoverState.Parent = this.totalMoney;
			this.totalMoney.Location = new System.Drawing.Point(168, 8);
			this.totalMoney.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.totalMoney.Name = "totalMoney";
			this.totalMoney.PasswordChar = '\0';
			this.totalMoney.PlaceholderText = "Nhà cung cấp";
			this.totalMoney.ReadOnly = true;
			this.totalMoney.SelectedText = "";
			this.totalMoney.SelectionStart = 2;
			this.totalMoney.ShadowDecoration.Parent = this.totalMoney;
			this.totalMoney.Size = new System.Drawing.Size(186, 36);
			this.totalMoney.TabIndex = 32;
			// 
			// panel9
			// 
			this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
			this.panel9.Location = new System.Drawing.Point(168, 45);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(200, 1);
			this.panel9.TabIndex = 8;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("#9Slide03 Cabin", 18F);
			this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.label9.Location = new System.Drawing.Point(3, 3);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(160, 49);
			this.label9.TabIndex = 5;
			this.label9.Text = "Tổng tiền:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("#9Slide03 Cabin", 16F);
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(23, 226);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(232, 49);
			this.label8.TabIndex = 6;
			this.label8.Text = "Danh sách trả :";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// refundBookContainer
			// 
			this.refundBookContainer.AutoScroll = true;
			this.refundBookContainer.Location = new System.Drawing.Point(25, 278);
			this.refundBookContainer.Name = "refundBookContainer";
			this.refundBookContainer.Size = new System.Drawing.Size(1089, 437);
			this.refundBookContainer.TabIndex = 7;
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
			this.submitBtn.FocusedColor = System.Drawing.Color.Empty;
			this.submitBtn.Font = new System.Drawing.Font("#9Slide03 Cabin Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.submitBtn.ForeColor = System.Drawing.Color.White;
			this.submitBtn.Image = null;
			this.submitBtn.ImageSize = new System.Drawing.Size(20, 20);
			this.submitBtn.Location = new System.Drawing.Point(914, 766);
			this.submitBtn.Name = "submitBtn";
			this.submitBtn.OnHoverBaseColor = System.Drawing.Color.White;
			this.submitBtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.submitBtn.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.submitBtn.OnHoverImage = null;
			this.submitBtn.OnPressedColor = System.Drawing.Color.Black;
			this.submitBtn.Radius = 22;
			this.submitBtn.Size = new System.Drawing.Size(200, 50);
			this.submitBtn.TabIndex = 9;
			this.submitBtn.TabStop = false;
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
			this.cancelBtn.FocusedColor = System.Drawing.Color.Empty;
			this.cancelBtn.Font = new System.Drawing.Font("#9Slide03 Cabin Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.cancelBtn.Image = null;
			this.cancelBtn.ImageSize = new System.Drawing.Size(20, 20);
			this.cancelBtn.Location = new System.Drawing.Point(652, 766);
			this.cancelBtn.Name = "cancelBtn";
			this.cancelBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.cancelBtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.cancelBtn.OnHoverForeColor = System.Drawing.Color.White;
			this.cancelBtn.OnHoverImage = null;
			this.cancelBtn.OnPressedColor = System.Drawing.Color.White;
			this.cancelBtn.Radius = 22;
			this.cancelBtn.Size = new System.Drawing.Size(200, 50);
			this.cancelBtn.TabIndex = 8;
			this.cancelBtn.TabStop = false;
			this.cancelBtn.Text = "Hủy";
			this.cancelBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// ImportRefundBillModal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1542, 838);
			this.Controls.Add(this.panel8);
			this.Controls.Add(this.submitBtn);
			this.Controls.Add(this.cancelBtn);
			this.Controls.Add(this.refundBookContainer);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("#9Slide03 Cabin", 9F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "ImportRefundBillModal";
			this.Text = "Thêm phiếu trả nhập hàng";
			this.Load += new System.EventHandler(this.ImportRefundBillModal_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel8.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.FlowLayoutPanel importBookContainer;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Panel panel2;
		private Guna.UI2.WinForms.Guna2TextBox supplierNameTxt;
		private System.Windows.Forms.Label supplierNameMsg;
		private System.Windows.Forms.Panel supplierNameLine;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel6;
		private Guna.UI.WinForms.GunaDateTimePicker dateTimeTo;
		private System.Windows.Forms.Panel dateTimeToLine;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Panel panel5;
		private Guna.UI2.WinForms.Guna2TextBox staffTxt;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label reasonMsg;
		private System.Windows.Forms.Panel reasonLine;
		private System.Windows.Forms.Label label6;
		private Guna.UI2.WinForms.Guna2TextBox reasonTxt;
		private System.Windows.Forms.Panel panel8;
		private Guna.UI2.WinForms.Guna2TextBox totalMoney;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.FlowLayoutPanel refundBookContainer;
		private Guna.UI.WinForms.GunaButton submitBtn;
		private Guna.UI.WinForms.GunaButton cancelBtn;
		private Guna.UI.WinForms.GunaLineTextBox importBillInput;
		private System.Windows.Forms.Timer timer1;
	}
}