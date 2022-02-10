using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Chat.Domain;
using Chat.Application.Interfaces;
using Chat.Persistence.EntityTypeConfigurations;
namespace Chat.Persistence
{
    public class ChatDbContext :DbContext , IChatDbContext
    {
       
        public ChatDbContext(DbContextOptions<ChatDbContext> options):base (options) { }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Domain.Chat> Chats { get; set; }
        public DbSet<ChatUser> ChatUsers { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ChatConfiguration());
            base.OnModelCreating(builder);
        }
    }
}
