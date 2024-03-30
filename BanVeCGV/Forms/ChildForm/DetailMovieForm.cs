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
		private Movies movies;

		Action<int> IdMove;

		public DetailMovieForm(Models.Movies moves)
		{
			InitializeComponent();
			this.movies = moves;
			LoadDetail(moves);

			IdMove = x =>
			{
				var arr = TicketRepo.TicketByScreenID(x);
				ticketBinding.DataSource = arr;
				LoadToView();
			};



		}
		private BindingSource movieBinding = new BindingSource();
		private BindingSource ticketBinding = new BindingSource();
		private void LoadToView()
		{
			dtgvDsVe.DataSource = ticketBinding;

			if (dtgvDsVe.DataSource != null)
			{
				dtgvDsVe.Columns[0].HeaderText = "Mã vé";
				dtgvDsVe.Columns[1].HeaderText = "Mã suất";
				dtgvDsVe.Columns[2].HeaderText = "Người tạo";
				dtgvDsVe.Columns[3].HeaderText = "Số ghế";
				dtgvDsVe.Columns[4].HeaderText = "Tình trạng";
				dtgvDsVe.Columns[5].Visible = false;
				//dtgvDsVe.Columns[6].Visible = false;
				//dtgvDsVe.Columns[7].Visible = false;
			}
		}


		private void LoadDetail(Movies moves)
		{
			txtName.Text = moves.Name;
			ImagePreview.ImageLocation = moves.Image;
			txtDienVien.Text = moves.Actor;
			txtHangSx.Text = moves.Director;
			txtTrailerLink.Text = moves.Image;
			edtTheLoai.Text = CategoryRepo.getNameById(moves.CategoryId);
			txtMota.Text = moves.Descripion;
			movieBinding.DataSource = ScreeningRepo.getScreenById(moves.Id);

			LoadDtgv(moves);
		}

		private void LoadDtgv(Movies moves)
		{
			dtgvSuatChieu.DataSource = movieBinding;
			dtgvSuatChieu.Columns[5].Visible = false;
			dtgvSuatChieu.Columns[6].Visible = false;
			screningID.DataBindings.Add(new Binding("Text", dtgvSuatChieu.DataSource, "Id", true, DataSourceUpdateMode.Never));
			screningID.Visible = true;
			dtgvSuatChieu.Columns[0].HeaderText = "Mã";
			dtgvSuatChieu.Columns[1].HeaderText = "Mã vé";
			dtgvSuatChieu.Columns[2].HeaderText = "Phòng";
			dtgvSuatChieu.Columns[3].HeaderText = "Thời gian";
			dtgvSuatChieu.Columns[4].HeaderText = "Số ghế";

		}

		private void BackIcon_Click(object sender, EventArgs e)
		{
			MainForms mainForm = this.ParentForm as MainForms;
			if (mainForm != null)
			{
				mainForm.OpenChildForm(new HomeForm());
			}
		}

		private void btnDatVe_Click(object sender, EventArgs e)
		{
			MainForms mainForm = this.ParentForm as MainForms;
			if (mainForm != null)
			{
				if (screenSelect == null)
				{
					new WarningDialog("Bạn chưa chọn suất chiếu", () =>
					{

					}).ShowDialog();
				}
				else
				{
					if (screenSelect.Id == 0)
					{
						new WarningDialog("Bạn chưa chọn suất chiếu",() =>
						{

						}).ShowDialog();
					}
					else
					{
						mainForm.OpenChildForm(new DatVeForm(screenSelect, movies));
					}
				}
			}
		}

		TimeScreening screenSelect = null;

		private void screningID_TextChange(object sender, EventArgs e)
		{
			int dienVien;
			if (string.IsNullOrEmpty(screningID.Text))
			{
				dienVien = 0;
			}
			else
			{
				if (!int.TryParse(screningID.Text, out dienVien))
				{
					dienVien = 0;
				}
			}
			IdMove.Invoke(dienVien);
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
				object remainingSeatsValue = selectedRow.Cells[4].Value;

				int screeningId = screeningIdValue != null ? int.Parse(screeningIdValue.ToString()) : 0;
				int movieId = movieIdValue != null ? int.Parse(movieIdValue.ToString()) : 0;
				string room = roomValue != null ? roomValue.ToString() : "N/A";
				string time = timeValue != null ? timeValue.ToString() : "N/A";
				double remainingSeats = remainingSeatsValue != null ? double.Parse(remainingSeatsValue.ToString()) : 0;

				
				screenSelect = new TimeScreening()
				{
					Id = screeningId,
					MovieId = movieId,
					RoomNumber = room,
					Times = time,
					Price = remainingSeats,
				};

				txtSelect.Text = "Phòng: " + room + " Giờ chiếu: " + time;
			}
		}


	}
}
