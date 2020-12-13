using System;
using BeerHallEF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeerHallEF.Data.Mapping
{
    public class BrewerConfiguration:IEntityTypeConfiguration<Brewer>
    {
        public BrewerConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<Brewer> builder)
        {
            builder.ToTable("Brewer");

            builder.HasKey(t => t.BrewerId);

            builder.Property(t => t.Name)
                .HasColumnName("BrewerName")
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(t => t.ContactEmail)
                .HasMaxLength(100);

            builder.Property(t => t.Street)
                .HasMaxLength(100);
        }
    }
}
