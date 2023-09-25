using System;
using System.Data;

namespace QuanLyCuaHangBanSach.DTO
{
    public class CustomerChangeBillDTO : ChangeBillDTO
    {
        public int MaKhachHang { get; set; }
        public CustomerChangeBillDTO()
        {
        }
        public CustomerChangeBillDTO(int maPhieu, string tinhTrangSanPham, string liDo,
            int maKhachHang, DateTime ngayLap, int maSachCanDoi, int maSachMuonDoi, int maNhanVien)
            :base(maPhieu, tinhTrangSanPham, liDo, ngayLap, maSachCanDoi, maSachMuonDoi, maNhanVien)
        {
            this.MaKhachHang = maKhachHang;
        }

        public CustomerChangeBillDTO(DataRow row){
            this.MaPhieu = (int)row["maPhieuDoiBanHang"];
            this.MaKhachHang = (int)row["maKhachHang"];
            this.SachCanDoi = (int)row["maSachCanDoi"];
            this.SachMuonDoi = (int)row["maSachMuonDoi"];
            this.MaNhanVien = (int)row["maNhanVien"];
            this.TinhTrangSanPham = row["tinhTrangSanPham"].ToString();
            this.LiDo = row["liDo"].ToString();
            this.NgayLap = (DateTime)row["ngayLap"];
        }
    }
}
