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

        public List<AuthorDTO> search(string value)
        {
            List<AuthorDTO> bookList = new List<AuthorDTO>();
            DataTable dt = AuthorDAO.Instance.searchData(value);

            foreach (DataRow row in dt.Rows)
            {
                AuthorDTO book = new AuthorDTO(row);
                bookList.Add(book);
            }

            return bookList;
        }

        public List<AuthorDTO> getAllData()
        {
            List<AuthorDTO> bookList = new List<AuthorDTO>();
            DataTable dt = AuthorDAO.Instance.getAll();

            foreach (DataRow row in dt.Rows)
            {
                AuthorDTO book = new AuthorDTO(row);
                bookList.Add(book);
            }

            return bookList;
        }

        public AuthorDTO getById(string id)
        {
            return AuthorDAO.Instance.getById(id);
        }

        public bool insert(AuthorDTO book)
        {
            return AuthorDAO.Instance.insert(book);
        }

        public bool update(AuthorDTO book)
        {
            return AuthorDAO.Instance.update(book);
        }

        public bool delete(string id)
        {
            return AuthorDAO.Instance.delete(id);
        }
    }
}
