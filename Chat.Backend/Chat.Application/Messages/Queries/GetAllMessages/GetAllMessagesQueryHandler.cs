using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Chat.Application.Interfaces;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using AutoMapper.QueryableExtensions;
namespace Chat.Application.Messages.Queries.GetAllMessages
{
    public class GetAllMessagesQueryHandler : IRequestHandler<GetAllMessagesQuery, AllMessagesVm>
    {
        private readonly IChatDbContext _chatDbContext;
        private readonly IMapper _mapper;
        public GetAllMessagesQueryHandler(IChatDbContext chatDbContext, IMapper mapper)
        {
            _chatDbContext = chatDbContext;
            _mapper = mapper;
        }

        public async Task<AllMessagesVm> Handle(GetAllMessagesQuery request, CancellationToken cancellationToken)
        {
            var chatQuery = await _chatDbContext.Messages
                .Where(message => message.ChatId == request.ChatId)
                .ProjectTo<MessageLookUpDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
            return new AllMessagesVm { Messages = chatQuery };
        }
    }
}
