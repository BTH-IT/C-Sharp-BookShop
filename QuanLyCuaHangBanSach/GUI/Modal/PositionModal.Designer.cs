namespace QuanLyCuaHangBanSach.GUI.Modal
{
    partial class PositionModal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.positionNameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.errorPositionNameMsg = new System.Windows.Forms.Label();
            this.nameLine = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.descTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.sellPriceLine = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.activeCkx = new Guna.UI.WinForms.GunaCheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.submitBtn = new Guna.UI.WinForms.GunaButton();
            this.cancelBtn = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.heSoLuongTxt = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heSoLuongTxt)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.positionNameTxt);
            this.panel1.Controls.Add(this.errorPositionNameMsg);
            this.panel1.Controls.Add(this.nameLine);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 88);
            this.panel1.TabIndex = 0;
            // 
            // positionNameTxt
            // 
            this.positionNameTxt.BackColor = System.Drawing.Color.Transparent;
            this.positionNameTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.positionNameTxt.BorderThickness = 0;
            this.positionNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.positionNameTxt.DefaultText = "";
            this.positionNameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.positionNameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.positionNameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.positionNameTxt.DisabledState.Parent = this.positionNameTxt;
            this.positionNameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.positionNameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.positionNameTxt.FocusedState.Parent = this.positionNameTxt;
            this.positionNameTxt.Font = new System.Drawing.Font("#9Slide03 Cabin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionNameTxt.ForeColor = System.Drawing.Color.Black;
            this.positionNameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.positionNameTxt.HoverState.Parent = this.positionNameTxt;
            this.positionNameTxt.Location = new System.Drawing.Point(149, 8);
            this.positionNameTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.positionNameTxt.Name = "positionNameTxt";
            this.positionNameTxt.PasswordChar = '\0';
            this.positionNameTxt.PlaceholderText = "Nhập tên chức vụ";
            this.positionNameTxt.SelectedText = "";
            this.positionNameTxt.ShadowDecoration.Parent = this.positionNameTxt;
            this.positionNameTxt.Size = new System.Drawing.Size(425, 36);
            this.positionNameTxt.TabIndex = 1;
            this.positionNameTxt.TextChanged += new System.EventHandler(this.positionNameTxt_TextChanged);
            this.positionNameTxt.Leave += new System.EventHandler(this.positionNameTxt_TextChanged);
            // 
            // errorPositionNameMsg
            // 
            this.errorPositionNameMsg.AutoSize = true;
            this.errorPositionNameMsg.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.errorPositionNameMsg.ForeColor = System.Drawing.Color.Red;
            this.errorPositionNameMsg.Location = new System.Drawing.Point(163, 50);
            this.errorPositionNameMsg.Name = "errorPositionNameMsg";
            this.errorPositionNameMsg.Size = new System.Drawing.Size(0, 21);
            this.errorPositionNameMsg.TabIndex = 7;
            // 
            // nameLine
            // 
            this.nameLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
            this.nameLine.Location = new System.Drawing.Point(160, 45);
            this.nameLine.Name = "nameLine";
            this.nameLine.Size = new System.Drawing.Size(414, 1);
            this.nameLine.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 49);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên chức vụ:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel12);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 60);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(600, 331);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.descTxt);
            this.panel4.Controls.Add(this.sellPriceLine);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(3, 165);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(594, 88);
            this.panel4.TabIndex = 9;
            // 
            // descTxt
            // 
            this.descTxt.BackColor = System.Drawing.Color.Transparent;
            this.descTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.descTxt.BorderThickness = 0;
            this.descTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.descTxt.DefaultText = "";
            this.descTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.descTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.descTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.descTxt.DisabledState.Parent = this.descTxt;
            this.descTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.descTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.descTxt.FocusedState.Parent = this.descTxt;
            this.descTxt.Font = new System.Drawing.Font("#9Slide03 Cabin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descTxt.ForeColor = System.Drawing.Color.Black;
            this.descTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.descTxt.HoverState.Parent = this.descTxt;
            this.descTxt.Location = new System.Drawing.Point(149, 7);
            this.descTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.descTxt.Name = "descTxt";
            this.descTxt.PasswordChar = '\0';
            this.descTxt.PlaceholderText = "Nhập mô tả";
            this.descTxt.SelectedText = "";
            this.descTxt.ShadowDecoration.Parent = this.descTxt;
            this.descTxt.Size = new System.Drawing.Size(425, 36);
            this.descTxt.TabIndex = 2;
            // 
            // sellPriceLine
            // 
            this.sellPriceLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(212)))), ((int)(((byte)(191)))));
            this.sellPriceLine.Location = new System.Drawing.Point(160, 45);
            this.sellPriceLine.Name = "sellPriceLine";
            this.sellPriceLine.Size = new System.Drawing.Size(414, 1);
            this.sellPriceLine.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 49);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mô tả:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.activeCkx);
            this.panel12.Controls.Add(this.label10);
            this.panel12.Location = new System.Drawing.Point(3, 259);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(594, 63);
            this.panel12.TabIndex = 11;
            // 
            // activeCkx
            // 
            this.activeCkx.BaseColor = System.Drawing.Color.White;
            this.activeCkx.CheckedOffColor = System.Drawing.Color.Gray;
            this.activeCkx.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.activeCkx.FillColor = System.Drawing.Color.White;
            this.activeCkx.Font = new System.Drawing.Font("#9Slide03 Cabin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeCkx.Location = new System.Drawing.Point(160, 12);
            this.activeCkx.Name = "activeCkx";
            this.activeCkx.Size = new System.Drawing.Size(126, 23);
            this.activeCkx.TabIndex = 3;
            this.activeCkx.Text = "Đang hoạt động";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(3, 1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 41);
            this.label10.TabIndex = 5;
            this.label10.Text = "Trạng thái:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.submitBtn.Font = new System.Drawing.Font("#9Slide03 Cabin Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.ForeColor = System.Drawing.Color.White;
            this.submitBtn.Image = null;
            this.submitBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.submitBtn.Location = new System.Drawing.Point(335, 412);
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
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
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
            this.cancelBtn.Font = new System.Drawing.Font("#9Slide03 Cabin Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.cancelBtn.Image = null;
            this.cancelBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.cancelBtn.Location = new System.Drawing.Point(89, 412);
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
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("#9Slide03 Cabin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(624, 45);
            this.label1.TabIndex = 5;
            this.label1.Text = "Thêm Chức Vụ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.heSoLuongTxt);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(3, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(594, 62);
            this.panel2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 49);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hệ số lương:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // heSoLuongTxt
            // 
            this.heSoLuongTxt.BackColor = System.Drawing.Color.Transparent;
            this.heSoLuongTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.heSoLuongTxt.DecimalPlaces = 1;
            this.heSoLuongTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.heSoLuongTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.heSoLuongTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.heSoLuongTxt.DisabledState.Parent = this.heSoLuongTxt;
            this.heSoLuongTxt.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.heSoLuongTxt.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.heSoLuongTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.heSoLuongTxt.FocusedState.Parent = this.heSoLuongTxt;
            this.heSoLuongTxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heSoLuongTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.heSoLuongTxt.Location = new System.Drawing.Point(160, 11);
            this.heSoLuongTxt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.heSoLuongTxt.Name = "heSoLuongTxt";
            this.heSoLuongTxt.ShadowDecoration.Parent = this.heSoLuongTxt;
            this.heSoLuongTxt.Size = new System.Drawing.Size(414, 36);
            this.heSoLuongTxt.TabIndex = 9;
            this.heSoLuongTxt.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.heSoLuongTxt.UpDownButtonForeColor = System.Drawing.Color.White;
            this.heSoLuongTxt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PositionModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(624, 481);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("#9Slide03 Cabin", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PositionModal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PositionModal";
            this.Load += new System.EventHandler(this.PositionModal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.heSoLuongTxt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox positionNameTxt;
        private System.Windows.Forms.Label errorPositionNameMsg;
        private System.Windows.Forms.Panel nameLine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2TextBox descTxt;
        private System.Windows.Forms.Panel sellPriceLine;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label10;
        private Guna.UI.WinForms.GunaButton submitBtn;
        private Guna.UI.WinForms.GunaButton cancelBtn;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaCheckBox activeCkx;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2NumericUpDown heSoLuongTxt;
    }
}