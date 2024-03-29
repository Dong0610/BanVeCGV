using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BanVeCGV.Models;

namespace BanVeCGV.Repo
{
	public class ScreeningRepo : BaseRepo<TimeScreening>
	{
		internal static IEnumerable<TimeScreening> getScreenById(int movieId)
		{
			initContex();
			return dbContext.TimeScreening.Where(t=> t.MovieId==movieId).ToList();
		}
	}
}
