using BanVeCGV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanVeCGV.Repo
{
	internal class PhongRepo : BaseRepo<Phong>
	{
		internal static List<Ghe> GetArrByPhongID(int phongId)
		{
			initContext();
			return dbContext.Ghe.Where(t=> t.PhongId == phongId).ToList();	
		}
	}
}
