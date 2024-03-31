using BanVeCGV.Models;
using BanVeCGV.Repo;
using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanVeCGV.Widget
{
	public partial class ItemMovieView : Form
	{
		private Phim Phim;
		private Action<Phim> Action;
		public ItemMovieView(Phim Phim, Action<Phim> action, bool isSmall)
		{
			InitializeComponent();
			this.Phim = Phim;
			this.Action = action;
			if (isSmall)
			{
				this.Size = new System.Drawing.Size(264,200);
			}
			
			txtNameMovie.Text= Phim.TenPhim;
		
			txtTheLoai.Text =TheLoaiRepo.FindById<TheLoai>(Phim.TheLoaiId, "TheLoaiId").TenTheLoai;
			txtThoiLuong.Text= Phim.ThoiLuong.ToString();
			ImgTraler.ImageLocation=(Phim.Anh);
			}


		private void pnView_Click(object sender, EventArgs e)
		{
			Action.Invoke(Phim);

		}
	}
}
