using System;
using System.Collections.Generic;
using System.Data;
using QuanLyCuaHangBanSach.DAO;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.BUS
{
    public class AuthorBUS : IBUS<AuthorDTO>
    {
        private static AuthorBUS instance;

        public static AuthorBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AuthorBUS();
                }

                return AuthorBUS.instance;
            }
            private set { AuthorBUS.instance = value; }
        }

        public DataTable getAll()
        {
            return AuthorDAO.Instance.getAll();
        }

        public bool checkDuplicateName(string value)
        {
            return AuthorDAO.Instance.checkDuplicateName(value);
        }

        public List<AuthorDTO> search(string value)
        {
            List<AuthorDTO> authorList = new List<AuthorDTO>();
            DataTable dt = AuthorDAO.Instance.searchData(value);

            foreach (DataRow row in dt.Rows)
            {
                AuthorDTO author = new AuthorDTO(row);
                authorList.Add(author);
            }

            return authorList;
        }

        public List<AuthorDTO> getAllData()
        {
            List<AuthorDTO> authorList = new List<AuthorDTO>();
            DataTable dt = AuthorDAO.Instance.getAll();

            foreach (DataRow row in dt.Rows)
            {
                AuthorDTO author = new AuthorDTO(row);
                authorList.Add(author);
            }

            return authorList;
        }

        public AuthorDTO getById(string id)
        {
            return AuthorDAO.Instance.getById(id);
        }

        public bool insert(AuthorDTO author)
        {
            return AuthorDAO.Instance.insert(author);
        }

        public bool update(AuthorDTO author)
        {
            return AuthorDAO.Instance.update(author);
        }

        public bool delete(string id)
        {
            return AuthorDAO.Instance.delete(id);
        }
    }
}
