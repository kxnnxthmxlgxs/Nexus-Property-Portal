using Microsoft.AspNetCore.Mvc;
using NexusPropertyPortal.Models;
using System.Linq;

namespace NexusPropertyPortal.Controllers
{
    public class PropertyController : Controller
    {
        private readonly ApplicationDbContext _context;

        // Constructor: This pulls in your Database connection
        public PropertyController(ApplicationDbContext context)
        {
            _context = context;
        }

        // 1. List all properties
        //public IActionResult Index()
        //{
        //    var properties = _context.Properties.ToList();
        //    return View(properties);
        //}

        // 2. Show the "Create New" form
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // 3. Save the new property to the SQL Database
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Property property)
        {
            if (ModelState.IsValid)
            {
                _context.Properties.Add(property);
                _context.SaveChanges(); // This pushes the data to SQL
                return RedirectToAction(nameof(Index));
            }
            return View(property);
        }

        public IActionResult Details(int id)
        {
            var property = _context.Properties.Find(id);
            if (property == null) return NotFound();

            // Data Analytics: Calculate the average price of houses in the same suburb
            ViewBag.AveragePrice = _context.Properties
                .Where(p => p.Suburb == property.Suburb)
                .Average(p => p.Price);

            return View(property);
        }

        // GET: Property/Edit/5
        // This loads the Edit page with existing data
        public IActionResult Edit(int id)
        {
            var property = _context.Properties.Find(id);
            if (property == null) return NotFound();
            return View(property);
        }

        // GET: Property/Delete/5
        // This loads the Delete confirmation page
        public IActionResult Delete(int id)
        {
            var property = _context.Properties.Find(id);
            if (property == null) return NotFound();
            return View(property);
        }

        public IActionResult Index(string searchString)
        {
            var properties = from p in _context.Properties
                             select p;

            if (!string.IsNullOrEmpty(searchString))
            {
                properties = properties.Where(s => s.Suburb.Contains(searchString));
            }

            // Dashboard Data
            ViewBag.TotalProperties = properties.Count();

            // Use 'm' for decimal literals to keep currency precision
            ViewBag.PortfolioValue = properties.Any() ? properties.Sum(p => p.Price) : 0m;

            // Average size is fine as a double for analytics
            ViewBag.AvgSqMeters = properties.Any() ? properties.Average(p => p.SquareMeters) : 0.0;

            return View(properties.ToList());
        }
    }
}