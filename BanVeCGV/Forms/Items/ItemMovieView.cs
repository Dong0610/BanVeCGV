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
		private Movies Movies;
		private Action<Movies> Action;
		public ItemMovieView(Movies movies, Action<Movies> action)
		{
			InitializeComponent();
			this.Movies = movies;
			this.Action = action;
			
			txtNameMovie.Text= movies.Name;
			pnItemView.Click +=_DetailMovies ;
			LoadImageFromUrl(movies.Image, pnItemView);
			ImgTraler.ImageLocation=(movies.Image);

			txtDoanhThu.Text ="Doanh thu: "+ RevenueRepo.FindById<Revenue>(int.Parse(movies.CategoryId.ToString()), "Id").TotalPrice.ToString();
		}

		private void _DetailMovies(object sender, EventArgs e)
		{
			Action.Invoke(Movies);
		}


		private void LoadImageFromUrl(string url, BunifuPanel picture)
		{
			
		}

		private void ItemMovieView_Load(object sender, EventArgs e)
		{
			
		}
	}
}
