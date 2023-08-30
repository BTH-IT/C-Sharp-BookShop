using System.Data;

namespace QuanLyCuaHangBanSach.DTO
{
    public class StaffDTO : HumanDTO
    {
        public string SoDienThoai { get; set; }
        public double Luong { get; set; }
        public int SoNgayNghi { get; set; }
        public string VaiTro { get; set; }

        public StaffDTO() { }
        public StaffDTO(
            int maNhanVien,
            string tenNhanVien,
            string soDienThoai,
            string gioiTinh,
            string namSinh,
            int soNgayNghi,
            string vaiTro)
        : base(maNhanVien, tenNhanVien, gioiTinh, namSinh)
        {
            this.SoDienThoai = soDienThoai;
            this.SoNgayNghi = soNgayNghi;
            this.VaiTro = vaiTro;
        }

        public StaffDTO(DataRow row)
        {
            this.Ma = (int)row["maNhanVien"];
            this.SoNgayNghi = (int)row["soNgayNghi"];
            this.VaiTro = row["vaiTro"].ToString();
            this.Ten = row["tenNhanVien"].ToString();
            this.SoDienThoai = row["soDienThoai"].ToString();
            this.GioiTinh = row["gioiTinh"].ToString();
            this.NamSinh = row["namSinh"].ToString();
        }
    }
}
