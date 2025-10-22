using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieReviewSite.Data;
using MovieReviewSite.Models;

namespace MovieReviewSite.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<MoviesController> _logger;

        public MoviesController(ApplicationDbContext context, ILogger<MoviesController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: Movies
        public async Task<IActionResult> Index()
        {
            var movies = await _context.Movies.Include(m => m.Reviews).ToListAsync();
            return View(movies);
        }

        // GET: Movies/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var movie = await _context.Movies
                .Include(m => m.Reviews)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (movie == null) return NotFound();
            return View(movie);
        }

        // GET: Movies/Create
        public IActionResult Create() => View();

        // POST: Movies/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(movie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }

        // GET: Movies/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var movie = await _context.Movies.FindAsync(id);
            if (movie == null) return NotFound();
            return View(movie);
        }

        // POST: Movies/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Movie movie)
        {
            if (id != movie.Id) return BadRequest();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(movie);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await _context.Movies.AnyAsync(e => e.Id == id))
                        return NotFound();
                    else
                        throw;
                }
            }
            return View(movie);
        }

        // GET: Movies/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var movie = await _context.Movies.FindAsync(id);
            if (movie == null) return NotFound();
            return View(movie);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var movie = await _context.Movies.FindAsync(id);
            if (movie == null) return NotFound();

            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}