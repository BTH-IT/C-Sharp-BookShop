namespace QuanLyCuaHangBanSach.GUI.UserControls
{
    partial class AuthorizeCkb
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
            this.ckx = new Guna.UI.WinForms.GunaCheckBox();
            this.SuspendLayout();
            // 
            // ckx
            // 
            this.ckx.BaseColor = System.Drawing.Color.White;
            this.ckx.CheckedOffColor = System.Drawing.Color.Gray;
            this.ckx.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(210)))), ((int)(((byte)(192)))));
            this.ckx.FillColor = System.Drawing.Color.White;
            this.ckx.Font = new System.Drawing.Font("#9Slide03 Cabin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckx.Location = new System.Drawing.Point(0, 0);
            this.ckx.Name = "ckx";
            this.ckx.Size = new System.Drawing.Size(168, 34);
            this.ckx.TabIndex = 5;
            this.ckx.Text = "gunaCheckBox1";
            this.ckx.CheckedChanged += new System.EventHandler(this.ckx_CheckedChanged);
            // 
            // AuthorizeCkb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ckx);
            this.Name = "AuthorizeCkb";
            this.Size = new System.Drawing.Size(190, 38);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaCheckBox ckx;
    }
}
