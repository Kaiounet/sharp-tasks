using sharp_tasks.Enums;

namespace sharp_tasks.Models;

public class Task
{

    public string? Label { get; set; }
    public string? Description { get; set; }
    public DateTime LimiteDate { get; set; }
    public State TaskState { get; set; }

}
