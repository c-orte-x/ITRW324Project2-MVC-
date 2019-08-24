using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ITRW324Project2_MVC_
{
    public partial class ITRW324Project2Context : DbContext
    {
        public ITRW324Project2Context()
        {
        }

        public ITRW324Project2Context(DbContextOptions<ITRW324Project2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<BookedCourt> BookedCourt { get; set; }
        public virtual DbSet<Booking> Booking { get; set; }
        public virtual DbSet<Court> Court { get; set; }
        public virtual DbSet<HostedAt> HostedAt { get; set; }
        public virtual DbSet<OccupiedCourt> OccupiedCourt { get; set; }
        public virtual DbSet<User> User { get; set; }
        public DbQuery<Models.MultipleTablesJoinData> MultipleTablesJoinData { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("Server=den1.mysql6.gear.host;Database=ITRW324Project2;Uid=itrw324project2;Pwd=Hr0T3_Bxx-rj;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<BookedCourt>(entity =>
            {
                entity.ToTable("booked_court", "itrw324project2");

                entity.HasIndex(e => e.BookingId)
                    .HasName("FK_BC_BookingID_idx");

                entity.HasIndex(e => e.CourtId)
                    .HasName("FK_BC_CourtID_idx");

                entity.Property(e => e.BookedCourtId)
                    .HasColumnName("BookedCourtID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BookedCourtStatus)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.BookingId)
                    .HasColumnName("BookingID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CourtId)
                    .HasColumnName("CourtID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NumberOfBookings).HasColumnType("int(11)");

                entity.HasOne(d => d.Booking)
                    .WithMany(p => p.BookedCourt)
                    .HasForeignKey(d => d.BookingId)
                    .HasConstraintName("FK_BC_BookingID");

                entity.HasOne(d => d.Court)
                    .WithMany(p => p.BookedCourt)
                    .HasForeignKey(d => d.CourtId)
                    .HasConstraintName("FK_BC_CourtID");
            });

            modelBuilder.Entity<Booking>(entity =>
            {
                entity.ToTable("booking", "itrw324project2");

                entity.HasIndex(e => e.UserId)
                    .HasName("FK_BO_PlayerID_idx");

                entity.Property(e => e.BookingId)
                    .HasColumnName("BookingID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BookingMadeBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Booking)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_BO_UserID");
            });

            modelBuilder.Entity<Court>(entity =>
            {
                entity.ToTable("court", "itrw324project2");

                entity.Property(e => e.CourtId)
                    .HasColumnName("CourtID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CourtNum)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CourtStatus)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HostedAt>(entity =>
            {
                entity.HasKey(e => e.HostId);

                entity.ToTable("hosted_at", "itrw324project2");

                entity.HasIndex(e => e.OccupiedCourtId)
                    .HasName("FK_HA_OccupiedCourtID_idx");

                entity.HasIndex(e => e.UserId)
                    .HasName("FK_HA_PlayerID_idx");

                entity.Property(e => e.HostId)
                    .HasColumnName("HostID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OccupiedCourtId)
                    .HasColumnName("OccupiedCourtID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.OccupiedCourt)
                    .WithMany(p => p.HostedAt)
                    .HasForeignKey(d => d.OccupiedCourtId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HA_OccupiedCourtID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.HostedAt)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HA_UserID");
            });

            modelBuilder.Entity<OccupiedCourt>(entity =>
            {
                entity.ToTable("occupied_court", "itrw324project2");

                entity.HasIndex(e => e.BookingId)
                    .HasName("FK_OC_BookingID_idx");

                entity.HasIndex(e => e.CourtId)
                    .HasName("FK_OC_CourtID_idx");

                entity.Property(e => e.OccupiedCourtId)
                    .HasColumnName("OccupiedCourtID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BookingId)
                    .HasColumnName("BookingID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CourtId)
                    .HasColumnName("CourtID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Booking)
                    .WithMany(p => p.OccupiedCourt)
                    .HasForeignKey(d => d.BookingId)
                    .HasConstraintName("FK_OC_BookingID");

                entity.HasOne(d => d.Court)
                    .WithMany(p => p.OccupiedCourt)
                    .HasForeignKey(d => d.CourtId)
                    .HasConstraintName("FK_OC_CourtID");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user", "itrw324project2");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserFirstName)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.UserGender)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.UserLastName)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.UserPhoneNum)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });
        }
    }
}
