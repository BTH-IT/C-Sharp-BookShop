namespace QuanLyCuaHangBanSach.GUI
{
    partial class MenuGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuGUI));
            this.label1 = new System.Windows.Forms.Label();
            this.menuFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.import = new Guna.UI.WinForms.GunaGradient2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.manage = new Guna.UI.WinForms.GunaGradient2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.sell = new Guna.UI.WinForms.GunaGradient2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuFlow.SuspendLayout();
            this.import.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            this.manage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.sell.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("#9Slide03 Cabin Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(2, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuFlow
            // 
            this.menuFlow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.menuFlow.Controls.Add(this.import);
            this.menuFlow.Controls.Add(this.manage);
            this.menuFlow.Controls.Add(this.sell);
            this.menuFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuFlow.Location = new System.Drawing.Point(0, 78);
            this.menuFlow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.menuFlow.Name = "menuFlow";
            this.menuFlow.Size = new System.Drawing.Size(279, 44);
            this.menuFlow.TabIndex = 9;
            // 
            // import
            // 
            this.import.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.import.BackColor = System.Drawing.Color.Transparent;
            this.import.Controls.Add(this.label4);
            this.import.Controls.Add(this.guna2PictureBox3);
            this.import.GradientColor1 = System.Drawing.Color.WhiteSmoke;
            this.import.GradientColor2 = System.Drawing.Color.WhiteSmoke;
            this.import.Location = new System.Drawing.Point(4, 4);
            this.import.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.import.Name = "import";
            this.import.Radius = 12;
            this.import.Size = new System.Drawing.Size(271, 231);
            this.import.TabIndex = 11;
            this.import.Visible = false;
            this.import.Click += new System.EventHandler(this.label4_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("#9Slide03 Cabin Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(31, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 56);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nhập Hàng";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.Image")));
            this.guna2PictureBox3.Location = new System.Drawing.Point(69, 13);
            this.guna2PictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.ShadowDecoration.Parent = this.guna2PictureBox3;
            this.guna2PictureBox3.Size = new System.Drawing.Size(125, 125);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox3.TabIndex = 7;
            this.guna2PictureBox3.TabStop = false;
            this.guna2PictureBox3.Click += new System.EventHandler(this.label4_Click);
            // 
            // manage
            // 
            this.manage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.manage.BackColor = System.Drawing.Color.Transparent;
            this.manage.Controls.Add(this.label3);
            this.manage.Controls.Add(this.guna2PictureBox2);
            this.manage.GradientColor1 = System.Drawing.Color.WhiteSmoke;
            this.manage.GradientColor2 = System.Drawing.Color.WhiteSmoke;
            this.manage.Location = new System.Drawing.Point(4, 243);
            this.manage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.manage.Name = "manage";
            this.manage.Radius = 12;
            this.manage.Size = new System.Drawing.Size(271, 219);
            this.manage.TabIndex = 10;
            this.manage.Visible = false;
            this.manage.Click += new System.EventHandler(this.guna2PictureBox2_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("#9Slide03 Cabin Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(54, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 56);
            this.label3.TabIndex = 8;
            this.label3.Text = "Quản Lý";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.guna2PictureBox2_Click);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.Location = new System.Drawing.Point(72, 12);
            this.guna2PictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(125, 125);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 7;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.Click += new System.EventHandler(this.guna2PictureBox2_Click);
            // 
            // sell
            // 
            this.sell.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sell.BackColor = System.Drawing.Color.Transparent;
            this.sell.Controls.Add(this.label2);
            this.sell.Controls.Add(this.guna2PictureBox1);
            this.sell.GradientColor1 = System.Drawing.Color.WhiteSmoke;
            this.sell.GradientColor2 = System.Drawing.Color.WhiteSmoke;
            this.sell.Location = new System.Drawing.Point(4, 470);
            this.sell.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sell.Name = "sell";
            this.sell.Radius = 12;
            this.sell.Size = new System.Drawing.Size(271, 219);
            this.sell.TabIndex = 9;
            this.sell.Visible = false;
            this.sell.Click += new System.EventHandler(this.sell_Click_1);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("#9Slide03 Cabin Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(43, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 56);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bán Hàng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.sell_Click_1);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(71, 14);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(125, 125);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 5;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.sell_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(231, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 78);
            this.panel1.TabIndex = 11;
            // 
            // MenuGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(279, 122);
            this.ControlBox = false;
            this.Controls.Add(this.menuFlow);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("#9Slide03 Cabin", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MenuGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuGUI_FormClosing);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuFlow.ResumeLayout(false);
            this.import.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            this.manage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.sell.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel menuFlow;
        private Guna.UI.WinForms.GunaGradient2Panel import;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI.WinForms.GunaGradient2Panel manage;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI.WinForms.GunaGradient2Panel sell;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}