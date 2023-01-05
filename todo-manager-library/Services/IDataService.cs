namespace todo_manager_library.Services;

internal interface IDataService
{
    internal IEnumerable<T> GetList<T>(Guid listId) where T : class;
    internal bool SaveItem<T>(T item);
    internal T AddItem<T>(T item) where T : class;
    internal T RemoveItem<T>(T item) where T : class;
    internal T GetItemById<T>(Guid id) where T : class;
}