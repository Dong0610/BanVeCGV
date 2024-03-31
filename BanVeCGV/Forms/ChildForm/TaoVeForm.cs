using BanVeCGV.Forms.Items;
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
using System.Windows.Forms.VisualStyles;
using System.Windows.Input;

namespace BanVeCGV.Forms.ChildForm
{
	public partial class TaoVeForm : Form
	{
		TaiKhoan TaiKhoan;
		private GioChieu GioChieu;
		private List<Phim> Phims;
		private List<GioChieu> GioChieuSelect;
		public TaoVeForm(TaiKhoan taiKhoan, GioChieu gioChieu)
		{
			InitializeComponent();
			TaiKhoan = taiKhoan;
			Phims = PhimRepo.GetAll().ToList();
			InitMovieView(Phims);
			if (gioChieu != null)
			{
				GioChieu = gioChieu;
				LoadThongTinToView();
			}
			LoadMonAn();
			edtNguoiTao.Text = TaiKhoan.HoTen;
			dtgvThucAn.DataSource = ctVp;
			dtgvThucAn.Columns[0].Visible = false;
			dtgvThucAn.Columns[1].Visible = false;
			dtgvThucAn.Columns[2].HeaderText = "Tên món";
			dtgvThucAn.Columns[3].HeaderText = "Giá món";
			dtgvThucAn.Columns[4].HeaderText = "Số Lượng";
			dtgvThucAn.Columns[5].HeaderText = "Thành tiền";

		}

		private void LoadMonAn()
		{
			List<DoAn> listDA = MonanRepo.GetAll().ToList();
			cbMonAn.DataSource = listDA;
			cbMonAn.DisplayMember = "TenDoAn";
			cbMonAn.SelectedValueChanged += CbMonAn_SelectedValueChanged;
			List<Phong> phongs = PhongRepo.GetAll().ToList();
			cbPhong.DataSource = phongs;
			cbPhong.DisplayMember = "TenPhong";
			cbPhong.SelectedValueChanged += CbPhong_SelectedValueChanged;
		}
		Phong PhongSelect = null;
		DoAn DoAnSelect = null; Ghe GheSelect = null;
		private void CbPhong_SelectedValueChanged(object sender, EventArgs e)
		{
			ComboBox comboBox = sender as ComboBox;
			if (comboBox != null)
			{
				Phong selectedPhong = comboBox.SelectedItem as Phong;
				if (selectedPhong != null)
				{
					PhongSelect = selectedPhong;
					LoadGeByPhong(PhongSelect);
				}
			}
		}

		private void LoadGeByPhong(Phong phongSelect)
		{
			List<Ghe> GheByPhong = PhongRepo.GetArrByPhongID(phongSelect.PhongId);
			cbGhe.DataSource = GheByPhong;
			cbGhe.DisplayMember = "TenGhe";
			cbGhe.SelectedValueChanged += CbGhe_SelectedValueChanged;
		}

		private void CbGhe_SelectedValueChanged(object sender, EventArgs e)
		{
			ComboBox comboBox = sender as ComboBox;
			if (comboBox != null)
			{
				Ghe selectedDoAn = comboBox.SelectedItem as Ghe;
				if (selectedDoAn != null)
				{
					GheSelect = selectedDoAn;
				}
			}
		}

		private void CbMonAn_SelectedValueChanged(object sender, EventArgs e)
		{
			ComboBox comboBox = sender as ComboBox;
			if (comboBox != null)
			{
				DoAn selectedDoAn = comboBox.SelectedItem as DoAn;
				if (selectedDoAn != null)
				{
					DoAnSelect = selectedDoAn;
				}
			}
		}


		private void LoadThongTinToView()
		{
			MovieViewHome data = PhimRepo.GetViewHomeById((int)GioChieu.MaPhim);
			LoadDetail(data);
			SelectMovie((int)GioChieu.MaPhim);
			LoadGioChieu(GioChieu);
		}

