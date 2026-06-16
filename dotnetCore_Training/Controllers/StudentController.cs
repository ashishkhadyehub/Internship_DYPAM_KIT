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

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var student = _context.Students.Find(id);
            return View(student);
        }

        [HttpPost]
        public IActionResult Edit(Student student)
        {
            _context.Students.Update(student);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var student = _context.Students.Find(id);
            return View(student);
        }

        [HttpPost]
        public IActionResult Delete(Student student)
        {
            _context.Students.Remove(student);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        
    }
}
