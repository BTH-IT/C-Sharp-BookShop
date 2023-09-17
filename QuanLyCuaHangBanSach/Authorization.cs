using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach
{
    public class Authorization
    {
        public int MaChucVu {  get; private set; }

        public Authorization(int maChucVu) {
            this.MaChucVu = maChucVu;
        }

        public bool checkAuthorize(int maQuyenHang)
        {
            bool isCheck = AuthDetailBUS.Instance.getById(this.MaChucVu.ToString(), maQuyenHang.ToString()) == null;

            return isCheck;
        }
    }
}
