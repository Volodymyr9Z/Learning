using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Chat.Domain;
using Chat.Application.Interfaces;



namespace Chat.Application.Messages.Commands.DeleteMessage
{
    public class DeleteMessageCommand : IRequest
    {
       // public Guid UserId { get; set; }
        public int Id { get; set; }
    }
}
