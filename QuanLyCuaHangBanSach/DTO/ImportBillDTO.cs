using System;
using System.Data;

namespace QuanLyCuaHangBanSach.DTO
{
    public class ImportBillDTO : BillDTO
    {
        public int MaDonNhapHang { get; set; }
        public int MaNhaCungCap { get; set; }
        public double DaTra { get; set; }

        public ImportBillDTO() : base()
        {
        }

        public ImportBillDTO(
            int maDonNhapHang, int maNhaCungCap, int daTra, int maNhanVien, DateTime ngayLap, double tongTien
        ) : base(ngayLap, maNhanVien, tongTien)
        {
            this.MaDonNhapHang = maDonNhapHang;
            this.MaNhaCungCap = maNhaCungCap;
            this.DaTra = daTra;
        }

        public ImportBillDTO(DataRow row)
        {
            this.MaDonNhapHang = (int)row["maDonNhapHang"];
            this.MaNhaCungCap = (int)row["maNhaCungCap"];
            this.NgayLap = (DateTime)row["ngayLap"];
            this.MaNhanVien = (int)row["maNhanVien"];
            this.TongTien = (double)row["tongTien"];
            this.DaTra = (double)row["daTra"];
        }
    }
}
