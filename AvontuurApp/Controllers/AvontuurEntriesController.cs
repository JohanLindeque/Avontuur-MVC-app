using AvontuurApp.Data;
using AvontuurApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AvontuurApp.Controllers
{
    public class AvontuurEntriesController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AvontuurEntriesController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<AvontuurEntry> objAvontuurEntryList = _db.AvontuurEntries.ToList();

            return View(objAvontuurEntryList);
        }

        // new action to open Create avontuur entry view
        public IActionResult Create()
        {
            return View();
        }

        //new action to post new entry
        [HttpPost]
        public IActionResult Create(AvontuurEntry obj)
        {
            // server side validation
            if (obj != null && obj.Title.Length < 3)
            {
                ModelState.AddModelError("Title", "Title to short.");
            }

            if (ModelState.IsValid)
            {
                _db.AvontuurEntries.Add(obj); // add new entry
                _db.SaveChanges();// saves entry to db

                return RedirectToAction("Index");
            }

            return View(obj);
        }

        // new actions to edit entry
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            AvontuurEntry? avontuurEntry = _db.AvontuurEntries.Find(id);

            if (avontuurEntry == null)
            {
                return NotFound();
            }

            return View(avontuurEntry);
        }

        [HttpPost]
        public IActionResult Edit(AvontuurEntry obj)
        {
            if(obj != null && obj.Title.Length < 3)
            {
                ModelState.AddModelError("Title", "Title to short.");
            }

            if (ModelState.IsValid)
            {
                _db.AvontuurEntries.Update(obj); // update entry
                _db.SaveChanges();// saves entry to db

                return RedirectToAction("Index");
            }

            return View(obj);
        }

        // new actions for delete
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            AvontuurEntry? avontuurEntry = _db.AvontuurEntries.Find(id);

            if (avontuurEntry == null)
            {
                return NotFound();
            }

            return View(avontuurEntry);
        }

        [HttpPost]
        public IActionResult Delete(AvontuurEntry obj)
        {
                _db.AvontuurEntries.Remove(obj); // remove entry from db
                _db.SaveChanges();// saves entry to db

                return RedirectToAction("Index");
        }


    }
}
