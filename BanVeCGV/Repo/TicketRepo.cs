using BanVeCGV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanVeCGV.Repo
{
	public class TicketRepo : BaseRepo<Tickets>
	{
		public TicketRepo() {
			initContex();
		}

		internal static int GetScreemIdByTicker(int ticketId)
		{
			initContex();
			return (int)dbContext.Tickets.Where(t=>t.TicketId == ticketId).FirstOrDefault().ScreeningId;
		}

		internal static IEnumerable<Tickets> TicketByScreenID(int x)
		{
			initContex();
			return dbContext.Tickets
							.Where(tickets => tickets.ScreeningId == x && tickets.Status==1)
							.ToList();
		}

	}
}
