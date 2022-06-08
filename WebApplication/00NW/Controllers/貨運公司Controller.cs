using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _00NW.Models;

namespace _00NW.Controllers
{
    public class 貨運公司Controller : Controller
    {
        private NorthwindEntities db = new NorthwindEntities();

        // GET: 貨運公司
        public ActionResult Index()
        {
            return View(db.貨運公司.ToList());
        }

        // GET: 貨運公司/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            貨運公司 貨運公司 = db.貨運公司.Find(id);
            if (貨運公司 == null)
            {
                return HttpNotFound();
            }
            return View(貨運公司);
        }

        // GET: 貨運公司/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: 貨運公司/Create
        // 若要避免過量張貼攻擊，請啟用您要繫結的特定屬性。
        // 如需詳細資料，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "貨運公司編號,貨運公司名稱,電話")] 貨運公司 貨運公司)
        {
            if (ModelState.IsValid)
            {
                db.貨運公司.Add(貨運公司);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(貨運公司);
        }

        // GET: 貨運公司/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            貨運公司 貨運公司 = db.貨運公司.Find(id);
            if (貨運公司 == null)
            {
                return HttpNotFound();
            }
            return View(貨運公司);
        }

        // POST: 貨運公司/Edit/5
        // 若要避免過量張貼攻擊，請啟用您要繫結的特定屬性。
        // 如需詳細資料，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "貨運公司編號,貨運公司名稱,電話")] 貨運公司 貨運公司)
        {
            if (ModelState.IsValid)
            {
                db.Entry(貨運公司).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(貨運公司);
        }

        // GET: 貨運公司/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            貨運公司 貨運公司 = db.貨運公司.Find(id);
            if (貨運公司 == null)
            {
                return HttpNotFound();
            }
            return View(貨運公司);
        }

        // POST: 貨運公司/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            貨運公司 貨運公司 = db.貨運公司.Find(id);
            db.貨運公司.Remove(貨運公司);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
