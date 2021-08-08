using System;
using Concierge.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Concierge.Dal
{
    public class ConciergeDBContext : IdentityDbContext<ApplicationUser>
    {

        public ConciergeDBContext(DbContextOptions<ConciergeDBContext> options)
          : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


        }
    }
    }
