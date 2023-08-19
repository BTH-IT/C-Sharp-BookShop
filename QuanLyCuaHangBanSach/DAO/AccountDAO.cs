using System.Data;
using MySql.Data.MySqlClient;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.DAO
{
    public class AccountDAO : IDAO<AccountDTO>
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AccountDAO();
                }

                return AccountDAO.instance;
            }
            private set { AccountDAO.instance = value; }
        }

        
        public DataTable getAll() {
            return DataProvider.Instance.ExecuteQuery("select * from taikhoan");
        }

        public AccountDTO getById(string id)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(
                "SELECT * FROM taikhoan WHERE email=@Email",
                new MySqlParameter[] { new MySqlParameter("@Email", id) }
            );

            if (dataTable.Rows.Count <= 0) return null;

            AccountDTO account = new AccountDTO(dataTable.Rows[0]);

            return account;
        }

        public bool insert(AccountDTO data)
        {

            string sql = $@"INSERT INTO taikhoan (maNhanVien, email, matKhau, hienThi)
                            VALUES (@MaNhanVien, @Email, @MatKhau, 1);";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@MaNhanVien", data.MaNhanVien),
                    new MySqlParameter("@Email", data.Email),
                    new MySqlParameter("@MatKhau", data.MatKhau),
                });

            return rowChanged > 0;
        }

        public bool update(AccountDTO data)
        {
            string sql = $@"UPDATE taikhoan SET maNhanVien=@MaNhanVien, matKhau=@MatKhau WHERE email=@Email;";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@MaNhanVien", data.MaNhanVien),
                    new MySqlParameter("@MatKhau", data.MatKhau),
                    new MySqlParameter("@Email", data.Email),
                });

            return rowChanged > 0;
        }

        public bool delete(AccountDTO data)
        {
            string sql = $@"UPDATE taikhoan SET hienThi = 0 WHERE email=@Email;";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@Email", data.Email),
                });

            return rowChanged > 0;
        }
    }
}
