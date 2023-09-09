using System;
using System.Data;
using System.Windows.Documents;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using QuanLyCuaHangBanSach.DTO;
using QuanLyCuaHangBanSach.GUI.UserControls;

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
            return DataProvider.Instance.ExecuteQuery("select * from sach WHERE hienThi = 1;");
        }

        public BookDTO getById(string id)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(
                "SELECT * FROM sach WHERE maSach=@MaSach AND hienThi = 1;",
                new MySqlParameter[] {
                    new MySqlParameter("@MaSach", id)
                }
            );

            if (dataTable.Rows.Count <= 0) return null;

            BookDTO account = new BookDTO(dataTable.Rows[0]);

            return account;
        }

        public DataTable getAllDataFiltered(int SortMode, int Type, int Author, int Publisher)
        {
            string sql = $@"SELECT * FROM sach WHERE hienThi = 1";
            if (Type != -1)
            {
                sql += " AND maTheLoai=@maTheLoai";
            }
            if (Author != -1)
            {
                sql += " AND maTacGia=@maTacGia";
            }
            if (Publisher != -1)
            {
                sql += " AND maNhaXuatBan=@maNhaXuatBan";
            }
            switch (SortMode)
            {
                case -1:
                    sql += ";";
                    break;
                case 0:
                    sql += " ORDER BY giaBan ASC;";
                    break;
                case 1:
                    sql += " ORDER BY giaBan DESC;";
                    break;
                case 2:
                    sql += " ORDER BY tenSach DESC;";
                    break;
                case 3:
                    sql += " ORDER BY tenSach DESC;";
                    break;
                default:
                    sql += ";";
                    break;
            }

            return DataProvider.Instance.ExecuteQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maTheLoai", Type.ToString()),
                    new MySqlParameter("@maTacGia", Author.ToString()),
                    new MySqlParameter("@maNhaXuatBan", Publisher.ToString())
                }
            );
        }

        public DataTable searchData(string value)
        {
            string sql = $@"SELECT * FROM sach WHERE (maSach LIKE @maSach OR tenSach LIKE @tenSach) AND hienThi = 1;";

            return DataProvider.Instance.ExecuteQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maSach", "%" + value + "%"),
                    new MySqlParameter("@tenSach", "%" + value + "%")
                }
            );
        }

        public bool insert(BookDTO data)
        {

            string sql = $@"INSERT INTO sach (tenSach, hinhAnh, maTheLoai, maTacGia, maNhaXuatBan, soLuongConLai, giaBan, giaNhap, namXuatBan)
                            VALUES (@tenSach, @hinhAnh, @maTheLoai, @maTacGia, @maNhaXuatBan, @soLuongConLai, @giaBan, @giaNhap, @namXuatBan);";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@tenSach", data.TenSach),
                    new MySqlParameter("@hinhAnh", data.HinhAnh),
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
            string sql = $@"UPDATE sach
                            SET tenSach=@tenSach, hinhAnh=@hinhAnh, maTheLoai=@maTheLoai, maTacGia=@maTacGia, maNhaXuatBan=@maNhaXuatBan, soLuongConLai=@soLuongConLai, giaBan=@giaBan, giaNhap=@giaNhap, namXuatBan=@namXuatBan
                            WHERE maSach=@maSach;";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maSach", data.MaSach),
                    new MySqlParameter("@tenSach", data.TenSach),
                    new MySqlParameter("@hinhAnh", data.HinhAnh),
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
