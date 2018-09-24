using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CallOut;

namespace CallOut.Controllers
{
    public class CallOutController : Controller
    {
        private CallOutEntities db = new CallOutEntities();

        // GET: CallOut
        public ActionResult Index()
        {
            return View(db.E_Numbers.ToList());
        }

        public ActionResult SharePage()
        {
            return View(db.E_Numbers.ToList());
        }

        public ActionResult ShareProblems()
        {
            return View(db.E_Numbers.ToList());
        }

        // GET: CallOut/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            E_Numbers e_Numbers = db.E_Numbers.Find(id);
            if (e_Numbers == null)
            {
                return HttpNotFound();
            }
            return View(e_Numbers);
        }

        // GET: CallOut/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CallOut/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,PolNum,FireNum,HealthNum")] E_Numbers e_Numbers)
        {
            if (ModelState.IsValid)
            {
                db.E_Numbers.Add(e_Numbers);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(e_Numbers);
        }

        // GET: CallOut/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            E_Numbers e_Numbers = db.E_Numbers.Find(id);
            if (e_Numbers == null)
            {
                return HttpNotFound();
            }
            return View(e_Numbers);
        }

        // POST: CallOut/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,PolNum,FireNum,HealthNum")] E_Numbers e_Numbers)
        {
            if (ModelState.IsValid)
            {
                db.Entry(e_Numbers).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(e_Numbers);
        }

        // GET: CallOut/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            E_Numbers e_Numbers = db.E_Numbers.Find(id);
            if (e_Numbers == null)
            {
                return HttpNotFound();
            }
            return View(e_Numbers);
        }

        // POST: CallOut/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            E_Numbers e_Numbers = db.E_Numbers.Find(id);
            db.E_Numbers.Remove(e_Numbers);
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
