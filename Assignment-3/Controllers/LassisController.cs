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
    public class LassisController : Controller
    {
        private RestaurantModels db = new RestaurantModels();

        // GET: Lassis
        public async Task<ActionResult> Index()
        {
            return View(await db.Lassis.ToListAsync());
        }

        // GET: Lassis/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lassi lassi = await db.Lassis.FindAsync(id);
            if (lassi == null)
            {
                return HttpNotFound();
            }
            return View(lassi);
        }

        // GET: Lassis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Lassis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "MenuID,MenuName,DetailedDecs,Rate")] Lassi lassi)
        {
            if (ModelState.IsValid)
            {
                db.Lassis.Add(lassi);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(lassi);
        }

        // GET: Lassis/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lassi lassi = await db.Lassis.FindAsync(id);
            if (lassi == null)
            {
                return HttpNotFound();
            }
            return View(lassi);
        }

        // POST: Lassis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "MenuID,MenuName,DetailedDecs,Rate")] Lassi lassi)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lassi).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(lassi);
        }

        // GET: Lassis/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lassi lassi = await db.Lassis.FindAsync(id);
            if (lassi == null)
            {
                return HttpNotFound();
            }
            return View(lassi);
        }

        // POST: Lassis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Lassi lassi = await db.Lassis.FindAsync(id);
            db.Lassis.Remove(lassi);
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
