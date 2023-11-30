using MySql.Data.MySqlClient;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangBanSach.DAO
{
	public class OrderBillDAO
	{
		private static OrderBillDAO instance;

		public static OrderBillDAO Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new OrderBillDAO();
				}

				return OrderBillDAO.instance;
			}
			private set { OrderBillDAO.instance = value; }
		}
		public DataTable getAll()
		{
			return DataProvider.Instance.ExecuteQuery("select * from phieuyeucau;");
		}
		public List<OrderBillDetailDTO> getOrderBillDetailList(string billId)
		{
			DataTable dataTable = DataProvider.Instance.ExecuteQuery(
				"SELECT * FROM chitietphieuyeucau WHERE maPhieuYeuCau=@maPhieuYeuCau;",
				new MySqlParameter[] {
					new MySqlParameter("@maPhieuYeuCau", billId),
				}
			);

			if (dataTable.Rows.Count <= 0) return null;

			List<OrderBillDetailDTO> orderBillDetailList = new List<OrderBillDetailDTO>();

			foreach (DataRow row in dataTable.Rows)
			{
				OrderBillDetailDTO orderBillDetail = new OrderBillDetailDTO(row);
				orderBillDetailList.Add(orderBillDetail);
			}

			return orderBillDetailList;
		}
		public bool createOrderBillDetail(OrderBillDetailDTO data)
		{
			string sql = $@"INSERT INTO chitietphieuyeucau (maPhieuYeuCau, maSach, soLuong) 
                            VALUES (@maPhieuYeuCau, @maSach, @soLuong);";

			int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
				new MySqlParameter[] {
					new MySqlParameter("@maPhieuYeuCau", data.MaPhieuYeuCau),
					new MySqlParameter("@maSach", data.MaSach),
					new MySqlParameter("@soLuong", data.SoLuong),
				});
			return rowChanged > 0;
		}
		public bool insert(OrderBillDTO data)
		{

			string sql = $@"INSERT INTO phieuyeucau (maNhanVien, maNhaCungCap, ngayLap, trangThai)
                            VALUES (@maNhanVien, @maNhaCungCap, @ngayLap, @trangThai);";

			int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
				new MySqlParameter[] {
					new MySqlParameter("@maNhaCungCap", data.MaNhaCungCap),
					new MySqlParameter("@maNhanVien", data.MaNhanVien),
					new MySqlParameter("@ngayLap", data.NgayLap),
					new MySqlParameter("@trangThai",data.TrangThai)
				});

			return rowChanged > 0;
		}
		public OrderBillDTO insertReturnBill(OrderBillDTO data)
		{
			string sql = "SELECT * FROM phieuyeucau ORDER BY maPhieuYeuCau DESC LIMIT 1;";
			if (this.insert(data))
			{

				DataTable dataTable = DataProvider.Instance.ExecuteQuery(sql);

				if (dataTable.Rows.Count <= 0) return null;

				OrderBillDTO orderBill = new OrderBillDTO(dataTable.Rows[0]);

				return orderBill;
			};

			return null;
		}
		public bool update(OrderBillDTO data)
		{
			Console.WriteLine();
			string sql = $@"UPDATE phieuyeucau SET 
                            maNhaCungCap=@maNhaCungCap, maNhanVien=@maNhanVien, ngayLap=@ngayLap, 
                            trangThai=@trangThai WHERE maPhieuYeuCau=@maPhieuNhapHang;";

			int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
				new MySqlParameter[] {
					new MySqlParameter("@maNhaCungCap", data.MaNhaCungCap),
					new MySqlParameter("@maNhanVien", data.MaNhanVien),
					new MySqlParameter("@ngayLap", data.NgayLap),
					new MySqlParameter("@trangThai", data.TrangThai),
					new MySqlParameter("@maPhieuNhapHang", data.MaPhieuYeuCau),
				});
			return rowChanged > 0;
		}
		public bool delete(string id)
		{
			string sql = $@"DELETE FROM chitietphieuyeucau WHERE maPhieuYeuCau=@maPhieuYeuCau;";

			int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
				new MySqlParameter[] {
					new MySqlParameter("@maPhieuYeuCau", id),
				});

			sql = $@"DELETE FROM phieuyeucau WHERE maPhieuYeuCau=@maPhieuYeuCau;";

			rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
				new MySqlParameter[] {
					new MySqlParameter("@maPhieuYeuCau;", id),
				});

			return rowChanged > 0;
		}

		public bool updateTrangThai(string maPhieuyeucau, int trangThai)
		{
			string sql = $@"UPDATE phieuyeucau SET 
                            trangThai=@trangThai Where maPhieuYeuCau=@maPhieuYeuCau;";

			int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
				new MySqlParameter[] {
					new MySqlParameter("@maPhieuYeuCau", maPhieuyeucau),
					new MySqlParameter("@trangThai", trangThai),
				});
			return rowChanged > 0;
		}

		public DataTable searchData(string value)
		{
			string sql = $@"SELECT * FROM phieuyeucau WHERE maPhieuYeuCau LIKE @maPhieuYeuCau;";

			return DataProvider.Instance.ExecuteQuery(sql,
				new MySqlParameter[] {
					new MySqlParameter("@maPhieuYeuCau", "%" + value + "%"),
				}
			);
		}
		public OrderBillDTO getById(string id)
		{
			Console.WriteLine(id);
			DataTable dataTable = DataProvider.Instance.ExecuteQuery(
				"SELECT * FROM phieuyeucau WHERE maPhieuYeuCau=@maPhieuYeuCau;",
				new MySqlParameter[] {
					new MySqlParameter("@maPhieuYeuCau", id),
				}
			);

			if (dataTable.Rows.Count <= 0) return null;

			OrderBillDTO orderBill = new OrderBillDTO(dataTable.Rows[0]);

			return orderBill;
		}
		public string getLatestId()
		{
			DataTable dataTable = DataProvider.Instance.ExecuteQuery(
				"SELECT maPhieuYeuCau FROM phieuyeucau ORDER BY maPhieuYeuCau DESC LIMIT 1;"
			);

			if (dataTable.Rows.Count <= 0) return null;

			return dataTable.Rows[0]["maPhieuYeuCau"].ToString();
		}
	}
}
