
using Microsoft.AspNetCore.Mvc;
using Movies.Models;
using System.Diagnostics;

namespace Movies.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext _context;

        public HomeController(MovieContext context) //Constructor
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Get_To_Know_Joel()
        {
            return View();
        }

        public IActionResult Movie_Collection()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SubmitMovie(Movie response)
        {
            return View("Movie_Collection");
        }

    }
}
