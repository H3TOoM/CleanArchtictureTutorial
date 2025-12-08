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
            return services;
        }
    }
}
