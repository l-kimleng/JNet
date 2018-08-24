using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JNet.Models;
using JNet.Persistences;
using Microsoft.AspNet.Identity;

namespace JNet.Controllers
{
    [Authorize]
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

        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();
            var result = Context.Jobs
                            .Include(x => x.Company)
                            .Include("Company.Location")
                            .Where(x => x.UserId == userId)
                            .ToList();
            return View(result);
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