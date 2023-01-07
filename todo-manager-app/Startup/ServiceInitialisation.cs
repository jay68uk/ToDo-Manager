using AutoMapper;
using todo_manager_library.Mappings;
using todo_manager_library.Services;
using todo_manager_library.Services.InMemoryData;

namespace todo.manager.app.Startup;

public static class ServiceInitialisation
{
    public static IServiceCollection RegisterServices(this IServiceCollection services)
    {
        services.AddScoped<IDataService, InMemoryDataService>();
        services.AddSingleton(GetMappers());

        return services;
    }

    private static Dictionary<string, IMapper> GetMappers()
    {
        var mappers = new Dictionary<string, IMapper> { { "todo", ToDoMapping.CreateMappings().CreateMapper() } };

        return mappers;
    }
}