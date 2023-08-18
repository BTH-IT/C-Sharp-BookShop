using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangBanSach.DTO
{
    public class AccountDTO
    {
        public int MaNhanVien { get; set; }
        public string Email { get; private set; }
        public string MatKhau { get; set; }

        public AccountDTO() { }
        public AccountDTO(int maNhanVien, string email, string matKhau) {
            this.Email = email;
            this.MaNhanVien = maNhanVien;
            this.MatKhau = matKhau;
        }

        public AccountDTO(DataRow row)
        {
            this.Email = row["email"].ToString();
            this.MaNhanVien = (int) row["maNhanVien"];
            this.MatKhau = row["matKhau"].ToString();
        }

        public override string ToString()
        {
            return this.Email + " " + this.MatKhau + " " + this.MaNhanVien;
        }
    }
}
