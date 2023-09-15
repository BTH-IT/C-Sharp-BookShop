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

        public StaffDTO getById(string id)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(
                "SELECT * FROM nhanvien WHERE maNhanVien=@MaNhanVien AND hienThi = 1;",
                new MySqlParameter[] { new MySqlParameter("@MaNhanVien", id) }
            );

            if (dataTable.Rows.Count <= 0) return null;

            StaffDTO customer = new StaffDTO(dataTable.Rows[0]);

            return customer;
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

            string sql = $@"INSERT INTO nhanvien (tenNhanVien, namSinh, gioiTinh, soDienThoai, luong, soNgayNghi, maChucVu, hienThi)
                            VALUES (@tenNhanVien, @namSinh, @gioiTinh, @soDienThoai, @luong, @soNgayNghi, @maChucVu, 1);";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@tenNhanVien", data.Ten),
                    new MySqlParameter("@namSinh", data.NamSinh),
                    new MySqlParameter("@gioiTinh", data.GioiTinh),
                    new MySqlParameter("@soDienThoai", data.SoDienThoai),
                    new MySqlParameter("@luong", data.Luong),
                    new MySqlParameter("@soNgayNghi", data.SoNgayNghi),
                    new MySqlParameter("@maChucVu", data.MaChucVu),
                });

            return rowChanged > 0;
        }

        public bool update(StaffDTO data)
        {
            string sql = $@"UPDATE nhanvien SET 
                            tenNhanVien=@tenNhanVien, namSinh=@namSinh, gioiTinh=@gioiTinh, soDienThoai=@soDienThoai, 
                            luong=@luong, soNgayNghi=@soNgayNghi, maChucVu=@maChucVu
                            WHERE maNhanVien=@maNhanVien;";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maNhanVien", data.Ma),
                    new MySqlParameter("@tenNhanVien", data.Ten),
                    new MySqlParameter("@namSinh", data.NamSinh),
                    new MySqlParameter("@gioiTinh", data.GioiTinh),
                    new MySqlParameter("@soDienThoai", data.SoDienThoai),
                    new MySqlParameter("@luong", data.Luong),
                    new MySqlParameter("@soNgayNghi", data.SoNgayNghi),
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