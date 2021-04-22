using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class EducationValidator : AbstractValidator<Education>
    {
        public EducationValidator()
        {
            RuleFor(e => e.EducationStatus).NotEmpty();
        }
    }
}
