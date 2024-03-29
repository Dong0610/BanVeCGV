using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BanVeCGV.Models
{
    public partial class Movies
    {
        public Movies()
        {
            Invoices = new HashSet<Invoices>();
            Revenue = new HashSet<Revenue>();
            TimeScreening = new HashSet<TimeScreening>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Actor { get; set; }
        public string Descripion { get; set; }
        public string Director { get; set; }
        public int? CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Invoices> Invoices { get; set; }
        public virtual ICollection<Revenue> Revenue { get; set; }
        public virtual ICollection<TimeScreening> TimeScreening { get; set; }
    }
}
