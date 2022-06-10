using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _03Model.Models;

namespace _03Model.Controllers
{
    public class DefaultController : Controller
    {
        dbSutdentEntities db = new dbSutdentEntities();



        public ActionResult Index()
        {
            var tStudent = db.tStudent.ToList();
            return View(tStudent);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(tStudent s)
        {
            db.tStudent.Add(s);
            db.SaveChanges();//找到新增的資料寫到資料庫
            return RedirectToAction("Index");
        }
        public ActionResult Delete(string id)
        {
            //var student = from s in db.tStudent
            //              where s.fStuId == id
            //              select s;
            var student = db.tStudent.Where(s => s.fStuId == id).FirstOrDefault();
            db.tStudent.Remove(student);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}