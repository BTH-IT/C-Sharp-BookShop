using QuanLyCuaHangBanSach.GUI.Manager;

namespace QuanLyCuaHangBanTacGia.GUI.Manager
{
    partial class AuthorGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorGUI));
            this.line1 = new System.Windows.Forms.Panel();
            this.dgvAuthor = new Guna.UI.WinForms.GunaDataGridView();
            this.Column11 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.searchInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.genderCbx = new Guna.UI.WinForms.GunaComboBox();
            this.exportBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.refreshBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.editBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.addBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthor)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
            this.line1.Location = new System.Drawing.Point(26, 44);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(268, 1);
            this.line1.TabIndex = 21;
            // 
            // dgvAuthor
            // 
            this.dgvAuthor.AllowUserToAddRows = false;
            this.dgvAuthor.AllowUserToDeleteRows = false;
            this.dgvAuthor.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.dgvAuthor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAuthor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAuthor.BackgroundColor = System.Drawing.Color.White;
            this.dgvAuthor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAuthor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAuthor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAuthor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvAuthor.ColumnHeadersHeight = 50;
            this.dgvAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAuthor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column9,
            this.trangThai});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAuthor.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvAuthor.EnableHeadersVisualStyles = false;
            this.dgvAuthor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAuthor.Location = new System.Drawing.Point(12, 69);
            this.dgvAuthor.Name = "dgvAuthor";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAuthor.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvAuthor.RowHeadersVisible = false;
            this.dgvAuthor.RowHeadersWidth = 51;
            this.dgvAuthor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAuthor.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvAuthor.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvAuthor.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAuthor.RowTemplate.Height = 75;
            this.dgvAuthor.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAuthor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvAuthor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAuthor.Size = new System.Drawing.Size(1376, 756);
            this.dgvAuthor.TabIndex = 23;
            this.dgvAuthor.TabStop = false;
            this.dgvAuthor.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvAuthor.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAuthor.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAuthor.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAuthor.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAuthor.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAuthor.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvAuthor.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAuthor.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.dgvAuthor.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvAuthor.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAuthor.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAuthor.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAuthor.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvAuthor.ThemeStyle.ReadOnly = false;
            this.dgvAuthor.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAuthor.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAuthor.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAuthor.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvAuthor.ThemeStyle.RowsStyle.Height = 75;
            this.dgvAuthor.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAuthor.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvAuthor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAuthor_CellDoubleClick);
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
            this.Column1.HeaderText = "Mã Tác Giả";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.ToolTipText = "Mã Tác Giả";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Tác Giả";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.ToolTipText = "Tên Tác Giả";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Giới Tính";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.ToolTipText = "Giới Tính";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Năm Sinh";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column9.ToolTipText = "Năm Sinh";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.panel1.Controls.Add(this.exportBtn);
            this.panel1.Controls.Add(this.refreshBtn);
            this.panel1.Controls.Add(this.editBtn);
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Location = new System.Drawing.Point(13, 832);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1372, 54);
            this.panel1.TabIndex = 24;
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
            this.searchInput.Size = new System.Drawing.Size(236, 36);
            this.searchInput.TabIndex = 31;
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
            this.genderCbx.Location = new System.Drawing.Point(1200, 12);
            this.genderCbx.Name = "genderCbx";
            this.genderCbx.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.genderCbx.OnHoverItemForeColor = System.Drawing.Color.White;
            this.genderCbx.Radius = 6;
            this.genderCbx.Size = new System.Drawing.Size(185, 36);
            this.genderCbx.TabIndex = 32;
            this.genderCbx.TabStop = false;
            this.genderCbx.SelectedIndexChanged += new System.EventHandler(this.genderCbx_SelectedIndexChanged);
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
            this.exportBtn.CheckedImage = null;
            this.exportBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.exportBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.exportBtn.FocusedColor = System.Drawing.Color.Empty;
            this.exportBtn.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.refreshBtn.CheckedImage = null;
            this.refreshBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.refreshBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.refreshBtn.FocusedColor = System.Drawing.Color.Empty;
            this.refreshBtn.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.editBtn.CheckedImage = null;
            this.editBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.editBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.editBtn.FocusedColor = System.Drawing.Color.Empty;
            this.editBtn.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.Image = ((System.Drawing.Image)(resources.GetObject("editBtn.Image")));
            this.editBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.editBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.editBtn.Location = new System.Drawing.Point(1256, 6);
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
            this.addBtn.CheckedImage = null;
            this.addBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.addBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addBtn.FocusedColor = System.Drawing.Color.Empty;
            this.addBtn.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Image = ((System.Drawing.Image)(resources.GetObject("addBtn.Image")));
            this.addBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.addBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.addBtn.Location = new System.Drawing.Point(1133, 6);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(258, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // trangThai
            // 
            this.trangThai.HeaderText = "Trạng Thái";
            this.trangThai.MinimumWidth = 6;
            this.trangThai.Name = "trangThai";
            // 
            // AuthorGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1400, 896);
            this.Controls.Add(this.genderCbx);
            this.Controls.Add(this.searchInput);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvAuthor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.line1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AuthorGUI";
            this.ShowInTaskbar = false;
            this.Text = "BookManageGUI";
            this.Load += new System.EventHandler(this.AuthorGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthor)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel line1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaDataGridView dgvAuthor;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaAdvenceButton addBtn;
        private Guna.UI.WinForms.GunaAdvenceButton editBtn;
        private Guna.UI.WinForms.GunaAdvenceButton refreshBtn;
        //private GradientPanel gradientPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaAdvenceButton exportBtn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private Guna.UI2.WinForms.Guna2TextBox searchInput;
        private Guna.UI.WinForms.GunaComboBox genderCbx;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThai;
    }
}