		private void LoadGioChieu(GioChieu gioChieu)
		{
			edtMaGC.Text = gioChieu.GioChieuId.ToString();
			GioChieuByMovieId = gioChieu;
			edtGC.Text = gioChieu.TenGioChieu;
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
		}
		private void InitMovieView(IEnumerable<Phim> enumerable)
		{
			foreach (var item in enumerable)
			{
				ItemMovieView itemMovie = new ItemMovieView(item, (movie) =>
				{
					SelectMovie(movie.PhimId);
				}, true);
				itemMovie.TopLevel = false;
				itemMovie.Show();
				flowLayoutPanel1.Controls.Add(itemMovie);
			}
		}

		private void SelectMovie(int movie)
		{
			LoadToView(movie);
			MovieViewHome data = PhimRepo.GetViewHomeById(movie);
			LoadDetail(data);
		}
		private BindingSource SuatChieuBinding = new BindingSource();
		private void LoadToView(int id)
		{
			SuatChieuBinding.DataSource = GioChieuRepo.GetGioChieuByPhim(id);
			dtgvSuatChieu.DataSource = SuatChieuBinding;
			dtgvSuatChieu.CellClick += DtgvSuatChieu_CellClick;
			dtgvSuatChieu.Columns[0].HeaderText = "Mã xuất";
			dtgvSuatChieu.Columns[1].HeaderText = "Giờ chiếu";
			dtgvSuatChieu.Columns[3].Visible = false;
			dtgvSuatChieu.Columns[4].Visible = false;
			//GioChieuID.DataBindings.Add(new Binding("Text", dtgvSuatChieu.DataSource, "GioChieuId", true, DataSourceUpdateMode.Never));
		}

		private void DtgvSuatChieu_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int Id = -1;
			if (dtgvSuatChieu.CurrentRow != null)
			{
				object cellValue = dtgvSuatChieu.CurrentRow.Cells[0].Value;
				if (cellValue != null && int.TryParse(cellValue.ToString(), out int parsedId))
				{
					Id = parsedId;
				}
				LoadIndextToView(Id);
			}
		}
		GioChieu GioChieuByMovieId = null;


		private void LoadIndextToView(int id)
		{
			GioChieuByMovieId = ((List<GioChieu>)SuatChieuBinding.DataSource).Where(t => t.GioChieuId == id).FirstOrDefault();
			LoadGioChieu(GioChieuByMovieId);
			List<ChiTietVePhim> chiTietVePhims = VePhimRepo.GetDetailById(id);
			dtgvThucAn.DataSource = chiTietVePhims;
		}

		private void icSearch_Click(object sender, EventArgs e)
		{
			String key = edtSeach.Text.Trim();
			List<Phim> Search = new List<Phim>();
			foreach (var item in Phims)
			{
				if (item.TenPhim.Contains(key))
				{
					Search.Add(item);
				}
			}
			InitMovieView(key == "" ? Phims : Search);
		}

		private void btnThemSuat_Click(object sender, EventArgs e)
		{
			if (VePhimCreated != null)
			{
				
			}
			else
			{
				new ErrorDialog("Chưa có vé nào được tạo").ShowDialog();
			}
			
		}

		private void btnXoaMon_Click(object sender, EventArgs e)
		{

		}
		VePhim VePhimCreated;

		private void btnTaove_Click(object sender, EventArgs e)
		{
			new YesNoDialog("Bạn có xác nhận tạo vé này không?", (b) =>
			{
				if (b)
				{
					VePhimCreated = VePhimRepo.CreateVePhim(TaiKhoan, edtTenKH.Text.ToString(), edtDtKh.Text.ToString(), GioChieuByMovieId, edtSove.Text.ToString(), GheSelect);
					if (VePhimCreated != null)
					{
						new SuccessDialog("Vé đãđược tạo thành công", () => { btnLuuCt.Visible = true; }).ShowDialog();

					}
				}
			}).ShowDialog();
		}

		private void dtgvSuatChieu_CellClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		List<ChiTietVePhim> ctVp = new List<ChiTietVePhim>();
		private void btnLuuCt_Click(object sender, EventArgs e)
		{


		}
	}
}
