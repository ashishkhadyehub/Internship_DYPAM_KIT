using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Template;

namespace LA.UI.Controllers
{
    public class ConceptController : Controller
    {
        public IActionResult Index()
        {
            //ViewBag.Message = "Hello from ViewBag";

            ViewData["Message"] = "Hello from ViewData";
            TempData["Message"] = "Hello from Tempdata received from previous request";
            return View();
        }

        public IActionResult NextPage()
        {
            return View();
        }
    }
}
