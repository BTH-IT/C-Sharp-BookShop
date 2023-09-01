using System.Collections.Generic;
using System.Data;
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

        public CustomerBillDetailDTO getCustomerBillDetail(string billId, string bookId)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(
                "SELECT * FROM chitietphieuban WHERE maDonKhachHang=@maDonKhachHang AND maSach=@maSach;",
                new MySqlParameter[] {
                    new MySqlParameter("@maDonKhachHang", billId),
                    new MySqlParameter("@maSach", bookId)
                }
            );

            if (dataTable.Rows.Count <= 0) return null;

            CustomerBillDetailDTO customerBillDetail = new CustomerBillDetailDTO(dataTable.Rows[0]);

            return customerBillDetail;
        }

        public List<CustomerBillDetailDTO> getCustomerBillDetailList(string billId)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(
                "SELECT * FROM chitietphieuban WHERE maDonKhachHang=@maDonKhachHang;",
                new MySqlParameter[] {
                    new MySqlParameter("@maDonKhachHang", billId),
                }
            );

            if (dataTable.Rows.Count <= 0) return null;

            List<CustomerBillDetailDTO> customerBillDetailList = new List<CustomerBillDetailDTO>();

            foreach (DataRow row in dataTable.Rows)
            {
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

        public bool createCustomerBillDetail(CustomerBillDetailDTO data)
        {
            string sql = $@"INSERT INTO chitietphieuban (maDonKhachHang, maSach, soLuong, donGia) 
                            VALUES (@maDonKhachHang, @maSach, @soLuong, @donGia);";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maDonKhachHang", data.MaDon),
                    new MySqlParameter("@maSach", data.MaSach),
                    new MySqlParameter("@soLuong", data.SoLuong),
                    new MySqlParameter("@donGia", data.DonGia),
                });

            return rowChanged > 0;
        }

        public bool updateCustomerBillDetail(CustomerBillDetailDTO data)
        {
            string sql = $@"UPDATE chitietphieuban SET soLuong=@soLuong, donGia=@donGia  
                            WHERE maDonKhachHang=@maDonKhachHang AND maSach=@maSach;";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maDonKhachHang", data.MaDon),
                    new MySqlParameter("@maSach", data.MaSach),
                    new MySqlParameter("@soLuong", data.SoLuong),
                    new MySqlParameter("@donGia", data.DonGia),
                });

            return rowChanged > 0;
        }

        public bool deleteCustomerBillDetail(string billId, string bookId)
        {
            string sql = $@"DELETE FROM chitietphieuban WHERE maDonKhachHang=@maDonKhachHang AND maSach=@maSach;";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maDonKhachHang", billId),
                    new MySqlParameter("@maSach", bookId),
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
                    new MySqlParameter("@maKhuyenMai", data.MaKhuyenMai == -1 ? null : data.MaKhuyenMai.ToString()),
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
