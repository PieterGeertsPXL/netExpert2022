using Brewery.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brewery.AppLogic
{
    public interface IBeerRepository
    {
        Task AddAsync(Beer beer);
        List<Beer> GetAllAsync();
        List<Beer> GetBeersFromBrewer(int brewerId);
        Task<Beer?> GetByIdAsync(int id);

        void RemoveBeer(int id);
    }
}
