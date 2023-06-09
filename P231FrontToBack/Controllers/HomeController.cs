﻿using Microsoft.AspNetCore.Mvc;
using P231FrontToBack.Entities;

namespace P231FrontToBack.Controllers
{
    public class HomeController:Controller
    {
        readonly List<Portfolio> _context;

        public HomeController()
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
            IEnumerable<Portfolio> portfolios = _context.AsEnumerable();
            return View(portfolios);
        }
    }
}
