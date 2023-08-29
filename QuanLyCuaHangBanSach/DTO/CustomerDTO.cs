using System.Data;

namespace QuanLyCuaHangBanSach.DTO
{
    public class CustomerDTO : HumanDTO
    {
        public string SoDienThoai { get; private set; }

        public CustomerDTO() { }
        public CustomerDTO(
            int maKhachHang,
            string tenKhachHang,
            string soDienThoai,
            string gioiTinh,
            string namSinh)
        :base(maKhachHang, tenKhachHang, gioiTinh, namSinh)
        {
            this.SoDienThoai = soDienThoai;
        }

        public CustomerDTO(DataRow row)
        {
            this.Ma = (int)row["maKhachHang"];
            this.Ten = row["tenKhachHang"].ToString();
            this.SoDienThoai = row["soDienThoai"].ToString();
            this.GioiTinh = row["gioiTinh"].ToString();
            this.NamSinh = row["namSinh"].ToString();
        }

        public override string ToString()
        {
            return this.Ma + " " + this.Ten + " " + this.SoDienThoai + " " + this.GioiTinh + " " + this.NamSinh;
        }
    }
}
