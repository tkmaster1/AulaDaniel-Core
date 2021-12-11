using Microsoft.Extensions.DependencyInjection;
using ProjetoDanielEx.Core.IoC;
using System;

namespace ProjetoDanielEx.Core.WebApi.Configurations
{
    public static class DependencyInjectionConfiguration
    {
        public static void AddDependencyInjectionConfiguration(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            BootStrapper.RegisterServices(services);
        }
    }
}
