using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.DAO
{
    public class CustomerRefundBillDAO : IDAO<CustomerRefundBillDTO>
    {
        private static CustomerRefundBillDAO instance;

        public static CustomerRefundBillDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CustomerRefundBillDAO();
                }

                return CustomerRefundBillDAO.instance;
            }
            private set { CustomerRefundBillDAO.instance = value; }
        }
        public DataTable getAll() {
            return DataProvider.Instance.ExecuteQuery("select * from phieutrabanhang;");
        }

        public CustomerRefundBillDetailDTO getCustomerRefundBillDetail(string billId, string bookId)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(
                "SELECT * FROM chitietphieutrabanhang WHERE maPhieuTraBanHang=@maPhieuTraBanHang AND maSach=@maSach;",
                new MySqlParameter[] {
                    new MySqlParameter("@maPhieuTraBanHang", billId),
                    new MySqlParameter("@maSach", bookId)
                }
            );

            if (dataTable.Rows.Count <= 0) return null;

            CustomerRefundBillDetailDTO customerBillDetail = new CustomerRefundBillDetailDTO(dataTable.Rows[0]);

            return customerBillDetail;
        }

        public List<CustomerRefundBillDetailDTO> getCustomerRefundBillDetailList(string billId)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(
                "SELECT * FROM chitietphieutrabanhang WHERE maPhieuTraBanHang=@maPhieuTraBanHang;",
                new MySqlParameter[] {
                    new MySqlParameter("@maPhieuTraBanHang", billId),
                }
            );

            if (dataTable.Rows.Count <= 0) return null;

            List<CustomerRefundBillDetailDTO> customerBillDetailList = new List<CustomerRefundBillDetailDTO>();

            foreach (DataRow row in dataTable.Rows)
            {
                CustomerRefundBillDetailDTO customerBillDetail = new CustomerRefundBillDetailDTO(row);
                customerBillDetailList.Add(customerBillDetail);
            }

            return customerBillDetailList;
        }

        public DataTable searchData(string value)
        {
            string sql = $@"SELECT * FROM phieutrabanhang WHERE maPhieuTraBanHang LIKE @maPhieuTraBanHang;";

            return DataProvider.Instance.ExecuteQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maPhieuTraBanHang", "%" + value + "%"),
                }
            );
        }

        public bool insert(CustomerRefundBillDTO data)
        {

            string sql = $@"INSERT INTO phieutrabanhang (maDonKhachHang, ngayLap, liDo, tongTien, daTraKhach, trangThai)
                            VALUES (@maDonKhachHang, @ngayLap, @liDo, @tongTien, @daTraKhach, @trangThai);";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maDonKhachHang", data.MaDonKhachHang),
                    new MySqlParameter("@ngayLap", data.NgayLap),
                    new MySqlParameter("@liDo", data.LiDo),
                    new MySqlParameter("@tongTien", data.TongTien),
                    new MySqlParameter("@daTraKhach", data.DaTraKhach),
                    new MySqlParameter("@trangThai", data.TrangThai),
                });

            return rowChanged > 0;
        }

        public CustomerRefundBillDTO insertReturnBill(CustomerRefundBillDTO data)
        {
            string sql = "SELECT * FROM phieutrabanhang ORDER BY maPhieuTraBanHang DESC LIMIT 1;";
            if (this.insert(data))
            {

                DataTable dataTable = DataProvider.Instance.ExecuteQuery(sql);

                if (dataTable.Rows.Count <= 0) return null;

                CustomerRefundBillDTO customerBill = new CustomerRefundBillDTO(dataTable.Rows[0]);

                return customerBill;
            };

            return null;
        }

        public bool createCustomerRefundBillDetail(CustomerRefundBillDetailDTO data)
        {
            string sql = $@"INSERT INTO chitietphieutrabanhang (maPhieuTraBanHang, maSach, soLuong, donGia) 
                            VALUES (@maPhieuTraBanHang, @maSach, @soLuong, @donGia);";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maPhieuTraBanHang", data.MaDon),
                    new MySqlParameter("@maSach", data.MaSach),
                    new MySqlParameter("@soLuong", data.SoLuong),
                    new MySqlParameter("@donGia", data.DonGia),
                });

            // xóa số lượng còn lại của sách
            if (rowChanged > 0)
            {
                BookDTO book = BookBUS.Instance.getById(data.MaSach.ToString());

                book.SoLuongConLai -= data.SoLuong;

                return BookBUS.Instance.update(book);
            }

            return rowChanged > 0;
        }

        public bool update(CustomerRefundBillDTO data)
        {
            string sql = $@"UPDATE phieutrabanhang SET 
                            maDonKhachHang=@maDonKhachHang, liDo=@liDo, ngayLap=@ngayLap, 
                            tongTien=@tongTien, daTraKhach=@daTraKhach, trangThai=@trangThai WHERE maPhieuTraBanHang=@maPhieuTraBanHang;";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maDonKhachHang", data.MaDonKhachHang),
                    new MySqlParameter("@liDo", data.LiDo),
                    new MySqlParameter("@ngayLap", data.NgayLap),
                    new MySqlParameter("@tongTien", data.TongTien),
                    new MySqlParameter("@daTraKhach", data.DaTraKhach),
                    new MySqlParameter("@maPhieuTraBanHang", data.MaPhieu),
                });

            return rowChanged > 0;
        }

        public bool delete(string id)
        {
            string sql = $@"DELETE FROM phieutrabanhang WHERE maPhieuTraBanHang=@maPhieuTraBanHang;";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maPhieuTraBanHang", id),
                });

            return rowChanged > 0;
        }

        public CustomerRefundBillDTO getById(string id)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(
                "SELECT * FROM phieutrabanhang WHERE maPhieuTraBanHang=@maPhieuTraBanHang;",
                new MySqlParameter[] {
                    new MySqlParameter("@maPhieuTraBanHang", id),
                }
            );

            if (dataTable.Rows.Count <= 0) return null;

            CustomerRefundBillDTO customerBill = new CustomerRefundBillDTO(dataTable.Rows[0]);

            return customerBill;
        }
    }
}
