using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.GUI.Report
{
    public partial class ImportChangeBillPrintForm : Form
    {
        private ImportChangeBillDTO customerChangeBill;
        public ImportChangeBillPrintForm(int maDonDoiHang)
        {
            InitializeComponent();
            this.customerChangeBill = ImportChangeBillBUS.Instance.getById(maDonDoiHang.ToString());
        }

        private void ImportChangeBillPrintForm_Load(object sender, EventArgs e)
        {
            try
            {
                StaffDTO staff = StaffBUS.Instance.getById(customerChangeBill.MaNhanVien.ToString());

                SupplierDTO supplier = SupplierBUS.Instance.getById(customerChangeBill.MaNhaCungCap.ToString());

                Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
                {
                new Microsoft.Reporting.WinForms.ReportParameter("pInvoiceCode", customerChangeBill.MaPhieu.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pEmployee", staff.Ten.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pDate", customerChangeBill.NgayLap.GetDateTimeFormats()[0].ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pSupplier", supplier.TenNhaCungCap.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pNewBook", customerChangeBill.SachMuonDoi.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pOldBook", customerChangeBill.SachMuonDoi.ToString()),
                };

                reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.SetParameters(p);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception er)
            {

                Console.WriteLine(er);
            }
        }
    }
}
