namespace QuanLyCuaHangBanSach.GUI.Vendor
{
	partial class ImportCartProductUserControl
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportCartProductUserControl));
			this.NameLb = new System.Windows.Forms.Label();
			this.amountPanel = new System.Windows.Forms.Panel();
			this.PlusBtn = new System.Windows.Forms.PictureBox();
			this.MinusBtn = new System.Windows.Forms.PictureBox();
			this.AmountTxt = new System.Windows.Forms.TextBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.DeleteBtn = new Guna.UI2.WinForms.Guna2CircleButton();
			this.BookImage = new System.Windows.Forms.PictureBox();
			this.IdLb = new System.Windows.Forms.Label();
			this.StockLb = new System.Windows.Forms.Label();
			this.ImportPriceTxb = new Guna.UI2.WinForms.Guna2TextBox();
			this.VndLb = new System.Windows.Forms.Label();
			this.ImportIdLb = new System.Windows.Forms.Label();
			this.ImportIdDetailLb = new System.Windows.Forms.Label();
			this.amountPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PlusBtn)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MinusBtn)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BookImage)).BeginInit();
			this.SuspendLayout();
			// 
			// NameLb
			// 
			this.NameLb.AutoEllipsis = true;
			this.NameLb.Font = new System.Drawing.Font("#9Slide03 Cabin Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.NameLb.Location = new System.Drawing.Point(107, 41);
			this.NameLb.Name = "NameLb";
			this.NameLb.Size = new System.Drawing.Size(171, 21);
			this.NameLb.TabIndex = 1;
			this.NameLb.Text = "Book Name";
			// 
			// amountPanel
			// 
			this.amountPanel.BackColor = System.Drawing.Color.White;
			this.amountPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.amountPanel.Controls.Add(this.PlusBtn);
			this.amountPanel.Controls.Add(this.MinusBtn);
			this.amountPanel.Controls.Add(this.AmountTxt);
			this.amountPanel.Location = new System.Drawing.Point(110, 99);
			this.amountPanel.Name = "amountPanel";
			this.amountPanel.Size = new System.Drawing.Size(93, 26);
			this.amountPanel.TabIndex = 0;
			// 
			// PlusBtn
			// 
			this.PlusBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.PlusBtn.Image = ((System.Drawing.Image)(resources.GetObject("PlusBtn.Image")));
			this.PlusBtn.Location = new System.Drawing.Point(66, 0);
			this.PlusBtn.Name = "PlusBtn";
			this.PlusBtn.Size = new System.Drawing.Size(25, 25);
			this.PlusBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PlusBtn.TabIndex = 1;
			this.PlusBtn.TabStop = false;
			this.PlusBtn.Click += new System.EventHandler(this.PlusBtn_Click);
			// 
			// MinusBtn
			// 
			this.MinusBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.MinusBtn.Image = ((System.Drawing.Image)(resources.GetObject("MinusBtn.Image")));
			this.MinusBtn.Location = new System.Drawing.Point(0, 0);
			this.MinusBtn.Name = "MinusBtn";
			this.MinusBtn.Size = new System.Drawing.Size(25, 25);
			this.MinusBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.MinusBtn.TabIndex = 0;
			this.MinusBtn.TabStop = false;
			this.MinusBtn.Click += new System.EventHandler(this.MinusBtn_Click);
			// 
			// AmountTxt
			// 
			this.AmountTxt.BackColor = System.Drawing.Color.White;
			this.AmountTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.AmountTxt.Font = new System.Drawing.Font("#9Slide03 Cabin Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.AmountTxt.Location = new System.Drawing.Point(26, 3);
			this.AmountTxt.MaxLength = 999;
			this.AmountTxt.Name = "AmountTxt";
			this.AmountTxt.Size = new System.Drawing.Size(38, 20);
			this.AmountTxt.TabIndex = 0;
			this.AmountTxt.Text = "1";
			this.AmountTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.AmountTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AmountTxt_KeyPress);
			this.AmountTxt.Leave += new System.EventHandler(this.AmountTxt_Leave);
			this.AmountTxt.MouseLeave += new System.EventHandler(this.AmountTxt_MouseLeave);
			// 
			// DeleteBtn
			// 
			this.DeleteBtn.CheckedState.Parent = this.DeleteBtn;
			this.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.DeleteBtn.CustomImages.Parent = this.DeleteBtn;
			this.DeleteBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.DeleteBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.DeleteBtn.ForeColor = System.Drawing.Color.White;
			this.DeleteBtn.HoverState.Parent = this.DeleteBtn;
			this.DeleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("DeleteBtn.Image")));
			this.DeleteBtn.ImageOffset = new System.Drawing.Point(0, -1);
			this.DeleteBtn.ImageSize = new System.Drawing.Size(23, 23);
			this.DeleteBtn.Location = new System.Drawing.Point(250, 4);
			this.DeleteBtn.Name = "DeleteBtn";
			this.DeleteBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.DeleteBtn.ShadowDecoration.Parent = this.DeleteBtn;
			this.DeleteBtn.Size = new System.Drawing.Size(30, 30);
			this.DeleteBtn.TabIndex = 1;
			this.DeleteBtn.TabStop = false;
			this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
			// 
			// BookImage
			// 
			this.BookImage.ErrorImage = ((System.Drawing.Image)(resources.GetObject("BookImage.ErrorImage")));
			this.BookImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("BookImage.InitialImage")));
			this.BookImage.Location = new System.Drawing.Point(1, 9);
			this.BookImage.Name = "BookImage";
			this.BookImage.Size = new System.Drawing.Size(100, 119);
			this.BookImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.BookImage.TabIndex = 0;
			this.BookImage.TabStop = false;
			// 
			// IdLb
			// 
			this.IdLb.Location = new System.Drawing.Point(269, 127);
			this.IdLb.Name = "IdLb";
			this.IdLb.Size = new System.Drawing.Size(14, 10);
			this.IdLb.TabIndex = 10;
			this.IdLb.Visible = false;
			// 
			// StockLb
			// 
			this.StockLb.AutoSize = true;
			this.StockLb.Font = new System.Drawing.Font("#9Slide03 Cabin Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.StockLb.ForeColor = System.Drawing.Color.Gray;
			this.StockLb.Location = new System.Drawing.Point(108, 73);
			this.StockLb.Name = "StockLb";
			this.StockLb.Size = new System.Drawing.Size(24, 18);
			this.StockLb.TabIndex = 2;
			this.StockLb.Text = "SL:";
			// 
			// ImportPriceTxb
			// 
			this.ImportPriceTxb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.ImportPriceTxb.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.ImportPriceTxb.DefaultText = "";
			this.ImportPriceTxb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.ImportPriceTxb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.ImportPriceTxb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.ImportPriceTxb.DisabledState.Parent = this.ImportPriceTxb;
			this.ImportPriceTxb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.ImportPriceTxb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.ImportPriceTxb.FocusedState.Parent = this.ImportPriceTxb;
			this.ImportPriceTxb.Font = new System.Drawing.Font("#9Slide03 Cabin Medium", 10F);
			this.ImportPriceTxb.ForeColor = System.Drawing.Color.Black;
			this.ImportPriceTxb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.ImportPriceTxb.HoverState.Parent = this.ImportPriceTxb;
			this.ImportPriceTxb.Location = new System.Drawing.Point(8, 151);
			this.ImportPriceTxb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.ImportPriceTxb.Name = "ImportPriceTxb";
			this.ImportPriceTxb.PasswordChar = '\0';
			this.ImportPriceTxb.PlaceholderForeColor = System.Drawing.Color.DarkGray;
			this.ImportPriceTxb.PlaceholderText = "Giá nhập ...";
			this.ImportPriceTxb.SelectedText = "";
			this.ImportPriceTxb.ShadowDecoration.Parent = this.ImportPriceTxb;
			this.ImportPriceTxb.Size = new System.Drawing.Size(215, 30);
			this.ImportPriceTxb.TabIndex = 1;
			this.ImportPriceTxb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ImportPriceTxb_KeyPress);
			// 
			// VndLb
			// 
			this.VndLb.AutoSize = true;
			this.VndLb.Font = new System.Drawing.Font("#9Slide03 Cabin Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.VndLb.Location = new System.Drawing.Point(233, 153);
			this.VndLb.Margin = new System.Windows.Forms.Padding(20, 30, 3, 5);
			this.VndLb.Name = "VndLb";
			this.VndLb.Size = new System.Drawing.Size(45, 25);
			this.VndLb.TabIndex = 28;
			this.VndLb.Text = "VND";
			this.VndLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ImportIdLb
			// 
			this.ImportIdLb.AutoSize = true;
			this.ImportIdLb.Font = new System.Drawing.Font("#9Slide03 Cabin Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.ImportIdLb.ForeColor = System.Drawing.Color.Gray;
			this.ImportIdLb.Location = new System.Drawing.Point(109, 13);
			this.ImportIdLb.Name = "ImportIdLb";
			this.ImportIdLb.Size = new System.Drawing.Size(51, 18);
			this.ImportIdLb.TabIndex = 30;
			this.ImportIdLb.Text = "Mã đơn:";
			// 
			// ImportIdDetailLb
			// 
			this.ImportIdDetailLb.AutoEllipsis = true;
			this.ImportIdDetailLb.Font = new System.Drawing.Font("#9Slide03 Cabin Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.ImportIdDetailLb.ForeColor = System.Drawing.Color.Gray;
			this.ImportIdDetailLb.Location = new System.Drawing.Point(154, 13);
			this.ImportIdDetailLb.Name = "ImportIdDetailLb";
			this.ImportIdDetailLb.Size = new System.Drawing.Size(90, 18);
			this.ImportIdDetailLb.TabIndex = 31;
			// 
			// ImportCartProductUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.ImportIdDetailLb);
			this.Controls.Add(this.ImportIdLb);
			this.Controls.Add(this.ImportPriceTxb);
			this.Controls.Add(this.VndLb);
			this.Controls.Add(this.IdLb);
			this.Controls.Add(this.DeleteBtn);
			this.Controls.Add(this.amountPanel);
			this.Controls.Add(this.StockLb);
			this.Controls.Add(this.NameLb);
			this.Controls.Add(this.BookImage);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "ImportCartProductUserControl";
			this.Size = new System.Drawing.Size(283, 200);
			this.amountPanel.ResumeLayout(false);
			this.amountPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PlusBtn)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MinusBtn)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BookImage)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox BookImage;
		private System.Windows.Forms.Label NameLb;
		private System.Windows.Forms.PictureBox PlusBtn;
		private System.Windows.Forms.PictureBox MinusBtn;
		private System.Windows.Forms.ToolTip toolTip1;
		internal System.Windows.Forms.Label IdLb;
		internal System.Windows.Forms.TextBox AmountTxt;
		private System.Windows.Forms.Label StockLb;
		private System.Windows.Forms.Label VndLb;
		private System.Windows.Forms.Label ImportIdLb;
		public System.Windows.Forms.Label ImportIdDetailLb;
		public System.Windows.Forms.Panel amountPanel;
		public Guna.UI2.WinForms.Guna2TextBox ImportPriceTxb;
		public Guna.UI2.WinForms.Guna2CircleButton DeleteBtn;
	}
}
