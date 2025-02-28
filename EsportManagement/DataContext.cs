using EsportManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsportManagement
{
    class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;database=esportDb;Trusted_Connection = true;TrustServerCertificate = true;");
        }

        public DbSet<Pemain> Pemains { get; set; }
        public DbSet<Tim> Tims { get; set; }
        public DbSet<Pertandingan> Pertandingans { get; set; }
        public DbSet<Hadiah> Hadiahs { get; set; }
        public DbSet<Sponsor> Sponsors { get; set; }
        public DbSet<Turnament> Tournaments { get; set; }
        public DbSet<Administrator> Administrators { get; set; }

        public DbSet<ViewPlayerSummary> ViewPlayerSummaries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Konfigurasi View sebagai entitas tanpa primary key
            modelBuilder.Entity<ViewPlayerSummary>().HasNoKey().ToView("View_PlayerSummary");

            modelBuilder.Entity<Pertandingan>()
                .HasOne(p => p.Tim1)
                .WithMany()
                .HasForeignKey(p => p.Tim_Id1)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Pertandingan>()
                .HasOne(p => p.Tim2)
                .WithMany()
                .HasForeignKey(p => p.Tim_Id2)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Pertandingan>()
                .HasOne(p => p.Pemenang)
                .WithMany()
                .HasForeignKey(p => p.Pemenang_Id)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Pertandingan>()
                .HasOne(p => p.Turnament)
                .WithMany()
                .HasForeignKey(p => p.Turnament_Id)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Hadiah>()
                .HasOne(h => h.Sponsor)
                .WithMany()
                .HasForeignKey(h => h.SponsorId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Hadiah>()
                .HasOne(h => h.Turnament)
                .WithMany()
                .HasForeignKey(h => h.TurnamentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Hadiah>()
                .HasOne(h => h.Tim)
                .WithMany()
                .HasForeignKey(h => h.TimId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Pemain>()
                .HasOne(p => p.Tim)
                .WithMany()
                .HasForeignKey(p => p.Tim_Id)
                .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
