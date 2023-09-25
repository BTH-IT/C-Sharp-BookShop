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
			((System.ComponentModel.ISupportInitialize)(this.BookImage)).BeginInit();
			this.SuspendLayout();
			// 
			// PriceLb
			// 
			this.PriceLb.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.PriceLb.AutoSize = true;
			this.PriceLb.Font = new System.Drawing.Font("#9Slide03 Cabin Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.PriceLb.ForeColor = System.Drawing.Color.Blue;
			this.PriceLb.Location = new System.Drawing.Point(120, 98);
			this.PriceLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.PriceLb.Name = "PriceLb";
			this.PriceLb.Size = new System.Drawing.Size(56, 30);
			this.PriceLb.TabIndex = 15;
			this.PriceLb.Text = "Price";
			// 
			// StockLb
			// 
			this.StockLb.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.StockLb.AutoSize = true;
			this.StockLb.Font = new System.Drawing.Font("#9Slide03 Cabin Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.StockLb.ForeColor = System.Drawing.Color.Gray;
			this.StockLb.Location = new System.Drawing.Point(122, 73);
			this.StockLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.StockLb.Name = "StockLb";
			this.StockLb.Size = new System.Drawing.Size(30, 23);
			this.StockLb.TabIndex = 14;
			this.StockLb.Text = "SL:";
			// 
			// NameLb
			// 
			this.NameLb.AutoEllipsis = true;
			this.NameLb.AutoSize = true;
			this.NameLb.Font = new System.Drawing.Font("#9Slide03 Cabin Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.NameLb.ForeColor = System.Drawing.Color.Black;
			this.NameLb.Location = new System.Drawing.Point(122, 8);
			this.NameLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.NameLb.MaximumSize = new System.Drawing.Size(197, 49);
			this.NameLb.Name = "NameLb";
			this.NameLb.Size = new System.Drawing.Size(99, 26);
			this.NameLb.TabIndex = 13;
			this.NameLb.Text = "Book Name";
			// 
			// IdLb
			// 
			this.IdLb.Location = new System.Drawing.Point(312, 130);
			this.IdLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.IdLb.Name = "IdLb";
			this.IdLb.Size = new System.Drawing.Size(19, 12);
			this.IdLb.TabIndex = 16;
			this.IdLb.Visible = false;
			// 
			// BookImage
			// 
			this.BookImage.ErrorImage = ((System.Drawing.Image)(resources.GetObject("BookImage.ErrorImage")));
			this.BookImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("BookImage.InitialImage")));
			this.BookImage.Location = new System.Drawing.Point(6, 3);
			this.BookImage.Margin = new System.Windows.Forms.Padding(4);
			this.BookImage.Name = "BookImage";
			this.BookImage.Size = new System.Drawing.Size(109, 133);
			this.BookImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.BookImage.TabIndex = 12;
			this.BookImage.TabStop = false;
			// 
			// ImportBookControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.PriceLb);
			this.Controls.Add(this.StockLb);
			this.Controls.Add(this.NameLb);
			this.Controls.Add(this.IdLb);
			this.Controls.Add(this.BookImage);
			this.ForeColor = System.Drawing.Color.LightGray;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "ImportBookControl";
			this.Size = new System.Drawing.Size(336, 145);
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
	}
}
