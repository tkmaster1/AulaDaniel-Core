using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProjetoDanielEx.Core.Data;
using ProjetoDanielEx.Core.Data.Repository;
using ProjetoDanielEx.Core.Domain.Interfaces.Notifications;
using ProjetoDanielEx.Core.Domain.Interfaces.Repositories;
using ProjetoDanielEx.Core.Domain.Interfaces.Services;
using ProjetoDanielEx.Core.Domain.Notifications;
using ProjetoDanielEx.Core.Service.Application;
using System.IO;

namespace ProjetoDanielEx.Core.IoC
{
    public static class BootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Lifestyle.Transient => Uma instância para cada solicitação
            // Lifestyle.Singleton => Uma instância única para a classe (para servidor)
            // Lifestyle.Scoped => Uma instância única para o request

            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json").Build();

            #region Domain

            services.AddScoped<IClienteAppService, ClienteAppService>();

            #endregion

            #region InfraData

            services.AddScoped<MeuContextoBDs>();
            services.AddScoped<INotificationHandler<DomainNotification>, DomainNotificationHandler>();
            services.AddScoped<IClienteRepository, ClienteRepository>();

            #endregion
        }
    }
}
