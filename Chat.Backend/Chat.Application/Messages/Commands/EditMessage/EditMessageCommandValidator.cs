using System;
using FluentValidation;

namespace Chat.Application.Messages.Commands.EditMessage
{
    public class EditMessageCommandValidator: AbstractValidator<EditMessageCommand>
    {
        public EditMessageCommandValidator()
        {
            RuleFor(editMessageCommand =>
            editMessageCommand.Id).NotEqual(0);
            RuleFor(editMessageCommand =>
            editMessageCommand.SendingMessage).NotEmpty();

        }
    }
}
