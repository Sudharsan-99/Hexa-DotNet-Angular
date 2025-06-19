using System;
using System.ComponentModel.DataAnnotations;

namespace BookValidationApp.Models
{
    public class NotFutureDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value is DateTime dateValue)
            {
                return dateValue <= DateTime.Today;
            }
            return false;
        }
    }
}

