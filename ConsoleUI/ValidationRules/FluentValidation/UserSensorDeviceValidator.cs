using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class UserSensorDeviceValidator : AbstractValidator<UserSensorDevice>
    {
        public UserSensorDeviceValidator()
        {
            RuleFor(usd => usd.SensorId).NotEmpty();
            RuleFor(usd => usd.UserId).NotEmpty();

            RuleFor(usd => usd.SensorId).GreaterThanOrEqualTo(1);
            RuleFor(usd => usd.UserId).GreaterThanOrEqualTo(1);
        }
    }
}
