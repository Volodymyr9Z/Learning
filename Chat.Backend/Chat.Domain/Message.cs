using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Domain
{
    public class Message
    {
        public ChatUser ChatUser { get; set; }
        public int Id { get; set; }
        public int ChatId { get; set; }

        public string SendingMessage { get; set; }
        public DateTime SendingDate { get; set; }
        public DateTime? EditDate { get; set; }
    }
}
 