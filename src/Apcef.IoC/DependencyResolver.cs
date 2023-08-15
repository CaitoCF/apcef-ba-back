using Apcef.Application;
using Apcef.Domain.Abstractions.Application;
using Apcef.Domain.Abstractions.Repository;
using Apcef.Domain.Abstractions.Repository.General;
using Apcef.Domain.Abstractions.Repository.WebApp;
using Apcef.Domain.Entities;
using Apcef.Infrastructure.Context;
using Apcef.Infrastructure.Repositories.Base;
using Apcef.Infrastructure.Repositories.General;
using Apcef.Infrastructure.Repositories.WebApp;
using Microsoft.Extensions.DependencyInjection;

namespace Apcef.IoC
{
    public static class DependencyResolver
    {

        public static void AddDependencyResolver(this IServiceCollection services)
        {
            AddDomain(services);
            AddApplication(services);
            AddRepository(services);
        }
        private static void AddDomain(IServiceCollection services)
        {

        }
        private static void AddRepository(IServiceCollection services)
        {
            services.AddScoped<IContext, Context>();
            services.AddScoped<IRepository<Modality>, Repository<Modality>>();
            services.AddScoped<IRepository<Team>, Repository<Team>>();
            services.AddScoped<IRepository<Group>, Repository<Group>>();
            services.AddScoped<IRepository<Branch>, Repository<Branch>>();
            services.AddScoped<IRepository<Round>, Repository<Round>>();
            services.AddScoped<IRepository<Match>, Repository<Match>>();

            services.AddSingleton<IAuthRepository, AuthRepository>();
            services.AddSingleton<IWebAppRepository, WebAppRepository>();
        }
        private static void AddApplication(IServiceCollection services)
        {
            services.AddScoped<IWebAppApplication, WebAppApplication>();
            services.AddScoped<IAppDataApplication, AppDataApplication>();
        }

    }
}
