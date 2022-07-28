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
        //教務系統Entities db = new 教務系統Entities();
        //static  SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["aaa"].ConnectionString);
        //SqlDataAdapter adp = new SqlDataAdapter("", conn);
        //DataSet ds=new DataSet();
        //DataTable dt = new DataTable();
        GetData gd = new GetData();
        public ActionResult Index()
        {

            //SqlDataAdapter adp=new SqlDataAdapter("select * from student",conn);
            //adp.Fill(ds, "studnets");
            //dt = ds.Tables["studnets"];
            ////ViewBag.DataSource = dt;
            //return View(dt);
            return View(gd.querySql("select * from student"));
        }
        public ActionResult GetEmployee()
        {
            //SqlDataAdapter adp = new SqlDataAdapter("select * from emp", conn);
            //adp.Fill(ds, "studnets");
            //dt = ds.Tables["studnets"];
            //return View(dt);
            //var student=gd.!!!!
            return View(gd.querySql("select * from emp"));
        }
        public ActionResult GetCursePivot()
        {
            return View(gd.querySqlBySP("getCoursePivot"));
        }
    }
}