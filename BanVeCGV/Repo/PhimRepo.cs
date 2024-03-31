using BanVeCGV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanVeCGV.Repo
{
	public class PhimRepo : BaseRepo<Phim>
	{
		public static List<MovieViewHome> GetViewHome()
		{
			initContext();
			return dbContext.MovieViewHome.ToList();
		}
		public static MovieViewHome GetViewHomeById(int id)
		{
			initContext();
			return GetViewHome().Where(t=> t.PhimId==id).FirstOrDefault();
		}

		
	}
}
