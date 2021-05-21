using BusinessLogic;
using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class LoginController : Controller
    {
        private TransactionManager transactionManager = new TransactionManager();
        // GET: Login
        public ActionResult Create()
        {
            return View();
        }

        // GET: Login
        [HttpPost]
        public ActionResult Create([Bind(Include ="")] Person person)
        {
            if (transactionManager.ValidateUser(person.Email, person.Password))
            {
                ViewBag.Sucess = "Sucess";
                person.Name = string.Empty;
                person.Email = string.Empty;
                person.Password = string.Empty;
            }
            else
            {
                ViewBag.Error = "Error";
            }

            return View();
        }
    }
}