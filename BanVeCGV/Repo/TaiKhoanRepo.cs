using BanVeCGV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanVeCGV.Repo
{
	internal class TaiKhoanRepo : BaseRepo<TaiKhoan>
	{
		internal static bool isResigter(string name, string email, string pass)
		{
			initContext();
			try
			{
				TaiKhoan tx = new TaiKhoan()
				{
					TenDangNhap = email,
					MatKhau = pass,
					HoTen = name,
					SoDienThoai = "",
					VaiTro = "Nhân viên",
				};
				return AddNew(tx);
			}
			catch (Exception ex)
			{
				return false;
			}
		}

		internal static TaiKhoan LogginApp(string v1, string v2)
		{
			initContext();
			return dbContext.TaiKhoan.Where(t => t.TenDangNhap.Equals(v1.Trim()) && t.MatKhau.Equals(v2.Trim())).FirstOrDefault();
		}


	}
}
