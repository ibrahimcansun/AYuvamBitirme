using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class MainDeviceValidator : AbstractValidator<MainDevice>
    {
        public MainDeviceValidator()
        {
            RuleFor(m => m.DeviceId).NotEmpty();
            RuleFor(m => m.UserId).NotEmpty();
            //RuleFor(m => m.HomeId).NotEmpty();
            RuleFor(m => m.DeviceName).NotEmpty();
            RuleFor(m => m.DeviceProps).NotEmpty();
            RuleFor(m => m.Digital).NotEmpty();
            RuleFor(m => m.Analog).NotEmpty();

            RuleFor(m => m.DeviceName).MaximumLength(50);
            RuleFor(m => m.DeviceProps).MaximumLength(255);
            RuleFor(m => m.Digital).LessThanOrEqualTo(Convert.ToByte(64));
            RuleFor(m => m.Analog).LessThanOrEqualTo(Convert.ToByte(64));
        }
    }
}
