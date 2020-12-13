using System;
using Microsoft.EntityFrameworkCore;

namespace BeerHallEF.Data
{
    public class ApplicationDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionstring = @"Server=localhost,1433;User Id=sa;Password=Mezta840;Database=Beerhall;Integrated Security=true";
            optionsBuilder.UseSqlServer(connectionstring);
        }
    }
}
