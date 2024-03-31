using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BanVeCGV.Models
{
    public partial class GioChieu
    {
        public GioChieu()
        {
            VePhim = new HashSet<VePhim>();
        }

        public int GioChieuId { get; set; }
        public string TenGioChieu { get; set; }
        public int? MaPhim { get; set; }
        public double GiaVe { get; set; }

        public virtual Phim MaPhimNavigation { get; set; }
        public virtual ICollection<VePhim> VePhim { get; set; }
    }
}
