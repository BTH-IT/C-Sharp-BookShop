using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop_CNPM.DTO
{
    public class CustomerRefundBillDetailDTO : BillDetailDTO
    {
        public CustomerRefundBillDetailDTO() : base()
        {
        }

        public CustomerRefundBillDetailDTO(
            int maDonHang, int maSach, int soLuong, double donGia
        ) : base(maDonHang, maSach, soLuong, donGia)
        {
        }

        public CustomerRefundBillDetailDTO(DataRow row)
        {
            this.MaDon = (int)row["maPhieuTraBanHang"];
            this.MaSach = (int)row["maSach"];
            this.SoLuong = (int)row["soLuong"];
            this.DonGia = Convert.ToDouble(row["donGia"]);
            this.ThanhTien = this.SoLuong * this.DonGia;
        }
    }
}
