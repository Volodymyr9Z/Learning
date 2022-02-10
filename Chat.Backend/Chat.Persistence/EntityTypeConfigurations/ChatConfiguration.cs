using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Chat.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Persistence.EntityTypeConfigurations
{
    class ChatConfiguration :IEntityTypeConfiguration<Message>
    {
        public void Configure (EntityTypeBuilder<Message> builder)
        {
            builder.HasKey(message => message.Id);
            builder.HasIndex(message => message.Id).IsUnique();
            builder.Property(message => message.SendingMessage).HasMaxLength(500);
        }
    }
}
