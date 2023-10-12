using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.GUI.Report
{
    public partial class CustomerRefundBillPrintForm : Form
    {
        private CustomerRefundBillDTO customerRefundBill;
        public CustomerRefundBillPrintForm(int maDonTraHang)
        {
            InitializeComponent();
            this.customerRefundBill = CustomerRefundBillBUS.Instance.getById(maDonTraHang.ToString());
        }

        private void CustomerRefundBillPrintForm_Load(object sender, EventArgs e)
        {
            List<CustomerBillDetailDTO> customerBillDetailList = CustomerBillBUS.Instance.getCustomerBillDetailList(
                customerRefundBill.MaPhieu.ToString()
            );

            StaffDTO staff = StaffBUS.Instance.getById(customerRefundBill.MaNhanVien.ToString());

            CustomerBillDTO customerBill = CustomerBillBUS.Instance.getById(customerRefundBill.MaDonKhachHang.ToString());

            CustomerDTO customer = CustomerBUS.Instance.getById(customerBill.MaKhachHang.ToString());


            System.Data.DataTable dataTable = this.bookDataSet1.Tables[0];

            int count = 1;
            BookDTO book;
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

                count++;
            }

            this.bindingSource1.DataSource = dataTable;

            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pInvoiceCode", customerRefundBill.MaPhieu.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pCustomerBill", customerRefundBill.MaDonKhachHang.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pEmployee", staff.Ten.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pDate", customerRefundBill.NgayLap.GetDateTimeFormats()[0].ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pCustomerName", customer == null ? "Không có" : customer.Ten.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pTotalPrice", customerRefundBill.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pTotalAmount", amount.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pReason", customerRefundBill.LiDo.ToString())
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
