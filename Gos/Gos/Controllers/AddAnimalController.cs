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
        public IActionResult Index(Animal animal)
        {
            if (ModelState.IsValid)
            {
                _projectContext.Animals.Add(animal);
                _projectContext.SaveChanges();
            }
            return View(animal);
        }

        public IActionResult AddAnimalPage()
        {

            return RedirectToAction("Index", "AddAnimal");
        }

    }
}
