using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangBanSach.DTO
{
    public class BillDetailDTO
    {
        public int MaDon { get; protected set; }
        public int MaSach { get; set; }
        public int SoLuong { get; set; }
        public double DonGia { get; set; }
        public double ThanhTien { get; }

        public BillDetailDTO() { }

        public BillDetailDTO(
            int maDon,
            int maSach,
            int soLuong,
            double donGia
        )
        {
            this.MaDon = maDon;
            this.MaSach = maSach;
            this.SoLuong = soLuong;
            this.DonGia = donGia;
            this.ThanhTien = soLuong * donGia;
        }
    }
}
