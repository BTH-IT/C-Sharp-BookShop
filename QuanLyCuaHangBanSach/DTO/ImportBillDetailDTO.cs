using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangBanSach.DTO
{
    public class ImportBillDetailDTO : BillDetailDTO
    {
        public ImportBillDetailDTO() : base()
        {
        }

        public ImportBillDetailDTO(
            int maDonHang, int maSach, int soLuong, double donGia
        ) : base(maDonHang, maSach, soLuong, donGia)
        {
        }

        public ImportBillDetailDTO(DataRow row)
        {
            this.MaDon = Convert.ToInt32(row["maDonNhapHang"].ToString());
            this.MaSach = Convert.ToInt32(row["maSach"].ToString());
            this.SoLuong = Convert.ToInt32(row["soLuong"].ToString());
            this.DonGia = Convert.ToDouble(row["donGia"].ToString());
            this.ThanhTien = this.SoLuong * this.DonGia;
        }
    }
}
