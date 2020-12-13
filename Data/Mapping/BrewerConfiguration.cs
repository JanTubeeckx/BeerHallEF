using System;
using BeerHallEF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeerHallEF.Data.Mapping
{
    internal class BrewerConfiguration:IEntityTypeConfiguration<Brewer>
    {
        public BrewerConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<Brewer> builder)
        {
            #region Table
            builder.ToTable("Brewer");
            #endregion

            #region Key and indices
            builder.HasKey(t => t.BrewerId);
            #endregion

            #region Properties
            builder.Property(t => t.Name)
                        .HasColumnName("BrewerName")
                        .IsRequired()
                        .HasMaxLength(100);

            builder.Property(t => t.ContactEmail)
                .HasMaxLength(100);

            builder.Property(t => t.Street)
                .HasMaxLength(100);
            #endregion

            builder.HasMany(t => t.Beers)
                .WithOne()
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
