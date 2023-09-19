using System.Data;
using MySql.Data.MySqlClient;
using QuanLyCuaHangBanSach.DTO;

namespace QuanLyCuaHangBanSach.DAO
{
    public class PaymentBillDAO : IDAO<PaymentBillDTO>
    {
        private static PaymentBillDAO instance;

        public static PaymentBillDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PaymentBillDAO();
                }

                return PaymentBillDAO.instance;
            }
            private set { PaymentBillDAO.instance = value; }
        }

        public DataTable getAll() {
            return DataProvider.Instance.ExecuteQuery("select * from phieuchi;");
        }

        public DataTable searchData(string value)
        {
            string sql = $@"SELECT * FROM phieuchi WHERE maPhieuChi LIKE @value OR maNhanVien LIKE @value OR maDonNhapHang LIKE @value;";

            return DataProvider.Instance.ExecuteQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@value", "%" + value + "%"),
                }
            );
        }

        public bool insert(PaymentBillDTO data)
        {

            string sql = $@"INSERT INTO phieuchi (maNhanVien, maDonNhapHang, ngayLap, liDo, ghiChu, tongTienChi)
                            VALUES (@maNhanVien, @maDonNhapHang, @ngayLap, @liDo, @ghiChu, @tongTienChi);";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maNhanVien", data.MaNhanVien),
                    new MySqlParameter("@maDonNhapHang", data.MaDonNhapHang),
                    new MySqlParameter("@ngayLap", data.NgayLap),
                    new MySqlParameter("@liDo", data.LiDo),
                    new MySqlParameter("@ghiChu", data.GhiChu),
                    new MySqlParameter("@tongTienChi", data.TongTien),
                });

            if (rowChanged > 0)
            {
                ImportBillDTO importBill = ImportBillDAO.Instance.getById(data.MaDonNhapHang.ToString());

                importBill.DaTra += data.TongTien;

                return ImportBillDAO.Instance.update(importBill);
            }

            return rowChanged > 0;
        }

        public PaymentBillDTO insertReturnBill(PaymentBillDTO data)
        {
            string sql = "SELECT * FROM phieuchi ORDER BY maPhieuChi DESC LIMIT 1;";
            if (this.insert(data))
            {

                DataTable dataTable = DataProvider.Instance.ExecuteQuery(sql);

                if (dataTable.Rows.Count <= 0) return null;

                PaymentBillDTO customerBill = new PaymentBillDTO(dataTable.Rows[0]);

                return customerBill;
            };

            return null;
        }

        public bool update(PaymentBillDTO data)
        {
            string sql = $@"UPDATE phieuchi SET 
                            maNhanVien=@maNhanVien, maDonNhapHang=@maDonNhapHang, liDo=@liDo, ghiChu=@ghiChu, ngayLap=@ngayLap, 
                            tongTienChi=@tongTienChi WHERE maPhieuChi=@maPhieuChi;";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maNhanVien", data.MaNhanVien),
                    new MySqlParameter("@maDonNhapHang", data.MaDonNhapHang),
                    new MySqlParameter("@liDo", data.LiDo),
                    new MySqlParameter("@ngayLap", data.NgayLap),
                    new MySqlParameter("@tongTienChi", data.TongTien),
                    new MySqlParameter("@maPhieuChi", data.MaPhieu),
                });

            return rowChanged > 0;
        }

        public bool delete(string id)
        {
            PaymentBillDTO paymentBill = getById(id);

            ImportBillDTO importBill = ImportBillDAO.Instance.getById(id);

            importBill.DaTra -= paymentBill.TongTien;

            ImportBillDAO.Instance.update(importBill);

            string sql = $@"DELETE FROM phieuchi WHERE maPhieuChi=@maPhieuChi;";

            int rowChanged = DataProvider.Instance.ExecuteNonQuery(sql,
                new MySqlParameter[] {
                    new MySqlParameter("@maPhieuChi", id),
                });

            return rowChanged > 0;
        }

        public PaymentBillDTO getById(string id)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(
                "SELECT * FROM phieuchi WHERE maPhieuChi=@maPhieuChi;",
                new MySqlParameter[] {
                    new MySqlParameter("@maPhieuChi", id),
                }
            );

            if (dataTable.Rows.Count <= 0) return null;

            PaymentBillDTO customerBill = new PaymentBillDTO(dataTable.Rows[0]);

            return customerBill;
        }
    }
}
