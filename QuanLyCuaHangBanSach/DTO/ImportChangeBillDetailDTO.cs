using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop_CNPM.DTO
{
    public class ImportChangeBillDetailDTO : ChangeBillDetailDTO
    {
        public ImportChangeBillDetailDTO() : base()
        {
        }

        public ImportChangeBillDetailDTO(
            int MaDon, int SachCanDoi, int SachMuonDoi, int soLuong
        ) : base(MaDon, SachCanDoi, SachMuonDoi, soLuong)
        {
        }

        public ImportChangeBillDetailDTO(DataRow row)
        {
            this.MaDon = Convert.ToInt32(row["maPhieuDoiNhapHang"].ToString());
            this.SachCanDoi = (int)row["maSachCanDoi"];
            this.SachMuonDoi = (int)row["maSachMuonDoi"];
            this.soLuong = (int)row["soLuong"];
        }
    }
}
