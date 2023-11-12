using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.GUI.Report
{
    public partial class CustomerBillPrintForm : Form
    {
        private int maDonKhachHang;
        public CustomerBillPrintForm(int maDonKhachHang)
        {
            InitializeComponent();
            this.maDonKhachHang = maDonKhachHang;
        }

        private void PrintCustomerBill_Load(object sender, EventArgs e)
        {
            List<CustomerBillDetailDTO> customerBillDetailList = CustomerBillBUS.Instance.getCustomerBillDetailList(maDonKhachHang.ToString());

            CustomerBillDTO customerBill = CustomerBillBUS.Instance.getById(maDonKhachHang.ToString());

            StaffDTO staff = StaffBUS.Instance.getById(customerBill.MaNhanVien.ToString());

            CustomerDTO customer = CustomerBUS.Instance.getById(customerBill.MaKhachHang.ToString());

            SaleDTO sale = SaleBUS.Instance.getById(customerBill.MaKhuyenMai.ToString());


            System.Data.DataTable dataTable = this.bookDataSet1.Tables[0];

            int count = 1;
            BookDTO book;
            double giaGoc = 0;
            int amount = 0;
            foreach (CustomerBillDetailDTO customerBillDetail in customerBillDetailList)
            {
                book = BookBUS.Instance.getById(customerBillDetail.MaSach.ToString());

                dataTable.Rows.Add(
                    count,
                    book.TenSach,
                    customerBillDetail.SoLuong,
                    customerBillDetail.DonGia,
                    customerBillDetail.ThanhTien
                );

                amount += customerBillDetail.SoLuong;
                giaGoc += customerBillDetail.ThanhTien;

                count++;
            }

            this.bindingSource1.DataSource = dataTable;

            double salePrice = sale == null ? 0 : giaGoc * (sale.PhanTram / 100.0);

            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pInvoiceCode", customerBill.MaDonKhachHang.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pEmployee", staff.Ten.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pDate", customerBill.NgayLap.GetDateTimeFormats()[0].ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pScore", customer == null ? "Không có" : customer.Diem.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pCustomerName", customer == null ? "Vãng lai" : customer.Ten.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pSale", sale == null ? "Không có" : sale.TenKhuyenMai.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pSalePrice", salePrice.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pTotalPrice", customerBill.TongTien.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pTotalAmount", amount.ToString())
            };

            // Set the data source of the report
            ReportDataSource reportDataSource = new ReportDataSource("BookDataList", dataTable);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.LocalReport.SetParameters(p);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_PrintingBegin(object sender, ReportPrintEventArgs e)
        {
            
            Console.WriteLine("printing");
        }

        private void reportViewer1_ReportError(object sender, ReportErrorEventArgs e)
        {
            Console.WriteLine("error");
        }

        private void reportViewer1_StatusChanged(object sender, EventArgs e)
        {
            Console.WriteLine(e.ToString());
        }
    }
}
