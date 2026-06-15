using dotnetCore_Training.Data;
using dotnetCore_Training.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnetCore_Training.Controllers
{
    public class StudentController : Controller
    {
        //select field and press ctrl + .
        private readonly ApplicationDbContext _context;

        //constructor dependency injection
        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }

        //template - UI design
        //model - model class
        public IActionResult Index()
        {
                            //database.tablename.selctquery
            var students = _context.Students.ToList();
            return View(students);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
