using System;
using System.Data;

namespace QuanLyCuaHangBanSach.DTO
{
    public class PaymentBillDTO : RefundBillDTO
    {
        public string GhiChu {  get; set; }
        public int MaDonNhapHang {  get; set; }

        public PaymentBillDTO() { }

        public PaymentBillDTO(int maPhieu, double tongTien, string liDo, int maNhanVien, string ghiChu, DateTime ngayLap, int maDonNhapHang)
            : base(maPhieu, tongTien, liDo, ngayLap, maNhanVien)
        {
            this.GhiChu = ghiChu;
            this.MaDonNhapHang = maDonNhapHang;
        }

        public PaymentBillDTO(DataRow row)
        {
            this.MaPhieu = (int)row["maPhieuChi"];
            this.MaNhanVien = (int)row["maNhanVien"];
            this.MaDonNhapHang = (int)row["maDonNhapHang"];
            this.TongTien = Convert.ToDouble(row["tongTienChi"]);
            this.LiDo = row["liDo"].ToString();
            this.GhiChu = row["ghiChu"].ToString();
            this.NgayLap = (DateTime)row["ngayLap"];
        }
    }
}
