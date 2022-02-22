using FluentValidation;
using JurisTempus.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JurisTempus.Validators
{
  public class ContactViewModelValidator : AbstractValidator<ContactViewModel>
  {
    public ContactViewModelValidator()
    {
      RuleFor(c => c.Email).NotEmpty()
                           .EmailAddress();
      RuleFor(c => c.Subject).NotEmpty()
                             .MaximumLength(100);
      RuleFor(c => c.Message).NotEmpty()
                             .MaximumLength(4000);
    }
  }
}
