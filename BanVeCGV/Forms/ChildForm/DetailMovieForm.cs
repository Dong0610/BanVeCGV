using BanVeCGV.Models;
using BanVeCGV.Repo;
using BanVeCGV.Widget;
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

namespace BanVeCGV.Forms.ChildForm
{
	public partial class DetailMovieForm : Form
	{
		Action BackClick;
		private MovieViewHome Phim;

		Action<int> IdMove;
		TaiKhoan TaiKhoan;

		public DetailMovieForm(MovieViewHome movie, TaiKhoan taiKhoan)
		{
			InitializeComponent();
			this.Phim = movie;
			LoadDetail(movie);
			this.TaiKhoan = taiKhoan;
			if (!TaiKhoan.VaiTro.Equals("Admin"))
			{
				btnThemSuat.Visible = false;
			}
			LoadToView();
		}

		private void LoadDetail(MovieViewHome movie)
		{
			edtmaPhim.Text = movie.PhimId.ToString();
			edtTenPhim.Text = movie.TenPhim;
			edtDoanhThu.Text = movie.Gia.ToString();
			edtLinkAnhr.Text = movie.PhimAnh;
			edtNgayChieu.Text = movie.NgayChieu;
			edtTheLoai.Text = movie.TenTheLoai;
			edtThoiLuong.Text = movie.ThoiLuong.ToString() + " phút";
			edtDes.Text = movie.NoiDung;
			ImgPreview.ImageLocation = movie.PhimAnh;

		}

		private BindingSource DsVeBinding = new BindingSource();
		private BindingSource SuatChieuBinding = new BindingSource();
		private void LoadToView()
		{
			var data = GioChieuRepo.GetGioChieuByPhim(Phim.PhimId);
			SuatChieuBinding.DataSource =data ;
			dtgvSuatChieu.DataSource = SuatChieuBinding;
			dtgvSuatChieu.Columns[0].HeaderText = "Mã xuất";
			dtgvSuatChieu.Columns[1].HeaderText = "Giờ chiếu";
			dtgvSuatChieu.Columns[3].Visible = false;
			dtgvSuatChieu.Columns[4].Visible = false;
			GioChieuID.DataBindings.Add(new Binding("Text", dtgvSuatChieu.DataSource, "GioChieuId", true, DataSourceUpdateMode.Never));


		}



		private void BackIcon_Click(object sender, EventArgs e)
		{
			MainForms mainForm = this.ParentForm as MainForms;
			if (mainForm != null)
			{
				mainForm.OpenChildForm(new HomeForm(TaiKhoan));
			}
		}


		private void dtgvSuatChieu_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Check if cell clicked is valid
			{
				DataGridViewRow selectedRow = dtgvSuatChieu.Rows[e.RowIndex];

				// Null checks for each cell value
				object screeningIdValue = selectedRow.Cells[0].Value;
				object movieIdValue = selectedRow.Cells[1].Value;
				object roomValue = selectedRow.Cells[2].Value;
				object timeValue = selectedRow.Cells[3].Value;



			}
		}

		private void btnTaoVe_Click(object sender, EventArgs e)
		{
			MainForms main= this.ParentForm as MainForms;
			if (main != null)
			{
				if (GioChieu == null)
				{
					new WarningDialog("Bạn chưa chọn khung giờ chiếu", () => { }).ShowDialog();
					return;
				}
				main.OpenChildForm(new TaoVeForm(TaiKhoan,GioChieu));
			}
		}

		private void btnThemSuat_Click(object sender, EventArgs e)
		{

		}
		private GioChieu GioChieu = null;

		private void GioChieuID_TextChanged(object sender, EventArgs e)
		{
			int Id = GioChieuID.Text.Length!=0?int.Parse(GioChieuID.Text.ToString()) :0;
			if (Id != 0)
			{
				List<DsVeBySuatChieu> vePhims = VePhimRepo.GetDSVeByGioChieu(Id);
				DsVeBinding.DataSource = vePhims;
				GioChieu = GioChieuRepo.FindById<GioChieu>(int.Parse(GioChieuID.Text.ToString()), "GioChieuId");
				dtgvDsVe.DataSource = DsVeBinding;
				dtgvDsVe.Columns[0].HeaderText = "Mã vé";
			}
			

		}
	}
}
