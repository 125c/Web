using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _01Controller.Models;
//引入命名空間

namespace _01Controller.Controllers
{
    public class ComplexController : Controller
    {
        // GET: Complex
        public ActionResult Index()
        {
            return View();
        }
    }
}