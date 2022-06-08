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
    public class 客戶Controller : Controller
    {
        private NorthwindEntities db = new NorthwindEntities();

        // GET: 客戶
        public ActionResult Index()
        {
            return View(db.客戶.ToList());
        }

        // GET: 客戶/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            客戶 客戶 = db.客戶.Find(id);
            if (客戶 == null)
            {
                return HttpNotFound();
            }
            return View(客戶);
        }

        // GET: 客戶/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: 客戶/Create
        // 若要避免過量張貼攻擊，請啟用您要繫結的特定屬性。
        // 如需詳細資料，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "客戶編號,公司名稱,連絡人,連絡人職稱,地址,城市,行政區,郵遞區號,國家地區,電話,傳真電話")] 客戶 客戶)
        {
            if (ModelState.IsValid)
            {
                db.客戶.Add(客戶);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(客戶);
        }

        // GET: 客戶/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            客戶 客戶 = db.客戶.Find(id);
            if (客戶 == null)
            {
                return HttpNotFound();
            }
            return View(客戶);
        }

        // POST: 客戶/Edit/5
        // 若要避免過量張貼攻擊，請啟用您要繫結的特定屬性。
        // 如需詳細資料，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "客戶編號,公司名稱,連絡人,連絡人職稱,地址,城市,行政區,郵遞區號,國家地區,電話,傳真電話")] 客戶 客戶)
        {
            if (ModelState.IsValid)
            {
                db.Entry(客戶).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(客戶);
        }

        // GET: 客戶/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            客戶 客戶 = db.客戶.Find(id);
            if (客戶 == null)
            {
                return HttpNotFound();
            }
            return View(客戶);
        }

        // POST: 客戶/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            客戶 客戶 = db.客戶.Find(id);
            db.客戶.Remove(客戶);
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
