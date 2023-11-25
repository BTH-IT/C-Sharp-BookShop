namespace QuanLyCuaHangBanSach.GUI.Manager
{
	partial class OrderBillManagerGUI
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderBillManagerGUI));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel6 = new System.Windows.Forms.Panel();
			this.supplierCbx = new Guna.UI.WinForms.GunaComboBox();
			this.staffCbx = new Guna.UI.WinForms.GunaComboBox();
			this.panel5 = new System.Windows.Forms.Panel();
			this.filterCkx = new Guna.UI.WinForms.GunaMediumCheckBox();
			this.dateTimeTo = new Guna.UI.WinForms.GunaDateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dateTimeFrom = new Guna.UI.WinForms.GunaDateTimePicker();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.line1 = new System.Windows.Forms.Panel();
			this.searchInput = new Guna.UI2.WinForms.Guna2TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.printPdfBtn = new Guna.UI.WinForms.GunaAdvenceButton();
			this.viewMoreBtn = new Guna.UI.WinForms.GunaAdvenceButton();
			this.exportBtn = new Guna.UI.WinForms.GunaAdvenceButton();
			this.refreshBtn = new Guna.UI.WinForms.GunaAdvenceButton();
			this.dgvOrderBill = new Guna.UI.WinForms.GunaDataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.trangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel6.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvOrderBill)).BeginInit();
			this.SuspendLayout();
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.supplierCbx);
			this.panel6.Controls.Add(this.staffCbx);
			this.panel6.Controls.Add(this.panel5);
			this.panel6.Controls.Add(this.pictureBox1);
			this.panel6.Controls.Add(this.line1);
			this.panel6.Controls.Add(this.searchInput);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel6.Location = new System.Drawing.Point(0, 0);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(1044, 122);
			this.panel6.TabIndex = 2;
			this.panel6.TabStop = true;
			// 
			// supplierCbx
			// 
			this.supplierCbx.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.supplierCbx.BackColor = System.Drawing.Color.Transparent;
			this.supplierCbx.BaseColor = System.Drawing.Color.White;
			this.supplierCbx.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.supplierCbx.BorderSize = 1;
			this.supplierCbx.Cursor = System.Windows.Forms.Cursors.Hand;
			this.supplierCbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.supplierCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.supplierCbx.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
			this.supplierCbx.Font = new System.Drawing.Font("#9Slide03 Cabin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.supplierCbx.ForeColor = System.Drawing.Color.Black;
			this.supplierCbx.FormattingEnabled = true;
			this.supplierCbx.IntegralHeight = false;
			this.supplierCbx.ItemHeight = 30;
			this.supplierCbx.Location = new System.Drawing.Point(633, 73);
			this.supplierCbx.MaxDropDownItems = 10;
			this.supplierCbx.Name = "supplierCbx";
			this.supplierCbx.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.supplierCbx.OnHoverItemForeColor = System.Drawing.Color.White;
			this.supplierCbx.Radius = 6;
			this.supplierCbx.Size = new System.Drawing.Size(200, 36);
			this.supplierCbx.TabIndex = 8;
			this.supplierCbx.SelectedIndexChanged += new System.EventHandler(this.supplierCbx_SelectedIndexChanged);
			// 
			// staffCbx
			// 
			this.staffCbx.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.staffCbx.BackColor = System.Drawing.Color.Transparent;
			this.staffCbx.BaseColor = System.Drawing.Color.White;
			this.staffCbx.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.staffCbx.BorderSize = 1;
			this.staffCbx.Cursor = System.Windows.Forms.Cursors.Hand;
			this.staffCbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.staffCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.staffCbx.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
			this.staffCbx.Font = new System.Drawing.Font("#9Slide03 Cabin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.staffCbx.ForeColor = System.Drawing.Color.Black;
			this.staffCbx.FormattingEnabled = true;
			this.staffCbx.IntegralHeight = false;
			this.staffCbx.ItemHeight = 30;
			this.staffCbx.Location = new System.Drawing.Point(839, 73);
			this.staffCbx.MaxDropDownItems = 10;
			this.staffCbx.Name = "staffCbx";
			this.staffCbx.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.staffCbx.OnHoverItemForeColor = System.Drawing.Color.White;
			this.staffCbx.Radius = 6;
			this.staffCbx.Size = new System.Drawing.Size(194, 36);
			this.staffCbx.TabIndex = 9;
			this.staffCbx.SelectedIndexChanged += new System.EventHandler(this.staffCbx_SelectedIndexChanged);
			// 
			// panel5
			// 
			this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.panel5.Controls.Add(this.filterCkx);
			this.panel5.Controls.Add(this.dateTimeTo);
			this.panel5.Controls.Add(this.label3);
			this.panel5.Controls.Add(this.label2);
			this.panel5.Controls.Add(this.dateTimeFrom);
			this.panel5.Location = new System.Drawing.Point(633, 15);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(400, 36);
			this.panel5.TabIndex = 2;
			// 
			// filterCkx
			// 
			this.filterCkx.BaseColor = System.Drawing.Color.White;
			this.filterCkx.CheckedOffColor = System.Drawing.Color.LightGray;
			this.filterCkx.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.filterCkx.FillColor = System.Drawing.Color.White;
			this.filterCkx.Location = new System.Drawing.Point(17, 9);
			this.filterCkx.Name = "filterCkx";
			this.filterCkx.Size = new System.Drawing.Size(20, 20);
			this.filterCkx.TabIndex = 2;
			this.filterCkx.TabStop = false;
			this.filterCkx.CheckedChanged += new System.EventHandler(this.filterCkx_CheckedChanged);
			// 
			// dateTimeTo
			// 
			this.dateTimeTo.BackColor = System.Drawing.Color.Transparent;
			this.dateTimeTo.BaseColor = System.Drawing.Color.White;
			this.dateTimeTo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.dateTimeTo.BorderSize = 1;
			this.dateTimeTo.CustomFormat = null;
			this.dateTimeTo.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
			this.dateTimeTo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
			this.dateTimeTo.Font = new System.Drawing.Font("#9Slide03 Cabin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimeTo.ForeColor = System.Drawing.Color.Black;
			this.dateTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimeTo.Location = new System.Drawing.Point(270, 0);
			this.dateTimeTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.dateTimeTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.dateTimeTo.Name = "dateTimeTo";
			this.dateTimeTo.OnHoverBaseColor = System.Drawing.Color.White;
			this.dateTimeTo.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.dateTimeTo.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.dateTimeTo.OnPressedColor = System.Drawing.Color.Black;
			this.dateTimeTo.Radius = 6;
			this.dateTimeTo.Size = new System.Drawing.Size(130, 36);
			this.dateTimeTo.TabIndex = 4;
			this.dateTimeTo.Text = "8/30/2023";
			this.dateTimeTo.Value = new System.DateTime(2023, 8, 30, 19, 55, 8, 854);
			this.dateTimeTo.ValueChanged += new System.EventHandler(this.dateTimeTo_ValueChanged);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("#9Slide03 Cabin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(217, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 36);
			this.label3.TabIndex = 41;
			this.label3.Text = "- Đến :";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("#9Slide03 Cabin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(43, -1);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 37);
			this.label2.TabIndex = 0;
			this.label2.Text = "Từ :";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dateTimeFrom
			// 
			this.dateTimeFrom.BackColor = System.Drawing.Color.Transparent;
			this.dateTimeFrom.BaseColor = System.Drawing.Color.White;
			this.dateTimeFrom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.dateTimeFrom.BorderSize = 1;
			this.dateTimeFrom.CustomFormat = null;
			this.dateTimeFrom.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
			this.dateTimeFrom.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
			this.dateTimeFrom.Font = new System.Drawing.Font("#9Slide03 Cabin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimeFrom.ForeColor = System.Drawing.Color.Black;
			this.dateTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimeFrom.Location = new System.Drawing.Point(81, 0);
			this.dateTimeFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.dateTimeFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.dateTimeFrom.Name = "dateTimeFrom";
			this.dateTimeFrom.OnHoverBaseColor = System.Drawing.Color.White;
			this.dateTimeFrom.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.dateTimeFrom.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.dateTimeFrom.OnPressedColor = System.Drawing.Color.Black;
			this.dateTimeFrom.Radius = 6;
			this.dateTimeFrom.Size = new System.Drawing.Size(130, 36);
			this.dateTimeFrom.TabIndex = 3;
			this.dateTimeFrom.Text = "8/30/2023";
			this.dateTimeFrom.Value = new System.DateTime(2023, 8, 30, 19, 55, 8, 854);
			this.dateTimeFrom.ValueChanged += new System.EventHandler(this.dateTimeFrom_ValueChanged);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(363, 17);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(36, 30);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 44;
			this.pictureBox1.TabStop = false;
			// 
			// line1
			// 
			this.line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
			this.line1.Location = new System.Drawing.Point(16, 52);
			this.line1.Name = "line1";
			this.line1.Size = new System.Drawing.Size(384, 1);
			this.line1.TabIndex = 43;
			// 
			// searchInput
			// 
			this.searchInput.BackColor = System.Drawing.Color.Transparent;
			this.searchInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
			this.searchInput.BorderThickness = 0;
			this.searchInput.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.searchInput.DefaultText = "";
			this.searchInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.searchInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.searchInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.searchInput.DisabledState.Parent = this.searchInput;
			this.searchInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.searchInput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
			this.searchInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.searchInput.FocusedState.Parent = this.searchInput;
			this.searchInput.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed", 11.25F);
			this.searchInput.ForeColor = System.Drawing.Color.Black;
			this.searchInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.searchInput.HoverState.Parent = this.searchInput;
			this.searchInput.Location = new System.Drawing.Point(6, 15);
			this.searchInput.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.searchInput.Name = "searchInput";
			this.searchInput.PasswordChar = '\0';
			this.searchInput.PlaceholderText = "Tìm kiếm theo mã đơn";
			this.searchInput.SelectedText = "";
			this.searchInput.ShadowDecoration.Parent = this.searchInput;
			this.searchInput.Size = new System.Drawing.Size(350, 32);
			this.searchInput.TabIndex = 1;
			this.searchInput.TextChanged += new System.EventHandler(this.searchInput_TextChanged);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
			this.panel1.Controls.Add(this.printPdfBtn);
			this.panel1.Controls.Add(this.viewMoreBtn);
			this.panel1.Controls.Add(this.exportBtn);
			this.panel1.Controls.Add(this.refreshBtn);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 630);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1044, 54);
			this.panel1.TabIndex = 4;
			// 
			// printPdfBtn
			// 
			this.printPdfBtn.AnimationHoverSpeed = 0.07F;
			this.printPdfBtn.AnimationSpeed = 0.03F;
			this.printPdfBtn.BackColor = System.Drawing.Color.Transparent;
			this.printPdfBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.printPdfBtn.BorderColor = System.Drawing.Color.Black;
			this.printPdfBtn.CheckedBaseColor = System.Drawing.Color.Gray;
			this.printPdfBtn.CheckedBorderColor = System.Drawing.Color.Black;
			this.printPdfBtn.CheckedForeColor = System.Drawing.Color.White;
			this.printPdfBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("printPdfBtn.CheckedImage")));
			this.printPdfBtn.CheckedLineColor = System.Drawing.Color.DimGray;
			this.printPdfBtn.DialogResult = System.Windows.Forms.DialogResult.None;
			this.printPdfBtn.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
			this.printPdfBtn.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.printPdfBtn.ForeColor = System.Drawing.Color.White;
			this.printPdfBtn.Image = ((System.Drawing.Image)(resources.GetObject("printPdfBtn.Image")));
			this.printPdfBtn.ImageSize = new System.Drawing.Size(20, 20);
			this.printPdfBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.printPdfBtn.Location = new System.Drawing.Point(251, 6);
			this.printPdfBtn.Name = "printPdfBtn";
			this.printPdfBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.printPdfBtn.OnHoverBorderColor = System.Drawing.Color.Transparent;
			this.printPdfBtn.OnHoverForeColor = System.Drawing.Color.White;
			this.printPdfBtn.OnHoverImage = null;
			this.printPdfBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.printPdfBtn.OnPressedColor = System.Drawing.Color.Black;
			this.printPdfBtn.Radius = 6;
			this.printPdfBtn.Size = new System.Drawing.Size(92, 42);
			this.printPdfBtn.TabIndex = 13;
			this.printPdfBtn.Text = "In PDF";
			this.printPdfBtn.Click += new System.EventHandler(this.printPdfBtn_Click);
			// 
			// viewMoreBtn
			// 
			this.viewMoreBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.viewMoreBtn.AnimationHoverSpeed = 0.07F;
			this.viewMoreBtn.AnimationSpeed = 0.03F;
			this.viewMoreBtn.BackColor = System.Drawing.Color.Transparent;
			this.viewMoreBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.viewMoreBtn.BorderColor = System.Drawing.Color.Black;
			this.viewMoreBtn.CheckedBaseColor = System.Drawing.Color.Gray;
			this.viewMoreBtn.CheckedBorderColor = System.Drawing.Color.Black;
			this.viewMoreBtn.CheckedForeColor = System.Drawing.Color.White;
			this.viewMoreBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("viewMoreBtn.CheckedImage")));
			this.viewMoreBtn.CheckedLineColor = System.Drawing.Color.DimGray;
			this.viewMoreBtn.DialogResult = System.Windows.Forms.DialogResult.None;
			this.viewMoreBtn.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
			this.viewMoreBtn.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.viewMoreBtn.ForeColor = System.Drawing.Color.White;
			this.viewMoreBtn.Image = ((System.Drawing.Image)(resources.GetObject("viewMoreBtn.Image")));
			this.viewMoreBtn.ImageSize = new System.Drawing.Size(20, 20);
			this.viewMoreBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.viewMoreBtn.Location = new System.Drawing.Point(907, 6);
			this.viewMoreBtn.Name = "viewMoreBtn";
			this.viewMoreBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.viewMoreBtn.OnHoverBorderColor = System.Drawing.Color.Transparent;
			this.viewMoreBtn.OnHoverForeColor = System.Drawing.Color.White;
			this.viewMoreBtn.OnHoverImage = null;
			this.viewMoreBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.viewMoreBtn.OnPressedColor = System.Drawing.Color.Black;
			this.viewMoreBtn.Radius = 6;
			this.viewMoreBtn.Size = new System.Drawing.Size(126, 42);
			this.viewMoreBtn.TabIndex = 15;
			this.viewMoreBtn.Text = "Xem chi tiết";
			this.viewMoreBtn.Click += new System.EventHandler(this.viewMoreBtn_Click);
			// 
			// exportBtn
			// 
			this.exportBtn.AnimationHoverSpeed = 0.07F;
			this.exportBtn.AnimationSpeed = 0.03F;
			this.exportBtn.BackColor = System.Drawing.Color.Transparent;
			this.exportBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.exportBtn.BorderColor = System.Drawing.Color.Black;
			this.exportBtn.CheckedBaseColor = System.Drawing.Color.Gray;
			this.exportBtn.CheckedBorderColor = System.Drawing.Color.Black;
			this.exportBtn.CheckedForeColor = System.Drawing.Color.White;
			this.exportBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("exportBtn.CheckedImage")));
			this.exportBtn.CheckedLineColor = System.Drawing.Color.DimGray;
			this.exportBtn.DialogResult = System.Windows.Forms.DialogResult.None;
			this.exportBtn.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
			this.exportBtn.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exportBtn.ForeColor = System.Drawing.Color.White;
			this.exportBtn.Image = ((System.Drawing.Image)(resources.GetObject("exportBtn.Image")));
			this.exportBtn.ImageSize = new System.Drawing.Size(20, 20);
			this.exportBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.exportBtn.Location = new System.Drawing.Point(124, 6);
			this.exportBtn.Name = "exportBtn";
			this.exportBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.exportBtn.OnHoverBorderColor = System.Drawing.Color.Transparent;
			this.exportBtn.OnHoverForeColor = System.Drawing.Color.White;
			this.exportBtn.OnHoverImage = null;
			this.exportBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.exportBtn.OnPressedColor = System.Drawing.Color.Black;
			this.exportBtn.Radius = 6;
			this.exportBtn.Size = new System.Drawing.Size(121, 42);
			this.exportBtn.TabIndex = 11;
			this.exportBtn.Text = "Xuất excel";
			this.exportBtn.TextChanged += new System.EventHandler(this.supplierCbx_SelectedIndexChanged);
			this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
			// 
			// refreshBtn
			// 
			this.refreshBtn.AnimationHoverSpeed = 0.07F;
			this.refreshBtn.AnimationSpeed = 0.03F;
			this.refreshBtn.BackColor = System.Drawing.Color.Transparent;
			this.refreshBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.refreshBtn.BorderColor = System.Drawing.Color.Black;
			this.refreshBtn.CheckedBaseColor = System.Drawing.Color.Gray;
			this.refreshBtn.CheckedBorderColor = System.Drawing.Color.Black;
			this.refreshBtn.CheckedForeColor = System.Drawing.Color.White;
			this.refreshBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("refreshBtn.CheckedImage")));
			this.refreshBtn.CheckedLineColor = System.Drawing.Color.DimGray;
			this.refreshBtn.DialogResult = System.Windows.Forms.DialogResult.None;
			this.refreshBtn.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
			this.refreshBtn.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.refreshBtn.ForeColor = System.Drawing.Color.White;
			this.refreshBtn.Image = ((System.Drawing.Image)(resources.GetObject("refreshBtn.Image")));
			this.refreshBtn.ImageSize = new System.Drawing.Size(20, 20);
			this.refreshBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.refreshBtn.Location = new System.Drawing.Point(11, 6);
			this.refreshBtn.Name = "refreshBtn";
			this.refreshBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.refreshBtn.OnHoverBorderColor = System.Drawing.Color.Transparent;
			this.refreshBtn.OnHoverForeColor = System.Drawing.Color.White;
			this.refreshBtn.OnHoverImage = null;
			this.refreshBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.refreshBtn.OnPressedColor = System.Drawing.Color.Black;
			this.refreshBtn.Radius = 6;
			this.refreshBtn.Size = new System.Drawing.Size(107, 42);
			this.refreshBtn.TabIndex = 10;
			this.refreshBtn.Text = "Làm mới";
			this.refreshBtn.TextChanged += new System.EventHandler(this.refreshBtn_Click);
			// 
			// dgvOrderBill
			// 
			this.dgvOrderBill.AllowUserToAddRows = false;
			this.dgvOrderBill.AllowUserToDeleteRows = false;
			this.dgvOrderBill.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.dgvOrderBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvOrderBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvOrderBill.BackgroundColor = System.Drawing.Color.White;
			this.dgvOrderBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvOrderBill.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvOrderBill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("#9Slide03 Cabin", 9F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvOrderBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvOrderBill.ColumnHeadersHeight = 50;
			this.dgvOrderBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvOrderBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column6,
            this.Column3,
            this.Column4,
            this.trangThai});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("#9Slide03 Cabin", 9F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvOrderBill.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvOrderBill.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvOrderBill.EnableHeadersVisualStyles = false;
			this.dgvOrderBill.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvOrderBill.Location = new System.Drawing.Point(0, 122);
			this.dgvOrderBill.Name = "dgvOrderBill";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("#9Slide03 Cabin", 9F);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvOrderBill.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvOrderBill.RowHeadersVisible = false;
			this.dgvOrderBill.RowHeadersWidth = 51;
			this.dgvOrderBill.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("#9Slide03 Cabin", 10F);
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvOrderBill.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvOrderBill.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dgvOrderBill.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvOrderBill.RowTemplate.Height = 75;
			this.dgvOrderBill.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvOrderBill.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dgvOrderBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvOrderBill.Size = new System.Drawing.Size(1044, 508);
			this.dgvOrderBill.TabIndex = 46;
			this.dgvOrderBill.TabStop = false;
			this.dgvOrderBill.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
			this.dgvOrderBill.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvOrderBill.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dgvOrderBill.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dgvOrderBill.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dgvOrderBill.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dgvOrderBill.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dgvOrderBill.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvOrderBill.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.dgvOrderBill.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dgvOrderBill.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("#9Slide03 Cabin", 9F);
			this.dgvOrderBill.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dgvOrderBill.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvOrderBill.ThemeStyle.HeaderStyle.Height = 50;
			this.dgvOrderBill.ThemeStyle.ReadOnly = false;
			this.dgvOrderBill.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvOrderBill.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvOrderBill.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("#9Slide03 Cabin", 9F);
			this.dgvOrderBill.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgvOrderBill.ThemeStyle.RowsStyle.Height = 75;
			this.dgvOrderBill.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvOrderBill.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgvOrderBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvImportBill_CellDoubleClick);
			// 
			// Column1
			// 
			this.Column1.FillWeight = 61.60671F;
			this.Column1.HeaderText = "Mã Đơn";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Column1.ToolTipText = "Mã Đơn";
			// 
			// Column6
			// 
			this.Column6.FillWeight = 61.60671F;
			this.Column6.HeaderText = "Nhà cung cấp";
			this.Column6.MinimumWidth = 6;
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			this.Column6.ToolTipText = "Nhà cung cấp";
			// 
			// Column3
			// 
			this.Column3.FillWeight = 61.60671F;
			this.Column3.HeaderText = "Nhân Viên";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Column3.ToolTipText = "Nhân Viên";
			// 
			// Column4
			// 
			this.Column4.FillWeight = 61.60671F;
			this.Column4.HeaderText = "Ngày Lập";
			this.Column4.MinimumWidth = 6;
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Column4.ToolTipText = "Ngày Lập";
			// 
			// trangThai
			// 
			this.trangThai.HeaderText = "Trạng thái";
			this.trangThai.MinimumWidth = 6;
			this.trangThai.Name = "trangThai";
			this.trangThai.ReadOnly = true;
			// 
			// OrderBillManagerGUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
			this.ClientSize = new System.Drawing.Size(1044, 684);
			this.Controls.Add(this.dgvOrderBill);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel6);
			this.Font = new System.Drawing.Font("#9Slide03 Cabin", 9F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "OrderBillManagerGUI";
			this.ShowInTaskbar = false;
			this.Text = "OrderBillManager";
			this.Load += new System.EventHandler(this.OrderBillManagerGUI_Load);
			this.panel6.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvOrderBill)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel6;
		private Guna.UI.WinForms.GunaComboBox supplierCbx;
		private Guna.UI.WinForms.GunaComboBox staffCbx;
		private System.Windows.Forms.Panel panel5;
		private Guna.UI.WinForms.GunaMediumCheckBox filterCkx;
		private Guna.UI.WinForms.GunaDateTimePicker dateTimeTo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private Guna.UI.WinForms.GunaDateTimePicker dateTimeFrom;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel line1;
		private Guna.UI2.WinForms.Guna2TextBox searchInput;
		private System.Windows.Forms.Panel panel1;
		private Guna.UI.WinForms.GunaAdvenceButton printPdfBtn;
		private Guna.UI.WinForms.GunaAdvenceButton viewMoreBtn;
		private Guna.UI.WinForms.GunaAdvenceButton exportBtn;
		private Guna.UI.WinForms.GunaAdvenceButton refreshBtn;
		private Guna.UI.WinForms.GunaDataGridView dgvOrderBill;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn trangThai;
	}
}