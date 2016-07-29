using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Assignment_3.Models;

namespace Assignment_3.Controllers
{
    public class ButterMilksController : Controller
    {
        private RestaurantModels db = new RestaurantModels();

        // GET: ButterMilks
        public async Task<ActionResult> Index()
        {
            return View(await db.ButterMilks.ToListAsync());
        }

        // GET: ButterMilks/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ButterMilk butterMilk = await db.ButterMilks.FindAsync(id);
            if (butterMilk == null)
            {
                return HttpNotFound();
            }
            return View(butterMilk);
        }

        // GET: ButterMilks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ButterMilks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "MenuID,MenuName,DetailedDecs,Rate")] ButterMilk butterMilk)
        {
            if (ModelState.IsValid)
            {
                db.ButterMilks.Add(butterMilk);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(butterMilk);
        }

        // GET: ButterMilks/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ButterMilk butterMilk = await db.ButterMilks.FindAsync(id);
            if (butterMilk == null)
            {
                return HttpNotFound();
            }
            return View(butterMilk);
        }

        // POST: ButterMilks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "MenuID,MenuName,DetailedDecs,Rate")] ButterMilk butterMilk)
        {
            if (ModelState.IsValid)
            {
                db.Entry(butterMilk).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(butterMilk);
        }

        // GET: ButterMilks/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ButterMilk butterMilk = await db.ButterMilks.FindAsync(id);
            if (butterMilk == null)
            {
                return HttpNotFound();
            }
            return View(butterMilk);
        }

        // POST: ButterMilks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            ButterMilk butterMilk = await db.ButterMilks.FindAsync(id);
            db.ButterMilks.Remove(butterMilk);
            await db.SaveChangesAsync();
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
