using System;
using System.Data;
using System.Windows.Documents;
using MySql.Data.MySqlClient;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.DAO
{
    public class PublisherDAO : IDAO<PublisherDTO>
    {
        private static PublisherDAO instance;

        public static PublisherDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PublisherDAO();
                }

                return PublisherDAO.instance;
            }
            private set { PublisherDAO.instance = value; }
        }

        
        public DataTable getAll() {
            return DataProvider.Instance.ExecuteQuery("select * from nhaxuatban");
        }

        public PublisherDTO getById(string id)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(
                "SELECT * FROM nhaxuatban WHERE maNhaXuatBan=@maNhaXuatBan;",
                new MySqlParameter[] {
                    new MySqlParameter("@maNhaXuatBan", id)
                }
            );

            if (dataTable.Rows.Count <= 0) return null;

            PublisherDTO account = new PublisherDTO(dataTable.Rows[0]);

            return account;
        }
        
        public DataTable searchData(string value)
        {
            string sql = $@"SELECT * FROM nhaxuatban WHERE maNhaXuatBan LIKE @maNhaXuatBan OR tenNhaXuatBan LIKE @tenNhaXuatBan;";

            return DataProvider.Instance.ExecuteQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maNhaXuatBan", "%" + value + "%"),
                    new MySqlParameter("@tenNhaXuatBan", "%" + value + "%")
                }
            );
        }

        public bool insert(PublisherDTO data)
        {

            string sql = $@"INSERT INTO nhaxuatban (tenNhaXuatBan, diaChi, soDienThoai)
                            VALUES (@tenNhaXuatBan, @diaChi, @soDienThoai);";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@tenNhaXuatBan", data.TenNhaXuatBan),
                    new MySqlParameter("@diaChi", data.DiaChi),
                    new MySqlParameter("@soDienThoai", data.SoDienThoai),
                });

            return rowChanged > 0;
        }

        public bool update(PublisherDTO data)
        {
            string sql = $@"UPDATE nhaxuatban
                            SET tenNhaXuatBan=@tenNhaXuatBan, diaChi=@diaChi, soDienThoai=@soDienThoai
                            WHERE maNhaXuatBan=@maNhaXuatBan;";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maNhaXuatBan", data.MaNhaXuatBan),
                    new MySqlParameter("@tenNhaXuatBan", data.TenNhaXuatBan),
                    new MySqlParameter("@diaChi", data.DiaChi),
                    new MySqlParameter("@soDienThoai", data.SoDienThoai),
                });

            return rowChanged > 0;
        }

        public bool delete(string id)
        {
            string sql = $@"UPDATE nhaxuatban SET hienThi = 0 WHERE maNhaXuatBan=@maNhaXuatBan;";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maNhaXuatBan", id),
                });

            return rowChanged > 0;
        }
    }
}
