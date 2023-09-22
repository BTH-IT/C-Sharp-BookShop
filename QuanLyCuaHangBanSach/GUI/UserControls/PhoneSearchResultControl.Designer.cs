namespace QuanLyCuaHangBanSach.GUI.Vendor
{
    partial class PhoneSearchResultControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhoneSearchResultControl));
            this.NameLb = new Guna.UI.WinForms.GunaLabel();
            this.PhoneLb = new Guna.UI.WinForms.GunaLabel();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLb
            // 
            this.NameLb.AutoSize = true;
            this.NameLb.Font = new System.Drawing.Font("#9Slide03 Cabin Bold", 12F, System.Drawing.FontStyle.Bold);
            this.NameLb.Location = new System.Drawing.Point(44, 0);
            this.NameLb.Name = "NameLb";
            this.NameLb.Size = new System.Drawing.Size(139, 25);
            this.NameLb.TabIndex = 0;
            this.NameLb.Text = "Nguyen Phuc Huy";
            // 
            // PhoneLb
            // 
            this.PhoneLb.AutoSize = true;
            this.PhoneLb.Font = new System.Drawing.Font("#9Slide03 Cabin Bold", 8F, System.Drawing.FontStyle.Bold);
            this.PhoneLb.ForeColor = System.Drawing.Color.Gray;
            this.PhoneLb.Location = new System.Drawing.Point(46, 21);
            this.PhoneLb.Name = "PhoneLb";
            this.PhoneLb.Size = new System.Drawing.Size(75, 17);
            this.PhoneLb.TabIndex = 1;
            this.PhoneLb.Text = "0889966850";
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaCirclePictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaCirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaCirclePictureBox1.Image")));
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(8, 1);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(40, 40);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.gunaCirclePictureBox1.TabIndex = 2;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // PhoneSearchResultControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.gunaCirclePictureBox1);
            this.Controls.Add(this.PhoneLb);
            this.Controls.Add(this.NameLb);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PhoneSearchResultControl";
            this.Size = new System.Drawing.Size(244, 45);
            this.Click += new System.EventHandler(this.PhoneSearchResultControl_Click);
            this.MouseLeave += new System.EventHandler(this.PhoneSearchResultControl_MouseLeave);
            this.MouseHover += new System.EventHandler(this.PhoneSearchResultControl_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel NameLb;
        private Guna.UI.WinForms.GunaLabel PhoneLb;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
    }
}
