using Microsoft.EntityFrameworkCore;
using Restaurants.Domains.Entities.Restaurant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Restaurants.Infrastructure.Persistence.Data
{
    public class RestaurantDbContext : DbContext
    {
        public RestaurantDbContext(DbContextOptions options) 
            : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AssemblyInformation).Assembly);
        }


        // define the Dbsets from entities 
        public DbSet<restaurant> Restaurants { get; set; }
        public DbSet<table> Tables { get; set; }
    }
}
