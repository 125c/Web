using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HW7Project.Models;
using PagedList;

namespace HW7Project.Controllers
{
    public class MembersController : Controller
    {
        private HW7ProjectContext db = new HW7ProjectContext();

        // GET: Members
        public ActionResult Index(int page=1)
        {
            var members = db.Members.ToList();
            int pagesize = 5;
            var PagedList = members.ToPagedList(page, pagesize);
            //return View(db.Members.ToList());
            return View(PagedList);
        }

        // GET: Members/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Members members = db.Members.Find(id);
            if (members == null)
            {
                return HttpNotFound();
            }
            return PartialView(members);
        }

        // GET: Members/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Members/Create
        // 若要避免過量張貼攻擊，請啟用您要繫結的特定屬性。
        // 如需詳細資料，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MemberId,MemberName,MemberPhotoFile,MemberBirthday,CreateDate,Account,Password")] Members members,HttpPostedFileBase photo)
        {
            //var account=db.Members.Where(m => m.Account == members.Account).FirstOrDefault();
            //if (account!=null) {
            //    ViewBag.Error = "帳號有人使用";
            //    return View();
            //}
            if (photo!=null) 
            {
                if (photo.ContentLength>0)  
                {
                    photo.SaveAs(Server.MapPath("~/MemberPhotos/" + members.Account + ".jpg"));
                }
            }
           
            if (ModelState.IsValid)
            {
                members.MemberPhotoFile = members.Account + ".jpg";
                db.Members.Add(members);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
            //return View(members);
        }

        // GET: Members/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Members members = db.Members.Find(id);
            if (members == null)
            {
                return HttpNotFound();
            }
            return View(members);
        }

        // POST: Members/Edit/5
        // 若要避免過量張貼攻擊，請啟用您要繫結的特定屬性。
        // 如需詳細資料，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Members members)
        {
            var member = db.Members.Find(members.MemberId);
            member.MemberName = members.MemberName;
            member.MemberBirthday= members.MemberBirthday;
            member.MemberId=members.MemberId;
            member.CreateDate=members.CreateDate;
            member.Account=members.Account;
            member.Password = members.Password;
            if (ModelState.IsValid)
            {
                db.Entry(member).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(members);
        }

        // GET: Members/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Members members = db.Members.Find(id);
            if (members == null)
            {
                return HttpNotFound();
            }
            return View(members);
        }

        // POST: Members/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Members members = db.Members.Find(id);
            db.Members.Remove(members);
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
