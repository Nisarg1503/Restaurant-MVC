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
    public class PicklesController : Controller
    {
        private RestaurantModels db = new RestaurantModels();

        // GET: Pickles
        public async Task<ActionResult> Index()
        {
            return View(await db.Pickles.ToListAsync());
        }

        // GET: Pickles/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pickle pickle = await db.Pickles.FindAsync(id);
            if (pickle == null)
            {
                return HttpNotFound();
            }
            return View(pickle);
        }

        // GET: Pickles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pickles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "MenuID,MenuName,DetailedDecs,Rate")] Pickle pickle)
        {
            if (ModelState.IsValid)
            {
                db.Pickles.Add(pickle);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(pickle);
        }

        // GET: Pickles/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pickle pickle = await db.Pickles.FindAsync(id);
            if (pickle == null)
            {
                return HttpNotFound();
            }
            return View(pickle);
        }

        // POST: Pickles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "MenuID,MenuName,DetailedDecs,Rate")] Pickle pickle)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pickle).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(pickle);
        }

        // GET: Pickles/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pickle pickle = await db.Pickles.FindAsync(id);
            if (pickle == null)
            {
                return HttpNotFound();
            }
            return View(pickle);
        }

        // POST: Pickles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Pickle pickle = await db.Pickles.FindAsync(id);
            db.Pickles.Remove(pickle);
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
