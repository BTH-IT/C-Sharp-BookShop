using System.Collections.Generic;
using System.Data;
using QuanLyCuaHangBanSach.DAO;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.BUS
{
    public class CustomerTypeBUS : IBUS<CustomerTypeDTO>
    {
        private static CustomerTypeBUS instance;

        public static CustomerTypeBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CustomerTypeBUS();
                }

                return CustomerTypeBUS.instance;
            }
            private set { CustomerTypeBUS.instance = value; }
        }

        public DataTable getAll()
        {
            return CustomerTypeDAO.Instance.getAll();
        }

        public List<CustomerTypeDTO> getAllData()
        {
            List<CustomerTypeDTO> customerTypeList = new List<CustomerTypeDTO>();
            DataTable dt = CustomerTypeDAO.Instance.getAll();

            foreach (DataRow row in dt.Rows)
            {
                CustomerTypeDTO customerType = new CustomerTypeDTO(row);
                customerTypeList.Add(customerType);
            }

            return customerTypeList;
        }

        public CustomerTypeDTO getById(string id)
        {
            return CustomerTypeDAO.Instance.getById(id);
        }

        public bool insert(CustomerTypeDTO customerType)
        {
            return CustomerTypeDAO.Instance.insert(customerType);
        }

        public bool update(CustomerTypeDTO customerType)
        {
            return CustomerTypeDAO.Instance.update(customerType);
        }

        public bool delete(string id)
        {
            return CustomerTypeDAO.Instance.delete(id);
        }
    }
}
