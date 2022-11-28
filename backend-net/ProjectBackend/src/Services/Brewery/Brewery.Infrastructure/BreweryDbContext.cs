using Brewery.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brewery.Infrastructure
{
    internal class BreweryDbContext : DbContext
    {
        public DbSet<Beer> Beers { get; set; }
        public DbSet<Brewer> Brewers { get; set; }
       

        public BreweryDbContext(DbContextOptions options) : base(options) { }

    }
}
