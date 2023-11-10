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
            int namSinh
        ): base(maTacGia, tenTacGia, gioiTinh, namSinh) {
        }

        public AuthorDTO(DataRow row)
        {
            this.Ma = (int) row["maTacGia"];
            this.Ten = row["tenTacGia"].ToString();
            this.GioiTinh = row["gioiTinh"].ToString();
            this.NamSinh = (int)row["namSinh"];
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
