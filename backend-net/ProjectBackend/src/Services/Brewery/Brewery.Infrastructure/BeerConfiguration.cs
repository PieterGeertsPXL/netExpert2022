using Brewery.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Brewery.Infrastructure
{
    internal class BeerConfiguration : IEntityTypeConfiguration<Beer>
    {
        public void Configure(EntityTypeBuilder<Beer> builder)
        {
            //rules
            builder.HasKey(x => x.Id);

            builder.HasOne(b => b.Brewer)
                .WithMany(b => b.Beers)
                .HasForeignKey(b => b.BrewerId);

            /*builder.HasOne<Brewer>()
                .WithMany()
                .HasForeignKey(beer => beer.BrewerId); ;
            builder.Property(x => x.BrewerId).IsRequired();*/


        
        }
    }
}
