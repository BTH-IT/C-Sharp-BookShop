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
            int maDonHang, int maSach, int soLuong, long donGia
        ) : base(maDonHang, maSach, soLuong, donGia)
        {
        }

        public ImportBillDetailDTO(DataRow row)
        {
            this.MaDon = (int)row["maDonNhapHang"];
            this.MaSach = (int)row["maSach"];
            this.SoLuong = (int)row["soLuong"];
            this.DonGia = (double)row["donGia"];
        }
    }
}
