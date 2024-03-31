using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BanVeCGV.Models
{
    public partial class MovieViewHome
    {
        public int PhimId { get; set; }
        public int TheLoaiId { get; set; }
        public string TenPhim { get; set; }
        public string PhimAnh { get; set; }
        public string NgayChieu { get; set; }
        public string NoiDung { get; set; }
        public decimal? Gia { get; set; }
        public int? ThoiLuong { get; set; }
        public string TenTheLoai { get; set; }
        public string TheLoaiAnh { get; set; }
    }
}
