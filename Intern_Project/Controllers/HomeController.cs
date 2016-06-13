using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Intern_Project.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Home/Test/
        public string Test(string vote)
        {
            //ViewData["Message"] = "You voted: " + vote; 
            //return View();
            return "You voted: " + vote;
        }
    }
}