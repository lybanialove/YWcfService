using Microsoft.EntityFrameworkCore;
using Service.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class Context: DbContext
    {
        public Context()
        {
            Database.EnsureCreated();
        }

        public DbSet<User> users { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Order> orders { get; set; }

        //kusya115murik
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=UserDb;Username=postgres;Password=2602;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(u => u.id);
            modelBuilder.Entity<Order>().HasKey(u => u.id);
            modelBuilder.Entity<Product>().HasKey(u => u.id);
        }
    }
}
