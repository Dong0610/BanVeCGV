using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BanVeCGV.Models
{
    public partial class ChiTietVePhim
    {
        public int VeId { get; set; }
        public int MaDoAn { get; set; }
        public string TenDoAn { get; set; }
        public int SoLuong { get; set; }
        public double? GiaMon { get; set; }
        public double? ThanhTien { get; set; }
    }
}
