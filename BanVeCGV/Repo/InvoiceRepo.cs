using BanVeCGV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanVeCGV.Repo
{
	internal class InvoiceRepo : BaseRepo<Invoices>
	{
		internal static bool AddNewBill(string khName, string phone, Movies movies, List<TicketSelect> ticketSelects, string v)
		{
			initContex();
			try
			{
				String time = DateTime.Now.ToString("dd/mm/yyyy HH:MM:ss");

				Invoices invoices = new Invoices()
				{
					CreatUsId = 100,
					CustomerName = khName,
					CustomerPhome = phone,
					MovieId = movies.Id,
					MovieName = movies.Name,
					TotalAmount = 0,
					VoucherCode = v,
					CreatedTime = time,
				};

				dbContext.Invoices.Add(invoices);	
				dbContext.SaveChanges();

				Invoices iv = getInvoi(khName, phone, time);

				foreach (var item in ticketSelects)
				{
					InvoiceDetails details = new InvoiceDetails()
					{
						InvoiceId = iv.InvoiceId,
						TicketId = item.Id,
						ItemName = "Vé xem phim " + time.Replace("/", "").Replace(" ", ""),
						Quantity = 1,
						Price = (decimal?)item.GiaVeGiam,
					};
					dbContext.Tickets.Where(id => id.TicketId == item.Id).FirstOrDefault().Status = 0;
					dbContext.SaveChanges();
					DetailInvoiceRepo.AddNew(details);
				}
				return true;
			}
			catch(Exception ex)
			{
				return false;
			}
			
		}

		private static Invoices getInvoi(string khName, string phone, string time)
		{
			initContex();
			return dbContext.Invoices.Where(t => t.CustomerName.Equals(khName) && t.CustomerPhome.Equals(phone) && t.CreatedTime.Equals(time)).FirstOrDefault();
		}
	}
}
