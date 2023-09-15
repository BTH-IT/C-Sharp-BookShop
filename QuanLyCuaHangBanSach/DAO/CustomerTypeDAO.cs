using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Markup;
using MySql.Data.MySqlClient;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.DAO
{
    public class CustomerTypeDAO : IDAO<CustomerTypeDTO>
    {
        private static CustomerTypeDAO instance;

        public static CustomerTypeDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CustomerTypeDAO();
                }

                return CustomerTypeDAO.instance;
            }
            private set { CustomerTypeDAO.instance = value; }
        }

        
        public DataTable getAll() {
            return DataProvider.Instance.ExecuteQuery("select * from nhomkhachhang WHERE hienThi = 1;");
        }

        public CustomerTypeDTO getById(string id)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(
                "SELECT * FROM nhomkhachhang WHERE maNhomKhachHang=@MaNhomKhachHang AND hienThi = 1;",
                new MySqlParameter[] { new MySqlParameter("@MaNhomKhachHang", id) }
            );

            if (dataTable.Rows.Count <= 0) return null;

            CustomerTypeDTO customer = new CustomerTypeDTO(dataTable.Rows[0]);

            return customer;
        }

        public bool insert(CustomerTypeDTO data)
        {

            string sql = $@"INSERT INTO nhomkhachhang (maNhomKhachHang, tenNhomKhachHang)
                            VALUES (@MaNhomKhachHang, @TenNhomKhachHang);";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@MaNhomKhachHang", data.MaNhomKhachHang),
                    new MySqlParameter("@TenNhomKhachHang", data.TenNhomKhachHang),
                });

            return rowChanged > 0;
        }

        public bool update(CustomerTypeDTO data)
        {
            string sql = $@"UPDATE nhomkhachhang SET tenNhomKhachHang=@TenNhomKhachHang
                            WHERE maNhomKhachHang=@MaNhomKhachHang;";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@MaNhomKhachHang", data.MaNhomKhachHang),
                    new MySqlParameter("@TenNhomKhachHang", data.TenNhomKhachHang),
                });

            return rowChanged > 0;
        }

        public bool delete(string id)
        {
            string sql = $@"UPDATE nhomkhachhang SET hienThi = 0 WHERE maNhomKhachHang=@MaNhomKhachHang;";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
            new MySqlParameter[] {
                    new MySqlParameter("@MaNhomKhachHang", id)
                });

            return rowChanged > 0;
        }
    }
}