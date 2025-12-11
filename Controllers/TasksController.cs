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
        Models.Task task;
        List<Models.Task> tasks;

        if (!ModelState.IsValid)
        {
            return View();
        }

        task = TaskMapper.GetTaskFromTaskAddVM(model);
        tasks = _sessionManager.Get<List<Models.Task>>("tasks");

        tasks.Add(task);
        _sessionManager.Add("tasks", tasks);

        return RedirectToAction(nameof(Index));
    }
}