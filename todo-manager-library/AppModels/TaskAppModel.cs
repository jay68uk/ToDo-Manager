namespace todo_manager_library.AppModels;

internal record TaskAppModel : BaseTaskAppModel
{
    public bool Done { get; set; }
}