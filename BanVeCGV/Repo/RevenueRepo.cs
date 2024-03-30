using BanVeCGV.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanVeCGV.Repo
{
	internal class RevenueRepo : BaseRepo<Revenue>
	{
		internal static string getTotalByMovies(int id)
		{
			initContex();
			return dbContext.Revenue.Where(t => t.Id == id).FirstOrDefault().TotalPrice.ToString();
		}

		public static List<RevenueDeatil> GetRenuveDetail()
		{
			initContex();
			RevenueDeatil revenueDeatil = new RevenueDeatil();
			List<RevenueDeatil> revenues = new List<RevenueDeatil>();

			List<Movies> MovieArr = MovieRepo.GetAll().ToList();

			foreach (var item in GetAll().ToList())
			{
				Movies movies = MovieArr.Where(t => t.Id == item.MovieId).FirstOrDefault();
				revenues.Add(new RevenueDeatil()
				{
					Id = item.Id,
					MovieID = movies.Id,
					MovieName = movies.Name,
					Actor = movies.Actor,
					Director = movies.Director,
					Price = item.TotalPrice

				});
			}

			return revenues;
		}
	}
}
