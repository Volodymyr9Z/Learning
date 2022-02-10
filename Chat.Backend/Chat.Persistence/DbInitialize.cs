using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Persistence
{
    public  class DbInitialize
    {
        public static void Initialize(ChatDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
