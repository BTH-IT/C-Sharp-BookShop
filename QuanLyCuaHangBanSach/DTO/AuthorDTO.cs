using System;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;

namespace QuanLyCuaHangBanSach.DTO
{
    public class AuthorDTO : HumanDTO
    {
        public AuthorDTO() { }

        public AuthorDTO(
            int maTacGia,
            string tenTacGia,
            string gioiTinh,
            int namSinh,
            int trangThai
        ): base(maTacGia, tenTacGia, gioiTinh, namSinh, trangThai) {
        }

        public AuthorDTO(DataRow row)
        {
            this.Ma = (int) row["maTacGia"];
            this.Ten = row["tenTacGia"].ToString();
            this.GioiTinh = row["gioiTinh"].ToString();
            this.NamSinh = (int)row["namSinh"];
            this.TrangThai = (bool)row["trangThai"];
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
