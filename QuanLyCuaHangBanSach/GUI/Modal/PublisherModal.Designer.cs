﻿using System;

namespace QuanLyCuaHangBanSach.GUI.Modal
{
    partial class PublisherModal
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
			this.cancelBtn = new Guna.UI.WinForms.GunaButton();
			this.submitBtn = new Guna.UI.WinForms.GunaButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.Publishertxt = new Guna.UI2.WinForms.Guna2TextBox();
			this.PublisherNameMsg = new System.Windows.Forms.Label();
			this.nameLine = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.addressLine = new System.Windows.Forms.Panel();
			this.addressTxt = new Guna.UI2.WinForms.Guna2TextBox();
			this.addressMsg = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.phoneNumbertxt = new Guna.UI2.WinForms.Guna2TextBox();
			this.phoneNumberMsg = new System.Windows.Forms.Label();
			this.phoneNumberLine = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(589, 36);
			this.label1.TabIndex = 0;
			this.label1.Text = "Thêm Nhà Xuất Bản";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cancelBtn
			// 
			this.cancelBtn.Animated = true;
			this.cancelBtn.AnimationHoverSpeed = 0.05F;
			this.cancelBtn.AnimationSpeed = 0.05F;
			this.cancelBtn.BackColor = System.Drawing.Color.Transparent;
			this.cancelBtn.BaseColor = System.Drawing.Color.White;
			this.cancelBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.cancelBtn.BorderSize = 2;
			this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.None;
			this.cancelBtn.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
			this.cancelBtn.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.cancelBtn.Image = null;
			this.cancelBtn.ImageSize = new System.Drawing.Size(20, 20);
			this.cancelBtn.Location = new System.Drawing.Point(66, 535);
			this.cancelBtn.Name = "cancelBtn";
			this.cancelBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.cancelBtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.cancelBtn.OnHoverForeColor = System.Drawing.Color.White;
			this.cancelBtn.OnHoverImage = null;
			this.cancelBtn.OnPressedColor = System.Drawing.Color.White;
			this.cancelBtn.Radius = 22;
			this.cancelBtn.Size = new System.Drawing.Size(200, 50);
			this.cancelBtn.TabIndex = 4;
			this.cancelBtn.Text = "Hủy";
			this.cancelBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
			// 
			// submitBtn
			// 
			this.submitBtn.Animated = true;
			this.submitBtn.AnimationHoverSpeed = 0.05F;
			this.submitBtn.AnimationSpeed = 0.05F;
			this.submitBtn.BackColor = System.Drawing.Color.Transparent;
			this.submitBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.submitBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.submitBtn.BorderSize = 2;
			this.submitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.submitBtn.DialogResult = System.Windows.Forms.DialogResult.None;
			this.submitBtn.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
			this.submitBtn.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.submitBtn.ForeColor = System.Drawing.Color.White;
			this.submitBtn.Image = null;
			this.submitBtn.ImageSize = new System.Drawing.Size(20, 20);
			this.submitBtn.Location = new System.Drawing.Point(315, 535);
			this.submitBtn.Name = "submitBtn";
			this.submitBtn.OnHoverBaseColor = System.Drawing.Color.White;
			this.submitBtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.submitBtn.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.submitBtn.OnHoverImage = null;
			this.submitBtn.OnPressedColor = System.Drawing.Color.Black;
			this.submitBtn.Radius = 22;
			this.submitBtn.Size = new System.Drawing.Size(200, 50);
			this.submitBtn.TabIndex = 5;
			this.submitBtn.Text = "Lưu";
			this.submitBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.submitBtn.Click += new System.EventHandler(this.gunaButton1_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.Publishertxt);
			this.panel1.Controls.Add(this.PublisherNameMsg);
			this.panel1.Controls.Add(this.nameLine);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(445, 139);
			this.panel1.TabIndex = 0;
			// 
			// Publishertxt
			// 
			this.Publishertxt.BackColor = System.Drawing.Color.Transparent;
			this.Publishertxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
			this.Publishertxt.BorderThickness = 0;
			this.Publishertxt.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Publishertxt.DefaultText = "";
			this.Publishertxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.Publishertxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.Publishertxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.Publishertxt.DisabledState.Parent = this.Publishertxt;
			this.Publishertxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.Publishertxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.Publishertxt.FocusedState.Parent = this.Publishertxt;
			this.Publishertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.Publishertxt.ForeColor = System.Drawing.Color.Black;
			this.Publishertxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.Publishertxt.HoverState.Parent = this.Publishertxt;
			this.Publishertxt.Location = new System.Drawing.Point(6, 61);
			this.Publishertxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.Publishertxt.Name = "Publishertxt";
			this.Publishertxt.PasswordChar = '\0';
			this.Publishertxt.PlaceholderText = "Nhập tên nhà xuất bản";
			this.Publishertxt.SelectedText = "";
			this.Publishertxt.ShadowDecoration.Parent = this.Publishertxt;
			this.Publishertxt.Size = new System.Drawing.Size(425, 36);
			this.Publishertxt.TabIndex = 1;
			this.Publishertxt.TextChanged += new System.EventHandler(this.bookNameTxt_TextChanged);
			this.Publishertxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PublisherModal_KeyDown);
			this.Publishertxt.Leave += new System.EventHandler(this.bookNameTxt_TextChanged);
			// 
			// PublisherNameMsg
			// 
			this.PublisherNameMsg.AutoSize = true;
			this.PublisherNameMsg.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.PublisherNameMsg.ForeColor = System.Drawing.Color.Red;
			this.PublisherNameMsg.Location = new System.Drawing.Point(20, 103);
			this.PublisherNameMsg.Name = "PublisherNameMsg";
			this.PublisherNameMsg.Size = new System.Drawing.Size(0, 21);
			this.PublisherNameMsg.TabIndex = 7;
			// 
			// nameLine
			// 
			this.nameLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
			this.nameLine.Location = new System.Drawing.Point(17, 98);
			this.nameLine.Name = "nameLine";
			this.nameLine.Size = new System.Drawing.Size(414, 1);
			this.nameLine.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label3.Location = new System.Drawing.Point(12, 13);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(202, 42);
			this.label3.TabIndex = 5;
			this.label3.Text = "Tên nhà xuất bản:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoScroll = true;
			this.flowLayoutPanel1.AutoScrollMargin = new System.Drawing.Size(10, 10);
			this.flowLayoutPanel1.Controls.Add(this.panel1);
			this.flowLayoutPanel1.Controls.Add(this.panel2);
			this.flowLayoutPanel1.Controls.Add(this.panel4);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(68, 50);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(452, 464);
			this.flowLayoutPanel1.TabIndex = 4;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.addressLine);
			this.panel2.Controls.Add(this.addressTxt);
			this.panel2.Controls.Add(this.addressMsg);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Location = new System.Drawing.Point(3, 148);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(445, 155);
			this.panel2.TabIndex = 1;
			// 
			// addressLine
			// 
			this.addressLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
			this.addressLine.Location = new System.Drawing.Point(15, 102);
			this.addressLine.Name = "addressLine";
			this.addressLine.Size = new System.Drawing.Size(414, 1);
			this.addressLine.TabIndex = 34;
			// 
			// addressTxt
			// 
			this.addressTxt.BackColor = System.Drawing.Color.Transparent;
			this.addressTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
			this.addressTxt.BorderThickness = 0;
			this.addressTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.addressTxt.DefaultText = "";
			this.addressTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.addressTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.addressTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.addressTxt.DisabledState.Parent = this.addressTxt;
			this.addressTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.addressTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.addressTxt.FocusedState.Parent = this.addressTxt;
			this.addressTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.addressTxt.ForeColor = System.Drawing.Color.Black;
			this.addressTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.addressTxt.HoverState.Parent = this.addressTxt;
			this.addressTxt.Location = new System.Drawing.Point(6, 61);
			this.addressTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.addressTxt.Name = "addressTxt";
			this.addressTxt.PasswordChar = '\0';
			this.addressTxt.PlaceholderText = "Nhập địa chỉ";
			this.addressTxt.SelectedText = "";
			this.addressTxt.ShadowDecoration.Parent = this.addressTxt;
			this.addressTxt.Size = new System.Drawing.Size(425, 36);
			this.addressTxt.TabIndex = 2;
			this.addressTxt.TextChanged += new System.EventHandler(this.addressTxt_TextChanged);
			this.addressTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PublisherModal_KeyDown);
			this.addressTxt.Leave += new System.EventHandler(this.addressTxt_TextChanged);
			// 
			// addressMsg
			// 
			this.addressMsg.AutoSize = true;
			this.addressMsg.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.addressMsg.ForeColor = System.Drawing.Color.Red;
			this.addressMsg.Location = new System.Drawing.Point(20, 109);
			this.addressMsg.Name = "addressMsg";
			this.addressMsg.Size = new System.Drawing.Size(0, 21);
			this.addressMsg.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label4.Location = new System.Drawing.Point(12, 13);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(151, 42);
			this.label4.TabIndex = 5;
			this.label4.Text = "Địa chỉ:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.phoneNumbertxt);
			this.panel4.Controls.Add(this.phoneNumberMsg);
			this.panel4.Controls.Add(this.phoneNumberLine);
			this.panel4.Controls.Add(this.label6);
			this.panel4.Location = new System.Drawing.Point(3, 309);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(445, 145);
			this.panel4.TabIndex = 33;
			// 
			// phoneNumbertxt
			// 
			this.phoneNumbertxt.BackColor = System.Drawing.Color.Transparent;
			this.phoneNumbertxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
			this.phoneNumbertxt.BorderThickness = 0;
			this.phoneNumbertxt.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.phoneNumbertxt.DefaultText = "";
			this.phoneNumbertxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.phoneNumbertxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.phoneNumbertxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.phoneNumbertxt.DisabledState.Parent = this.phoneNumbertxt;
			this.phoneNumbertxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.phoneNumbertxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.phoneNumbertxt.FocusedState.Parent = this.phoneNumbertxt;
			this.phoneNumbertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.phoneNumbertxt.ForeColor = System.Drawing.Color.Black;
			this.phoneNumbertxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.phoneNumbertxt.HoverState.Parent = this.phoneNumbertxt;
			this.phoneNumbertxt.Location = new System.Drawing.Point(6, 61);
			this.phoneNumbertxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.phoneNumbertxt.Name = "phoneNumbertxt";
			this.phoneNumbertxt.PasswordChar = '\0';
			this.phoneNumbertxt.PlaceholderText = "Nhập số điện thoại";
			this.phoneNumbertxt.SelectedText = "";
			this.phoneNumbertxt.ShadowDecoration.Parent = this.phoneNumbertxt;
			this.phoneNumbertxt.Size = new System.Drawing.Size(425, 36);
			this.phoneNumbertxt.TabIndex = 3;
			this.phoneNumbertxt.TextChanged += new System.EventHandler(this.birthYear_TextChanged);
			this.phoneNumbertxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PublisherModal_KeyDown);
			this.phoneNumbertxt.Leave += new System.EventHandler(this.birthYear_TextChanged);
			// 
			// phoneNumberMsg
			// 
			this.phoneNumberMsg.AutoSize = true;
			this.phoneNumberMsg.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.phoneNumberMsg.ForeColor = System.Drawing.Color.Red;
			this.phoneNumberMsg.Location = new System.Drawing.Point(20, 106);
			this.phoneNumberMsg.Name = "phoneNumberMsg";
			this.phoneNumberMsg.Size = new System.Drawing.Size(0, 21);
			this.phoneNumberMsg.TabIndex = 7;
			// 
			// phoneNumberLine
			// 
			this.phoneNumberLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
			this.phoneNumberLine.Location = new System.Drawing.Point(17, 98);
			this.phoneNumberLine.Name = "phoneNumberLine";
			this.phoneNumberLine.Size = new System.Drawing.Size(414, 1);
			this.phoneNumberLine.TabIndex = 8;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label6.Location = new System.Drawing.Point(12, 13);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(151, 42);
			this.label6.TabIndex = 5;
			this.label6.Text = "Số điện thoại:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// PublisherModal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(589, 603);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.submitBtn);
			this.Controls.Add(this.cancelBtn);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "PublisherModal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Thêm nhà xuất bản";
			this.Load += new System.EventHandler(this.PublisherModal_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PublisherModal_KeyDown);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton cancelBtn;
        private Guna.UI.WinForms.GunaButton submitBtn;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox Publishertxt;
        private System.Windows.Forms.Label PublisherNameMsg;
        private System.Windows.Forms.Panel nameLine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label addressMsg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2TextBox phoneNumbertxt;
        private System.Windows.Forms.Label phoneNumberMsg;
        private System.Windows.Forms.Panel phoneNumberLine;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel addressLine;
        private Guna.UI2.WinForms.Guna2TextBox addressTxt;
    }
}