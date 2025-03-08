using Microsoft.AspNetCore.Mvc;
using Gos.Models; 
using System.Linq; 

namespace Gos.Controllers
{
    public class MainPageController : Controller
    {
        private readonly SpoProjectContext _context; // Контекст базы данных

        public MainPageController(SpoProjectContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var userId = HttpContext.Session.GetInt32("UserId");

            if (userId == null)
            {
                return RedirectToAction("Index", "Authorization");
            }

            var user = _context.Users.FirstOrDefault(u => u.Id == userId);

            if (user == null)
            {
                return RedirectToAction("Error");
            }

            return View(user);
        }
    }
}