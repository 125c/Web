using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HW7Project.Models;

namespace HW7Project.Controllers
{
    public class HomeController : Controller
    {
        HW7ProjectContext db=new HW7ProjectContext();
        //[HandleError(View="Error3")]
        //public ActionResult ExciptionDemo() {
        //    int i = 0;
        //    int j=100/i;//如果直接打j=100/0會出現紅波浪，無法執行
        //    return View(); 
        //}
        //public ActionResult Test() {
        //    throw new NotImplementedException();//這個異常代表該方法沒有實現,這是一個好的程式設計習慣。

        //    //因為當提出程式碼構建結構的時候,有一些方法是不具體實現的,要先搭起程式的架構,當不實現的東西特別多的時候就會忘記,導致方法呼叫時沒有出現預期的效果,對程式碼除錯找了很大的麻煩,這是我們可以在這些沒有具體實現的方法中丟擲這個異常,當程式呼叫這些方法時,會自動丟擲這些異常,為除錯程式碼提供便捷。
        //}
        // GET: Home
        public ActionResult Index()
        {
            Random r = new Random();
            int i=r.Next(0,db.Products.Count());
            var productIDs=db.Products.Select(x => x.ProductID).ToList();
            string PID=productIDs[i];
            ViewBag.PID = PID;
            return View();
        }
        public ActionResult ProductList()
        {
            return View();
        }
        [ChildActionOnly]
        public ActionResult _ProductList(int itemCount=0) 
        {
            List<Products> products;
            if(itemCount==0)
                products = db.Products.Where(p => p.Discontinued == false).OrderByDescending(p => p.CreatedDate).ThenByDescending(p => p.ProductID).ToList();
            else
                products = db.Products.Where(p => p.Discontinued == false).OrderByDescending(p => p.CreatedDate).ThenByDescending(p => p.ProductID).Take(itemCount).ToList();
            return View(products);
        }
        [ChildActionOnly]
        public ActionResult _ProductPhotoShow()
        {
            var products = db.Products.OrderByDescending(p => p.CreatedDate).ThenByDescending(p => p.ProductID).Take(10).ToList();
            return View(products);
        }
        public ActionResult MyCart()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(VMLogin vMLogin)
        {
            string pw = Members.getHashPassword(vMLogin.Password);
            var member = db.Members.Where(m => m.Account == vMLogin.Account && m.Password == pw).FirstOrDefault();
            if (member == null)
            {
                ViewBag.ErrMsg = "帳密錯誤!";
                return View(vMLogin);
            }
            Session["member"] = member;
            return RedirectToAction("ProductList");
        }
        [LoginCheck]
        public ActionResult Logout()
        {
            Session["member"] = null;
            return RedirectToAction("Login", "Home");
        }
    }
}