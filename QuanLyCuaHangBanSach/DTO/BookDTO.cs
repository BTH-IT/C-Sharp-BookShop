using System;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;

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
        public double GiaBan { get; set; }
        public double GiaNhap { get; set; }
        public int NamXuatBan { get; set; }

        public BookDTO() { }
        public BookDTO(
            int maSach,
            string tenSach,
            byte[] hinhAnh,
            int maTheLoai,
            int maTacGia,
            int maNhaXuatBan,
            int soLuongConLai,
            double giaBan,
            double giaNhap,
            int namXuatBan
        ) {
            this.MaSach = maSach;
            this.TenSach = tenSach;
            this.HinhAnh = hinhAnh;
            this.MaTheLoai = maTheLoai;
            this.MaTacGia = maTacGia;
            this.MaNhaXuatBan = maNhaXuatBan;
            this.SoLuongConLai = soLuongConLai;
            this.GiaBan = giaBan;
            this.GiaNhap = giaNhap;
            this.NamXuatBan = namXuatBan;
        }

        public BookDTO(DataRow row)
        {
            this.MaSach = (int) row["maSach"];
            this.TenSach = row["tenSach"].ToString();
            this.HinhAnh = (byte[]) row["hinhAnh"];
            this.MaTheLoai = (int)row["maTheLoai"];
            this.MaTacGia = (int)row["maTacGia"];
            this.MaNhaXuatBan = (int)row["maNhaXuatBan"];
            this.SoLuongConLai = (int)row["soLuongConLai"];
            this.GiaBan = Convert.ToDouble(row["giaBan"]);
            this.GiaNhap = Convert.ToDouble(row["giaNhap"]);
            this.NamXuatBan = (int)row["namXuatBan"];
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
