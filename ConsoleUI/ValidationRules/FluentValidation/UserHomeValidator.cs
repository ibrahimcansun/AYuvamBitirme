using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class UserHomeValidator:AbstractValidator<UserHome>
    {
        public UserHomeValidator()
        {
            RuleFor(uhm => uhm.HomeId).NotEmpty();
            RuleFor(uhm => uhm.UserId).NotEmpty();
            RuleFor(uhm => uhm.HomeId).GreaterThanOrEqualTo(1);
            RuleFor(uhm => uhm.UserId).GreaterThanOrEqualTo(1);
        }
    }
}
