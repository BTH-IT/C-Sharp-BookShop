using BookShop_CNPM.GUI.Vendor;

namespace BookShop_CNPM.GUI.UserControls
{
    partial class CartProductImportControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartProductImportControl));
            this.NameLb = new System.Windows.Forms.Label();
            this.StockLb = new System.Windows.Forms.Label();
            this.PriceLb = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PlusBtn = new System.Windows.Forms.PictureBox();
            this.MinusBtn = new System.Windows.Forms.PictureBox();
            this.AmountTxt = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.EditBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.BookImage = new System.Windows.Forms.PictureBox();
            this.IdLb = new System.Windows.Forms.Label();
            this.soluong = new System.Windows.Forms.Label();
            this.index = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlusBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinusBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookImage)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLb
            // 
            this.NameLb.AutoEllipsis = true;
            this.NameLb.AutoSize = true;
            this.NameLb.Font = new System.Drawing.Font("#9Slide03 Cabin Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.NameLb.Location = new System.Drawing.Point(143, 17);
            this.NameLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLb.Name = "NameLb";
            this.NameLb.Size = new System.Drawing.Size(99, 26);
            this.NameLb.TabIndex = 1;
            this.NameLb.Text = "Book Name";
            // 
            // StockLb
            // 
            this.StockLb.AutoSize = true;
            this.StockLb.Font = new System.Drawing.Font("#9Slide03 Cabin Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.StockLb.ForeColor = System.Drawing.Color.Gray;
            this.StockLb.Location = new System.Drawing.Point(144, 63);
            this.StockLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StockLb.Name = "StockLb";
            this.StockLb.Size = new System.Drawing.Size(30, 23);
            this.StockLb.TabIndex = 2;
            this.StockLb.Text = "SL:";
            // 
            // PriceLb
            // 
            this.PriceLb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PriceLb.AutoSize = true;
            this.PriceLb.Font = new System.Drawing.Font("#9Slide03 Cabin Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.PriceLb.ForeColor = System.Drawing.Color.Blue;
            this.PriceLb.Location = new System.Drawing.Point(140, 84);
            this.PriceLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PriceLb.Name = "PriceLb";
            this.PriceLb.Size = new System.Drawing.Size(56, 30);
            this.PriceLb.TabIndex = 7;
            this.PriceLb.Text = "Price";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.PlusBtn);
            this.panel1.Controls.Add(this.MinusBtn);
            this.panel1.Controls.Add(this.AmountTxt);
            this.panel1.Location = new System.Drawing.Point(145, 126);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 32);
            this.panel1.TabIndex = 8;
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
            this.AmountTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AmountTxt_KeyPress);
            this.AmountTxt.Leave += new System.EventHandler(this.AmountTxt_Leave);
            this.AmountTxt.MouseLeave += new System.EventHandler(this.AmountTxt_MouseLeave);
            // 
            // EditBtn
            // 
            this.EditBtn.CheckedState.Parent = this.EditBtn;
            this.EditBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditBtn.CustomImages.Parent = this.EditBtn;
            this.EditBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.EditBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EditBtn.ForeColor = System.Drawing.Color.White;
            this.EditBtn.HoverState.Parent = this.EditBtn;
            this.EditBtn.Image = ((System.Drawing.Image)(resources.GetObject("EditBtn.Image")));
            this.EditBtn.ImageOffset = new System.Drawing.Point(0, -1);
            this.EditBtn.ImageSize = new System.Drawing.Size(23, 23);
            this.EditBtn.Location = new System.Drawing.Point(335, 5);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(4);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.EditBtn.ShadowDecoration.Parent = this.EditBtn;
            this.EditBtn.Size = new System.Drawing.Size(40, 37);
            this.EditBtn.TabIndex = 9;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // BookImage
            // 
            this.BookImage.ErrorImage = null;
            this.BookImage.InitialImage = null;
            this.BookImage.Location = new System.Drawing.Point(1, 11);
            this.BookImage.Margin = new System.Windows.Forms.Padding(4);
            this.BookImage.Name = "BookImage";
            this.BookImage.Size = new System.Drawing.Size(133, 146);
            this.BookImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BookImage.TabIndex = 0;
            this.BookImage.TabStop = false;
            // 
            // IdLb
            // 
            this.IdLb.Location = new System.Drawing.Point(359, 156);
            this.IdLb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IdLb.Name = "IdLb";
            this.IdLb.Size = new System.Drawing.Size(19, 12);
            this.IdLb.TabIndex = 10;
            this.IdLb.Visible = false;
            // 
            // soluong
            // 
            this.soluong.Location = new System.Drawing.Point(303, 146);
            this.soluong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.soluong.Name = "soluong";
            this.soluong.Size = new System.Drawing.Size(19, 12);
            this.soluong.TabIndex = 11;
            this.soluong.Visible = false;
            // 
            // index
            // 
            this.index.Location = new System.Drawing.Point(354, 112);
            this.index.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.index.Name = "index";
            this.index.Size = new System.Drawing.Size(19, 12);
            this.index.TabIndex = 12;
            this.index.Visible = false;
            // 
            // CartProductImportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.index);
            this.Controls.Add(this.soluong);
            this.Controls.Add(this.IdLb);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PriceLb);
            this.Controls.Add(this.StockLb);
            this.Controls.Add(this.NameLb);
            this.Controls.Add(this.BookImage);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CartProductImportControl";
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

        private System.Windows.Forms.PictureBox BookImage;
        private System.Windows.Forms.Label NameLb;
        private System.Windows.Forms.Label StockLb;
        private System.Windows.Forms.Label PriceLb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PlusBtn;
        private System.Windows.Forms.PictureBox MinusBtn;
        private System.Windows.Forms.ToolTip toolTip1;
        private Guna.UI2.WinForms.Guna2CircleButton EditBtn;
        internal System.Windows.Forms.Label IdLb;
        internal System.Windows.Forms.TextBox AmountTxt;
        internal System.Windows.Forms.Label soluong;
        internal System.Windows.Forms.Label index;
    }
}
