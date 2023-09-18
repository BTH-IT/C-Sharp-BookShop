using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangBanSach.DTO
{
    public class CustomerBillDTO : BillDTO
    {
        public int MaDonKhachHang { get; set; }
        public int MaKhachHang { get; set; }
        public int MaKhuyenMai { get; set; }

        public double TienKhachDua { get; set; }

        public CustomerBillDTO() : base()
        {
        }

        public CustomerBillDTO(
            int maDonKhachHang, int maKhachHang, int maNhanVien, DateTime ngayLap, double tongTien, int maKhuyenMai, double tienKhachDua
        ) : base(ngayLap, maNhanVien, tongTien)
        {
            this.MaDonKhachHang = maDonKhachHang;
            this.MaKhachHang = maKhachHang;
            this.MaKhuyenMai = maKhuyenMai;
        }

        public CustomerBillDTO(DataRow row)
        {
            this.MaDonKhachHang = (int)row["maDonKhachHang"];
            this.MaKhachHang = (int)row["maKhachHang"];
            this.MaKhuyenMai = (int)row["maKhuyenMai"];
            this.NgayLap = (DateTime)row["ngayLap"];
            this.MaNhanVien = (int)row["maNhanVien"];
            this.TongTien = (double)row["tongTien"];
            this.TienKhachDua = (double)row["tienKhachDua"];
        }
    }
}
