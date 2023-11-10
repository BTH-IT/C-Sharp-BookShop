using System;
using System.Data;

namespace BookShop_CNPM.DTO
{
    public class ImportChangeBillDTO : ChangeBillDTO
    {
        public int MaDonNhapHang {  get; set; }

        public ImportChangeBillDTO()
        {
        }

        public ImportChangeBillDTO(int maPhieu,int maDonNhapHang, string tinhTrangSanPham, string liDo, DateTime ngayLap, int maNhanVien)
            : base(maPhieu, tinhTrangSanPham, liDo, ngayLap, maNhanVien)
        {
            this.MaDonNhapHang = maDonNhapHang;   
        }

        public ImportChangeBillDTO(DataRow row)
        {
            this.MaPhieu = (int)row["maPhieuDoiNhapHang"];
            this.MaDonNhapHang = (int)row["maDonNhapHang"];
            this.MaNhanVien = (int)row["maNhanVien"];
            this.TinhTrangSanPham = row["tinhTrangSanPham"].ToString();
            this.LiDo = row["liDo"].ToString();
            this.NgayLap = (DateTime)row["ngayLap"];
        }

        
    }
}
