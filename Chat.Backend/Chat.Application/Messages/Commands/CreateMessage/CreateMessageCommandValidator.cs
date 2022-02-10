using System;
using FluentValidation;

namespace Chat.Application.Messages.Commands.CreateMessage
{
    public class CreateMessageCommandValidator : AbstractValidator<CreateMessageCommand>
    {
        public CreateMessageCommandValidator()
        {
            RuleFor(createMessageCommand =>
            createMessageCommand.ChatUser.FirstName).NotEmpty().MaximumLength(30);
            RuleFor(createMessageCommand =>
            createMessageCommand.ChatUser.LastName).NotEmpty().MaximumLength(30);
            RuleFor(createMessageCommand =>
            createMessageCommand.Id).NotEqual(0);
            RuleFor(createMessageCommand =>
            createMessageCommand.ChatUser.UserId).NotEqual(Guid.Empty);
            RuleFor(createMessageCommand =>
            createMessageCommand.SendingMessage).NotEmpty();
            RuleFor(createMessageCommand =>
            createMessageCommand.ChatId).NotEqual(0);

        }
    }
}
