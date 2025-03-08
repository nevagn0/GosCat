using System.Reflection.Metadata.Ecma335;
using Gos.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gos.Controllers
{
    public class AddAnimalController : Controller
    {
        private readonly SpoProjectContext _projectContext;
        public AddAnimalController(SpoProjectContext projectContext)
        {
            _projectContext = projectContext;
        }
        [HttpPost]
        public IActionResult Index(Animal animal)
        {
            if (ModelState.IsValid)
            {
                // Добавляем животное в базу данных
                _projectContext.Animals.Add(animal);
                _projectContext.SaveChanges();

                // Перенаправляем на главную страницу или другую страницу
                return RedirectToAction("Index", "AddAnimal");
            }

            // Если данные не прошли валидацию, возвращаем форму с ошибками
            return View(animal);
        }

        public IActionResult Index()
        {
            var userId = HttpContext.Session.GetInt32("UserId");

            if (userId == null)
            {
                return RedirectToAction("Index", "Authorization");
            }

            var user = _projectContext.Users.FirstOrDefault(u => u.Id == userId);

            if (user == null)
            {
                return RedirectToAction("Error");
            }

            ViewBag.UserId = userId;
            ViewBag.UserFullName = $"{user.Firstname} {user.Secondname}";

            return View();
        }

        public IActionResult AddAnimalPage()
        {
            var userId = HttpContext.Session.GetInt32("UserId");
            var user = _projectContext.Users.FirstOrDefault(u => u.Id == userId);

            ViewBag.UserId = userId;
            ViewBag.UserFullName = $"{user.Secondname} {user.Firstname}";
            return View("Index");
        }

        public void PageNewAnimal(Animal animal)
        {

        }

    }
}
