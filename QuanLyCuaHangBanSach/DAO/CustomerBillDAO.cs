using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Documents;
using MySql.Data.MySqlClient;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.DAO
{
    public class CustomerBillDAO : IDAO<CustomerBillDTO>
    {
        private static CustomerBillDAO instance;

        public static CustomerBillDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CustomerBillDAO();
                }

                return CustomerBillDAO.instance;
            }
            private set { CustomerBillDAO.instance = value; }
        }

        
        public DataTable getAll() {
            return DataProvider.Instance.ExecuteQuery("select * from phieuban WHERE hienThi = 1;");
        }

        public CustomerBillDTO getById(string id)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(
                "SELECT * FROM phieuban WHERE maDonKhachHang=@maDonKhachHang AND hienThi = 1;",
                new MySqlParameter[] {
                    new MySqlParameter("@maDonKhachHang", id)
                }
            );

            if (dataTable.Rows.Count <= 0) return null;

            CustomerBillDTO account = new CustomerBillDTO(dataTable.Rows[0]);

            return account;
        }

        public List<CustomerBillDetailDTO> getCustomerBillDetail(string id)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(
                "SELECT * FROM chitietphieuban WHERE maDonKhachHang=@maDonKhachHang;",
                new MySqlParameter[] {
                    new MySqlParameter("@maDonKhachHang", id)
                }
            );

            if (dataTable.Rows.Count <= 0) return null;

            List<CustomerBillDetailDTO> customerBillDetailList = new List<CustomerBillDetailDTO>();

            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine(row["donGia"]);
                CustomerBillDetailDTO customerBillDetail = new CustomerBillDetailDTO(row);
                customerBillDetailList.Add(customerBillDetail);
            }

            return customerBillDetailList;
        }


        public DataTable searchData(string value)
        {
            string sql = $@"SELECT * FROM phieuban WHERE maDonKhachHang LIKE @maDonKhachHang AND hienThi = 1;";

            return DataProvider.Instance.ExecuteQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maDonKhachHang", "%" + value + "%"),
                }
            );
        }

        public bool insert(CustomerBillDTO data)
        {

            string sql = $@"INSERT INTO phieuban (maKhachHang, maNhanVien, ngayLap, tongTien, maKhuyenMai)
                            VALUES (@maKhachHang, @maNhanVien, @ngayLap, @tongTien, @maKhuyenMai);";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maKhachHang", data.MaKhachHang),
                    new MySqlParameter("@maNhanVien", data.MaNhanVien),
                    new MySqlParameter("@ngayLap", data.NgayLap),
                    new MySqlParameter("@tongTien", data.TongTien),
                    new MySqlParameter("@maKhuyenMai", data.MaKhuyenMai),
                });

            return rowChanged > 0;
        }

        public bool update(CustomerBillDTO data)
        {
            string sql = $@"UPDATE phieuban SET 
                            maKhachHang=@maKhachHang, maNhanVien=@maNhanVien, ngayLap=@ngayLap, 
                            tongTien=@tongTien, maKhuyenMai=@maKhuyenMai WHERE maDonKhachHang=@maDonKhachHang;";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maKhachHang", data.MaKhachHang),
                    new MySqlParameter("@maNhanVien", data.MaNhanVien),
                    new MySqlParameter("@ngayLap", data.NgayLap),
                    new MySqlParameter("@tongTien", data.TongTien),
                    new MySqlParameter("@maKhuyenMai", data.MaKhuyenMai),
                    new MySqlParameter("@maDonKhachHang", data.MaDonKhachHang),
                });

            return rowChanged > 0;
        }

        public bool delete(string id)
        {
            string sql = $@"UPDATE phieuban SET hienThi = 0 WHERE maDonKhachHang=@maDonKhachHang;";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maDonKhachHang", id),
                });

            return rowChanged > 0;
        }
    }
}
