namespace QuanLyCuaHangBanSach.GUI.Manager
{
    partial class StaffManageGUI
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffManageGUI));
			this.searchInput = new Guna.UI2.WinForms.Guna2TextBox();
			this.genderCbx = new Guna.UI.WinForms.GunaComboBox();
			this.positionCbx = new Guna.UI.WinForms.GunaComboBox();
			this.dgvStaff = new Guna.UI.WinForms.GunaDataGridView();
			this.Column11 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.maNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.namSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.soDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.soNgayNghi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.chucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.line1 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.exportBtn = new Guna.UI.WinForms.GunaAdvenceButton();
			this.refreshBtn = new Guna.UI.WinForms.GunaAdvenceButton();
			this.deleteBtn = new Guna.UI.WinForms.GunaAdvenceButton();
			this.editBtn = new Guna.UI.WinForms.GunaAdvenceButton();
			this.addBtn = new Guna.UI.WinForms.GunaAdvenceButton();
			this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.gradientPanel1 = new QuanLyCuaHangBanSach.GradientPanel();
			this.salaryTo = new Guna.UI2.WinForms.Guna2TextBox();
			this.salaryFrom = new Guna.UI2.WinForms.Guna2TextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.gradientPanel1.SuspendLayout();
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
			this.searchInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.searchInput.ForeColor = System.Drawing.Color.Black;
			this.searchInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.searchInput.HoverState.Parent = this.searchInput;
			this.searchInput.Location = new System.Drawing.Point(15, 14);
			this.searchInput.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.searchInput.Name = "searchInput";
			this.searchInput.PasswordChar = '\0';
			this.searchInput.PlaceholderText = "Tìm kiếm theo tên,SĐT";
			this.searchInput.SelectedText = "";
			this.searchInput.ShadowDecoration.Parent = this.searchInput;
			this.searchInput.Size = new System.Drawing.Size(236, 36);
			this.searchInput.TabIndex = 40;
			this.searchInput.TextChanged += new System.EventHandler(this.searchInput_TextChanged);
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
			this.genderCbx.FocusedColor = System.Drawing.Color.Empty;
			this.genderCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.genderCbx.ForeColor = System.Drawing.Color.Black;
			this.genderCbx.FormattingEnabled = true;
			this.genderCbx.ItemHeight = 30;
			this.genderCbx.Location = new System.Drawing.Point(526, 18);
			this.genderCbx.Name = "genderCbx";
			this.genderCbx.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.genderCbx.OnHoverItemForeColor = System.Drawing.Color.White;
			this.genderCbx.Radius = 6;
			this.genderCbx.Size = new System.Drawing.Size(166, 36);
			this.genderCbx.TabIndex = 37;
			this.genderCbx.TabStop = false;
			this.genderCbx.SelectedIndexChanged += new System.EventHandler(this.genderCbx_SelectedIndexChanged);
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
			this.positionCbx.FocusedColor = System.Drawing.Color.Empty;
			this.positionCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.positionCbx.ForeColor = System.Drawing.Color.Black;
			this.positionCbx.FormattingEnabled = true;
			this.positionCbx.ItemHeight = 30;
			this.positionCbx.Location = new System.Drawing.Point(345, 18);
			this.positionCbx.Name = "positionCbx";
			this.positionCbx.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.positionCbx.OnHoverItemForeColor = System.Drawing.Color.White;
			this.positionCbx.Radius = 6;
			this.positionCbx.Size = new System.Drawing.Size(175, 36);
			this.positionCbx.TabIndex = 36;
			this.positionCbx.TabStop = false;
			this.positionCbx.SelectedIndexChanged += new System.EventHandler(this.positionCbx_SelectedIndexChanged);
			// 
			// dgvStaff
			// 
			this.dgvStaff.AllowUserToAddRows = false;
			this.dgvStaff.AllowUserToDeleteRows = false;
			this.dgvStaff.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.dgvStaff.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvStaff.BackgroundColor = System.Drawing.Color.White;
			this.dgvStaff.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvStaff.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvStaff.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvStaff.ColumnHeadersHeight = 50;
			this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.maNhanVien,
            this.tenNhanVien,
            this.namSinh,
            this.gioiTinh,
            this.soDienThoai,
            this.soNgayNghi,
            this.luong,
            this.chucVu});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvStaff.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvStaff.EnableHeadersVisualStyles = false;
			this.dgvStaff.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvStaff.Location = new System.Drawing.Point(12, 69);
			this.dgvStaff.Name = "dgvStaff";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvStaff.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvStaff.RowHeadersVisible = false;
			this.dgvStaff.RowHeadersWidth = 51;
			this.dgvStaff.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvStaff.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvStaff.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dgvStaff.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvStaff.RowTemplate.Height = 75;
			this.dgvStaff.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvStaff.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dgvStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvStaff.Size = new System.Drawing.Size(1376, 757);
			this.dgvStaff.TabIndex = 34;
			this.dgvStaff.TabStop = false;
			this.dgvStaff.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
			this.dgvStaff.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvStaff.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dgvStaff.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dgvStaff.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dgvStaff.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dgvStaff.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dgvStaff.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvStaff.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.dgvStaff.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dgvStaff.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.dgvStaff.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dgvStaff.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvStaff.ThemeStyle.HeaderStyle.Height = 50;
			this.dgvStaff.ThemeStyle.ReadOnly = false;
			this.dgvStaff.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvStaff.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvStaff.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.dgvStaff.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgvStaff.ThemeStyle.RowsStyle.Height = 75;
			this.dgvStaff.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvStaff.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
			// maNhanVien
			// 
			this.maNhanVien.HeaderText = "Mã Nhân viên";
			this.maNhanVien.MinimumWidth = 6;
			this.maNhanVien.Name = "maNhanVien";
			this.maNhanVien.ReadOnly = true;
			// 
			// tenNhanVien
			// 
			this.tenNhanVien.HeaderText = "Tên nhân viên";
			this.tenNhanVien.MinimumWidth = 6;
			this.tenNhanVien.Name = "tenNhanVien";
			this.tenNhanVien.ReadOnly = true;
			// 
			// namSinh
			// 
			this.namSinh.HeaderText = "Năm sinh";
			this.namSinh.MinimumWidth = 6;
			this.namSinh.Name = "namSinh";
			this.namSinh.ReadOnly = true;
			// 
			// gioiTinh
			// 
			this.gioiTinh.HeaderText = " Giới Tính";
			this.gioiTinh.MinimumWidth = 6;
			this.gioiTinh.Name = "gioiTinh";
			this.gioiTinh.ReadOnly = true;
			// 
			// soDienThoai
			// 
			this.soDienThoai.HeaderText = "Số điện thoại";
			this.soDienThoai.MinimumWidth = 6;
			this.soDienThoai.Name = "soDienThoai";
			this.soDienThoai.ReadOnly = true;
			// 
			// soNgayNghi
			// 
			this.soNgayNghi.HeaderText = "Ngày nghỉ";
			this.soNgayNghi.MinimumWidth = 6;
			this.soNgayNghi.Name = "soNgayNghi";
			this.soNgayNghi.ReadOnly = true;
			// 
			// luong
			// 
			this.luong.HeaderText = "Lương";
			this.luong.MinimumWidth = 6;
			this.luong.Name = "luong";
			// 
			// chucVu
			// 
			this.chucVu.HeaderText = "Chức vụ";
			this.chucVu.MinimumWidth = 6;
			this.chucVu.Name = "chucVu";
			this.chucVu.ReadOnly = true;
			// 
			// line1
			// 
			this.line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
			this.line1.Location = new System.Drawing.Point(26, 50);
			this.line1.Name = "line1";
			this.line1.Size = new System.Drawing.Size(268, 1);
			this.line1.TabIndex = 32;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
			this.panel1.Controls.Add(this.exportBtn);
			this.panel1.Controls.Add(this.refreshBtn);
			this.panel1.Controls.Add(this.deleteBtn);
			this.panel1.Controls.Add(this.editBtn);
			this.panel1.Controls.Add(this.addBtn);
			this.panel1.Location = new System.Drawing.Point(12, 832);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1376, 54);
			this.panel1.TabIndex = 35;
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
			this.exportBtn.FocusedColor = System.Drawing.Color.Empty;
			this.exportBtn.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 10.2F, System.Drawing.FontStyle.Bold);
			this.exportBtn.ForeColor = System.Drawing.Color.White;
			this.exportBtn.Image = ((System.Drawing.Image)(resources.GetObject("exportBtn.Image")));
			this.exportBtn.ImageSize = new System.Drawing.Size(20, 20);
			this.exportBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.exportBtn.Location = new System.Drawing.Point(116, 6);
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
			this.refreshBtn.CheckedBaseColor = System.Drawing.Color.Gray;
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
			// deleteBtn
			// 
			this.deleteBtn.AnimationHoverSpeed = 0.07F;
			this.deleteBtn.AnimationSpeed = 0.03F;
			this.deleteBtn.BackColor = System.Drawing.Color.Transparent;
			this.deleteBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.deleteBtn.BorderColor = System.Drawing.Color.Black;
			this.deleteBtn.CheckedBaseColor = System.Drawing.Color.Gray;
			this.deleteBtn.CheckedBorderColor = System.Drawing.Color.Black;
			this.deleteBtn.CheckedForeColor = System.Drawing.Color.White;
			this.deleteBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("deleteBtn.CheckedImage")));
			this.deleteBtn.CheckedLineColor = System.Drawing.Color.DimGray;
			this.deleteBtn.DialogResult = System.Windows.Forms.DialogResult.None;
			this.deleteBtn.FocusedColor = System.Drawing.Color.Empty;
			this.deleteBtn.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 10.2F, System.Drawing.FontStyle.Bold);
			this.deleteBtn.ForeColor = System.Drawing.Color.White;
			this.deleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteBtn.Image")));
			this.deleteBtn.ImageSize = new System.Drawing.Size(20, 20);
			this.deleteBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.deleteBtn.Location = new System.Drawing.Point(1288, 6);
			this.deleteBtn.Name = "deleteBtn";
			this.deleteBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.deleteBtn.OnHoverBorderColor = System.Drawing.Color.Transparent;
			this.deleteBtn.OnHoverForeColor = System.Drawing.Color.White;
			this.deleteBtn.OnHoverImage = null;
			this.deleteBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.deleteBtn.OnPressedColor = System.Drawing.Color.Black;
			this.deleteBtn.Radius = 6;
			this.deleteBtn.Size = new System.Drawing.Size(78, 42);
			this.deleteBtn.TabIndex = 6;
			this.deleteBtn.Text = "Xóa";
			this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
			// 
			// editBtn
			// 
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
			this.editBtn.FocusedColor = System.Drawing.Color.Empty;
			this.editBtn.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.editBtn.ForeColor = System.Drawing.Color.White;
			this.editBtn.Image = ((System.Drawing.Image)(resources.GetObject("editBtn.Image")));
			this.editBtn.ImageSize = new System.Drawing.Size(20, 20);
			this.editBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.editBtn.Location = new System.Drawing.Point(1169, 6);
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
			this.addBtn.FocusedColor = System.Drawing.Color.Empty;
			this.addBtn.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.addBtn.ForeColor = System.Drawing.Color.White;
			this.addBtn.Image = ((System.Drawing.Image)(resources.GetObject("addBtn.Image")));
			this.addBtn.ImageSize = new System.Drawing.Size(20, 20);
			this.addBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.addBtn.Location = new System.Drawing.Point(1046, 6);
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
			this.pictureBox1.Location = new System.Drawing.Point(258, 18);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(36, 30);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 33;
			this.pictureBox1.TabStop = false;
			// 
			// gradientPanel1
			// 
			this.gradientPanel1.ColorLeft = System.Drawing.Color.Empty;
			this.gradientPanel1.ColorRight = System.Drawing.Color.Empty;
			this.gradientPanel1.Controls.Add(this.salaryTo);
			this.gradientPanel1.Controls.Add(this.salaryFrom);
			this.gradientPanel1.Controls.Add(this.panel3);
			this.gradientPanel1.Controls.Add(this.panel4);
			this.gradientPanel1.Controls.Add(this.panel2);
			this.gradientPanel1.Controls.Add(this.label1);
			this.gradientPanel1.Location = new System.Drawing.Point(719, 18);
			this.gradientPanel1.Name = "gradientPanel1";
			this.gradientPanel1.Size = new System.Drawing.Size(291, 36);
			this.gradientPanel1.TabIndex = 41;
			// 
			// salaryTo
			// 
			this.salaryTo.BackColor = System.Drawing.Color.Transparent;
			this.salaryTo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
			this.salaryTo.BorderThickness = 0;
			this.salaryTo.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.salaryTo.DefaultText = "";
			this.salaryTo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.salaryTo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.salaryTo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.salaryTo.DisabledState.Parent = this.salaryTo;
			this.salaryTo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.salaryTo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
			this.salaryTo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.salaryTo.FocusedState.Parent = this.salaryTo;
			this.salaryTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.salaryTo.ForeColor = System.Drawing.Color.Black;
			this.salaryTo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.salaryTo.HoverState.Parent = this.salaryTo;
			this.salaryTo.Location = new System.Drawing.Point(178, 3);
			this.salaryTo.Margin = new System.Windows.Forms.Padding(0);
			this.salaryTo.Name = "salaryTo";
			this.salaryTo.PasswordChar = '\0';
			this.salaryTo.PlaceholderText = "Lương đến";
			this.salaryTo.SelectedText = "";
			this.salaryTo.ShadowDecoration.Parent = this.salaryTo;
			this.salaryTo.Size = new System.Drawing.Size(110, 25);
			this.salaryTo.TabIndex = 34;
			this.salaryTo.TextChanged += new System.EventHandler(this.salaryTo_TextChanged);
			// 
			// salaryFrom
			// 
			this.salaryFrom.BackColor = System.Drawing.Color.Transparent;
			this.salaryFrom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
			this.salaryFrom.BorderThickness = 0;
			this.salaryFrom.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.salaryFrom.DefaultText = "";
			this.salaryFrom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.salaryFrom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.salaryFrom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.salaryFrom.DisabledState.Parent = this.salaryFrom;
			this.salaryFrom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.salaryFrom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
			this.salaryFrom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.salaryFrom.FocusedState.Parent = this.salaryFrom;
			this.salaryFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.salaryFrom.ForeColor = System.Drawing.Color.Black;
			this.salaryFrom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.salaryFrom.HoverState.Parent = this.salaryFrom;
			this.salaryFrom.Location = new System.Drawing.Point(21, 4);
			this.salaryFrom.Margin = new System.Windows.Forms.Padding(0);
			this.salaryFrom.Name = "salaryFrom";
			this.salaryFrom.PasswordChar = '\0';
			this.salaryFrom.PlaceholderText = "Lương từ";
			this.salaryFrom.SelectedText = "";
			this.salaryFrom.ShadowDecoration.Parent = this.salaryFrom;
			this.salaryFrom.Size = new System.Drawing.Size(110, 25);
			this.salaryFrom.TabIndex = 32;
			this.salaryFrom.TextChanged += new System.EventHandler(this.salaryFrom_TextChanged);
			// 
			// panel3
			// 
			this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
			this.panel3.Location = new System.Drawing.Point(31, 31);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(100, 1);
			this.panel3.TabIndex = 31;
			// 
			// panel4
			// 
			this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
			this.panel4.Location = new System.Drawing.Point(188, 31);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(100, 1);
			this.panel4.TabIndex = 33;
			// 
			// panel2
			// 
			this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
			this.panel2.Location = new System.Drawing.Point(147, 18);
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
			// StaffManageGUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
			this.ClientSize = new System.Drawing.Size(1400, 845);
			this.Controls.Add(this.gradientPanel1);
			this.Controls.Add(this.searchInput);
			this.Controls.Add(this.genderCbx);
			this.Controls.Add(this.positionCbx);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.dgvStaff);
			this.Controls.Add(this.line1);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "StaffManageGUI";
			this.ShowInTaskbar = false;
			this.Text = "StaffManageGUI";
			this.Load += new System.EventHandler(this.StaffManageGUI_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.gradientPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox searchInput;
        private Guna.UI.WinForms.GunaComboBox genderCbx;
        private Guna.UI.WinForms.GunaComboBox positionCbx;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaAdvenceButton exportBtn;
        private Guna.UI.WinForms.GunaAdvenceButton refreshBtn;
        private Guna.UI.WinForms.GunaDataGridView dgvStaff;
        private System.Windows.Forms.Panel line1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaAdvenceButton deleteBtn;
        private Guna.UI.WinForms.GunaAdvenceButton editBtn;
        private Guna.UI.WinForms.GunaAdvenceButton addBtn;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn namSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn soNgayNghi;
        private System.Windows.Forms.DataGridViewTextBoxColumn luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucVu;
        private GradientPanel gradientPanel1;
        private Guna.UI2.WinForms.Guna2TextBox salaryTo;
        private Guna.UI2.WinForms.Guna2TextBox salaryFrom;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}