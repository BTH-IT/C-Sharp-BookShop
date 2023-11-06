﻿using System;
using System.Collections.Generic;
using System.Data;
using QuanLyCuaHangBanSach.DAO;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.BUS
{
    public class StaffBUS : IBUS<StaffDTO>
    {
        private static StaffBUS instance;

        public static StaffBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new StaffBUS();
                }

                return StaffBUS.instance;
            }
            private set { StaffBUS.instance = value; }
        }

        public DataTable getAll()
        {
            return StaffDAO.Instance.getAll();
        }

        public List<StaffDTO> getAllData()
        {
            List<StaffDTO> customerList = new List<StaffDTO>();
            DataTable dt = StaffDAO.Instance.getAll();

            foreach (DataRow row in dt.Rows)
            {
                StaffDTO customer = new StaffDTO(row);
                customerList.Add(customer);
            }

            return customerList;
        }

        public List<StaffDTO> getAllNoAccount()
        {
            List<StaffDTO> customerList = new List<StaffDTO>();
            DataTable dt = StaffDAO.Instance.getAllNoAccount();

            foreach (DataRow row in dt.Rows)
            {
                StaffDTO customer = new StaffDTO(row);
                customerList.Add(customer);
            }

            return customerList;
        }

        public StaffDTO getById(string id)
        {
            return StaffDAO.Instance.getById(id);
        }

		public double getSoldRevenue(string id)
        {
			return StaffDAO.Instance.getSoldRevenue(id);
		}

		public List<StaffDTO> search(string value)
        {
            return StaffDAO.Instance.searchData(value);
        }

        public bool insert(StaffDTO customer)
        {
            return StaffDAO.Instance.insert(customer);
        }

        public bool update(StaffDTO customer)
        {
            return StaffDAO.Instance.update(customer);
        }

        public bool delete(string id)
        {
            return StaffDAO.Instance.delete(id);
        }
    }
}
