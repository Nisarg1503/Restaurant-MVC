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
    public class IceCreamsController : Controller
    {
        private RestaurantModels db = new RestaurantModels();

        // GET: IceCreams
        public async Task<ActionResult> Index()
        {
            return View(await db.IceCreams.ToListAsync());
        }

        // GET: IceCreams/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IceCream iceCream = await db.IceCreams.FindAsync(id);
            if (iceCream == null)
            {
                return HttpNotFound();
            }
            return View(iceCream);
        }

        // GET: IceCreams/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: IceCreams/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "MenuID,MenuName,DetailedDecs,Rate")] IceCream iceCream)
        {
            if (ModelState.IsValid)
            {
                db.IceCreams.Add(iceCream);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(iceCream);
        }

        // GET: IceCreams/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IceCream iceCream = await db.IceCreams.FindAsync(id);
            if (iceCream == null)
            {
                return HttpNotFound();
            }
            return View(iceCream);
        }

        // POST: IceCreams/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "MenuID,MenuName,DetailedDecs,Rate")] IceCream iceCream)
        {
            if (ModelState.IsValid)
            {
                db.Entry(iceCream).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(iceCream);
        }

        // GET: IceCreams/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IceCream iceCream = await db.IceCreams.FindAsync(id);
            if (iceCream == null)
            {
                return HttpNotFound();
            }
            return View(iceCream);
        }

        // POST: IceCreams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            IceCream iceCream = await db.IceCreams.FindAsync(id);
            db.IceCreams.Remove(iceCream);
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
