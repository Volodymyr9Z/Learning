using Microsoft.Extensions.DependencyInjection;
using AutoMapper.Configuration;
using MediatR;
using System.Reflection;
using FluentValidation;
using Chat.Application.Common.Behaviors;

namespace Chat.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services )
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssemblies(new[] { Assembly.GetExecutingAssembly() });
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
            return services;
        }

    }
}
