using _05CusVal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _05CusVal.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Member member)
        {
            if(ModelState.IsValid)
            {
                //把資料存入db
                return RedirectToAction("Index");
            }
            else
            {
                return View(member);
            }

            //return View(member);如果有else這一段可以不用，2擇1
        }

    }
}