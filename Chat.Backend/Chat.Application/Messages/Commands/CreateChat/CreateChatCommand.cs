using System;
using MediatR;
using Chat.Domain;
using System.Collections.Generic;

namespace Chat.Application.Messages.Commands.CreateChat
{
    public class CreateChatCommand :IRequest<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ChatType Type { get; set; }
        public ICollection<Message> Messages { get; set; }
        public ICollection<ChatUser> Users { get; set; }
    }
}
