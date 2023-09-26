using System.Collections.Generic;
using System.Data;
using QuanLyCuaHangBanSach.DAO;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.BUS
{
    public class ImportChangeBillBUS : IBUS<ImportChangeBillDTO>
    {
        private static ImportChangeBillBUS instance;

        public static ImportChangeBillBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ImportChangeBillBUS();
                }

                return ImportChangeBillBUS.instance;
            }
            private set { ImportChangeBillBUS.instance = value; }
        }

        public DataTable getAll()
        {
            return ImportChangeBillDAO.Instance.getAll();
        }

        public List<ImportChangeBillDTO> getAllData()
        {
            List<ImportChangeBillDTO> importChangeBillList = new List<ImportChangeBillDTO>();
            DataTable dt = ImportChangeBillDAO.Instance.getAll();

            foreach (DataRow row in dt.Rows)
            {
                ImportChangeBillDTO importChangeBill = new ImportChangeBillDTO(row);
                importChangeBillList.Add(importChangeBill);
            }

            return importChangeBillList;
        }

        public List<ImportChangeBillDTO> search(string value)
        {
            DataTable dataTable = ImportChangeBillDAO.Instance.searchData(value);

            List<ImportChangeBillDTO> importChangeBillList = new List<ImportChangeBillDTO>();

            foreach (DataRow row in dataTable.Rows)
            {
                ImportChangeBillDTO importChangeBill = new ImportChangeBillDTO(row);
                importChangeBillList.Add(importChangeBill);
            }

            return importChangeBillList;
        }

        public bool insert(ImportChangeBillDTO importChangeBill)
        {
            return ImportChangeBillDAO.Instance.insert(importChangeBill);
        }

        public ImportChangeBillDTO insertReturnBill(ImportChangeBillDTO importChangeBill)
        {
            return ImportChangeBillDAO.Instance.insertReturnBill(importChangeBill);
        }

        public bool update(ImportChangeBillDTO importChangeBill)
        {
            return ImportChangeBillDAO.Instance.update(importChangeBill);
        }

        public bool delete(string id)
        {
            return ImportChangeBillDAO.Instance.delete(id);
        }

        public ImportChangeBillDTO getById(string id)
        {
            return ImportChangeBillDAO.Instance.getById(id);
        }
    }
}
