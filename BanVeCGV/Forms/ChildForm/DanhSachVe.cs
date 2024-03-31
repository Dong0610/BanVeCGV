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

namespace BanVeCGV.Forms.ChildForm
{
	public partial class DanhSachVe : Form
	{

		private BindingSource BindingSource = new BindingSource();
		private MainForms MainForms;
		TaiKhoan GetUsers;
		private List<DsVeBySuatChieu> LisAllVe;

		public DanhSachVe(TaiKhoan users)
		{
			InitializeComponent();
			LisAllVe = VePhimRepo.GetAllVe();
			LoadDsVePhim(LisAllVe);
			dtgvThucAn.DataSource = ChiTietSource;


		}

		DsVeBySuatChieu DsVeBySuatChieu {  get; set; }

		private void LoadDsVePhim(List<DsVeBySuatChieu> lisAllVe)
		{
			flowLayoutPanel1.Controls.Clear();
			foreach (var item in lisAllVe)
			{
				TicketsRowItems data = new TicketsRowItems(item, (ds) =>
				{
					LoadDetail(ds);
				});
				data.TopLevel = false;
				data.Show();
				data.Size = new Size(265, 180);
				data.AutoSize = true;
				flowLayoutPanel1.Controls.Add(data);

			}
		}

		private void LoadDetail(DsVeBySuatChieu ds)
		{
			DsVeBySuatChieu = ds;
			int PhimId = (int)GioChieuRepo.FindById<GioChieu>(ds.GioChieuId, "GioChieuId").MaPhim;
			LoadDetail(PhimRepo.GetViewHomeById(PhimId));
			edtMaGC.Text= ds.GioChieuId.ToString();
			var data = GioChieuRepo.FindById<GioChieu>(ds.GioChieuId, "GioChieuId");
			edtGC.Text = data.TenGioChieu;
			edtTenKH.Text = ds.TenKh;
			edtNguoiTao.Text = ds.HoTen;
			edtDtKh.Text= ds.DienThoai;

			Phong p = PhimRepo.FindByKey<Phong>(ds.TenPhong, "TenPhong");
			var lp = new List<Phong>();
			lp.Add(p);
			cbPhong.DataSource= lp;
			cbPhong.DisplayMember= "TenPhong";
			Ghe gh = GheRepo.FindByKey<Ghe>(ds.TenGhe, "TenGhe");
			var lg= new List<Ghe>();
			lg.Add(gh);
			cbGhe.DataSource= lg;
			cbGhe.DisplayMember = "TenGhe";
			LoadFoodDetail(ds.VeId);
			List<DoAn> listDA = MonanRepo.GetAll().ToList();
			cbMonAn.DataSource = listDA;
			cbMonAn.DisplayMember = "TenDoAn";
			cbMonAn.SelectedValueChanged += CbMonAn_SelectedValueChanged;
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



		private List<ChiTietVePhim> ChiTietVePhims= new List<ChiTietVePhim>();

		private BindingSource ChiTietSource= new BindingSource();

		public DoAn DoAnSelect { get; private set; }

		private void LoadFoodDetail(int veId)
		{

			ChiTietSource.DataSource= VePhimRepo.GetDetailById(veId);
		
			dtgvThucAn.Columns[0].Visible = false;
			dtgvThucAn.Columns[1].Visible = false;
			dtgvThucAn.Columns[2].HeaderText = "Tên món";
			dtgvThucAn.Columns[3].HeaderText = "Giá món";
			dtgvThucAn.Columns[4].HeaderText = "Số Lượng";
			dtgvThucAn.Columns[5].HeaderText = "Thành tiền";
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

		private void btnXoaMon_Click(object sender, EventArgs e)
		{

		}



		private void btnThemSuat_Click(object sender, EventArgs e)
		{
			if (DoAnSelect != null)
			{
				int SoLuong = (int)nmSoLuong.Value;
				var Data= ChiTietVePhims.Where(t=>t.MaDoAn==DoAnSelect.DoAnId).FirstOrDefault();
				if(Data==null)
				{
					ChiTietVePhim ct = new ChiTietVePhim()
					{
						VeId = DsVeBySuatChieu.VeId,
						MaDoAn = DoAnSelect.DoAnId,
						TenDoAn = DoAnSelect.TenDoAn,
						SoLuong = SoLuong,
						GiaMon = (double?)DoAnSelect.Gia,
						ThanhTien = (double?)DoAnSelect.Gia * SoLuong,
					};
					ChiTietVePhims.Add(ct);
					DoAnSelect = null;
					dtgvThucAn.Refresh();

				}
				else
				{
					Data.SoLuong+= SoLuong;
					Data.ThanhTien= Data.GiaMon*Data.SoLuong;
					ChiTietVePhims.Where(t => t.MaDoAn == DoAnSelect.DoAnId).FirstOrDefault().ThanhTien = Data.ThanhTien;
					ChiTietVePhims.Where(t => t.MaDoAn == DoAnSelect.DoAnId).FirstOrDefault().SoLuong = Data.SoLuong;
					
				}
			}
			else
			{
				new ErrorDialog("Chưa có món ăn nào được chọn").ShowDialog();
			}

			ChiTietSource.DataSource = ChiTietVePhims;
			dtgvThucAn.Refresh();


		}
	}
}
