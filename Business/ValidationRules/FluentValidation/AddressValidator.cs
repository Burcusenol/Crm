using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(a => a.AddressType).NotEmpty();
            RuleFor(a => a.RecipientName).NotEmpty();
            RuleFor(a => a.Country).NotEmpty();
            RuleFor(a => a.City).NotEmpty();
            RuleFor(a => a.District).NotEmpty();
            RuleFor(a => a.ApartmentNo).NotEmpty();
           
        }
    }
}
