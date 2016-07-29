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
    public class SambharoesController : Controller
    {
        private RestaurantModels db = new RestaurantModels();

        // GET: Sambharoes
        public async Task<ActionResult> Index()
        {
            return View(await db.Sambharoes.ToListAsync());
        }

        // GET: Sambharoes/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sambharo sambharo = await db.Sambharoes.FindAsync(id);
            if (sambharo == null)
            {
                return HttpNotFound();
            }
            return View(sambharo);
        }

        // GET: Sambharoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sambharoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "MenuID,MenuName,DetailedDecs,Rate")] Sambharo sambharo)
        {
            if (ModelState.IsValid)
            {
                db.Sambharoes.Add(sambharo);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(sambharo);
        }

        // GET: Sambharoes/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sambharo sambharo = await db.Sambharoes.FindAsync(id);
            if (sambharo == null)
            {
                return HttpNotFound();
            }
            return View(sambharo);
        }

        // POST: Sambharoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "MenuID,MenuName,DetailedDecs,Rate")] Sambharo sambharo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sambharo).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(sambharo);
        }

        // GET: Sambharoes/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sambharo sambharo = await db.Sambharoes.FindAsync(id);
            if (sambharo == null)
            {
                return HttpNotFound();
            }
            return View(sambharo);
        }

        // POST: Sambharoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Sambharo sambharo = await db.Sambharoes.FindAsync(id);
            db.Sambharoes.Remove(sambharo);
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
