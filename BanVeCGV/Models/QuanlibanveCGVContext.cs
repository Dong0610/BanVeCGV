using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BanVeCGV.Models
{
    public partial class QuanlibanveCGVContext : DbContext
    {
        public QuanlibanveCGVContext()
        {
        }

        public QuanlibanveCGVContext(DbContextOptions<QuanlibanveCGVContext> options)
            : base(options)
        {
        }

        public virtual DbSet<InvoiceDetails> InvoiceDetails { get; set; }
        public virtual DbSet<Invoices> Invoices { get; set; }
        public virtual DbSet<Movies> Movies { get; set; }
        public virtual DbSet<Screenings> Screenings { get; set; }
        public virtual DbSet<Tickets> Tickets { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
				String cnn= @"Data Source=.\SQLEXPRESS;AttachDbFilename=""C:\SQL2022\QuanlibanveCGV.mdf"";
                          Integrated Security=True;
                          Connect Timeout=30;
                          User Instance=True";
                String relCnn = "Server=.\\SQLExpress;Database=QuanlibanveCGV;Trusted_Connection=True;";
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
				optionsBuilder.UseSqlServer(relCnn);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InvoiceDetails>(entity =>
            {
                entity.HasKey(e => e.InvoiceDetailId)
                    .HasName("PK__InvoiceD__1F1578F1122A6313");

                entity.Property(e => e.InvoiceDetailId).HasColumnName("InvoiceDetailID");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(1200)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TicketId).HasColumnName("TicketID");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.InvoiceDetails)
                    .HasForeignKey(d => d.InvoiceId)
                    .HasConstraintName("FK__InvoiceDe__Invoi__6B24EA82");

                entity.HasOne(d => d.Ticket)
                    .WithMany(p => p.InvoiceDetails)
                    .HasForeignKey(d => d.TicketId)
                    .HasConstraintName("FK__InvoiceDe__Ticke__6C190EBB");
            });

            modelBuilder.Entity<Invoices>(entity =>
            {
                entity.HasKey(e => e.InvoiceId)
                    .HasName("PK__Invoices__D796AAD55F5EA465");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.CreatedTime)
                    .HasMaxLength(1200)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName).HasMaxLength(500);

                entity.Property(e => e.CustomerPhome)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Invoices__UserID__68487DD7");
            });

            modelBuilder.Entity<Movies>(entity =>
            {
                entity.HasKey(e => e.MovieId)
                    .HasName("PK__Movies__4BD2943AE4AC7AE3");

                entity.Property(e => e.MovieId).HasColumnName("MovieID");

                entity.Property(e => e.Actors)
                    .HasMaxLength(1200)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Director)
                    .HasMaxLength(1200)
                    .IsUnicode(false);

                entity.Property(e => e.Genre)
                    .HasMaxLength(1200)
                    .IsUnicode(false);

                entity.Property(e => e.MovieName).HasMaxLength(1200);

                entity.Property(e => e.TrailerLink)
                    .HasMaxLength(1200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Screenings>(entity =>
            {
                entity.HasKey(e => e.ScreeningId)
                    .HasName("PK__Screenin__7734E46C8CBFCE9E");

                entity.Property(e => e.ScreeningId).HasColumnName("ScreeningID");

                entity.Property(e => e.MovieId).HasColumnName("MovieID");

                entity.Property(e => e.Room)
                    .HasMaxLength(1200)
                    .IsUnicode(false);

                entity.Property(e => e.Times)
                    .HasMaxLength(1200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.Screenings)
                    .HasForeignKey(d => d.MovieId)
                    .HasConstraintName("FK__Screening__Movie__619B8048");
            });

            modelBuilder.Entity<Tickets>(entity =>
            {
                entity.HasKey(e => e.TicketId)
                    .HasName("PK__Tickets__712CC6278A26831D");

                entity.Property(e => e.TicketId).HasColumnName("TicketID");

                entity.Property(e => e.ScreeningId).HasColumnName("ScreeningID");

                entity.Property(e => e.SeatNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Screening)
                    .WithMany(p => p.Tickets)
                    .HasForeignKey(d => d.ScreeningId)
                    .HasConstraintName("FK__Tickets__Screeni__6477ECF3");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Tickets)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Tickets__UserID__656C112C");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__Users__1788CCAC5F1AE0AA");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Email)
                    .HasMaxLength(1200)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(1200)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserName).HasMaxLength(1200);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
