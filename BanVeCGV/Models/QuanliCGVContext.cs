using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BanVeCGV.Models
{
    public partial class QuanliCGVContext : DbContext
    {
        public QuanliCGVContext()
        {
        }

        public QuanliCGVContext(DbContextOptions<QuanliCGVContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChiTietVePhim> ChiTietVePhim { get; set; }
        public virtual DbSet<DoAn> DoAn { get; set; }
        public virtual DbSet<DsVeBySuatChieu> DsVeBySuatChieu { get; set; }
        public virtual DbSet<Ghe> Ghe { get; set; }
        public virtual DbSet<GioChieu> GioChieu { get; set; }
        public virtual DbSet<MovieViewHome> MovieViewHome { get; set; }
        public virtual DbSet<Phim> Phim { get; set; }
        public virtual DbSet<Phong> Phong { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoan { get; set; }
        public virtual DbSet<TheLoai> TheLoai { get; set; }
        public virtual DbSet<VePhim> VePhim { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=QuanliCGV;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietVePhim>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.TenDoAn).HasMaxLength(500);

                entity.Property(e => e.VeId).HasColumnName("VeID");
            });

            modelBuilder.Entity<DoAn>(entity =>
            {
                entity.Property(e => e.DoAnId).HasColumnName("DoAnID");

                entity.Property(e => e.Gia).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TenDoAn)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<DsVeBySuatChieu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DsVeBySuatChieu");

                entity.Property(e => e.DienThoai).HasMaxLength(30);

                entity.Property(e => e.GioChieuId).HasColumnName("GioChieuID");

                entity.Property(e => e.HoTen)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TenDangNhap)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TenGhe)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TenKh)
                    .IsRequired()
                    .HasColumnName("TenKH")
                    .HasMaxLength(1000);

                entity.Property(e => e.TenPhong)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TongTien).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.VeId).HasColumnName("VeID");
            });

            modelBuilder.Entity<Ghe>(entity =>
            {
                entity.Property(e => e.GheId).HasColumnName("GheID");

                entity.Property(e => e.LuaChon).HasMaxLength(255);

                entity.Property(e => e.TenGhe)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.Phong)
                    .WithMany(p => p.Ghe)
                    .HasForeignKey(d => d.PhongId)
                    .HasConstraintName("FK__Ghe__PhongId__66603565");
            });

            modelBuilder.Entity<GioChieu>(entity =>
            {
                entity.Property(e => e.GioChieuId).HasColumnName("GioChieuID");

                entity.Property(e => e.GiaVe).HasDefaultValueSql("('')");

                entity.Property(e => e.TenGioChieu)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.MaPhimNavigation)
                    .WithMany(p => p.GioChieu)
                    .HasForeignKey(d => d.MaPhim)
                    .HasConstraintName("FK__GioChieu__MaPhim__693CA210");
            });

            modelBuilder.Entity<MovieViewHome>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MovieViewHome");

                entity.Property(e => e.Gia).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.NgayChieu).HasMaxLength(30);

                entity.Property(e => e.NoiDung).HasColumnType("text");

                entity.Property(e => e.PhimAnh).HasMaxLength(255);

                entity.Property(e => e.PhimId).HasColumnName("PhimID");

                entity.Property(e => e.TenPhim)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TenTheLoai)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TheLoaiAnh).HasMaxLength(255);

                entity.Property(e => e.TheLoaiId).HasColumnName("TheLoaiID");
            });

            modelBuilder.Entity<Phim>(entity =>
            {
                entity.Property(e => e.PhimId).HasColumnName("PhimID");

                entity.Property(e => e.Anh).HasMaxLength(255);

                entity.Property(e => e.Gia).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.NgayChieu).HasMaxLength(30);

                entity.Property(e => e.NoiDung).HasColumnType("text");

                entity.Property(e => e.TenPhim)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TheLoaiId).HasColumnName("TheLoaiID");

                entity.HasOne(d => d.TheLoai)
                    .WithMany(p => p.Phim)
                    .HasForeignKey(d => d.TheLoaiId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Phim__TheLoaiID__619B8048");
            });

            modelBuilder.Entity<Phong>(entity =>
            {
                entity.Property(e => e.PhongId).HasColumnName("PhongID");

                entity.Property(e => e.TenPhong)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TaiKhoan>(entity =>
            {
                entity.HasKey(e => e.TenDangNhap)
                    .HasName("PK__TaiKhoan__55F68FC17D45EBAE");

                entity.Property(e => e.TenDangNhap).HasMaxLength(255);

                entity.Property(e => e.HoTen)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.MatKhau)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.SoDienThoai)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.VaiTro)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TheLoai>(entity =>
            {
                entity.Property(e => e.TheLoaiId).HasColumnName("TheLoaiID");

                entity.Property(e => e.Anh).HasMaxLength(255);

                entity.Property(e => e.TenTheLoai)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<VePhim>(entity =>
            {
                entity.HasKey(e => e.VeId)
                    .HasName("PK__VePhim__B1C60039F769F369");

                entity.Property(e => e.VeId).HasColumnName("VeID");

                entity.Property(e => e.DienThoai)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GheId).HasColumnName("GheID");

                entity.Property(e => e.GioChieuId).HasColumnName("GioChieuID");

                entity.Property(e => e.TenDangNhap)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TenKh)
                    .IsRequired()
                    .HasColumnName("TenKH")
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.TongTien).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.Ghe)
                    .WithMany(p => p.VePhim)
                    .HasForeignKey(d => d.GheId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VePhim__GheID__72C60C4A");

                entity.HasOne(d => d.GioChieu)
                    .WithMany(p => p.VePhim)
                    .HasForeignKey(d => d.GioChieuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VePhim__GioChieu__71D1E811");

                entity.HasOne(d => d.TenDangNhapNavigation)
                    .WithMany(p => p.VePhim)
                    .HasForeignKey(d => d.TenDangNhap)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VePhim__TenDangN__70DDC3D8");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
