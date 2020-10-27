using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.IO;
using System.Net;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRMS.Models;

namespace HRMS.Controllers
{
    public class employeeregController : Controller
    {
        private DB db1 = new DB();



        // GET: employeereg
        public ActionResult Index()
        {
            using (DB db = new DB())
            {
                return View(db1.employeeregs.ToString());
            }
        }

        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]

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
        public ActionResult login()
        {
            return View();
        }
        [HttpPost]

        public ActionResult login(employeereg user)
        {
            using (DB db = new DB())
            {
                var usr = db.employeeregs.Where(u => u.Username == user.Username && u.Password == user.Password).FirstOrDefault();

                if (usr != null)
                {
                    Session["ID"] = usr.ID.ToString();
                    Session["user"] = 1;
                    Session["user_name"] = usr.Username.ToString();
                    return RedirectToAction("loggedIn");
                }
                else if (user.Username == "admin" && user.Password == "admin")
                {
                    //Session["ID"] = usr.ID.ToString();
                    Session["admin"] = 1;
                    return RedirectToAction("Adminhome", "admin");
                }
                else
                {
                    ModelState.AddModelError("", "username or password is wrong.");
                }
            }
            return View();
        }

        public ActionResult loggedIn()
        {
            if (Session["ID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("login");
            }
        }


        public ActionResult MyAccount()
        {
            return View();
        }

        public ActionResult Logout()
        {
            Session["admin"] = null;
            Session["user"] = null;
            Session["ID"] = null;
            // Session["user"] = 1;
            Session["user_name"] = null;
            Session["cart"] = null;
            Session["count"] = null;
            Response.Cache.SetNoStore();
            Session.RemoveAll();
            Session.Abandon();
            Session.Clear();
            System.Web.Security.FormsAuthentication.SignOut();

            return RedirectToAction("Index", "Home");
        }



    }
}