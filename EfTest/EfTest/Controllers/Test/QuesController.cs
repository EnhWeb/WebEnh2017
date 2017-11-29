using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EfTest.Models;

namespace EfTest.Controllers.Test
{
    public class QuesController : Controller
    {
        private EFCodeFirstDbContext db = new EFCodeFirstDbContext();

        // GET: Ques
        public async Task<ActionResult> Index()
        {
            return View(await db.Ques.ToListAsync());
        }

        // GET: Ques/Details/5
        public async Task<ActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Que que = await db.Ques.FindAsync(id);
            if (que == null)
            {
                return HttpNotFound();
            }
            return View(que);
        }

        // GET: Ques/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ques/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,TopicTitle,Stem,TopicPic,CreateTime,UpdateTime,RowVersion")] Que que)
        {
            if (ModelState.IsValid)
            {
                que.Id = Guid.NewGuid();
                db.Ques.Add(que);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(que);
        }

        // GET: Ques/Edit/5
        public async Task<ActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Que que = await db.Ques.FindAsync(id);
            if (que == null)
            {
                return HttpNotFound();
            }
            return View(que);
        }

        // POST: Ques/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,TopicTitle,Stem,TopicPic,CreateTime,UpdateTime,RowVersion")] Que que)
        {
            if (ModelState.IsValid)
            {
                que.RowVersion = await RowVersionHelper.GetAsync(Request.Form);

                db.Entry(que).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(que);
        }

        // GET: Ques/Delete/5
        public async Task<ActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Que que = await db.Ques.FindAsync(id);
            if (que == null)
            {
                return HttpNotFound();
            }
            return View(que);
        }

        // POST: Ques/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(Guid id)
        {
            Que que = await db.Ques.FindAsync(id);
            db.Ques.Remove(que);
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
