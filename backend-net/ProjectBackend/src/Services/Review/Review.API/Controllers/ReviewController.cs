using Microsoft.AspNetCore.Mvc;
using Review.AppLogic;
using Review.Domain;
using static System.Net.Mime.MediaTypeNames;
using System;

namespace Review.API.Controllers
{
    public class ReviewController : Controller
    {
        private IReviewRepository _reviewRepository;

        public ReviewController(IReviewRepository reviewRepository )
        {
            _reviewRepository = reviewRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("/{retableItemid}")]
        public ActionResult PostReview(int retableItemId, [FromBody] Domain.Review review)
        {
            _reviewRepository.AddReview(retableItemId, review);
            return View();
        }

/*        R-00: als reviewer moet ik kunnen inloggen in het systeem
m.b.v.het OpenId Connect protocol
• R-01: als anonieme gebruiker kan ik bieren opvragen
gesorteerd volgens gemiddelde rating
• R-02: als ingelogde gebruiker kan ik een review indienen voor
een bier(dit kan slechts éénmalig). Een review bestaat uit een
rating en een beschrijvende tekst.
• R-03: als ingelogde gebruiker kan ik alle reviews van een bier
bekijken.*/
    }
}
