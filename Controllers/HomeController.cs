using Microsoft.AspNetCore.Mvc;
using Railwaiy_Eproject.Data;
using Railwaiy_Eproject.Models;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Railwaiy_Eproject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        // Constructor to inject dependencies
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View("Privacy");
        }

        public IActionResult Aboutus()
        {
            return View();
        }

        public IActionResult Contactus()
        {
            return View();
        }

        public async Task<IActionResult> Flightlisting()
        {
            try
            {
                // Fetch flight schedules from the database
                var schedules = await _context.Scheduling.ToListAsync();

                if (schedules == null || schedules.Count == 0)
                {
                    ViewBag.Message = "No flight schedules available at the moment.";
                    return View();
                }

                return View(schedules); // Pass data to the view
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error fetching flight schedules: {ex.Message}");
                ViewBag.Message = "An error occurred while fetching flight schedules.";
                return View();
            }
        }

        public IActionResult FlightBooking()
        {
            return View();
        }

        public IActionResult TourPackages()
        {
            return View("tpackages");
        }

        public IActionResult Signup()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
