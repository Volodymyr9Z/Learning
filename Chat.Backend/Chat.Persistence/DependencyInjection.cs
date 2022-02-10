using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Chat.Application.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Chat.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
             var optionsBuilder = new DbContextOptionsBuilder<ChatDbContext>();
           var connectionString = configuration["DefaultConnection"];
            services.AddDbContext<ChatDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });
            services.AddScoped<IChatDbContext>(provider =>  provider.GetService<ChatDbContext>());
            return services;

        }
    }
}
