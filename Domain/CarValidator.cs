using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace BasicWebAPI.Domain
{
    class CarValidator : AbstractValidator<CarDTO>
    {
        public CarValidator()
        {
            RuleFor(x => x.id).NotNull();
            //RuleFor(x => x.Deadline).GreaterThan(DateTime.Now);
            RuleFor(x => x.acceleration).LessThanOrEqualTo(100);
            RuleFor(x => x.braking).LessThanOrEqualTo(100);

        }

    }
}
