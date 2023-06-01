using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P231Relations.DAL;
using P231Relations.Entities;

namespace P231Relations.Controllers
{
    public class CountriesController:Controller
    {
        private readonly RelationsDbContext _context;

        public CountriesController(RelationsDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<Country> countries = _context.Countries.Include(c=>c.Cities).AsEnumerable();
            return View(countries);
        }
    }
}
