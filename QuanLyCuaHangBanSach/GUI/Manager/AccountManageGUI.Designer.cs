namespace QuanLyCuaHangBanSach.GUI.Manager
{
    partial class AccountManageGUI
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountManageGUI));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnExport = new Guna.UI.WinForms.GunaAdvenceButton();
			this.btnRefresh = new Guna.UI.WinForms.GunaAdvenceButton();
			this.deleteBtn = new Guna.UI.WinForms.GunaAdvenceButton();
			this.btnEdit = new Guna.UI.WinForms.GunaAdvenceButton();
			this.btnAdd = new Guna.UI.WinForms.GunaAdvenceButton();
			this.searchInput = new Guna.UI2.WinForms.Guna2TextBox();
			this.dgvAccount = new Guna.UI.WinForms.GunaDataGridView();
			this.Column11 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.nhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.eMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.matKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.line1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
			this.panel1.Controls.Add(this.btnExport);
			this.panel1.Controls.Add(this.btnRefresh);
			this.panel1.Controls.Add(this.deleteBtn);
			this.panel1.Controls.Add(this.btnEdit);
			this.panel1.Controls.Add(this.btnAdd);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 630);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1044, 54);
			this.panel1.TabIndex = 2;
			// 
			// btnExport
			// 
			this.btnExport.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
			this.btnExport.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
			this.btnExport.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 10.2F, System.Drawing.FontStyle.Bold);
			this.btnExport.ForeColor = System.Drawing.Color.White;
			this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
			this.btnExport.ImageSize = new System.Drawing.Size(20, 20);
			this.btnExport.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.btnExport.Location = new System.Drawing.Point(130, 7);
			this.btnExport.Name = "btnExport";
			this.btnExport.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.btnExport.OnHoverBorderColor = System.Drawing.Color.Transparent;
			this.btnExport.OnHoverForeColor = System.Drawing.Color.White;
			this.btnExport.OnHoverImage = null;
			this.btnExport.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.btnExport.OnPressedColor = System.Drawing.Color.Black;
			this.btnExport.Radius = 6;
			this.btnExport.Size = new System.Drawing.Size(121, 42);
			this.btnExport.TabIndex = 3;
			this.btnExport.Text = "Xuất excel";
			this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
			// 
			// btnRefresh
			// 
			this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
			this.btnRefresh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
			this.btnRefresh.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 10.2F, System.Drawing.FontStyle.Bold);
			this.btnRefresh.ForeColor = System.Drawing.Color.White;
			this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
			this.btnRefresh.ImageSize = new System.Drawing.Size(20, 20);
			this.btnRefresh.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.btnRefresh.Location = new System.Drawing.Point(12, 7);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.btnRefresh.OnHoverBorderColor = System.Drawing.Color.Transparent;
			this.btnRefresh.OnHoverForeColor = System.Drawing.Color.White;
			this.btnRefresh.OnHoverImage = null;
			this.btnRefresh.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.btnRefresh.OnPressedColor = System.Drawing.Color.Black;
			this.btnRefresh.Radius = 6;
			this.btnRefresh.Size = new System.Drawing.Size(107, 42);
			this.btnRefresh.TabIndex = 2;
			this.btnRefresh.Text = "Làm mới";
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
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
			this.deleteBtn.Location = new System.Drawing.Point(954, 6);
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
			this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Right;
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
			this.btnEdit.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
			this.btnEdit.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 10.2F, System.Drawing.FontStyle.Bold);
			this.btnEdit.ForeColor = System.Drawing.Color.White;
			this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
			this.btnEdit.ImageSize = new System.Drawing.Size(20, 20);
			this.btnEdit.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.btnEdit.Location = new System.Drawing.Point(835, 6);
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
			this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
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
			this.btnAdd.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
			this.btnAdd.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 10.2F, System.Drawing.FontStyle.Bold);
			this.btnAdd.ForeColor = System.Drawing.Color.White;
			this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
			this.btnAdd.ImageSize = new System.Drawing.Size(20, 20);
			this.btnAdd.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
			this.btnAdd.Location = new System.Drawing.Point(712, 6);
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
			this.searchInput.Location = new System.Drawing.Point(12, 16);
			this.searchInput.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
			this.searchInput.Name = "searchInput";
			this.searchInput.PasswordChar = '\0';
			this.searchInput.PlaceholderText = "Tìm kiếm theo tên nhân viên, email";
			this.searchInput.SelectedText = "";
			this.searchInput.ShadowDecoration.Parent = this.searchInput;
			this.searchInput.Size = new System.Drawing.Size(266, 34);
			this.searchInput.TabIndex = 1;
			this.searchInput.TextChanged += new System.EventHandler(this.searchInput_TextChanged);
			// 
			// dgvAccount
			// 
			this.dgvAccount.AllowUserToAddRows = false;
			this.dgvAccount.AllowUserToDeleteRows = false;
			this.dgvAccount.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.dgvAccount.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvAccount.BackgroundColor = System.Drawing.Color.White;
			this.dgvAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvAccount.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvAccount.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvAccount.ColumnHeadersHeight = 50;
			this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.nhanVien,
            this.eMail,
            this.matKhau});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvAccount.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvAccount.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvAccount.EnableHeadersVisualStyles = false;
			this.dgvAccount.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvAccount.Location = new System.Drawing.Point(0, 63);
			this.dgvAccount.Name = "dgvAccount";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvAccount.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvAccount.RowHeadersVisible = false;
			this.dgvAccount.RowHeadersWidth = 51;
			this.dgvAccount.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvAccount.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvAccount.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dgvAccount.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvAccount.RowTemplate.Height = 75;
			this.dgvAccount.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvAccount.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dgvAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvAccount.Size = new System.Drawing.Size(1044, 621);
			this.dgvAccount.TabIndex = 0;
			this.dgvAccount.TabStop = false;
			this.dgvAccount.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
			this.dgvAccount.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvAccount.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dgvAccount.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dgvAccount.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dgvAccount.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dgvAccount.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dgvAccount.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvAccount.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.dgvAccount.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dgvAccount.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.dgvAccount.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dgvAccount.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvAccount.ThemeStyle.HeaderStyle.Height = 50;
			this.dgvAccount.ThemeStyle.ReadOnly = false;
			this.dgvAccount.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvAccount.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvAccount.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.dgvAccount.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgvAccount.ThemeStyle.RowsStyle.Height = 75;
			this.dgvAccount.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvAccount.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgvAccount.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccountCell_DoubleClick);
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
			// nhanVien
			// 
			this.nhanVien.HeaderText = "Nhân viên";
			this.nhanVien.MinimumWidth = 6;
			this.nhanVien.Name = "nhanVien";
			this.nhanVien.ReadOnly = true;
			// 
			// eMail
			// 
			this.eMail.HeaderText = "Email";
			this.eMail.MinimumWidth = 6;
			this.eMail.Name = "eMail";
			this.eMail.ReadOnly = true;
			// 
			// matKhau
			// 
			this.matKhau.HeaderText = "Mật khẩu ";
			this.matKhau.MinimumWidth = 6;
			this.matKhau.Name = "matKhau";
			this.matKhau.ReadOnly = true;
			// 
			// line1
			// 
			this.line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
			this.line1.Location = new System.Drawing.Point(19, 51);
			this.line1.Name = "line1";
			this.line1.Size = new System.Drawing.Size(302, 1);
			this.line1.TabIndex = 43;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(285, 19);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(36, 30);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 44;
			this.pictureBox1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Controls.Add(this.searchInput);
			this.panel2.Controls.Add(this.line1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1044, 63);
			this.panel2.TabIndex = 1;
			// 
			// AccountManageGUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
			this.ClientSize = new System.Drawing.Size(1044, 684);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.dgvAccount);
			this.Controls.Add(this.panel2);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.KeyPreview = true;
			this.Name = "AccountManageGUI";
			this.ShowInTaskbar = false;
			this.Text = "AccountMangeGUI";
			this.Load += new System.EventHandler(this.AccountMangeGUI_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaAdvenceButton btnExport;
        private Guna.UI.WinForms.GunaAdvenceButton btnRefresh;
        private Guna.UI.WinForms.GunaAdvenceButton deleteBtn;
        private Guna.UI.WinForms.GunaAdvenceButton btnEdit;
        private Guna.UI.WinForms.GunaAdvenceButton btnAdd;
        private Guna.UI2.WinForms.Guna2TextBox searchInput;
        private Guna.UI.WinForms.GunaDataGridView dgvAccount;
        private System.Windows.Forms.Panel line1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn matKhau;
        private System.Windows.Forms.Panel panel2;
    }
}