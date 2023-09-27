using System;
using System.Data;

namespace QuanLyCuaHangBanSach.DTO
{
    public class ImportChangeBillDTO : ChangeBillDTO
    {
        public int MaNhaCungCap { get; set; }

        public ImportChangeBillDTO()
        {
        }

        public ImportChangeBillDTO(int maPhieu, string tinhTrangSanPham, string liDo,
            int maNhaCungCap, DateTime ngayLap, int maSachCanDoi, int maSachMuonDoi, int maNhanVien)
            : base(maPhieu, tinhTrangSanPham, liDo, ngayLap, maSachCanDoi, maSachMuonDoi, maNhanVien)
        {
            this.MaNhaCungCap = MaNhaCungCap;
        }

        public ImportChangeBillDTO(DataRow row)
        {
            this.MaPhieu = (int)row["maPhieuDoiNhapHang"];
            this.MaNhaCungCap = (int)row["maNhaCungCap"];
            this.SachCanDoi = (int)row["maSachCanDoi"];
            this.SachMuonDoi = (int)row["maSachMuonDoi"];
            this.MaNhanVien = (int)row["maNhanVien"];
            this.TinhTrangSanPham = row["tinhTrangSanPham"].ToString();
            this.LiDo = row["liDo"].ToString();
            this.NgayLap = (DateTime)row["ngayLap"];
        }

        
    }
}
