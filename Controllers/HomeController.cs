using GhostShoes_Art_Site.Data;
using GhostShoes_Art_Site.Models;
using Microsoft.AspNetCore.Mvc;

namespace GhostShoes_Art_Site.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Gallery()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Commission()
        {
            return View(new CommissionInquiry());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Commission(CommissionInquiry inquiry)
        {
            if (!ModelState.IsValid)
            {
                return View(inquiry);
            }

            inquiry.SubmittedAt = DateTime.UtcNow;
            _context.CommissionInquiries.Add(inquiry);
            await _context.SaveChangesAsync();

            TempData["CommissionSuccess"] = "Thanks! Your commission inquiry has been sent.";
            return RedirectToAction(nameof(Commission));
        }
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}