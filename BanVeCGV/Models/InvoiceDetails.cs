using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BanVeCGV.Models
{
    public partial class InvoiceDetails
    {
        public int InvoiceId { get; set; }
        public int TicketId { get; set; }
        public string ItemName { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }

        public virtual Invoices Invoice { get; set; }
        public virtual Tickets Ticket { get; set; }
    }
}
