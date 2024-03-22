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
	public static class UserRepo
	{
		public static bool isResigter(string username, string email, string passs)
		{
			string query = "INSERT INTO dbo.Users (UserName, Email, Password, Phone, AccountType) VALUES (N'" + username + "',N'" + email + "',N'" + passs + "', '', '')";
			return DBInstance.Instance.ExcuteNoneQuery(query) > 0;
		}

		public static Users LogginApp(string email,string pass)
		{
			var dtTable = DBInstance.Instance.ExcuteQuery("SELECT*FROM dbo.Users WHERE Email = N'"+email+"' AND Password =N'"+pass+"'");
			if(dtTable == null) return null;
            else if(dtTable.Rows.Count == 0)
            {
                 return null;
            }
			else
			{
				Users us = new Users();
				foreach (DataRow dr in dtTable.Rows)
				{
					us =new  Users(dr);
				}
				return us;
			}
        }
	}
}
