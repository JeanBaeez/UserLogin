using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserLogin.Models;
using static DataLibrary.BussinesLogic.EmployeeProcessor;
using System.Threading;

namespace UserLogin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult LoginForm()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LoginForm(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                int ?found = UserSearch(username: model.Username, password: model.Password);

                if (found >= 1)
                {
                    ViewBag.JavaScriptFunction = string.Format("userFound();");
                    Thread.Sleep(100);
                    return RedirectToAction("Home");
                }
                else
                {
                    ViewBag.JavaScriptFunction = string.Format("bdnotfounduser();");
                    return View();
                }
            }
             
            return View();
          
        }


        public ActionResult Home()
        {
            return View();

        }


    }
}