using dotnetCore_Training.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace dotnetCore_Training.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        //public returnType
        public IActionResult Index()
        {
            //int a = 80;
            //return View(a);

            //string name = "Shree";
            //return View("Index",name);

            Student student = new Student();
            student.Id = 1;
            student.Name = "Shree";
            student.City = "Kolhapur";
            return View(student);
        }

        public IActionResult Privacy()
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
