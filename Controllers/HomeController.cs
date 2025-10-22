using Microsoft.AspNetCore.Mvc;
using MovieReviewSite.Data;
using MovieReviewSite.Models;
using Microsoft.EntityFrameworkCore;

namespace MovieReviewSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var movies = await _context.Movies
                .Include(m => m.Reviews)
                .OrderByDescending(m => m.Id)
                .ToListAsync();

            return View(movies); 
        }


        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        // ------------------ Contact POST ------------------
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Contact(ContactViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            ViewBag.Message = "Thank you! Your message has been sent successfully.";
            ModelState.Clear();
            return View();
        }
    }
}
