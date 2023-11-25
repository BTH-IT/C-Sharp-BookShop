using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;
using QuanLyCuaHangBanSach.GUI.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangBanSach.GUI.Modal
{
	public partial class ViewOrderBillModal : Form
	{
		public ViewOrderBillModal(OrderBillDTO OrderBill)
		{
			InitializeComponent();
			List<OrderBillDetailDTO> customerBillDetailList = OrderBillBUS.Instance.getOrderBillDetailList(OrderBill.MaPhieuYeuCau.ToString());
			StaffDTO staff = StaffBUS.Instance.getById(OrderBill.MaNhanVien.ToString());
			this.staffTxt.Text = staff.Ten;
			SupplierDTO supplier = SupplierBUS.Instance.getById(OrderBill.MaNhaCungCap.ToString());
			this.supplierTxt.Text = supplier.TenNhaCungCap;
			this.dateTxt.Text = OrderBill.NgayLap.GetDateTimeFormats()[0];
			BookDTO book;
			foreach (OrderBillDetailDTO customerBillDetail in customerBillDetailList)
			{
				book = BookBUS.Instance.getById(customerBillDetail.MaSach.ToString());

				ViewBookBill viewBook = new ViewBookBill(book.TenSach, customerBillDetail.SoLuong, 0, book.HinhAnh);

				this.bookList.Controls.Add(viewBook);
			}
		}

		private void cancelBtn_Click_1(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
