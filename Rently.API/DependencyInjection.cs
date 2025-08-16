using Rently.Application;
using Rently.Infrastructure;

namespace Rently.API
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAppDI(this IServiceCollection services)
        {

            services.AddApplicationDI()
                .AddInfrastructureDI();

            return services;
        }
    }
}
