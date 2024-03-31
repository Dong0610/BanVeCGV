using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BanVeCGV.Models
{
    public partial class VePhim
    {
        public int VeId { get; set; }
        public string TenDangNhap { get; set; }
        public int GioChieuId { get; set; }
        public int GheId { get; set; }
        public string TenKh { get; set; }
        public string DienThoai { get; set; }
        public decimal? TongTien { get; set; }
        public int? SoLuongVe { get; set; }

        public virtual Ghe Ghe { get; set; }
        public virtual GioChieu GioChieu { get; set; }
        public virtual TaiKhoan TenDangNhapNavigation { get; set; }
    }
}
