using System;

namespace QuanLyCuaHangBanSach.GUI.Modal
{
    partial class ChooseExcelModal
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
			this.label1 = new System.Windows.Forms.Label();
			this.RequestBtn = new Guna.UI.WinForms.GunaButton();
			this.ImportBtn = new Guna.UI.WinForms.GunaButton();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("#9Slide03 Cabin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(418, 45);
			this.label1.TabIndex = 0;
			this.label1.Text = "Chọn mục đích tệp Excel";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// RequestBtn
			// 
			this.RequestBtn.Animated = true;
			this.RequestBtn.AnimationHoverSpeed = 0.05F;
			this.RequestBtn.AnimationSpeed = 0.05F;
			this.RequestBtn.BackColor = System.Drawing.Color.Transparent;
			this.RequestBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.RequestBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.RequestBtn.BorderSize = 2;
			this.RequestBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.RequestBtn.DialogResult = System.Windows.Forms.DialogResult.None;
			this.RequestBtn.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
			this.RequestBtn.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RequestBtn.ForeColor = System.Drawing.Color.White;
			this.RequestBtn.Image = null;
			this.RequestBtn.ImageSize = new System.Drawing.Size(20, 20);
			this.RequestBtn.Location = new System.Drawing.Point(223, 71);
			this.RequestBtn.Name = "RequestBtn";
			this.RequestBtn.OnHoverBaseColor = System.Drawing.Color.White;
			this.RequestBtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.RequestBtn.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.RequestBtn.OnHoverImage = null;
			this.RequestBtn.OnPressedColor = System.Drawing.Color.Black;
			this.RequestBtn.Radius = 10;
			this.RequestBtn.Size = new System.Drawing.Size(182, 50);
			this.RequestBtn.TabIndex = 5;
			this.RequestBtn.Text = "Phiếu yêu cầu";
			this.RequestBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.RequestBtn.Click += new System.EventHandler(this.RequestBtn_Click);
			// 
			// ImportBtn
			// 
			this.ImportBtn.Animated = true;
			this.ImportBtn.AnimationHoverSpeed = 0.05F;
			this.ImportBtn.AnimationSpeed = 0.05F;
			this.ImportBtn.BackColor = System.Drawing.Color.Transparent;
			this.ImportBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.ImportBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.ImportBtn.BorderSize = 2;
			this.ImportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ImportBtn.DialogResult = System.Windows.Forms.DialogResult.None;
			this.ImportBtn.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
			this.ImportBtn.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ImportBtn.ForeColor = System.Drawing.Color.White;
			this.ImportBtn.Image = null;
			this.ImportBtn.ImageSize = new System.Drawing.Size(20, 20);
			this.ImportBtn.Location = new System.Drawing.Point(14, 71);
			this.ImportBtn.Name = "ImportBtn";
			this.ImportBtn.OnHoverBaseColor = System.Drawing.Color.White;
			this.ImportBtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.ImportBtn.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.ImportBtn.OnHoverImage = null;
			this.ImportBtn.OnPressedColor = System.Drawing.Color.Black;
			this.ImportBtn.Radius = 10;
			this.ImportBtn.Size = new System.Drawing.Size(182, 50);
			this.ImportBtn.TabIndex = 6;
			this.ImportBtn.Text = "Phiếu nhập hàng";
			this.ImportBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ImportBtn.Click += new System.EventHandler(this.ImportBtn_Click);
			// 
			// ChooseExcelModal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(418, 137);
			this.Controls.Add(this.ImportBtn);
			this.Controls.Add(this.RequestBtn);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "ChooseExcelModal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Chọn mục đích tệp Excel";
			this.Load += new System.EventHandler(this.ChooseExcelModal_Load);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton RequestBtn;
		private Guna.UI.WinForms.GunaButton ImportBtn;
	}
}