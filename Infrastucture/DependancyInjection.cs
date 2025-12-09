using Domain.Repoistiers;
using Infrastucture.Reposities;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    // We will Register in Program 
    public static class DependancyInjection
    {
        public static IServiceCollection AddInfrastucture(this IServiceCollection services)
        {
           services.AddScoped(typeof(IProductRepoistery), typeof(ProductRepoistry));
            return services;
        }
    }
}
