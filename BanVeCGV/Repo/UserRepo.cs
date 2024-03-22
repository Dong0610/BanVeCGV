using BanVeCGV.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanVeCGV.Repo
{
	internal class UserRepo
	{
		public bool isResigter(string username, string email, string passs)
		{
			string query = "INSERT INTO dbo.Users (UserName, Email, Password, Phone, AccountType) VALUES (N'" + username + "',N'" + email + "',N'" + passs + "', '', '')";
			return DBInstance.Instance.ExcuteNoneQuery(query) > 0;
		}
	}
}
