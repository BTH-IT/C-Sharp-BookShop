using System;

namespace QuanLyCuaHangBanSach.GUI.Modal
{
    partial class AuthorModal
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
            this.authorName = new Guna.UI2.WinForms.Guna2TextBox();
            this.authorNameMsg = new System.Windows.Forms.Label();
            this.nameLine = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.genderCbx = new Guna.UI.WinForms.GunaComboBox();
            this.genderMsg = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.birthYear = new Guna.UI2.WinForms.Guna2TextBox();
            this.birthYearMsg = new System.Windows.Forms.Label();
            this.birthYearLine = new System.Windows.Forms.Panel();
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
            this.label1.Font = new System.Drawing.Font("#9Slide03 Cabin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(589, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm Tác giả";
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
            this.cancelBtn.Location = new System.Drawing.Point(66, 585);
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
            this.submitBtn.Location = new System.Drawing.Point(315, 585);
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
            this.panel1.Controls.Add(this.authorName);
            this.panel1.Controls.Add(this.authorNameMsg);
            this.panel1.Controls.Add(this.nameLine);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 155);
            this.panel1.TabIndex = 0;
            // 
            // authorName
            // 
            this.authorName.BackColor = System.Drawing.Color.Transparent;
            this.authorName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.authorName.BorderThickness = 0;
            this.authorName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.authorName.DefaultText = "";
            this.authorName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.authorName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.authorName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.authorName.DisabledState.Parent = this.authorName;
            this.authorName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.authorName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.authorName.FocusedState.Parent = this.authorName;
            this.authorName.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorName.ForeColor = System.Drawing.Color.Black;
            this.authorName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.authorName.HoverState.Parent = this.authorName;
            this.authorName.Location = new System.Drawing.Point(6, 61);
            this.authorName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.authorName.Name = "authorName";
            this.authorName.PasswordChar = '\0';
            this.authorName.PlaceholderText = "Nhập tên tác giả";
            this.authorName.SelectedText = "";
            this.authorName.ShadowDecoration.Parent = this.authorName;
            this.authorName.Size = new System.Drawing.Size(425, 36);
            this.authorName.TabIndex = 1;
            this.authorName.TextChanged += new System.EventHandler(this.bookNameTxt_TextChanged);
            this.authorName.Leave += new System.EventHandler(this.bookNameTxt_TextChanged);
            // 
            // authorNameMsg
            // 
            this.authorNameMsg.AutoSize = true;
            this.authorNameMsg.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.authorNameMsg.ForeColor = System.Drawing.Color.Red;
            this.authorNameMsg.Location = new System.Drawing.Point(20, 109);
            this.authorNameMsg.Name = "authorNameMsg";
            this.authorNameMsg.Size = new System.Drawing.Size(0, 21);
            this.authorNameMsg.TabIndex = 7;
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
            this.label3.Font = new System.Drawing.Font("#9Slide03 Cabin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 42);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên tác giả:";
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
            this.flowLayoutPanel1.Size = new System.Drawing.Size(452, 496);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.genderCbx);
            this.panel2.Controls.Add(this.genderMsg);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(3, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(445, 155);
            this.panel2.TabIndex = 0;
            // 
            // genderCbx
            // 
            this.genderCbx.BackColor = System.Drawing.Color.Transparent;
            this.genderCbx.BaseColor = System.Drawing.Color.White;
            this.genderCbx.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.genderCbx.BorderSize = 1;
            this.genderCbx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.genderCbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.genderCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderCbx.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
            this.genderCbx.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderCbx.ForeColor = System.Drawing.Color.Black;
            this.genderCbx.FormattingEnabled = true;
            this.genderCbx.IntegralHeight = false;
            this.genderCbx.ItemHeight = 30;
            this.genderCbx.Items.AddRange(new object[] {
            "Chọn giới tính",
            "Nam",
            "Nữ"});
            this.genderCbx.Location = new System.Drawing.Point(17, 64);
            this.genderCbx.MaxDropDownItems = 10;
            this.genderCbx.Name = "genderCbx";
            this.genderCbx.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.genderCbx.OnHoverItemForeColor = System.Drawing.Color.White;
            this.genderCbx.Radius = 6;
            this.genderCbx.Size = new System.Drawing.Size(414, 36);
            this.genderCbx.TabIndex = 2;
            this.genderCbx.SelectedIndexChanged += new System.EventHandler(this.genderCbx_SelectedIndexChanged);
            this.genderCbx.Leave += new System.EventHandler(this.genderCbx_SelectedIndexChanged);
            // 
            // genderMsg
            // 
            this.genderMsg.AutoSize = true;
            this.genderMsg.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.genderMsg.ForeColor = System.Drawing.Color.Red;
            this.genderMsg.Location = new System.Drawing.Point(20, 109);
            this.genderMsg.Name = "genderMsg";
            this.genderMsg.Size = new System.Drawing.Size(0, 21);
            this.genderMsg.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("#9Slide03 Cabin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 42);
            this.label4.TabIndex = 5;
            this.label4.Text = "Giới tính";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.birthYear);
            this.panel4.Controls.Add(this.birthYearMsg);
            this.panel4.Controls.Add(this.birthYearLine);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(3, 325);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(445, 153);
            this.panel4.TabIndex = 1;
            // 
            // birthYear
            // 
            this.birthYear.BackColor = System.Drawing.Color.Transparent;
            this.birthYear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.birthYear.BorderThickness = 0;
            this.birthYear.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.birthYear.DefaultText = "";
            this.birthYear.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.birthYear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.birthYear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.birthYear.DisabledState.Parent = this.birthYear;
            this.birthYear.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.birthYear.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.birthYear.FocusedState.Parent = this.birthYear;
            this.birthYear.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthYear.ForeColor = System.Drawing.Color.Black;
            this.birthYear.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.birthYear.HoverState.Parent = this.birthYear;
            this.birthYear.Location = new System.Drawing.Point(6, 61);
            this.birthYear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.birthYear.Name = "birthYear";
            this.birthYear.PasswordChar = '\0';
            this.birthYear.PlaceholderText = "Nhập năm sinh";
            this.birthYear.SelectedText = "";
            this.birthYear.ShadowDecoration.Parent = this.birthYear;
            this.birthYear.Size = new System.Drawing.Size(425, 36);
            this.birthYear.TabIndex = 3;
            this.birthYear.TextChanged += new System.EventHandler(this.birthYear_TextChanged);
            this.birthYear.Leave += new System.EventHandler(this.birthYear_TextChanged);
            // 
            // birthYearMsg
            // 
            this.birthYearMsg.AutoSize = true;
            this.birthYearMsg.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.birthYearMsg.ForeColor = System.Drawing.Color.Red;
            this.birthYearMsg.Location = new System.Drawing.Point(20, 109);
            this.birthYearMsg.Name = "birthYearMsg";
            this.birthYearMsg.Size = new System.Drawing.Size(0, 21);
            this.birthYearMsg.TabIndex = 7;
            // 
            // birthYearLine
            // 
            this.birthYearLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
            this.birthYearLine.Location = new System.Drawing.Point(17, 98);
            this.birthYearLine.Name = "birthYearLine";
            this.birthYearLine.Size = new System.Drawing.Size(414, 1);
            this.birthYearLine.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("#9Slide03 Cabin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 42);
            this.label6.TabIndex = 3;
            this.label6.Text = "Năm sinh:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AuthorModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(589, 653);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AuthorModal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm tác giả";
            this.Load += new System.EventHandler(this.AuthorModal_Load);
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
        private Guna.UI2.WinForms.Guna2TextBox authorName;
        private System.Windows.Forms.Label authorNameMsg;
        private System.Windows.Forms.Panel nameLine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label genderMsg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2TextBox birthYear;
        private System.Windows.Forms.Label birthYearMsg;
        private System.Windows.Forms.Panel birthYearLine;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaComboBox genderCbx;
    }
}