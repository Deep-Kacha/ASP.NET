using Microsoft.AspNetCore.Mvc;
using SchoolManagemengtSystem.DBFolder;
using SchoolManagemengtSystem.Models;

namespace SchoolManagemengtSystem.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentDB db;

        public StudentController(StudentDB db)
        {
            this.db = db;
        }

        // ================= ADD =================

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(StudentModel s)
        {
            if (!ModelState.IsValid)
            {
                TempData["Error"] = "Please fill all required fields correctly.";
                return View(s);
            }

            try
            {
                db.students.Add(s);
                db.SaveChanges();
                TempData["Success"] = "Student added successfully.";
                return RedirectToAction("Display");
            }
            catch (Exception)
            {
                TempData["Error"] = "Something went wrong while adding student.";
                return View(s);
            }
        }

        // ================= DISPLAY =================

        [HttpGet]
        public IActionResult Display()
        {
            try
            {
                var data = db.students.ToList();
                return View(data);
            }
            catch (Exception)
            {
                TempData["Error"] = "Unable to load student list.";
                return View(new List<StudentModel>());
            }
        }

        // ================= UPDATE =================

        [HttpGet]
        public IActionResult Update(int id)
        {
            var student = db.students.Find(id);

            if (student == null)
            {
                TempData["Error"] = "Student not found.";
                return RedirectToAction("Display");
            }

            return View(student);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(StudentModel s)
        {
            if (!ModelState.IsValid)
            {
                TempData["Error"] = "Please correct the form errors.";
                return View(s);
            }

            try
            {
                db.students.Update(s);
                db.SaveChanges();
                TempData["Success"] = "Student updated successfully.";
                return RedirectToAction("Display");
            }
            catch (Exception)
            {
                TempData["Error"] = "Something went wrong while updating.";
                return View(s);
            }
        }

        // ================= DELETE =================

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var student = db.students.Find(id);

            if (student == null)
            {
                TempData["Error"] = "Student not found.";
                return RedirectToAction("Display");
            }

            return View(student);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int studentId)
        {
            try
            {
                var student = db.students.Find(studentId);

                if (student == null)
                {
                    TempData["Error"] = "Student not found.";
                    return RedirectToAction("Display");
                }

                db.students.Remove(student);
                db.SaveChanges();

                TempData["Success"] = "Student deleted successfully.";
            }
            catch (Exception)
            {
                TempData["Error"] = "Something went wrong while deleting.";
            }

            return RedirectToAction("Display");
        }
    }
}