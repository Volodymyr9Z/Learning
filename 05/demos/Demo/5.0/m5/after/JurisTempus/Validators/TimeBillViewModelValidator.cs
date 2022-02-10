using FluentValidation;
using JurisTempus.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JurisTempus.Validators
{
  public class TimeBillViewModelValidator : AbstractValidator<TimeBillViewModel>
  {
    public TimeBillViewModelValidator()
    {
      RuleFor(b => b.Rate).InclusiveBetween(0m, 500m);
      RuleFor(b => b.TimeSegments).GreaterThan(0);
      RuleFor(b => b.WorkDescription).MinimumLength(25);
      RuleFor(b => b.CaseId).NotEmpty();
      RuleFor(b => b.EmployeeId).NotEmpty();
    }
  }
}
