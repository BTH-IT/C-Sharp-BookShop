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
        public DateTime NgayLap { get; set; }
        public int MaNhanVien { get; set; }
        public double TongTien { get; set; }

        public BillDTO() { }

        public BillDTO(
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
