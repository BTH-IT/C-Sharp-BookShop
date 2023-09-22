namespace QuanLyCuaHangBanSach.GUI.UserControls
{
	partial class RefundBookControl
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RefundBookControl));
			this.panel1 = new System.Windows.Forms.Panel();
			this.PlusBtn = new System.Windows.Forms.PictureBox();
			this.MinusBtn = new System.Windows.Forms.PictureBox();
			this.AmountTxt = new System.Windows.Forms.TextBox();
			this.PriceLb = new System.Windows.Forms.Label();
			this.StockLb = new System.Windows.Forms.Label();
			this.NameLb = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.IdLb = new System.Windows.Forms.Label();
			this.DeleteBtn = new Guna.UI2.WinForms.Guna2CircleButton();
			this.BookImage = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PlusBtn)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MinusBtn)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BookImage)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.PlusBtn);
			this.panel1.Controls.Add(this.MinusBtn);
			this.panel1.Controls.Add(this.AmountTxt);
			this.panel1.Location = new System.Drawing.Point(144, 124);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(123, 32);
			this.panel1.TabIndex = 15;
			// 
			// PlusBtn
			// 
			this.PlusBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.PlusBtn.Image = ((System.Drawing.Image)(resources.GetObject("PlusBtn.Image")));
			this.PlusBtn.Location = new System.Drawing.Point(88, 0);
			this.PlusBtn.Margin = new System.Windows.Forms.Padding(4);
			this.PlusBtn.Name = "PlusBtn";
			this.PlusBtn.Size = new System.Drawing.Size(33, 31);
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
			this.MinusBtn.Margin = new System.Windows.Forms.Padding(4);
			this.MinusBtn.Name = "MinusBtn";
			this.MinusBtn.Size = new System.Drawing.Size(33, 31);
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
			this.AmountTxt.Location = new System.Drawing.Point(35, 4);
			this.AmountTxt.Margin = new System.Windows.Forms.Padding(4);
			this.AmountTxt.MaxLength = 999;
			this.AmountTxt.Name = "AmountTxt";
			this.AmountTxt.Size = new System.Drawing.Size(51, 25);
			this.AmountTxt.TabIndex = 2;
			this.AmountTxt.Text = "1";
			this.AmountTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// PriceLb
			// 
			this.PriceLb.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.PriceLb.AutoSize = true;
			this.PriceLb.Font = new System.Drawing.Font("#9Slide03 Cabin Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.PriceLb.ForeColor = System.Drawing.Color.Blue;
			this.PriceLb.Location = new System.Drawing.Point(139, 82);
			this.PriceLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.PriceLb.Name = "PriceLb";
			this.PriceLb.Size = new System.Drawing.Size(56, 30);
			this.PriceLb.TabIndex = 14;
			this.PriceLb.Text = "Price";
			// 
			// StockLb
			// 
			this.StockLb.AutoSize = true;
			this.StockLb.Font = new System.Drawing.Font("#9Slide03 Cabin Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.StockLb.ForeColor = System.Drawing.Color.Gray;
			this.StockLb.Location = new System.Drawing.Point(143, 61);
			this.StockLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.StockLb.Name = "StockLb";
			this.StockLb.Size = new System.Drawing.Size(30, 23);
			this.StockLb.TabIndex = 13;
			this.StockLb.Text = "SL:";
			// 
			// NameLb
			// 
			this.NameLb.AutoEllipsis = true;
			this.NameLb.AutoSize = true;
			this.NameLb.Font = new System.Drawing.Font("#9Slide03 Cabin Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.NameLb.Location = new System.Drawing.Point(142, 15);
			this.NameLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.NameLb.Name = "NameLb";
			this.NameLb.Size = new System.Drawing.Size(99, 26);
			this.NameLb.TabIndex = 12;
			this.NameLb.Text = "Book Name";
			// 
			// IdLb
			// 
			this.IdLb.Location = new System.Drawing.Point(358, 154);
			this.IdLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.IdLb.Name = "IdLb";
			this.IdLb.Size = new System.Drawing.Size(19, 12);
			this.IdLb.TabIndex = 17;
			this.IdLb.Visible = false;
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
			this.DeleteBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.DeleteBtn.ImageOffset = new System.Drawing.Point(-6, -1);
			this.DeleteBtn.ImageSize = new System.Drawing.Size(23, 23);
			this.DeleteBtn.Location = new System.Drawing.Point(331, 3);
			this.DeleteBtn.Margin = new System.Windows.Forms.Padding(4);
			this.DeleteBtn.Name = "DeleteBtn";
			this.DeleteBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.DeleteBtn.ShadowDecoration.Parent = this.DeleteBtn;
			this.DeleteBtn.Size = new System.Drawing.Size(40, 37);
			this.DeleteBtn.TabIndex = 16;
			this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
			// 
			// BookImage
			// 
			this.BookImage.ErrorImage = ((System.Drawing.Image)(resources.GetObject("BookImage.ErrorImage")));
			this.BookImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("BookImage.InitialImage")));
			this.BookImage.Location = new System.Drawing.Point(0, 9);
			this.BookImage.Margin = new System.Windows.Forms.Padding(4);
			this.BookImage.Name = "BookImage";
			this.BookImage.Size = new System.Drawing.Size(133, 146);
			this.BookImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.BookImage.TabIndex = 11;
			this.BookImage.TabStop = false;
			// 
			// RefundBookControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.PriceLb);
			this.Controls.Add(this.StockLb);
			this.Controls.Add(this.NameLb);
			this.Controls.Add(this.IdLb);
			this.Controls.Add(this.DeleteBtn);
			this.Controls.Add(this.BookImage);
			this.Name = "RefundBookControl";
			this.Size = new System.Drawing.Size(377, 169);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PlusBtn)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MinusBtn)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BookImage)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox PlusBtn;
		private System.Windows.Forms.PictureBox MinusBtn;
		internal System.Windows.Forms.TextBox AmountTxt;
		private System.Windows.Forms.Label PriceLb;
		private System.Windows.Forms.Label StockLb;
		private System.Windows.Forms.Label NameLb;
		private System.Windows.Forms.ToolTip toolTip1;
		internal System.Windows.Forms.Label IdLb;
		private Guna.UI2.WinForms.Guna2CircleButton DeleteBtn;
		private System.Windows.Forms.PictureBox BookImage;
	}
}
