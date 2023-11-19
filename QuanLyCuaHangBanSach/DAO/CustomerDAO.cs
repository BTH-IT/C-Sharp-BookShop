using System;
using System.Collections.Generic;
using System.Data;
using QuanLyCuaHangBanSach.DAO;
using QuanLyCuaHangBanSach.DTO;
using MySql.Data.MySqlClient;

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


        public DataTable getAll()
        {
            return DataProvider.Instance.ExecuteQuery("select * from khachhang;");
        }

        public bool checkDuplicateName(string value)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("select * from khachhang WHERE  LOWER(soDienThoai)=LOWER(@soDienThoai);",
                new MySqlParameter[] {
                    new MySqlParameter("@soDienThoai", value.Trim().ToLower())
                }
            );

            if (dataTable.Rows.Count <= 0) return false;

            return true;
        }

        public bool checkDuplicateName(string value, int id)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("select * from khachhang WHERE  LOWER(soDienThoai)=LOWER(@soDienThoai) and maKhachHang!=@id;",
                new MySqlParameter[] {
                    new MySqlParameter("@soDienThoai", value.Trim().ToLower()),
                    new MySqlParameter("@id", id)
                }
            );

            if (dataTable.Rows.Count <= 0) return false;

            return true;
        }

        public List<CustomerDTO> Search(string searchInput)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(
                    "SELECT * FROM khachhang WHERE (soDienThoai = @SoDienThoai OR maKhachHang = @MaKhachHang OR tenKhachHang LIKE @TenKhachHang);",
                    new MySqlParameter[] {
                            new MySqlParameter("@MaKhachHang" ,$"{searchInput}"),
                            new MySqlParameter("@SoDienThoai" ,$"{searchInput}"),
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
                "SELECT * FROM khachhang WHERE maKhachHang=@MaKhachHang;",
                new MySqlParameter[] { new MySqlParameter("@MaKhachHang", id) }
            );

            if (dataTable.Rows.Count <= 0) return null;

            CustomerDTO customer = new CustomerDTO(dataTable.Rows[0]);

            return customer;
        }

        public List<CustomerDTO> SearchByPhoneNum(string num)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(
                "SELECT * FROM khachhang WHERE soDienThoai LIKE @SoDienThoai;",
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

        public List<CustomerDTO> loadCustomerChartData()
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(
                "SELECT khachhang.*, COALESCE((" +
                "SELECT SUM(tongTien) FROM phieuban WHERE khachhang.maKhachHang = phieuban.maKhachHang), 0) AS daMua " +
                "FROM khachhang " +
                "ORDER BY daMua DESC " +
                "LIMIT 5;"
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

            string sql = $@"INSERT INTO khachhang (maKhachHang, tenKhachHang, soDienThoai, gioiTinh, namSinh, diem)
                            VALUES (@MaKhachHang, @TenKhachHang, @SoDienThoai, @GioiTinh, @NamSinh, @Diem);";

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
            string sql = $@"UPDATE khachhang SET soDienThoai=@SoDienThoai, tenKhachHang=@TenKhachHang, gioiTinh=@GioiTinh, namSinh=@NamSinh, diem=@Diem
                            WHERE maKhachHang = @MaKhachHang";

            Console.WriteLine(data.Ma);
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