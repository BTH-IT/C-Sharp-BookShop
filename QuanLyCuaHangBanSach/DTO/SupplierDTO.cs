using System;
using System.Data;

namespace QuanLyCuaHangBanSach.DTO
{
    public class SupplierDTO
    {
        public int MaNhaCungCap { get; private set; }
        public string TenNhaCungCap { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }

        public bool TrangThai { get; set; }

        public SupplierDTO() { }
        public SupplierDTO(
            int maNhaCungCap,
            string tenNhaCungCap,
            string diaChi,
            string soDienThoai,
            bool trangThai
        )
        {
            this.MaNhaCungCap = maNhaCungCap;
            this.TenNhaCungCap = tenNhaCungCap;
            this.DiaChi = diaChi;
            this.SoDienThoai = soDienThoai;
            this.TrangThai = trangThai;
        }

        public SupplierDTO(DataRow row)
        {
            this.MaNhaCungCap = (int)row["maNhaCungCap"];
            this.TenNhaCungCap = row["tenNhaCungCap"].ToString();
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
