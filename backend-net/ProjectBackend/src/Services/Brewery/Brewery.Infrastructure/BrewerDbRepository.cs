using Brewery.AppLogic;
using Brewery.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brewery.Infrastructure
{
    internal class BrewerDbRepository : IBrewerRepository
    {
        private BreweryDbContext _breweryDbContext;

        public BrewerDbRepository(BreweryDbContext breweryDbContext)
        {
            _breweryDbContext = breweryDbContext;

        }

        public async Task AddAsync(Brewer brewer)
        {
            _breweryDbContext.AddAsync(brewer);
            await _breweryDbContext.SaveChangesAsync();
            
        }
    }
}
