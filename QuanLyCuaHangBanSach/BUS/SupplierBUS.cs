using System.Collections.Generic;
using System.Data;
using QuanLyCuaHangBanSach.DAO;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.BUS
{
    public class SupplierBUS : IBUS<SupplierDTO>
    {
        private static SupplierBUS instance;

        public static SupplierBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SupplierBUS();
                }

                return SupplierBUS.instance;
            }
            private set { SupplierBUS.instance = value; }
        }

        public DataTable getAll()
        {
            return SupplierDAO.Instance.getAll();
        }

        public List<SupplierDTO> search(string value)
        {
            List<SupplierDTO> supplierList = new List<SupplierDTO>();
            DataTable dt = SupplierDAO.Instance.searchData(value);

            foreach (DataRow row in dt.Rows)
            {
                SupplierDTO supplier = new SupplierDTO(row);
                supplierList.Add(supplier);
            }

            return supplierList;
        }

        public List<SupplierDTO> getAllData()
        {
            List<SupplierDTO> supplierList = new List<SupplierDTO>();
            DataTable dt = SupplierDAO.Instance.getAll();

            foreach (DataRow row in dt.Rows)
            {
                SupplierDTO supplier = new SupplierDTO(row);
                supplierList.Add(supplier);
            }

            return supplierList;
        }

        public SupplierDTO getById(string id)
        {
            return SupplierDAO.Instance.getById(id);
        }

        public bool insert(SupplierDTO supplier)
        {
            return SupplierDAO.Instance.insert(supplier);
        }

        public bool update(SupplierDTO supplier)
        {
            return SupplierDAO.Instance.update(supplier);
        }

        public bool delete(string id)
        {
            return SupplierDAO.Instance.delete(id);
        }
    }
}
