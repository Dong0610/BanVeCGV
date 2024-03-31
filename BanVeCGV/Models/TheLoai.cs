using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BanVeCGV.Models
{
    public partial class TheLoai
    {
        public TheLoai()
        {
            Phim = new HashSet<Phim>();
        }

        public int TheLoaiId { get; set; }
        public string TenTheLoai { get; set; }
        public string Anh { get; set; }

        public virtual ICollection<Phim> Phim { get; set; }
    }
}
