using Microsoft.AspNetCore.Mvc;
using P231Entities.Entities;

namespace P231Entities.Controllers
{
    public class ProductsController : Controller
    {
        private readonly List<Product> _context;
        public ProductsController()
        {
            _context = new List<Product>()
            {
                new Product()
                {
                    Id = 1,
                    Name = "Product 1",
                    SKU = "12345678",
                    Price = 24.56,
                    Image = "https://study.com/cimages/videopreview/capture_115896.jpg"
                },
                new Product()
                {
                    Id = 2,
                    Name = "Product 2",
                    SKU = "12345",
                    Price = 30.56,
                    Image = "https://www.shutterstock.com/image-photo/cosmetic-spa-medical-skincare-glass-260nw-2004249659.jpg"
                },
                new Product()
                {
                    Id = 3,
                    Name = "Product 3",
                    SKU = "87654321",
                    Price = 55.00,
                    Image = "https://img.freepik.com/premium-psd/bottle-product-mockup-psd-beauty-packaging_53876-130082.jpg"
                },
                new Product()
                {
                    Id = 4,
                    Name = "Product 4",
                    SKU = "123456",
                    Price = 100.76,
                    Image = "https://images.unsplash.com/photo-1523275335684-37898b6baf30?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Mnx8cHJvZHVjdHxlbnwwfHwwfHx8MA%3D%3D&w=1000&q=80"
                },
                new Product()
                {
                    Id = 5,
                    Name = "Product 5",
                    SKU = "8761234",
                    Price = 124.6,
                    Image = "https://images.unsplash.com/photo-1505740420928-5e560c06d30e?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8M3x8cHJvZHVjdHxlbnwwfHwwfHx8MA%3D%3D&w=1000&q=80"
                },
            };
        }
        public IActionResult Index()
        {
            return View(_context);
        }
        public IActionResult Details(int id)
        {
            if (id <= 0) return BadRequest();
            Product product = _context.FirstOrDefault(p=>p.Id == id);
            if (product is null) return NotFound();
            return View(product);
        }
    }
}
