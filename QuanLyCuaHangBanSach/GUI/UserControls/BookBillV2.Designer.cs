namespace QuanLyCuaHangBanSach.GUI.UserControls
{
    partial class BookBillV2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookBillV2));
            this.panel7 = new System.Windows.Forms.Panel();
            this.id = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.amountInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.name = new System.Windows.Forms.Label();
            this.priceTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.price = new System.Windows.Forms.Label();
            this.minus = new Guna.UI.WinForms.GunaAdvenceButton();
            this.plus = new Guna.UI.WinForms.GunaAdvenceButton();
            this.close = new System.Windows.Forms.PictureBox();
            this.pictureBook = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel7.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBook)).BeginInit();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.AutoSize = true;
            this.panel7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel7.Controls.Add(this.priceTxt);
            this.panel7.Controls.Add(this.id);
            this.panel7.Controls.Add(this.guna2Panel2);
            this.panel7.Controls.Add(this.close);
            this.panel7.Controls.Add(this.price);
            this.panel7.Controls.Add(this.pictureBook);
            this.panel7.Controls.Add(this.name);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(477, 162);
            this.panel7.TabIndex = 9;
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("#9Slide03 Cabin", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.id.Location = new System.Drawing.Point(202, 11);
            this.id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(117, 24);
            this.id.TabIndex = 7;
            this.id.Text = "Mã: 1";
            this.id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderRadius = 100;
            this.guna2Panel2.Controls.Add(this.amountInput);
            this.guna2Panel2.Controls.Add(this.minus);
            this.guna2Panel2.Controls.Add(this.plus);
            this.guna2Panel2.Location = new System.Drawing.Point(205, 74);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(181, 34);
            this.guna2Panel2.TabIndex = 6;
            // 
            // amountInput
            // 
            this.amountInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.amountInput.DefaultText = "";
            this.amountInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.amountInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.amountInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.amountInput.DisabledState.Parent = this.amountInput;
            this.amountInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.amountInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.amountInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.amountInput.FocusedState.Parent = this.amountInput;
            this.amountInput.Font = new System.Drawing.Font("#9Slide03 Cabin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.amountInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.amountInput.HoverState.Parent = this.amountInput;
            this.amountInput.Location = new System.Drawing.Point(34, 0);
            this.amountInput.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.amountInput.Name = "amountInput";
            this.amountInput.PasswordChar = '\0';
            this.amountInput.PlaceholderText = "";
            this.amountInput.SelectedText = "";
            this.amountInput.ShadowDecoration.Parent = this.amountInput;
            this.amountInput.Size = new System.Drawing.Size(109, 34);
            this.amountInput.TabIndex = 4;
            this.amountInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(200, 34);
            this.name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(185, 31);
            this.name.TabIndex = 1;
            this.name.Text = "Conan";
            // 
            // priceTxt
            // 
            this.priceTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.priceTxt.DefaultText = "";
            this.priceTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.priceTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.priceTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceTxt.DisabledState.Parent = this.priceTxt;
            this.priceTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceTxt.FocusedState.Parent = this.priceTxt;
            this.priceTxt.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceTxt.HoverState.Parent = this.priceTxt;
            this.priceTxt.Location = new System.Drawing.Point(203, 122);
            this.priceTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.PasswordChar = '\0';
            this.priceTxt.PlaceholderText = "";
            this.priceTxt.SelectedText = "";
            this.priceTxt.ShadowDecoration.Parent = this.priceTxt;
            this.priceTxt.Size = new System.Drawing.Size(196, 30);
            this.priceTxt.TabIndex = 9;
            this.priceTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceTxt_KeyPress);
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.price.Location = new System.Drawing.Point(405, 122);
            this.price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(57, 30);
            this.price.TabIndex = 3;
            this.price.Text = "VNĐ";
            this.price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // minus
            // 
            this.minus.AnimationHoverSpeed = 0.07F;
            this.minus.AnimationSpeed = 0.03F;
            this.minus.BackColor = System.Drawing.Color.Transparent;
            this.minus.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.minus.BorderColor = System.Drawing.Color.Black;
            this.minus.CheckedBaseColor = System.Drawing.Color.Gray;
            this.minus.CheckedBorderColor = System.Drawing.Color.Black;
            this.minus.CheckedForeColor = System.Drawing.Color.White;
            this.minus.CheckedImage = ((System.Drawing.Image)(resources.GetObject("minus.CheckedImage")));
            this.minus.CheckedLineColor = System.Drawing.Color.DimGray;
            this.minus.DialogResult = System.Windows.Forms.DialogResult.None;
            this.minus.Dock = System.Windows.Forms.DockStyle.Left;
            this.minus.FocusedColor = System.Drawing.Color.Empty;
            this.minus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.minus.ForeColor = System.Drawing.Color.White;
            this.minus.Image = ((System.Drawing.Image)(resources.GetObject("minus.Image")));
            this.minus.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minus.ImageSize = new System.Drawing.Size(20, 20);
            this.minus.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.minus.Location = new System.Drawing.Point(0, 0);
            this.minus.Margin = new System.Windows.Forms.Padding(2);
            this.minus.Name = "minus";
            this.minus.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(225)))));
            this.minus.OnHoverBorderColor = System.Drawing.Color.Black;
            this.minus.OnHoverForeColor = System.Drawing.Color.White;
            this.minus.OnHoverImage = null;
            this.minus.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.minus.OnPressedColor = System.Drawing.Color.Black;
            this.minus.Size = new System.Drawing.Size(34, 34);
            this.minus.TabIndex = 3;
            this.minus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // plus
            // 
            this.plus.AnimationHoverSpeed = 0.07F;
            this.plus.AnimationSpeed = 0.03F;
            this.plus.BackColor = System.Drawing.Color.Transparent;
            this.plus.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.plus.BorderColor = System.Drawing.Color.Black;
            this.plus.CheckedBaseColor = System.Drawing.Color.Gray;
            this.plus.CheckedBorderColor = System.Drawing.Color.Black;
            this.plus.CheckedForeColor = System.Drawing.Color.White;
            this.plus.CheckedImage = ((System.Drawing.Image)(resources.GetObject("plus.CheckedImage")));
            this.plus.CheckedLineColor = System.Drawing.Color.DimGray;
            this.plus.DialogResult = System.Windows.Forms.DialogResult.None;
            this.plus.Dock = System.Windows.Forms.DockStyle.Right;
            this.plus.FocusedColor = System.Drawing.Color.Empty;
            this.plus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.plus.ForeColor = System.Drawing.Color.White;
            this.plus.Image = ((System.Drawing.Image)(resources.GetObject("plus.Image")));
            this.plus.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.plus.ImageSize = new System.Drawing.Size(20, 20);
            this.plus.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.plus.Location = new System.Drawing.Point(143, 0);
            this.plus.Margin = new System.Windows.Forms.Padding(2);
            this.plus.Name = "plus";
            this.plus.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(225)))));
            this.plus.OnHoverBorderColor = System.Drawing.Color.Black;
            this.plus.OnHoverForeColor = System.Drawing.Color.White;
            this.plus.OnHoverImage = null;
            this.plus.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.plus.OnPressedColor = System.Drawing.Color.Black;
            this.plus.Size = new System.Drawing.Size(38, 34);
            this.plus.TabIndex = 2;
            this.plus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(435, 11);
            this.close.Margin = new System.Windows.Forms.Padding(2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(27, 24);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close.TabIndex = 5;
            this.close.TabStop = false;
            // 
            // pictureBook
            // 
            this.pictureBook.BorderRadius = 12;
            this.pictureBook.Image = ((System.Drawing.Image)(resources.GetObject("pictureBook.Image")));
            this.pictureBook.Location = new System.Drawing.Point(9, 11);
            this.pictureBook.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBook.Name = "pictureBook";
            this.pictureBook.ShadowDecoration.Parent = this.pictureBook;
            this.pictureBook.Size = new System.Drawing.Size(188, 141);
            this.pictureBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBook.TabIndex = 2;
            this.pictureBook.TabStop = false;
            // 
            // BookBillV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.panel7);
            this.Name = "BookBillV2";
            this.Size = new System.Drawing.Size(477, 162);
            this.panel7.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label id;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        public Guna.UI2.WinForms.Guna2TextBox amountInput;
        public Guna.UI.WinForms.GunaAdvenceButton minus;
        public Guna.UI.WinForms.GunaAdvenceButton plus;
        public System.Windows.Forms.PictureBox close;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBook;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label price;
        public Guna.UI2.WinForms.Guna2TextBox priceTxt;
    }
}
