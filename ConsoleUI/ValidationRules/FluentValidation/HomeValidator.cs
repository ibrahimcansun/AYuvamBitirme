using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class HomeValidator:AbstractValidator<Home>
    {
        public HomeValidator()
        {
            RuleFor(h => h.StructureId).NotEmpty();
            RuleFor(h => h.AreaId).NotEmpty();
            RuleFor(h => h.AreaId).LessThanOrEqualTo(Convert.ToByte(82));
            RuleFor(h => h.StructureName).NotEmpty();
            RuleFor(h => h.StructureName).MaximumLength(30);
        }
    }
}
