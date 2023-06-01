using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P231Relations.DAL;
using P231Relations.Entities;
using P231Relations.ViewModels;

namespace P231Relations.Controllers
{
    public class HomeController:Controller
    {
        private readonly RelationsDbContext _context;

        public HomeController(RelationsDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {  
            IEnumerable<Country> countries = _context.Countries.Include(c=>c.Capital).AsEnumerable();
            IEnumerable<Capital> capitals = _context.Capitals.AsEnumerable();
            CountryCapitalVM model = new()
            {
                Countries = countries,
                Capitals = capitals
            };

            return View(model);
        }
    }
}
