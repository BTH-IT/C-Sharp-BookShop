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

        public AccountDTO login(string email, string pwd)
        {
            AccountDTO account = this.getById(email);

            if (account == null) return null;

            if (!account.MatKhau.Equals(pwd)) return null;

            return account;
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

        public bool delete(AccountDTO account)
        {
            return AccountDAO.Instance.delete(account);
        }
    }
}
