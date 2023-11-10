using System;
using System.Data;

namespace QuanLyCuaHangBanSach.DTO
{
    public class PermissionDTO
    {
        public int maQuyenHan { get; private set; }
        public string tenQuyenHan { get; set; }
        public bool TrangThai { get; set; }

        public PermissionDTO() { }

        public PermissionDTO(int maQuyenHan, string tenQuyenHan, bool trangThai)
        {
            this.maQuyenHan = maQuyenHan;
            this.tenQuyenHan = tenQuyenHan;
            this.TrangThai = trangThai;
        }

        public PermissionDTO(DataRow row)
        {
            this.maQuyenHan = (int)row["maQuyenHan"];
            this.tenQuyenHan = row["tenQuyenHan"].ToString();
            this.TrangThai = Convert.ToBoolean(row["trangThai"]);
        }
    }
}
