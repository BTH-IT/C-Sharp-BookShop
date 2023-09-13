using System;
using System.Data;

namespace QuanLyCuaHangBanSach.DTO
{
    public class PermissionDTO
    {
        public int MaQuyenHang { get; private set; }
        public string TenQuyenHang { get; set; }
        public bool TrangThai { get; set; }

        public PermissionDTO() { }

        public PermissionDTO(int maQuyenHang, string tenQuyenHang, bool trangThai)
        {
            this.MaQuyenHang = maQuyenHang;
            this.TenQuyenHang = tenQuyenHang;
            this.TrangThai = trangThai;
        }

        public PermissionDTO(DataRow row)
        {
            this.MaQuyenHang = (int)row["maQuyenHang"];
            this.TenQuyenHang = row["tenQuyenHang"].ToString();
            this.TrangThai = Convert.ToBoolean(row["trangThai"].ToString());
        }
    }
}
