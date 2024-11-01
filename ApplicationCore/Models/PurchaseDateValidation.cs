using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public class PurchaseDateValidation : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is DateTime dateTimeValue)
            {
                DateTime _date = DateTime.Now;
                DateTime now = DateTime.Now;
                DateTime end = DateTime.Now.AddDays(-1).AddTicks(1);
                bool check = (_date >= end) && _date <= now;
                if (check)
                {
                    return ValidationResult.Success;
                }
            }

            return new ValidationResult("Date does not occur with in the same day: purchase error...");
        }


    }
}
