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

        public decimal TienKhachDua { get; set; }
        public int DoiDiem { get; set; }

        public CustomerBillDTO() : base()
        {
        }

        public CustomerBillDTO(
            int maDonKhachHang, int maKhachHang, int maNhanVien, DateTime ngayLap, decimal tongTien, int maKhuyenMai, decimal tienKhachDua, int doiDiem
        ) : base(ngayLap, maNhanVien, tongTien)
        {
            this.MaDonKhachHang = maDonKhachHang;
            this.MaKhachHang = maKhachHang;
            this.MaKhuyenMai = maKhuyenMai;
            this.TienKhachDua = tienKhachDua;
            this.DoiDiem = doiDiem;
        }

        public CustomerBillDTO(DataRow row)
        {
            this.MaDonKhachHang = (int)row["maDonKhachHang"];
            this.MaKhachHang = (int)row["maKhachHang"];
            this.MaKhuyenMai = (int)row["maKhuyenMai"];
            this.NgayLap = (DateTime)row["ngayLap"];
            this.MaNhanVien = (int)row["maNhanVien"];
            this.TongTien = Convert.ToDecimal(row["tongTien"]);
            this.TienKhachDua = Convert.ToDecimal(row["tienKhachDua"]);
            this.DoiDiem = Convert.ToInt32(row["doiDiem"]);
        }
    }
}
