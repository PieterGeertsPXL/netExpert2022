using Brewery.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brewery.Infrastructure
{
    internal class BrewerConfiguration : IEntityTypeConfiguration<Brewer>
    {
        public void Configure(EntityTypeBuilder<Brewer> builder)
        {
            builder.Property(bre => bre.Name).IsRequired();

            // configures one-to-many relationship
            /*builder
            .HasMany(e => e.Beers)
            .WithOne(e => e.Brewer)
            .HasForeignKey(e => e.BrewerId);*/

        }
    }
}
