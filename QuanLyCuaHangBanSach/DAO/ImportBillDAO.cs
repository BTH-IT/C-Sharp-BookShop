using System;
using System.Data;
using System.Windows.Documents;
using MySql.Data.MySqlClient;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.DAO
{
    public class ImportBillDAO : IDAO<ImportBillDTO>
    {
        private static ImportBillDAO instance;

        public static ImportBillDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ImportBillDAO();
                }

                return ImportBillDAO.instance;
            }
            private set { ImportBillDAO.instance = value; }
        }

        
        public DataTable getAll() {
            return DataProvider.Instance.ExecuteQuery("select * from phieunhap WHERE hienThi = 1;");
        }

        public ImportBillDTO getById(string id)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(
                "SELECT * FROM phieunhap WHERE maDonNhapHang=@maDonNhapHang AND hienThi = 1;",
                new MySqlParameter[] {
                    new MySqlParameter("@maDonNhapHang", id)
                }
            );

            if (dataTable.Rows.Count <= 0) return null;

            ImportBillDTO account = new ImportBillDTO(dataTable.Rows[0]);

            return account;
        }
        
        public DataTable searchData(string value)
        {
            string sql = $@"SELECT * FROM phieunhap WHERE maDonNhapHang LIKE @maDonNhapHang AND hienThi = 1;";

            return DataProvider.Instance.ExecuteQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maDonNhapHang", "%" + value + "%"),
                }
            );
        }

        public bool insert(ImportBillDTO data)
        {

            string sql = $@"INSERT INTO phieunhap (maNhanVien, maNhaCungCap, ngayLap, tongTien)
                            VALUES (@maNhanVien, @maNhaCungCap, @ngayLap, @tongTien);";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maNhaCungCap", data.MaNhaCungCap),
                    new MySqlParameter("@maNhanVien", data.MaNhanVien),
                    new MySqlParameter("@ngayLap", data.NgayLap),
                    new MySqlParameter("@tongTien", data.TongTien),
                });

            return rowChanged > 0;
        }

        public bool update(ImportBillDTO data)
        {
            string sql = $@"UPDATE phieunhap SET 
                            maNhaCungCap=@maNhaCungCap, maNhanVien=@maNhanVien, ngayLap=@ngayLap, 
                            tongTien=@tongTien WHERE maDonNhapHang=@maDonNhapHang;";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maNhaCungCap", data.MaNhaCungCap),
                    new MySqlParameter("@maNhanVien", data.MaNhanVien),
                    new MySqlParameter("@ngayLap", data.NgayLap),
                    new MySqlParameter("@tongTien", data.TongTien),
                    new MySqlParameter("@maDonNhapHang", data.MaDonNhapHang),
                });

            return rowChanged > 0;
        }

        public bool delete(string id)
        {
            string sql = $@"UPDATE phieunhap SET hienThi = 0 WHERE maDonNhapHang=@maDonNhapHang;";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maDonNhapHang", id),
                });

            return rowChanged > 0;
        }
    }
}
