using BanVeCGV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanVeCGV.Repo
{
	internal class CategoryRepo : BaseRepo<Category>
	{
		internal static string getNameById(int? categoryId)
		{
			initContex();
			return dbContext.Category.Where(t => t.Id == categoryId).FirstOrDefault().Name;
		}
	}
}
