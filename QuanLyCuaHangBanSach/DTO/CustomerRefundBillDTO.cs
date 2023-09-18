using System;
using System.Data;

namespace QuanLyCuaHangBanSach.DTO
{
    public class CustomerRefundBillDTO : RefundBillDTO
    {
        public int MaDonKhachHang { get; set; }
        public double DaTraKhach { get; set; }

        public CustomerRefundBillDTO(int maPhieu, double tongTien, bool trangThai, string liDo, int maDonKhachHang, int daTraKhach, DateTime ngayLap, int maNhanVien)
            :base(maPhieu, tongTien, trangThai, liDo, ngayLap, maNhanVien)
        {
            this.MaDonKhachHang = maDonKhachHang;
            this.DaTraKhach = daTraKhach;
        }

        public CustomerRefundBillDTO(DataRow row){
            this.MaPhieu = (int)row["maPhieu"];
            this.MaDonKhachHang = (int)row["maDonKhachHang"];
            this.MaNhanVien = (int)row["maNhanVien"];
            this.DaTraKhach = Convert.ToDouble(row["daTraKhach"]);
            this.TongTien = Convert.ToDouble(row["tongTien"]);
            this.TrangThai = Convert.ToBoolean(row["trangThai"]);
            this.LiDo = row["liDo"].ToString();
            this.NgayLap = (DateTime)row["ngayLap"];
        }
    }
}
