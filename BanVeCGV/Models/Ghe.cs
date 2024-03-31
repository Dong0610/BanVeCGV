using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BanVeCGV.Models
{
    public partial class Ghe
    {
        public Ghe()
        {
            VePhim = new HashSet<VePhim>();
        }

        public int GheId { get; set; }
        public string TenGhe { get; set; }
        public string LuaChon { get; set; }
        public int? PhongId { get; set; }

        public virtual Phong Phong { get; set; }
        public virtual ICollection<VePhim> VePhim { get; set; }
    }
}
