using Microsoft.AspNetCore.Mvc;
using P231FrontToBack.Entities;

namespace P231FrontToBack.Controllers
{
    public class PortfoliosController:Controller
    {
        readonly List<Portfolio> _context;

        public PortfoliosController()
        {
            _context = new()
            {
                new ()
                {
                    Id = 1,
                    Image = "cabin.png"
                },
                new ()
                {
                    Id = 2,
                    Image = "cake.png"
                },
                new ()
                {
                    Id = 3,
                    Image = "circus.png"
                }
            };
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            if (id <= 0) return BadRequest();
            Portfolio? portfolio = _context.Find(p=>p.Id == id);
            if (portfolio is null) return NotFound();
            return View(portfolio);
        }
    }
}
