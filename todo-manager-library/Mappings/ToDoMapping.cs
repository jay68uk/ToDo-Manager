using AutoMapper;

namespace todo_manager_library.Mappings;

public class ToDoMapping : Profile
{
    public static MapperConfiguration CreateMappings()
    {
        var mapperConfiguration =
            new MapperConfiguration(mapperConfig => { mapperConfig.AddProfile<ToDoMapping>(); });

        return mapperConfiguration;
    }
}