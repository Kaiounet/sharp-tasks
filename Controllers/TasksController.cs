using Microsoft.AspNetCore.Mvc;
using sharp_tasks.ViewModels.Task;

namespace sharp_tasks.Controllers
{
    public class TasksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(TaskAddVM model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            return RedirectToAction(nameof(Index));
        }

    }
}
