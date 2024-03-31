using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BanVeCGV.Models
{
    public partial class Phong
    {
        public Phong()
        {
            Ghe = new HashSet<Ghe>();
        }

        public int PhongId { get; set; }
        public string TenPhong { get; set; }

        public virtual ICollection<Ghe> Ghe { get; set; }
    }
}
