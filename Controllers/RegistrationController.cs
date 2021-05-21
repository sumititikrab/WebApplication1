using BusinessObjects;
using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class RegistrationController : Controller
    {
        private InformationManager informationManager = new InformationManager();
        // GET: Registration
        public ActionResult Index()
        {
            return View(informationManager.GetPerson());
        }

        private TransactionManager transactionManager = new TransactionManager();
        // GET: Registration
        public ActionResult Create()
        {
            return View();
        }

        // Post: Registration
        [HttpPost]
        public ActionResult Create([Bind(Include = "ID,Name,Email,Password")] Person person)
        {
            if (transactionManager.Registration(person))
            {
                ViewBag.Sucess = "Sucess";
            }
            else
            { 
                ViewBag.Error = "Error"; 
            }

            return View();
        }
    }
}