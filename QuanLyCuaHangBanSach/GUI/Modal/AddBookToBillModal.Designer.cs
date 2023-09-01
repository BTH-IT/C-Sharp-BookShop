namespace QuanLyCuaHangBanSach.GUI.Modal
{
    partial class AddBookToBillModal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBookToBillModal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.publisherCbx = new Guna.UI.WinForms.GunaComboBox();
            this.bookTypeCbx = new Guna.UI.WinForms.GunaComboBox();
            this.authorCbx = new Guna.UI.WinForms.GunaComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancelBtn = new Guna.UI.WinForms.GunaButton();
            this.addToProductList = new Guna.UI.WinForms.GunaAdvenceButton();
            this.refreshBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.barcodeBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.searchInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvBook = new Guna.UI.WinForms.GunaDataGridView();
            this.line1 = new System.Windows.Forms.Panel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gradientPanel1 = new QuanLyCuaHangBanSach.GradientPanel();
            this.priceTo = new Guna.UI2.WinForms.Guna2TextBox();
            this.priceFrom = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Column11 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.maSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinhAnh = new System.Windows.Forms.DataGridViewImageColumn();
            this.maTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNhaXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongConLai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // publisherCbx
            // 
            this.publisherCbx.BackColor = System.Drawing.Color.Transparent;
            this.publisherCbx.BaseColor = System.Drawing.Color.White;
            this.publisherCbx.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.publisherCbx.BorderSize = 1;
            this.publisherCbx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.publisherCbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.publisherCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.publisherCbx.FocusedColor = System.Drawing.Color.Empty;
            this.publisherCbx.Font = new System.Drawing.Font("#9Slide03 Cabin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisherCbx.ForeColor = System.Drawing.Color.Black;
            this.publisherCbx.FormattingEnabled = true;
            this.publisherCbx.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.publisherCbx.ItemHeight = 30;
            this.publisherCbx.Location = new System.Drawing.Point(869, 9);
            this.publisherCbx.Margin = new System.Windows.Forms.Padding(3, 3, 100, 3);
            this.publisherCbx.Name = "publisherCbx";
            this.publisherCbx.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.publisherCbx.OnHoverItemForeColor = System.Drawing.Color.White;
            this.publisherCbx.Radius = 6;
            this.publisherCbx.Size = new System.Drawing.Size(200, 36);
            this.publisherCbx.TabIndex = 38;
            this.publisherCbx.TabStop = false;
            this.publisherCbx.SelectedIndexChanged += new System.EventHandler(this.publisherCbx_SelectedIndexChanged);
            // 
            // bookTypeCbx
            // 
            this.bookTypeCbx.BackColor = System.Drawing.Color.Transparent;
            this.bookTypeCbx.BaseColor = System.Drawing.Color.White;
            this.bookTypeCbx.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.bookTypeCbx.BorderSize = 1;
            this.bookTypeCbx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookTypeCbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.bookTypeCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bookTypeCbx.FocusedColor = System.Drawing.Color.Empty;
            this.bookTypeCbx.Font = new System.Drawing.Font("#9Slide03 Cabin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTypeCbx.ForeColor = System.Drawing.Color.Black;
            this.bookTypeCbx.FormattingEnabled = true;
            this.bookTypeCbx.ItemHeight = 30;
            this.bookTypeCbx.Location = new System.Drawing.Point(697, 9);
            this.bookTypeCbx.Name = "bookTypeCbx";
            this.bookTypeCbx.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.bookTypeCbx.OnHoverItemForeColor = System.Drawing.Color.White;
            this.bookTypeCbx.Radius = 6;
            this.bookTypeCbx.Size = new System.Drawing.Size(166, 36);
            this.bookTypeCbx.TabIndex = 37;
            this.bookTypeCbx.TabStop = false;
            this.bookTypeCbx.SelectedIndexChanged += new System.EventHandler(this.bookTypeCbx_SelectedIndexChanged);
            // 
            // authorCbx
            // 
            this.authorCbx.BackColor = System.Drawing.Color.Transparent;
            this.authorCbx.BaseColor = System.Drawing.Color.White;
            this.authorCbx.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.authorCbx.BorderSize = 1;
            this.authorCbx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.authorCbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.authorCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.authorCbx.FocusedColor = System.Drawing.Color.Empty;
            this.authorCbx.Font = new System.Drawing.Font("#9Slide03 Cabin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorCbx.ForeColor = System.Drawing.Color.Black;
            this.authorCbx.FormattingEnabled = true;
            this.authorCbx.ItemHeight = 30;
            this.authorCbx.Location = new System.Drawing.Point(516, 9);
            this.authorCbx.Name = "authorCbx";
            this.authorCbx.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.authorCbx.OnHoverItemForeColor = System.Drawing.Color.White;
            this.authorCbx.Radius = 6;
            this.authorCbx.Size = new System.Drawing.Size(175, 36);
            this.authorCbx.TabIndex = 36;
            this.authorCbx.TabStop = false;
            this.authorCbx.SelectedIndexChanged += new System.EventHandler(this.authorCbx_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.panel1.Controls.Add(this.cancelBtn);
            this.panel1.Controls.Add(this.addToProductList);
            this.panel1.Controls.Add(this.refreshBtn);
            this.panel1.Controls.Add(this.barcodeBtn);
            this.panel1.Location = new System.Drawing.Point(3, 756);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1376, 62);
            this.panel1.TabIndex = 35;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Animated = true;
            this.cancelBtn.AnimationHoverSpeed = 0.05F;
            this.cancelBtn.AnimationSpeed = 0.05F;
            this.cancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.BaseColor = System.Drawing.Color.White;
            this.cancelBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.cancelBtn.BorderSize = 2;
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cancelBtn.FocusedColor = System.Drawing.Color.Empty;
            this.cancelBtn.Font = new System.Drawing.Font("#9Slide03 Cabin Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.cancelBtn.Image = null;
            this.cancelBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.cancelBtn.Location = new System.Drawing.Point(1211, 7);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.cancelBtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.cancelBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.cancelBtn.OnHoverImage = null;
            this.cancelBtn.OnPressedColor = System.Drawing.Color.White;
            this.cancelBtn.Radius = 16;
            this.cancelBtn.Size = new System.Drawing.Size(156, 49);
            this.cancelBtn.TabIndex = 41;
            this.cancelBtn.TabStop = false;
            this.cancelBtn.Text = "Trở về";
            this.cancelBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // addToProductList
            // 
            this.addToProductList.AnimationHoverSpeed = 0.07F;
            this.addToProductList.AnimationSpeed = 0.03F;
            this.addToProductList.BackColor = System.Drawing.Color.Transparent;
            this.addToProductList.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.addToProductList.BorderColor = System.Drawing.Color.Black;
            this.addToProductList.CheckedBaseColor = System.Drawing.Color.Gray;
            this.addToProductList.CheckedBorderColor = System.Drawing.Color.Black;
            this.addToProductList.CheckedForeColor = System.Drawing.Color.White;
            this.addToProductList.CheckedImage = ((System.Drawing.Image)(resources.GetObject("addToProductList.CheckedImage")));
            this.addToProductList.CheckedLineColor = System.Drawing.Color.DimGray;
            this.addToProductList.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addToProductList.FocusedColor = System.Drawing.Color.Empty;
            this.addToProductList.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToProductList.ForeColor = System.Drawing.Color.White;
            this.addToProductList.Image = ((System.Drawing.Image)(resources.GetObject("addToProductList.Image")));
            this.addToProductList.ImageSize = new System.Drawing.Size(20, 20);
            this.addToProductList.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.addToProductList.Location = new System.Drawing.Point(122, 10);
            this.addToProductList.Name = "addToProductList";
            this.addToProductList.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.addToProductList.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.addToProductList.OnHoverForeColor = System.Drawing.Color.White;
            this.addToProductList.OnHoverImage = null;
            this.addToProductList.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.addToProductList.OnPressedColor = System.Drawing.Color.Black;
            this.addToProductList.Radius = 6;
            this.addToProductList.Size = new System.Drawing.Size(240, 42);
            this.addToProductList.TabIndex = 8;
            this.addToProductList.Text = "Thêm vào danh sách sản phẩm";
            this.addToProductList.Click += new System.EventHandler(this.addToProductList_Click);
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
            this.refreshBtn.Location = new System.Drawing.Point(9, 10);
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
            // barcodeBtn
            // 
            this.barcodeBtn.AnimationHoverSpeed = 0.07F;
            this.barcodeBtn.AnimationSpeed = 0.03F;
            this.barcodeBtn.BackColor = System.Drawing.Color.Transparent;
            this.barcodeBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.barcodeBtn.BorderColor = System.Drawing.Color.Black;
            this.barcodeBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.barcodeBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.barcodeBtn.CheckedForeColor = System.Drawing.Color.White;
            this.barcodeBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("barcodeBtn.CheckedImage")));
            this.barcodeBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.barcodeBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.barcodeBtn.FocusedColor = System.Drawing.Color.Empty;
            this.barcodeBtn.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodeBtn.ForeColor = System.Drawing.Color.White;
            this.barcodeBtn.Image = ((System.Drawing.Image)(resources.GetObject("barcodeBtn.Image")));
            this.barcodeBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.barcodeBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.barcodeBtn.Location = new System.Drawing.Point(373, 10);
            this.barcodeBtn.Name = "barcodeBtn";
            this.barcodeBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.barcodeBtn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.barcodeBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.barcodeBtn.OnHoverImage = null;
            this.barcodeBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.barcodeBtn.OnPressedColor = System.Drawing.Color.Black;
            this.barcodeBtn.Radius = 6;
            this.barcodeBtn.Size = new System.Drawing.Size(154, 42);
            this.barcodeBtn.TabIndex = 4;
            this.barcodeBtn.Text = "Quét mã vạch";
            this.barcodeBtn.Click += new System.EventHandler(this.barcodeBtn_Click);
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
            this.searchInput.Location = new System.Drawing.Point(6, 6);
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("#9Slide03 Cabin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBook.ColumnHeadersHeight = 50;
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.maSach,
            this.tenSach,
            this.hinhAnh,
            this.maTacGia,
            this.maTheLoai,
            this.maNhaXuatBan,
            this.giaBan,
            this.giaNhap,
            this.namXuatBan,
            this.soLuongConLai});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("#9Slide03 Cabin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBook.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBook.EnableHeadersVisualStyles = false;
            this.dgvBook.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBook.Location = new System.Drawing.Point(3, 62);
            this.dgvBook.Name = "dgvBook";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("#9Slide03 Cabin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBook.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBook.RowHeadersVisible = false;
            this.dgvBook.RowHeadersWidth = 51;
            this.dgvBook.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBook.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBook.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvBook.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBook.RowTemplate.Height = 75;
            this.dgvBook.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBook.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBook.Size = new System.Drawing.Size(1376, 688);
            this.dgvBook.TabIndex = 34;
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
            this.dgvBook.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("#9Slide03 Cabin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBook.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBook.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBook.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvBook.ThemeStyle.ReadOnly = false;
            this.dgvBook.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBook.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBook.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("#9Slide03 Cabin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBook.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBook.ThemeStyle.RowsStyle.Height = 75;
            this.dgvBook.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBook.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
            this.line1.Location = new System.Drawing.Point(17, 43);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(268, 1);
            this.line1.TabIndex = 32;
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
            this.pictureBox1.Location = new System.Drawing.Point(249, 10);
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
            this.gradientPanel1.Controls.Add(this.priceTo);
            this.gradientPanel1.Controls.Add(this.priceFrom);
            this.gradientPanel1.Controls.Add(this.panel3);
            this.gradientPanel1.Controls.Add(this.panel4);
            this.gradientPanel1.Controls.Add(this.panel2);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Location = new System.Drawing.Point(1088, 10);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(291, 36);
            this.gradientPanel1.TabIndex = 39;
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
            this.priceTo.Font = new System.Drawing.Font("#9Slide03 Cabin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.priceTo.TabIndex = 34;
            this.priceTo.TextChanged += new System.EventHandler(this.priceTo_TextChanged);
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
            this.priceFrom.Font = new System.Drawing.Font("#9Slide03 Cabin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.priceFrom.TabIndex = 32;
            this.priceFrom.TextChanged += new System.EventHandler(this.priceFrom_TextChanged);
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
            this.label1.Size = new System.Drawing.Size(18, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "$";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // maSach
            // 
            this.maSach.HeaderText = "Mã Sách";
            this.maSach.MinimumWidth = 6;
            this.maSach.Name = "maSach";
            this.maSach.ReadOnly = true;
            this.maSach.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.maSach.ToolTipText = "Mã Sách";
            // 
            // tenSach
            // 
            this.tenSach.HeaderText = "Tên Sách";
            this.tenSach.MinimumWidth = 6;
            this.tenSach.Name = "tenSach";
            this.tenSach.ReadOnly = true;
            this.tenSach.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tenSach.ToolTipText = "Tên Sách";
            // 
            // hinhAnh
            // 
            this.hinhAnh.HeaderText = "Hình Ảnh";
            this.hinhAnh.Image = ((System.Drawing.Image)(resources.GetObject("hinhAnh.Image")));
            this.hinhAnh.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.hinhAnh.MinimumWidth = 100;
            this.hinhAnh.Name = "hinhAnh";
            // 
            // maTacGia
            // 
            this.maTacGia.HeaderText = "Tác Giả";
            this.maTacGia.MinimumWidth = 6;
            this.maTacGia.Name = "maTacGia";
            this.maTacGia.ReadOnly = true;
            this.maTacGia.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.maTacGia.ToolTipText = "Tác Giả";
            // 
            // maTheLoai
            // 
            this.maTheLoai.HeaderText = "Thể Loại";
            this.maTheLoai.MinimumWidth = 6;
            this.maTheLoai.Name = "maTheLoai";
            this.maTheLoai.ReadOnly = true;
            this.maTheLoai.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.maTheLoai.ToolTipText = "Thể Loại";
            // 
            // maNhaXuatBan
            // 
            this.maNhaXuatBan.HeaderText = "Nhà Xuất Bản";
            this.maNhaXuatBan.MinimumWidth = 6;
            this.maNhaXuatBan.Name = "maNhaXuatBan";
            this.maNhaXuatBan.ReadOnly = true;
            this.maNhaXuatBan.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.maNhaXuatBan.ToolTipText = "Nhà Xuất Bản";
            // 
            // giaBan
            // 
            this.giaBan.HeaderText = "Giá Bán";
            this.giaBan.MinimumWidth = 6;
            this.giaBan.Name = "giaBan";
            this.giaBan.ReadOnly = true;
            this.giaBan.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.giaBan.ToolTipText = "Giá Bán";
            // 
            // giaNhap
            // 
            this.giaNhap.HeaderText = "Giá Nhập";
            this.giaNhap.MinimumWidth = 6;
            this.giaNhap.Name = "giaNhap";
            this.giaNhap.ReadOnly = true;
            this.giaNhap.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.giaNhap.ToolTipText = "Giá Nhập";
            // 
            // namXuatBan
            // 
            this.namXuatBan.HeaderText = "Năm Xuất Bản";
            this.namXuatBan.MinimumWidth = 6;
            this.namXuatBan.Name = "namXuatBan";
            this.namXuatBan.ReadOnly = true;
            this.namXuatBan.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.namXuatBan.ToolTipText = "Năm Xuất Bản";
            // 
            // soLuongConLai
            // 
            this.soLuongConLai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.soLuongConLai.HeaderText = "Còn Lại";
            this.soLuongConLai.MinimumWidth = 6;
            this.soLuongConLai.Name = "soLuongConLai";
            this.soLuongConLai.ReadOnly = true;
            this.soLuongConLai.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.soLuongConLai.ToolTipText = "Còn Lại";
            this.soLuongConLai.Width = 125;
            // 
            // AddBookToBillModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1382, 817);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.publisherCbx);
            this.Controls.Add(this.bookTypeCbx);
            this.Controls.Add(this.authorCbx);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchInput);
            this.Controls.Add(this.dgvBook);
            this.Controls.Add(this.line1);
            this.Font = new System.Drawing.Font("#9Slide03 Cabin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddBookToBillModal";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm sách vào danh sách sản phẩm của đơn khách hàng";
            this.Load += new System.EventHandler(this.AddBookToBillModal_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox priceTo;
        private Guna.UI2.WinForms.Guna2TextBox priceFrom;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaComboBox publisherCbx;
        private Guna.UI.WinForms.GunaComboBox bookTypeCbx;
        private Guna.UI.WinForms.GunaComboBox authorCbx;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaAdvenceButton refreshBtn;
        private Guna.UI.WinForms.GunaAdvenceButton barcodeBtn;
        private Guna.UI2.WinForms.Guna2TextBox searchInput;
        private Guna.UI.WinForms.GunaDataGridView dgvBook;
        private System.Windows.Forms.Panel line1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private Guna.UI.WinForms.GunaAdvenceButton addToProductList;
        private Guna.UI.WinForms.GunaButton cancelBtn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSach;
        private System.Windows.Forms.DataGridViewImageColumn hinhAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhaXuatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn namXuatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongConLai;
    }
}