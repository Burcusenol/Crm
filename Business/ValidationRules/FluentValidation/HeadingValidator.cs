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
            RuleFor(h => h.Name).NotEmpty().WithMessage("Lütfen muhatabın Ad, Soyad ve en az bir iletişim bilgisini giriniz.");
            RuleFor(h => h.SurName).NotEmpty().WithMessage("Lütfen muhatabın Ad, Soyad ve en az bir iletişim bilgisini giriniz.");
            RuleFor(h => h.Identification).NotEmpty();
            RuleFor(h => h.BirthDate).NotEmpty();
                       
        }
    }
}
