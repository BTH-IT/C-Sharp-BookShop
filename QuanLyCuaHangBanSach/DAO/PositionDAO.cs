using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.DAO
{
    public class PositionDAO : IDAO<PositionDTO>
    {
        private static PositionDAO instance;

        public static PositionDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PositionDAO();
                }

                return PositionDAO.instance;
            }
            private set { PositionDAO.instance = value; }
        }


        public DataTable getAll()
        {
            return DataProvider.Instance.ExecuteQuery("select * from chucvu;");
        }

        public bool checkDuplicateName(string value)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("select * from chucvu WHERE  LOWER(tenChucVu)= LOWER(@tenChucVu);",
                new MySqlParameter[] {
                    new MySqlParameter("@tenChucVu", value.Trim().ToLower())
                }
            );

            if (dataTable.Rows.Count <= 0) return false;

            return true;
        }

        public PositionDTO getById(string id)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(
                "SELECT * FROM chucvu WHERE maChucVu=@maChucVu;",
                new MySqlParameter[] {
                    new MySqlParameter("@maChucVu", id)
                }
            );

            if (dataTable.Rows.Count <= 0) return null;

            PositionDTO account = new PositionDTO(dataTable.Rows[0]);

            return account;
        }
        public DataTable searchData(string value)
        {
            string sql = $@"SELECT * FROM chucvu WHERE (maChucVu LIKE @maChucVu OR tenChucVu LIKE @tenChucVu);";

            return DataProvider.Instance.ExecuteQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maChucVu", "%" + value + "%"),
                    new MySqlParameter("@tenChucVu", "%" + value + "%")
                }
            );
        }

        public bool insert(PositionDTO data)
        {

            string sql = $@"INSERT INTO chucvu (tenChucVu, moTa, trangThai)
                            VALUES (@tenChucVu, @moTa, @trangThai);";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@tenChucVu", data.TenChucVu),
                    new MySqlParameter("@moTa", data.MoTa),
                    new MySqlParameter("@trangThai", data.TrangThai),
                });

            if (rowChanged > 0 )
            {
                
            }

            return rowChanged > 0;
        }

        public bool advanceInsert(PositionDTO data)
        {
            string sql = "SELECT * FROM chucvu ORDER BY maChucVu DESC LIMIT 1;";
            if (this.insert(data))
            {

                DataTable dataTable = DataProvider.Instance.ExecuteQuery(sql);

                if (dataTable.Rows.Count <= 0) return false;

                PositionDTO position = new PositionDTO(dataTable.Rows[0]);

                if (position != null)
                {
                    List<PermissionDTO> permissionList = PermissionBUS.Instance.getAllData();
                    
                    sql = $@"INSERT INTO chitietphanquyen (maChucVu, maQuyenHan)
                            VALUES (@maChucVu, @maQuyenHan);";

                    foreach (PermissionDTO permission in permissionList)
                    {
                        DataProvider.Instance.ExecuteNonQuery(sql,
                                new MySqlParameter[] {
                                new MySqlParameter("@maChucVu", position.MaChucVu),
                                new MySqlParameter("@maQuyenHan", permission.MaQuyenHan),
                            });
                    }
                }

                return position != null;
            };

            return false;
        }

        public bool update(PositionDTO data)
        {
            string sql = $@"UPDATE chucvu
                            SET tenChucVu=@tenChucVu, moTa=@moTa, trangThai=@trangThai
                            WHERE maChucVu=@maChucVu;";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maChucVu", data.MaChucVu),
                    new MySqlParameter("@tenChucVu", data.TenChucVu),
                    new MySqlParameter("@moTa", data.MoTa),
                    new MySqlParameter("@trangThai", data.TrangThai),
                });

            return rowChanged > 0;
        }

        public bool delete(string id)
        {
            string sql = $@"DELETE FROM chucvu WHERE maChucVu=@maChucVu;";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maChucVu", id),
                });

            if (rowChanged > 0 )
            {
                AuthDetailBUS.Instance.deleteAllByPositionId(id);
            }

            return rowChanged > 0;
        }
    }
}
