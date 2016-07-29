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
    public class MiniDishesController : Controller
    {
        private RestaurantModels db = new RestaurantModels();

        // GET: MiniDishes
        public async Task<ActionResult> Index()
        {
            return View(await db.MiniDishes.ToListAsync());
        }

        // GET: MiniDishes/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MiniDish miniDish = await db.MiniDishes.FindAsync(id);
            if (miniDish == null)
            {
                return HttpNotFound();
            }
            return View(miniDish);
        }

        // GET: MiniDishes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MiniDishes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "MenuID,MenuName,DetailedDecs,Rate")] MiniDish miniDish)
        {
            if (ModelState.IsValid)
            {
                db.MiniDishes.Add(miniDish);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(miniDish);
        }

        // GET: MiniDishes/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MiniDish miniDish = await db.MiniDishes.FindAsync(id);
            if (miniDish == null)
            {
                return HttpNotFound();
            }
            return View(miniDish);
        }

        // POST: MiniDishes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "MenuID,MenuName,DetailedDecs,Rate")] MiniDish miniDish)
        {
            if (ModelState.IsValid)
            {
                db.Entry(miniDish).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(miniDish);
        }

        // GET: MiniDishes/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MiniDish miniDish = await db.MiniDishes.FindAsync(id);
            if (miniDish == null)
            {
                return HttpNotFound();
            }
            return View(miniDish);
        }

        // POST: MiniDishes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            MiniDish miniDish = await db.MiniDishes.FindAsync(id);
            db.MiniDishes.Remove(miniDish);
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
