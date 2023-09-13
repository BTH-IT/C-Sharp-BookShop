using System;
using System.Data;

namespace QuanLyCuaHangBanSach.DTO
{
    public class CustomerTypeDTO
    {
        public int MaNhomKhachHang { get; private set; }
        public string TenNhomKhachHang { get; set; }
        public bool MacDinh { get; set; }

        public CustomerTypeDTO() { }

        public CustomerTypeDTO(
            int maNhomKhachHang,
            string tenNhomKhachHang,
            bool macDinh)
        {
            this.MaNhomKhachHang = maNhomKhachHang;
            this.TenNhomKhachHang = tenNhomKhachHang;
            this.MacDinh = macDinh;
        }

        public CustomerTypeDTO(DataRow row)
        {
            this.MaNhomKhachHang = (int)row["maNhomKhachHang"];
            this.TenNhomKhachHang = row["tenNhomKhachHang"].ToString();
            this.MacDinh = Convert.ToBoolean(row["macDinh"]);
        }
    }
}
