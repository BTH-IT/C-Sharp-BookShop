namespace QuanLyCuaHangBanSach.GUI.Manager
{
    partial class PermissionManageGUI
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PermissionManageGUI));
			this.searchInput = new Guna.UI2.WinForms.Guna2TextBox();
			this.dgvPermission = new Guna.UI.WinForms.GunaDataGridView();
			this.line1 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.exportBtn = new Guna.UI.WinForms.GunaAdvenceButton();
			this.refreshBtn = new Guna.UI.WinForms.GunaAdvenceButton();
			this.editBtn = new Guna.UI.WinForms.GunaAdvenceButton();
			this.addBtn = new Guna.UI.WinForms.GunaAdvenceButton();
			this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.Column11 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvPermission)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
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
			this.searchInput.Font = new System.Drawing.Font("#9Slide03 Cabin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.searchInput.ForeColor = System.Drawing.Color.Black;
			this.searchInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.searchInput.HoverState.Parent = this.searchInput;
			this.searchInput.Location = new System.Drawing.Point(4, 10);
			this.searchInput.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.searchInput.Name = "searchInput";
			this.searchInput.PasswordChar = '\0';
			this.searchInput.PlaceholderText = "Tìm kiếm theo mã, tên";
			this.searchInput.SelectedText = "";
			this.searchInput.ShadowDecoration.Parent = this.searchInput;
			this.searchInput.Size = new System.Drawing.Size(236, 32);
			this.searchInput.TabIndex = 0;
			this.searchInput.TextChanged += new System.EventHandler(this.searchInput_TextChanged);
			// 
			// dgvPermission
			// 
			this.dgvPermission.AllowUserToAddRows = false;
			this.dgvPermission.AllowUserToDeleteRows = false;
			this.dgvPermission.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.dgvPermission.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvPermission.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvPermission.BackgroundColor = System.Drawing.Color.White;
			this.dgvPermission.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvPermission.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvPermission.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("#9Slide03 Cabin", 9F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvPermission.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvPermission.ColumnHeadersHeight = 50;
			this.dgvPermission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvPermission.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.Column1,
            this.Column2,
            this.Column3});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("#9Slide03 Cabin", 9F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvPermission.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvPermission.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvPermission.EnableHeadersVisualStyles = false;
			this.dgvPermission.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvPermission.Location = new System.Drawing.Point(0, 59);
			this.dgvPermission.Name = "dgvPermission";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("#9Slide03 Cabin", 9F);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvPermission.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvPermission.RowHeadersVisible = false;
			this.dgvPermission.RowHeadersWidth = 51;
			this.dgvPermission.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvPermission.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvPermission.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dgvPermission.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvPermission.RowTemplate.Height = 75;
			this.dgvPermission.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvPermission.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dgvPermission.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvPermission.Size = new System.Drawing.Size(1044, 571);
			this.dgvPermission.TabIndex = 34;
			this.dgvPermission.TabStop = false;
			this.dgvPermission.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
			this.dgvPermission.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvPermission.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dgvPermission.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dgvPermission.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dgvPermission.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dgvPermission.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dgvPermission.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvPermission.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.dgvPermission.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dgvPermission.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("#9Slide03 Cabin", 9F);
			this.dgvPermission.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dgvPermission.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvPermission.ThemeStyle.HeaderStyle.Height = 50;
			this.dgvPermission.ThemeStyle.ReadOnly = false;
			this.dgvPermission.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvPermission.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvPermission.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("#9Slide03 Cabin", 9F);
			this.dgvPermission.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgvPermission.ThemeStyle.RowsStyle.Height = 75;
			this.dgvPermission.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvPermission.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgvPermission.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPermission_CellDoubleClick);
			// 
			// line1
			// 
			this.line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
			this.line1.Location = new System.Drawing.Point(15, 43);
			this.line1.Name = "line1";
			this.line1.Size = new System.Drawing.Size(268, 1);
			this.line1.TabIndex = 32;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
			this.panel1.Controls.Add(this.exportBtn);
			this.panel1.Controls.Add(this.refreshBtn);
			this.panel1.Controls.Add(this.editBtn);
			this.panel1.Controls.Add(this.addBtn);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 630);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1044, 54);
			this.panel1.TabIndex = 1;
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
			this.exportBtn.Location = new System.Drawing.Point(119, 6);
			this.exportBtn.Name = "exportBtn";
			this.exportBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.exportBtn.OnHoverBorderColor = System.Drawing.Color.Transparent;
			this.exportBtn.OnHoverForeColor = System.Drawing.Color.White;
			this.exportBtn.OnHoverImage = null;
			this.exportBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.exportBtn.OnPressedColor = System.Drawing.Color.Black;
			this.exportBtn.Radius = 6;
			this.exportBtn.Size = new System.Drawing.Size(121, 42);
			this.exportBtn.TabIndex = 3;
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
			this.refreshBtn.Location = new System.Drawing.Point(6, 6);
			this.refreshBtn.Name = "refreshBtn";
			this.refreshBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.refreshBtn.OnHoverBorderColor = System.Drawing.Color.Transparent;
			this.refreshBtn.OnHoverForeColor = System.Drawing.Color.White;
			this.refreshBtn.OnHoverImage = null;
			this.refreshBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.refreshBtn.OnPressedColor = System.Drawing.Color.Black;
			this.refreshBtn.Radius = 6;
			this.refreshBtn.Size = new System.Drawing.Size(107, 42);
			this.refreshBtn.TabIndex = 2;
			this.refreshBtn.Text = "Làm mới";
			this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
			// 
			// editBtn
			// 
			this.editBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.editBtn.AnimationHoverSpeed = 0.07F;
			this.editBtn.AnimationSpeed = 0.03F;
			this.editBtn.BackColor = System.Drawing.Color.Transparent;
			this.editBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.editBtn.BorderColor = System.Drawing.Color.Black;
			this.editBtn.CheckedBaseColor = System.Drawing.Color.Gray;
			this.editBtn.CheckedBorderColor = System.Drawing.Color.Black;
			this.editBtn.CheckedForeColor = System.Drawing.Color.White;
			this.editBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("editBtn.CheckedImage")));
			this.editBtn.CheckedLineColor = System.Drawing.Color.DimGray;
			this.editBtn.DialogResult = System.Windows.Forms.DialogResult.None;
			this.editBtn.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
			this.editBtn.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.editBtn.ForeColor = System.Drawing.Color.White;
			this.editBtn.Image = ((System.Drawing.Image)(resources.GetObject("editBtn.Image")));
			this.editBtn.ImageSize = new System.Drawing.Size(20, 20);
			this.editBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.editBtn.Location = new System.Drawing.Point(919, 6);
			this.editBtn.Name = "editBtn";
			this.editBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.editBtn.OnHoverBorderColor = System.Drawing.Color.Transparent;
			this.editBtn.OnHoverForeColor = System.Drawing.Color.White;
			this.editBtn.OnHoverImage = null;
			this.editBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.editBtn.OnPressedColor = System.Drawing.Color.Black;
			this.editBtn.Radius = 6;
			this.editBtn.Size = new System.Drawing.Size(113, 42);
			this.editBtn.TabIndex = 5;
			this.editBtn.Text = "Chỉnh sửa";
			this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
			// 
			// addBtn
			// 
			this.addBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.addBtn.AnimationHoverSpeed = 0.07F;
			this.addBtn.AnimationSpeed = 0.03F;
			this.addBtn.BackColor = System.Drawing.Color.Transparent;
			this.addBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.addBtn.BorderColor = System.Drawing.Color.Black;
			this.addBtn.CheckedBaseColor = System.Drawing.Color.Gray;
			this.addBtn.CheckedBorderColor = System.Drawing.Color.Black;
			this.addBtn.CheckedForeColor = System.Drawing.Color.White;
			this.addBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("addBtn.CheckedImage")));
			this.addBtn.CheckedLineColor = System.Drawing.Color.DimGray;
			this.addBtn.DialogResult = System.Windows.Forms.DialogResult.None;
			this.addBtn.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
			this.addBtn.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addBtn.ForeColor = System.Drawing.Color.White;
			this.addBtn.Image = ((System.Drawing.Image)(resources.GetObject("addBtn.Image")));
			this.addBtn.ImageSize = new System.Drawing.Size(20, 20);
			this.addBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.addBtn.Location = new System.Drawing.Point(796, 6);
			this.addBtn.Name = "addBtn";
			this.addBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.addBtn.OnHoverBorderColor = System.Drawing.Color.Transparent;
			this.addBtn.OnHoverForeColor = System.Drawing.Color.White;
			this.addBtn.OnHoverImage = null;
			this.addBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.addBtn.OnPressedColor = System.Drawing.Color.Black;
			this.addBtn.Radius = 6;
			this.addBtn.Size = new System.Drawing.Size(117, 42);
			this.addBtn.TabIndex = 4;
			this.addBtn.Text = "Thêm mới";
			this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
			// 
			// dataGridViewImageColumn1
			// 
			this.dataGridViewImageColumn1.HeaderText = "Hình Ảnh";
			this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
			this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
			this.dataGridViewImageColumn1.MinimumWidth = 100;
			this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
			this.dataGridViewImageColumn1.Width = 108;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(247, 10);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(36, 30);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 33;
			this.pictureBox1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Controls.Add(this.line1);
			this.panel2.Controls.Add(this.searchInput);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1044, 59);
			this.panel2.TabIndex = 0;
			// 
			// Column11
			// 
			this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Column11.FillWeight = 50F;
			this.Column11.Frozen = true;
			this.Column11.HeaderText = "";
			this.Column11.MinimumWidth = 50;
			this.Column11.Name = "Column11";
			this.Column11.Width = 50;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Mã Quyền";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Column1.ToolTipText = "Mã Quyền";
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Tên Quyền";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Column2.ToolTipText = "Tên Quyền";
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Trạng Thái";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Column3.ToolTipText = "Trạng Thái";
			// 
			// PermissionManageGUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
			this.ClientSize = new System.Drawing.Size(1044, 684);
			this.Controls.Add(this.dgvPermission);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.Font = new System.Drawing.Font("#9Slide03 Cabin", 9F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "PermissionManageGUI";
			this.Text = "PermissionManageGUI";
			this.Load += new System.EventHandler(this.PermissionManageGUI_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvPermission)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox searchInput;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaAdvenceButton exportBtn;
        private Guna.UI.WinForms.GunaAdvenceButton refreshBtn;
        private Guna.UI.WinForms.GunaDataGridView dgvPermission;
        private System.Windows.Forms.Panel line1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaAdvenceButton editBtn;
        private Guna.UI.WinForms.GunaAdvenceButton addBtn;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Column11;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
	}
}