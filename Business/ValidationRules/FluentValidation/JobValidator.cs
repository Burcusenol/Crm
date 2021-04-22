using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class JobValidator : AbstractValidator<Job>
    {
        public JobValidator()
        {
            RuleFor(j => j.WorkingWay).NotEmpty();
            RuleFor(j => j.Profession).NotEmpty();
        }
    }
}
