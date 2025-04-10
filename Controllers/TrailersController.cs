using Microsoft.AspNetCore.Mvc;
using COMP003B.Assignment4.Models;

namespace COMP003B.Assignment4.Controllers
{
    public class TrailersController : Controller
    {
        public IActionResult Index()
        {
            var trailers = new List<ReleaseTrailers>
            {
                new ReleaseTrailers
                { Id = 1, Title = "BloomBurrow -  Release Trailer", Summary = "Bloomburrow is the first set in the Dragonstorm Arc. A ragtag team of anthropomorphic adventurers must band together to go on an important quest to save the realm from elemental calamity beasts and the Great-Night Owl."
                },
                new ReleaseTrailers
                { Id = 2, Title = "Duskmourn: House of Horrors - Release Trailer", Summary = "Duskmourn is set in the world of Duskmourn, which consists of one giant haunted mansion filled with horrors and is ruled by the demonic Valgavoth. The entire set takes place within its eerie walls."
                },
                new ReleaseTrailers
                { Id = 3, Title = "Aetherdrift - Release Trailer", Summary = "Aetherdrift follows Chandra Nalaar as she competes in the Ghirapur Grand Prix, a death-defying interplanar circuit race across Amonkhet, Avishkar and Muraganda." }

            };

            return View(trailers);
        }
    }
}
