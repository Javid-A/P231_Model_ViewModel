using Microsoft.AspNetCore.Mvc;

namespace P231FrontToBack.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
