
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
            ViewBag.Categories = _context.Categories.ToList();
            return View();
        }


        [HttpPost]
        public IActionResult Movie_Collection(Movie response)
        {
            _context.Movies.Add(response);
            _context.SaveChanges();

            return RedirectToAction("MovieList");
        }

        public IActionResult MovieList()
        {
            //linq
            var movies = _context.Movies.ToList();
            return View(movies);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.Movies
                .Single(x => x.Mission06_MovieId == id);

            ViewBag.Categories = _context.Categories.ToList();

            return View("Movie_Collection", recordToEdit);
        }
        [HttpPost]
        public IActionResult Edit(Movie update)
        {
            _context.Update(update);
            _context.SaveChanges(true);
            return RedirectToAction("MovieList");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Movies.Single(x => x.Mission06_MovieId == id);
            return View(recordToDelete);
        }
        [HttpPost]
        public IActionResult Delete(Movie movie)
        {
            _context.Movies.Remove(movie);
            _context.SaveChanges();

            return RedirectToAction("MovieList");

        }
    }
}
