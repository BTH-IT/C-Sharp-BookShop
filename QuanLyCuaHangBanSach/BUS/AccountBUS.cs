using System.Collections.Generic;
using System.Data;
using QuanLyCuaHangBanSach.DAO;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.BUS
{
    public class AccountBUS : IBUS<AccountDTO>
    {
        private static AccountBUS instance;

        public static AccountBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AccountBUS();
                }

                return AccountBUS.instance;
            }
            private set { AccountBUS.instance = value; }
        }

        public DataTable getAll()
        {
            return AccountDAO.Instance.getAll();
        }

        public AccountDTO getByStaffId(string id)
        {
            return AccountDAO.Instance.getByStaffId(id);
        }

        public AccountDTO login(string email, string pwd)
        {
            AccountDTO account = this.getById(email);

            if (account == null) return null;

            if (!account.MatKhau.Equals(pwd)) return null;

            return account;
        }

        public bool checkDuplicateName(string value)
        {
            return AccountDAO.Instance.checkDuplicateName(value);
        }

        public bool resetPassword(string email, string pwd)
        {
            AccountDTO account = this.getById(email);

            if (account == null) return false;

            account.MatKhau = pwd;

            return this.update(account);
        }

        public List<AccountDTO> getAllData()
        {
            List<AccountDTO> accountList = new List<AccountDTO>();
            DataTable dt = AccountDAO.Instance.getAll();

            foreach (DataRow row in dt.Rows)
            {
                AccountDTO account = new AccountDTO(row);
                accountList.Add(account);
            }

            return accountList;
        }
        public List<AccountDTO> search(string searchInput) 
        { 
            List<AccountDTO> accounts = new List<AccountDTO>();  
            DataTable dt =AccountDAO.Instance.search(searchInput);
            if (dt == null) return accounts;    
            foreach(DataRow row in dt.Rows)
            {
                AccountDTO account = new AccountDTO(row);
                accounts.Add(account);
            }
            return accounts;
        }
        public AccountDTO getById(string id)
        {
            return AccountDAO.Instance.getById(id);
        }

        public bool insert(AccountDTO account)
        {
            return AccountDAO.Instance.insert(account);
        }

        public bool update(AccountDTO account)
        {
            return AccountDAO.Instance.update(account);
        }

        public bool delete(string id)
        {
            return AccountDAO.Instance.delete(id);
        }
    }
}
