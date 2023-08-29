﻿using System.Collections.Generic;
using System.Data;
using QuanLyCuaHangBanSach.DAO;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.BUS
{
    public class BookBUS : IBUS<BookDTO>
    {
        private static BookBUS instance;

        public static BookBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BookBUS();
                }

                return BookBUS.instance;
            }
            private set { BookBUS.instance = value; }
        }

        public DataTable getAll()
        {
            return BookDAO.Instance.getAll();
        }

        public List<BookDTO> search(string value)
        {
            List<BookDTO> bookList = new List<BookDTO>();
            DataTable dt = BookDAO.Instance.searchData(value);

            foreach (DataRow row in dt.Rows)
            {
                BookDTO book = new BookDTO(row);
                bookList.Add(book);
            }

            return bookList;
        }

        public List<BookDTO> getAllData()
        {
            List<BookDTO> bookList = new List<BookDTO>();
            DataTable dt = BookDAO.Instance.getAll();

            foreach (DataRow row in dt.Rows)
            {
                BookDTO book = new BookDTO(row);
                bookList.Add(book);
            }

            return bookList;
        }

        public BookDTO getById(string id)
        {
            return BookDAO.Instance.getById(id);
        }

        public bool insert(BookDTO book)
        {
            return BookDAO.Instance.insert(book);
        }

        public bool update(BookDTO book)
        {
            return BookDAO.Instance.update(book);
        }

        public bool delete(string id)
        {
            return BookDAO.Instance.delete(id);
        }
    }
}