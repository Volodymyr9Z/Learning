using System;
using MediatR;
using Chat.Domain;
using System.Threading.Tasks;
using System.Threading;
using Chat.Application.Interfaces;

namespace Chat.Application.Messages.Commands.CreateChat
{
    public class CreateChatCommandHandler : IRequestHandler<CreateChatCommand, int>
    {
        private readonly IChatDbContext _chatDbContext;

        public CreateChatCommandHandler(IChatDbContext chatDbContext)
        {
            _chatDbContext = chatDbContext;
        }

        public async Task<int> Handle(CreateChatCommand request, CancellationToken cancellationToken)
        {
            var chat = new Domain.Chat
            {
                Id = request.Id,
                Messages = request.Messages,
                Type = request.Type,
                Name = request.Name,
                Users = request.Users
            };
            await _chatDbContext.Chats.AddAsync(chat, cancellationToken);
            await _chatDbContext.SaveChangesAsync(cancellationToken);
            return chat.Id;
        }
    }
}
