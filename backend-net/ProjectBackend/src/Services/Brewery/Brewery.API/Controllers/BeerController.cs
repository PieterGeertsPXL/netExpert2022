using Brewery.AppLogic;
using Brewery.Domain;
using Brewery.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Brewery.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BeerController : Controller
    {
        private IBeerRepository _beerDbRepository;

        public BeerController(IBeerRepository beerDbRepository)
        {
            _beerDbRepository = beerDbRepository;
        }

        [HttpGet]
        [Route("/all")]
        public List<Beer> getAllBeers()
        {
            return _beerDbRepository.GetAllAsync();
        }

        [HttpGet]
        [Route("/{brewerId}")]
        public List<Beer> getBeersFromBrewer(int brewerId)
        {
            return _beerDbRepository.GetBeersFromBrewer(brewerId);
        }


/*        • BR-00: als brouwer moet ik kunnen inloggen in het systeem via
het OpenId Connect protocol
• BR-01: als niet ingelogde gebruiker kan ik de biersoorten van
een bepaalde brouwer opvragen.
• BR-02: als brouwer kan ik een bier toevoegen(vereist login)
• BR-03: als brouwer kan ik een bier verwijderen(vereist login)
*/

    }
}
