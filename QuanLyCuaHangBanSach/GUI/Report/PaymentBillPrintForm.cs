using System;
using System.Windows.Forms;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.GUI.Report
{
    public partial class PaymentBillPrintForm : Form
    {
        private PaymentBillDTO paymentBill;
        public PaymentBillPrintForm(int maPhieuChi)
        {
            InitializeComponent();
            this.paymentBill = PaymentBillBUS.Instance.getById(maPhieuChi.ToString());
        }

        private void PaymentBillPrintForm_Load(object sender, EventArgs e)
        {
            StaffDTO staff = StaffBUS.Instance.getById(paymentBill.MaNhanVien.ToString());

            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pInvoiceCode", paymentBill.MaPhieu.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pImportBill", paymentBill.MaDonNhapHang.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pEmployee", staff.Ten.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pDate", paymentBill.NgayLap.GetDateTimeFormats()[0].ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pReason", paymentBill.LiDo.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pNote", paymentBill.GhiChu.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pTotalPrice", paymentBill.TongTien.ToString()),
            };

            reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.SetParameters(p);
            this.reportViewer1.RefreshReport();
        }
    }
}
