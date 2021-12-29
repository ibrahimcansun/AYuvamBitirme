using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class SensorDeviceValidator : AbstractValidator<SensorDevice>
    {
        public SensorDeviceValidator()
        {
            RuleFor(sd => sd.DeviceId).NotEmpty();
            RuleFor(sd => sd.UserId).NotEmpty();
            RuleFor(sd => sd.HomeId).NotEmpty();
            RuleFor(sd => sd.DeviceName).NotEmpty();
            RuleFor(sd => sd.DeviceProps).NotEmpty();
            RuleFor(sd => sd.State).NotEmpty();

            RuleFor(sd => sd.DeviceId).GreaterThanOrEqualTo(1);
            RuleFor(sd => sd.UserId).GreaterThanOrEqualTo(1);
            RuleFor(sd => sd.HomeId).GreaterThanOrEqualTo(1);
        }
    }
}
