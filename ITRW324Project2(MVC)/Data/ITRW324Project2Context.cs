using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Final
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

        public virtual DbSet<Aspnetroleclaims> Aspnetroleclaims { get; set; }
        public virtual DbSet<Aspnetroles> Aspnetroles { get; set; }
        public virtual DbSet<Aspnetuserclaims> Aspnetuserclaims { get; set; }
        public virtual DbSet<Aspnetuserlogins> Aspnetuserlogins { get; set; }
        public virtual DbSet<Aspnetuserroles> Aspnetuserroles { get; set; }
        public virtual DbSet<Aspnetusers> Aspnetusers { get; set; }
        public virtual DbSet<Aspnetusertokens> Aspnetusertokens { get; set; }
        public virtual DbSet<BookedCourt> BookedCourt { get; set; }
        public virtual DbSet<Booking> Booking { get; set; }
        public virtual DbSet<Court> Court { get; set; }
        public virtual DbSet<HostedAt> HostedAt { get; set; }
        public virtual DbSet<OccupiedCourt> OccupiedCourt { get; set; }
        public virtual DbSet<User> User { get; set; }

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

            modelBuilder.Entity<Aspnetroleclaims>(entity =>
            {
                entity.ToTable("aspnetroleclaims", "itrw324project2");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_AspNetRoleClaims_RoleId");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClaimType).HasColumnType("longtext");

                entity.Property(e => e.ClaimValue).HasColumnType("longtext");

                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Aspnetroleclaims)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_AspNetRoleClaims_AspNetRoles_RoleId");
            });

            modelBuilder.Entity<Aspnetroles>(entity =>
            {
                entity.ToTable("aspnetroles", "itrw324project2");

                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ConcurrencyStamp).HasColumnType("longtext");

                entity.Property(e => e.Name)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.NormalizedName)
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Aspnetuserclaims>(entity =>
            {
                entity.ToTable("aspnetuserclaims", "itrw324project2");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_AspNetUserClaims_UserId");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClaimType).HasColumnType("longtext");

                entity.Property(e => e.ClaimValue).HasColumnType("longtext");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Aspnetuserclaims)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_AspNetUserClaims_AspNetUsers_UserId");
            });

            modelBuilder.Entity<Aspnetuserlogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.ToTable("aspnetuserlogins", "itrw324project2");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_AspNetUserLogins_UserId");

                entity.Property(e => e.LoginProvider)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderKey)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderDisplayName).HasColumnType("longtext");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Aspnetuserlogins)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_AspNetUserLogins_AspNetUsers_UserId");
            });

            modelBuilder.Entity<Aspnetuserroles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.ToTable("aspnetuserroles", "itrw324project2");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_AspNetUserRoles_RoleId");

                entity.Property(e => e.UserId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Aspnetuserroles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_AspNetUserRoles_AspNetRoles_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Aspnetuserroles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_AspNetUserRoles_AspNetUsers_UserId");
            });

            modelBuilder.Entity<Aspnetusers>(entity =>
            {
                entity.ToTable("aspnetusers", "itrw324project2");

                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AccessFailedCount).HasColumnType("int(11)");

                entity.Property(e => e.ConcurrencyStamp).HasColumnType("longtext");

                entity.Property(e => e.Email)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.EmailConfirmed).HasColumnType("bit(1)");

                entity.Property(e => e.LockoutEnabled).HasColumnType("bit(1)");

                entity.Property(e => e.LockoutEnd).HasColumnType("datetime(6)");

                entity.Property(e => e.NormalizedEmail)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.NormalizedUserName)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.PasswordHash).HasColumnType("longtext");

                entity.Property(e => e.PhoneNumber).HasColumnType("longtext");

                entity.Property(e => e.PhoneNumberConfirmed).HasColumnType("bit(1)");

                entity.Property(e => e.SecurityStamp).HasColumnType("longtext");

                entity.Property(e => e.TwoFactorEnabled).HasColumnType("bit(1)");

                entity.Property(e => e.UserName)
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Aspnetusertokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.ToTable("aspnetusertokens", "itrw324project2");

                entity.Property(e => e.UserId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LoginProvider)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Value).HasColumnType("longtext");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Aspnetusertokens)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_AspNetUserTokens_AspNetUsers_UserId");
            });

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

                entity.Property(e => e.CourtNr).HasColumnType("int(11)");

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
