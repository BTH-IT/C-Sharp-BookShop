using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.DAO
{
    public class ImportRefundBillDAO : IDAO<ImportRefundBillDTO>
    {
        private static ImportRefundBillDAO instance;

        public static ImportRefundBillDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ImportRefundBillDAO();
                }

                return ImportRefundBillDAO.instance;
            }
            private set { ImportRefundBillDAO.instance = value; }
        }
        public DataTable getAll() {
            return DataProvider.Instance.ExecuteQuery("select * from phieutranhaphang;");
        }

        public ImportRefundBillDetailDTO getImportRefundBillDetail(string billId, string bookId)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(
                "SELECT * FROM chitietphieutranhaphang WHERE maPhieuTraNhapHang=@maPhieuTraNhapHang AND maSach=@maSach;",
                new MySqlParameter[] {
                    new MySqlParameter("@maPhieuTraNhapHang", billId),
                    new MySqlParameter("@maSach", bookId)
                }
            );

            if (dataTable.Rows.Count <= 0) return null;

            ImportRefundBillDetailDTO customerBillDetail = new ImportRefundBillDetailDTO(dataTable.Rows[0]);

            return customerBillDetail;
        }

        public List<ImportRefundBillDetailDTO> getImportRefundBillDetailList(string billId)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(
                "SELECT * FROM chitietphieutranhaphang WHERE maPhieuTraNhapHang=@maPhieuTraNhapHang;",
                new MySqlParameter[] {
                    new MySqlParameter("@maPhieuTraNhapHang", billId),
                }
            );

            if (dataTable.Rows.Count <= 0) return null;

            List<ImportRefundBillDetailDTO> customerBillDetailList = new List<ImportRefundBillDetailDTO>();

            foreach (DataRow row in dataTable.Rows)
            {
                ImportRefundBillDetailDTO customerBillDetail = new ImportRefundBillDetailDTO(row);
                customerBillDetailList.Add(customerBillDetail);
            }

            return customerBillDetailList;
        }

        public DataTable searchData(string value)
        {
            string sql = $@"SELECT * FROM phieutranhaphang WHERE maPhieuTraNhapHang LIKE @maPhieuTraNhapHang;";

            return DataProvider.Instance.ExecuteQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maPhieuTraNhapHang", "%" + value + "%"),
                }
            );
        }

        public bool insert(ImportRefundBillDTO data)
        {

            string sql = $@"INSERT INTO phieutranhaphang (maDonNhapHang, liDo, tongTien, nhaCungCapDaTra, ngayLap, trangThai)
                            VALUES (@maDonNhapHang, @liDo, @tongTien, @nhaCungCapDaTra, @ngayLap, @trangThai);";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maDonNhapHang", data.MaDonNhapHang),
                    new MySqlParameter("@ngayLap", data.NgayLap),
                    new MySqlParameter("@liDo", data.LiDo),
                    new MySqlParameter("@tongTien", data.TongTien),
                    new MySqlParameter("@nhaCungCapDaTra", data.NhaCungCapDaTra),
                    new MySqlParameter("@trangThai", data.TrangThai),
                });

            return rowChanged > 0;
        }

        public ImportRefundBillDTO insertReturnBill(ImportRefundBillDTO data)
        {
            string sql = "SELECT * FROM phieutranhaphang ORDER BY maPhieuTraNhapHang DESC LIMIT 1;";
            if (this.insert(data))
            {

                DataTable dataTable = DataProvider.Instance.ExecuteQuery(sql);

                if (dataTable.Rows.Count <= 0) return null;

                ImportRefundBillDTO customerBill = new ImportRefundBillDTO(dataTable.Rows[0]);

                return customerBill;
            };

            return null;
        }

        public bool createImportRefundBillDetail(ImportRefundBillDetailDTO data)
        {
            string sql = $@"INSERT INTO chitietphieutranhaphang (maPhieuTraNhapHang, maSach, soLuong, donGia) 
                            VALUES (@maPhieuTraNhapHang, @maSach, @soLuong, @donGia);";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maPhieuTraNhapHang", data.MaDon),
                    new MySqlParameter("@maSach", data.MaSach),
                    new MySqlParameter("@soLuong", data.SoLuong),
                    new MySqlParameter("@donGia", data.DonGia),
                });

            return rowChanged > 0;
        }

        public bool update(ImportRefundBillDTO data)
        {
            string sql = $@"UPDATE phieutranhaphang SET 
                            maDonNhapHang=@maDonNhapHang, liDo=@liDo, ngayLap=@ngayLap, 
                            tongTien=@tongTien, nhaCungCapDaTra=@nhaCungCapDaTra, trangThai=@trangThai WHERE maPhieuTraNhapHang=@maPhieuTraNhapHang;";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maDonNhapHang", data.MaDonNhapHang),
                    new MySqlParameter("@ngayLap", data.NgayLap),
                    new MySqlParameter("@liDo", data.LiDo),
                    new MySqlParameter("@tongTien", data.TongTien),
                    new MySqlParameter("@nhaCungCapDaTra", data.NhaCungCapDaTra),
                    new MySqlParameter("@trangThai", data.TrangThai),
                    new MySqlParameter("@maPhieuTraNhapHang", data.MaPhieu),
                });

            return rowChanged > 0;
        }

        public bool delete(string id)
        {
            string sql = $@"DELETE FROM phieutranhaphang WHERE maPhieuTraNhapHang=@maPhieuTraNhapHang;";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maPhieuTraNhapHang", id),
                });

            return rowChanged > 0;
        }

        public ImportRefundBillDTO getById(string id)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(
                "SELECT * FROM phieutranhaphang WHERE maPhieuTraNhapHang=@maPhieuTraNhapHang;",
                new MySqlParameter[] {
                    new MySqlParameter("@maPhieuTraNhapHang", id),
                }
            );

            if (dataTable.Rows.Count <= 0) return null;

            ImportRefundBillDTO customerBill = new ImportRefundBillDTO(dataTable.Rows[0]);

            return customerBill;
        }
    }
}
