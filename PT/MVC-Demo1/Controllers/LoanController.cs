using Microsoft.AspNetCore.Mvc;

namespace MVC_Demo1.Controllers
{
    public class LoanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ViewAll() // Action Method for ViewAll.cshtml
        {
            return View(); // it means shwow ViewAll.cshtml
        }

        public IActionResult NewApplication() // Action Method for NewApplication.cshtml
        {
            return View(); // it means show NewApplication.cshtml
        }

        public IActionResult UpdateApplication() // Action Method for UpdateApplication.cshtml
        {
            return View(); // it means show UpdateApplication.cshtml
        }

        public IActionResult DiscardApplication() // Action Method for DiscardApplication.cshtml
        {
            return View(); // it means show DiscardApplication.cshtml
        }
    }
}
