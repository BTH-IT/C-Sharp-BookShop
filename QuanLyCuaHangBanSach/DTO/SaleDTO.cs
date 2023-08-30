using System;
using System.Data;

namespace QuanLyCuaHangBanSach.DTO
{
    public class SaleDTO
    {
        public int MaKhuyenMai { get; private set; }
        public string TenKhuyenMai { get; set; }
        public byte PhanTram { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }

        public SaleDTO() { }

        public SaleDTO(int maKhuyenMai, string tenKhuyenMai, byte phanTram, DateTime ngayBatDau, DateTime ngayKetThuc) {
            this.MaKhuyenMai = maKhuyenMai;
            this.TenKhuyenMai = tenKhuyenMai;
            this.PhanTram = phanTram;
            this.NgayBatDau = ngayBatDau;
            this.NgayKetThuc = ngayKetThuc;
        }

        public SaleDTO(DataRow row)
        {
            this.MaKhuyenMai = (int)row["maKhuyenMai"];
            this.TenKhuyenMai = row["tenKhuyenMai"].ToString();
            this.PhanTram = (byte)row["phanTram"];
            this.NgayBatDau = (DateTime) row["ngayBatDau"];
            this.NgayKetThuc = (DateTime)row["ngayKetThuc"];
        }
    }
}
