using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BanVeCGV.Models
{
    public partial class Users
    {
        public Users()
        {
            Invoices = new HashSet<Invoices>();
        }

        public int UsId { get; set; }
        public string UsName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public int AccountType { get; set; }

        public virtual ICollection<Invoices> Invoices { get; set; }
    }
}
