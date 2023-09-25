using System;
using System.Data;

namespace QuanLyCuaHangBanSach.DTO
{
    public class StaffDTO : HumanDTO
    {
        public string SoDienThoai { get; set; }
        public double Luong { get; set; }
        public int SoNgayNghi { get; set; }
        public int MaChucVu { get; set; }
        public StaffDTO() { }
        public StaffDTO(
            int maNhanVien,
            string tenNhanVien,
            string soDienThoai,
            string gioiTinh,
            int namSinh,
            int maChucVu,
            double luong
            )
        : base(maNhanVien, tenNhanVien, gioiTinh, namSinh)
        {
            this.SoDienThoai = soDienThoai;
            this.MaChucVu = maChucVu;
            this.Luong = luong;
        }

        public StaffDTO(DataRow row)
        {
            this.Ma = (int)row["maNhanVien"];
            this.MaChucVu = (int)row["maChucVu"];
            this.Ten = row["tenNhanVien"].ToString();
            this.SoDienThoai = row["soDienThoai"].ToString();
            this.GioiTinh = row["gioiTinh"].ToString();
            this.NamSinh = (int)row["namSinh"];
            this.Luong = Convert.ToDouble(row["Luong"]);
        }
    }
}