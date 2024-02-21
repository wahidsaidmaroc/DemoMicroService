using Data.Entities;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Service.Implementations;
using Service.Interfaces;
using System.Reflection;

namespace Service;

public static class ModuleServiceDependencies
{
    public static IServiceCollection AddServiceDependencies(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddMediatR(Assembly.GetExecutingAssembly());
        return services;
    }
}
