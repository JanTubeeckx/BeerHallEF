using System;
using BeerHallEF.Data;

namespace BeerHallEF
{
    class Program
    {
        static void Main(string[] args)
        {
            using(ApplicationDbContext context = new ApplicationDbContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                Console.WriteLine("Database created");
            }
        }
    }
}
