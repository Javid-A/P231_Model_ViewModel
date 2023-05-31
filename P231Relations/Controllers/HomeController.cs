using Microsoft.AspNetCore.Mvc;
using P231Relations.DAL;
using P231Relations.Entities;

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
            List<Student> students = _context.Students.ToList();
            return View(students);
        }
    }
}
