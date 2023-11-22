using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace QuanLyCuaHangBanSach.GUI.Report
{
    public partial class BarcodePrintForm : Form
    {
        DataTable BarcodeTable;
        public BarcodePrintForm(DataTable dt)
        {
            InitializeComponent();
            BarcodeTable = dt;
        }

        private void BarcodePrintForm_Load(object sender, EventArgs e)
        {
            ReportDataSource reportDataSource = new ReportDataSource("DataSet1", BarcodeTable);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
