using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangBanSach.DTO
{
	public class NumberBookSoldDTO
	{
		public int thang { get; set; }
		public int soLuong { get; set; }

		public NumberBookSoldDTO() { }

		public NumberBookSoldDTO(int thang, int soLuong)
		{
			this.thang = thang;
			this.soLuong = soLuong;
		}

		public NumberBookSoldDTO(DataRow row)
		{
			this.thang = (int)row["thang"];
			this.soLuong = Convert.ToInt32((decimal)row["soLuong"]);
		}
	}
}
