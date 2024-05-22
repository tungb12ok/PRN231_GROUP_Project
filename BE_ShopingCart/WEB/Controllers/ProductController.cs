using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.Xml;

namespace WEB.Controllers
{
    public class ProductController : Controller
    {
        private readonly FPTshopContext _context;

        public ProductController(FPTshopContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult getProductAll()
        {
            var products = _context.Products
                .Include(s => s.StatusNavigation)                    
                .Where(x=> x.StatusNavigation.Name.SequenceEqual("Active"))
                .ToList();
            return StatusCode(200, products);
        }
        [HttpGet]
        public IActionResult getProductById(int id)
        {
            var products = _context.Products
                .Include(s => s.StatusNavigation)
                .Where(x => x.StatusNavigation.Name.SequenceEqual("Active") && x.Id == id)
                .FirstOrDefault();

            if(products == null)
            {
                return StatusCode(400, "Product doesn't exits!");
            }
            return StatusCode(200, products);
        }
    }
}
