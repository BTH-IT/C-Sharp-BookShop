using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangBanSach.DTO
{
    public class BillDTO
    {
        protected DateTime NgayLap { get; set; }
        protected int MaNhanVien { get; set; }
        protected double TongTien { get; set; }

        protected BillDTO() { }

        protected BillDTO(
            DateTime ngayLap,
            int maNhanVien,
            double tongTien
        )   
        {
            this.MaNhanVien = maNhanVien;
            this.NgayLap = ngayLap;
            this.TongTien = tongTien;
        }

    }
}
