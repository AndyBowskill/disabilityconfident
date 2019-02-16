using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DisabledConfidentWebsite.Data;
using DisabledConfidentWebsite.Models;
using System;

namespace DisabledConfidentWebsite.Controllers
{
    public class EmployersController : Controller
    {
        private readonly EmployerContext _context;

        public EmployersController(EmployerContext context)
        {
            _context = context;
        }

        // GET: Employers
        [Route("")]
        [HttpGet]
        public async Task<IActionResult> Index(int? page, string currentFilter, string searchString)
        {
            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["currentFilter"] = searchString;

            var employers = from e in _context.Employers
                            select e;

            if (!String.IsNullOrEmpty(searchString))
            {
                employers = employers.Where(e => e.Sector.Contains(searchString));
            }

            int pageSize = 10;
            return View(await PaginatedList<Employer>.CreateAsync(employers.AsNoTracking(), page ?? 1, pageSize));
        }

        // GET: Employers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employer = await _context.Employers
                .FirstOrDefaultAsync(m => m.ID == id);
            if (employer == null)
            {
                return NotFound();
            }

            return View(employer);
        }

    }
}
