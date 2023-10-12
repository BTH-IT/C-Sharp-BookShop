namespace QuanLyCuaHangBanSach.GUI.Vendor
{
    partial class BookUserControl
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
            this.NameLb = new System.Windows.Forms.Label();
            this.StockLb = new System.Windows.Forms.Label();
            this.PriceLb = new System.Windows.Forms.Label();
            this.BookImage = new System.Windows.Forms.PictureBox();
            this.IdLb = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BookImage)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLb
            // 
            this.NameLb.AutoEllipsis = true;
            this.NameLb.AutoSize = true;
            this.NameLb.Font = new System.Drawing.Font("#9Slide03 Cabin Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.NameLb.ForeColor = System.Drawing.Color.Black;
            this.NameLb.Location = new System.Drawing.Point(97, 10);
            this.NameLb.MaximumSize = new System.Drawing.Size(148, 40);
            this.NameLb.Name = "NameLb";
            this.NameLb.Size = new System.Drawing.Size(81, 21);
            this.NameLb.TabIndex = 3;
            this.NameLb.Text = "Book Name";
            // 
            // StockLb
            // 
            this.StockLb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StockLb.AutoSize = true;
            this.StockLb.Font = new System.Drawing.Font("#9Slide03 Cabin Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.StockLb.ForeColor = System.Drawing.Color.Gray;
            this.StockLb.Location = new System.Drawing.Point(97, 70);
            this.StockLb.Name = "StockLb";
            this.StockLb.Size = new System.Drawing.Size(24, 18);
            this.StockLb.TabIndex = 5;
            this.StockLb.Text = "SL:";
            // 
            // PriceLb
            // 
            this.PriceLb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PriceLb.AutoSize = true;
            this.PriceLb.Font = new System.Drawing.Font("#9Slide03 Cabin Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.PriceLb.ForeColor = System.Drawing.Color.Blue;
            this.PriceLb.Location = new System.Drawing.Point(96, 90);
            this.PriceLb.Name = "PriceLb";
            this.PriceLb.Size = new System.Drawing.Size(46, 25);
            this.PriceLb.TabIndex = 6;
            this.PriceLb.Text = "Price";
            // 
            // BookImage
            // 
            this.BookImage.ErrorImage = null;
            this.BookImage.InitialImage = null;
            this.BookImage.Location = new System.Drawing.Point(8, 10);
            this.BookImage.Name = "BookImage";
            this.BookImage.Size = new System.Drawing.Size(82, 108);
            this.BookImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BookImage.TabIndex = 0;
            this.BookImage.TabStop = false;
            // 
            // IdLb
            // 
            this.IdLb.Location = new System.Drawing.Point(238, 108);
            this.IdLb.Name = "IdLb";
            this.IdLb.Size = new System.Drawing.Size(14, 10);
            this.IdLb.TabIndex = 11;
            this.IdLb.Visible = false;
            // 
            // BookUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.IdLb);
            this.Controls.Add(this.PriceLb);
            this.Controls.Add(this.StockLb);
            this.Controls.Add(this.BookImage);
            this.Controls.Add(this.NameLb);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BookUserControl";
            this.Size = new System.Drawing.Size(252, 127);
            this.Click += new System.EventHandler(this.BookUserControl_Click);
            this.MouseLeave += new System.EventHandler(this.BookUserControl_Leave);
            this.MouseHover += new System.EventHandler(this.BookUserControl_Hover);
            ((System.ComponentModel.ISupportInitialize)(this.BookImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BookImage;
        private System.Windows.Forms.Label NameLb;
        private System.Windows.Forms.Label StockLb;
        private System.Windows.Forms.Label PriceLb;
        private System.Windows.Forms.Label IdLb;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
