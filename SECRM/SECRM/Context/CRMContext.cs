using Microsoft.EntityFrameworkCore;
using SECRM.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SECRM.Context
{
    public class CRMContext : DbContext
    {
        public CRMContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=SchoolDB;Trusted_Connection=True;");
            optionsBuilder.UseSqlite("Data Source = SECRMDb.db;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmbroideryColor>()
                .HasKey(ec => new { ec.EmbroideryColorId });
            modelBuilder.Entity<EmbroideryColor>()
                .HasOne(ec => ec.Embroidery)
                .WithMany(e => e.EmbroideryColors)
                .HasForeignKey(ec => ec.EmbroideryId);
            modelBuilder.Entity<EmbroideryColor>()
                .HasOne(ec => ec.Color)
                .WithMany(c => c.EmbroideryColors)
                .HasForeignKey(ec => ec.ColorId);
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Embroidery> Embroideries { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<EmbroideryColor> EmbroideryColors { get; set; }

    }
}
