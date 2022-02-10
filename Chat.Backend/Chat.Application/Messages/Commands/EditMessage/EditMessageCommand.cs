using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Chat.Application.Messages.Commands.EditMessage
{
    public class EditMessageCommand :IRequest
    {
      
        public string SendingMessage { get; set; }
        public int Id { get; set; }
       
        
    }
}
