using System;
using System.Data.Entity;
using Concierge.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Concierge.Dal
{
    public class ConciergeDBContext : IdentityDbContext<ApplicationUser>
    {
 

        public ConciergeDBContext(DbContextOptions<ConciergeDBContext> options)
          : base(options)
        {

        }
        public Microsoft.EntityFrameworkCore.DbSet<Building> Buildings { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Person> Person { get; set; }

        public Microsoft.EntityFrameworkCore.DbSet<Rooms> Rooms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


        }
    }
    }
