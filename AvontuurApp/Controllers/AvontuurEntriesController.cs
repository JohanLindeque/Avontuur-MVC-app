using Microsoft.AspNetCore.Mvc;

namespace AvontuurApp.Controllers
{
    public class AvontuurEntriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
