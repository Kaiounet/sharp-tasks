using sharp_tasks.ViewModels.Task;

namespace sharp_tasks.Mappers;

public class TaskMapper
{
    public static Models.Task GetTaskFromTaskAddVM(TaskAddVM model)
    {
        return new Models.Task
        {
            Label = model.Label,
            Description = model.Description,
            LimiteDate = model.LimiteDate,
            TaskState = model.TaskState
        };

    }
}
