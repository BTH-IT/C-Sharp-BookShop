﻿using System;

namespace QuanLyCuaHangBanSach.DTO
{
    public class RefundBillDTO
    {
        public int MaPhieu { get; protected set; }
        public int MaNhanVien { get; set; }
        public double TongTien { get; set; }
        public bool TrangThai { get; set; }
        public string LiDo { get; set; }
        public DateTime NgayLap { get; set; }

        public RefundBillDTO() { }

        public RefundBillDTO(int maPhieu, double tongTien, bool trangThai, string liDo, DateTime ngayLap, int maNhanVien)
        {
            this.MaPhieu = maPhieu;
            this.TongTien = tongTien;
            this.TrangThai = trangThai;
            this.LiDo = liDo;
            this.NgayLap = ngayLap;
            this.MaNhanVien = maNhanVien;
        }
    }
}
