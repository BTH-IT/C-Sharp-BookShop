namespace QuanLyCuaHangBanSach.GUI.Modal
{
    partial class CustomerBillModal
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.errorCustomerMsg = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.customerCbx = new Guna.UI.WinForms.GunaComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.errorSaleMsg = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.saleCbx = new Guna.UI.WinForms.GunaComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.errorBookListMsg = new System.Windows.Forms.Label();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.bookList = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.percentTxt = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.totalPriceTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.nameLine = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelBtn = new Guna.UI.WinForms.GunaButton();
            this.submitBtn = new Guna.UI.WinForms.GunaButton();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.errorCustomerMsg);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.customerCbx);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(594, 88);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // errorCustomerMsg
            // 
            this.errorCustomerMsg.AutoSize = true;
            this.errorCustomerMsg.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.errorCustomerMsg.ForeColor = System.Drawing.Color.Red;
            this.errorCustomerMsg.Location = new System.Drawing.Point(163, 55);
            this.errorCustomerMsg.Name = "errorCustomerMsg";
            this.errorCustomerMsg.Size = new System.Drawing.Size(0, 21);
            this.errorCustomerMsg.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.Location = new System.Drawing.Point(3, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(145, 49);
            this.label13.TabIndex = 9;
            this.label13.Text = "Khách hàng:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.customerCbx.IntegralHeight = false;
            this.customerCbx.ItemHeight = 30;
            this.customerCbx.Location = new System.Drawing.Point(160, 12);
            this.customerCbx.MaxDropDownItems = 10;
            this.customerCbx.Name = "customerCbx";
            this.customerCbx.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.customerCbx.OnHoverItemForeColor = System.Drawing.Color.White;
            this.customerCbx.Radius = 6;
            this.customerCbx.Size = new System.Drawing.Size(408, 36);
            this.customerCbx.TabIndex = 26;
            this.customerCbx.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(11, 64);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1200, 681);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.errorSaleMsg);
            this.panel6.Controls.Add(this.label18);
            this.panel6.Controls.Add(this.saleCbx);
            this.panel6.Location = new System.Drawing.Point(603, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(594, 88);
            this.panel6.TabIndex = 2;
            // 
            // errorSaleMsg
            // 
            this.errorSaleMsg.AutoSize = true;
            this.errorSaleMsg.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.errorSaleMsg.ForeColor = System.Drawing.Color.Red;
            this.errorSaleMsg.Location = new System.Drawing.Point(163, 54);
            this.errorSaleMsg.Name = "errorSaleMsg";
            this.errorSaleMsg.Size = new System.Drawing.Size(0, 21);
            this.errorSaleMsg.TabIndex = 33;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label18.Location = new System.Drawing.Point(3, 3);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(145, 49);
            this.label18.TabIndex = 31;
            this.label18.Text = "Khuyến mãi:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // saleCbx
            // 
            this.saleCbx.BackColor = System.Drawing.Color.Transparent;
            this.saleCbx.BaseColor = System.Drawing.Color.White;
            this.saleCbx.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.saleCbx.BorderSize = 1;
            this.saleCbx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saleCbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.saleCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.saleCbx.FocusedColor = System.Drawing.Color.Empty;
            this.saleCbx.Font = new System.Drawing.Font("#9Slide03 Cabin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleCbx.ForeColor = System.Drawing.Color.Black;
            this.saleCbx.FormattingEnabled = true;
            this.saleCbx.IntegralHeight = false;
            this.saleCbx.ItemHeight = 30;
            this.saleCbx.Location = new System.Drawing.Point(160, 12);
            this.saleCbx.MaxDropDownItems = 10;
            this.saleCbx.Name = "saleCbx";
            this.saleCbx.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.saleCbx.OnHoverItemForeColor = System.Drawing.Color.White;
            this.saleCbx.Radius = 6;
            this.saleCbx.Size = new System.Drawing.Size(408, 36);
            this.saleCbx.TabIndex = 32;
            this.saleCbx.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.errorBookListMsg);
            this.panel4.Controls.Add(this.gunaButton1);
            this.panel4.Controls.Add(this.bookList);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(3, 97);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1194, 478);
            this.panel4.TabIndex = 1;
            // 
            // errorBookListMsg
            // 
            this.errorBookListMsg.AutoSize = true;
            this.errorBookListMsg.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.errorBookListMsg.ForeColor = System.Drawing.Color.Red;
            this.errorBookListMsg.Location = new System.Drawing.Point(422, 435);
            this.errorBookListMsg.Name = "errorBookListMsg";
            this.errorBookListMsg.Size = new System.Drawing.Size(0, 21);
            this.errorBookListMsg.TabIndex = 35;
            // 
            // gunaButton1
            // 
            this.gunaButton1.Animated = true;
            this.gunaButton1.AnimationHoverSpeed = 0.05F;
            this.gunaButton1.AnimationSpeed = 0.05F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.White;
            this.gunaButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.gunaButton1.BorderSize = 1;
            this.gunaButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.PaleTurquoise;
            this.gunaButton1.Font = new System.Drawing.Font("#9Slide03 Cabin Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(960, 15);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.White;
            this.gunaButton1.OnPressedDepth = 0;
            this.gunaButton1.Radius = 12;
            this.gunaButton1.Size = new System.Drawing.Size(214, 50);
            this.gunaButton1.TabIndex = 0;
            this.gunaButton1.TabStop = false;
            this.gunaButton1.Text = "Thêm sách vào danh sách";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // bookList
            // 
            this.bookList.AutoScroll = true;
            this.bookList.Location = new System.Drawing.Point(3, 85);
            this.bookList.Name = "bookList";
            this.bookList.Size = new System.Drawing.Size(1188, 334);
            this.bookList.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(389, 49);
            this.label2.TabIndex = 28;
            this.label2.Text = "Danh sách các sản phẩm";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.percentTxt);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.totalPriceTxt);
            this.panel1.Controls.Add(this.nameLine);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(3, 581);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1194, 88);
            this.panel1.TabIndex = 0;
            // 
            // percentTxt
            // 
            this.percentTxt.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.percentTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.percentTxt.Location = new System.Drawing.Point(218, 16);
            this.percentTxt.Name = "percentTxt";
            this.percentTxt.Size = new System.Drawing.Size(133, 40);
            this.percentTxt.TabIndex = 12;
            this.percentTxt.Text = "Không có";
            this.percentTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(4, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 40);
            this.label5.TabIndex = 11;
            this.label5.Text = "Phần trăm khuyến mãi:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(1130, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "VNĐ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalPriceTxt
            // 
            this.totalPriceTxt.BackColor = System.Drawing.Color.Transparent;
            this.totalPriceTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.totalPriceTxt.BorderThickness = 0;
            this.totalPriceTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.totalPriceTxt.DefaultText = "";
            this.totalPriceTxt.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.totalPriceTxt.DisabledState.FillColor = System.Drawing.Color.White;
            this.totalPriceTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.totalPriceTxt.DisabledState.Parent = this.totalPriceTxt;
            this.totalPriceTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.totalPriceTxt.Enabled = false;
            this.totalPriceTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totalPriceTxt.FocusedState.Parent = this.totalPriceTxt;
            this.totalPriceTxt.Font = new System.Drawing.Font("#9Slide03 Cabin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceTxt.ForeColor = System.Drawing.Color.Black;
            this.totalPriceTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totalPriceTxt.HoverState.Parent = this.totalPriceTxt;
            this.totalPriceTxt.Location = new System.Drawing.Point(760, 14);
            this.totalPriceTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.totalPriceTxt.Name = "totalPriceTxt";
            this.totalPriceTxt.PasswordChar = '\0';
            this.totalPriceTxt.PlaceholderText = "Tổng tiền";
            this.totalPriceTxt.SelectedText = "";
            this.totalPriceTxt.ShadowDecoration.Parent = this.totalPriceTxt;
            this.totalPriceTxt.Size = new System.Drawing.Size(363, 36);
            this.totalPriceTxt.TabIndex = 0;
            // 
            // nameLine
            // 
            this.nameLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
            this.nameLine.Location = new System.Drawing.Point(767, 50);
            this.nameLine.Name = "nameLine";
            this.nameLine.Size = new System.Drawing.Size(414, 1);
            this.nameLine.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(653, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tổng tiền:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("#9Slide03 Cabin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1222, 45);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tạo Đơn Khách Hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.cancelBtn.FocusedColor = System.Drawing.Color.PaleTurquoise;
            this.cancelBtn.Font = new System.Drawing.Font("#9Slide03 Cabin Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.cancelBtn.Image = null;
            this.cancelBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.cancelBtn.Location = new System.Drawing.Point(388, 778);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.cancelBtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.cancelBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.cancelBtn.OnHoverImage = null;
            this.cancelBtn.OnPressedColor = System.Drawing.Color.White;
            this.cancelBtn.Radius = 22;
            this.cancelBtn.Size = new System.Drawing.Size(200, 50);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.TabStop = false;
            this.cancelBtn.Text = "Hủy";
            this.cancelBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.Animated = true;
            this.submitBtn.AnimationHoverSpeed = 0.05F;
            this.submitBtn.AnimationSpeed = 0.05F;
            this.submitBtn.BackColor = System.Drawing.Color.Transparent;
            this.submitBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.submitBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.submitBtn.BorderSize = 2;
            this.submitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.submitBtn.FocusedColor = System.Drawing.Color.PaleTurquoise;
            this.submitBtn.Font = new System.Drawing.Font("#9Slide03 Cabin Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.ForeColor = System.Drawing.Color.White;
            this.submitBtn.Image = null;
            this.submitBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.submitBtn.Location = new System.Drawing.Point(634, 778);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.OnHoverBaseColor = System.Drawing.Color.White;
            this.submitBtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.submitBtn.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.submitBtn.OnHoverImage = null;
            this.submitBtn.OnPressedColor = System.Drawing.Color.Black;
            this.submitBtn.Radius = 22;
            this.submitBtn.Size = new System.Drawing.Size(200, 50);
            this.submitBtn.TabIndex = 2;
            this.submitBtn.TabStop = false;
            this.submitBtn.Text = "Lưu";
            this.submitBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // CustomerBillModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1222, 847);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("#9Slide03 Cabin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CustomerBillModal";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo đơn khách hàng";
            this.Load += new System.EventHandler(this.CustomerBillModal_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label errorCustomerMsg;
        private System.Windows.Forms.Label label13;
        private Guna.UI.WinForms.GunaComboBox customerCbx;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label errorSaleMsg;
        private System.Windows.Forms.Label label18;
        private Guna.UI.WinForms.GunaComboBox saleCbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel nameLine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel bookList;
        private Guna.UI2.WinForms.Guna2TextBox totalPriceTxt;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private System.Windows.Forms.Label errorBookListMsg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label percentTxt;
        private Guna.UI.WinForms.GunaButton cancelBtn;
        private Guna.UI.WinForms.GunaButton submitBtn;
    }
}