using System;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;

namespace QuanLyCuaHangBanSach.DTO
{
    public class BookTypeDTO
    {
        public int MaTheLoai { get; private set; }
        public string TenTheLoai { get; set; }

        public BookTypeDTO() { }
        public BookTypeDTO(
            int maTheLoai,
            string tenTheLoai
        ) {
            this.MaTheLoai = maTheLoai;
            this.TenTheLoai = tenTheLoai;
        }

        public BookTypeDTO(DataRow row)
        {
            this.MaTheLoai = (int) row["maTheLoai"];
            this.TenTheLoai = row["tenTheLoai"].ToString();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
