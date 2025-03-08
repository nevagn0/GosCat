using Gos.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gos.Controllers
{
    
    public class RegistrationController : Controller
    {
        private readonly SpoProjectContext _context;
        public RegistrationController(SpoProjectContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Check(User user)
        {
            if (ModelState.IsValid) 
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                return Redirect("/");
            }
            return View("Index");
        }

    }

}
