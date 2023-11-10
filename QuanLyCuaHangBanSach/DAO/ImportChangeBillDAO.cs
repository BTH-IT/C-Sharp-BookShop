using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using BookShop_CNPM.BUS;
using BookShop_CNPM.DTO;

namespace BookShop_CNPM.DAO
{
    public class ImportChangeBillDAO : IDAO<ImportChangeBillDTO>
    {
        private static ImportChangeBillDAO instance;

        public static ImportChangeBillDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ImportChangeBillDAO();
                }

                return ImportChangeBillDAO.instance;
            }
            private set { ImportChangeBillDAO.instance = value; }
        }

        public DataTable getAll()
        {
            return DataProvider.Instance.ExecuteQuery("select * from phieudoinhaphang;");
        }

        public DataTable searchData(string value)
        {
            string sql = $@"SELECT * FROM phieudoinhaphang WHERE maPhieuDoiNhapHang LIKE @maPhieuDoiNhapHang;";

            return DataProvider.Instance.ExecuteQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maPhieuDoiNhapHang", "%" + value + "%"),
                }
            );
        }

        public bool insert(ImportChangeBillDTO data)
        {

            string sql = $@"INSERT INTO phieudoinhaphang (maDonNhapHang, ngayLap, liDo, tinhTrangSanPham, maNhanVien)
                            VALUES (@maDonNhapHang, @ngayLap, @liDo, @tinhTrangSanPham, @maNhanVien);";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maDonNhapHang", data.MaDonNhapHang),
                    new MySqlParameter("@ngayLap", data.NgayLap),
                    new MySqlParameter("@liDo", data.LiDo),
                    new MySqlParameter("@tinhTrangSanPham", data.TinhTrangSanPham),
                    new MySqlParameter("@maNhanVien", data.MaNhanVien),
                });

            return rowChanged > 0;
        }

        public ImportChangeBillDTO insertReturnBill(ImportChangeBillDTO data)
        {
            string sql = "SELECT * FROM phieudoinhaphang ORDER BY maPhieuDoiNhapHang DESC LIMIT 1;";
            if (this.insert(data))
            {

                DataTable dataTable = DataProvider.Instance.ExecuteQuery(sql);

                if (dataTable.Rows.Count <= 0) return null;

                ImportChangeBillDTO importBill = new ImportChangeBillDTO(dataTable.Rows[0]);

                return importBill;
            };

            return null;
        }

        public bool update(ImportChangeBillDTO data)
        {
            string sql = $@"UPDATE phieudoinhaphang SET maDonNhapHang=@maDonNhapHang, ngayLap=@ngayLap, liDo=@liDo, tinhTrangSanPham=@tinhTrangSanPham,
                            maNhanVien=@maNhanVien WHERE maPhieuDoiNhapHang=@maPhieuDoiNhapHang;";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maDonNhapHang", data.MaDonNhapHang),
                    new MySqlParameter("@ngayLap", data.NgayLap),
                    new MySqlParameter("@liDo", data.LiDo),
                    new MySqlParameter("@tinhTrangSanPham", data.TinhTrangSanPham),
                    new MySqlParameter("@maPhieuDoiNhapHang", data.MaPhieu),
                });

            return rowChanged > 0;
        }

        public bool delete(string id)
        {
            string sql = $@"DELETE FROM phieudoinhaphang WHERE maPhieuDoiNhapHang=@maPhieuDoiNhapHang;";
            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maPhieuDoiNhapHang", id),
                });

            string sql2 = $@"DELETE FROM chitietdoinhaphang WHERE maPhieuDoiNhapHang=@maPhieuDoiNhapHang;";
            int rowChangeddetail = DataProvider.Instance.ExecuteNonQuery(sql2,
                new MySqlParameter[] {
                    new MySqlParameter("@maPhieuDoiNhapHang", id),
                });

            return rowChanged > 0;
        }

        public ImportChangeBillDTO getById(string id)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(
                "SELECT * FROM phieudoinhaphang WHERE maPhieuDoiNhapHang=@maPhieuDoiNhapHang;",
                new MySqlParameter[] {
                    new MySqlParameter("@maPhieuDoiNhapHang", id),
                }
            );

            if (dataTable.Rows.Count <= 0) return null;

            ImportChangeBillDTO importBill = new ImportChangeBillDTO(dataTable.Rows[0]);

            return importBill;
        }
        public List<ImportChangeBillDetailDTO> getImportChangeBillDetailList(string billId)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(
                "SELECT * FROM chitietdoinhaphang WHERE maPhieuDoiNhapHang=@maPhieuDoiNhapHang;",
                new MySqlParameter[] {
                    new MySqlParameter("@maPhieuDoiNhapHang", billId),
                }
            );

            if (dataTable.Rows.Count <= 0) return null;

            List<ImportChangeBillDetailDTO> importChangeBillDetailList = new List<ImportChangeBillDetailDTO>();

            foreach (DataRow row in dataTable.Rows)
            {
                ImportChangeBillDetailDTO importChangeBillDetail = new ImportChangeBillDetailDTO(row);
                importChangeBillDetailList.Add(importChangeBillDetail);
            }

            return importChangeBillDetailList;
        }
        public bool createImportChangeBillDetail(ImportChangeBillDetailDTO data)
        {
            string sql = $@"INSERT INTO chitietdoinhaphang (maPhieuDoiNhapHang, maSachCanDoi, maSachMuonDoi, soLuong) 
                            VALUES (@maPhieuDoiNhapHang, @maSachCanDoi, @maSachMuonDoi, @soLuong);";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maPhieuDoiNhapHang", data.MaDon),
                    new MySqlParameter("@maSachCanDoi", data.SachCanDoi),
                    new MySqlParameter("@maSachMuonDoi", data.SachMuonDoi),
                    new MySqlParameter("@soLuong", data.soLuong),
                });
            if (rowChanged > 0)
            {
                 BookBUS.Instance.deleteBookAmount(data.SachCanDoi.ToString(), data.soLuong);
                 BookBUS.Instance.createBookAmount(data.SachMuonDoi.ToString(), data.soLuong);
            }

            return rowChanged > 0;
        }
    }
}