using System;
using System.Data;

namespace QuanLyCuaHangBanSach.DTO
{
    public class ImportBillDTO : BillDTO
    {
        public int MaDonNhapHang { get; set; }
        public int MaNhaCungCap { get; set; }
        public int PhanTramLoiNhuan { get; set; }
        public int MaPhieuYeuCau { get; set; }

		public ImportBillDTO() : base()
        {
        }

        public ImportBillDTO(
            int maDonNhapHang, int maNhaCungCap, int maNhanVien, DateTime ngayLap, decimal tongTien, int phanTramLoiNhuan, int maPhieuYeuCau
        ) : base(ngayLap, maNhanVien, tongTien)
        {
            this.MaDonNhapHang = maDonNhapHang;
            this.MaNhaCungCap = maNhaCungCap;
            this.PhanTramLoiNhuan = phanTramLoiNhuan;
            this.MaPhieuYeuCau = maPhieuYeuCau;
		}

        public ImportBillDTO(DataRow row)
        {
            this.MaDonNhapHang = (int)row["maDonNhapHang"];
            this.MaNhaCungCap = (int)row["maNhaCungCap"];
            this.NgayLap = (DateTime)row["ngayLap"];
            this.MaNhanVien = (int)row["maNhanVien"];
            this.TongTien = Convert.ToDecimal(row["tongTien"]);
            this.PhanTramLoiNhuan = Convert.ToInt32(row["phanTramLoiNhuan"]);
            this.MaPhieuYeuCau = (int)row["maPhieuYeuCau"];
		}
    }
}
