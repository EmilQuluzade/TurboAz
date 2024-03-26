using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Turbo.az.DAL;

namespace Turbo.az.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public readonly AppDbContex _context;
        public HomeController(AppDbContex context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DataTable()
        {
            var products = _context.Markas.ToList();
            return View(products);
        }

    }
}
