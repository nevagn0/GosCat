using Microsoft.AspNetCore.Mvc;

namespace Gos.Controllers
{
    public class MainPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
