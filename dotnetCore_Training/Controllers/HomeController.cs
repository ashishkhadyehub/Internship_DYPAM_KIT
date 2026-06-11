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

            //Student student = new Student();
            //student.Id = 1;
            //student.Name = "Shree";
            //student.City = "Kolhapur";
            //return View(student);
            
            List<Student> students = new List<Student>();
            students.Add(new Student { Id=1,Name="Shree",City="Pune" });
            students.Add(new Student { Id=2,Name="Abhishek",City="Mumbai" });
            students.Add(new Student { Id=3,Name="Vinayak",City="Kolhapur" });
            students.Add(new Student { Id = 4, Name = "Subhash", City = "Nagpur" });
            return View(students);
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
