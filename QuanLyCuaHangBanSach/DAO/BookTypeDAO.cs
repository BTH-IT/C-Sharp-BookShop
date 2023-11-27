using System.Data;
using MySql.Data.MySqlClient;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.DAO
{
    public class BookTypeDAO : IDAO<BookTypeDTO>
    {
        private static BookTypeDAO instance;

        public static BookTypeDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BookTypeDAO();
                }

                return BookTypeDAO.instance;
            }
            private set { BookTypeDAO.instance = value; }
        }

        
        public DataTable getAll() {
            return DataProvider.Instance.ExecuteQuery("select * from theloai;");
        }

        public bool checkDuplicateName(string value)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("select * from theloai WHERE  LOWER(tenTheLoai)=LOWER(@tenTheLoai);",
                new MySqlParameter[] {
                    new MySqlParameter("@tenTheLoai", value.Trim().ToLower())
                }
            );

            if (dataTable.Rows.Count <= 0) return false;

            return true;
        }

        public bool checkDuplicateName(string value, int id)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("select * from theloai WHERE  LOWER(tenTheLoai)=LOWER(@tenTheLoai) and maTheLoai!=@id;",
                new MySqlParameter[] {
                    new MySqlParameter("@tenTheLoai", value.Trim().ToLower()),
                    new MySqlParameter("@id", id)
                }
            );

            if (dataTable.Rows.Count <= 0) return false;

            return true;
        }

        public BookTypeDTO getById(string id)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(
                "SELECT * FROM theloai WHERE maTheLoai=@maTheLoai;",
                new MySqlParameter[] {
                    new MySqlParameter("@maTheLoai", id)
                }
            );

            if (dataTable.Rows.Count <= 0) return null;

            BookTypeDTO account = new BookTypeDTO(dataTable.Rows[0]);

            return account;
        }
        
        public DataTable searchData(string value)
        {
            string sql = $@"SELECT * FROM theloai WHERE (maTheLoai LIKE @maTheLoai OR tenTheLoai LIKE @tenTheLoai);";

            return DataProvider.Instance.ExecuteQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maTheLoai", "%" + value + "%"),
                    new MySqlParameter("@tenTheLoai", "%" + value + "%")
                }
            );
        }

        public bool insert(BookTypeDTO data)
        {

            string sql = $@"INSERT INTO theloai (tenTheLoai)
                            VALUES (@tenTheLoai);";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@tenTheLoai", data.TenTheLoai),
                });

            return rowChanged > 0;
        }

        public bool update(BookTypeDTO data)
        {
            string sql = $@"UPDATE theloai SET tenTheLoai=@tenTheLoai WHERE maTheLoai=@maTheLoai;";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maTheLoai", data.MaTheLoai),
                    new MySqlParameter("@tenTheLoai", data.TenTheLoai),
                });

            return rowChanged > 0;
        }

        public bool delete(string id)
        {
            string sql = $@"UPDATE theloai SET hienThi = 0 WHERE maTheLoai=@maTheLoai;";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maTheLoai", id),
                });

            return rowChanged > 0;
        }
    }
}
