using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.GUI.Report
{
    public partial class ImportBillPrintForm : Form
    {
        private int maDonNhapHang;
        public ImportBillPrintForm(int maDonNhapHang)
        {
            InitializeComponent();
            this.maDonNhapHang = maDonNhapHang;
        }

        private void ImportBillPrintForm_Load(object sender, EventArgs e)
        {
            List<ImportBillDetailDTO> importBillDetailList = ImportBillBUS.Instance.getImportBillDetailList(maDonNhapHang.ToString());

            ImportBillDTO importBill = ImportBillBUS.Instance.getById(maDonNhapHang.ToString());

            StaffDTO staff = StaffBUS.Instance.getById(importBill.MaNhanVien.ToString());

            SupplierDTO supplier = SupplierBUS.Instance.getById(importBill.MaNhaCungCap.ToString());

            System.Data.DataTable dataTable = this.bookDataSet1.Tables[0];

            int count = 1;
            BookDTO book;
            int amount = 0;
            foreach (ImportBillDetailDTO importBillDetail in importBillDetailList)
            {
                book = BookBUS.Instance.getById(importBillDetail.MaSach.ToString());

                dataTable.Rows.Add(
                    count,
                    book.TenSach,
                    importBillDetail.SoLuong,
                    string.Format("{0:N0} VNĐ", importBillDetail.DonGia),
                    string.Format("{0:N0} VNĐ", importBillDetail.ThanhTien)
                );

                amount += importBillDetail.SoLuong;

                count++;
            }

            this.bindingSource1.DataSource = dataTable;

            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pInvoiceCode", importBill.MaDonNhapHang.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pEmployee", staff.Ten.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pDate", importBill.NgayLap.GetDateTimeFormats()[0].ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pSupplier", supplier.TenNhaCungCap),
                new Microsoft.Reporting.WinForms.ReportParameter("pTotalPrice", string.Format("{0:N0} VNĐ", importBill.TongTien)),
                new Microsoft.Reporting.WinForms.ReportParameter("pBenefitPercent", importBill.PhanTramLoiNhuan + "%"),
                new Microsoft.Reporting.WinForms.ReportParameter("pTotalAmount", amount.ToString())
            };

            // Set the data source of the report
            ReportDataSource reportDataSource = new ReportDataSource("BookDataList", dataTable);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.LocalReport.SetParameters(p);
            this.reportViewer1.RefreshReport();
        }
    }
}
