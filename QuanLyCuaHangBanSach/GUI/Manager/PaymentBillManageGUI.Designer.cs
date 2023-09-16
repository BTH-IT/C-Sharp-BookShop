namespace QuanLyCuaHangBanSach.GUI.Manager
{
    partial class PaymentBillManageGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentBillManageGUI));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.filterCkx = new Guna.UI.WinForms.GunaMediumCheckBox();
            this.dateTimeTo = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeFrom = new Guna.UI.WinForms.GunaDateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.line1 = new System.Windows.Forms.Panel();
            this.gradientPanel1 = new QuanLyCuaHangBanSach.GradientPanel();
            this.toPriceTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.fromPriceTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.searchInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.staffCbx = new Guna.UI.WinForms.GunaComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.printPdfBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.exportBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.refreshBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.deleteBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.addBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.dgvPaymentBill = new Guna.UI.WinForms.GunaDataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentBill)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Hình Ảnh";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.MinimumWidth = 100;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 106;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.filterCkx);
            this.panel5.Controls.Add(this.dateTimeTo);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.dateTimeFrom);
            this.panel5.Location = new System.Drawing.Point(989, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(400, 36);
            this.panel5.TabIndex = 51;
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
            this.dateTimeTo.TabIndex = 42;
            this.dateTimeTo.Text = "8/30/2023";
            this.dateTimeTo.Value = new System.DateTime(2023, 8, 30, 19, 55, 8, 854);
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
            this.dateTimeFrom.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
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
            this.dateTimeFrom.TabIndex = 40;
            this.dateTimeFrom.Text = "8/30/2023";
            this.dateTimeFrom.Value = new System.DateTime(2023, 8, 30, 19, 55, 8, 854);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(297, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // line1
            // 
            this.line1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
            this.line1.Location = new System.Drawing.Point(22, 40);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(312, 1);
            this.line1.TabIndex = 43;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorLeft = System.Drawing.Color.Empty;
            this.gradientPanel1.ColorRight = System.Drawing.Color.Empty;
            this.gradientPanel1.Controls.Add(this.toPriceTxt);
            this.gradientPanel1.Controls.Add(this.fromPriceTxt);
            this.gradientPanel1.Controls.Add(this.panel3);
            this.gradientPanel1.Controls.Add(this.panel4);
            this.gradientPanel1.Controls.Add(this.panel2);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Location = new System.Drawing.Point(692, 5);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(291, 36);
            this.gradientPanel1.TabIndex = 50;
            // 
            // toPriceTxt
            // 
            this.toPriceTxt.BackColor = System.Drawing.Color.Transparent;
            this.toPriceTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.toPriceTxt.BorderThickness = 0;
            this.toPriceTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.toPriceTxt.DefaultText = "";
            this.toPriceTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.toPriceTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.toPriceTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.toPriceTxt.DisabledState.Parent = this.toPriceTxt;
            this.toPriceTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.toPriceTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.toPriceTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toPriceTxt.FocusedState.Parent = this.toPriceTxt;
            this.toPriceTxt.Font = new System.Drawing.Font("#9Slide03 Cabin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toPriceTxt.ForeColor = System.Drawing.Color.Black;
            this.toPriceTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toPriceTxt.HoverState.Parent = this.toPriceTxt;
            this.toPriceTxt.Location = new System.Drawing.Point(177, 2);
            this.toPriceTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.toPriceTxt.Name = "toPriceTxt";
            this.toPriceTxt.PasswordChar = '\0';
            this.toPriceTxt.PlaceholderText = "Tổng tiền đến";
            this.toPriceTxt.SelectedText = "";
            this.toPriceTxt.ShadowDecoration.Parent = this.toPriceTxt;
            this.toPriceTxt.Size = new System.Drawing.Size(110, 25);
            this.toPriceTxt.TabIndex = 44;
            // 
            // fromPriceTxt
            // 
            this.fromPriceTxt.BackColor = System.Drawing.Color.Transparent;
            this.fromPriceTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.fromPriceTxt.BorderThickness = 0;
            this.fromPriceTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fromPriceTxt.DefaultText = "";
            this.fromPriceTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.fromPriceTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.fromPriceTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fromPriceTxt.DisabledState.Parent = this.fromPriceTxt;
            this.fromPriceTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fromPriceTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.fromPriceTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fromPriceTxt.FocusedState.Parent = this.fromPriceTxt;
            this.fromPriceTxt.Font = new System.Drawing.Font("#9Slide03 Cabin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromPriceTxt.ForeColor = System.Drawing.Color.Black;
            this.fromPriceTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fromPriceTxt.HoverState.Parent = this.fromPriceTxt;
            this.fromPriceTxt.Location = new System.Drawing.Point(21, 4);
            this.fromPriceTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.fromPriceTxt.Name = "fromPriceTxt";
            this.fromPriceTxt.PasswordChar = '\0';
            this.fromPriceTxt.PlaceholderText = "Tổng tiền từ";
            this.fromPriceTxt.SelectedText = "";
            this.fromPriceTxt.ShadowDecoration.Parent = this.fromPriceTxt;
            this.fromPriceTxt.Size = new System.Drawing.Size(110, 25);
            this.fromPriceTxt.TabIndex = 43;
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
            this.label1.Font = new System.Drawing.Font("#9Slide03 Cabin Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 36);
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
            this.searchInput.Font = new System.Drawing.Font("#9Slide03 Cabin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchInput.ForeColor = System.Drawing.Color.Black;
            this.searchInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchInput.HoverState.Parent = this.searchInput;
            this.searchInput.Location = new System.Drawing.Point(13, 5);
            this.searchInput.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.searchInput.Name = "searchInput";
            this.searchInput.PasswordChar = '\0';
            this.searchInput.PlaceholderText = "Tìm kiếm theo mã, đơn nhập hàng";
            this.searchInput.SelectedText = "";
            this.searchInput.ShadowDecoration.Parent = this.searchInput;
            this.searchInput.Size = new System.Drawing.Size(274, 32);
            this.searchInput.TabIndex = 52;
            // 
            // staffCbx
            // 
            this.staffCbx.BackColor = System.Drawing.Color.Transparent;
            this.staffCbx.BaseColor = System.Drawing.Color.White;
            this.staffCbx.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.staffCbx.BorderSize = 1;
            this.staffCbx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.staffCbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.staffCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.staffCbx.FocusedColor = System.Drawing.Color.Empty;
            this.staffCbx.Font = new System.Drawing.Font("#9Slide03 Cabin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffCbx.ForeColor = System.Drawing.Color.Black;
            this.staffCbx.FormattingEnabled = true;
            this.staffCbx.ItemHeight = 30;
            this.staffCbx.Location = new System.Drawing.Point(523, 5);
            this.staffCbx.Name = "staffCbx";
            this.staffCbx.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.staffCbx.OnHoverItemForeColor = System.Drawing.Color.White;
            this.staffCbx.Radius = 6;
            this.staffCbx.Size = new System.Drawing.Size(153, 36);
            this.staffCbx.TabIndex = 48;
            this.staffCbx.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.panel1.Controls.Add(this.printPdfBtn);
            this.panel1.Controls.Add(this.exportBtn);
            this.panel1.Controls.Add(this.refreshBtn);
            this.panel1.Controls.Add(this.deleteBtn);
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Location = new System.Drawing.Point(16, 831);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1371, 54);
            this.panel1.TabIndex = 46;
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
            this.printPdfBtn.FocusedColor = System.Drawing.Color.Empty;
            this.printPdfBtn.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printPdfBtn.ForeColor = System.Drawing.Color.White;
            this.printPdfBtn.Image = ((System.Drawing.Image)(resources.GetObject("printPdfBtn.Image")));
            this.printPdfBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.printPdfBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.printPdfBtn.Location = new System.Drawing.Point(243, 6);
            this.printPdfBtn.Name = "printPdfBtn";
            this.printPdfBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.printPdfBtn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.printPdfBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.printPdfBtn.OnHoverImage = null;
            this.printPdfBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.printPdfBtn.OnPressedColor = System.Drawing.Color.Black;
            this.printPdfBtn.Radius = 6;
            this.printPdfBtn.Size = new System.Drawing.Size(92, 42);
            this.printPdfBtn.TabIndex = 9;
            this.printPdfBtn.Text = "In PDF";
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
            this.deleteBtn.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteBtn.Image")));
            this.deleteBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.deleteBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.deleteBtn.Location = new System.Drawing.Point(1286, 6);
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
            this.addBtn.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Image = ((System.Drawing.Image)(resources.GetObject("addBtn.Image")));
            this.addBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.addBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.addBtn.Location = new System.Drawing.Point(1163, 6);
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
            // 
            // dgvPaymentBill
            // 
            this.dgvPaymentBill.AllowUserToAddRows = false;
            this.dgvPaymentBill.AllowUserToDeleteRows = false;
            this.dgvPaymentBill.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            this.dgvPaymentBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvPaymentBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPaymentBill.BackgroundColor = System.Drawing.Color.White;
            this.dgvPaymentBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPaymentBill.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPaymentBill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("#9Slide03 Cabin", 9F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPaymentBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvPaymentBill.ColumnHeadersHeight = 50;
            this.dgvPaymentBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPaymentBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column1,
            this.Column3,
            this.Column6,
            this.Column2,
            this.Column5,
            this.Column8,
            this.Column7});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("#9Slide03 Cabin", 9F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPaymentBill.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvPaymentBill.EnableHeadersVisualStyles = false;
            this.dgvPaymentBill.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPaymentBill.Location = new System.Drawing.Point(16, 62);
            this.dgvPaymentBill.Name = "dgvPaymentBill";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("#9Slide03 Cabin", 9F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPaymentBill.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvPaymentBill.RowHeadersVisible = false;
            this.dgvPaymentBill.RowHeadersWidth = 51;
            this.dgvPaymentBill.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPaymentBill.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvPaymentBill.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvPaymentBill.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPaymentBill.RowTemplate.Height = 75;
            this.dgvPaymentBill.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPaymentBill.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPaymentBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPaymentBill.Size = new System.Drawing.Size(1371, 763);
            this.dgvPaymentBill.TabIndex = 45;
            this.dgvPaymentBill.TabStop = false;
            this.dgvPaymentBill.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvPaymentBill.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPaymentBill.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPaymentBill.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPaymentBill.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPaymentBill.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPaymentBill.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvPaymentBill.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPaymentBill.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.dgvPaymentBill.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvPaymentBill.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("#9Slide03 Cabin", 9F);
            this.dgvPaymentBill.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPaymentBill.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPaymentBill.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvPaymentBill.ThemeStyle.ReadOnly = false;
            this.dgvPaymentBill.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPaymentBill.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPaymentBill.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("#9Slide03 Cabin", 9F);
            this.dgvPaymentBill.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPaymentBill.ThemeStyle.RowsStyle.Height = 75;
            this.dgvPaymentBill.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPaymentBill.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column9.FillWeight = 50F;
            this.Column9.Frozen = true;
            this.Column9.HeaderText = "";
            this.Column9.MinimumWidth = 50;
            this.Column9.Name = "Column9";
            this.Column9.Width = 50;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 61.60671F;
            this.Column1.HeaderText = "Mã Phiếu Chi";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.ToolTipText = "Mã Phiếu Chi";
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
            // Column6
            // 
            this.Column6.FillWeight = 61.60671F;
            this.Column6.HeaderText = "Mã Đơn Nhập Hàng";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ToolTipText = "Mã Đơn Nhập Hàng";
            // 
            // Column2
            // 
            this.Column2.FillWeight = 61.60671F;
            this.Column2.HeaderText = "Ngày Lập";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.ToolTipText = "Ngày Lập";
            // 
            // Column5
            // 
            this.Column5.FillWeight = 61.60671F;
            this.Column5.HeaderText = "Lí Do";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.ToolTipText = "Lí Do";
            // 
            // Column8
            // 
            this.Column8.FillWeight = 61.60671F;
            this.Column8.HeaderText = "Ghi Chú";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ToolTipText = "Ghi Chú";
            // 
            // Column7
            // 
            this.Column7.FillWeight = 61.60671F;
            this.Column7.HeaderText = "Tổng Tiền Chi";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column7.ToolTipText = "Tổng Tiền Chi";
            // 
            // PaymentBillManageGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1400, 890);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.searchInput);
            this.Controls.Add(this.staffCbx);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvPaymentBill);
            this.Font = new System.Drawing.Font("#9Slide03 Cabin", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PaymentBillManageGUI";
            this.Text = "PaymentBillManageGUI";
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI.WinForms.GunaMediumCheckBox filterCkx;
        private Guna.UI.WinForms.GunaDateTimePicker dateTimeTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaDateTimePicker dateTimeFrom;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel line1;
        private GradientPanel gradientPanel1;
        private Guna.UI2.WinForms.Guna2TextBox toPriceTxt;
        private Guna.UI2.WinForms.Guna2TextBox fromPriceTxt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox searchInput;
        private Guna.UI.WinForms.GunaComboBox staffCbx;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaAdvenceButton printPdfBtn;
        private Guna.UI.WinForms.GunaAdvenceButton exportBtn;
        private Guna.UI.WinForms.GunaAdvenceButton refreshBtn;
        private Guna.UI.WinForms.GunaAdvenceButton deleteBtn;
        private Guna.UI.WinForms.GunaAdvenceButton addBtn;
        private Guna.UI.WinForms.GunaDataGridView dgvPaymentBill;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}