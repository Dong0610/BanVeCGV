using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanVeCGV.Models
{
	internal class RevenueDeatil
	{
		public int Id { get; set; }
		public int MovieID { get; set; }
		public String MovieName { get; set; }
		public String Actor {  get; set; }
		public String Director { get; set; }	
		public double Price { get; set; }

		public RevenueDeatil()
		{
		}

		public RevenueDeatil(int id, int movieID, string movieName, string actor, string director, double price)
		{
			Id = id;
			MovieID = movieID;
			MovieName = movieName;
			Actor = actor;
			Director = director;
			Price = price;
		}
	}
}
