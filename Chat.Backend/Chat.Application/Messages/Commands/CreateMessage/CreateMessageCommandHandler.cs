using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using MediatR;
using Chat.Domain;
using Chat.Application.Interfaces;

namespace Chat.Application.Messages.Commands.CreateMessage
{
    public class CreateMessageCommandHandler : IRequestHandler<CreateMessageCommand, int>
    {
        private readonly IChatDbContext _ChatDbContext;
        public CreateMessageCommandHandler(IChatDbContext dbContext) => _ChatDbContext = dbContext;
        public async Task<int> Handle(CreateMessageCommand request, CancellationToken cancellationToken)
        {
            var message = new Message
            {

                SendingMessage = request.SendingMessage,
                Id = request.Id,
                SendingDate = DateTime.Now,
                ChatUser = request.ChatUser,
                ChatId = request.ChatId
                
            };
            await _ChatDbContext.Messages.AddAsync(message, cancellationToken);
            await _ChatDbContext.SaveChangesAsync(cancellationToken);

            return message.Id;
        }
    }
}
