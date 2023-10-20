﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Markup;
using MySql.Data.MySqlClient;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.DAO
{
    public class PermissionDAO : IDAO<PermissionDTO>
    {
        private static PermissionDAO instance;

        public static PermissionDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PermissionDAO();
                }

                return PermissionDAO.instance;
            }
            private set { PermissionDAO.instance = value; }
        }

        
        public DataTable getAll() {
            return DataProvider.Instance.ExecuteQuery("select * from quyenhang;");
        }

        public PermissionDTO getById(string id)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(
                "SELECT * FROM quyenhang WHERE maQuyenHang=@maQuyenHang;",
                new MySqlParameter[] {
                    new MySqlParameter("@maQuyenHang", id)
                }
            );

            if (dataTable.Rows.Count <= 0) return null;

            PermissionDTO account = new PermissionDTO(dataTable.Rows[0]);

            return account;
        }
        
        public DataTable searchData(string value)
        {
            string sql = $@"SELECT * FROM quyenhang 
                            WHERE (maQuyenHang LIKE @maQuyenHang OR tenQuyenHang LIKE @tenQuyenHang);";

            return DataProvider.Instance.ExecuteQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maQuyenHang", "%" + value + "%"),
                    new MySqlParameter("@tenQuyenHang", "%" + value + "%")
                }
            );
        }

        public bool insert(PermissionDTO data)
        {

            string sql = $@"INSERT INTO quyenhang (tenQuyenHang, trangThai)
                            VALUES (@tenQuyenHang, @trangThai);";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@tenQuyenHang", data.TenQuyenHang),
                    new MySqlParameter("@trangThai", data.TrangThai),
                });

            if (rowChanged > 0)
            {
                List<PositionDTO> positionList = PositionBUS.Instance.getAllData();

                sql = $@"INSERT INTO chitietphanquyen (maChucVu, maQuyenHang)
                            VALUES (@maChucVu, @maQuyenHang);";

                foreach (PositionDTO position in positionList)
                {
                    DataProvider.Instance.ExecuteNonQuery(sql,
                    new MySqlParameter[] {
                        new MySqlParameter("@maChucVu", position.MaChucVu),
                        new MySqlParameter("@maQuyenHang", data.MaQuyenHang),
                    });
                }
            }

            return rowChanged > 0;
        }

        public bool update(PermissionDTO data)
        {
            string sql = $@"UPDATE quyenhang
                            SET tenQuyenHang=@tenQuyenHang, trangThai=@trangThai
                            WHERE maQuyenHang=@maQuyenHang;";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maQuyenHang", data.MaQuyenHang),
                    new MySqlParameter("@tenQuyenHang", data.TenQuyenHang),
                    new MySqlParameter("@trangThai", data.TrangThai)
                });

            return rowChanged > 0;
        }

        public bool delete(string id)
        {
            string sql = $@"DELETE FROM quyenhang WHERE maQuyenHang=@maQuyenHang;";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maQuyenHang", id),
                });

            /*if (rowChanged > 0)
            {
                List<PositionDTO> positionList = PositionBUS.Instance.getAllData();

                sql = $@"UPDATE chitietphanquyen SET hienThi = 0 WHERE maChucVu=@maChucVu AND maQuyenHang=@maQuyenHang;";

                foreach (PositionDTO position in positionList)
                {
                    DataProvider.Instance.ExecuteNonQuery(sql,
                    new MySqlParameter[] {
                        new MySqlParameter("@maChucVu", position.MaChucVu),
                        new MySqlParameter("@maQuyenHang", id),
                    });
                }
            }*/

            return rowChanged > 0;
        }
    }
}
