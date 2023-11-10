using System.Collections.Generic;
using System.Data;
using BookShop_CNPM.DAO;
using BookShop_CNPM.DTO;

namespace BookShop_CNPM.BUS
{
    public class CustomerChangeBillBUS : IBUS<CustomerChangeBillDTO>
    {
        private static CustomerChangeBillBUS instance;

        public static CustomerChangeBillBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CustomerChangeBillBUS();
                }

                return CustomerChangeBillBUS.instance;
            }
            private set { CustomerChangeBillBUS.instance = value; }
        }

        public DataTable getAll()
        {
            return CustomerChangeBillDAO.Instance.getAll();
        }

        public List<CustomerChangeBillDTO> getAllData()
        {
            List<CustomerChangeBillDTO> customerChangeBillList = new List<CustomerChangeBillDTO>();
            DataTable dt = CustomerChangeBillDAO.Instance.getAll();

            foreach (DataRow row in dt.Rows)
            {
                CustomerChangeBillDTO customerChangeBill = new CustomerChangeBillDTO(row);
                customerChangeBillList.Add(customerChangeBill);
            }

            return customerChangeBillList;
        }

        public List<CustomerChangeBillDTO> search(string value)
        {
            DataTable dataTable = CustomerChangeBillDAO.Instance.searchData(value);

            List<CustomerChangeBillDTO> customerChangeBillList = new List<CustomerChangeBillDTO>();

            foreach (DataRow row in dataTable.Rows)
            {
                CustomerChangeBillDTO customerChangeBill = new CustomerChangeBillDTO(row);
                customerChangeBillList.Add(customerChangeBill);
            }

            return customerChangeBillList;
        }

        public bool insert(CustomerChangeBillDTO customerChangeBill)
        {
            return CustomerChangeBillDAO.Instance.insert(customerChangeBill);
        }

        public CustomerChangeBillDTO insertReturnBill(CustomerChangeBillDTO customerChangeBill)
        {
            return CustomerChangeBillDAO.Instance.insertReturnBill(customerChangeBill);
        }

        public bool update(CustomerChangeBillDTO customerChangeBill)
        {
            return CustomerChangeBillDAO.Instance.update(customerChangeBill);
        }

        public bool delete(string id)
        {
            return CustomerChangeBillDAO.Instance.delete(id);
        }

        public CustomerChangeBillDTO getById(string id)
        {
            return CustomerChangeBillDAO.Instance.getById(id);
        }
        public List<CustomerChangeBillDetailDTO> getCustomerChangeBillDetailList(string id)
        {
            return CustomerChangeBillDAO.Instance.getCustomerChangeBillDetailList(id);
        }

        public bool createCustomerChangeBillDetail(CustomerChangeBillDetailDTO customerChangeBillDetail)
        {
            return CustomerChangeBillDAO.Instance.createCustomerChangeBillDetail(customerChangeBillDetail);
        }
    }
}