using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Chat.Domain;

namespace Chat.Application.Messages.Commands.CreateMessage
{
    public class CreateMessageCommand :IRequest<int>
    {
        public int ChatId { get; set; }
        public string SendingMessage { get; set; }
        public ChatUser ChatUser { get; set; }
        public DateTime SendingDate { get; set; }
        public int Id { get; set; }
    }
}
