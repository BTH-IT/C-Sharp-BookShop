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

        public List<CustomerBillDetailDTO> getCustomerBillDetailList(string id)
        {
            return CustomerBillDAO.Instance.getCustomerBillDetailList(id);
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

        public bool updateBillAndBillDetail(CustomerBillDTO customerBill, List<CustomerBillDetailDTO> customerBillDetailList)
        {
            try
            {
                if (CustomerBillDAO.Instance.update(customerBill))
                {
                    List<CustomerBillDetailDTO> oldCustomerBillDetailList = CustomerBillDAO.Instance.getCustomerBillDetailList(customerBill.MaDonKhachHang.ToString());

                    oldCustomerBillDetailList = oldCustomerBillDetailList.FindAll(
                        (oldCustomerBillDetail) =>
                        {
                            foreach (CustomerBillDetailDTO customerBillDetail in customerBillDetailList)
                            {
                                if (customerBillDetail.MaDon == oldCustomerBillDetail.MaDon
                                    && customerBillDetail.MaSach == oldCustomerBillDetail.MaSach
                                )
                                {
                                    return false;
                                }
                            }

                            return true;
                        }
                    );

                    foreach (CustomerBillDetailDTO customerBillDetail in customerBillDetailList)
                    {
                        if (CustomerBillDAO.Instance.getCustomerBillDetail(
                            customerBillDetail.MaDon.ToString(),
                            customerBillDetail.MaSach.ToString()
                         ) == null)
                        {
                            CustomerBillDAO.Instance.createCustomerBillDetail(customerBillDetail);
                            continue;
                        }

                        CustomerBillDAO.Instance.updateCustomerBillDetail(customerBillDetail);
                    }

                    foreach (CustomerBillDetailDTO customerBillDetail in oldCustomerBillDetailList)
                    {
                        CustomerBillDAO.Instance.deleteCustomerBillDetail(customerBillDetail.MaDon.ToString(), customerBillDetail.MaSach.ToString());
                    }
                }

                return true;
            } catch
            {
                return false;
            }
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
