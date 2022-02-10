using System;
using FluentValidation;

namespace Chat.Application.Messages.Queries.GetAllMessages
{
    public class GetAllMessagesQueryValidator : AbstractValidator<GetAllMessagesQuery>
    {
        public GetAllMessagesQueryValidator()
        {
            RuleFor(getAllMessagesQuery =>
           getAllMessagesQuery.ChatId).NotEqual(0);
        }
    }
}
