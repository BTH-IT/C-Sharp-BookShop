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
    public class CustomerBUS : IBUS<CustomerDTO>
    {
        private static CustomerBUS instance;

        public static CustomerBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CustomerBUS();
                }

                return CustomerBUS.instance;
            }
            private set { CustomerBUS.instance = value; }
        }

        public DataTable getAll()
        {
            return CustomerDAO.Instance.getAll();
        }

        public List<CustomerDTO> getAllData()
        {
            List<CustomerDTO> customerList = new List<CustomerDTO>();
            DataTable dt = CustomerDAO.Instance.getAll();

            foreach (DataRow row in dt.Rows)
            {
                CustomerDTO customer = new CustomerDTO(row);
                customerList.Add(customer);
            }

            return customerList;
        }

        public CustomerDTO getById(string id)
        {
            return CustomerDAO.Instance.getById(id);
        }
        public List<CustomerDTO> SearchByPhoneNum(string num)
        {
            return CustomerDAO.Instance.SearchByPhoneNum(num);
        }

        public bool insert(CustomerDTO customer)
        {
            return CustomerDAO.Instance.insert(customer);
        }

        public bool update(CustomerDTO customer)
        {
            return CustomerDAO.Instance.update(customer);
        }

        public bool delete(CustomerDTO customer)
        {
            return CustomerDAO.Instance.delete(customer);
        }
    }
}
