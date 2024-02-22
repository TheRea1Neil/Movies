
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
        [HttpGet]
        public IActionResult Movie_Collection()
        {
            return View();
        }


        [HttpPost]
        public IActionResult SubmitMovie(Movie response)
        {
            _context.Movies.Add(response);
            _context.SaveChanges();

            return View("Movie_Collection", response);
        }

        public IActionResult MovieList ()
        {
            //linq
           var movies = _context.Movies.ToList();
            return View(movies);
        }
    }
}
