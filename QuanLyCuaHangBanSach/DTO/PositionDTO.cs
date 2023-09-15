using System;
using System.Data;

namespace QuanLyCuaHangBanSach.DTO
{
    public class PositionDTO
    {
        public int MaChucVu { get; private set; }
        public string TenChucVu { get; set; }
        public string MoTa { get; set; }
        public bool TrangThai { get; set; }

        public PositionDTO() { }

        public PositionDTO(int maChucVu, string tenChucVu, string moTa, bool trangThai)
        {
            this.MaChucVu = maChucVu;
            this.TenChucVu = tenChucVu;
            this.MoTa = moTa;
            this.TrangThai = trangThai;
        }

        public PositionDTO(DataRow row)
        {
            this.MaChucVu = (int)row["maChucVu"];
            this.TenChucVu = row["tenChucVu"].ToString();
            this.MoTa = row["moTa"].ToString();
            this.TrangThai = Convert.ToBoolean(row["trangThai"]);
        }
    }
}

