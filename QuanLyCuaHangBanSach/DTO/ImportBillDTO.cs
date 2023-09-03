using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangBanSach.DTO
{
    public class ImportBillDTO : BillDTO
    {
        public int MaDonNhapHang { get; set; }
        public int MaNhaCungCap { get; set; }

        public ImportBillDTO() : base()
        {
        }

        public ImportBillDTO(
            int maDonNhapHang, int maNhaCungCap, int maNhanVien, DateTime ngayLap, double tongTien
        ) : base(ngayLap, maNhanVien, tongTien)
        {
            this.MaDonNhapHang = maDonNhapHang;
            this.MaNhaCungCap = maNhaCungCap;
        }

        public ImportBillDTO(DataRow row)
        {
            this.MaDonNhapHang = (int)row["maDonNhapHang"];
            this.MaNhaCungCap = (int)row["maNhaCungCap"];
            this.NgayLap = (DateTime)row["ngayLap"];
            this.MaNhanVien = (int)row["maNhanVien"];
            this.TongTien = (double)row["tongTien"];
        }
    }
}
