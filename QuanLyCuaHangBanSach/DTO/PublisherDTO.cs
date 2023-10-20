using System;
using System.Data;

namespace QuanLyCuaHangBanSach.DTO
{
    public class PublisherDTO
    {
        public int MaNhaXuatBan { get; private set; }
        public string TenNhaXuatBan { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public bool TrangThai { get; set; }

        public PublisherDTO() { }
        public PublisherDTO(
            int maNhaXuatBan,
            string tenNhaXuatBan,
            string diaChi,
            string soDienThoai,
            bool trangThai
        ) {
            this.MaNhaXuatBan = maNhaXuatBan;
            this.TenNhaXuatBan = tenNhaXuatBan;
            this.DiaChi = diaChi;
            this.SoDienThoai = soDienThoai;
            this.TrangThai = trangThai;
        }

        public PublisherDTO(DataRow row)
        {
            this.MaNhaXuatBan = (int) row["maNhaXuatBan"];
            this.TenNhaXuatBan = row["tenNhaXuatBan"].ToString();
            this.DiaChi = row["diaChi"].ToString();
            this.SoDienThoai = row["soDienThoai"].ToString();
            this.TrangThai = Convert.ToBoolean(Convert.ToInt32(row["trangThai"]));
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
