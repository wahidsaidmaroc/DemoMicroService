using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Service.Interfaces;
using Service.Service;
using System.Reflection;

namespace Service;

public static class ModuleServiceDependencies
{
    public static IServiceCollection AddServiceDependencies(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddMediatR(Assembly.GetExecutingAssembly());

        //Services Injection
        services.AddScoped<IUnitOfService, UnitOfService>();
        return services;
    }
}
