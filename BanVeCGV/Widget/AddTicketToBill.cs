using BanVeCGV.Forms.Items;
using BanVeCGV.Models;
using BanVeCGV.Repo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace BanVeCGV.Widget
{
	public partial class AddTicketToBill : Form
	{
		Action<List<TicketSelect>> ticketSelect;
		Invoices invoices;
		List<TicketSelect> TicketSelects = new List<TicketSelect>();
		List<Tickets> Tickets;
		private int screenId;

		TimeScreening TimeScreening;

		public AddTicketToBill(Invoices invoices, int screenId, Action<List<TicketSelect>> ticketSelect)
		{
			InitializeComponent();
			this.ticketSelect = ticketSelect;
			this.invoices = invoices;

			Tickets = TicketRepo.TicketByScreenID(screenId).ToList();
			TimeScreening = (TimeScreening)ScreeningRepo.FindById<TimeScreening>(screenId,"Id");
			LoadToTicket(Tickets);
			
		}

		private void LoadToTicket(List<Tickets> tickets)
		{
			flistItemView.Controls
			.Clear();
			foreach (var ticket in tickets)
			{
				RowItemTicket it = new RowItemTicket(ticket, TimeScreening, (data) =>
				{
					AddItem = data;
					edtAddData.Text= data.TicketId.ToString();
					RemoveItem = new TicketSelect(data.TicketId, TimeScreening.Price,"0", 0,DateTime.Now.ToString("dd/MM/yyyy HH:MM:ss"), data.SeatNumber);


				});
				flistItemView.Controls .Add(it);
				it.Show();
			}
		}



		private TicketSelect RemoveItem;
		private Tickets AddItem;

		private void IconAdd_Click(object sender, EventArgs e)
		{
			if(AddItem!=null)
			{
				AddTickSelKet();
			}
			
		}
		private void RemoveTicketS()
		{
			Tickets tickets = new Tickets()
			{
				TicketId = RemoveItem.Id,
				ScreeningId = RemoveItem.Id,
				SeatNumber = RemoveItem.SoGhe,
				Status = 0
			};

			Tickets.Add(tickets);
			LoadToTicket(Tickets);
			AddItem = null;
			
			TicketSelects.Remove(RemoveItem);
			LoadToSelect(TicketSelects);
			RemoveItem = null;

		}

		void AddTickSelKet()
		{
			if (RemoveItem != null)
			{
				TicketSelects.Add(RemoveItem);
				LoadToSelect(TicketSelects);
				RemoveItem = null;
				Tickets.Remove(AddItem);
				LoadToTicket(Tickets);
				AddItem = null;
			}
			
		}
		private void LoadToSelect(List<TicketSelect> ticketSelects)
		{
			flItemSelect.Controls
			.Clear();
			foreach (var ticket in ticketSelects)
			{
				RowSelectTicket it = new RowSelectTicket(ticket, (data) =>
				{
					RemoveItem = data;
					edtRemove.Text = data.Id.ToString();
				});
				flItemSelect.Controls.Add(it);
				it.Show();
			}
		}



		private void icSave_Click(object sender, EventArgs e)
		{
			ticketSelect.Invoke(TicketSelects);
			this.Close();

		}

		private void btnDel_Click(object sender, EventArgs e)
		{
			if(RemoveItem != null)
			{
				RemoveTicketS();
			}
			
		}

		private void icCloseApp_Click(object sender, EventArgs e)
		{
			this.Close();
			ticketSelect.Invoke(null);
		}
	}
}
