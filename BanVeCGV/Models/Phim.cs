using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BanVeCGV.Models
{
    public partial class Phim
    {
        public Phim()
        {
            GioChieu = new HashSet<GioChieu>();
        }

        public int PhimId { get; set; }
        public int TheLoaiId { get; set; }
        public string TenPhim { get; set; }
        public string Anh { get; set; }
        public string NgayChieu { get; set; }
        public string NoiDung { get; set; }
        public decimal? Gia { get; set; }
        public int? ThoiLuong { get; set; }

        public virtual TheLoai TheLoai { get; set; }
        public virtual ICollection<GioChieu> GioChieu { get; set; }
    }
}
