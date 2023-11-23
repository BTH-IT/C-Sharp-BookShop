namespace QuanLyCuaHangBanSach.GUI.Manager
{
    partial class BookManageGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookManageGUI));
            this.line1 = new System.Windows.Forms.Panel();
            this.dgvBook = new Guna.UI.WinForms.GunaDataGridView();
            this.Column11 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.exportBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.refreshBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.deleteBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.editBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.addBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.authorCbx = new Guna.UI.WinForms.GunaComboBox();
            this.bookTypeCbx = new Guna.UI.WinForms.GunaComboBox();
            this.publisherCbx = new Guna.UI.WinForms.GunaComboBox();
            this.searchInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.gradientPanel1 = new QuanLyCuaHangBanSach.GradientPanel();
            this.priceTo = new Guna.UI2.WinForms.Guna2TextBox();
            this.priceFrom = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
            this.line1.Location = new System.Drawing.Point(26, 42);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(211, 1);
            this.line1.TabIndex = 21;
            // 
            // dgvBook
            // 
            this.dgvBook.AllowUserToAddRows = false;
            this.dgvBook.AllowUserToDeleteRows = false;
            this.dgvBook.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvBook.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBook.BackgroundColor = System.Drawing.Color.White;
            this.dgvBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBook.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBook.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBook.ColumnHeadersHeight = 67;
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.Column1,
            this.Column2,
            this.Column10,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column6});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBook.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBook.EnableHeadersVisualStyles = false;
            this.dgvBook.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBook.Location = new System.Drawing.Point(0, 61);
            this.dgvBook.Name = "dgvBook";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBook.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBook.RowHeadersVisible = false;
            this.dgvBook.RowHeadersWidth = 51;
            this.dgvBook.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("#9Slide03 Cabin", 10F);
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBook.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBook.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvBook.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBook.RowTemplate.Height = 115;
            this.dgvBook.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBook.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBook.Size = new System.Drawing.Size(1044, 569);
            this.dgvBook.TabIndex = 23;
            this.dgvBook.TabStop = false;
            this.dgvBook.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvBook.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBook.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvBook.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvBook.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvBook.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvBook.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvBook.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBook.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.dgvBook.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvBook.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBook.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBook.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBook.ThemeStyle.HeaderStyle.Height = 67;
            this.dgvBook.ThemeStyle.ReadOnly = false;
            this.dgvBook.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBook.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBook.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBook.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBook.ThemeStyle.RowsStyle.Height = 115;
            this.dgvBook.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBook.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBook.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBook_CellDoubleClick);
            this.dgvBook.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.dgvBook_SortCompare);
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
            this.Column1.HeaderText = "Mã Sách";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.ToolTipText = "Mã Sách";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Sách";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.ToolTipText = "Tên Sách";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Hình Ảnh";
            this.Column10.Image = ((System.Drawing.Image)(resources.GetObject("Column10.Image")));
            this.Column10.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column10.MinimumWidth = 80;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tác Giả";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.ToolTipText = "Tác Giả";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Thể Loại";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.ToolTipText = "Thể Loại";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Nhà Xuất Bản";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.ToolTipText = "Nhà Xuất Bản";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Giá Bán";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column7.ToolTipText = "Giá Bán";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Giá Nhập";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column8.ToolTipText = "Giá Nhập";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Năm Xuất Bản";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column9.ToolTipText = "Năm Xuất Bản";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Còn Lại";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column6.ToolTipText = "Còn Lại";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.panel1.Controls.Add(this.gunaAdvenceButton1);
            this.panel1.Controls.Add(this.exportBtn);
            this.panel1.Controls.Add(this.refreshBtn);
            this.panel1.Controls.Add(this.deleteBtn);
            this.panel1.Controls.Add(this.editBtn);
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 630);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 54);
            this.panel1.TabIndex = 2;
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.CheckedImage")));
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 10.2F, System.Drawing.FontStyle.Bold);
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.Image")));
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(233, 6);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Radius = 6;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(110, 42);
            this.gunaAdvenceButton1.TabIndex = 12;
            this.gunaAdvenceButton1.Text = "In mã vạch";
            this.gunaAdvenceButton1.Click += new System.EventHandler(this.gunaAdvenceButton1_Click_1);
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
            this.exportBtn.Size = new System.Drawing.Size(111, 42);
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
            this.refreshBtn.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
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
            this.refreshBtn.Click += new System.EventHandler(this.gunaAdvenceButton4_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
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
            this.deleteBtn.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
            this.deleteBtn.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 10.2F, System.Drawing.FontStyle.Bold);
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteBtn.Image")));
            this.deleteBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.deleteBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.deleteBtn.Location = new System.Drawing.Point(956, 6);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.deleteBtn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.deleteBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.deleteBtn.OnHoverImage = null;
            this.deleteBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.deleteBtn.OnPressedColor = System.Drawing.Color.Black;
            this.deleteBtn.Radius = 6;
            this.deleteBtn.Size = new System.Drawing.Size(78, 42);
            this.deleteBtn.TabIndex = 11;
            this.deleteBtn.Text = "Xóa";
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
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
            this.editBtn.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.Image = ((System.Drawing.Image)(resources.GetObject("editBtn.Image")));
            this.editBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.editBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.editBtn.Location = new System.Drawing.Point(847, 6);
            this.editBtn.Name = "editBtn";
            this.editBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.editBtn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.editBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.editBtn.OnHoverImage = null;
            this.editBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.editBtn.OnPressedColor = System.Drawing.Color.Black;
            this.editBtn.Radius = 6;
            this.editBtn.Size = new System.Drawing.Size(103, 42);
            this.editBtn.TabIndex = 10;
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
            this.addBtn.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Image = ((System.Drawing.Image)(resources.GetObject("addBtn.Image")));
            this.addBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.addBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.addBtn.Location = new System.Drawing.Point(733, 6);
            this.addBtn.Name = "addBtn";
            this.addBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.addBtn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.addBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.addBtn.OnHoverImage = null;
            this.addBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.addBtn.OnPressedColor = System.Drawing.Color.Black;
            this.addBtn.Radius = 6;
            this.addBtn.Size = new System.Drawing.Size(108, 42);
            this.addBtn.TabIndex = 9;
            this.addBtn.Text = "Thêm mới";
            this.addBtn.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
            // 
            // authorCbx
            // 
            this.authorCbx.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.authorCbx.BackColor = System.Drawing.Color.Transparent;
            this.authorCbx.BaseColor = System.Drawing.Color.White;
            this.authorCbx.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.authorCbx.BorderSize = 1;
            this.authorCbx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.authorCbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.authorCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.authorCbx.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
            this.authorCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorCbx.ForeColor = System.Drawing.Color.Black;
            this.authorCbx.FormattingEnabled = true;
            this.authorCbx.IntegralHeight = false;
            this.authorCbx.ItemHeight = 30;
            this.authorCbx.Location = new System.Drawing.Point(243, 7);
            this.authorCbx.MaxDropDownItems = 10;
            this.authorCbx.Name = "authorCbx";
            this.authorCbx.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.authorCbx.OnHoverItemForeColor = System.Drawing.Color.White;
            this.authorCbx.Radius = 6;
            this.authorCbx.Size = new System.Drawing.Size(134, 36);
            this.authorCbx.TabIndex = 2;
            this.authorCbx.SelectedIndexChanged += new System.EventHandler(this.authorCbx_SelectedIndexChanged);
            // 
            // bookTypeCbx
            // 
            this.bookTypeCbx.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bookTypeCbx.BackColor = System.Drawing.Color.Transparent;
            this.bookTypeCbx.BaseColor = System.Drawing.Color.White;
            this.bookTypeCbx.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.bookTypeCbx.BorderSize = 1;
            this.bookTypeCbx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookTypeCbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.bookTypeCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bookTypeCbx.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
            this.bookTypeCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTypeCbx.ForeColor = System.Drawing.Color.Black;
            this.bookTypeCbx.FormattingEnabled = true;
            this.bookTypeCbx.IntegralHeight = false;
            this.bookTypeCbx.ItemHeight = 30;
            this.bookTypeCbx.Location = new System.Drawing.Point(383, 7);
            this.bookTypeCbx.MaxDropDownItems = 10;
            this.bookTypeCbx.Name = "bookTypeCbx";
            this.bookTypeCbx.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.bookTypeCbx.OnHoverItemForeColor = System.Drawing.Color.White;
            this.bookTypeCbx.Radius = 6;
            this.bookTypeCbx.Size = new System.Drawing.Size(139, 36);
            this.bookTypeCbx.TabIndex = 3;
            this.bookTypeCbx.SelectedIndexChanged += new System.EventHandler(this.bookTypeCbx_SelectedIndexChanged);
            // 
            // publisherCbx
            // 
            this.publisherCbx.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.publisherCbx.BackColor = System.Drawing.Color.Transparent;
            this.publisherCbx.BaseColor = System.Drawing.Color.White;
            this.publisherCbx.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.publisherCbx.BorderSize = 1;
            this.publisherCbx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.publisherCbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.publisherCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.publisherCbx.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
            this.publisherCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisherCbx.ForeColor = System.Drawing.Color.Black;
            this.publisherCbx.FormattingEnabled = true;
            this.publisherCbx.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.publisherCbx.IntegralHeight = false;
            this.publisherCbx.ItemHeight = 30;
            this.publisherCbx.Location = new System.Drawing.Point(528, 7);
            this.publisherCbx.Margin = new System.Windows.Forms.Padding(3, 3, 100, 3);
            this.publisherCbx.MaxDropDownItems = 10;
            this.publisherCbx.Name = "publisherCbx";
            this.publisherCbx.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.publisherCbx.OnHoverItemForeColor = System.Drawing.Color.White;
            this.publisherCbx.Radius = 6;
            this.publisherCbx.Size = new System.Drawing.Size(136, 36);
            this.publisherCbx.TabIndex = 4;
            this.publisherCbx.SelectedIndexChanged += new System.EventHandler(this.publisherCbx_SelectedIndexChanged);
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
            this.searchInput.Location = new System.Drawing.Point(15, 7);
            this.searchInput.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.searchInput.Name = "searchInput";
            this.searchInput.PasswordChar = '\0';
            this.searchInput.PlaceholderText = "Tìm kiếm theo mã, tên";
            this.searchInput.SelectedText = "";
            this.searchInput.ShadowDecoration.Parent = this.searchInput;
            this.searchInput.Size = new System.Drawing.Size(179, 30);
            this.searchInput.TabIndex = 1;
            this.searchInput.TextChanged += new System.EventHandler(this.searchInput_TextChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.searchInput);
            this.panel5.Controls.Add(this.bookTypeCbx);
            this.panel5.Controls.Add(this.gradientPanel1);
            this.panel5.Controls.Add(this.authorCbx);
            this.panel5.Controls.Add(this.line1);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.publisherCbx);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1044, 61);
            this.panel5.TabIndex = 1;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gradientPanel1.ColorLeft = System.Drawing.Color.Empty;
            this.gradientPanel1.ColorRight = System.Drawing.Color.Empty;
            this.gradientPanel1.Controls.Add(this.priceTo);
            this.gradientPanel1.Controls.Add(this.priceFrom);
            this.gradientPanel1.Controls.Add(this.panel3);
            this.gradientPanel1.Controls.Add(this.panel4);
            this.gradientPanel1.Controls.Add(this.panel2);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Location = new System.Drawing.Point(743, 7);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(291, 36);
            this.gradientPanel1.TabIndex = 30;
            // 
            // priceTo
            // 
            this.priceTo.BackColor = System.Drawing.Color.Transparent;
            this.priceTo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.priceTo.BorderThickness = 0;
            this.priceTo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.priceTo.DefaultText = "";
            this.priceTo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.priceTo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.priceTo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceTo.DisabledState.Parent = this.priceTo;
            this.priceTo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceTo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.priceTo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceTo.FocusedState.Parent = this.priceTo;
            this.priceTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTo.ForeColor = System.Drawing.Color.Black;
            this.priceTo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceTo.HoverState.Parent = this.priceTo;
            this.priceTo.Location = new System.Drawing.Point(178, 3);
            this.priceTo.Margin = new System.Windows.Forms.Padding(0);
            this.priceTo.Name = "priceTo";
            this.priceTo.PasswordChar = '\0';
            this.priceTo.PlaceholderText = "Giá bán đến";
            this.priceTo.SelectedText = "";
            this.priceTo.ShadowDecoration.Parent = this.priceTo;
            this.priceTo.Size = new System.Drawing.Size(110, 25);
            this.priceTo.TabIndex = 6;
            this.priceTo.TextChanged += new System.EventHandler(this.DebounceTextBox_TextChanged);
            this.priceTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceTo_KeyPress);
            // 
            // priceFrom
            // 
            this.priceFrom.BackColor = System.Drawing.Color.Transparent;
            this.priceFrom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.priceFrom.BorderThickness = 0;
            this.priceFrom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.priceFrom.DefaultText = "";
            this.priceFrom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.priceFrom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.priceFrom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceFrom.DisabledState.Parent = this.priceFrom;
            this.priceFrom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceFrom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.priceFrom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceFrom.FocusedState.Parent = this.priceFrom;
            this.priceFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceFrom.ForeColor = System.Drawing.Color.Black;
            this.priceFrom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceFrom.HoverState.Parent = this.priceFrom;
            this.priceFrom.Location = new System.Drawing.Point(21, 4);
            this.priceFrom.Margin = new System.Windows.Forms.Padding(0);
            this.priceFrom.Name = "priceFrom";
            this.priceFrom.PasswordChar = '\0';
            this.priceFrom.PlaceholderText = "Giá bán từ";
            this.priceFrom.SelectedText = "";
            this.priceFrom.ShadowDecoration.Parent = this.priceFrom;
            this.priceFrom.Size = new System.Drawing.Size(110, 25);
            this.priceFrom.TabIndex = 5;
            this.priceFrom.TextChanged += new System.EventHandler(this.DebounceTextBox_TextChanged);
            this.priceFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceFrom_KeyPress);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(201, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Hình Ảnh";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.MinimumWidth = 80;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 99;
            // 
            // BookManageGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1044, 684);
            this.Controls.Add(this.dgvBook);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BookManageGUI";
            this.ShowInTaskbar = false;
            this.Text = "BookManageGUI";
            this.Load += new System.EventHandler(this.BookManageGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel line1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaDataGridView dgvBook;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaComboBox authorCbx;
        private Guna.UI.WinForms.GunaComboBox bookTypeCbx;
        private Guna.UI.WinForms.GunaComboBox publisherCbx;
        private Guna.UI.WinForms.GunaAdvenceButton addBtn;
        private Guna.UI.WinForms.GunaAdvenceButton editBtn;
        private Guna.UI.WinForms.GunaAdvenceButton deleteBtn;
        private Guna.UI.WinForms.GunaAdvenceButton refreshBtn;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaAdvenceButton exportBtn;
        private Guna.UI2.WinForms.Guna2TextBox searchInput;
        private Guna.UI2.WinForms.Guna2TextBox priceTo;
        private Guna.UI2.WinForms.Guna2TextBox priceFrom;
        private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Column11;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewImageColumn Column10;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
    }
}