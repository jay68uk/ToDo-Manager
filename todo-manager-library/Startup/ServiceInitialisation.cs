using Microsoft.Extensions.DependencyInjection;

namespace todo_manager_library.Startup;

public static class ServiceInitialisation
{
    public static IServiceCollection RegisterServices(this IServiceCollection services)
    {
        return services;
    }
}