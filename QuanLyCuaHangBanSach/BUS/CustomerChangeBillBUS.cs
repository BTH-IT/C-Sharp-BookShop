using System.Collections.Generic;
using System.Data;
using QuanLyCuaHangBanSach.DAO;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.BUS
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
            List<CustomerChangeBillDTO> importChangeBillList = new List<CustomerChangeBillDTO>();
            DataTable dt = CustomerChangeBillDAO.Instance.getAll();

            foreach (DataRow row in dt.Rows)
            {
                CustomerChangeBillDTO importChangeBill = new CustomerChangeBillDTO(row);
                importChangeBillList.Add(importChangeBill);
            }

            return importChangeBillList;
        }

        public List<CustomerChangeBillDTO> search(string value)
        {
            DataTable dataTable = CustomerChangeBillDAO.Instance.searchData(value);

            List<CustomerChangeBillDTO> importChangeBillList = new List<CustomerChangeBillDTO>();

            foreach (DataRow row in dataTable.Rows)
            {
                CustomerChangeBillDTO importChangeBill = new CustomerChangeBillDTO(row);
                importChangeBillList.Add(importChangeBill);
            }

            return importChangeBillList;
        }

        public bool insert(CustomerChangeBillDTO importChangeBill)
        {
            return CustomerChangeBillDAO.Instance.insert(importChangeBill);
        }

        public CustomerChangeBillDTO insertReturnBill(CustomerChangeBillDTO importChangeBill)
        {
            return CustomerChangeBillDAO.Instance.insertReturnBill(importChangeBill);
        }

        public bool update(CustomerChangeBillDTO importChangeBill)
        {
            return CustomerChangeBillDAO.Instance.update(importChangeBill);
        }

        public bool delete(string id)
        {
            return CustomerChangeBillDAO.Instance.delete(id);
        }

        public CustomerChangeBillDTO getById(string id)
        {
            return CustomerChangeBillDAO.Instance.getById(id);
        }
    }
}
