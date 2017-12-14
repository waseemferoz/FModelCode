using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AngAsp.Models;

namespace AngAsp.Controllers
{
    public class FModelsController : Controller
    {
        private IdentityDBContext db = new IdentityDBContext();

        // GET: FModels
        public async Task<ActionResult> Index()
        {
            ViewBag.Name = "Waseem";
            return View(await db.MyModel.ToListAsync());
        }

        // GET: FModels/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FModel fModel = await db.MyModel.FindAsync(id);
            if (fModel == null)
            {
                return HttpNotFound();
            }
            return View(fModel);
        }

        // GET: FModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Name")] FModel fModel)
        {
            if (ModelState.IsValid)
            {
                db.MyModel.Add(fModel);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(fModel);
        }

        // GET: FModels/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FModel fModel = await db.MyModel.FindAsync(id);
            if (fModel == null)
            {
                return HttpNotFound();
            }
            return View(fModel);
        }

        // POST: FModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Name")] FModel fModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fModel).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(fModel);
        }

        // GET: FModels/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FModel fModel = await db.MyModel.FindAsync(id);
            if (fModel == null)
            {
                return HttpNotFound();
            }
            return View(fModel);
        }

        // POST: FModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            FModel fModel = await db.MyModel.FindAsync(id);
            db.MyModel.Remove(fModel);
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
