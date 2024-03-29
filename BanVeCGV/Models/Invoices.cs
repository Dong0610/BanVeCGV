using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BanVeCGV.Models
{
    public partial class Invoices
    {
        public Invoices()
        {
            InvoiceDetails = new HashSet<InvoiceDetails>();
        }

        public int InvoiceId { get; set; }
        public int? CreatUsId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhome { get; set; }
        public int? MovieId { get; set; }
        public string MovieName { get; set; }
        public decimal? TotalAmount { get; set; }
        public string VoucherCode { get; set; }
        public string CreatedTime { get; set; }

        public virtual Users CreatUs { get; set; }
        public virtual Movies Movie { get; set; }
        public virtual ICollection<InvoiceDetails> InvoiceDetails { get; set; }
    }
}
