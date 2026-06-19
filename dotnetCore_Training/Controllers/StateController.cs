using Microsoft.AspNetCore.Mvc;

namespace dotnetCore_Training.Controllers
{
    public class StateController : Controller
    {
      
        public IActionResult Index()
        {
            return View();
        }
    }
}
