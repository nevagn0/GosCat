using Microsoft.AspNetCore.Mvc;
using Gos.Models; // Подключите пространство имен с моделью User
using System.Linq; // Для использования LINQ

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
            // Получаем ID пользователя из сессии
            var userId = HttpContext.Session.GetInt32("UserId");

            if (userId == null)
            {
                // Если пользователь не авторизован, перенаправляем на страницу входа
                return RedirectToAction("Index", "Authorization");
            }

            // Получаем пользователя из базы данных
            var user = _context.Users.FirstOrDefault(u => u.Id == userId);

            if (user == null)
            {
                // Если пользователь не найден, показываем ошибку
                return RedirectToAction("Error");
            }

            // Передаем объект User в представление
            return View(user);
        }
    }
}