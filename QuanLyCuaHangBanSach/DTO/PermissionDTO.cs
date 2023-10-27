using System;
using System.Data;

namespace QuanLyCuaHangBanSach.DTO
{
    public class PermissionDTO
    {
        public int MaQuyenHan { get; private set; }
        public string TenQuyenHan { get; set; }
        public bool TrangThai { get; set; }

        public PermissionDTO() { }

        public PermissionDTO(int maQuyenHan, string tenQuyenHan, bool trangThai)
        {
            this.MaQuyenHan = maQuyenHan;
            this.TenQuyenHan = tenQuyenHan;
            this.TrangThai = trangThai;
        }

        public PermissionDTO(DataRow row)
        {
            this.MaQuyenHan = (int)row["maQuyenHan"];
            this.TenQuyenHan = row["tenQuyenHan"].ToString();
            this.TrangThai = Convert.ToBoolean(Convert.ToInt32(row["trangThai"]));
        }
    }
}
