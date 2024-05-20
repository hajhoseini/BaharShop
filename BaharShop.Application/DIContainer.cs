using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace BaharShop.Application
{
    public static class DIContainer
    {
        public static IServiceCollection ApplicationServiceCollections(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

            return services;
        }
    }
}
