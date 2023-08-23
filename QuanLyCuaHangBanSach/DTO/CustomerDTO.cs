using System.Data;

namespace QuanLyCuaHangBanSach.DTO
{
    public class CustomerDTO
    {
        public int MaKhachHang { get; private set; }
        public string TenKhachHang { get; set; }
        public string SoDienThoai { get; private set; }
        public string GioiTinh { get; set; }
        public string NamSinh { get; set; }

        public CustomerDTO() { }
        public CustomerDTO(int maKhachHang, string tenKhachHang, string soDienThoai, string gioiTinh, string namSinh)
        {
            this.MaKhachHang = maKhachHang;
            this.TenKhachHang = tenKhachHang;
            this.SoDienThoai = soDienThoai;
            this.GioiTinh = gioiTinh;
            this.NamSinh = namSinh;
        }

        public CustomerDTO(DataRow row)
        {
            this.TenKhachHang = row["tenKhachHang"].ToString();
            this.MaKhachHang = (int)row["maKhachHang"];
            this.SoDienThoai = row["soDienThoai"].ToString();
            this.GioiTinh = row["gioiTinh"].ToString();
            this.NamSinh = row["namSinh"].ToString();
        }

        public override string ToString()
        {
            return this.MaKhachHang + " " + this.TenKhachHang + " " + this.SoDienThoai + " " + this.GioiTinh + " " + this.NamSinh;
        }
    }
}
