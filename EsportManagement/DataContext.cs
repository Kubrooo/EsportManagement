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

    }
}
