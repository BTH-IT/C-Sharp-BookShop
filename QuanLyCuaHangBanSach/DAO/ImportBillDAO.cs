﻿using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.DAO
{
    public class ImportBillDAO : IDAO<ImportBillDTO>
    {
        private static ImportBillDAO instance;

        public static ImportBillDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ImportBillDAO();
                }

                return ImportBillDAO.instance;
            }
            private set { ImportBillDAO.instance = value; }
        }

        
        public DataTable getAll() {
            return DataProvider.Instance.ExecuteQuery("select * from phieunhap WHERE hienThi = 1;");
        }

        public ImportBillDetailDTO getImportBillDetail(string billId, string bookId)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(
                "SELECT * FROM chitietphieunhap WHERE maDonNhapHang=@maDonNhapHang AND maSach=@maSach;",
                new MySqlParameter[] {
                    new MySqlParameter("@maDonNhapHang", billId),
                    new MySqlParameter("@maSach", bookId)
                }
            );

            if (dataTable.Rows.Count <= 0) return null;

            ImportBillDetailDTO importBillDetail = new ImportBillDetailDTO(dataTable.Rows[0]);

            return importBillDetail;
        }

        public List<ImportBillDetailDTO> getImportBillDetailList(string billId)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(
                "SELECT * FROM chitietphieunhap WHERE maDonNhapHang=@maDonNhapHang;",
                new MySqlParameter[] {
                    new MySqlParameter("@maDonNhapHang", billId),
                }
            );

            if (dataTable.Rows.Count <= 0) return null;

            List<ImportBillDetailDTO> importBillDetailList = new List<ImportBillDetailDTO>();

            foreach (DataRow row in dataTable.Rows)
            {
                ImportBillDetailDTO importBillDetail = new ImportBillDetailDTO(row);
                importBillDetailList.Add(importBillDetail);
            }

            return importBillDetailList;
        }

        public DataTable searchData(string value)
        {
            string sql = $@"SELECT * FROM phieunhap WHERE maDonNhapHang LIKE @maDonNhapHang AND hienThi = 1;";

            return DataProvider.Instance.ExecuteQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maDonNhapHang", "%" + value + "%"),
                }
            );
        }

        public bool createImportBillDetail(ImportBillDetailDTO data)
        {
            string sql = $@"INSERT INTO chitietphieunhap (maDonNhapHang, maSach, soLuong, donGia) 
                            VALUES (@maDonNhapHang, @maSach, @soLuong, @donGia);";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maDonNhapHang", data.MaDon),
                    new MySqlParameter("@maSach", data.MaSach),
                    new MySqlParameter("@soLuong", data.SoLuong),
                    new MySqlParameter("@donGia", data.DonGia),
                });

            // xóa số lượng còn lại của sách
            if (rowChanged > 0)
            {
                BookDTO book = BookBUS.Instance.getById(data.MaSach.ToString());

                book.SoLuongConLai += data.SoLuong;

                return BookBUS.Instance.update(book);
            }

            return rowChanged > 0;
        }

        public bool insert(ImportBillDTO data)
        {

            string sql = $@"INSERT INTO phieunhap (maNhanVien, maNhaCungCap, ngayLap, tongTien)
                            VALUES (@maNhanVien, @maNhaCungCap, @ngayLap, @tongTien);";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maNhaCungCap", data.MaNhaCungCap),
                    new MySqlParameter("@maNhanVien", data.MaNhanVien),
                    new MySqlParameter("@ngayLap", data.NgayLap),
                    new MySqlParameter("@tongTien", data.TongTien),
                });

            return rowChanged > 0;
        }

        public ImportBillDTO insertReturnBill(ImportBillDTO data)
        {
            string sql = "SELECT * FROM phieunhap ORDER BY maDonNhapHang DESC LIMIT 1;";
            if (this.insert(data)) {

                DataTable dataTable = DataProvider.Instance.ExecuteQuery(sql);

                if (dataTable.Rows.Count <= 0) return null;

                ImportBillDTO importBill = new ImportBillDTO(dataTable.Rows[0]);

                return importBill;
            };

            return null;
        }

        public bool update(ImportBillDTO data)
        {
            string sql = $@"UPDATE phieunhap SET 
                            maNhaCungCap=@maNhaCungCap, maNhanVien=@maNhanVien, ngayLap=@ngayLap, 
                            tongTien=@tongTien WHERE maDonNhapHang=@maDonNhapHang;";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maNhaCungCap", data.MaNhaCungCap),
                    new MySqlParameter("@maNhanVien", data.MaNhanVien),
                    new MySqlParameter("@ngayLap", data.NgayLap),
                    new MySqlParameter("@tongTien", data.TongTien),
                    new MySqlParameter("@maDonNhapHang", data.MaDonNhapHang),
                });

            return rowChanged > 0;
        }

        public bool delete(string id)
        {
            string sql = $@"UPDATE phieunhap SET hienThi = 0 WHERE maDonNhapHang=@maDonNhapHang;";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maDonNhapHang", id),
                });

            return rowChanged > 0;
        }

        public ImportBillDTO getById(string id)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(
                "SELECT * FROM phieunhap WHERE maDonNhapHang=@maDonNhapHang;",
                new MySqlParameter[] {
                    new MySqlParameter("@maDonNhapHang", id),
                }
            );

            if (dataTable.Rows.Count <= 0) return null;

            ImportBillDTO importBill = new ImportBillDTO(dataTable.Rows[0]);

            return importBill;
        }
    }
}
