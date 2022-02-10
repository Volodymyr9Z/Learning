using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Chat.Application.Interfaces;
using Chat.Domain;
using Microsoft.EntityFrameworkCore;
using Chat.Application.Common.Exceptions;
namespace Chat.Application.Messages.Commands.EditMessage
{
    public class EditMessageCommandHandler : IRequestHandler<EditMessageCommand>
    {
        private readonly IChatDbContext _chatDbContext;
        public EditMessageCommandHandler(IChatDbContext DbContext) => _chatDbContext = DbContext;

        public async Task<Unit> Handle(EditMessageCommand request, CancellationToken cancellationToken)
        {
            var message = 
            await _chatDbContext.Messages.FirstOrDefaultAsync(message => message.Id == request.Id, cancellationToken);
            if (message == null || message.Id != request.Id)
            {
                throw new NotFoundException(nameof(Message), request.Id);
            }
            message.SendingMessage = request.SendingMessage;
            message.EditDate = DateTime.Now;
            await _chatDbContext.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }

        
    }
}
