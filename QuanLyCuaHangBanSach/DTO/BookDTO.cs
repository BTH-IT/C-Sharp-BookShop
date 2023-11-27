using System;
using System.Data;

namespace QuanLyCuaHangBanSach.DTO
{
    public class BookDTO
    {
        public int MaSach { get; private set; }
        public string TenSach { get; set; }
        public byte[] HinhAnh { get; set; }
        public int MaTheLoai { get; set; }
        public int MaTacGia { get; set; }
        public int MaNhaXuatBan { get; set; }
        public int SoLuongConLai { get; set; }
        public decimal GiaBan { get; set; }
        public decimal GiaNhap { get; set; }

        public BookDTO() { }
        public BookDTO(
            int maSach,
            string tenSach,
            byte[] hinhAnh,
            int maTheLoai,
            int maTacGia,
            int maNhaXuatBan,
            decimal giaBan,
            decimal giaNhap
        ) {
            this.MaSach = maSach;
            this.TenSach = tenSach;
            this.HinhAnh = hinhAnh;
            this.MaTheLoai = maTheLoai;
            this.MaTacGia = maTacGia;
            this.MaNhaXuatBan = maNhaXuatBan;
            this.GiaBan = giaBan;
            this.GiaNhap = giaNhap;
        }

        public BookDTO(DataRow row)
        {
            this.MaSach = Convert.ToInt32(row["maSach"]);
            this.TenSach = row["tenSach"].ToString();
            this.HinhAnh = (byte[])row["hinhAnh"];
            this.MaTheLoai = Convert.ToInt32(row["maTheLoai"]);
            this.MaTacGia = Convert.ToInt32(row["maTacGia"]);
            this.MaNhaXuatBan = Convert.ToInt32(row["maNhaXuatBan"]);
            this.GiaBan = Convert.ToDecimal(row["giaBan"]);
            this.GiaNhap = Convert.ToDecimal(row["giaNhap"]);
            this.SoLuongConLai = Convert.ToInt32(row["soLuongConLai"]);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
