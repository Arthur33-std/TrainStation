using TrainStation.DAL.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace TrainStation.BLL.Validation
{
    public class PassageDTOValidator : AbstractValidator<Passage>
    {
        public PassageDTOValidator()
        {
            RuleFor(e => e.Froms)
                .NotEmpty().WithMessage("The Froms cannot be empty")
                .MaximumLength(20).WithMessage("The Froms cannot be longer than 20 characters");
            RuleFor(e => e.Wheres)
                .NotEmpty().WithMessage("The Wheres cannot be empty")
                .MaximumLength(20).WithMessage("The Wheres cannot be longer than 20 characters");
            RuleFor(e => e.Passages)
               .NotEmpty().WithMessage("The Passages cannot be empty")
               .MaximumLength(20).WithMessage("The Passages cannot be longer than 20 characters");
        }
    }
}
