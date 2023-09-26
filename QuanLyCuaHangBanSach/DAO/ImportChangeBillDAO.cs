using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.DAO
{
    public class ImportChangeBillDAO : IDAO<ImportChangeBillDTO>
    {
        private static ImportChangeBillDAO instance;

        public static ImportChangeBillDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ImportChangeBillDAO();
                }

                return ImportChangeBillDAO.instance;
            }
            private set { ImportChangeBillDAO.instance = value; }
        }

        public DataTable getAll()
        {
            return DataProvider.Instance.ExecuteQuery("select * from phieudoinhaphang;");
        }

        public DataTable searchData(string value)
        {
            string sql = $@"SELECT * FROM phieudoinhaphang WHERE maPhieuDoiNhapHang LIKE @maPhieuDoiNhapHang;";

            return DataProvider.Instance.ExecuteQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maPhieuDoiNhapHang", "%" + value + "%"),
                }
            );
        }

        public bool insert(ImportChangeBillDTO data)
        {

            string sql = $@"INSERT INTO phieudoinhaphang (ngayLap, liDo, tinhTrangSanPham, maNhaCungCap, maSachCanDoi, maSachMuonDoi, maNhanVien)
                            VALUES (@ngayLap, @liDo, @tinhTrangSanPham, @maNhaCungCap, @maSachCanDoi, @maSachMuonDoi, @maNhanVien);";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@ngayLap", data.NgayLap),
                    new MySqlParameter("@liDo", data.LiDo),
                    new MySqlParameter("@tinhTrangSanPham", data.TinhTrangSanPham),
                    new MySqlParameter("@maNhaCungCap", data.MaNhaCungCap),
                    new MySqlParameter("@maSachCanDoi", data.SachCanDoi),
                    new MySqlParameter("@maSachMuonDoi", data.SachMuonDoi),
                    new MySqlParameter("@maNhanVien", data.MaNhanVien),
                });

            return rowChanged > 0;
        }

        public ImportChangeBillDTO insertReturnBill(ImportChangeBillDTO data)
        {
            string sql = "SELECT * FROM phieudoinhaphang ORDER BY maPhieuDoiNhapHang DESC LIMIT 1;";
            if (this.insert(data))
            {

                DataTable dataTable = DataProvider.Instance.ExecuteQuery(sql);

                if (dataTable.Rows.Count <= 0) return null;

                ImportChangeBillDTO customerBill = new ImportChangeBillDTO(dataTable.Rows[0]);

                return customerBill;
            };

            return null;
        }

        public bool update(ImportChangeBillDTO data)
        {
            string sql = $@"UPDATE phieudoinhaphang SET ngayLap=@ngayLap, liDo=@liDo, tinhTrangSanPham=@tinhTrangSanPham, 
                            maNhaCungCap=@maNhaCungCap, maSachCanDoi=@maSachCanDoi, maSachMuonDoi=@maSachMuonDoi
                            maNhanVien=@maNhanVien WHERE maPhieuDoiNhapHang=@maPhieuDoiNhapHang;";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@ngayLap", data.NgayLap),
                    new MySqlParameter("@liDo", data.LiDo),
                    new MySqlParameter("@tinhTrangSanPham", data.TinhTrangSanPham),
                    new MySqlParameter("@maNhaCungCap", data.MaNhaCungCap),
                    new MySqlParameter("@maSachCanDoi", data.SachCanDoi),
                    new MySqlParameter("@maSachMuonDoi", data.SachMuonDoi),
                    new MySqlParameter("@maPhieuDoiNhapHang", data.MaPhieu),
                });

            return rowChanged > 0;
        }

        public bool delete(string id)
        {
            string sql = $@"UPDATE phieudoinhaphang SET hienThi=0 WHERE maPhieuDoiNhapHang=@maPhieuDoiNhapHang;";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maPhieuDoiNhapHang", id),
                });

            return rowChanged > 0;
        }

        public ImportChangeBillDTO getById(string id)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(
                "SELECT * FROM phieudoinhaphang WHERE maPhieuDoiNhapHang=@maPhieuDoiNhapHang;",
                new MySqlParameter[] {
                    new MySqlParameter("@maPhieuDoiNhapHang", id),
                }
            );

            if (dataTable.Rows.Count <= 0) return null;

            ImportChangeBillDTO customerBill = new ImportChangeBillDTO(dataTable.Rows[0]);

            return customerBill;
        }
    }
}