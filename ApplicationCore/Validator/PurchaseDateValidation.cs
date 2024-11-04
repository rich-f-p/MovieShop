using ApplicationCore.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public class PurchaseDateValidation : AbstractValidator<Purchase>
    {
        public PurchaseDateValidation()
        {
            RuleFor(p => p.PurchaseDateTime >= DateTime.Now.Date);
        }

    }
}
