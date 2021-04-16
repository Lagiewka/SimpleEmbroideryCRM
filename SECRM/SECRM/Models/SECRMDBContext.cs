using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SECRM.Models
{
    public partial class SECRMDBContext : DbContext
    {
        public SECRMDBContext()
        {
        }

        public SECRMDBContext(DbContextOptions<SECRMDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Color> Colors { get; set; }
        public virtual DbSet<Embroidery> Embroideries { get; set; }
        public virtual DbSet<EmbroideryColor> EmbroideryColors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-SSTUNK6\\SQLEXPRESS;Initial Catalog=SECRMDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Client>(entity =>
            {
                entity.ToTable("Client");

                entity.Property(e => e.ClientId).ValueGeneratedNever();

                entity.Property(e => e.Email).HasColumnType("text");

                entity.Property(e => e.Machine).HasColumnType("text");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Phone).HasColumnType("text");
            });

            modelBuilder.Entity<Color>(entity =>
            {
                entity.ToTable("Color");

                entity.Property(e => e.ColorId).ValueGeneratedNever();

                entity.Property(e => e.Catalog).HasColumnType("text");

                entity.Property(e => e.Code).HasColumnType("text");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("text");
            });

            modelBuilder.Entity<Embroidery>(entity =>
            {
                entity.ToTable("Embroidery");

                entity.Property(e => e.EmbroideryId).ValueGeneratedNever();

                entity.Property(e => e.BackPrice).HasColumnType("money");

                entity.Property(e => e.FrontPrice).HasColumnType("money");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasColumnType("image");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Observations).HasColumnType("text");

                entity.Property(e => e.ProgrammingPrice).HasColumnType("money");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Embroideries)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Embroidery_Client");
            });

            modelBuilder.Entity<EmbroideryColor>(entity =>
            {
                entity.ToTable("EmbroideryColor");

                entity.Property(e => e.EmbroideryColorId).ValueGeneratedNever();

                entity.HasOne(d => d.Color)
                    .WithMany(p => p.EmbroideryColors)
                    .HasForeignKey(d => d.ColorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmbroideryColor_Color");

                entity.HasOne(d => d.Embroidery)
                    .WithMany(p => p.EmbroideryColors)
                    .HasForeignKey(d => d.EmbroideryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmbroideryColor_Embroidery");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
