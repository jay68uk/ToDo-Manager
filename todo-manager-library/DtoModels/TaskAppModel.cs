namespace todo_manager_library.DtoModels;

internal record TaskDtoModel : BaseTaskDtoModel
{
    public bool Done { get; set; }
}