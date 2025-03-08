using Gos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Gos.Controllers
{
    public class AuthorizationController : Controller
    {
        private readonly SpoProjectContext _projectContext;
        public AuthorizationController(SpoProjectContext projectContext)
        {
            _projectContext = projectContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Auth(User user)
        {
            if (ModelState.IsValid)
            {
                var NameAuth = _projectContext.Users.FirstOrDefault(b => b.Firstname == user.Firstname);
                var SecondAuth = _projectContext.Users.FirstOrDefault(h => h.Secondname == user.Secondname);
                var PhoneAuth = _projectContext.Users.FirstOrDefault(k => k.Phone == user.Phone);

                if (NameAuth != null && SecondAuth != null && PhoneAuth != null)
                {
                    // Сохраняем ID пользователя в сессии
                    HttpContext.Session.SetInt32("UserId", NameAuth.Id);

                    // Перенаправляем на главную страницу
                    return RedirectToAction("Index", "MainPage");
                }
                else
                {
                    ModelState.AddModelError("Firstname", "Пользователь с такими данными не найден.");
                }
            }

            // Возвращаем представление Index с ошибками
            return View("Index", user);
        }

    }
}
