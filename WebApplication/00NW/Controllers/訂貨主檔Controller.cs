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
    public class 訂貨主檔Controller : Controller
    {
        private NorthwindEntities db = new NorthwindEntities();

        // GET: 訂貨主檔
        public ActionResult Index()
        {
            var 訂貨主檔 = db.訂貨主檔.Include(訂 => 訂.客戶).Include(訂 => 訂.員工).Include(訂 => 訂.貨運公司);
            return View(訂貨主檔.ToList());
        }

        // GET: 訂貨主檔/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            訂貨主檔 訂貨主檔 = db.訂貨主檔.Find(id);
            if (訂貨主檔 == null)
            {
                return HttpNotFound();
            }
            return View(訂貨主檔);
        }

        // GET: 訂貨主檔/Create
        public ActionResult Create()
        {
            ViewBag.客戶編號 = new SelectList(db.客戶, "客戶編號", "公司名稱");
            ViewBag.員工編號 = new SelectList(db.員工, "員工編號", "姓名");
            ViewBag.送貨方式 = new SelectList(db.貨運公司, "貨運公司編號", "貨運公司名稱");
            return View();
        }

        // POST: 訂貨主檔/Create
        // 若要避免過量張貼攻擊，請啟用您要繫結的特定屬性。
        // 如需詳細資料，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "訂單號碼,客戶編號,員工編號,訂單日期,要貨日期,送貨日期,送貨方式,運費,收貨人,送貨地址,送貨城市,送貨行政區,送貨郵遞區號,送貨國家地區")] 訂貨主檔 訂貨主檔)
        {
            if (ModelState.IsValid)
            {
                db.訂貨主檔.Add(訂貨主檔);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.客戶編號 = new SelectList(db.客戶, "客戶編號", "公司名稱", 訂貨主檔.客戶編號);
            ViewBag.員工編號 = new SelectList(db.員工, "員工編號", "姓名", 訂貨主檔.員工編號);
            ViewBag.送貨方式 = new SelectList(db.貨運公司, "貨運公司編號", "貨運公司名稱", 訂貨主檔.送貨方式);
            return View(訂貨主檔);
        }

        // GET: 訂貨主檔/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            訂貨主檔 訂貨主檔 = db.訂貨主檔.Find(id);
            if (訂貨主檔 == null)
            {
                return HttpNotFound();
            }
            ViewBag.客戶編號 = new SelectList(db.客戶, "客戶編號", "公司名稱", 訂貨主檔.客戶編號);
            ViewBag.員工編號 = new SelectList(db.員工, "員工編號", "姓名", 訂貨主檔.員工編號);
            ViewBag.送貨方式 = new SelectList(db.貨運公司, "貨運公司編號", "貨運公司名稱", 訂貨主檔.送貨方式);
            return View(訂貨主檔);
        }

        // POST: 訂貨主檔/Edit/5
        // 若要避免過量張貼攻擊，請啟用您要繫結的特定屬性。
        // 如需詳細資料，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "訂單號碼,客戶編號,員工編號,訂單日期,要貨日期,送貨日期,送貨方式,運費,收貨人,送貨地址,送貨城市,送貨行政區,送貨郵遞區號,送貨國家地區")] 訂貨主檔 訂貨主檔)
        {
            if (ModelState.IsValid)
            {
                db.Entry(訂貨主檔).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.客戶編號 = new SelectList(db.客戶, "客戶編號", "公司名稱", 訂貨主檔.客戶編號);
            ViewBag.員工編號 = new SelectList(db.員工, "員工編號", "姓名", 訂貨主檔.員工編號);
            ViewBag.送貨方式 = new SelectList(db.貨運公司, "貨運公司編號", "貨運公司名稱", 訂貨主檔.送貨方式);
            return View(訂貨主檔);
        }

        // GET: 訂貨主檔/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            訂貨主檔 訂貨主檔 = db.訂貨主檔.Find(id);
            if (訂貨主檔 == null)
            {
                return HttpNotFound();
            }
            return View(訂貨主檔);
        }

        // POST: 訂貨主檔/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            訂貨主檔 訂貨主檔 = db.訂貨主檔.Find(id);
            db.訂貨主檔.Remove(訂貨主檔);
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
