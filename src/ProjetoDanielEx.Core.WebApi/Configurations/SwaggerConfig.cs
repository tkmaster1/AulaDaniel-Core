using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Linq;

namespace ProjetoDanielEx.Core.WebApi.Configurations
{
    public static class SwaggerConfig
    {
        public static void AddSwaggerConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc
                (
                  "v1"
                  , new OpenApiInfo
                  {
                      Version = configuration["AppSettings:Application:Version"],
                      Title = "Projeto Exemplo Core API",
                      Description = "Projeto Exemplo Core API Swagger",
                      Contact = new OpenApiContact
                      {
                          Name = "Teste Aula Daniel 2",
                          Email = string.Empty
                      }
                  }
                  );

                s.CustomSchemaIds(x => x.FullName);
                s.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
            });
        }
    }
}
