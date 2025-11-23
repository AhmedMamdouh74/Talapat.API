using Application.Mapping;
using Microsoft.Extensions.DependencyInjection;



namespace Application.DI
{
    public static class ApplicationLayerConfigurations
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)

        {
            // Add application services and configurations here
            services.AddAutoMapper(op => op.AddProfile<MapConfig>());
            return services;
        }
    }
}
