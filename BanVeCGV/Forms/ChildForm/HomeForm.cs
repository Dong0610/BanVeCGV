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
		Action<String,Movies> OpenNewForm;
		public HomeForm()
		{
			InitializeComponent();

			bindingSource.DataSource = MovieRepo.GetAll();
			dtgvMovie.DataSource = bindingSource;
			
			InitializeHeaders();


			InitMovieView();
		
		}

		private void InitMovieView()
		{
            foreach (var item in MovieRepo.GetAll())
            {
				ItemMovieView itemMovie = new ItemMovieView(item, (movie) =>
				{
					MainForms mainForm = this.ParentForm as MainForms;
					if (mainForm != null)
					{
						mainForm.OpenChildForm(new DetailMovieForm(movie));
					}
				});
				
				itemMovie.TopLevel = false;
				itemMovie.Show();
				listPnViewMovie.Controls.Add(itemMovie);
                
            }
        }



		private void InitializeHeaders()
		{
		
			dtgvMovie.Columns[0].HeaderText = "Mã phim";
			dtgvMovie.Columns[1].HeaderText = "Tên Phim";
			dtgvMovie.Columns[2].HeaderText = "Thể loại";
			dtgvMovie.Columns[3].HeaderText = "Đạo diễn";
			dtgvMovie.Columns[4].HeaderText = "Diễn viên";
			dtgvMovie.Columns[5].HeaderText = "Mô tả";
			dtgvMovie.Columns[6].Visible = false;
			dtgvMovie.Columns[7].Visible = false;
			dtgvMovie.Columns[8].Visible = false;

			dtgvMovie.Columns[10].Visible = false;
			dtgvMovie.Columns[9].Visible = false;



		}
		private void BindingData()
		{
			//tbmacv.DataBindings.Add(new Binding("Text", dtgvchucvu.DataSource, "Mã chức vụ", true, DataSourceUpdateMode.Never));
			//tbtencv.DataBindings.Add(new Binding("Text", dtgvchucvu.DataSource, "Tên chức vụ", true, DataSourceUpdateMode.Never));
			//tbhspk.DataBindings.Add(new Binding("Text", dtgvchucvu.DataSource, "Lương cơ bản", true, DataSourceUpdateMode.Never));
			//tbluongcb.DataBindings.Add(new Binding("Text", dtgvchucvu.DataSource, "Phụ cấp", true, DataSourceUpdateMode.Never));
		}

		private void icSearch_Click(object sender, EventArgs e)
		{
			SearchMovie();
		}

		private void icReload_Click(object sender, EventArgs e)
		{
			bindingSource.DataSource= MovieRepo.GetAll();
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
			List<Movies> movies = new List<Movies>();
			IEnumerable<Movies> dbMovies = MovieRepo.GetAll();
			string searchKey = edtSearchKey.Text.ToString();
			foreach (Movies movie in dbMovies)
			{
				if (movie.Name.Contains(searchKey) || movie.Descripion.Contains(searchKey) || movie.Director.Contains(searchKey))
				{
					movies.Add(movie);
				}
			}
			bindingSource.DataSource = movies;
		}

		private void bunifuPanel2_Click(object sender, EventArgs e)
		{

		}

		private void listPnViewMovie_Paint(object sender, PaintEventArgs e)
		{

		}

		private void edtSearchKey_TextChanged(object sender, EventArgs e)
		{

		}

		private void bunifuPanel1_Click(object sender, EventArgs e)
		{

		}

		private void pndtgv_Click(object sender, EventArgs e)
		{

		}

		private void dtgvMovie_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void usersBindingSource_CurrentChanged(object sender, EventArgs e)
		{

		}
	}
}
