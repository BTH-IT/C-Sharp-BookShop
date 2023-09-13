using System;
using System.Data;

namespace QuanLyCuaHangBanSach.DTO
{
    public class ImportRefundBillDTO : RefundBillDTO
    {
        public int MaDonNhapHang { get; set; }
        public double NhaCungCapDaTra { get; set; }

        public ImportRefundBillDTO(int maPhieu, double tongTien, bool trangThai, string liDo, int maDonNhapHang, int nhaCungCapDaTra, DateTime ngayLap)
            : base(maPhieu, tongTien, trangThai, liDo, ngayLap)
        {
            this.MaDonNhapHang = maDonNhapHang;
            this.NhaCungCapDaTra = nhaCungCapDaTra;
        }

        public ImportRefundBillDTO(DataRow row)
        {
            this.MaPhieu = (int)row["maPhieu"];
            this.MaDonNhapHang = (int)row["maDonNhapHang"];
            this.NhaCungCapDaTra = Convert.ToDouble(row["nhaCungCapDaTra"]);
            this.TongTien = Convert.ToDouble(row["tongTien"]);
            this.TrangThai = Convert.ToBoolean(row["trangThai"]);
            this.LiDo = row["liDo"].ToString();
            this.NgayLap = (DateTime)row["ngayLap"];
        }
    }
}
