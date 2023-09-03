﻿using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.DAO
{
    public class CustomerDAO : IDAO<CustomerDTO>
    {
        private static CustomerDAO instance;

        public static CustomerDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CustomerDAO();
                }

                return CustomerDAO.instance;
            }
            private set { CustomerDAO.instance = value; }
        }

        
        public DataTable getAll() {
            return DataProvider.Instance.ExecuteQuery("SELECT * from khachhang WHERE hienthi=1");
        }

        public CustomerDTO getById(string id)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(
                "SELECT * FROM khachhang WHERE maKhachHang=@MaKhachHang AND hienthi=1",
                new MySqlParameter[] { new MySqlParameter("@MaKhachHang", id) }
            );

            if (dataTable.Rows.Count <= 0) return null;

            CustomerDTO customer = new CustomerDTO(dataTable.Rows[0]);

            return customer;
        }

        public List<CustomerDTO> SearchByPhoneNum(string num)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(
                "SELECT * FROM khachhang WHERE soDienThoai LIKE @SoDienThoai AND hienthi=1",
                new MySqlParameter[] { new MySqlParameter("@SoDienThoai", $"%{num}%") }
            );

            if (dataTable.Rows.Count <= 0) return null;

            List<CustomerDTO> customers = new List<CustomerDTO>();

            foreach (DataRow row in dataTable.Rows)
            {
                CustomerDTO customer = new CustomerDTO(row);
                customers.Add(customer);
            }

            return customers;
        }

        public bool insert(CustomerDTO data)
        {

            string sql = $@"INSERT INTO khachhang (maKhachHang, tenKhachHang, soDienThoai, gioiTinh, namSinh, hienThi)
                            VALUES (@MaKhachHang, @TenKhachHang, @SoDienThoai, @GioiTinh, @NamSinh, 1);";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@MaKhachHang", data.MaKhachHang),
                    new MySqlParameter("@TenKhachHang", data.TenKhachHang),
                    new MySqlParameter("@SoDienThoai", data.SoDienThoai),
                    new MySqlParameter("@GioiTinh", data.GioiTinh),
                    new MySqlParameter("@NamSinh", data.NamSinh),
                });

            return rowChanged > 0;
        }

        public bool update(CustomerDTO data)
        {
            string sql = $@"UPDATE khachhang SET maKhachHang=@MaKhachHang, tenKhachHang=@TenKhachHang, gioiTinh=@GioiTinh, namSinh=@NamSinh
                            WHERE soDienThoai=@SoDienThoai;";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@MaKhachHang", data.MaKhachHang),
                    new MySqlParameter("@TenKhachHang", data.TenKhachHang),
                    new MySqlParameter("@SoDienThoai", data.SoDienThoai),
                    new MySqlParameter("@GioiTinh", data.GioiTinh),
                    new MySqlParameter("@NamSinh", data.NamSinh),
                });

            return rowChanged > 0;
        }

        public bool delete(string id)
        {
            string sql = $@"UPDATE khachhang SET hienThi = 0 WHERE soDienThoai=@SoDienThoai;";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@SoDienThoai", id),
                });

            return rowChanged > 0;
        }
    }
}