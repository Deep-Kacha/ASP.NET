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

        // POST (AUTO INSERT OR UPDATE)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddStudent(Student s1)
        {
            if (!ModelState.IsValid)
                return View(s1);

            if (db.StudentExists(s1.studentname))
            {
                db.UpdateStudentByName(s1);
                TempData["SuccessMessage"] = "Student city updated successfully!";
            }
            else
            {
                db.AddStudent(s1);
                TempData["SuccessMessage"] = "Student added successfully!";
            }

            return RedirectToAction("AddStudent");
        }
    }
}
