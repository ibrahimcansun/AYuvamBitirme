using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class NormalUserValidator : AbstractValidator<NormalUser>
    {
        public NormalUserValidator()
        {
            RuleFor(u => u.UserId).NotEmpty();
            RuleFor(u => u.Name).NotEmpty();
            RuleFor(u => u.Password).NotEmpty();
            RuleFor(u => u.Email).NotEmpty();

            RuleFor(u => u.Name).MaximumLength(30);
            RuleFor(u => u.Name).MinimumLength(3);
            RuleFor(u => u.Email).MaximumLength(150);
            RuleFor(u => u.Email).MinimumLength(5);
            RuleFor(u => u.Password).MaximumLength(150);
            RuleFor(u => u.Password).MinimumLength(10);
        }
    }
}
