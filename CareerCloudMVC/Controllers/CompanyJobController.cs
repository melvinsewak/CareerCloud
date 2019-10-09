using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.Pocos;

namespace CareerCloudMVC.Controllers
{
    public class CompanyJobController : Controller
    {
        private readonly CareerCloudContext db = new CareerCloudContext();

        // GET: CompanyJob
        public ActionResult Index()
        {
            var companyJobs = db.CompanyJobs.Include(c => c.CompanyProfiles);
            return View(companyJobs.ToList());
        }

        // GET: CompanyJob/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CompanyJobPoco companyJobPoco = db.CompanyJobs.Find(id);
            if (companyJobPoco == null)
            {
                return HttpNotFound();
            }
            return View(companyJobPoco);
        }

        // GET: CompanyJob/Create
        public ActionResult Create()
        {
            ViewBag.Company = new SelectList(db.CompanyProfiles, "Id", "CompanyWebsite");
            return View();
        }

        // POST: CompanyJob/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Company,ProfileCreated,IsInactive,IsCompanyHidden,TimeStamp")] CompanyJobPoco companyJobPoco)
        {
            if (ModelState.IsValid)
            {
                companyJobPoco.Id = Guid.NewGuid();
                db.CompanyJobs.Add(companyJobPoco);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Company = new SelectList(db.CompanyProfiles, "Id", "CompanyWebsite", companyJobPoco.Company);
            return View(companyJobPoco);
        }

        // GET: CompanyJob/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CompanyJobPoco companyJobPoco = db.CompanyJobs.Find(id);
            if (companyJobPoco == null)
            {
                return HttpNotFound();
            }
            ViewBag.Company = new SelectList(db.CompanyProfiles, "Id", "CompanyWebsite", companyJobPoco.Company);
            return View(companyJobPoco);
        }

        // POST: CompanyJob/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Company,ProfileCreated,IsInactive,IsCompanyHidden,TimeStamp")] CompanyJobPoco companyJobPoco)
        {
            if (ModelState.IsValid)
            {
                db.Entry(companyJobPoco).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Company = new SelectList(db.CompanyProfiles, "Id", "CompanyWebsite", companyJobPoco.Company);
            return View(companyJobPoco);
        }

        // GET: CompanyJob/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CompanyJobPoco companyJobPoco = db.CompanyJobs.Find(id);
            if (companyJobPoco == null)
            {
                return HttpNotFound();
            }
            return View(companyJobPoco);
        }

        // POST: CompanyJob/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            CompanyJobPoco companyJobPoco = db.CompanyJobs.Find(id);
            db.CompanyJobs.Remove(companyJobPoco);
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
