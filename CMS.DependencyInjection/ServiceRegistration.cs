using AutoMapper;
using CMS.FrameworkExtensions;
using CMS.Repository.Implementation;
using CMS.Repository.Infrastructure;
using CMS.Repository.Infrastructure.Interface;
using CMS.Repository.Interface;
using CMS.Service.Implementation;
using CMS.Service.Interface;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CMS.DependencyInjection
{
    public static class ServiceRegistration
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<ICardService, CardService>();
            services.AddScoped<ICardRepository, CardsRepository>();

            
        }
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSettingsProvider(configuration);
            services.AddTransient<IQueryBuilder, SqlQueryBuilder>();
            //services.AddTransient<ISettingsService, SettingsService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IConnectionFactory, SqlConnectionFactory>();
        }
       /* public static void AddAutoMapper(this IServiceCollection services)
        {
            var mapperConfig = AutoMapperConfiguration.Intialize();
            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
        }*/

    }
}
