using Microsoft.Extensions.DependencyInjection;
using Shop.Domain.Commands.CreateCustomer;
using System.Reflection;

namespace Shop.Infra
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            return services;
        }
    }
}
