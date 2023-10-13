﻿namespace QuanLyCuaHangBanSach.GUI.Manager
{
	partial class CustomerStatisticGUI
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerStatisticGUI));
			this.line1 = new System.Windows.Forms.Panel();
			this.dgvCustomer = new Guna.UI.WinForms.GunaDataGridView();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.optionPanel = new System.Windows.Forms.Panel();
			this.chartBtn = new Guna.UI.WinForms.GunaAdvenceButton();
			this.tableBtn = new Guna.UI.WinForms.GunaAdvenceButton();
			this.exportBtn = new Guna.UI.WinForms.GunaAdvenceButton();
			this.refreshBtn = new Guna.UI.WinForms.GunaAdvenceButton();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.searchInput = new Guna.UI2.WinForms.Guna2TextBox();
			this.modeCheck = new System.Windows.Forms.Timer(this.components);
			this.tablePanel = new System.Windows.Forms.Panel();
			this.gradientPanel1 = new QuanLyCuaHangBanSach.GradientPanel();
			this.boughtTo = new Guna.UI2.WinForms.Guna2TextBox();
			this.boughtFrom = new Guna.UI2.WinForms.Guna2TextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.chartPanel = new System.Windows.Forms.Panel();
			this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
			this.pieChart1 = new LiveCharts.Wpf.PieChart();
			this.label7 = new System.Windows.Forms.Label();
			this.gunaGradient2Panel3 = new Guna.UI.WinForms.GunaGradient2Panel();
			this.gunaGradient2Panel5 = new Guna.UI.WinForms.GunaGradient2Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.bookSoldLb = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.gunaGradient2Panel2 = new Guna.UI.WinForms.GunaGradient2Panel();
			this.gunaGradient2Panel6 = new Guna.UI.WinForms.GunaGradient2Panel();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.customerNumLb = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.gunaGradient2Panel1 = new Guna.UI.WinForms.GunaGradient2Panel();
			this.gunaGradient2Panel4 = new Guna.UI.WinForms.GunaGradient2Panel();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.revenueLb = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
			this.optionPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.tablePanel.SuspendLayout();
			this.gradientPanel1.SuspendLayout();
			this.chartPanel.SuspendLayout();
			this.gunaGradient2Panel3.SuspendLayout();
			this.gunaGradient2Panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.gunaGradient2Panel2.SuspendLayout();
			this.gunaGradient2Panel6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.gunaGradient2Panel1.SuspendLayout();
			this.gunaGradient2Panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			this.SuspendLayout();
			// 
			// line1
			// 
			this.line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
			this.line1.Location = new System.Drawing.Point(16, 48);
			this.line1.Name = "line1";
			this.line1.Size = new System.Drawing.Size(268, 1);
			this.line1.TabIndex = 21;
			// 
			// dgvCustomer
			// 
			this.dgvCustomer.AllowUserToAddRows = false;
			this.dgvCustomer.AllowUserToDeleteRows = false;
			this.dgvCustomer.AllowUserToResizeRows = false;
			dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
			this.dgvCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
			this.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvCustomer.BackgroundColor = System.Drawing.Color.White;
			this.dgvCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvCustomer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle12.Font = new System.Drawing.Font("#9Slide03 Cabin", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
			this.dgvCustomer.ColumnHeadersHeight = 50;
			this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column7,
            this.Column8,
            this.Column6,
            this.Column1});
			dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle18.Font = new System.Drawing.Font("#9Slide03 Cabin", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvCustomer.DefaultCellStyle = dataGridViewCellStyle18;
			this.dgvCustomer.EnableHeadersVisualStyles = false;
			this.dgvCustomer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvCustomer.Location = new System.Drawing.Point(3, 63);
			this.dgvCustomer.Name = "dgvCustomer";
			dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle19.Font = new System.Drawing.Font("#9Slide03 Cabin", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvCustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
			this.dgvCustomer.RowHeadersVisible = false;
			this.dgvCustomer.RowHeadersWidth = 51;
			this.dgvCustomer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvCustomer.RowsDefaultCellStyle = dataGridViewCellStyle20;
			this.dgvCustomer.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dgvCustomer.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvCustomer.RowTemplate.Height = 75;
			this.dgvCustomer.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvCustomer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCustomer.Size = new System.Drawing.Size(1247, 575);
			this.dgvCustomer.TabIndex = 23;
			this.dgvCustomer.TabStop = false;
			this.dgvCustomer.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
			this.dgvCustomer.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvCustomer.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dgvCustomer.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dgvCustomer.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dgvCustomer.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dgvCustomer.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dgvCustomer.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvCustomer.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.dgvCustomer.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dgvCustomer.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("#9Slide03 Cabin", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvCustomer.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dgvCustomer.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvCustomer.ThemeStyle.HeaderStyle.Height = 50;
			this.dgvCustomer.ThemeStyle.ReadOnly = false;
			this.dgvCustomer.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvCustomer.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvCustomer.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("#9Slide03 Cabin", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvCustomer.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgvCustomer.ThemeStyle.RowsStyle.Height = 75;
			this.dgvCustomer.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvCustomer.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgvCustomer.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.dgvCustomer_SortCompare);
			// 
			// Column2
			// 
			dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle13.Font = new System.Drawing.Font("#9Slide03 Cabin", 10F);
			this.Column2.DefaultCellStyle = dataGridViewCellStyle13;
			this.Column2.FillWeight = 50F;
			this.Column2.HeaderText = "Mã khách hàng";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Column2.ToolTipText = "Mã khách hàng";
			// 
			// Column7
			// 
			dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle14.Font = new System.Drawing.Font("#9Slide03 Cabin", 10F);
			this.Column7.DefaultCellStyle = dataGridViewCellStyle14;
			this.Column7.FillWeight = 120F;
			this.Column7.HeaderText = "Tên khách hàng";
			this.Column7.MinimumWidth = 6;
			this.Column7.Name = "Column7";
			this.Column7.ReadOnly = true;
			this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Column7.ToolTipText = "Tên khách hàng";
			// 
			// Column8
			// 
			dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle15.Font = new System.Drawing.Font("#9Slide03 Cabin", 10F);
			this.Column8.DefaultCellStyle = dataGridViewCellStyle15;
			this.Column8.FillWeight = 120F;
			this.Column8.HeaderText = "Số điện thoại";
			this.Column8.MinimumWidth = 6;
			this.Column8.Name = "Column8";
			this.Column8.ReadOnly = true;
			this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Column8.ToolTipText = "Số điện thoại";
			// 
			// Column6
			// 
			dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle16.Font = new System.Drawing.Font("#9Slide03 Cabin", 10F);
			this.Column6.DefaultCellStyle = dataGridViewCellStyle16;
			this.Column6.FillWeight = 50F;
			this.Column6.HeaderText = "Số lượng hóa đơn";
			this.Column6.MinimumWidth = 6;
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Column6.ToolTipText = "Số lượng hóa đơn";
			// 
			// Column1
			// 
			dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle17.Font = new System.Drawing.Font("#9Slide03 Cabin", 10F);
			this.Column1.DefaultCellStyle = dataGridViewCellStyle17;
			this.Column1.FillWeight = 120F;
			this.Column1.HeaderText = "Đã mua hàng";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.ToolTipText = "Đã mua hàng";
			// 
			// optionPanel
			// 
			this.optionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
			this.optionPanel.Controls.Add(this.chartBtn);
			this.optionPanel.Controls.Add(this.tableBtn);
			this.optionPanel.Controls.Add(this.exportBtn);
			this.optionPanel.Controls.Add(this.refreshBtn);
			this.optionPanel.Location = new System.Drawing.Point(15, 654);
			this.optionPanel.Name = "optionPanel";
			this.optionPanel.Size = new System.Drawing.Size(1253, 54);
			this.optionPanel.TabIndex = 24;
			// 
			// chartBtn
			// 
			this.chartBtn.AnimationHoverSpeed = 0.07F;
			this.chartBtn.AnimationSpeed = 0.03F;
			this.chartBtn.BackColor = System.Drawing.Color.Transparent;
			this.chartBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.chartBtn.BorderColor = System.Drawing.Color.Black;
			this.chartBtn.CheckedBaseColor = System.Drawing.Color.PaleTurquoise;
			this.chartBtn.CheckedBorderColor = System.Drawing.Color.Black;
			this.chartBtn.CheckedForeColor = System.Drawing.Color.White;
			this.chartBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("chartBtn.CheckedImage")));
			this.chartBtn.CheckedLineColor = System.Drawing.Color.DimGray;
			this.chartBtn.DialogResult = System.Windows.Forms.DialogResult.None;
			this.chartBtn.FocusedColor = System.Drawing.Color.Empty;
			this.chartBtn.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 10.2F, System.Drawing.FontStyle.Bold);
			this.chartBtn.ForeColor = System.Drawing.Color.White;
			this.chartBtn.Image = ((System.Drawing.Image)(resources.GetObject("chartBtn.Image")));
			this.chartBtn.ImageSize = new System.Drawing.Size(20, 20);
			this.chartBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.chartBtn.Location = new System.Drawing.Point(1154, 6);
			this.chartBtn.Name = "chartBtn";
			this.chartBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.chartBtn.OnHoverBorderColor = System.Drawing.Color.Transparent;
			this.chartBtn.OnHoverForeColor = System.Drawing.Color.White;
			this.chartBtn.OnHoverImage = null;
			this.chartBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.chartBtn.OnPressedColor = System.Drawing.Color.Black;
			this.chartBtn.Radius = 6;
			this.chartBtn.Size = new System.Drawing.Size(96, 42);
			this.chartBtn.TabIndex = 10;
			this.chartBtn.Text = "Biểu đồ";
			this.chartBtn.Click += new System.EventHandler(this.chartBtn_Click);
			// 
			// tableBtn
			// 
			this.tableBtn.AnimationHoverSpeed = 0.07F;
			this.tableBtn.AnimationSpeed = 0.03F;
			this.tableBtn.BackColor = System.Drawing.Color.Transparent;
			this.tableBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.tableBtn.BorderColor = System.Drawing.Color.Black;
			this.tableBtn.CheckedBaseColor = System.Drawing.Color.PaleTurquoise;
			this.tableBtn.CheckedBorderColor = System.Drawing.Color.Black;
			this.tableBtn.CheckedForeColor = System.Drawing.Color.White;
			this.tableBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("tableBtn.CheckedImage")));
			this.tableBtn.CheckedLineColor = System.Drawing.Color.DimGray;
			this.tableBtn.DialogResult = System.Windows.Forms.DialogResult.None;
			this.tableBtn.FocusedColor = System.Drawing.Color.Empty;
			this.tableBtn.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 10.2F, System.Drawing.FontStyle.Bold);
			this.tableBtn.ForeColor = System.Drawing.Color.White;
			this.tableBtn.Image = ((System.Drawing.Image)(resources.GetObject("tableBtn.Image")));
			this.tableBtn.ImageSize = new System.Drawing.Size(20, 20);
			this.tableBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.tableBtn.Location = new System.Drawing.Point(1045, 6);
			this.tableBtn.Name = "tableBtn";
			this.tableBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.tableBtn.OnHoverBorderColor = System.Drawing.Color.Transparent;
			this.tableBtn.OnHoverForeColor = System.Drawing.Color.White;
			this.tableBtn.OnHoverImage = null;
			this.tableBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.tableBtn.OnPressedColor = System.Drawing.Color.Black;
			this.tableBtn.Radius = 6;
			this.tableBtn.Size = new System.Drawing.Size(92, 42);
			this.tableBtn.TabIndex = 9;
			this.tableBtn.Text = "Bảng";
			this.tableBtn.Click += new System.EventHandler(this.tableBtn_Click);
			// 
			// exportBtn
			// 
			this.exportBtn.AnimationHoverSpeed = 0.07F;
			this.exportBtn.AnimationSpeed = 0.03F;
			this.exportBtn.BackColor = System.Drawing.Color.Transparent;
			this.exportBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.exportBtn.BorderColor = System.Drawing.Color.Black;
			this.exportBtn.CheckedBaseColor = System.Drawing.Color.PaleTurquoise;
			this.exportBtn.CheckedBorderColor = System.Drawing.Color.Black;
			this.exportBtn.CheckedForeColor = System.Drawing.Color.White;
			this.exportBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("exportBtn.CheckedImage")));
			this.exportBtn.CheckedLineColor = System.Drawing.Color.DimGray;
			this.exportBtn.DialogResult = System.Windows.Forms.DialogResult.None;
			this.exportBtn.FocusedColor = System.Drawing.Color.Empty;
			this.exportBtn.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 10.2F, System.Drawing.FontStyle.Bold);
			this.exportBtn.ForeColor = System.Drawing.Color.White;
			this.exportBtn.Image = ((System.Drawing.Image)(resources.GetObject("exportBtn.Image")));
			this.exportBtn.ImageSize = new System.Drawing.Size(20, 20);
			this.exportBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.exportBtn.Location = new System.Drawing.Point(128, 6);
			this.exportBtn.Name = "exportBtn";
			this.exportBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.exportBtn.OnHoverBorderColor = System.Drawing.Color.Transparent;
			this.exportBtn.OnHoverForeColor = System.Drawing.Color.White;
			this.exportBtn.OnHoverImage = null;
			this.exportBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.exportBtn.OnPressedColor = System.Drawing.Color.Black;
			this.exportBtn.Radius = 6;
			this.exportBtn.Size = new System.Drawing.Size(121, 42);
			this.exportBtn.TabIndex = 8;
			this.exportBtn.Text = "Xuất excel";
			this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
			// 
			// refreshBtn
			// 
			this.refreshBtn.AnimationHoverSpeed = 0.07F;
			this.refreshBtn.AnimationSpeed = 0.03F;
			this.refreshBtn.BackColor = System.Drawing.Color.Transparent;
			this.refreshBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.refreshBtn.BorderColor = System.Drawing.Color.Black;
			this.refreshBtn.CheckedBaseColor = System.Drawing.Color.PaleTurquoise;
			this.refreshBtn.CheckedBorderColor = System.Drawing.Color.Black;
			this.refreshBtn.CheckedForeColor = System.Drawing.Color.White;
			this.refreshBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("refreshBtn.CheckedImage")));
			this.refreshBtn.CheckedLineColor = System.Drawing.Color.DimGray;
			this.refreshBtn.DialogResult = System.Windows.Forms.DialogResult.None;
			this.refreshBtn.FocusedColor = System.Drawing.Color.Empty;
			this.refreshBtn.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 10.2F, System.Drawing.FontStyle.Bold);
			this.refreshBtn.ForeColor = System.Drawing.Color.White;
			this.refreshBtn.Image = ((System.Drawing.Image)(resources.GetObject("refreshBtn.Image")));
			this.refreshBtn.ImageSize = new System.Drawing.Size(20, 20);
			this.refreshBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.refreshBtn.Location = new System.Drawing.Point(3, 6);
			this.refreshBtn.Name = "refreshBtn";
			this.refreshBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.refreshBtn.OnHoverBorderColor = System.Drawing.Color.Transparent;
			this.refreshBtn.OnHoverForeColor = System.Drawing.Color.White;
			this.refreshBtn.OnHoverImage = null;
			this.refreshBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.refreshBtn.OnPressedColor = System.Drawing.Color.Black;
			this.refreshBtn.Radius = 6;
			this.refreshBtn.Size = new System.Drawing.Size(107, 42);
			this.refreshBtn.TabIndex = 7;
			this.refreshBtn.Text = "Làm mới";
			this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(248, 15);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(36, 30);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 22;
			this.pictureBox1.TabStop = false;
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
			this.searchInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.searchInput.ForeColor = System.Drawing.Color.Black;
			this.searchInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.searchInput.HoverState.Parent = this.searchInput;
			this.searchInput.Location = new System.Drawing.Point(5, 11);
			this.searchInput.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.searchInput.Name = "searchInput";
			this.searchInput.PasswordChar = '\0';
			this.searchInput.PlaceholderText = "Tìm kiếm theo mã, tên ...";
			this.searchInput.SelectedText = "";
			this.searchInput.ShadowDecoration.Parent = this.searchInput;
			this.searchInput.Size = new System.Drawing.Size(236, 36);
			this.searchInput.TabIndex = 31;
			this.searchInput.TextChanged += new System.EventHandler(this.searchInput_TextChanged);
			this.searchInput.MouseLeave += new System.EventHandler(this.searchInput_MouseLeave);
			// 
			// modeCheck
			// 
			this.modeCheck.Enabled = true;
			this.modeCheck.Tick += new System.EventHandler(this.modeCheck_Tick);
			// 
			// tablePanel
			// 
			this.tablePanel.Controls.Add(this.searchInput);
			this.tablePanel.Controls.Add(this.pictureBox1);
			this.tablePanel.Controls.Add(this.gradientPanel1);
			this.tablePanel.Controls.Add(this.line1);
			this.tablePanel.Controls.Add(this.dgvCustomer);
			this.tablePanel.Location = new System.Drawing.Point(15, 12);
			this.tablePanel.Name = "tablePanel";
			this.tablePanel.Size = new System.Drawing.Size(1253, 636);
			this.tablePanel.TabIndex = 39;
			// 
			// gradientPanel1
			// 
			this.gradientPanel1.ColorLeft = System.Drawing.Color.Empty;
			this.gradientPanel1.ColorRight = System.Drawing.Color.Empty;
			this.gradientPanel1.Controls.Add(this.boughtTo);
			this.gradientPanel1.Controls.Add(this.boughtFrom);
			this.gradientPanel1.Controls.Add(this.panel3);
			this.gradientPanel1.Controls.Add(this.panel4);
			this.gradientPanel1.Controls.Add(this.panel2);
			this.gradientPanel1.Controls.Add(this.label1);
			this.gradientPanel1.Location = new System.Drawing.Point(910, 11);
			this.gradientPanel1.Name = "gradientPanel1";
			this.gradientPanel1.Size = new System.Drawing.Size(337, 36);
			this.gradientPanel1.TabIndex = 30;
			// 
			// boughtTo
			// 
			this.boughtTo.Animated = true;
			this.boughtTo.BackColor = System.Drawing.Color.Transparent;
			this.boughtTo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
			this.boughtTo.BorderThickness = 0;
			this.boughtTo.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.boughtTo.DefaultText = "";
			this.boughtTo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.boughtTo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.boughtTo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.boughtTo.DisabledState.Parent = this.boughtTo;
			this.boughtTo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.boughtTo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
			this.boughtTo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.boughtTo.FocusedState.Parent = this.boughtTo;
			this.boughtTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.boughtTo.ForeColor = System.Drawing.Color.Black;
			this.boughtTo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.boughtTo.HoverState.Parent = this.boughtTo;
			this.boughtTo.Location = new System.Drawing.Point(195, 4);
			this.boughtTo.Margin = new System.Windows.Forms.Padding(0);
			this.boughtTo.Name = "boughtTo";
			this.boughtTo.PasswordChar = '\0';
			this.boughtTo.PlaceholderText = "Đã mua đến  ...";
			this.boughtTo.SelectedText = "";
			this.boughtTo.ShadowDecoration.Parent = this.boughtTo;
			this.boughtTo.Size = new System.Drawing.Size(129, 25);
			this.boughtTo.TabIndex = 34;
			// 
			// boughtFrom
			// 
			this.boughtFrom.Animated = true;
			this.boughtFrom.BackColor = System.Drawing.Color.Transparent;
			this.boughtFrom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
			this.boughtFrom.BorderThickness = 0;
			this.boughtFrom.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.boughtFrom.DefaultText = "";
			this.boughtFrom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.boughtFrom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.boughtFrom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.boughtFrom.DisabledState.Parent = this.boughtFrom;
			this.boughtFrom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.boughtFrom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
			this.boughtFrom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.boughtFrom.FocusedState.Parent = this.boughtFrom;
			this.boughtFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.boughtFrom.ForeColor = System.Drawing.Color.Black;
			this.boughtFrom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.boughtFrom.HoverState.Parent = this.boughtFrom;
			this.boughtFrom.Location = new System.Drawing.Point(21, 4);
			this.boughtFrom.Margin = new System.Windows.Forms.Padding(0);
			this.boughtFrom.Name = "boughtFrom";
			this.boughtFrom.PasswordChar = '\0';
			this.boughtFrom.PlaceholderText = "Đã mua từ  ...";
			this.boughtFrom.SelectedText = "";
			this.boughtFrom.ShadowDecoration.Parent = this.boughtFrom;
			this.boughtFrom.Size = new System.Drawing.Size(125, 25);
			this.boughtFrom.TabIndex = 32;
			this.boughtFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boughtFrom_KeyPress);
			// 
			// panel3
			// 
			this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
			this.panel3.Location = new System.Drawing.Point(26, 31);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(120, 1);
			this.panel3.TabIndex = 31;
			// 
			// panel4
			// 
			this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
			this.panel4.Location = new System.Drawing.Point(201, 31);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(120, 1);
			this.panel4.TabIndex = 33;
			// 
			// panel2
			// 
			this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
			this.panel2.Location = new System.Drawing.Point(158, 18);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(28, 1);
			this.panel2.TabIndex = 22;
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Left;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(18, 36);
			this.label1.TabIndex = 0;
			this.label1.Text = "$";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// chartPanel
			// 
			this.chartPanel.Controls.Add(this.elementHost1);
			this.chartPanel.Controls.Add(this.label7);
			this.chartPanel.Controls.Add(this.gunaGradient2Panel3);
			this.chartPanel.Controls.Add(this.gunaGradient2Panel2);
			this.chartPanel.Controls.Add(this.gunaGradient2Panel1);
			this.chartPanel.Location = new System.Drawing.Point(15, 12);
			this.chartPanel.Name = "chartPanel";
			this.chartPanel.Size = new System.Drawing.Size(1253, 636);
			this.chartPanel.TabIndex = 40;
			// 
			// elementHost1
			// 
			this.elementHost1.Location = new System.Drawing.Point(3, 180);
			this.elementHost1.Name = "elementHost1";
			this.elementHost1.Size = new System.Drawing.Size(1247, 453);
			this.elementHost1.TabIndex = 21;
			this.elementHost1.Text = "elementHost1";
			this.elementHost1.Child = this.pieChart1;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(3, 149);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(160, 28);
			this.label7.TabIndex = 20;
			this.label7.Text = "BIỂU ĐỒ THỐNG KÊ";
			// 
			// gunaGradient2Panel3
			// 
			this.gunaGradient2Panel3.BackColor = System.Drawing.Color.Transparent;
			this.gunaGradient2Panel3.Controls.Add(this.gunaGradient2Panel5);
			this.gunaGradient2Panel3.Controls.Add(this.bookSoldLb);
			this.gunaGradient2Panel3.Controls.Add(this.label4);
			this.gunaGradient2Panel3.GradientColor1 = System.Drawing.Color.White;
			this.gunaGradient2Panel3.GradientColor2 = System.Drawing.Color.White;
			this.gunaGradient2Panel3.Location = new System.Drawing.Point(452, 4);
			this.gunaGradient2Panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.gunaGradient2Panel3.Name = "gunaGradient2Panel3";
			this.gunaGradient2Panel3.Radius = 16;
			this.gunaGradient2Panel3.Size = new System.Drawing.Size(350, 125);
			this.gunaGradient2Panel3.TabIndex = 19;
			// 
			// gunaGradient2Panel5
			// 
			this.gunaGradient2Panel5.BackColor = System.Drawing.Color.Transparent;
			this.gunaGradient2Panel5.Controls.Add(this.pictureBox2);
			this.gunaGradient2Panel5.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.gunaGradient2Panel5.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.gunaGradient2Panel5.Location = new System.Drawing.Point(266, 30);
			this.gunaGradient2Panel5.Name = "gunaGradient2Panel5";
			this.gunaGradient2Panel5.Radius = 12;
			this.gunaGradient2Panel5.Size = new System.Drawing.Size(64, 64);
			this.gunaGradient2Panel5.TabIndex = 6;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(16, 16);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(32, 32);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 0;
			this.pictureBox2.TabStop = false;
			// 
			// bookSoldLb
			// 
			this.bookSoldLb.AutoSize = true;
			this.bookSoldLb.Font = new System.Drawing.Font("#9Slide03 Cabin Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bookSoldLb.ForeColor = System.Drawing.Color.Black;
			this.bookSoldLb.Location = new System.Drawing.Point(15, 64);
			this.bookSoldLb.Name = "bookSoldLb";
			this.bookSoldLb.Size = new System.Drawing.Size(0, 25);
			this.bookSoldLb.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("#9Slide03 Cabin Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(174)))), ((int)(((byte)(192)))));
			this.label4.Location = new System.Drawing.Point(15, 30);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(232, 21);
			this.label4.TabIndex = 3;
			this.label4.Text = "Tổng số sách đã bán 6 tháng gần đây";
			// 
			// gunaGradient2Panel2
			// 
			this.gunaGradient2Panel2.BackColor = System.Drawing.Color.Transparent;
			this.gunaGradient2Panel2.Controls.Add(this.gunaGradient2Panel6);
			this.gunaGradient2Panel2.Controls.Add(this.customerNumLb);
			this.gunaGradient2Panel2.Controls.Add(this.label6);
			this.gunaGradient2Panel2.GradientColor1 = System.Drawing.Color.White;
			this.gunaGradient2Panel2.GradientColor2 = System.Drawing.Color.White;
			this.gunaGradient2Panel2.Location = new System.Drawing.Point(900, 4);
			this.gunaGradient2Panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.gunaGradient2Panel2.Name = "gunaGradient2Panel2";
			this.gunaGradient2Panel2.Radius = 16;
			this.gunaGradient2Panel2.Size = new System.Drawing.Size(350, 125);
			this.gunaGradient2Panel2.TabIndex = 18;
			// 
			// gunaGradient2Panel6
			// 
			this.gunaGradient2Panel6.BackColor = System.Drawing.Color.Transparent;
			this.gunaGradient2Panel6.Controls.Add(this.pictureBox3);
			this.gunaGradient2Panel6.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.gunaGradient2Panel6.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.gunaGradient2Panel6.Location = new System.Drawing.Point(266, 30);
			this.gunaGradient2Panel6.Name = "gunaGradient2Panel6";
			this.gunaGradient2Panel6.Radius = 12;
			this.gunaGradient2Panel6.Size = new System.Drawing.Size(64, 64);
			this.gunaGradient2Panel6.TabIndex = 9;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(16, 16);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(32, 32);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 0;
			this.pictureBox3.TabStop = false;
			// 
			// customerNumLb
			// 
			this.customerNumLb.AutoSize = true;
			this.customerNumLb.Font = new System.Drawing.Font("#9Slide03 Cabin Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customerNumLb.ForeColor = System.Drawing.Color.Black;
			this.customerNumLb.Location = new System.Drawing.Point(13, 64);
			this.customerNumLb.Name = "customerNumLb";
			this.customerNumLb.Size = new System.Drawing.Size(0, 25);
			this.customerNumLb.TabIndex = 8;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("#9Slide03 Cabin Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(174)))), ((int)(((byte)(192)))));
			this.label6.Location = new System.Drawing.Point(13, 30);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(230, 21);
			this.label6.TabIndex = 6;
			this.label6.Text = "Tổng số khách hàng 6 tháng gần đây";
			// 
			// gunaGradient2Panel1
			// 
			this.gunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent;
			this.gunaGradient2Panel1.Controls.Add(this.gunaGradient2Panel4);
			this.gunaGradient2Panel1.Controls.Add(this.revenueLb);
			this.gunaGradient2Panel1.Controls.Add(this.label8);
			this.gunaGradient2Panel1.GradientColor1 = System.Drawing.Color.White;
			this.gunaGradient2Panel1.GradientColor2 = System.Drawing.Color.White;
			this.gunaGradient2Panel1.Location = new System.Drawing.Point(3, 4);
			this.gunaGradient2Panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.gunaGradient2Panel1.Name = "gunaGradient2Panel1";
			this.gunaGradient2Panel1.Radius = 16;
			this.gunaGradient2Panel1.Size = new System.Drawing.Size(350, 125);
			this.gunaGradient2Panel1.TabIndex = 17;
			// 
			// gunaGradient2Panel4
			// 
			this.gunaGradient2Panel4.BackColor = System.Drawing.Color.Transparent;
			this.gunaGradient2Panel4.Controls.Add(this.pictureBox4);
			this.gunaGradient2Panel4.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.gunaGradient2Panel4.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.gunaGradient2Panel4.Location = new System.Drawing.Point(265, 30);
			this.gunaGradient2Panel4.Name = "gunaGradient2Panel4";
			this.gunaGradient2Panel4.Radius = 12;
			this.gunaGradient2Panel4.Size = new System.Drawing.Size(64, 64);
			this.gunaGradient2Panel4.TabIndex = 3;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(16, 16);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(32, 32);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox4.TabIndex = 0;
			this.pictureBox4.TabStop = false;
			// 
			// revenueLb
			// 
			this.revenueLb.AutoSize = true;
			this.revenueLb.Font = new System.Drawing.Font("#9Slide03 Cabin Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.revenueLb.ForeColor = System.Drawing.Color.Black;
			this.revenueLb.Location = new System.Drawing.Point(16, 64);
			this.revenueLb.Name = "revenueLb";
			this.revenueLb.Size = new System.Drawing.Size(0, 25);
			this.revenueLb.TabIndex = 2;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("#9Slide03 Cabin Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(174)))), ((int)(((byte)(192)))));
			this.label8.Location = new System.Drawing.Point(16, 30);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(207, 21);
			this.label8.TabIndex = 0;
			this.label8.Text = "Tổng doanh thu 6 tháng gần đây";
			// 
			// CustomerStatisticGUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
			this.ClientSize = new System.Drawing.Size(1280, 720);
			this.Controls.Add(this.tablePanel);
			this.Controls.Add(this.chartPanel);
			this.Controls.Add(this.optionPanel);
			this.Font = new System.Drawing.Font("#9Slide03 Cabin", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "CustomerStatisticGUI";
			this.ShowInTaskbar = false;
			this.Text = "CustomerStatisticGUI";
			this.Load += new System.EventHandler(this.CustomerStatisticGUI_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
			this.optionPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.tablePanel.ResumeLayout(false);
			this.gradientPanel1.ResumeLayout(false);
			this.chartPanel.ResumeLayout(false);
			this.chartPanel.PerformLayout();
			this.gunaGradient2Panel3.ResumeLayout(false);
			this.gunaGradient2Panel3.PerformLayout();
			this.gunaGradient2Panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.gunaGradient2Panel2.ResumeLayout(false);
			this.gunaGradient2Panel2.PerformLayout();
			this.gunaGradient2Panel6.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.gunaGradient2Panel1.ResumeLayout(false);
			this.gunaGradient2Panel1.PerformLayout();
			this.gunaGradient2Panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel line1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private Guna.UI.WinForms.GunaDataGridView dgvCustomer;
		private System.Windows.Forms.Panel optionPanel;
		private Guna.UI.WinForms.GunaAdvenceButton refreshBtn;
		private GradientPanel gradientPanel1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private Guna.UI.WinForms.GunaAdvenceButton exportBtn;
		private Guna.UI2.WinForms.Guna2TextBox searchInput;
		private Guna.UI2.WinForms.Guna2TextBox boughtTo;
		private Guna.UI2.WinForms.Guna2TextBox boughtFrom;
		private Guna.UI.WinForms.GunaAdvenceButton chartBtn;
		private Guna.UI.WinForms.GunaAdvenceButton tableBtn;
		private System.Windows.Forms.Timer modeCheck;
		private System.Windows.Forms.Panel tablePanel;
		private System.Windows.Forms.Panel chartPanel;
		private System.Windows.Forms.Label label7;
		private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel3;
		private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel5;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label bookSoldLb;
		private System.Windows.Forms.Label label4;
		private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel2;
		private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel6;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label customerNumLb;
		private System.Windows.Forms.Label label6;
		private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel1;
		private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel4;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Label revenueLb;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Integration.ElementHost elementHost1;
		private LiveCharts.Wpf.PieChart pieChart1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
	}
}