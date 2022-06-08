using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace _01Controller.Controllers
{
    public class MultiFileUpLoadController : Controller
    {
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(HttpPostedFileBase[] photo)
        {
            if (photo != null)
            {
                for(int i = 0; i < photo.Length; i++)
                {
                    if (photo[i].ContentLength > 0 && photo[i].ContentLength < 1048576)
                    {
                        photo[i].SaveAs(Server.MapPath("~/Photos/" + photo[i].FileName));//.FileName抓原本的檔名.MapPath邏輯路徑對應實體路徑
                        ViewBag.Message = "success";
                    }
                    else
                        {
                            ViewBag.Message = "tooBig";
                        }
                }
            }else
                 {
                     ViewBag.Message = "Nothing";
                 }
            return View();
        }
        public string ShowPhoto()
        {
            DirectoryInfo d = new DirectoryInfo(Server.MapPath("~/Photos/"));
            FileInfo[] files = d.GetFiles();
            string show = "";
            foreach (FileInfo item in files)
            {
                show += "<img src='../Photos/" + item.Name + "'/>";
            }
            show += "<hr><a href='/FileUpLoad/Create'>點我回上傳照片頁面</a>";

            return show;

        }
    }
}