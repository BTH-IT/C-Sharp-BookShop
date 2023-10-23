using System;
using System.Data;

namespace QuanLyCuaHangBanSach.DTO
{
    public class AuthDetailDTO
    {
        public int MaChucVu { get; set; }
        public int MaQuyenHang { get; set; }
        public bool TrangThai { get; set; }

        public AuthDetailDTO() { }

        public AuthDetailDTO(int maChucVu, int maQuyenHang, bool trangThai) {
            this.MaChucVu = maChucVu;
            this.MaQuyenHang = maQuyenHang;
            this.TrangThai = trangThai;
        }

        public AuthDetailDTO(DataRow row) {
            this.MaChucVu = (int)row["maChucVu"];
            this.MaQuyenHang = (int)row["maQuyenHang"];
            this.TrangThai = Convert.ToBoolean(Convert.ToInt32(row["trangThai"]));
        }
    }
}
