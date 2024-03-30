using BanVeCGV.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanVeCGV.Forms.Items
{
	public partial class RowItemTicket : UserControl
	{
		private Tickets Tickets;
		Action<Tickets> action;
		public RowItemTicket(Tickets tickets,TimeScreening screenings, Action<Tickets> action)
		{
			InitializeComponent();
			Tickets = tickets;
			this.action = action;
			LoadToView(tickets, screenings);
		}

		private void LoadToView(Tickets tickets, TimeScreening screenings)
		{
			txtId.Text ="Mã vé: "+ tickets.TicketId.ToString();
			txtPhong.Text="Phòng: "+ screenings.RoomNumber.ToString();
			txtTgChieu.Text ="Giờ chiếu:"+ screenings.Times.ToString();

		}

		private void tbLayout_Click(object sender, EventArgs e)
		{
			action.Invoke(Tickets);
		}
	}
}
