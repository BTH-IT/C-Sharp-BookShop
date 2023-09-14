namespace QuanLyCuaHangBanSach.GUI.Modal
{
    partial class AuthorizeModal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizeModal));
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.title = new System.Windows.Forms.Label();
            this.authorizeList = new System.Windows.Forms.FlowLayoutPanel();
            this.cancelBtn = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Hình Ảnh";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.MinimumWidth = 100;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 108;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Hình Ảnh";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn2.MinimumWidth = 100;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 108;
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("#9Slide03 Cabin", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.title.Location = new System.Drawing.Point(-1, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(1219, 55);
            this.title.TabIndex = 1;
            this.title.Text = "Phân quyền cho chức vụ";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // authorizeList
            // 
            this.authorizeList.AutoScroll = true;
            this.authorizeList.Location = new System.Drawing.Point(54, 85);
            this.authorizeList.Name = "authorizeList";
            this.authorizeList.Size = new System.Drawing.Size(1115, 590);
            this.authorizeList.TabIndex = 2;
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
            this.cancelBtn.FocusedColor = System.Drawing.Color.Empty;
            this.cancelBtn.Font = new System.Drawing.Font("#9Slide03 Cabin Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.cancelBtn.Image = null;
            this.cancelBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.cancelBtn.Location = new System.Drawing.Point(511, 690);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.cancelBtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.cancelBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.cancelBtn.OnHoverImage = null;
            this.cancelBtn.OnPressedColor = System.Drawing.Color.White;
            this.cancelBtn.Radius = 22;
            this.cancelBtn.Size = new System.Drawing.Size(200, 50);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.TabStop = false;
            this.cancelBtn.Text = "Thoát";
            this.cancelBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // AuthorizeModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1222, 753);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.authorizeList);
            this.Controls.Add(this.title);
            this.Font = new System.Drawing.Font("#9Slide03 Cabin", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AuthorizeModal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthorizeGUI";
            this.Load += new System.EventHandler(this.AuthorizeModal_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.FlowLayoutPanel authorizeList;
        private Guna.UI.WinForms.GunaButton cancelBtn;
    }
}