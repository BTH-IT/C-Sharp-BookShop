using System;
using System.Data;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Markup;

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
            this.MaSach = Convert.ToInt32(row["maSach"]);
            this.TenSach = row["tenSach"].ToString();
            this.HinhAnh = (byte[])row["hinhAnh"];
            this.MaTheLoai = Convert.ToInt32(row["maTheLoai"]);
            this.MaTacGia = Convert.ToInt32(row["maTacGia"]);
            this.MaNhaXuatBan = Convert.ToInt32(row["maNhaXuatBan"]);
            this.SoLuongConLai = Convert.ToInt32(row["soLuongConLai"]);
            this.GiaBan = Convert.ToDouble(row["giaBan"]);
            this.GiaNhap = Convert.ToDouble(row["giaNhap"]);
            this.NamXuatBan = Convert.ToInt32(row["namXuatBan"]);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
