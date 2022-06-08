using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;//上傳檔案用

namespace _01Controller.Controllers
{
    public class FileUploadController : Controller
    {
        // GET: FileUpload
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(HttpPostedFileBase photo)
        {
            if(photo != null)
            {
                if(photo.ContentLength > 0 && photo.ContentLength<1048576)
                    {
                        photo.SaveAs(Server.MapPath("~/Photos/" + photo.FileName));//.FileName抓原本的檔名.MapPath邏輯路徑對應實體路徑
                        ViewBag.Message = "success";
                    }
                else
                {
                    ViewBag.Message = "tooBig";
                }
            }
            else
            {
                ViewBag.Message = "Nothing";
            }
            
            return View();
        }
        //02-4-6 建立ShowPhotos()一般方法-可顯示Photos資料夾下所有圖檔
        public string ShowPhoto() 
        {
            DirectoryInfo d = new DirectoryInfo(Server.MapPath("~/Photos/"));
            FileInfo[]files = d.GetFiles();
            string show="";
            foreach(FileInfo item in files)
            {
                show += "<img src='../Photos/" + item.Name + "'/>";
            }
            show += "<hr><a href='/FileUpLoad/Create'>點我回上傳照片頁面</a>";

            return show;

        }
    }
}