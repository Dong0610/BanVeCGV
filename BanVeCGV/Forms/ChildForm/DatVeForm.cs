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

namespace BanVeCGV.Forms.ChildForm
{
	public partial class DatVeForm : Form
	{
		TimeScreening screenings;
		Movies Movies;
		Tickets tickets;
		private TicketSelect ticketSelect;
		List<Tickets> GetTickets;
		public DatVeForm(TimeScreening screening, Movies movies1)
		{
			InitializeComponent();
			screenings = screening;
			Movies = movies1;
			GetTickets = TicketRepo.TicketByScreenID(screenings.Id).ToList();
			LoadDataToView(GetTickets);
			LoadMovieToView(Movies);
		}

		private void LoadMovieToView(Movies movies)
		{
			edtMoviewName.Text = movies.Name;
			edtDaoDien.Text = movies.Director;
			edtDienVien.Text = movies.Actor;
			edtTheLoai.Text = CategoryRepo.getNameById(movies.Id);
		}


		List<TicketSelect> TicketSelects = new List<TicketSelect>();

		private void LoadDataToView(List<Tickets> getTickets)
		{
			flistItemView.Controls.Clear();
			foreach (var item in getTickets)
			{
				RowItemTicket rowItem = new RowItemTicket(item, screenings, (data) =>
				{
					this.tickets = data;
					SelectTicKet(data, screenings);
				});
				flistItemView.Controls.Add(rowItem);
				rowItem.Show();
			};
		}

		private void SelectTicKet(Tickets data, TimeScreening screenings)
		{
			edtMaVe.Text = data.TicketId.ToString();
			edtTimeCreate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
			edtGiave.Text = screenings.Price.ToString();
			edtSoGe.Text = data.SeatNumber.ToString();
			ticketSelect = new TicketSelect(tickets.TicketId, screenings.Price, edtDiscount.Text.ToString(), (float)(edtDiscount.Text.ToString()=="" ? screenings.Price: 0), edtTimeCreate.Text.ToString(), tickets.SeatNumber);

		}

		private void btnHuyBo_Click(object sender, EventArgs e)
		{

			MainForms mainForm = this.ParentForm as MainForms;
			if (mainForm != null)
			{
				mainForm.OpenChildForm(new HomeForm());
			}
		}

		private void btnTaoDon_Click(object sender, EventArgs e)
		{
			new WarningDialog("Bạn có xác nhận tạo hóa đơn này không", () =>
			{
				String khName = edtTenKh.Text.ToString();
				String phone = edtPhoneNum.Text.ToString();

				if (InvoiceRepo.AddNewBill(khName, phone, Movies, TicketSelects, edtMaGD.Text.ToString()))
				{
					new SuccessDialog("Đã tạo hóa đơn thành công!", () =>
					{
						MainForms mainForm = this.ParentForm as MainForms;
						if (mainForm != null)
						{
							mainForm.OpenChildForm(new HomeForm());
						}
					}).ShowDialog();
				}
				else
				{
					new ErrorDialog("Đã xảy ra rỗi hãy thử lại sau").ShowDialog();
				}


			}).ShowDialog();
		}

		private void icRemove_Click(object sender, EventArgs e)
		{
			if (ticketSelect != null)
			{
				RemoveTicketS();
			}


		}

		private void RemoveTicketS()
		{
			Tickets tickets = new Tickets()
			{
				TicketId = ticketSelect.Id,
				ScreeningId = screenings.Id,
				SeatNumber = ticketSelect.SoGhe,
				Status = 0
			};

			GetTickets.Add(tickets);
			TicketSelects.Remove(ticketSelect);
			LoadSelectTicKet();
			LoadDataToView(GetTickets);
			ticketSelect = null;
			tickets = null;

		}

		private void btnAddVe_Click(object sender, EventArgs e)
		{
			TicketSelects.Add(ticketSelect);
			AddTickSelKet();


		}

		void LoadSelectTicKet()
		{
			flSelectVe.Controls.Clear();

			TicketSelects.ForEach(item =>
			{
				RowSelectTicket tk = new RowSelectTicket(item, (data) =>
				{
					ticketSelect = data;
				});
				flSelectVe.Controls.Add(tk);
				tk.Show();
			});
		}

		void AddTickSelKet()
		{
			if (ticketSelect != null)
			{
				LoadSelectTicKet();
				GetTickets.Remove(tickets);
				tickets = null;
				LoadDataToView(GetTickets);
				ticketSelect = null;
			}
		}
	}
}
