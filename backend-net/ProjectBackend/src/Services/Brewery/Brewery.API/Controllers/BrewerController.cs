using Brewery.AppLogic;
using Brewery.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Brewery.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BrewerController : Controller
    {
        private readonly IBeerRepository _beerRepository;
        private readonly IBrewerRepository _brewerRepository;

        public BrewerController(IBeerRepository beerRepository, IBrewerRepository brewerRepository) {
            _brewerRepository= brewerRepository;
            _beerRepository = beerRepository;
        }
        [HttpPost] 
        [Authorize(policy: "write")]
        [Route("/addbeer")]
        public ActionResult PostNewBeer([FromBody]Beer beer)
        {
            _beerRepository.AddAsync(beer);
            return Ok(beer);
        }

        [HttpPost] //change
        [Route("/addbrewer")]
        public ActionResult PostNewBrewer([FromBody] Brewer brewer) {
            _brewerRepository.AddAsync(brewer);
            return Ok(brewer);
        }


        [HttpDelete]
        [Route("/{id}")]
        public ActionResult DeleteBeer(int id)
        {
            _beerRepository.RemoveBeer(id);
            return Ok();
        }
    }
}
