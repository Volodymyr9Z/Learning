using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Chat.Domain;
using System.Threading;
using Chat.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Chat.Application.Common.Exceptions;

namespace Chat.Application.Messages.Commands.DeleteMessage
{
    public class DeleteMessageCommandHandler : IRequestHandler<DeleteMessageCommand>
    {
        private readonly IChatDbContext _chatDbContext;
        public DeleteMessageCommandHandler(IChatDbContext DbContext) => _chatDbContext = DbContext;
        public async Task<Unit> Handle(DeleteMessageCommand request, CancellationToken cancellationToken)
        {
            var message = await _chatDbContext.Messages.FindAsync(new object[] {request.Id}, cancellationToken);
            if (message == null || message.Id != request.Id)
            {
                throw new NotFoundException(nameof(Message), request.Id);
            }
            _chatDbContext.Messages.Remove(message);
            await _chatDbContext.SaveChangesAsync(cancellationToken);
                return Unit.Value;
        }
    }
}
