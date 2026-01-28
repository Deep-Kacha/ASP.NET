using Microsoft.AspNetCore.Mvc;

namespace CORE_MVC_DEMO.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult add()
        {
            return View();
        }
    }
}
