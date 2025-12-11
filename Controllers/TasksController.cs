using Microsoft.AspNetCore.Mvc;
using sharp_tasks.Mappers;
using sharp_tasks.Services;
using sharp_tasks.ViewModels.Task;
using System.Text.Json;

namespace sharp_tasks.Controllers;

public class TasksController : Controller
{
    private readonly ISessionManagerService _sessionManager;

    public TasksController(ISessionManagerService sessionManager)
    {
        _sessionManager = sessionManager ?? throw new ArgumentNullException(nameof(sessionManager));
    }

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

        List<Models.Task> tasks;

        if (HttpContext.Session.GetString("Tasks") == null)
        {
            tasks = new List<Models.Task>();
        }
        else
        {
            tasks = JsonSerializer.Deserialize<List<Models.Task>>(HttpContext.Session.GetString("Tasks"));
        }

        Models.Task task = TaskMapper.GetTaskFromTaskAddVM(model);
        tasks.Add(task);

        _sessionManager.Add("Tasks", tasks);

        return RedirectToAction(nameof(Index));
    }
}