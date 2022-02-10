using System;
using FluentValidation;

namespace Chat.Application.Messages.Commands.DeleteMessage
{
    class DeleteMessageCommandValidator : AbstractValidator<DeleteMessageCommand>
    {
        public DeleteMessageCommandValidator()
        {
             RuleFor(deleteMessageCommand =>
            deleteMessageCommand.Id).NotEqual(0);
        }
    }
}
