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
    public class RiceKheersController : Controller
    {
        private RestaurantModels db = new RestaurantModels();

        // GET: RiceKheers
        public async Task<ActionResult> Index()
        {
            return View(await db.RiceKheers.ToListAsync());
        }

        // GET: RiceKheers/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RiceKheer riceKheer = await db.RiceKheers.FindAsync(id);
            if (riceKheer == null)
            {
                return HttpNotFound();
            }
            return View(riceKheer);
        }

        // GET: RiceKheers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RiceKheers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "MenuID,MenuName,DetailedDecs,Rate")] RiceKheer riceKheer)
        {
            if (ModelState.IsValid)
            {
                db.RiceKheers.Add(riceKheer);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(riceKheer);
        }

        // GET: RiceKheers/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RiceKheer riceKheer = await db.RiceKheers.FindAsync(id);
            if (riceKheer == null)
            {
                return HttpNotFound();
            }
            return View(riceKheer);
        }

        // POST: RiceKheers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "MenuID,MenuName,DetailedDecs,Rate")] RiceKheer riceKheer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(riceKheer).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(riceKheer);
        }

        // GET: RiceKheers/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RiceKheer riceKheer = await db.RiceKheers.FindAsync(id);
            if (riceKheer == null)
            {
                return HttpNotFound();
            }
            return View(riceKheer);
        }

        // POST: RiceKheers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            RiceKheer riceKheer = await db.RiceKheers.FindAsync(id);
            db.RiceKheers.Remove(riceKheer);
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
