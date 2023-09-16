using System;
using System.Data;
using MySql.Data.MySqlClient;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.DAO
{
    public class PermissionDAO : IDAO<PermissionDTO>
    {
        private static PermissionDAO instance;

        public static PermissionDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PermissionDAO();
                }

                return PermissionDAO.instance;
            }
            private set { PermissionDAO.instance = value; }
        }

        
        public DataTable getAll() {
            return DataProvider.Instance.ExecuteQuery("select * from quyenhang WHERE hienThi=1;");
        }

        public PermissionDTO getById(string id)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(
                "SELECT * FROM quyenhang WHERE maQuyenHang=@maQuyenHang AND hienThi=1;",
                new MySqlParameter[] {
                    new MySqlParameter("@maQuyenHang", id)
                }
            );

            if (dataTable.Rows.Count <= 0) return null;

            PermissionDTO account = new PermissionDTO(dataTable.Rows[0]);

            return account;
        }
        
        public DataTable searchData(string value)
        {
            string sql = $@"SELECT * FROM quyenhang 
                            WHERE (maQuyenHang LIKE @maQuyenHang OR tenQuyenHang LIKE @tenQuyenHang)
                            AND hienThi=1;";

            return DataProvider.Instance.ExecuteQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maQuyenHang", "%" + value + "%"),
                    new MySqlParameter("@tenQuyenHang", "%" + value + "%")
                }
            );
        }

        public bool insert(PermissionDTO data)
        {

            string sql = $@"INSERT INTO quyenhang (tenQuyenHang, trangThai)
                            VALUES (@tenQuyenHang, @trangThai);";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@tenQuyenHang", data.TenQuyenHang),
                    new MySqlParameter("@trangThai", data.TrangThai),
                });

            return rowChanged > 0;
        }

        public bool update(PermissionDTO data)
        {
            string sql = $@"UPDATE quyenhang
                            SET tenQuyenHang=@tenQuyenHang, trangThai=@trangThai
                            WHERE maQuyenHang=@maQuyenHang;";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maQuyenHang", data.MaQuyenHang),
                    new MySqlParameter("@tenQuyenHang", data.TenQuyenHang),
                    new MySqlParameter("@trangThai", data.TrangThai)
                });

            return rowChanged > 0;
        }

        public bool delete(string id)
        {
            string sql = $@"UPDATE quyenhang SET hienThi = 0 WHERE maQuyenHang=@maQuyenHang;";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maQuyenHang", id),
                });

            return rowChanged > 0;
        }
    }
}
