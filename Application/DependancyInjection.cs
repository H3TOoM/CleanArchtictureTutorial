using Application.Features.Behaviors;
using Application.Features.Commands;
using Application.Features.Queries;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    public static class DependancyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            var assembly = typeof(DependancyInjection).Assembly;
            services.AddMediatR(Config => 
                Config.RegisterServicesFromAssembly(assembly)
            );

            services.AddValidatorsFromAssembly(assembly);
            services.AddValidatorsFromAssemblyContaining<AddProductCommandValidator>();
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));


            services.AddTransient<AddProductCommandHandler>()
                .AddTransient<GetAllProductsQueryHandler>();

            return services;
        }
    }
}
