﻿using System.Data;

namespace QuanLyCuaHangBanSach.DTO
{
    public class HumanDTO
    {
        public int Ma { get; protected set; }
        public string Ten { get; set; }

        public string GioiTinh { get; set; }
        public int NamSinh { get; set; }

        public HumanDTO() { }

        public HumanDTO(int ma, string ten, string gioiTinh, int namSinh)
        {
            this.Ma = ma;
            this.Ten = ten;
            this.GioiTinh = gioiTinh;
            this.NamSinh = namSinh;
        }
    }
}
