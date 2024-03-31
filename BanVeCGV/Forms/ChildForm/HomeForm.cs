using BanVeCGV.Models;
using BanVeCGV.Repo;
using BanVeCGV.Widget;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BanVeCGV.Forms.ChildForm
{
	public partial class HomeForm : Form
	{
		BindingSource bindingSource = new BindingSource();
		Action<String, Phim> OpenNewForm;
		private TaiKhoan TaiKhoan;
		public HomeForm(TaiKhoan taiKhoan)
		{
			InitializeComponent();

			bindingSource.DataSource = PhimRepo.GetViewHome();
			dtgvMovie.DataSource = bindingSource;
			this.TaiKhoan = taiKhoan;
			InitializeHeaders();


			InitMovieView();

		}

		private void InitMovieView()
		{
			foreach (var item in PhimRepo.GetAll())
			{
				ItemMovieView itemMovie = new ItemMovieView(item, (movie) =>
				{
					MainForms mainForm = this.ParentForm as MainForms;
					if (mainForm != null)
					{
						mainForm.OpenChildForm(new DetailMovieForm(PhimRepo.GetViewHomeById(movie.PhimId),TaiKhoan));
					}
				},false);

				itemMovie.TopLevel = false;
				itemMovie.Show();
				listPnViewMovie.Controls.Add(itemMovie);

			}
		}



		private void InitializeHeaders()
		{
			dtgvMovie.Columns[0].HeaderText = "Mã phim";
			dtgvMovie.Columns[1].Visible=false;
			
			dtgvMovie.Columns[2].HeaderText = "Tên phim";
			dtgvMovie.Columns[3].HeaderText = "Ảnh";
			dtgvMovie.Columns[4].HeaderText = "Ngày chiếu";
			dtgvMovie.Columns[5].HeaderText = "Nội dung";
			dtgvMovie.Columns[6].HeaderText = "Giá";
			dtgvMovie.Columns[7].HeaderText = "Thời lượng";
			dtgvMovie.Columns[8].HeaderText = "Thể loại";
			dtgvMovie.Columns[9].Visible = false;

		}
		
		private void icSearch_Click(object sender, EventArgs e)
		{
			SearchMovie();
		}

		private void icReload_Click(object sender, EventArgs e)
		{
			bindingSource.DataSource = PhimRepo.GetAll();
		}

		private void edtSearchKey_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				SearchMovie();
			}
		}

		private void SearchMovie()
		{
			List<Phim> movies = new List<Phim>();
			IEnumerable<Phim> dbMovies = PhimRepo.GetAll();
			string searchKey = edtSearchKey.Text.ToString();
			foreach (Phim movie in dbMovies)
			{
				if (movie.TenPhim.Contains(searchKey) || movie.NoiDung.Contains(searchKey) || movie.TheLoai.TenTheLoai.Contains(searchKey))
				{
					movies.Add(movie);
				}
			}
			bindingSource.DataSource = movies;
		}
	}
}
