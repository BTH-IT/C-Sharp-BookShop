using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangBanSach.DTO
{
	public class OrderBillDetailDTO
	{
		public int MaPhieuYeuCau { get; set; }	
		public int MaSach { get; set; }

		public int SoLuong { get; set; }

		public OrderBillDetailDTO() { }	

		public OrderBillDetailDTO(int maPhieuYeuCau ,int maSach,int soLuong)
		{
			this.MaPhieuYeuCau = maPhieuYeuCau;	
			this.MaSach = maSach;	
			this.SoLuong = soLuong;	
		}
		public OrderBillDetailDTO(DataRow row)
		{
			this.MaPhieuYeuCau = Convert.ToInt32(row["maPhieuYeuCau"].ToString());
			this.MaSach = Convert.ToInt32(row["maSach"].ToString());
			this.SoLuong = Convert.ToInt32(row["soLuong"].ToString());
		}
	}
}
