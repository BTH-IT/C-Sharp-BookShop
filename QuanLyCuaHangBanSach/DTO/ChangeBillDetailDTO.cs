using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop_CNPM.DTO
{
    public class ChangeBillDetailDTO
    {
        

        public int MaDon { get; set; }
        public int SachCanDoi { get; set; }
        public int SachMuonDoi { get; set; }
        public int soLuong { get; set; }

        public ChangeBillDetailDTO()
        {
        }

        public ChangeBillDetailDTO(int MaDon, int SachCanDoi, int SachMuonDoi,int soLuong)
        {
            this.MaDon = MaDon;
            this.SachCanDoi = SachCanDoi;
            this.SachMuonDoi = SachMuonDoi;
            this.soLuong = soLuong;
        }
    }
}
