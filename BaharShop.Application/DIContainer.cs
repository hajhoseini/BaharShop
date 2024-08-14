using BaharShop.Application.Services.Carts;
using BaharShop.Application.Services.Orders;
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
            services.AddScoped<ICartServices, CartServices>();
            services.AddScoped<IOrderServices, OrderServices>();

            return services;
        }
    }
}
