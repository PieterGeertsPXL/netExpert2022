using Brewery.AppLogic;
using Brewery.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brewery.Infrastructure
{
    internal class BeerDbRepository : IBeerRepository
    {
        private BreweryDbContext _breweryDbContext;

        public BeerDbRepository(BreweryDbContext breweryDbContext)
        {
            _breweryDbContext = breweryDbContext;

        }

        public async Task AddAsync(Beer beer)
        {
            _breweryDbContext.Beers.Add(beer);
            Brewer brewer = _breweryDbContext.Brewers.FirstOrDefault(brewer => brewer.Id == beer.BrewerId);
            brewer.Beers.Add(beer);
            _breweryDbContext.SaveChangesAsync();
           
        }

        public List<Beer> GetAllAsync()
        {
            return _breweryDbContext.Beers.ToList();
        }

        public List<Beer> GetBeersFromBrewer(int brewerId)
        {
            return _breweryDbContext.Beers.Where(b => b.BrewerId == brewerId).ToList();
        }

        public async Task<Beer?> GetByIdAsync(int id)
        {
            return await _breweryDbContext.Beers.FindAsync(id);
        }

        public void RemoveBeer(int id)
        {
            Beer beer = _breweryDbContext.Beers.Find(id);
            _breweryDbContext.Remove(beer);
            _breweryDbContext.SaveChanges();
        }
    }
}
