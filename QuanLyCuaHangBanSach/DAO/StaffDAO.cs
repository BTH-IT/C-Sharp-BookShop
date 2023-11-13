using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.DAO
{
    public class StaffDAO : IDAO<StaffDTO>
    {
        private static StaffDAO instance;

        public static StaffDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new StaffDAO();
                }

                return StaffDAO.instance;
            }
            private set { StaffDAO.instance = value; }
        }

        
        public DataTable getAll() {
            return DataProvider.Instance.ExecuteQuery("select * from nhanvien WHERE hienThi = 1;");
        }

        public DataTable getAllNoAccount()
        {
            return DataProvider.Instance.ExecuteQuery("select * from nhanvien LEFT JOIN taikhoan ON nhanvien.maNhanVien=taikhoan.maNhanVien WHERE taikhoan.maNhanVien IS NULL AND nhanvien.hienThi = 1;");
        }

        public DataTable getAllNoAccountNotId(int id)
        {
            return DataProvider.Instance.ExecuteQuery("select * from nhanvien LEFT JOIN taikhoan ON nhanvien.maNhanVien=taikhoan.maNhanVien WHERE (taikhoan.maNhanVien IS NULL OR taikhoan.maNhanVien=@id) AND nhanvien.hienThi = 1;",
            new MySqlParameter[] {
                    new MySqlParameter("@id", id.ToString())
                }
            );
        }

        public bool checkDuplicateName(string value)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("select * from nhanvien WHERE LOWER(soDienThoai)=LOWER(@soDienThoai) and hienThi=1;",
                new MySqlParameter[] {
                    new MySqlParameter("@soDienThoai", value.Trim().ToLower())
                }
            );

            if (dataTable.Rows.Count <= 0) return false;

            return true;
        }

        public bool checkDuplicateName(string value, int id)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("select * from nhanvien WHERE LOWER(soDienThoai)=LOWER(@soDienThoai) and hienThi=1 and maNhanVien!=@id;",
                new MySqlParameter[] {
                    new MySqlParameter("@soDienThoai", value.Trim().ToLower()),
                    new MySqlParameter("@id", id)
                }
            );

            if (dataTable.Rows.Count <= 0) return false;

            return true;
        }

        public StaffDTO getById(string id)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(
                "SELECT * FROM nhanvien WHERE maNhanVien=@MaNhanVien;",
                new MySqlParameter[] { new MySqlParameter("@MaNhanVien", id) }
            );
       
            if (dataTable.Rows.Count <= 0)
            {
				return null;
			}
			StaffDTO staff = new StaffDTO(dataTable.Rows[0]);
            return staff;
        }

        public double getSoldRevenue(string id)
        {
			DataTable dataTable = DataProvider.Instance.ExecuteQuery(
	            "SELECT SUM(tongtien) AS doanhThu FROM phieuban WHERE maNhanVien=@MaNhanVien;",
	            new MySqlParameter[] { new MySqlParameter("@MaNhanVien", id) }
            );

			if (dataTable.Rows.Count <= 0 || dataTable.Rows[0]["doanhThu"] == DBNull.Value) return 0;

			return Convert.ToDouble(dataTable.Rows[0]["doanhThu"]);
		}

        public List<StaffDTO> searchData(string value)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(
                "SELECT * FROM nhanvien WHERE (soDienThoai LIKE @value OR tenNhanVien LIKE @value) AND hienThi = 1;",
                new MySqlParameter[] { new MySqlParameter("@value", $"%{value}%") }
            );

            if (dataTable.Rows.Count <= 0) return null;

            List<StaffDTO> customers = new List<StaffDTO>();

            foreach (DataRow row in dataTable.Rows)
            {
                StaffDTO customer = new StaffDTO(row);
                customers.Add(customer);
            }

            return customers;
        }

        public bool insert(StaffDTO data)
        {

            string sql = $@"INSERT INTO nhanvien (tenNhanVien, namSinh, gioiTinh, soDienThoai, luong, maChucVu)
                            VALUES (@tenNhanVien, @namSinh, @gioiTinh, @soDienThoai, @luong, @maChucVu);";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@tenNhanVien", data.Ten),
                    new MySqlParameter("@namSinh", data.NamSinh),
                    new MySqlParameter("@gioiTinh", data.GioiTinh),
                    new MySqlParameter("@soDienThoai", data.SoDienThoai),
                    new MySqlParameter("@luong", data.Luong),
                    new MySqlParameter("@maChucVu", data.MaChucVu),
                });

            return rowChanged > 0;
        }

        public bool update(StaffDTO data)
        {
            string sql = $@"UPDATE nhanvien SET 
                            tenNhanVien=@tenNhanVien, namSinh=@namSinh, gioiTinh=@gioiTinh, soDienThoai=@soDienThoai, 
                            luong=@luong, maChucVu=@maChucVu WHERE maNhanVien=@maNhanVien;";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maNhanVien", data.Ma),
                    new MySqlParameter("@tenNhanVien", data.Ten),
                    new MySqlParameter("@namSinh", data.NamSinh),
                    new MySqlParameter("@gioiTinh", data.GioiTinh),
                    new MySqlParameter("@soDienThoai", data.SoDienThoai),
                    new MySqlParameter("@luong", data.Luong),
                    new MySqlParameter("@maChucVu", data.MaChucVu),
                });

            return rowChanged > 0;
        }

        public bool delete(string id)
        {
            string sql = $@"UPDATE nhanvien SET hienThi = 0 WHERE maNhanVien=@maNhanVien;";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maNhanVien", id),
                });

            return rowChanged > 0;
        }
    }
}