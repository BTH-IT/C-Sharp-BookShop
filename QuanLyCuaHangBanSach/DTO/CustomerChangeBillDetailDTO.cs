using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop_CNPM.DTO
{
    public class CustomerChangeBillDetailDTO : ChangeBillDetailDTO
    {
        public CustomerChangeBillDetailDTO() : base()
        { }
        public CustomerChangeBillDetailDTO(
            int MaDon, int SachCanDoi, int SachMuonDoi, int soLuong
        ) : base(MaDon, SachCanDoi, SachMuonDoi, soLuong)
        {
        }

        public CustomerChangeBillDetailDTO(DataRow row)
        {
            this.MaDon = (int)row["maPhieuDoiBanHang"];
            this.SachCanDoi = (int)row["maSachCanDoi"];
            this.SachMuonDoi = (int)row["maSachMuonDoi"];
            this.soLuong = (int)row["soLuong"];
        }
    }
}
