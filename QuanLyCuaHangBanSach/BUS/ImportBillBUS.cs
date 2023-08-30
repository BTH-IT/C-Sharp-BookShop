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
    public class ImportBillBUS : IBUS<ImportBillDTO>
    {
        private static ImportBillBUS instance;

        public static ImportBillBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ImportBillBUS();
                }

                return ImportBillBUS.instance;
            }
            private set { ImportBillBUS.instance = value; }
        }

        public DataTable getAll()
        {
            return ImportBillDAO.Instance.getAll();
        }

        public List<ImportBillDTO> getAllData()
        {
            List<ImportBillDTO> importBillList = new List<ImportBillDTO>();
            DataTable dt = ImportBillDAO.Instance.getAll();

            foreach (DataRow row in dt.Rows)
            {
                ImportBillDTO importBill = new ImportBillDTO(row);
                importBillList.Add(importBill);
            }

            return importBillList;
        }

        public ImportBillDTO getById(string id)
        {
            return ImportBillDAO.Instance.getById(id);
        }

        public List<ImportBillDTO> search(string id)
        {
            DataTable dataTable = ImportBillDAO.Instance.searchData(id);

            List<ImportBillDTO> importBillList = new List<ImportBillDTO>();

            foreach (DataRow row in dataTable.Rows)
            {
                ImportBillDTO importBill = new ImportBillDTO(row);
                importBillList.Add(importBill);
            }

            return importBillList;
        }

        public bool insert(ImportBillDTO importBill)
        {
            return ImportBillDAO.Instance.insert(importBill);
        }

        public bool update(ImportBillDTO importBill)
        {
            return ImportBillDAO.Instance.update(importBill);
        }

        public bool delete(string id)
        {
            return ImportBillDAO.Instance.delete(id);
        }
    }
}
