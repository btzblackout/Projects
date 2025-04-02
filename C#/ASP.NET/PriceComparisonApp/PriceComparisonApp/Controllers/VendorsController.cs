using Microsoft.AspNetCore.Mvc;
using PriceComparisonApp.Data;

namespace PriceComparisonApp.Controllers
{
    public class VendorsController : Controller
    {
        private readonly AppDbContext _context;

        public VendorsController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Vendors.ToList());
        }
    }
}
