using System;
using System.Data;
using System.Windows.Documents;
using MySql.Data.MySqlClient;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.DAO
{
    public class BookDAO : IDAO<BookDTO>
    {
        private static BookDAO instance;

        public static BookDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BookDAO();
                }

                return BookDAO.instance;
            }
            private set { BookDAO.instance = value; }
        }

        
        public DataTable getAll() {
            return DataProvider.Instance.ExecuteQuery("select * from sach");
        }

        public BookDTO getById(string id)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(
                "SELECT * FROM sach WHERE maSach=@MaSach;",
                new MySqlParameter[] {
                    new MySqlParameter("@MaSach", id)
                }
            );

            if (dataTable.Rows.Count <= 0) return null;

            BookDTO account = new BookDTO(dataTable.Rows[0]);

            return account;
        }
        
        public DataTable searchData(string value)
        {
            string sql = $@"SELECT * FROM sach WHERE maSach LIKE @maSach OR tenSach LIKE @tenSach;";

            return DataProvider.Instance.ExecuteQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maSach", "%" + value + "%"),
                    new MySqlParameter("@tenSach", "%" + value + "%")
                }
            );
        }

        public bool insert(BookDTO data)
        {

            string sql = $@"INSERT INTO sach (tenSach, maTheLoai, maTacGia, maNhaXuatBan, soLuongConLai, giaBan, giaNhap, namXuatBan)
                            VALUES (@tenSach, @maTheLoai, @maTacGia, @maNhaXuatBan, @soLuongConLai, @giaBan, @giaNhap, @namXuatBan);";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@tenSach", data.TenSach),
                    new MySqlParameter("@maTheLoai", data.MaTheLoai),
                    new MySqlParameter("@maTacGia", data.MaTacGia),
                    new MySqlParameter("@maNhaXuatBan", data.MaNhaXuatBan),
                    new MySqlParameter("@soLuongConLai", data.SoLuongConLai),
                    new MySqlParameter("@giaBan", data.GiaBan),
                    new MySqlParameter("@giaNhap", data.GiaNhap),
                    new MySqlParameter("@namXuatBan", data.NamXuatBan),
                });

            return rowChanged > 0;
        }

        public bool update(BookDTO data)
        {
            string sql = $@"UPDATE taikhoan
                            SET tenSach=@tenSach, maTheLoai=@maTheLoai, maTacGia=@maTacGia, maNhaXuatBan=@maNhaXuatBan, soLuongConLai=@soLuongConLai, giaBan=@giaBan, giaNhap=@giaNhap, namXuatBan=@namXuatBan
                            WHERE maSach=@maSach;";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maSach", data.MaSach),
                    new MySqlParameter("@tenSach", data.TenSach),
                    new MySqlParameter("@maTheLoai", data.MaTheLoai),
                    new MySqlParameter("@maTacGia", data.MaTacGia),
                    new MySqlParameter("@maNhaXuatBan", data.MaNhaXuatBan),
                    new MySqlParameter("@soLuongConLai", data.SoLuongConLai),
                    new MySqlParameter("@giaBan", data.GiaBan),
                    new MySqlParameter("@giaNhap", data.GiaNhap),
                    new MySqlParameter("@namXuatBan", data.NamXuatBan),
                });

            return rowChanged > 0;
        }

        public bool delete(string id)
        {
            string sql = $@"UPDATE sach SET hienThi = 0 WHERE maSach=@maSach;";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maSach", id),
                });

            return rowChanged > 0;
        }
    }
}
