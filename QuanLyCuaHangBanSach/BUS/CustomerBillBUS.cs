using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Utilities;
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

        public CustomerBillDTO getById(string id)
        {
            return CustomerBillDAO.Instance.getById(id);
        }
        public List<CustomerBillDetailDTO> getCustomerBillDetail(string id)
        {
            return CustomerBillDAO.Instance.getCustomerBillDetail(id);
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

        public bool update(CustomerBillDTO customerBill)
        {
            return CustomerBillDAO.Instance.update(customerBill);
        }

        public bool delete(string id)
        {
            return CustomerBillDAO.Instance.delete(id);
        }
    }
}
