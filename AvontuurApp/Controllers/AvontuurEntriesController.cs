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
    }
}
