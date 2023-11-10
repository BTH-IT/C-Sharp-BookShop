using System;
using System.Collections.Generic;
using System.Data;
using System.Net;
using MySql.Data.MySqlClient;
using QuanLyCuaHangBanSach.BUS;
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
            return DataProvider.Instance.ExecuteQuery("select * from phieuban;");
        }

		public DataTable getAllInRange(string year, string startMonth, string endMonth)
		{
			DataTable dataTable = DataProvider.Instance.ExecuteQuery(
				"SELECT * FROM phieuban WHERE YEAR(ngayLap)=@nam AND MONTH(ngayLap) >= @thangBatDau AND MONTH(ngayLap) <= @thangKetThuc;",
				new MySqlParameter[] {
					new MySqlParameter("@nam", year),
					new MySqlParameter("@thangBatDau", startMonth),
					new MySqlParameter("@thangKetThuc", endMonth)
				}

			);

			if (dataTable.Rows.Count <= 0) return null;

			return dataTable;
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

        public int getSoldQuantity(string bookId)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(
                "SELECT sum(soLuong) as daBan FROM chitietphieuban where maSach=@maSach;",
                new MySqlParameter[] {
                    new MySqlParameter("@maSach", bookId)
                }
            );
            if (dataTable.Rows.Count <= 0 || dataTable.Rows[0]["daBan"] == DBNull.Value) return 0;

            return Convert.ToInt32(dataTable.Rows[0]["daBan"]);
        }

        public double getRevenue(string bookId)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(
                "SELECT SUM(soLuong * donGia) AS doanhThu FROM chitietphieuban where maSach=@maSach;",
                new MySqlParameter[] {
                    new MySqlParameter("@maSach", bookId)
                }
            );

            if (dataTable.Rows.Count <= 0 || dataTable.Rows[0]["doanhThu"] == DBNull.Value) return 0;

            return Convert.ToDouble(dataTable.Rows[0]["doanhThu"]);
        }
        
        public DataTable getSoldQuantityAndRevenue(string query)
        {
			DataTable dataTable = DataProvider.Instance.ExecuteQuery(
				"SELECT chitietphieuban.maSach, SUM(soLuong) as daBan, SUM(soLuong * donGia) AS doanhThu " +
                "FROM chitietphieuban JOIN sach ON chitietphieuban.maSach=sach.maSach " +
                "WHERE (sach.maSach LIKE @maSach OR tenSach LIKE @tenSach) " +
                "GROUP BY maSach;",
	            new MySqlParameter[] {
					new MySqlParameter("@maSach", "%" + query + "%"),
					new MySqlParameter("@tenSach", "%" + query + "%")
	            }
            );

            if (dataTable.Rows.Count <= 0) return null;

			return dataTable;
		}

		public double getRevenueInRange(string year, string startMonth, string endMonth)
		{
			DataTable dataTable = DataProvider.Instance.ExecuteQuery(
				"SELECT SUM(tongTien) AS doanhThu FROM phieuban WHERE YEAR(ngayLap)=@nam AND MONTH(ngayLap) >= @thangBatDau AND MONTH(ngayLap) <= @thangKetThuc;",
				new MySqlParameter[] {
					new MySqlParameter("@nam", year),
					new MySqlParameter("@thangBatDau", startMonth),
					new MySqlParameter("@thangKetThuc", endMonth)
				}

			);

			if (dataTable.Rows.Count <= 0 || dataTable.Rows[0]["doanhThu"] == DBNull.Value) return 0;

			return Convert.ToDouble(dataTable.Rows[0]["doanhThu"]);
		}

		public DataTable getBookSoldInRange(string year, string startMonth, string endMonth)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(
                "SELECT MONTH(ngayLap) AS thang, SUM(chitietphieuban.soLuong) AS soLuong " +
                "FROM phieuban JOIN chitietphieuban ON phieuban.maDonKhachHang = chitietphieuban.maDonKhachHang " +
				"WHERE YEAR(ngayLap)=@nam AND MONTH(ngayLap) >= @thangBatDau AND MONTH(ngayLap) <= @thangKetThuc " +
                "GROUP BY thang " +
                "ORDER BY thang;",
                new MySqlParameter[] {
                    new MySqlParameter("@nam", year),
                    new MySqlParameter("@thangBatDau", startMonth),
                    new MySqlParameter("@thangKetThuc", endMonth)
                }
            );

            if (dataTable.Rows.Count <= 0) return null;

            return dataTable;
        }

		public int getNumberCustomerInRange(string year, string startMonth, string endMonth)
		{
			DataTable dataTable = DataProvider.Instance.ExecuteQuery(
				"SELECT COUNT(maKhachHang) AS soLuongKhach FROM phieuban WHERE YEAR(ngayLap)=@nam AND MONTH(ngayLap) >= @thangBatDau AND MONTH(ngayLap) <= @thangKetThuc;",
				new MySqlParameter[] {
					new MySqlParameter("@nam", year),
					new MySqlParameter("@thangBatDau", startMonth),
					new MySqlParameter("@thangKetThuc", endMonth)
				}
			);

			if (dataTable.Rows.Count <= 0 || dataTable.Rows[0]["soLuongKhach"] == DBNull.Value) return 0;

			return Convert.ToInt32(dataTable.Rows[0]["soLuongKhach"]);
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

        public int countBillByCustomerID(string customerId)
        {
			DataTable dataTable = DataProvider.Instance.ExecuteQuery(
				"SELECT COUNT(maDonKhachHang) AS soDon FROM phieuban WHERE maKhachHang=@maKhachHang;",
				new MySqlParameter[] {
					new MySqlParameter("@maKhachHang", customerId),
				}
			);

			if (dataTable.Rows.Count <= 0 || dataTable.Rows[0]["soDon"] == DBNull.Value) return 0;

			return Convert.ToInt32(dataTable.Rows[0]["soDon"]);
		}

		public double getCustomerBoughtTotal(string customerId)
		{
			DataTable dataTable = DataProvider.Instance.ExecuteQuery(
				"SELECT SUM(tongTien) AS daMua FROM phieuban WHERE maKhachHang=@maKhachHang;",
				new MySqlParameter[] {
					new MySqlParameter("@maKhachHang", customerId),
				}
			);

			if (dataTable.Rows.Count <= 0 || dataTable.Rows[0]["daMua"] == DBNull.Value) return 0;

			return Convert.ToDouble(dataTable.Rows[0]["daMua"]);
		}

		public DataTable searchData(string value)
        {
            string sql = $@"SELECT * FROM phieuban WHERE maDonKhachHang LIKE @maDonKhachHang;";

            return DataProvider.Instance.ExecuteQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maDonKhachHang", "%" + value + "%"),
                }
            );
        }

        public bool insert(CustomerBillDTO data)
        {

            string sql = $@"INSERT INTO phieuban (maKhachHang, maNhanVien, ngayLap, tongTien, maKhuyenMai, tienKhachDua)
                            VALUES (@maKhachHang, @maNhanVien, @ngayLap, @tongTien, @maKhuyenMai, @tienKhachDua);";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maKhachHang", data.MaKhachHang),
                    new MySqlParameter("@maNhanVien", data.MaNhanVien),
                    new MySqlParameter("@ngayLap", data.NgayLap),
                    new MySqlParameter("@tongTien", data.TongTien),
                    new MySqlParameter("@maKhuyenMai", data.MaKhuyenMai),
                    new MySqlParameter("@tienKhachDua", data.TienKhachDua),
                });

            return rowChanged > 0;
        }

        public CustomerBillDTO insertReturnBill(CustomerBillDTO data)
        {
            string sql = "SELECT * FROM phieuban ORDER BY maDonKhachHang DESC LIMIT 1;";
            if (this.insert(data))
            {

                DataTable dataTable = DataProvider.Instance.ExecuteQuery(sql);

                if (dataTable.Rows.Count <= 0) return null;

                CustomerBillDTO customerBill = new CustomerBillDTO(dataTable.Rows[0]);

                return customerBill;
            };

            return null;
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

            // xóa số lượng còn lại của sách
            if (rowChanged > 0)
            {
                return BookBUS.Instance.deleteBookAmount(data.MaSach.ToString(), data.SoLuong);
            }

            return rowChanged > 0;
        }

        public bool update(CustomerBillDTO data)
        {
            string sql = $@"UPDATE phieuban SET 
                            maKhachHang=@maKhachHang, maNhanVien=@maNhanVien, ngayLap=@ngayLap, 
                            tongTien=@tongTien, maKhuyenMai=@maKhuyenMai, tienKhachDua=@tienKhachDua WHERE maDonKhachHang=@maDonKhachHang;";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maKhachHang", data.MaKhachHang),
                    new MySqlParameter("@maNhanVien", data.MaNhanVien),
                    new MySqlParameter("@ngayLap", data.NgayLap),
                    new MySqlParameter("@tongTien", data.TongTien),
                    new MySqlParameter("@maKhuyenMai", data.MaKhuyenMai == -1 ? null : data.MaKhuyenMai.ToString()),
                    new MySqlParameter("@tienKhachDua", data.MaDonKhachHang),
                    new MySqlParameter("@maDonKhachHang", data.MaDonKhachHang),
                });

            return rowChanged > 0;
        }

        public bool delete(string id)
        {
            string sql = $@"DELETE FROM phieuban WHERE maDonKhachHang=@maDonKhachHang;";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maDonKhachHang", id),
                });

            return rowChanged > 0;
        }

        public CustomerBillDTO getById(string id)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(
                "SELECT * FROM phieuban WHERE maDonKhachHang=@maDonKhachHang;",
                new MySqlParameter[] {
                    new MySqlParameter("@maDonKhachHang", id),
                }
            );

            if (dataTable.Rows.Count <= 0) return null;

            CustomerBillDTO customerBill = new CustomerBillDTO(dataTable.Rows[0]);

            return customerBill;
        }
    }
}
