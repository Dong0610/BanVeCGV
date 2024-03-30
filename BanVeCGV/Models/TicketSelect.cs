using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanVeCGV.Models
{
	public class TicketSelect
	{
		public int Id { get; set; }
		public double GiaVe { get; set; }
		public string MaGiamGia { get; set; }
		public float GiaVeGiam { get; set; }
		public string ThoiGian { get; set; }
		public string SoGhe {  get; set; }

		public TicketSelect(int id, double giaVe, string maGiamGia, float giaVeGiam, string thoiGian, string soGhe)
		{
			Id = id;
			GiaVe = giaVe;
			MaGiamGia = maGiamGia;
			GiaVeGiam = giaVeGiam;
			ThoiGian = thoiGian;
			SoGhe = soGhe;
		}

		public TicketSelect()
		{
		}
	}
}
