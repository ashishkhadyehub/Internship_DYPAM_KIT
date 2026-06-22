using Microsoft.AspNetCore.Mvc;

namespace EMS.UI.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
