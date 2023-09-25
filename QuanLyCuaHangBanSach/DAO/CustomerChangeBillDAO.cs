using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.DAO
{
    public class CustomerChangeBillDAO : IDAO<CustomerChangeBillDTO>
    {
        private static CustomerChangeBillDAO instance;

        public static CustomerChangeBillDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CustomerChangeBillDAO();
                }

                return CustomerChangeBillDAO.instance;
            }
            private set { CustomerChangeBillDAO.instance = value; }
        }
        public DataTable getAll() {
            return DataProvider.Instance.ExecuteQuery("select * from phieudoibanhang;");
        }

        public DataTable searchData(string value)
        {
            string sql = $@"SELECT * FROM phieudoibanhang WHERE maPhieuDoiBanHang LIKE @maPhieuDoiBanHang;";

            return DataProvider.Instance.ExecuteQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maPhieuDoiBanHang", "%" + value + "%"),
                }
            );
        }

        public bool insert(CustomerChangeBillDTO data)
        {

            string sql = $@"INSERT INTO phieudoibanhang (ngayLap, liDo, tinhTrangSanPham, maKhachHang, maSachCanDoi, maSachMuonDoi, maNhanVien)
                            VALUES (@ngayLap, @liDo, @tinhTrangSanPham, @maKhachHang, @maSachCanDoi, @maSachMuonDoi, @maNhanVien);";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@ngayLap", data.NgayLap),
                    new MySqlParameter("@liDo", data.LiDo),
                    new MySqlParameter("@tinhTrangSanPham", data.TinhTrangSanPham),
                    new MySqlParameter("@maKhachHang", data.MaKhachHang),
                    new MySqlParameter("@maSachCanDoi", data.SachCanDoi),
                    new MySqlParameter("@maSachMuonDoi", data.SachMuonDoi),
                    new MySqlParameter("@maNhanVien", data.MaNhanVien),
                });

            return rowChanged > 0;
        }

        public CustomerChangeBillDTO insertReturnBill(CustomerChangeBillDTO data)
        {
            string sql = "SELECT * FROM phieudoibanhang ORDER BY maPhieuDoiBanHang DESC LIMIT 1;";
            if (this.insert(data))
            {

                DataTable dataTable = DataProvider.Instance.ExecuteQuery(sql);

                if (dataTable.Rows.Count <= 0) return null;

                CustomerChangeBillDTO customerBill = new CustomerChangeBillDTO(dataTable.Rows[0]);

                return customerBill;
            };

            return null;
        }

        public bool update(CustomerChangeBillDTO data)
        {
            string sql = $@"UPDATE phieudoibanhang SET ngayLap=@ngayLap, liDo=@liDo, tinhTrangSanPham=@tinhTrangSanPham, 
                            maKhachHang=@maKhachHang, maSachCanDoi=@maSachCanDoi, maSachMuonDoi=@maSachMuonDoi
                            maNhanVien=@maNhanVien WHERE maPhieuDoiBanHang=@maPhieuDoiBanHang;";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@ngayLap", data.NgayLap),
                    new MySqlParameter("@liDo", data.LiDo),
                    new MySqlParameter("@tinhTrangSanPham", data.TinhTrangSanPham),
                    new MySqlParameter("@maKhachHang", data.MaKhachHang),
                    new MySqlParameter("@maSachCanDoi", data.SachCanDoi),
                    new MySqlParameter("@maSachMuonDoi", data.SachMuonDoi),
                    new MySqlParameter("@maPhieuDoiBanHang", data.MaPhieu),
                });

            return rowChanged > 0;
        }

        public bool delete(string id)
        {
            string sql = $@"DELETE FROM `phieudoibanhang` WHERE maPhieuDoiBanHang=@maPhieuDoiBanHang;";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maPhieuDoiBanHang", id),
                });

            return rowChanged > 0;
        }

        public CustomerChangeBillDTO getById(string id)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(
                "SELECT * FROM phieudoibanhang WHERE maPhieuDoiBanHang=@maPhieuDoiBanHang;",
                new MySqlParameter[] {
                    new MySqlParameter("@maPhieuDoiBanHang", id),
                }
            );

            if (dataTable.Rows.Count <= 0) return null;

            CustomerChangeBillDTO customerBill = new CustomerChangeBillDTO(dataTable.Rows[0]);

            return customerBill;
        }
    }
}
