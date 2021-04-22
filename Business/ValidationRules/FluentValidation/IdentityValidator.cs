using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class IdentityValidator : AbstractValidator<Identity>
    {
        public IdentityValidator()
        {
            RuleFor(ı => ı.BirthPlace).NotEmpty();
            RuleFor(ı => ı.FatherName).NotEmpty();
            RuleFor(ı => ı.MotherName).NotEmpty();
            RuleFor(ı => ı.Nationality).NotEmpty();
            RuleFor(ı => ı.NationalStatus).NotEmpty();
            RuleFor(ı => ı.Place).NotEmpty();
            
        }
    }
}
