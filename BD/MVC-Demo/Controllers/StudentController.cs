using MVC_Demo.Models;
using MVC_Demo.Models.DBContext;
using System.Web.Mvc;

namespace MVC_Demo.Controllers
{
    public class StudentController : Controller
    {
        studentDB db = new studentDB();

        // GET
        public ActionResult AddStudent()
        {
            return View();
        }

        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddStudent(Student s1)
        {
            if (ModelState.IsValid)
            {
                db.AddStudent(s1);
                TempData["SuccessMessage"] = "Student added successfully!";
                return RedirectToAction("AddStudent");
            }

            return View(s1);
        }
    }
}
