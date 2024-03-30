using BanVeCGV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace BanVeCGV.Repo
{
	internal class DetailInvoiceRepo : BaseRepo<InvoiceDetails>
	{
		internal static void AddToData(Invoices iv, List<TicketSelect> data)
		{
			initContex();
			foreach (var item in data)
			{
				InvoiceDetails details = new InvoiceDetails()
				{
					InvoiceId = iv.InvoiceId,
					TicketId = item.Id,
					ItemName = "Vé xem phim " + DateTime.Now.ToString("dd/mm/yyy HH:mm:ss").Replace("/", "").Replace(" ", ""),
					Quantity = 1,
					Price = (decimal?)item.GiaVeGiam,
				};
				dbContext.Tickets.Where(id => id.TicketId == item.Id).FirstOrDefault().Status = 0;
				dbContext.SaveChanges();
				DetailInvoiceRepo.AddNew(details);
			}
		}

		internal static List<InvoiceDetails> GetByInvoiceId(int id)
		{
			initContex();
			return dbContext.InvoiceDetails.Where(t => t.InvoiceId==id).ToList();
		}
	}
}
