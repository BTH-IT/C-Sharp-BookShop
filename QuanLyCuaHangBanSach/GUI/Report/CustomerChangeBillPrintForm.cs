using System;
using System.Windows.Forms;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.GUI.Report
{
    public partial class CustomerChangeBillPrintForm : Form
    {
        private CustomerChangeBillDTO customerChangeBill;

        public CustomerChangeBillPrintForm(int maDonDoiHang)
        {
            InitializeComponent();
            this.customerChangeBill = CustomerChangeBillBUS.Instance.getById(maDonDoiHang.ToString());
        }

        private void CustomerChangeBillPrintForm_Load(object sender, EventArgs e)
        {
            try
            {
                StaffDTO staff = StaffBUS.Instance.getById(customerChangeBill.MaNhanVien.ToString());

                CustomerDTO customer = CustomerBUS.Instance.getById(customerChangeBill.MaKhachHang.ToString());

                Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
                {
                new Microsoft.Reporting.WinForms.ReportParameter("pInvoiceCode", customerChangeBill.MaPhieu.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pEmployee", staff.Ten.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pDate", customerChangeBill.NgayLap.GetDateTimeFormats()[0].ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pSupplierName", customer == null ? "Không có" : customer.Ten.ToString()),
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
