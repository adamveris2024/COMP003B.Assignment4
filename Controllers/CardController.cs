using Microsoft.AspNetCore.Mvc;
using COMP003B.Assignment4.Models;

namespace COMP003B.Assignment4.Controllers
{
    public class CardController : Controller
    {
        public IActionResult Index()
        {
            var cards = new List<CardList>
            {
                new CardList
                { Id = 1, Title = "BloomBurrow", Summary = "Bloomburrow is the 101st Magic expansion. It was released on August 2, 2024."
                },
                new CardList
                { Id = 2, Title = "Duskmourn: House of Horrors", Summary = "Duskmourn: House of Horror is the 102nd Magic expansion. It was released on September 27, 2024."
                },
                new CardList
                { Id = 3, Title = "Aetherdrift", Summary = "Aetherdrift is the 103rd Magic expansion and was released on February 14, 2025." }

            };

            return View(cards);
        }
    }
}
