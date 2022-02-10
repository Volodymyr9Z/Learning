using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Chat.Domain;
namespace Chat.Application.Messages.Queries.GetAllMessages
{
    public class GetAllMessagesQuery :IRequest<AllMessagesVm>
    {
        public int ChatId { get; set; }
    }
}
