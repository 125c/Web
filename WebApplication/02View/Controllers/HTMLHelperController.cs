using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _02View.Models;

namespace _02View.Controllers
{
    public class HTMLHelperController : Controller
    {
        // GET: HTMLHelper
        public ActionResult Create()
        {
            return View();
        } 

        [HttpPost]
        public ActionResult Create(Member member)
        {
            string result = "";
            result = "你的註冊資料如下：<br>" +
                "帳號：" + member.UserId + "<br>" +
                "密碼：" + member.Pwd + "<br>" +
                "姓名：" + member.Name + "<br>" +
                "信箱：" + member.Email + "<br>" +
                "生日：" + member.Birthday;
            ViewBag.Result = result;
            return View();
        }
    }
}