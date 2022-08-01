using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Windows.Documents;
using _07ADOnet.Models;
using System.Data.SqlClient;


namespace _07ADOnet.Controllers
{
    public class LoginController : Controller
    {
        GetData gd = new GetData();
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string id, string name)
        {
            //select * from student where 學號 = 'S001' and 姓名 = '陳小安'
            //string sql = "select * from 學生 where 學號= '"+id+"' and 姓名='"+ name+"'";
            List<SqlParameter> list = new List<SqlParameter>
            {
                new SqlParameter("id", id),
                new SqlParameter("name",name)
            };
            string sql = "select * from student where 學號=@id and 姓名=@name";
            var dt = gd.querySql(sql, System.Data.CommandType.Text,list);

            if(dt.Rows.Count==0)
            {
                ViewBag.Msg = "帳號或密碼有誤!";
                return View();
            }
            return RedirectToAction("Index","Home");
        }
    }
}