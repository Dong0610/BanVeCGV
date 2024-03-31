using BanVeCGV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanVeCGV.Repo
{
	internal class VePhimRepo : BaseRepo<VePhim>
	{
		internal static VePhim CreateVePhim(TaiKhoan taiKhoan, string v1, string v2, GioChieu gioChieuSelect, string v3, Ghe gheSelect)
		{
			try
			{
				VePhim v = new VePhim()
				{
					TenDangNhap =taiKhoan.TenDangNhap,
					GioChieuId =gioChieuSelect.GioChieuId,
					GheId =gheSelect.GheId,
					TenKh =v1,
					DienThoai =v2,
					TongTien = (decimal?)gioChieuSelect.GiaVe,
					SoLuongVe =int.Parse(v3),
				};
				if (AddNew(v))
				{
					return dbContext.VePhim.Where(t => t.TenDangNhap == taiKhoan.TenDangNhap && t.GioChieuId == v.GioChieuId && t.GheId == v.GheId).FirstOrDefault();
				}
				else
				{
					return null;
				}

			}
			catch
			{
				return null;
			}
		}

		internal static List<DsVeBySuatChieu> GetAllVe()
		{
			initContext();
			return dbContext.DsVeBySuatChieu.ToList();
		}

		internal static List<ChiTietVePhim> GetDetailById(int id)
		{
			initContext();
			return dbContext.ChiTietVePhim.Where(t => t.VeId == id).ToList();
		}

		internal static List<DsVeBySuatChieu> GetDSVeByGioChieu(int v)
		{
			initContext();
			return dbContext.DsVeBySuatChieu.Where(t => t.GioChieuId == v).ToList();
		}


	}
}
