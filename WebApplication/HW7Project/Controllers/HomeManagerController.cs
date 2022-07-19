using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW7Project.Controllers
{
    public class HomeManagerController : Controller
    {
        // GET: Homemanager
        public ActionResult Index()
        {
            return View();
        }
    }
}