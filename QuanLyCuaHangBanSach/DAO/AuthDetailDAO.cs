using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.DAO
{
    public class AuthDetailDAO
    {
        private static AuthDetailDAO instance;

        public static AuthDetailDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AuthDetailDAO();
                }

                return AuthDetailDAO.instance;
            }
            private set { AuthDetailDAO.instance = value; }
        }


        public DataTable getAll()
        {
            return DataProvider.Instance.ExecuteQuery("select * from chitietphanquyen");
        }

        public AuthDetailDTO getById(string positionId, string permissionId)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(
                "SELECT * FROM chitietphanquyen WHERE maChucVu=@maChucVu AND maQuyenHang=@maQuyenHang;",
                new MySqlParameter[] { 
                    new MySqlParameter("@maChucVu", positionId),
                    new MySqlParameter("@maQuyenHang", permissionId),
                }
            );

            if (dataTable.Rows.Count <= 0) return null;

            AuthDetailDTO authDetail = new AuthDetailDTO(dataTable.Rows[0]);

            return authDetail;
        }

        public List<AuthDetailDTO> getByPositionId(string positionId)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(
                "SELECT * FROM chitietphanquyen WHERE maChucVu=@maChucVu;",
                new MySqlParameter[] {
                    new MySqlParameter("@maChucVu", positionId),
                }
            );

            if (dataTable.Rows.Count <= 0) return null;

            List<AuthDetailDTO> authDetailDTOs = new List<AuthDetailDTO>();

            foreach (DataRow row in dataTable.Rows)
            {
                AuthDetailDTO authDetail = new AuthDetailDTO(row);
                authDetailDTOs.Add(authDetail);
            }

            return authDetailDTOs;
        }

        public bool insert(AuthDetailDTO data)
        {

            string sql = $@"INSERT INTO chitietphanquyen (maChucVu, maQuyenHang)
                            VALUES (@maChucVu, @maQuyenHang);";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maChucVu", data.MaChucVu),
                    new MySqlParameter("@maQuyenHang", data.MaQuyenHang),
                });

            return rowChanged > 0;
        }

        public bool update(AuthDetailDTO data)
        {
            string sql = $@"UPDATE chitietphanquyen SET trangThai=@trangThai 
                            WHERE maChucVu=@maChucVu AND maQuyenHang=@maQuyenHang;";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@trangThai", data.TrangThai),
                    new MySqlParameter("@maChucVu", data.MaChucVu),
                    new MySqlParameter("@maQuyenHang", data.MaQuyenHang),
                });

            return rowChanged > 0;
        }

        public bool delete(string positionId, string permissionId)
        {
            string sql = $@"DELETE FROM chitietphanquyen
                            WHERE maChucVu=@maChucVu AND maQuyenHang=@maQuyenHang;";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
            new MySqlParameter[] {
                    new MySqlParameter("@maChucVu", positionId),
                    new MySqlParameter("@maQuyenHang", permissionId),
                });

            return rowChanged > 0;
        }

        public bool deleteAllByPositionId(string positionId)
        {
            string sql = $@"DELETE FROM chitietphanquyen
                            WHERE maChucVu=@maChucVu;";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maChucVu", positionId),
                });

            return rowChanged > 0;
        }
    }
}
