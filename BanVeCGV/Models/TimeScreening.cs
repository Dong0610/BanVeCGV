using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BanVeCGV.Models
{
    public partial class TimeScreening
    {
        public TimeScreening()
        {
            Tickets = new HashSet<Tickets>();
        }

        public int Id { get; set; }
        public int? MovieId { get; set; }
        public string Times { get; set; }
        public string RoomNumber { get; set; }
        public double Price { get; set; }

        public virtual Movies Movie { get; set; }
        public virtual ICollection<Tickets> Tickets { get; set; }
    }
}
