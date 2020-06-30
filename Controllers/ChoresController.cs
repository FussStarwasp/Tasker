using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tasker.Controllers
{
    public class ChoresController : Controller
    {
        // GET: Chores
        public ActionResult Index()
        {
            return View();
        }
    }
}