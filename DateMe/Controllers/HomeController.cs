using DateMe.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DateMe.Controllers
{
    // createa a class
    public class HomeController : Controller
    {
        private DatingApplicationContext _context;

        public HomeController(DatingApplicationContext context) //Constructor
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
        public IActionResult DatingApplication(Application response)
        {
            _context.applications.Add(response); //add record to data base
            _context.SaveChanges();
            return View("Confirmation", response);
        }


    }
}
