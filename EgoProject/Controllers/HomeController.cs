using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CoreProject;

namespace EgoProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            HttpEgo clsEgo = new HttpEgo();

            var result = clsEgo.Post(542,11542);

            return View(result);
        }

    }
}