using Ecommerce.Application.Interfaces.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Ecommerce.Application
{
    public static class DependencyInjection
    {
        /*public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<Irepo, Repository>();

            return services;
        }*/

        public static void AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper();
            services.AddMediator();
        }

        private static void AddAutoMapper(this IServiceCollection services)
        {
            //services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }

        private static void AddMediator(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        }
    }
}
