using System;
using System.ComponentModel.DataAnnotations;

namespace sharp_tasks.Validation;

public class FutureDateAttribute : ValidationAttribute
{
    public override bool IsValid(object value)
    {
        if (value == null)
        {
            return true; // [Required] handle null values
        }

        if (value is DateTime date)
        {
            return date.Date >= DateTime.Today;
        }

        return false;
    }

    public override string FormatErrorMessage(string name)
    {
        return $"The {name} must be today or a future date.";
    }
}