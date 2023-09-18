using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.DAO
{
    public class CustomerDAO : IDAO<CustomerDTO>
    {
        private static CustomerDAO instance;

        public static CustomerDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CustomerDAO();
                }

                return CustomerDAO.instance;
            }
            private set { CustomerDAO.instance = value; }
        }

        
        public DataTable getAll() {
            return DataProvider.Instance.ExecuteQuery("select * from khachhang WHERE hienThi = 1;");
        }

        public List<CustomerDTO> Search(string searchInput)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(
                    "SELECT * FROM khachhang WHERE (hienthi = 1 ) AND (soDienThoai = @SoDienThoai OR maKhachHang = @MaKhachHang OR tenKhachHang LIKE @TenKhachHang) ",
                    new MySqlParameter[] {
                            new MySqlParameter("@SoDienThoai" ,$"{searchInput}"),
                            new MySqlParameter("@MaKhachHang" ,$"{searchInput}"),
                            new MySqlParameter("@TenKhachHang" ,$"%{searchInput}%"),
                    }
                );
            if (dataTable.Rows.Count <= 0) return null;
            List<CustomerDTO> customers = new List<CustomerDTO>();

            foreach (DataRow row in dataTable.Rows)
            {
                CustomerDTO customer = new CustomerDTO(row);
                customers.Add(customer);
            }
            return customers;
        }

        public CustomerDTO getById(string id)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(
                "SELECT * FROM khachhang WHERE maKhachHang=@MaKhachHang AND hienThi = 1;",
                new MySqlParameter[] { new MySqlParameter("@MaKhachHang", id) }
            );

            if (dataTable.Rows.Count <= 0) return null;

            CustomerDTO customer = new CustomerDTO(dataTable.Rows[0]);

            return customer;
        }

        public List<CustomerDTO> SearchByPhoneNum(string num)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(
                "SELECT * FROM khachhang WHERE soDienThoai LIKE @SoDienThoai AND hienThi = 1;",
                new MySqlParameter[] { new MySqlParameter("@SoDienThoai", $"%{num}%") }
            );

            if (dataTable.Rows.Count <= 0) return null;

            List<CustomerDTO> customers = new List<CustomerDTO>();

            foreach (DataRow row in dataTable.Rows)
            {
                CustomerDTO customer = new CustomerDTO(row);
                customers.Add(customer);
            }

            return customers;
        }

        public bool insert(CustomerDTO data)
        {

            string sql = $@"INSERT INTO khachhang (maKhachHang, tenKhachHang, soDienThoai, gioiTinh, namSinh, diem, hienThi)
                            VALUES (@MaKhachHang, @TenKhachHang, @SoDienThoai, @GioiTinh, @NamSinh, @Diem, 1);";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@MaKhachHang", data.Ma),
                    new MySqlParameter("@TenKhachHang", data.Ten),
                    new MySqlParameter("@SoDienThoai", data.SoDienThoai),
                    new MySqlParameter("@GioiTinh", data.GioiTinh),
                    new MySqlParameter("@NamSinh", data.NamSinh),
                    new MySqlParameter("@Diem", data.Diem),
                });

            return rowChanged > 0;
        }

        public bool update(CustomerDTO data)
        {
            string sql = $@"UPDATE khachhang SET maKhachHang=@MaKhachHang, tenKhachHang=@TenKhachHang, gioiTinh=@GioiTinh, namSinh=@NamSinh, diem=@Diem
                            WHERE soDienThoai=@SoDienThoai;";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@MaKhachHang", data.Ma),
                    new MySqlParameter("@TenKhachHang", data.Ten),
                    new MySqlParameter("@SoDienThoai", data.SoDienThoai),
                    new MySqlParameter("@GioiTinh", data.GioiTinh),
                    new MySqlParameter("@NamSinh", data.NamSinh),
                    new MySqlParameter("@Diem", data.Diem),
                });

            return rowChanged > 0;
        }

        public bool delete(string id)
        {
            string sql = $@"UPDATE khachhang SET hienThi = 0 WHERE soDienThoai=@SoDienThoai;";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@SoDienThoai", id),
                });

            return rowChanged > 0;
        }
    }
}