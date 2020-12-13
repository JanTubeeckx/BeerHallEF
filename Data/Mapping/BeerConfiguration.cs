using System;
using BeerHallEF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeerHallEF.Data.Mapping
{
    internal class BeerConfiguration : IEntityTypeConfiguration<Beer>
    {
        public void Configure(EntityTypeBuilder<Beer> builder)
        {
            builder.ToTable("Beer");

            builder.Property(t => t.Name)
                   .IsRequired()
                   .HasMaxLength(100);
        }
    }
}
