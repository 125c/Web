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
    public class 供應商Controller : Controller
    {
        private NorthwindEntities db = new NorthwindEntities();

        // GET: 供應商
        public ActionResult Index()
        {
            return View(db.供應商.ToList());
        }

        // GET: 供應商/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            供應商 供應商 = db.供應商.Find(id);
            if (供應商 == null)
            {
                return HttpNotFound();
            }
            return View(供應商);
        }

        // GET: 供應商/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: 供應商/Create
        // 若要避免過量張貼攻擊，請啟用您要繫結的特定屬性。
        // 如需詳細資料，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "供應商編號,供應商1,連絡人,連絡人職稱,地址,城市,行政區,郵遞區號,國家地區,電話,傳真電話,首頁")] 供應商 供應商)
        {
            if (ModelState.IsValid)
            {
                db.供應商.Add(供應商);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(供應商);
        }

        // GET: 供應商/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            供應商 供應商 = db.供應商.Find(id);
            if (供應商 == null)
            {
                return HttpNotFound();
            }
            return View(供應商);
        }

        // POST: 供應商/Edit/5
        // 若要避免過量張貼攻擊，請啟用您要繫結的特定屬性。
        // 如需詳細資料，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "供應商編號,供應商1,連絡人,連絡人職稱,地址,城市,行政區,郵遞區號,國家地區,電話,傳真電話,首頁")] 供應商 供應商)
        {
            if (ModelState.IsValid)
            {
                db.Entry(供應商).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(供應商);
        }

        // GET: 供應商/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            供應商 供應商 = db.供應商.Find(id);
            if (供應商 == null)
            {
                return HttpNotFound();
            }
            return View(供應商);
        }

        // POST: 供應商/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            供應商 供應商 = db.供應商.Find(id);
            db.供應商.Remove(供應商);
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
