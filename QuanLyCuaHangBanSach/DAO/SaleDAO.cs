using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.DAO
{
    public class SaleDAO : IDAO<SaleDTO>
    {
        private static SaleDAO instance;

        public static SaleDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SaleDAO();
                }

                return SaleDAO.instance;
            }
            private set { SaleDAO.instance = value; }
        }

        
        public DataTable getAll() {
            return DataProvider.Instance.ExecuteQuery("select * from khuyenmai WHERE hienThi = 1;");
        }

        public SaleDTO getById(string id)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(
                "SELECT * FROM khuyenmai WHERE maKhuyenMai=@MaKhuyenMai AND hienThi = 1;",
                new MySqlParameter[] { new MySqlParameter("@MaKhuyenMai", id) }
            );

            if (dataTable.Rows.Count <= 0) return null;

            SaleDTO customer = new SaleDTO(dataTable.Rows[0]);

            return customer;
        }

        public List<SaleDTO> getAllNotExpired()
        {
            DateTime currentDate = DateTime.Now;
            string sqlFormattedDate = currentDate.ToString("yyyy-MM-dd");

            DataTable dataTable = DataProvider.Instance.ExecuteQuery(
                "SELECT * FROM khuyenmai WHERE hienThi = 1 AND ngayBatDau<=@currentDate AND ngayKetThuc>=@currentDate;",
                new MySqlParameter[] { new MySqlParameter("@currentDate", sqlFormattedDate) }
            );

            if (dataTable.Rows.Count <= 0) return null;

            List<SaleDTO> customers = new List<SaleDTO>();

            foreach (DataRow row in dataTable.Rows)
            {
                SaleDTO customer = new SaleDTO(row);
                customers.Add(customer);
            }

            return customers;
        }

        public List<SaleDTO> searchData(string value)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(
                "SELECT * FROM khuyenmai WHERE (maKhuyenMai LIKE @value OR tenKhuyenMai LIKE @value) AND hienThi = 1;",
                new MySqlParameter[] { new MySqlParameter("@value", $"%{value}%") }
            );

            if (dataTable.Rows.Count <= 0) return null;

            List<SaleDTO> customers = new List<SaleDTO>();

            foreach (DataRow row in dataTable.Rows)
            {
                SaleDTO customer = new SaleDTO(row);
                customers.Add(customer);
            }

            return customers;
        }

        public bool insert(SaleDTO data)
        {

            string sql = $@"INSERT INTO khuyenmai (tenKhuyenMai, phanTram, ngayBatDau, ngayKetThuc, hienThi)
                            VALUES (@tenKhuyenMai, @phanTram, @ngayBatDau, @ngayKetThuc, 1);";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@tenKhuyenMai", data.TenKhuyenMai),
                    new MySqlParameter("@phanTram", data.PhanTram),
                    new MySqlParameter("@ngayBatDau", data.NgayBatDau),
                    new MySqlParameter("@ngayKetThuc", data.NgayKetThuc),
                });

            return rowChanged > 0;
        }

        public bool update(SaleDTO data)
        {
            string sql = $@"UPDATE khuyenmai SET 
                            tenKhuyenMai=@tenKhuyenMai, phanTram=@phanTram, ngayBatDau=@ngayBatDau, ngayKetThuc=@ngayKetThuc 
                            WHERE maKhuyenMai=@maKhuyenMai;";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maKhuyenMai", data.MaKhuyenMai),
                    new MySqlParameter("@tenKhuyenMai", data.TenKhuyenMai),
                    new MySqlParameter("@phanTram", data.PhanTram),
                    new MySqlParameter("@ngayBatDau", data.NgayBatDau),
                    new MySqlParameter("@ngayKetThuc", data.NgayKetThuc),
                });

            return rowChanged > 0;
        }

        public bool delete(string id)
        {
            string sql = $@"UPDATE khuyenmai SET hienThi = 0 WHERE maKhuyenMai=@maKhuyenMai;";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maKhuyenMai", id),
                });

            return rowChanged > 0;
        }
    }
}