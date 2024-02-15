using Data.Entities;
using Microsoft.Extensions.DependencyInjection;
using Service.Implementations;
using Service.Interfaces;

namespace Service;

public static class ModuleServiceDependencies
{
    public static IServiceCollection AddServiceDependencies(this IServiceCollection services)
    {
        services.AddTransient<IProduitService, ProduitService>();

        return services;
    }
}
