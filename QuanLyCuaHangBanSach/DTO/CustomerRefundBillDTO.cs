using System;
using System.Data;

namespace QuanLyCuaHangBanSach.DTO
{
    public class CustomerRefundBillDTO : RefundBillDTO
    {
        public int MaDonKhachHang { get; set; }

        public CustomerRefundBillDTO(int maPhieu, double tongTien, string liDo, int maDonKhachHang, DateTime ngayLap, int maNhanVien)
            :base(maPhieu, tongTien, liDo, ngayLap, maNhanVien)
        {
            this.MaDonKhachHang = maDonKhachHang;
        }

        public CustomerRefundBillDTO(DataRow row){
            this.MaPhieu = (int)row["maPhieu"];
            this.MaDonKhachHang = (int)row["maDonKhachHang"];
            this.MaNhanVien = (int)row["maNhanVien"];
            this.TongTien = Convert.ToDouble(row["tongTien"]);
            this.LiDo = row["liDo"].ToString();
            this.NgayLap = (DateTime)row["ngayLap"];
        }
    }
}
