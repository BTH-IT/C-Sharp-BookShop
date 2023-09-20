using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.GUI.Report
{
    public partial class ImportRefundBillPrintForm : Form
    {
        private ImportRefundBillDTO importRefundBill;
        public ImportRefundBillPrintForm(int maDonTraHang)
        {
            InitializeComponent();
            this.importRefundBill = ImportRefundBillBUS.Instance.getById(maDonTraHang.ToString());
        }

        private void ImportRefundBillPrintForm_Load(object sender, EventArgs e)
        {
            List<ImportRefundBillDetailDTO> importBillDetailList = ImportRefundBillBUS.Instance.getImportRefundBillDetailList(
                importRefundBill.MaPhieu.ToString()
            );

            StaffDTO staff = StaffBUS.Instance.getById(importRefundBill.MaNhanVien.ToString());

            ImportBillDTO importBill = ImportBillBUS.Instance.getById(importRefundBill.MaDonNhapHang.ToString());

            SupplierDTO import = SupplierBUS.Instance.getById(importBill.MaNhaCungCap.ToString());


            System.Data.DataTable dataTable = this.bookDataSet1.Tables[0];

            int count = 1;
            BookDTO book;
            int amount = 0;

            foreach (ImportRefundBillDetailDTO importBillDetail in importBillDetailList)
            {
                book = BookBUS.Instance.getById(importBillDetail.MaSach.ToString());

                dataTable.Rows.Add(
                    count,
                    book.TenSach,
                    importBillDetail.SoLuong,
                    importBillDetail.DonGia,
                    importBillDetail.ThanhTien
                );

                amount += importBillDetail.SoLuong;

                count++;
            }

            this.bindingSource1.DataSource = dataTable;

            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pInvoiceCode", importRefundBill.MaPhieu.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pImportBill", importRefundBill.MaDonNhapHang.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pEmployee", staff.Ten.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pDate", importRefundBill.NgayLap.GetDateTimeFormats()[0].ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pSupplier", import.TenNhaCungCap.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pTotalPrice", importRefundBill.TongTien.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pTotalAmount", amount.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pReason", importRefundBill.LiDo.ToString())
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
