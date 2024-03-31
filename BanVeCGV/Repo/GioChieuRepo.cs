using BanVeCGV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanVeCGV.Repo
{
	internal class GioChieuRepo : BaseRepo<GioChieu>
	{
		internal static List<GioChieu> GetGioChieuByPhim(int phimId)
		{
			initContext();
			var data = GetAll();

			return dbContext.GioChieu.Where(t=> t.MaPhim == phimId).ToList();
		}
	}
}
