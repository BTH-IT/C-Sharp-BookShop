using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangBanSach.DTO
{
	public class OrderBillDTO 
	{
		public int MaPhieuYeuCau { get; set; }
		public int MaNhaCungCap { get; set; }
		public int MaNhanVien { get; set; }
		public DateTime NgayLap { get; set; }	
		public bool TrangThai { get; set; }
		
		public OrderBillDTO() { }	
		public OrderBillDTO(int maPhieuYeuCau,int maNhaCungCap,int maNhanVien,DateTime ngayLap, bool trangThai) 
		{
			this.MaPhieuYeuCau = maPhieuYeuCau;
			this.MaNhaCungCap = maNhaCungCap;
			this.MaNhanVien = maNhanVien;
			this.NgayLap = ngayLap;	
			this.TrangThai = trangThai;	
		}
		public OrderBillDTO(DataRow row)
		{
			this.MaPhieuYeuCau = (int)row["maPhieuYeuCau"];
			this.MaNhaCungCap = (int)row["maNhaCungCap"];
			this.MaNhanVien = (int)row["maNhanVien"];
			this.NgayLap = (DateTime)row["ngayLap"];
			this.TrangThai = Convert.ToBoolean(row["trangThai"]);
		}

	}
}
