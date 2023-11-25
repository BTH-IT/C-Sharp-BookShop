using QuanLyCuaHangBanSach.DAO;
using QuanLyCuaHangBanSach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangBanSach.BUS
{
	public class OrderBillBUS : IBUS<OrderBillDTO>
	{
		private static OrderBillBUS instance;

		public static OrderBillBUS Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new OrderBillBUS();
				}

				return OrderBillBUS.instance;
			}
			private set { OrderBillBUS.instance = value; }
		}
		public bool delete(string id)
		{
			throw new NotImplementedException();
		}

		public DataTable getAll()
		{
			return OrderBillDAO.Instance.getAll();
		}

		public List<OrderBillDTO> getAllData()
		{
			List<OrderBillDTO> orderBillList = new List<OrderBillDTO>();
			DataTable dt = OrderBillDAO.Instance.getAll();
			foreach (DataRow row in dt.Rows)
			{
				OrderBillDTO orderBill = new OrderBillDTO(row);
				Console.WriteLine(orderBill.TrangThai);
				orderBillList.Add(orderBill);
			}
		
			return orderBillList;
		}

		public OrderBillDTO getById(string id)
		{
			return OrderBillDAO.Instance.getById(id);
		}

		public bool insert(OrderBillDTO data)
		{
			return OrderBillDAO.Instance.insert(data);	
		}

		public bool update(OrderBillDTO data)
		{
			return OrderBillDAO.Instance.update(data);
		}
		public string getLatestId()
		{
			return OrderBillDAO.Instance.getLatestId();
		}
		public bool createOrderBillDetail(OrderBillDetailDTO OrderBillDetail)
		{
			return OrderBillDAO.Instance.createOrderBillDetail(OrderBillDetail);
		}
		public List<OrderBillDetailDTO> getOrderBillDetailList(string id)
		{
			return OrderBillDAO.Instance.getOrderBillDetailList(id);
		}
		public List<OrderBillDTO> search(string value)
		{
			DataTable dataTable = OrderBillDAO.Instance.searchData(value);

			List<OrderBillDTO> OrderBillList = new List<OrderBillDTO>();

			foreach (DataRow row in dataTable.Rows)
			{
				OrderBillDTO OrderBill = new OrderBillDTO(row);
				OrderBillList.Add(OrderBill);
			}

			return OrderBillList;
		}
	}
}
