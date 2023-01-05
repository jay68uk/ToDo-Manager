namespace todo_manager_library.AppModels;

internal record ListAppModel<T>
{
    public Guid? Id { get; set; }
    public string? Name { get; set; }
    public DateTime? Date { get; set; }
    public IEnumerable<T>? Tasks { get; set; }
}