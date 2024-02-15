using Infrastructure.InfrastructureBases;
using Infrastructure.Interfaces;
using Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;


namespace Infrastructure;

public static class ModuleInfrastructureDependencies
{
    public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services)
    {
        services.AddTransient<IProduitRepos, ProduitRepository>();
        services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));
        return services;
    }
}
