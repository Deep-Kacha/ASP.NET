using MVC_Demo.DBContext;
using MVC_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Demo.Models;
namespace MVC_Demo.Controllers
{
    public class CustomerController : Controller
    {
        customerDB db = new customerDB();

        // GET: Customer
        public ActionResult AddCustomer()
        {
            return View();
        }

        // POST: Customer
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult AddCustomer(Customer c1)
        {
            if (ModelState.IsValid)
            {
                db.AddCustomer(c1);
                TempData["SuccessMessage"] = "Customer added successfully!";
               return RedirectToAction("AddCustomer");
            }
            return View();
        }
    }
}