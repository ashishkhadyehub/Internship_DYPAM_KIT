using EMS.Entities;
using EMS.Repositories.Intrerfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EMS.UI.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IBranchRepo _branchRepo;
        private readonly IDeptRepo _deptRepo;
        private readonly IEmployeeRepo _employeeRepo;

        public EmployeeController(IBranchRepo branchRepo, IDeptRepo deptRepo, IEmployeeRepo employeeRepo)
        {
            _branchRepo = branchRepo;
            _deptRepo = deptRepo;
            _employeeRepo = employeeRepo;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            var branchlist = _branchRepo.GetAll();
            ViewBag.BranchList = new SelectList(branchlist, "BranchName", "BranchName");

            var deptlist = _deptRepo.GetAll();
            ViewBag.DeptList = new SelectList(deptlist, "Name", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Register(Employee employee)
        {

            _employeeRepo.RegisterEmployee(employee);
            TempData["Message"] = "You can login now";
            return RedirectToAction("Login");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(EmployeeLogin user)
        {
            var userInfo = _employeeRepo.GetUserInfo(user.Email, user.Password);
            if (userInfo != null)
            {
                
                HttpContext.Session.SetInt32("userId", userInfo.Id);
                HttpContext.Session.SetString("userName", userInfo.Name);
                return RedirectToAction("Profile", "Employee");
            }
            else
            {
                ViewData["Message"] = "Invalid Login";
                return View();
            }

        }

        [HttpGet]
        public IActionResult Logout()
        {

            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Profile()
        {

            if (HttpContext.Session.GetInt32("userId") != null)
            {
                var branchlist = _branchRepo.GetAll();
                ViewBag.BranchList = new SelectList(branchlist, "BranchName", "BranchName");

                var deptlist = _deptRepo.GetAll();
                ViewBag.DeptList = new SelectList(deptlist, "Name", "Name");

                int userid = (int)HttpContext.Session.GetInt32("userId");

                var profile = _employeeRepo.GetById(userid);

                return View(profile);
            }
            else
            {
                return RedirectToAction("Login");
            }
            
        }

        [HttpPost]
        public IActionResult Profile(Employee employee)
        {
            _employeeRepo.UpdateEmployee(employee);
            return View();
        }

        [HttpGet]
        public IActionResult Application()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Application(LeaveApplication leaveApplication)
        {
            leaveApplication.EmployeeId = (int)HttpContext.Session.GetInt32("userId");
            leaveApplication.Status = "Submitted";
            leaveApplication.ApplicationDate= DateTime.Now;
            _employeeRepo.SubmitApplication(leaveApplication);
            return RedirectToAction("AppList");
        }

        public IActionResult AppList()
        {

            var apps = _employeeRepo.GetApplications((int)HttpContext.Session.GetInt32("userId"));

            return View(apps);
        }

    }
}
