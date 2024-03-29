using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BanVeCGV.Models
{
    public partial class Tickets
    {
        public Tickets()
        {
            InvoiceDetails = new HashSet<InvoiceDetails>();
        }

        public int TicketId { get; set; }
        public int? ScreeningId { get; set; }
        public string SeatNumber { get; set; }
        public int? Status { get; set; }

        public virtual TimeScreening Screening { get; set; }
        public virtual ICollection<InvoiceDetails> InvoiceDetails { get; set; }
    }
}
