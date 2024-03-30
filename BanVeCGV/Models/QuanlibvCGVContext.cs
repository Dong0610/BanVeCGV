using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BanVeCGV.Models
{
    public partial class QuanlibvCGVContext : DbContext
    {
        public QuanlibvCGVContext()
        {
        }

        public QuanlibvCGVContext(DbContextOptions<QuanlibvCGVContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<InvoiceDetails> InvoiceDetails { get; set; }
        public virtual DbSet<Invoices> Invoices { get; set; }
        public virtual DbSet<Movies> Movies { get; set; }
        public virtual DbSet<Revenue> Revenue { get; set; }
        public virtual DbSet<Tickets> Tickets { get; set; }
        public virtual DbSet<TimeScreening> TimeScreening { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Voucher> Voucher { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

				string databasePath = Path.Combine(Application.StartupPath, "Database\\QuanlibvCGV.mdf");
				String cnn = @"Data Source=.\SQLEXPRESS;AttachDbFilename="+databasePath+"; " +
                    "Integrated Security=True;Connect Timeout=30;User Instance=True";


#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
				optionsBuilder.UseSqlServer(cnn);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(1000);
            });

            modelBuilder.Entity<InvoiceDetails>(entity =>
            {
                entity.HasKey(e => new { e.InvoiceId, e.TicketId })
                    .HasName("PK");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.TicketId).HasColumnName("TicketID");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(1200)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.InvoiceDetails)
                    .HasForeignKey(d => d.InvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__InvoiceDe__Invoi__7F2BE32F");

                entity.HasOne(d => d.Ticket)
                    .WithMany(p => p.InvoiceDetails)
                    .HasForeignKey(d => d.TicketId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__InvoiceDe__Ticke__00200768");
            });

            modelBuilder.Entity<Invoices>(entity =>
            {
                entity.HasKey(e => e.InvoiceId)
                    .HasName("PK__Invoices__D796AAD519BBB142");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.CreatedTime)
                    .HasMaxLength(1200)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName).HasMaxLength(500);

                entity.Property(e => e.CustomerPhome)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MovieName)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.VoucherCode)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.HasOne(d => d.CreatUs)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.CreatUsId)
                    .HasConstraintName("FK__Invoices__CreatU__7C4F7684");

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.MovieId)
                    .HasConstraintName("FK__Invoices__MovieI__797309D9");
            });

            modelBuilder.Entity<Movies>(entity =>
            {
                entity.Property(e => e.Actor)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Descripion)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Director)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .HasDefaultValueSql("(N'')");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Movies)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__Movies__Category__6B24EA82");
            });

            modelBuilder.Entity<Revenue>(entity =>
            {
                entity.Property(e => e.MovieId).HasColumnName("MovieID");

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.Revenue)
                    .HasForeignKey(d => d.MovieId)
                    .HasConstraintName("FK__Revenue__MovieID__02FC7413");
            });

            modelBuilder.Entity<Tickets>(entity =>
            {
                entity.HasKey(e => e.TicketId)
                    .HasName("PK__Tickets__712CC627C85DB934");

                entity.Property(e => e.TicketId).HasColumnName("TicketID");

                entity.Property(e => e.ScreeningId).HasColumnName("ScreeningID");

                entity.Property(e => e.SeatNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Screening)
                    .WithMany(p => p.Tickets)
                    .HasForeignKey(d => d.ScreeningId)
                    .HasConstraintName("FK__Tickets__Screeni__73BA3083");
            });

            modelBuilder.Entity<TimeScreening>(entity =>
            {
                entity.Property(e => e.MovieId).HasColumnName("MovieID");

                entity.Property(e => e.RoomNumber)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Times)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.TimeScreening)
                    .HasForeignKey(d => d.MovieId)
                    .HasConstraintName("FK__TimeScree__Movie__6E01572D");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UsId)
                    .HasName("PK__Users__BD21E35F3ADD7DBA");

                entity.Property(e => e.AccountType).HasDefaultValueSql("((1))");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.UsName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<Voucher>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'')");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
