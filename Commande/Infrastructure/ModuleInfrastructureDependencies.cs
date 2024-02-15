
using unOf = Infrastructure.UnitOfWork ;
using Microsoft.Extensions.DependencyInjection;


namespace Infrastructure;

public static class ModuleInfrastructureDependencies
{
    public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services)
    {
        services.AddScoped<unOf.IUnitOfWork, unOf.UnitOfWork>();

        return services;
    }
}
