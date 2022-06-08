using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _03Model.Models;

namespace _03Model.Controllers
{
    public class LinqController : Controller
    {
        //建立db context物件
        NorthwindEntities db=new NorthwindEntities();
        public string ShowEmp()
        {
            //var result=from m in db.員工
            //           select m;
            var result = db.員工;


            string show = "";
            foreach (var item in result) 
            {
                show += "員工編號：" + item.員工編號 + "<br>";
                show += "員工姓名：" + item.姓名 + "<br>";
                show += "員工職稱：" + item.職稱 + "<hr>";
            }
            return show;
        }
        public string ShowCusAdd(string KeyWord ) 
        {
            string show = "";
            //var result = from c in db.客戶
            //             where c.地址.Contains(KeyWord)
            //             select c;
            //var result = db.客戶.Where(c=>c.地址.Contains(KeyWord));
            //'%KeyWord%'
            //var result = db.客戶.Where(c => c.地址.StartsWith(KeyWord));
            //'KeyWord%'
            var result = db.客戶.Where(c => c.地址.EndsWith(KeyWord));
            //'%KeyWord'

            foreach (var item in result)
            {
                show += "客戶編號：" + item.客戶編號 + "<br>";
                show += "客戶名稱：" + item.公司名稱 + "<br>";
                show += "員工地址：" + item.地址 + "<hr>";
            }
            return show;
        }
        public string ShowProduct()
        {
            string show = "";
            //var result = from p in db.產品資料
            //             where p.單價>30
            //             orderby p.單價,p.庫存量 descending
            //             select p;

            var result = db.產品資料.Where(p => p.單價>30).OrderBy(p=> p.單價).ThenByDescending(p => p.單價);
         

            foreach (var item in result)
            {
                show += "產品編號：" + item.產品編號 + "<br>";
                show += "產品名稱：" + item.產品 + "<br>";
                show += "產品單價：" + item.單價 + "<br>";
                show += "庫存量：" + item.庫存量 + "<hr>";
            }
            return show;
        }
        public string ShowProductInfo()
        {
            string show = "";
            var result = from p in db.產品資料
                         select p;
            show += "產品筆數：" + result.Count() + "<br>";
            show += "產品單價總和：" + result.Sum(p => p.單價) + "<br>";
            show += "產品單價平均：" + result.Average(p => p.單價) + "<br>";
            show += "最低單價：" + result.Min(p => p.單價) + "<br>";
            show += "最高單價：" + result.Max(p => p.單價) + "<hr>";
            return show;
        }
        

    }
}