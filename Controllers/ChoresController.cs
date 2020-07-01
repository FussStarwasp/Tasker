using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tasker.Models;

namespace Tasker.Controllers
{
    public class ChoresController : Controller
    {
        ApplicationDbContext _context;

        public ChoresController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Chores
        public ActionResult Index()
        {
            var chores = _context.Chores
                .Include(c => c.ChoreStatus)
                .ToList();


            return View(chores);
        }

        [HttpPost]
        public ActionResult ChoresForm()
        {




        }
    }
}