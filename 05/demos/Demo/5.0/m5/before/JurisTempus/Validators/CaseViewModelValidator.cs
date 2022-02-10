using FluentValidation;
using JurisTempus.Data.Entities;
using JurisTempus.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JurisTempus.Validators
{
  public class CaseViewModelValidator : AbstractValidator<CaseViewModel>
  {
    public CaseViewModelValidator()
    {
      RuleFor(c => c.FileNumber).NotEmpty()
                                .Matches(@"^\d{10}$")
                                .WithMessage("File Number must be ten digits");
      RuleFor(c => c.Status).IsInEnum()
                            .NotEqual(CaseStatus.Invalid)
                            .WithName("CaseStatus");
    }
  }
}
