namespace QuanLyCuaHangBanSach.GUI.Modal
{
    partial class BookTypeModal
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
			this.BookTypeNameTxt = new Guna.UI2.WinForms.Guna2TextBox();
			this.errorBookTypeNameMsg = new System.Windows.Forms.Label();
			this.nameLine = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.panel1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(632, 49);
			this.label1.TabIndex = 0;
			this.label1.Text = "Thêm Thể Loại";
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
			this.cancelBtn.Location = new System.Drawing.Point(91, 191);
			this.cancelBtn.Name = "cancelBtn";
			this.cancelBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.cancelBtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.cancelBtn.OnHoverForeColor = System.Drawing.Color.White;
			this.cancelBtn.OnHoverImage = null;
			this.cancelBtn.OnPressedColor = System.Drawing.Color.White;
			this.cancelBtn.Radius = 22;
			this.cancelBtn.Size = new System.Drawing.Size(200, 50);
			this.cancelBtn.TabIndex = 2;
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
			this.submitBtn.Location = new System.Drawing.Point(337, 191);
			this.submitBtn.Name = "submitBtn";
			this.submitBtn.OnHoverBaseColor = System.Drawing.Color.White;
			this.submitBtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.submitBtn.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
			this.submitBtn.OnHoverImage = null;
			this.submitBtn.OnPressedColor = System.Drawing.Color.Black;
			this.submitBtn.Radius = 22;
			this.submitBtn.Size = new System.Drawing.Size(200, 50);
			this.submitBtn.TabIndex = 3;
			this.submitBtn.Text = "Lưu";
			this.submitBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.submitBtn.Click += new System.EventHandler(this.gunaButton1_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.BookTypeNameTxt);
			this.panel1.Controls.Add(this.errorBookTypeNameMsg);
			this.panel1.Controls.Add(this.nameLine);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(594, 88);
			this.panel1.TabIndex = 0;
			// 
			// BookTypeNameTxt
			// 
			this.BookTypeNameTxt.BackColor = System.Drawing.Color.Transparent;
			this.BookTypeNameTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
			this.BookTypeNameTxt.BorderThickness = 0;
			this.BookTypeNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.BookTypeNameTxt.DefaultText = "";
			this.BookTypeNameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.BookTypeNameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.BookTypeNameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.BookTypeNameTxt.DisabledState.Parent = this.BookTypeNameTxt;
			this.BookTypeNameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.BookTypeNameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.BookTypeNameTxt.FocusedState.Parent = this.BookTypeNameTxt;
			this.BookTypeNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BookTypeNameTxt.ForeColor = System.Drawing.Color.Black;
			this.BookTypeNameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.BookTypeNameTxt.HoverState.Parent = this.BookTypeNameTxt;
			this.BookTypeNameTxt.Location = new System.Drawing.Point(149, 8);
			this.BookTypeNameTxt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.BookTypeNameTxt.Name = "BookTypeNameTxt";
			this.BookTypeNameTxt.PasswordChar = '\0';
			this.BookTypeNameTxt.PlaceholderText = "Nhập tên thể loại";
			this.BookTypeNameTxt.SelectedText = "";
			this.BookTypeNameTxt.ShadowDecoration.Parent = this.BookTypeNameTxt;
			this.BookTypeNameTxt.Size = new System.Drawing.Size(425, 36);
			this.BookTypeNameTxt.TabIndex = 1;
			this.BookTypeNameTxt.TextChanged += new System.EventHandler(this.BookTypeNameTxt_TextChanged);
			this.BookTypeNameTxt.Leave += new System.EventHandler(this.BookTypeNameTxt_TextChanged);
			// 
			// errorBookTypeNameMsg
			// 
			this.errorBookTypeNameMsg.AutoSize = true;
			this.errorBookTypeNameMsg.Font = new System.Drawing.Font("#9Slide03 Cabin Condensed Bold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.errorBookTypeNameMsg.ForeColor = System.Drawing.Color.Red;
			this.errorBookTypeNameMsg.Location = new System.Drawing.Point(159, 54);
			this.errorBookTypeNameMsg.Name = "errorBookTypeNameMsg";
			this.errorBookTypeNameMsg.Size = new System.Drawing.Size(0, 26);
			this.errorBookTypeNameMsg.TabIndex = 7;
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
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label3.Location = new System.Drawing.Point(3, 3);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(151, 49);
			this.label3.TabIndex = 5;
			this.label3.Text = "Tên thể loại:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoScroll = true;
			this.flowLayoutPanel1.AutoScrollMargin = new System.Drawing.Size(10, 10);
			this.flowLayoutPanel1.Controls.Add(this.panel1);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 66);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(602, 98);
			this.flowLayoutPanel1.TabIndex = 4;
			// 
			// BookTypeModal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(632, 269);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.submitBtn);
			this.Controls.Add(this.cancelBtn);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "BookTypeModal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Thêm thể loại";
			this.Load += new System.EventHandler(this.AddBookTypeModal_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton cancelBtn;
        private Guna.UI.WinForms.GunaButton submitBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label errorBookTypeNameMsg;
        private System.Windows.Forms.Panel nameLine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2TextBox BookTypeNameTxt;
    }
}