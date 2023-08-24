using System;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;

namespace QuanLyCuaHangBanSach.DTO
{
    public class AuthorDTO
    {
        public int MaTacGia { get; private set; }
        public string TenTacGia { get; set; }
        public string GioiTinh { get; set; }
        public int NamSinh { get; set; }

        public AuthorDTO() { }
        public AuthorDTO(
            int maTacGia,
            string tenTacGia,
            string gioiTinh,
            int namSinh
        ) {
            this.MaTacGia = maTacGia;
            this.TenTacGia = tenTacGia;
            this.GioiTinh = gioiTinh;
            this.NamSinh = namSinh;
        }

        public AuthorDTO(DataRow row)
        {
            this.MaTacGia = (int) row["maTacGia"];
            this.TenTacGia = row["tenTacGia"].ToString();
            this.GioiTinh = row["gioiTinh"].ToString();
            this.NamSinh = (int)row["namSinh"];
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
