namespace QuanLyCuaHangBanSach.GUI.UserControls
{
	partial class ImportBookControl
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportBookControl));
			this.PriceLb = new System.Windows.Forms.Label();
			this.StockLb = new System.Windows.Forms.Label();
			this.NameLb = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.IdLb = new System.Windows.Forms.Label();
			this.BookImage = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.BookImage)).BeginInit();
			this.SuspendLayout();
			// 
			// PriceLb
			// 
			this.PriceLb.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.PriceLb.AutoSize = true;
			this.PriceLb.Font = new System.Drawing.Font("#9Slide03 Cabin Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.PriceLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.PriceLb.Location = new System.Drawing.Point(90, 80);
			this.PriceLb.Name = "PriceLb";
			this.PriceLb.Size = new System.Drawing.Size(46, 25);
			this.PriceLb.TabIndex = 15;
			this.PriceLb.Text = "Price";
			// 
			// StockLb
			// 
			this.StockLb.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.StockLb.AutoSize = true;
			this.StockLb.Font = new System.Drawing.Font("#9Slide03 Cabin Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.StockLb.ForeColor = System.Drawing.Color.Gray;
			this.StockLb.Location = new System.Drawing.Point(92, 59);
			this.StockLb.Name = "StockLb";
			this.StockLb.Size = new System.Drawing.Size(24, 18);
			this.StockLb.TabIndex = 14;
			this.StockLb.Text = "SL:";
			// 
			// NameLb
			// 
			this.NameLb.AutoEllipsis = true;
			this.NameLb.Font = new System.Drawing.Font("#9Slide03 Cabin Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.NameLb.ForeColor = System.Drawing.Color.Black;
			this.NameLb.Location = new System.Drawing.Point(92, 6);
			this.NameLb.MaximumSize = new System.Drawing.Size(148, 40);
			this.NameLb.Name = "NameLb";
			this.NameLb.Size = new System.Drawing.Size(148, 21);
			this.NameLb.TabIndex = 13;
			this.NameLb.Text = "Book Name";
			// 
			// IdLb
			// 
			this.IdLb.Location = new System.Drawing.Point(234, 106);
			this.IdLb.Name = "IdLb";
			this.IdLb.Size = new System.Drawing.Size(14, 10);
			this.IdLb.TabIndex = 16;
			this.IdLb.Visible = false;
			// 
			// BookImage
			// 
			this.BookImage.ErrorImage = ((System.Drawing.Image)(resources.GetObject("BookImage.ErrorImage")));
			this.BookImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("BookImage.InitialImage")));
			this.BookImage.Location = new System.Drawing.Point(4, 2);
			this.BookImage.Name = "BookImage";
			this.BookImage.Size = new System.Drawing.Size(82, 108);
			this.BookImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.BookImage.TabIndex = 12;
			this.BookImage.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(156, 63);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 15);
			this.label1.TabIndex = 16;
			this.label1.Text = "10";
			this.label1.Visible = false;
			// 
			// ImportBookControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.PriceLb);
			this.Controls.Add(this.StockLb);
			this.Controls.Add(this.NameLb);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.IdLb);
			this.Controls.Add(this.BookImage);
			this.ForeColor = System.Drawing.Color.LightGray;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "ImportBookControl";
			this.Size = new System.Drawing.Size(252, 118);
			this.Click += new System.EventHandler(this.ImportBookControl_Click);
			((System.ComponentModel.ISupportInitialize)(this.BookImage)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label PriceLb;
		private System.Windows.Forms.Label StockLb;
		private System.Windows.Forms.Label NameLb;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Label IdLb;
		private System.Windows.Forms.PictureBox BookImage;
        private System.Windows.Forms.Label label1;
    }
}
