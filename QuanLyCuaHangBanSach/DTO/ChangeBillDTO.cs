using System;

namespace QuanLyCuaHangBanSach.DTO
{
    public class ChangeBillDTO
    {
        public int MaPhieu { get; protected set; }
        public string LiDo { get; set; }
        public DateTime NgayLap { get; set; }
        public string TinhTrangSanPham { get; set; }
        public int SachCanDoi { get; set; }
        public int SachMuonDoi { get; set; }
        public int MaNhanVien { get; set; }

        public ChangeBillDTO() { }

        public ChangeBillDTO(int maPhieu, string tinhTrangSanPham, string liDo, DateTime ngayLap, int sachCanDoi, int sachMuonDoi, int maNhanVien)
        {
            this.MaPhieu = maPhieu;
            this.TinhTrangSanPham = tinhTrangSanPham;
            this.LiDo = liDo;
            this.NgayLap = ngayLap;
            this.SachCanDoi = sachCanDoi;
            this.SachMuonDoi = sachMuonDoi;
            this.MaNhanVien = maNhanVien;
        }
    }
}
