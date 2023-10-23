using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Markup;
using MySql.Data.MySqlClient;
using QuanLyCuaHangBanSach.BUS;
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
            return DataProvider.Instance.ExecuteQuery("select * from quyenhan;");
        }

        public PermissionDTO getById(string id)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(
                "SELECT * FROM quyenhan WHERE maQuyenHan=@maQuyenHan;",
                new MySqlParameter[] {
                    new MySqlParameter("@maQuyenHan", id)
                }
            );

            if (dataTable.Rows.Count <= 0) return null;

            PermissionDTO account = new PermissionDTO(dataTable.Rows[0]);

            return account;
        }
        
        public DataTable searchData(string value)
        {
            string sql = $@"SELECT * FROM quyenhan 
                            WHERE (maQuyenHan LIKE @maQuyenHan OR tenQuyenHan LIKE @tenQuyenHan);";

            return DataProvider.Instance.ExecuteQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maQuyenHan", "%" + value + "%"),
                    new MySqlParameter("@tenQuyenHan", "%" + value + "%")
                }
            );
        }

        public bool insert(PermissionDTO data)
        {

            string sql = $@"INSERT INTO quyenhan (tenQuyenHan, trangThai)
                            VALUES (@tenQuyenHan, @trangThai);";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@tenQuyenHan", data.TenQuyenHan),
                    new MySqlParameter("@trangThai", data.TrangThai),
                });

            if (rowChanged > 0)
            {
                List<PositionDTO> positionList = PositionBUS.Instance.getAllData();

                sql = $@"INSERT INTO chitietphanquyen (maChucVu, maQuyenHan)
                            VALUES (@maChucVu, @maQuyenHan);";

                foreach (PositionDTO position in positionList)
                {
                    DataProvider.Instance.ExecuteNonQuery(sql,
                    new MySqlParameter[] {
                        new MySqlParameter("@maChucVu", position.MaChucVu),
                        new MySqlParameter("@maQuyenHan", data.MaQuyenHan),
                    });
                }
            }

            return rowChanged > 0;
        }

        public bool update(PermissionDTO data)
        {
            string sql = $@"UPDATE quyenhan
                            SET tenQuyenHan=@tenQuyenHan, trangThai=@trangThai
                            WHERE maQuyenHan=@maQuyenHan;";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maQuyenHan", data.MaQuyenHan),
                    new MySqlParameter("@tenQuyenHan", data.TenQuyenHan),
                    new MySqlParameter("@trangThai", data.TrangThai)
                });

            return rowChanged > 0;
        }

        public bool delete(string id)
        {
            string sql = $@"DELETE FROM quyenhan WHERE maQuyenHan=@maQuyenHan;";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maQuyenHan", id),
                });

            /*if (rowChanged > 0)
            {
                List<PositionDTO> positionList = PositionBUS.Instance.getAllData();

                sql = $@"UPDATE chitietphanquyen SET hienThi = 0 WHERE maChucVu=@maChucVu AND maQuyenHan=@maQuyenHan;";

                foreach (PositionDTO position in positionList)
                {
                    DataProvider.Instance.ExecuteNonQuery(sql,
                    new MySqlParameter[] {
                        new MySqlParameter("@maChucVu", position.MaChucVu),
                        new MySqlParameter("@maQuyenHan", id),
                    });
                }
            }*/

            return rowChanged > 0;
        }
    }
}
