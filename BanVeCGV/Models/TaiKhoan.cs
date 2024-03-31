using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BanVeCGV.Models
{
    public partial class TaiKhoan
    {
        public TaiKhoan()
        {
            VePhim = new HashSet<VePhim>();
        }

        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string HoTen { get; set; }
        public string SoDienThoai { get; set; }
        public string VaiTro { get; set; }

        public virtual ICollection<VePhim> VePhim { get; set; }
    }
}
