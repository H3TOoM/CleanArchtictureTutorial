using Application.Interfaces;
using Application.Services;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    // We will Register in Program 
    public static class DependancyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            var assembly = typeof(DependancyInjection).Assembly;
            services.AddMediatR(Config => 
                Config.RegisterServicesFromAssembly(assembly)
            );

            services.AddValidatorsFromAssembly(assembly);
            services.AddScoped<IProductService, ProductService>();

            return services;
        }
    }
}
