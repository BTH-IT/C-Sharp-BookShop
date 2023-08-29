using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangBanSach.DTO
{
    public class BillDetailDTO
    {
        protected int MaDon { get; set; }
        protected int MaSach { get; set; }
        protected int SoLuong { get; set; }
        protected double DonGia { get; set; }
        protected double ThanhTien { get; }

        protected BillDetailDTO() { }

        protected BillDetailDTO(
            int maSach,
            int soLuong,
            double donGia
        )
        {
            this.MaSach = maSach;
            this.SoLuong = soLuong;
            this.DonGia = donGia;
            this.ThanhTien = soLuong * donGia;
        }
    }
}
