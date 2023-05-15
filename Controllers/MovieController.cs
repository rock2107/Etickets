using Etickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Etickets.Controllers
{
    public class MovieController : Controller
    {
        private readonly AppDbContext _context;
        public MovieController(AppDbContext context)
        {
            _context = context;


        }
        public async Task<IActionResult> Index()
        {
            var Data = await _context.Movies.Include(n => n.Cinema).OrderBy(n=>n.Name).ToListAsync();
            return View(Data);
        }
    }
}
