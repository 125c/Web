using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//06-2-3 using _04ViewModel.Models及using _04ViewModel.ViewModels
using _04ViewModel.Models;
using _04ViewModel.ViewModels;

namespace _04ViewModel.Controllers
{
    public class HomeController : Controller
    {
        //06-2-4 於HomeController建立DB物件
        dbEmployeeEntities db = new dbEmployeeEntities();

        //06-2-5 編輯ActionResult Index()的內容
        public ActionResult Index(int depId = 1)
        {
            VMEmp vme = new VMEmp()
            {
                department = db.tDepartment.ToList(),
                employee = db.tEmployee.Where(m => m.fDepId == depId).ToList()
            };

            ViewBag.deptName = db.tDepartment.Where(m => m.fDepId == depId).FirstOrDefault().fDepName;


            return View(vme);
        }


        public ActionResult Create()
        {
            ViewBag.dept = db.tDepartment.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult Create(tEmployee emp)
        {
            db.tEmployee.Add(emp);
            db.SaveChanges();

            return RedirectToAction("Index", new { depId = emp.fDepId });
        }
    }
}

//06-1 建立ViewModel
//06-1-0 練習將tEmpolyee的資料讀到網頁上顯示(略)
//06-1-1 建立dbEmployee.mdb資料庫Model
//       在Models上按右鍵,選擇加入,新增項目,資料,ADO.NET實體資料模型
//       來自資料庫的EF Designer
//       連接dbEmployee.mdf資料庫,連線名稱不修改,按下一步按鈕
//       選擇Entity Framework 6.x, 按下一步按鈕
//       資料表"全選", 按完成鈕
//       若跳出詢問方法按確定鈕
//06-1-2 在專案上按右鍵,建置
//06-1-3 進入NuGet移除 Entity Framework語系套件包
//06-1-4 加入ViewModels資料夾
//06-1-5 在ViewModels資料夾裡建立ViewModel並取名為VMEmp
//06-1-6 在VMEmp.cs裡 using _04ViewModel.Models
//06-1-7 建立tDepartment和tEmployee的List物件做為屬性

//06-2 建立HomeController
//06-2-1 在Controllers資料夾上按右鍵,加入,控制器,選擇 MVC5Controller-空白
//06-2-2 指定控制器名稱為HomeController,並開啟HomeController
//06-2-3 using _04ViewModel.Models及using _04ViewModel.ViewModels
//06-2-4 於HomeController建立DB物件
//06-2-5 編輯ActionResult Index()的內容
//06-2-6 於HomeController建立GET與POST的Create Action
//06-2-7 於HomeController建立POST的Delete Action

//06-3 建立各個View
//06-3-1 在public ActionResult Index()上按右鍵,新增檢視,建立Index View
//06-3-2 進行下列設定:
//        檢視名稱:Index
//        範本:List
//        模型類別:tEmployee(_04ViewModel.Models)
//        資料內容類別:dbEmployeeEntities(_04ViewModel.Models)
//        勾選 不使用版片配置頁
//        按下 加入
//        安裝Bootstrap套件(如果需要)
//06-3-3 在最上方加上@model _04ViewModel.ViewModels.VMEmp
//06-3-4 將tilte改為中文
//06-3-5 更改Index View為想要的排版
//06-3-6 執行及測試
//06-3-7 在public ActionResult Create()上按右鍵,新增檢視,建立CreateView
//06-3-8 進行下列設定:
//       檢視名稱:Create
//       範本:Create
//       模型類別:tEmployee(_04ViewModel.Models)
//       資料內容類別:dbEmployeeEntities(_04ViewModel.Models)
//       勾選 使用版片配置頁
//       按下 加入
//06-3-9 加入給下拉選單用的資料
//06-3-10 將英文字改為中文字
//06-3-11 建立員工資料新增表單
//06-3-12 執行及測試