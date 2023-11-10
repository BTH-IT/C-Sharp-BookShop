using System;
using System.Data;

namespace BookShop_CNPM.DTO
{
    public class CustomerChangeBillDTO : ChangeBillDTO
    {
        public int MaDonKhachHang { get; set; }
        public CustomerChangeBillDTO()
        {
        }
        public CustomerChangeBillDTO(int maPhieu, int maDonKhachHang, string tinhTrangSanPham, string liDo, DateTime ngayLap, int maNhanVien)
            :base(maPhieu, tinhTrangSanPham, liDo, ngayLap, maNhanVien)
        {
            this.MaDonKhachHang = maDonKhachHang;
        }

        public CustomerChangeBillDTO(DataRow row){
            this.MaPhieu = (int)row["maPhieuDoiBanHang"];
            this.MaDonKhachHang = (int)row["maDonKhachHang"];
            this.MaNhanVien = (int)row["maNhanVien"];
            this.TinhTrangSanPham = row["tinhTrangSanPham"].ToString();
            this.LiDo = row["liDo"].ToString();
            this.NgayLap = (DateTime)row["ngayLap"];
        }
    }
}
