using System;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;

namespace QuanLyCuaHangBanSach.DTO
{
    public class PublisherDTO
    {
        public int MaNhaXuatBan { get; private set; }
        public string TenNhaXuatBan { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }

        public PublisherDTO() { }
        public PublisherDTO(
            int maNhaXuatBan,
            string tenNhaXuatBan,
            string diaChi,
            string soDienThoai
        ) {
            this.MaNhaXuatBan = maNhaXuatBan;
            this.TenNhaXuatBan = tenNhaXuatBan;
            this.DiaChi = diaChi;
            this.SoDienThoai = soDienThoai;
        }

        public PublisherDTO(DataRow row)
        {
            this.MaNhaXuatBan = (int) row["maNhaXuatBan"];
            this.TenNhaXuatBan = row["tenNhaXuatBan"].ToString();
            this.DiaChi = row["diaChi"].ToString();
            this.SoDienThoai = row["soDienThoai"].ToString();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
