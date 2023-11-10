using System;
using System.Data;
using System.Windows.Documents;
using MySql.Data.MySqlClient;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.DAO
{
    public class AuthorDAO : IDAO<AuthorDTO>
    {
        private static AuthorDAO instance;

        public static AuthorDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AuthorDAO();
                }

                return AuthorDAO.instance;
            }
            private set { AuthorDAO.instance = value; }
        }

        
        public DataTable getAll() {
            return DataProvider.Instance.ExecuteQuery("select * from tacgia;");
        }

        public bool checkDuplicateName(string value)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("select * from tacgia WHERE  LOWER(tenTacGia)=LOWER(@tenTacGia);",
                new MySqlParameter[] {
                    new MySqlParameter("@tenTacGia", value.Trim().ToLower())
                }
            );

            if (dataTable.Rows.Count <= 0) return false;

            return true;
        }

        public bool checkDuplicateName(string value, int id)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("select * from tacgia WHERE  LOWER(tenTacGia)=LOWER(@tenTacGia) and maTacGia!=@id;",
                new MySqlParameter[] {
                    new MySqlParameter("@tenTacGia", value.Trim().ToLower()),
                    new MySqlParameter("@maTacGia", id)
                }
            );

            if (dataTable.Rows.Count <= 0) return false;

            return true;
        }

        public AuthorDTO getById(string id)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(
                "SELECT * FROM tacgia WHERE maTacGia=@maTacGia;",
                new MySqlParameter[] {
                    new MySqlParameter("@maTacGia", id)
                }
            );

            if (dataTable.Rows.Count <= 0) return null;

            AuthorDTO account = new AuthorDTO(dataTable.Rows[0]);

            return account;
        }

        public DataTable searchData(string value)
        {
            string sql = $@"SELECT * FROM tacgia WHERE (maTacGia LIKE @maTacGia OR tenTacGia LIKE @tenTacGia);";
            

            return DataProvider.Instance.ExecuteQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maTacGia", "%" + value + "%"),
                    new MySqlParameter("@tenTacGia", "%" + value + "%")
                }
            );
        }

        public bool insert(AuthorDTO data)
        {

            string sql = $@"INSERT INTO tacgia (tenTacGia, gioiTinh, namSinh)
                            VALUES (@tenTacGia, @gioiTinh, @namSinh);";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@tenTacGia", data.Ten),
                    new MySqlParameter("@gioiTinh", data.GioiTinh),
                    new MySqlParameter("@namSinh", data.NamSinh),
                });

            return rowChanged > 0;
        }

        public bool update(AuthorDTO data)
        {
            string sql = $@"UPDATE tacgia
                            SET tenTacGia=@tenTacGia, gioiTinh=@gioiTinh, namSinh=@namSinh
                            WHERE maTacGia=@maTacGia;";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maTacGia", data.Ma),
                    new MySqlParameter("@tenTacGia", data.Ten),
                    new MySqlParameter("@gioiTinh", data.GioiTinh),
                    new MySqlParameter("@namSinh", data.NamSinh),
                });

            return rowChanged > 0;
        }

        public bool delete(string id)
        {
            string sql = $@"DELETE FROM tacgia WHERE maTacGia=@maTacGia;";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maTacGia", id),
                });

            return rowChanged > 0;
        }
    }
}
