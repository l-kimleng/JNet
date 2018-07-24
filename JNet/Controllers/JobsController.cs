using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JNet.Models;
using Microsoft.AspNet.Identity;

namespace JNet.Controllers
{
    public class JobsController : Controller
    {
        public JNetDbContext Context { get; }

        public JobsController()
        {
            Context = JNetDbContext.Create();
        }

        protected override void Dispose(bool disposing)
        {
            Context.Dispose();
            base.Dispose(disposing);
        }

        // GET: Job/New
        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Job model)
        {
            if (!ModelState.IsValid)
            {
                return View("New", model);
            }
            model.UserId = User.Identity.GetUserId();
            Context.Jobs.Add(model);
            Context.SaveChanges();
            ViewBag.Message = "Add";
            return View("New");
        }
    }
}