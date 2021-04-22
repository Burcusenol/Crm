using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class HomeValidator : AbstractValidator<Home>
    {
        public HomeValidator()
        {
            RuleFor(h => h.HomeStatus).NotEmpty();
        }
    }
}
