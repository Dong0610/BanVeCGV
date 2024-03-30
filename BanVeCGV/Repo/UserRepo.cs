using BanVeCGV.Database;
using BanVeCGV.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanVeCGV.Repo
{
	public class UserRepo : BaseRepo<Users>
	{
		public static  Users LogginApp(string v1, string v2)
		{
			if (dbContext == null)
			{
				dbContext= new QuanlibvCGVContext();
			}
			Users us = null;
			us= dbContext.Users.Where(t=> t.Email.Equals(v1)&& t.Password.Equals(v2)).FirstOrDefault<Users>();
			return us;
		}

		public static bool isResigter(string name, string email, string pass)
		{
			initContex();
			Users us = new Users();
			us.UsName= name;
			us.Email= email;
			us.Password= pass;
			us.Phone = "";
			us.AccountType = 0;
			return AddNew(us);
		}

		internal static Users getUserById(int? creatUsId)
		{
			initContex();
			return dbContext.Users.Where(t=> t.UsId==creatUsId).FirstOrDefault();
		}
	}
}
