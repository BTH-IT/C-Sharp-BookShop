using Microsoft.Reporting.WinForms;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangBanSach.GUI.Report
{
	public partial class OrderBillPrintForm : Form
	{
		private int maPhieu;
		public OrderBillPrintForm(int maPhieu)
		{
			InitializeComponent();
			this.maPhieu = maPhieu;
		}

		private void OrderBillPrintForm_Load(object sender, EventArgs e)
		{
			List<OrderBillDetailDTO> OrderBillDetailList = OrderBillBUS.Instance.getOrderBillDetailList(maPhieu.ToString());

			OrderBillDTO OrderBill = OrderBillBUS.Instance.getById(maPhieu.ToString());

			StaffDTO staff = StaffBUS.Instance.getById(OrderBill.MaNhanVien.ToString());

			SupplierDTO supplier = SupplierBUS.Instance.getById(OrderBill.MaNhaCungCap.ToString());

			System.Data.DataTable dataTable = this.bookD1.Tables[0];

			BookDTO book;
	
			foreach (OrderBillDetailDTO OrderBillDetail in OrderBillDetailList)
			{
				book = BookBUS.Instance.getById(OrderBillDetail.MaSach.ToString());

				dataTable.Rows.Add(
					book.MaSach,
					book.TenSach,
					OrderBillDetail.SoLuong
				);
			}

			this.bindingSource1.DataSource = dataTable;

			Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
			{
				new Microsoft.Reporting.WinForms.ReportParameter("pInvoiceCode", OrderBill.MaPhieuYeuCau.ToString()),
				new Microsoft.Reporting.WinForms.ReportParameter("pSupplierId", supplier.MaNhaCungCap.ToString()),
				new Microsoft.Reporting.WinForms.ReportParameter("pSupplierName", supplier.TenNhaCungCap),
				new Microsoft.Reporting.WinForms.ReportParameter("pDate", OrderBill.NgayLap.GetDateTimeFormats()[0].ToString()),
				new Microsoft.Reporting.WinForms.ReportParameter("pEmployeeId", staff.Ma.ToString()),
				new Microsoft.Reporting.WinForms.ReportParameter("pEmployeeName", staff.Ten.ToString()),
			};
			// Set the data source of the report
			ReportDataSource reportDataSource = new ReportDataSource("BookD", dataTable);
			reportViewer1.LocalReport.DataSources.Clear();
			reportViewer1.LocalReport.DataSources.Add(reportDataSource);
			this.reportViewer1.LocalReport.SetParameters(p);
			this.reportViewer1.RefreshReport();
		}
	}
}
