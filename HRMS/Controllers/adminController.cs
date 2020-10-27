using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HRMS.Controllers
{
    public class adminController : Controller
    {
        // GET: admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Adminhome()
        {
            return View();
        }

        public ActionResult empproject()
        {
            return View();
        }

        public ActionResult employeelist()
        {
            return View();
        }



    }
}