using EMS.Entities;
using EMS.Repositories.Intrerfaces;
using Microsoft.AspNetCore.Mvc;

namespace EMS.UI.Controllers
{
    public class AdminController : Controller
    {
        private readonly IBranchRepo _branchRepo;
        private readonly IDeptRepo _deptRepo;

        public AdminController(IBranchRepo branchRepo, IDeptRepo deptRepo)
        {
            _branchRepo = branchRepo;
            _deptRepo = deptRepo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BranchList()
        {
            var branches = _branchRepo.GetAll();
            return View(branches);
        }

        [HttpGet]
        public IActionResult CreateBranch()
        {

            return View();
        }

        [HttpPost]
        public IActionResult CreateBranch(Branch branch)
        {

            _branchRepo.Save(branch);
            TempData["Message"] = "True";
            return RedirectToAction("BranchList");
        }

        [HttpGet]
        public IActionResult EditBranch(int id)
        {
            var branch = _branchRepo.GetById(id);

            return View(branch);
        }

        [HttpPost]
        public async Task<IActionResult> EditBranch(Branch branch)
        {
            _branchRepo.Edit(branch);
            return RedirectToAction("BranchList");


        }

        public IActionResult DeleteBranch(Branch branch)
        {

            _branchRepo.RemoveData(branch);
            return RedirectToAction("BranchList");
        }

        public IActionResult DeptList()
        {
            var departments = _deptRepo.GetAll();

            return View(departments);
        }

        [HttpGet]
        public async Task<IActionResult> CreateDept()
        {

            return View();
        }

        [HttpPost]
        public IActionResult CreateDept(Department department)
        {
            _deptRepo.Save(department);

            return RedirectToAction("DeptList");


        }

        [HttpGet]
        public IActionResult EditDept(int id)
        {
            var dept = _deptRepo.GetById(id);

            return View(dept);
        }

        [HttpPost]
        public async Task<IActionResult> EditDept(Department department)
        {
            _deptRepo.Edit(department);
            return RedirectToAction("DeptList");


        }

        public async Task<IActionResult> DeleteDept(Department department)
        {
            _deptRepo.RemoveData(department);
            return RedirectToAction("DeptList");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Admin admin)
        {
            if (admin.UserName == "admin" && admin.Password == "admin")
            {
                //set session value
                HttpContext.Session.SetString("Admin", "True");
                return RedirectToAction("BranchList");
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
            return RedirectToAction("Login");
        }
    }
}
