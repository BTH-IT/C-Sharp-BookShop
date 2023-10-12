using System.Collections.Generic;
using System.Data;
using QuanLyCuaHangBanSach.DAO;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.BUS
{
	public class CustomerBillBUS : IBUS<CustomerBillDTO>
	{
		private static CustomerBillBUS instance;

		public static CustomerBillBUS Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new CustomerBillBUS();
				}

				return CustomerBillBUS.instance;
			}
			private set { CustomerBillBUS.instance = value; }
		}

		public DataTable getAll()
		{
			return CustomerBillDAO.Instance.getAll();
		}


		public List<CustomerBillDTO> getAllData()
		{
			List<CustomerBillDTO> customerBillList = new List<CustomerBillDTO>();
			DataTable dt = CustomerBillDAO.Instance.getAll();

			foreach (DataRow row in dt.Rows)
			{
				CustomerBillDTO customerBill = new CustomerBillDTO(row);
				customerBillList.Add(customerBill);
			}

			return customerBillList;
		}

		public List<CustomerBillDTO> getAllInRange(string year, string startMonth, string endMonth)
		{
			List<CustomerBillDTO> customerBillList = new List<CustomerBillDTO>();
			DataTable dt = CustomerBillDAO.Instance.getAllInRange(year, startMonth, endMonth);

			foreach (DataRow row in dt.Rows)
			{
				CustomerBillDTO customerBill = new CustomerBillDTO(row);
				customerBillList.Add(customerBill);
			}

			return customerBillList;
		}

		public List<CustomerBillDetailDTO> getCustomerBillDetailList(string id)
		{
			return CustomerBillDAO.Instance.getCustomerBillDetailList(id);
		}

		public int getSoldQuantity(string id)
		{
			return CustomerBillDAO.Instance.getSoldQuantity(id);
		}

		public double getRevenue(string id)
		{ 
			return CustomerBillDAO.Instance.getRevenue(id);
		}

		public DataTable getSoldQuantityAndRevenue(string query)
		{
			return CustomerBillDAO.Instance.getSoldQuantityAndRevenue(query);
		}

		public double getRevenueInRange(string year, string startMonth, string endMonth)
		{
			return CustomerBillDAO.Instance.getRevenueInRange(year, startMonth, endMonth);
		}

		public DataTable getBookSoldInRange(string year, string startMonth, string endMonth)
		{ 
			return CustomerBillDAO.Instance.getBookSoldInRange(year, startMonth, endMonth);
		}

		public int getNumberCustomerInRange(string year, string startMonth, string endMonth)
		{
			return CustomerBillDAO.Instance.getNumberCustomerInRange(year, startMonth, endMonth);
		}

		public bool createCustomerBillDetail(CustomerBillDetailDTO customerBillDetail)
		{
			return CustomerBillDAO.Instance.createCustomerBillDetail(customerBillDetail);
		}

		public List<CustomerBillDTO> search(string id)
		{
			DataTable dataTable = CustomerBillDAO.Instance.searchData(id);

			List<CustomerBillDTO> customerBillList = new List<CustomerBillDTO>();

			foreach (DataRow row in dataTable.Rows)
			{
				CustomerBillDTO customerBill = new CustomerBillDTO(row);
				customerBillList.Add(customerBill);
			}

			return customerBillList;
		}

		public bool insert(CustomerBillDTO customerBill)
		{
			return CustomerBillDAO.Instance.insert(customerBill);
		}

		public CustomerBillDTO insertReturnBill(CustomerBillDTO customerBill)
		{
			return CustomerBillDAO.Instance.insertReturnBill(customerBill);
		}

		public bool delete(string id)
		{
			return CustomerBillDAO.Instance.delete(id);
		}

		public bool update(CustomerBillDTO customerBill)
		{
			return CustomerBillDAO.Instance.update(customerBill);
		}

		public CustomerBillDTO getById(string id)
		{
			return CustomerBillDAO.Instance.getById(id);
		}
	}
}
