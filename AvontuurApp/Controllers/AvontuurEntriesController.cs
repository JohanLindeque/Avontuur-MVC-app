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
    }
}
