using System;
using System.ComponentModel.DataAnnotations;
using sharp_tasks.Enums;

namespace sharp_tasks.ViewModels.Task;

public class TaskAddVM
{
    [Required(ErrorMessage = "The label is required")]
    public string Label { get; set; }
    [Required(ErrorMessage = "The description is required")]
    public string Description { get; set; }
    [Required(ErrorMessage = "The limite date is required")]
    [DataType(DataType.Date)]
    public DateTime LimiteDate { get; set; }
    [Required(ErrorMessage = "The state is required")]
    public State TaskState { get; set; }
}
