using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _02View.Models;
namespace _02View.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            string[] id = { "A01", "A02", "A03", "A04", "A05", "A06", "A07" };
            string[] name = { "瑞豐夜市", "新堀江商圈", "六合夜市", "青年夜市", "花園夜市", "大東夜市", "武聖夜市" };
            string[] address = {  "813高雄市左營區裕誠路", "800高雄市新興區玉衡里", "800台灣高雄市新興區六合二路","80652高雄市前鎮區凱旋四路758號", "台南市北區海安路三段533號", "台南市東區林森路一段276號","台南市中西區武聖路69巷42號"  };
            int[] price = { 20, 28, 75, 58, 41, 68, 84 };
            List<NightMarket> list = new List<NightMarket>();
            NightMarket nm ;
            for(int i = 0; i < id.Length; i++)
            {
                /*也可以NightMarket nm=new NightMarket();會佔用到7個記憶體空間放nm*/
                nm=new NightMarket();/*變數會被蓋掉，參數會另外開一個*/
                nm.Id = id[i];
                nm.Name= name[i];
                nm.Address= address[i];
                nm.price= price[i];
                list.Add(nm);/*add是放位置，沒有新增位置*/
            }
            /*用寫死方式新增3個夜市*/
            nm = new NightMarket();
            nm.Id = "B01";
            nm.Name = "大東夜市";
            nm.Address = "台南東區林森路一段大東夜市";
            nm.price = 50;
            list.Add(nm);

            nm = new NightMarket();
            nm.Id = "B02";
            nm.Name = "饒河夜市";
            nm.Address = "台北松山區饒河街饒河街觀光夜市";
            nm.price = 65;
            list.Add(nm);

            nm = new NightMarket();
            nm.Id = "B03";
            nm.Name = "師大夜市";
            nm.Address = "台北大安區師大路39巷師大夜市";
            nm.price = 100;
            list.Add(nm);


            return View(list);
        }
        public ActionResult Details(string id)
        {
            ViewBag.ID = id;
            return View();
        }
        public ActionResult Razer(string id)
        {
            ViewBag.ID = id;
            return View();
        }
        public ActionResult Boostrap()
        {
            string[] id = { "A01", "A02", "A03", "A04", "A05", "A06", "A07" };
            string[] name = { "瑞豐夜市", "新堀江商圈", "六合夜市", "青年夜市", "花園夜市", "大東夜市", "武聖夜市" };
            string[] address = { "813高雄市左營區裕誠路", "800高雄市新興區玉衡里", "800台灣高雄市新興區六合二路", "80652高雄市前鎮區凱旋四路758號", "台南市北區海安路三段533號", "台南市東區林森路一段276號", "台南市中西區武聖路69巷42號" };
            int[] price = { 20, 28, 75, 58, 41, 68, 84 };
            List<NightMarket> list = new List<NightMarket>();
            NightMarket nm;
            for (int i = 0; i < id.Length; i++)
            {
                /*也可以NightMarket nm=new NightMarket();會佔用到7個記憶體空間放nm*/
                nm = new NightMarket();/*變數會被蓋掉，參數會另外開一個*/
                nm.Id = id[i];
                nm.Name = name[i];
                nm.Address = address[i];
                nm.price = price[i];
                list.Add(nm);/*add是放位置，沒有新增位置*/
            }
            /*用寫死方式新增3個夜市*/
            nm = new NightMarket();
            nm.Id = "B01";
            nm.Name = "大東夜市";
            nm.Address = "台南東區林森路一段大東夜市";
            nm.price = 50;
            list.Add(nm);

            nm = new NightMarket();
            nm.Id = "B02";
            nm.Name = "饒河夜市";
            nm.Address = "台北松山區饒河街饒河街觀光夜市";
            nm.price = 65;
            list.Add(nm);

            nm = new NightMarket();
            nm.Id = "B03";
            nm.Name = "師大夜市";
            nm.Address = "台北大安區師大路39巷師大夜市";
            nm.price = 100;
            list.Add(nm);


            return View(list);
        }
        //public ActionResult Details(string id)
        //{
        //    ViewBag.ID = id;
        //    return View();
        //}
        //public ActionResult Razer(string id)
        //{
        //    ViewBag.ID = id;
        //    return View();
        //}

    }
}//03-1 建立一個顯示各大夜市的View
 //03-1-1 在Models上按右鍵,選擇加入,新增項目,程式碼,選擇類別,名稱鍵入NightMarket.cs
 //03-1-2 在NightMarket class中輸入下列欄位以建立Model
 //03-1-3 在Controllers資料夾上按右鍵,加入,控制器,選擇 MVC5控制器-空白
 //03-1-4 指定控制器名稱為HomeController,並開啟HomeController
 //03-1-5 using _02View.Models
 //03-1-6 在public ActionResult Index()內輸入內容
 //03-1-7 在public ActionResult Index()上按右鍵,新增檢視
 //03-1-8 進行下列設定:
 //       檢視名稱:Index
 //       範本:List
 //       模型:NightMarket(02View.Models) 
 //       不勾選 使用板版面配置頁
 //       按下 加入