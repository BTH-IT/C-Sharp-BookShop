using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangBanSach.DTO
{
    public class CustomerBillDetailDTO : BillDetailDTO
    {
        public CustomerBillDetailDTO() : base()
        {
        }

        public CustomerBillDetailDTO(
            int maDonHang, int maSach, int soLuong, double donGia
        ) : base(maDonHang, maSach, soLuong, donGia)
        {
        }

        public CustomerBillDetailDTO(DataRow row)
        {
            this.MaDon = (int)row["maDonKhachHang"];
            this.MaSach = (int)row["maSach"];
            this.SoLuong = (int)row["soLuong"];
            this.DonGia = Convert.ToDouble(row["donGia"]);
            this.ThanhTien = this.SoLuong * this.DonGia;
        }
    }
}
