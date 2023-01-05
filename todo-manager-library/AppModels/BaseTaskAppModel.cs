namespace todo_manager_library.AppModels;

internal record BaseTaskAppModel
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public bool Rollover { get; set; }
    public Guid ListId { get; set; }
}