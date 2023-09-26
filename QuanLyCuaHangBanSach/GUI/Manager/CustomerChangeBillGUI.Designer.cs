namespace QuanLyCuaHangBanSach.GUI.Manager
{
    partial class CustomerChangeBillGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerChangeBillGUI));
            this.staffCbx = new Guna.UI.WinForms.GunaComboBox();
            this.bookWantChangeCbx = new Guna.UI.WinForms.GunaComboBox();
            this.bookNeedChangeCbx = new Guna.UI.WinForms.GunaComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.printPdfBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.exportBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.refreshBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.deleteBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.addBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.dgvCustomerChangeBill = new Guna.UI.WinForms.GunaDataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.line1 = new System.Windows.Forms.Panel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dateTimeFrom = new Guna.UI.WinForms.GunaDateTimePicker();
            this.panel5 = new System.Windows.Forms.Panel();
            this.filterCkx = new Guna.UI.WinForms.GunaMediumCheckBox();
            this.dateTimeTo = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.customerCbx = new Guna.UI.WinForms.GunaComboBox();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerChangeBill)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.SuspendLayout();
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
            this.staffCbx.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.staffCbx.ItemHeight = 30;
            this.staffCbx.Location = new System.Drawing.Point(819, 10);
            this.staffCbx.Margin = new System.Windows.Forms.Padding(3, 3, 100, 3);
            this.staffCbx.Name = "staffCbx";
            this.staffCbx.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.staffCbx.OnHoverItemForeColor = System.Drawing.Color.White;
            this.staffCbx.Radius = 6;
            this.staffCbx.Size = new System.Drawing.Size(159, 36);
            this.staffCbx.TabIndex = 38;
            this.staffCbx.TabStop = false;
            this.staffCbx.SelectedIndexChanged += new System.EventHandler(this.staffCbx_SelectedIndexChanged);
            // 
            // bookWantChangeCbx
            // 
            this.bookWantChangeCbx.BackColor = System.Drawing.Color.Transparent;
            this.bookWantChangeCbx.BaseColor = System.Drawing.Color.White;
            this.bookWantChangeCbx.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.bookWantChangeCbx.BorderSize = 1;
            this.bookWantChangeCbx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookWantChangeCbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.bookWantChangeCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bookWantChangeCbx.FocusedColor = System.Drawing.Color.Empty;
            this.bookWantChangeCbx.Font = new System.Drawing.Font("#9Slide03 Cabin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookWantChangeCbx.ForeColor = System.Drawing.Color.Black;
            this.bookWantChangeCbx.FormattingEnabled = true;
            this.bookWantChangeCbx.ItemHeight = 30;
            this.bookWantChangeCbx.Location = new System.Drawing.Point(626, 10);
            this.bookWantChangeCbx.Name = "bookWantChangeCbx";
            this.bookWantChangeCbx.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.bookWantChangeCbx.OnHoverItemForeColor = System.Drawing.Color.White;
            this.bookWantChangeCbx.Radius = 6;
            this.bookWantChangeCbx.Size = new System.Drawing.Size(187, 36);
            this.bookWantChangeCbx.TabIndex = 37;
            this.bookWantChangeCbx.TabStop = false;
            this.bookWantChangeCbx.SelectedIndexChanged += new System.EventHandler(this.bookWantChangeCbx_SelectedIndexChanged);
            // 
            // bookNeedChangeCbx
            // 
            this.bookNeedChangeCbx.BackColor = System.Drawing.Color.Transparent;
            this.bookNeedChangeCbx.BaseColor = System.Drawing.Color.White;
            this.bookNeedChangeCbx.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.bookNeedChangeCbx.BorderSize = 1;
            this.bookNeedChangeCbx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookNeedChangeCbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.bookNeedChangeCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bookNeedChangeCbx.FocusedColor = System.Drawing.Color.Empty;
            this.bookNeedChangeCbx.Font = new System.Drawing.Font("#9Slide03 Cabin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookNeedChangeCbx.ForeColor = System.Drawing.Color.Black;
            this.bookNeedChangeCbx.FormattingEnabled = true;
            this.bookNeedChangeCbx.ItemHeight = 30;
            this.bookNeedChangeCbx.Location = new System.Drawing.Point(442, 10);
            this.bookNeedChangeCbx.Name = "bookNeedChangeCbx";
            this.bookNeedChangeCbx.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.bookNeedChangeCbx.OnHoverItemForeColor = System.Drawing.Color.White;
            this.bookNeedChangeCbx.Radius = 6;
            this.bookNeedChangeCbx.Size = new System.Drawing.Size(178, 36);
            this.bookNeedChangeCbx.TabIndex = 36;
            this.bookNeedChangeCbx.TabStop = false;
            this.bookNeedChangeCbx.SelectedIndexChanged += new System.EventHandler(this.bookNeedChangeCbx_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Controls.Add(this.printPdfBtn);
            this.panel1.Controls.Add(this.exportBtn);
            this.panel1.Controls.Add(this.refreshBtn);
            this.panel1.Controls.Add(this.deleteBtn);
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Location = new System.Drawing.Point(12, 836);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1371, 54);
            this.panel1.TabIndex = 35;
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
            this.printPdfBtn.CheckedImage = null;
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
            this.printPdfBtn.Click += new System.EventHandler(this.printPdfBtn_Click);
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
            this.deleteBtn.CheckedImage = null;
            this.deleteBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.deleteBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.deleteBtn.FocusedColor = System.Drawing.Color.Empty;
            this.deleteBtn.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteBtn.Image")));
            this.deleteBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.deleteBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.deleteBtn.Location = new System.Drawing.Point(1213, 6);
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
            this.addBtn.Location = new System.Drawing.Point(1090, 6);
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
            // dgvCustomerChangeBill
            // 
            this.dgvCustomerChangeBill.AllowUserToAddRows = false;
            this.dgvCustomerChangeBill.AllowUserToDeleteRows = false;
            this.dgvCustomerChangeBill.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvCustomerChangeBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomerChangeBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomerChangeBill.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomerChangeBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCustomerChangeBill.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCustomerChangeBill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("#9Slide03 Cabin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomerChangeBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustomerChangeBill.ColumnHeadersHeight = 50;
            this.dgvCustomerChangeBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCustomerChangeBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column1,
            this.Column10,
            this.Column6,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column8,
            this.Column4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("#9Slide03 Cabin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomerChangeBill.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCustomerChangeBill.EnableHeadersVisualStyles = false;
            this.dgvCustomerChangeBill.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCustomerChangeBill.Location = new System.Drawing.Point(12, 67);
            this.dgvCustomerChangeBill.Name = "dgvCustomerChangeBill";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("#9Slide03 Cabin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomerChangeBill.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCustomerChangeBill.RowHeadersVisible = false;
            this.dgvCustomerChangeBill.RowHeadersWidth = 51;
            this.dgvCustomerChangeBill.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomerChangeBill.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCustomerChangeBill.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvCustomerChangeBill.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomerChangeBill.RowTemplate.Height = 75;
            this.dgvCustomerChangeBill.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomerChangeBill.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCustomerChangeBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomerChangeBill.Size = new System.Drawing.Size(1371, 763);
            this.dgvCustomerChangeBill.TabIndex = 34;
            this.dgvCustomerChangeBill.TabStop = false;
            this.dgvCustomerChangeBill.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvCustomerChangeBill.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCustomerChangeBill.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCustomerChangeBill.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCustomerChangeBill.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCustomerChangeBill.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCustomerChangeBill.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCustomerChangeBill.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCustomerChangeBill.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.dgvCustomerChangeBill.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCustomerChangeBill.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("#9Slide03 Cabin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCustomerChangeBill.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCustomerChangeBill.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCustomerChangeBill.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvCustomerChangeBill.ThemeStyle.ReadOnly = false;
            this.dgvCustomerChangeBill.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCustomerChangeBill.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCustomerChangeBill.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("#9Slide03 Cabin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCustomerChangeBill.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCustomerChangeBill.ThemeStyle.RowsStyle.Height = 75;
            this.dgvCustomerChangeBill.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCustomerChangeBill.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.Column1.HeaderText = "Mã Phiếu";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.ToolTipText = "Mã Phiếu";
            // 
            // Column10
            // 
            this.Column10.FillWeight = 61.60671F;
            this.Column10.HeaderText = "Mã Khách Hàng";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column10.ToolTipText = "Mã Khách Hàng";
            // 
            // Column6
            // 
            this.Column6.FillWeight = 61.60671F;
            this.Column6.HeaderText = "Mã Sách Cần Đổi";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ToolTipText = "Mã Sách Cần Đổi";
            // 
            // Column2
            // 
            this.Column2.FillWeight = 61.60671F;
            this.Column2.HeaderText = "Mã Sách Muốn Đổi";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.ToolTipText = "Mã Sách Muốn Đổi";
            // 
            // Column3
            // 
            this.Column3.FillWeight = 61.60671F;
            this.Column3.HeaderText = "Mã Nhân Viên";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.ToolTipText = "Mã Nhân Viên";
            // 
            // Column5
            // 
            this.Column5.FillWeight = 61.60671F;
            this.Column5.HeaderText = "Tình Trạng Sản Phẩm";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.ToolTipText = "Tình Trạng Sản Phẩm";
            // 
            // Column8
            // 
            this.Column8.FillWeight = 61.60671F;
            this.Column8.HeaderText = "Lý Do";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ToolTipText = "Lý Do";
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
            // Column7
            // 
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // line1
            // 
            this.line1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
            this.line1.Location = new System.Drawing.Point(18, 46);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(240, 1);
            this.line1.TabIndex = 32;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Hình Ảnh";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.MinimumWidth = 100;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 106;
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
            this.dateTimeFrom.ValueChanged += new System.EventHandler(this.dateTimeFrom_ValueChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.filterCkx);
            this.panel5.Controls.Add(this.dateTimeTo);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.dateTimeFrom);
            this.panel5.Location = new System.Drawing.Point(985, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(400, 36);
            this.panel5.TabIndex = 41;
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
            this.searchInput.Location = new System.Drawing.Point(7, 10);
            this.searchInput.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.searchInput.Name = "searchInput";
            this.searchInput.PasswordChar = '\0';
            this.searchInput.PlaceholderText = "Tìm kiếm theo mã đơn";
            this.searchInput.SelectedText = "";
            this.searchInput.ShadowDecoration.Parent = this.searchInput;
            this.searchInput.Size = new System.Drawing.Size(196, 32);
            this.searchInput.TabIndex = 42;
            this.searchInput.TextChanged += new System.EventHandler(this.searchInput_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(220, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // customerCbx
            // 
            this.customerCbx.BackColor = System.Drawing.Color.Transparent;
            this.customerCbx.BaseColor = System.Drawing.Color.White;
            this.customerCbx.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.customerCbx.BorderSize = 1;
            this.customerCbx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customerCbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.customerCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerCbx.FocusedColor = System.Drawing.Color.Empty;
            this.customerCbx.Font = new System.Drawing.Font("#9Slide03 Cabin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerCbx.ForeColor = System.Drawing.Color.Black;
            this.customerCbx.FormattingEnabled = true;
            this.customerCbx.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.customerCbx.ItemHeight = 30;
            this.customerCbx.Location = new System.Drawing.Point(264, 10);
            this.customerCbx.Margin = new System.Windows.Forms.Padding(3, 3, 100, 3);
            this.customerCbx.Name = "customerCbx";
            this.customerCbx.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.customerCbx.OnHoverItemForeColor = System.Drawing.Color.White;
            this.customerCbx.Radius = 6;
            this.customerCbx.Size = new System.Drawing.Size(168, 36);
            this.customerCbx.TabIndex = 43;
            this.customerCbx.TabStop = false;
            this.customerCbx.SelectedIndexChanged += new System.EventHandler(this.customerCbx_SelectedIndexChanged);
            // 
            // closeBtn
            // 
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.Location = new System.Drawing.Point(1297, 6);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(69, 40);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeBtn.TabIndex = 49;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // CustomerChangeBillGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1400, 890);
            this.Controls.Add(this.customerCbx);
            this.Controls.Add(this.searchInput);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.staffCbx);
            this.Controls.Add(this.bookWantChangeCbx);
            this.Controls.Add(this.bookNeedChangeCbx);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvCustomerChangeBill);
            this.Controls.Add(this.line1);
            this.Font = new System.Drawing.Font("#9Slide03 Cabin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CustomerChangeBillGUI";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerChangeBillGUI";
            this.Load += new System.EventHandler(this.CustomerChangeBillGUI_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerChangeBill)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaComboBox staffCbx;
        private Guna.UI.WinForms.GunaComboBox bookWantChangeCbx;
        private Guna.UI.WinForms.GunaComboBox bookNeedChangeCbx;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaAdvenceButton exportBtn;
        private Guna.UI.WinForms.GunaAdvenceButton refreshBtn;
        private Guna.UI.WinForms.GunaAdvenceButton deleteBtn;
        private Guna.UI.WinForms.GunaAdvenceButton addBtn;
        private Guna.UI.WinForms.GunaDataGridView dgvCustomerChangeBill;
        private System.Windows.Forms.Panel line1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private Guna.UI.WinForms.GunaDateTimePicker dateTimeFrom;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI.WinForms.GunaDateTimePicker dateTimeTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaMediumCheckBox filterCkx;
        private Guna.UI2.WinForms.Guna2TextBox searchInput;
        private Guna.UI.WinForms.GunaAdvenceButton printPdfBtn;
        private Guna.UI.WinForms.GunaComboBox customerCbx;
        private System.Windows.Forms.PictureBox closeBtn;
    }
}