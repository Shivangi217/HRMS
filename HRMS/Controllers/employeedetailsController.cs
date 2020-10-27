using HRMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HRMS.Controllers
{
    public class employeedetailsController : Controller
    {
        // GET: employeedetails
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register(employeereg account)
        {
            if (ModelState.IsValid)
            {
                using (DB db = new DB())
                {
                    db.employeeregs.Add(account);
                    db.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = account.First_name + " " + account.Last_name + "successfully registered.";
            }
            return View();
        }

    }
       
}