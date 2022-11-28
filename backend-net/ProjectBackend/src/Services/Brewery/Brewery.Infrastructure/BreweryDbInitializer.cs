using Brewery.Domain;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Polly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brewery.Infrastructure
{
    internal class BreweryDbInitializer
    {
        private readonly BreweryDbContext _context;
        private readonly ILogger<BreweryDbContext> _logger;

        public BreweryDbInitializer(BreweryDbContext context, ILogger<BreweryDbContext> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void MigrateDatabase()
        {
            _logger.LogInformation("Migrating database associated with BreweryDbCOntext");

            try
            {
                //if the sql server container is not created on run docker compose this migration can't fail for network related exception.
                var retry = Policy.Handle<SqlException>()
                    .WaitAndRetry(new TimeSpan[]
                    {
                        TimeSpan.FromSeconds(3),
                        TimeSpan.FromSeconds(5),
                        TimeSpan.FromSeconds(8),
                    });
                //todo fix there is allready a 'brewer' in the DB SQLclient
                retry.Execute(() => _context.Database.Migrate());

                _logger.LogInformation("Migrated database associated with BreweryDbContext");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while migrating the database used on BreweryDbContext");
            }
        }
 /*       public void SeedData()
        {
            if (_context.Brewers.Any())
            {
                //Seeding already happened
                return;
            }
            if(_context.Beers.Any()) {
                return;
            }
            Beer stella = new Beer();
            stella.BrewerId = 1;
            stella.Name = "Stella Artois";
            stella.Description = "Pils";

            Beer primus = new Beer();
            primus.BrewerId = 2;
            primus.Name = "Primus";
            primus.Description = "Pils";

            _context.Beers.Add(stella);
            _context.Beers.Add(primus);

            Brewer inbev = new Brewer();
            inbev.Name = "Inbev";
            inbev.Id = 1;

            Brewer primusb = new Brewer();
            primusb.Id = 2;
            primusb.Name = "Primus";

            _context.Brewers.Add(inbev);
            _context.Brewers.Add(primusb);

            

            _context.SaveChanges();
        }*/
    }
}


