using System;
using System.Data;

namespace QuanLyCuaHangBanSach.DTO
{
    public class AuthDetailDTO
    {
        public int MaChucVu { get; set; }
        public int MaQuyenHan { get; set; }
        public bool TrangThai { get; set; }

        public AuthDetailDTO() { }

        public AuthDetailDTO(int maChucVu, int maQuyenHan, bool trangThai) {
            this.MaChucVu = maChucVu;
            this.MaQuyenHan = maQuyenHan;
            this.TrangThai = trangThai;
        }

        public AuthDetailDTO(DataRow row) {
            this.MaChucVu = (int)row["maChucVu"];
            this.MaQuyenHan = (int)row["maQuyenHan"];
            this.TrangThai = Convert.ToBoolean(Convert.ToInt32(row["trangThai"]));
        }
    }
}
