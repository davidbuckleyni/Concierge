using System;
using Concierge.Dal.Configuration;
using Concierge.Models;

using Microsoft.EntityFrameworkCore;

namespace Concierge.Dal
{
    public class ConciergeDBContext : DbContext
    {
      
        public ConciergeDBContext(DbContextOptions<ConciergeDBContext> options)
          : base(options)
        {

        }
        public DbSet<AppSettings> Appsettings { get; set; }

        public DbSet<Building> Buildings { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<Rooms> Rooms { get; set; }


        public DbSet<StockItems> StockItem { get; set; }

        public DbSet<SalesOrder> SalesOrders { get; set; }

        public DbSet<SalesOrderItems> SalesOrderItems { get; set; }
        public DbSet<Tables> Tables { get; set; }

        public DbSet<Amenitie> Amenities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


        }
    }
    }
