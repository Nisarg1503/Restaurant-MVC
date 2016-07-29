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
    public class ChutneysController : Controller
    {
        private RestaurantModels db = new RestaurantModels();

        // GET: Chutneys
        public async Task<ActionResult> Index()
        {
            return View(await db.Chutneys.ToListAsync());
        }

        // GET: Chutneys/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Chutney chutney = await db.Chutneys.FindAsync(id);
            if (chutney == null)
            {
                return HttpNotFound();
            }
            return View(chutney);
        }

        // GET: Chutneys/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Chutneys/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "MenuID,MenuName,DetailedDecs,Rate")] Chutney chutney)
        {
            if (ModelState.IsValid)
            {
                db.Chutneys.Add(chutney);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(chutney);
        }

        // GET: Chutneys/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Chutney chutney = await db.Chutneys.FindAsync(id);
            if (chutney == null)
            {
                return HttpNotFound();
            }
            return View(chutney);
        }

        // POST: Chutneys/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "MenuID,MenuName,DetailedDecs,Rate")] Chutney chutney)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chutney).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(chutney);
        }

        // GET: Chutneys/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Chutney chutney = await db.Chutneys.FindAsync(id);
            if (chutney == null)
            {
                return HttpNotFound();
            }
            return View(chutney);
        }

        // POST: Chutneys/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Chutney chutney = await db.Chutneys.FindAsync(id);
            db.Chutneys.Remove(chutney);
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
