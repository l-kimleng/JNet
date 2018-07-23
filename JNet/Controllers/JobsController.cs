using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JNet.Models;

namespace JNet.Controllers
{
    public class JobsController : Controller
    {
        // GET: Job/New
        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Job model)
        {
            return View("New");
        }
    }
}