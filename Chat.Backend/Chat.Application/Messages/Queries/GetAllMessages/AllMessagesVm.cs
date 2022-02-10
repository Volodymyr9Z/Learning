using Chat.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Application.Messages.Queries.GetAllMessages
{
    public class AllMessagesVm
    {
        public IList<MessageLookUpDto> Messages {get; set;}
    }
}
