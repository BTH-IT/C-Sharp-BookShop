namespace QuanLyCuaHangBanSach.GUI.Report
{
	partial class OrderBillPrintForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderBillPrintForm));
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.bookD1 = new QuanLyCuaHangBanSach.GUI.Report.BookD();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.bookD1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// reportViewer1
			// 
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyCuaHangBanSach.GUI.Report.OrderBillReport.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(-1, 1);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(888, 731);
			this.reportViewer1.TabIndex = 0;
			// 
			// bookD1
			// 
			this.bookD1.DataSetName = "BookD";
			this.bookD1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// OrderBillPrintForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(889, 770);
			this.Controls.Add(this.reportViewer1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "OrderBillPrintForm";
			this.Text = "OrderBillPrintForm";
			this.Load += new System.EventHandler(this.OrderBillPrintForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.bookD1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private BookD bookD1;
		private System.Windows.Forms.BindingSource bindingSource1;
	}
}