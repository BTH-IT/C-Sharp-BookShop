namespace QuanLyCuaHangBanSach.GUI.Modal
{
    partial class ScannerModal
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.scanBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cameraCbx = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(61, 96);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.ShadowDecoration.Parent = this.pictureBox;
            this.pictureBox.Size = new System.Drawing.Size(733, 458);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // scanBtn
            // 
            this.scanBtn.CheckedState.Parent = this.scanBtn;
            this.scanBtn.CustomImages.Parent = this.scanBtn;
            this.scanBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.scanBtn.ForeColor = System.Drawing.Color.White;
            this.scanBtn.HoverState.Parent = this.scanBtn;
            this.scanBtn.Location = new System.Drawing.Point(335, 574);
            this.scanBtn.Name = "scanBtn";
            this.scanBtn.ShadowDecoration.Parent = this.scanBtn;
            this.scanBtn.Size = new System.Drawing.Size(180, 45);
            this.scanBtn.TabIndex = 3;
            this.scanBtn.Text = "Bắt đầu Scan";
            this.scanBtn.Click += new System.EventHandler(this.scanBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("#9Slide03 Cabin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Camera :";
            // 
            // cameraCbx
            // 
            this.cameraCbx.BackColor = System.Drawing.Color.Transparent;
            this.cameraCbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cameraCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cameraCbx.FocusedColor = System.Drawing.Color.Empty;
            this.cameraCbx.FocusedState.Parent = this.cameraCbx;
            this.cameraCbx.Font = new System.Drawing.Font("#9Slide03 Cabin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cameraCbx.ForeColor = System.Drawing.Color.Black;
            this.cameraCbx.FormattingEnabled = true;
            this.cameraCbx.HoverState.Parent = this.cameraCbx;
            this.cameraCbx.ItemHeight = 30;
            this.cameraCbx.ItemsAppearance.Parent = this.cameraCbx;
            this.cameraCbx.Location = new System.Drawing.Point(188, 33);
            this.cameraCbx.Name = "cameraCbx";
            this.cameraCbx.ShadowDecoration.Parent = this.cameraCbx;
            this.cameraCbx.Size = new System.Drawing.Size(606, 36);
            this.cameraCbx.TabIndex = 1;
            // 
            // ScannerModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 647);
            this.Controls.Add(this.scanBtn);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.cameraCbx);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("#9Slide03 Cabin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ScannerModal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScannerModal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScannerModal_FormClosing);
            this.Load += new System.EventHandler(this.ScannerModal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2PictureBox pictureBox;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Button scanBtn;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cameraCbx;
    }
}