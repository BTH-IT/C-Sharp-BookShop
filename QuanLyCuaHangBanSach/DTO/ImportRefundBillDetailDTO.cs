using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangBanSach.DTO
{
    public class ImportRefundBillDetailDTO : BillDetailDTO
    {
        public ImportRefundBillDetailDTO() : base()
        {
        }

        public ImportRefundBillDetailDTO(
            int maDonHang, int maSach, int soLuong, double donGia
        ) : base(maDonHang, maSach, soLuong, donGia)
        {
        }

        public ImportRefundBillDetailDTO(DataRow row)
        {
            this.MaDon = Convert.ToInt32(row["maPhieuTraNhapHang"].ToString());
            this.MaSach = Convert.ToInt32(row["maSach"].ToString());
            this.SoLuong = Convert.ToInt32(row["soLuong"].ToString());
            this.DonGia = Convert.ToDouble(row["donGia"].ToString());
            this.ThanhTien = this.SoLuong * this.DonGia;
        }
    }
}
