namespace QuanLyCuaHangBanSach.GUI.Manager
{
    partial class SeoManageGUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeoManageGUI));
            this.searchInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvSale = new Guna.UI.WinForms.GunaDataGridView();
            this.Column11 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.maKhuyenMai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKhuyenMai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phanTram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.line1 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExport = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnRefresh = new Guna.UI.WinForms.GunaAdvenceButton();
            this.deleteBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnEdit = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnAdd = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.filterCkx = new Guna.UI.WinForms.GunaMediumCheckBox();
            this.dateTimeTo = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeFrom = new Guna.UI.WinForms.GunaDateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.searchInput.Location = new System.Drawing.Point(13, 12);
            this.searchInput.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.searchInput.Name = "searchInput";
            this.searchInput.PasswordChar = '\0';
            this.searchInput.PlaceholderText = "Tìm kiếm theo mã, tên";
            this.searchInput.SelectedText = "";
            this.searchInput.ShadowDecoration.Parent = this.searchInput;
            this.searchInput.Size = new System.Drawing.Size(236, 36);
            this.searchInput.TabIndex = 40;
            this.searchInput.TextChanged += new System.EventHandler(this.searchInput_TextChanged);
            // 
            // dgvSale
            // 
            this.dgvSale.AllowUserToAddRows = false;
            this.dgvSale.AllowUserToDeleteRows = false;
            this.dgvSale.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.dgvSale.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSale.BackgroundColor = System.Drawing.Color.White;
            this.dgvSale.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSale.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSale.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSale.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvSale.ColumnHeadersHeight = 50;
            this.dgvSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.maKhuyenMai,
            this.tenKhuyenMai,
            this.phanTram,
            this.ngayBatDau,
            this.ngayKetThuc});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSale.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvSale.EnableHeadersVisualStyles = false;
            this.dgvSale.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSale.Location = new System.Drawing.Point(12, 69);
            this.dgvSale.Name = "dgvSale";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSale.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvSale.RowHeadersVisible = false;
            this.dgvSale.RowHeadersWidth = 51;
            this.dgvSale.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSale.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvSale.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvSale.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSale.RowTemplate.Height = 75;
            this.dgvSale.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSale.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSale.Size = new System.Drawing.Size(1376, 757);
            this.dgvSale.TabIndex = 34;
            this.dgvSale.TabStop = false;
            this.dgvSale.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvSale.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSale.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvSale.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvSale.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvSale.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvSale.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvSale.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSale.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.dgvSale.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvSale.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dgvSale.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSale.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSale.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvSale.ThemeStyle.ReadOnly = false;
            this.dgvSale.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSale.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSale.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dgvSale.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvSale.ThemeStyle.RowsStyle.Height = 75;
            this.dgvSale.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSale.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvSale.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCell_CellDoubleClick);
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
            // maKhuyenMai
            // 
            this.maKhuyenMai.HeaderText = "Mã khuyến mãi";
            this.maKhuyenMai.MinimumWidth = 6;
            this.maKhuyenMai.Name = "maKhuyenMai";
            this.maKhuyenMai.ReadOnly = true;
            // 
            // tenKhuyenMai
            // 
            this.tenKhuyenMai.HeaderText = "Tên Khuyến mãi";
            this.tenKhuyenMai.MinimumWidth = 6;
            this.tenKhuyenMai.Name = "tenKhuyenMai";
            this.tenKhuyenMai.ReadOnly = true;
            // 
            // phanTram
            // 
            this.phanTram.HeaderText = "Phần Trăm";
            this.phanTram.MinimumWidth = 6;
            this.phanTram.Name = "phanTram";
            this.phanTram.ReadOnly = true;
            // 
            // ngayBatDau
            // 
            this.ngayBatDau.HeaderText = "Ngày Bắt đầu";
            this.ngayBatDau.MinimumWidth = 6;
            this.ngayBatDau.Name = "ngayBatDau";
            this.ngayBatDau.ReadOnly = true;
            // 
            // ngayKetThuc
            // 
            this.ngayKetThuc.HeaderText = "Ngày kết thúc";
            this.ngayKetThuc.MinimumWidth = 6;
            this.ngayKetThuc.Name = "ngayKetThuc";
            this.ngayKetThuc.ReadOnly = true;
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
            this.line1.Location = new System.Drawing.Point(26, 53);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(268, 1);
            this.line1.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.deleteBtn);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Location = new System.Drawing.Point(12, 832);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1376, 54);
            this.panel1.TabIndex = 35;
            // 
            // btnExport
            // 
            this.btnExport.AnimationHoverSpeed = 0.07F;
            this.btnExport.AnimationSpeed = 0.03F;
            this.btnExport.BackColor = System.Drawing.Color.Transparent;
            this.btnExport.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.btnExport.BorderColor = System.Drawing.Color.Black;
            this.btnExport.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnExport.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnExport.CheckedForeColor = System.Drawing.Color.White;
            this.btnExport.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnExport.CheckedImage")));
            this.btnExport.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnExport.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExport.FocusedColor = System.Drawing.Color.Empty;
            this.btnExport.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.ImageSize = new System.Drawing.Size(20, 20);
            this.btnExport.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnExport.Location = new System.Drawing.Point(116, 6);
            this.btnExport.Name = "btnExport";
            this.btnExport.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.btnExport.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnExport.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExport.OnHoverImage = null;
            this.btnExport.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnExport.OnPressedColor = System.Drawing.Color.Black;
            this.btnExport.Radius = 6;
            this.btnExport.Size = new System.Drawing.Size(121, 42);
            this.btnExport.TabIndex = 8;
            this.btnExport.Text = "Xuất excel";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.AnimationHoverSpeed = 0.07F;
            this.btnRefresh.AnimationSpeed = 0.03F;
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.btnRefresh.BorderColor = System.Drawing.Color.Black;
            this.btnRefresh.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnRefresh.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnRefresh.CheckedForeColor = System.Drawing.Color.White;
            this.btnRefresh.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.CheckedImage")));
            this.btnRefresh.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnRefresh.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRefresh.FocusedColor = System.Drawing.Color.Empty;
            this.btnRefresh.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRefresh.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnRefresh.Location = new System.Drawing.Point(3, 6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.btnRefresh.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnRefresh.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRefresh.OnHoverImage = null;
            this.btnRefresh.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnRefresh.OnPressedColor = System.Drawing.Color.Black;
            this.btnRefresh.Radius = 6;
            this.btnRefresh.Size = new System.Drawing.Size(107, 42);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
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
            this.deleteBtn.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AnimationHoverSpeed = 0.07F;
            this.btnEdit.AnimationSpeed = 0.03F;
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.btnEdit.BorderColor = System.Drawing.Color.Black;
            this.btnEdit.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnEdit.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnEdit.CheckedForeColor = System.Drawing.Color.White;
            this.btnEdit.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.CheckedImage")));
            this.btnEdit.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnEdit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEdit.FocusedColor = System.Drawing.Color.Empty;
            this.btnEdit.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEdit.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnEdit.Location = new System.Drawing.Point(1169, 6);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.btnEdit.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnEdit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEdit.OnHoverImage = null;
            this.btnEdit.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnEdit.OnPressedColor = System.Drawing.Color.Black;
            this.btnEdit.Radius = 6;
            this.btnEdit.Size = new System.Drawing.Size(113, 42);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Chỉnh sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AnimationHoverSpeed = 0.07F;
            this.btnAdd.AnimationSpeed = 0.03F;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.btnAdd.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnAdd.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAdd.CheckedForeColor = System.Drawing.Color.White;
            this.btnAdd.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.CheckedImage")));
            this.btnAdd.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdd.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAdd.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAdd.Location = new System.Drawing.Point(1046, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Radius = 6;
            this.btnAdd.Size = new System.Drawing.Size(117, 42);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.filterCkx);
            this.panel5.Controls.Add(this.dateTimeTo);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.dateTimeFrom);
            this.panel5.Location = new System.Drawing.Point(882, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(400, 36);
            this.panel5.TabIndex = 42;
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
            this.filterCkx.TabIndex = 42;
            this.filterCkx.CheckedChanged += new System.EventHandler(this.filterCkx_CheckChanged);
            // 
            // dateTimeTo
            // 
            this.dateTimeTo.BackColor = System.Drawing.Color.Transparent;
            this.dateTimeTo.BaseColor = System.Drawing.Color.White;
            this.dateTimeTo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.dateTimeTo.BorderSize = 1;
            this.dateTimeTo.CustomFormat = null;
            this.dateTimeTo.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimeTo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.dateTimeTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dateTimeTo.TabIndex = 42;
            this.dateTimeTo.Text = "8/30/2023";
            this.dateTimeTo.Value = new System.DateTime(2023, 8, 30, 19, 55, 8, 854);
            this.dateTimeTo.ValueChanged += new System.EventHandler(this.dateTimeTo_ValueChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(217, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 36);
            this.label3.TabIndex = 41;
            this.label3.Text = "- Đến :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 37);
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
            this.dateTimeFrom.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.dateTimeFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dateTimeFrom.TabIndex = 40;
            this.dateTimeFrom.Text = "8/30/2023";
            this.dateTimeFrom.Value = new System.DateTime(2023, 8, 30, 19, 55, 8, 854);
            this.dateTimeFrom.ValueChanged += new System.EventHandler(this.dateTimeFrom_Changed);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(258, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // SeoManageGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1400, 845);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.searchInput);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvSale);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SeoManageGUI";
            this.ShowInTaskbar = false;
            this.Text = "SeoManageGUI";
            this.Load += new System.EventHandler(this.salesManagaer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox searchInput;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaAdvenceButton btnExport;
        private Guna.UI.WinForms.GunaAdvenceButton btnRefresh;
        private Guna.UI.WinForms.GunaDataGridView dgvSale;
        private System.Windows.Forms.Panel line1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaAdvenceButton deleteBtn;
        private Guna.UI.WinForms.GunaAdvenceButton btnEdit;
        private Guna.UI.WinForms.GunaAdvenceButton btnAdd;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhuyenMai;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhuyenMai;
        private System.Windows.Forms.DataGridViewTextBoxColumn phanTram;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayKetThuc;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI.WinForms.GunaMediumCheckBox filterCkx;
        private Guna.UI.WinForms.GunaDateTimePicker dateTimeTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaDateTimePicker dateTimeFrom;
    }
}