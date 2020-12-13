using System;
using BeerHallEF.Data.Mapping;
using BeerHallEF.Models;
using Microsoft.EntityFrameworkCore;

namespace BeerHallEF.Data
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Brewer> Brewers { get; set; }
        public DbSet<Beer> Beers { get; set; }
        public DbSet<Location> Locations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionstring = @"Server=localhost,1433;User Id=sa;Password=Mezta840;Database=Beerhall;Integrated Security=false";
            optionsBuilder.UseSqlServer(connectionstring);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new BrewerConfiguration());
            modelBuilder.ApplyConfiguration(new BeerConfiguration());
            modelBuilder.ApplyConfiguration(new LocationConfiguration());
        }
    }
}
