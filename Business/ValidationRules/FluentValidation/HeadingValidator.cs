using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class HeadingValidator:AbstractValidator<Heading>
    {
        public HeadingValidator()
        {
            RuleFor(h => h.Name).NotEmpty();
            RuleFor(h => h.SurName).NotEmpty();
            RuleFor(h => h.Identification).NotEmpty();
            RuleFor(h => h.BirthDate).NotEmpty();
                       
        }
    }
}
