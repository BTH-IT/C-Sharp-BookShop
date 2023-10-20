using System;
using System.Data;

namespace QuanLyCuaHangBanSach.DTO
{
    public class StaffDTO
    {
        public int Ma { get; protected set; }
        public string Ten { get; set; }
        public string GioiTinh { get; set; }
        public int NamSinh { get; set; }
        public bool TrangThai { get; set; }
        public string SoDienThoai { get; set; }
        public double Luong { get; set; }
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
        {
            this.Ma = maNhanVien;
            this.Ten = tenNhanVien;
            this.GioiTinh = gioiTinh;
            this.NamSinh = namSinh;
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