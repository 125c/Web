using _07ADOnet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace _07ADOnet.Controllers
{
    public class HomeController : Controller
    {

        GetData gd = new GetData();

        public ActionResult Index()
        {
            var student = gd.querySql("select * from student", CommandType.Text);

            return View(student);
        }

        public ActionResult GetEmployee()
        {

            return View(gd.querySql("select * from emp", CommandType.Text,"employee"));
        }


        public ActionResult GetCoursePivot()
        {

            var result = gd.querySql("getCoursePivot", CommandType.StoredProcedure);
            return View(result);
        }
    }
}