using barApp.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace barApp.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        DataContext db = new DataContext();
        public ActionResult List()
        {

            if (Session["Username"] != null)
            {
                var data = db.ACCOUNT.SqlQuery("SELECT * FROM ACCOUNT").ToList();

                var orders = db.FOODORDER.SqlQuery("SELECT * FROM FOODORDER").ToList();
                object[] info = new object[2];
                info[0] = data;
                info[1] = orders;

                return View(data);

                

            }
            else
            {
                return RedirectToAction("Index");
            }



        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Account login)
        {

            try
            {
                // creating new list to store details of new login
                List<object> newLogin = new List<object>();
                newLogin.Add(login.Username);
                newLogin.Add(login.Password);

                // copying login items to array for sql statement
                object[] loginItems = newLogin.ToArray();
                var data = db.ACCOUNT.SqlQuery("SELECT * FROM ACCOUNT WHERE Username=@p0 AND Password=@p1", loginItems).SingleOrDefault();

                if (data != null)
                {
                    Session["UserName"] = login.Username.ToString(); // setting session
                    return RedirectToAction("List"); // redirecting to list page
                }
                else
                {
                    ViewBag.msg = "invalid password/username";
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Login/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Login/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Login/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Login/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Login/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Login/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Login/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
