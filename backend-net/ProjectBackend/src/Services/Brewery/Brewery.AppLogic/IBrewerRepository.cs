using Brewery.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brewery.AppLogic
{
    public interface IBrewerRepository
    {

        Task AddAsync(Brewer brewer);
    }
}
