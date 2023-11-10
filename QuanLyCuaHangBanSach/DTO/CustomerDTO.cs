using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangBanSach.DTO
{
   public class CustomerDTO : HumanDTO
    {
        public string SoDienThoai {  get;private set; }
        public int Diem { get; set; }

        public CustomerDTO() { }
        
        public CustomerDTO(int ma, string ten, string gioiTinh, int namSinh,string soDienThoai , int diem) : base(ma, ten , gioiTinh, namSinh) {
            SoDienThoai = soDienThoai;
            Diem = diem;
        }

        public CustomerDTO(DataRow row)
        {
            this.Ma = (int)row["maKhachHang"];
            this.Ten = row["tenKhachHang"].ToString();
            this.SoDienThoai = row["soDienThoai"].ToString();
            this.GioiTinh = row["gioiTinh"].ToString();
            this.NamSinh = (int)row["namSinh"];
            this.Diem = (int)row["diem"];
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
