using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.EntityFrameworkCore;
using Chat.Domain;

namespace Chat.Application.Interfaces
{
    public interface IChatDbContext
    {
        DbSet<Domain.Chat> Chats { get; set; }
        DbSet<ChatUser> ChatUsers { get; set; }
        DbSet<Message> Messages { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
