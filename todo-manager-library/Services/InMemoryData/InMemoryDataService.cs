namespace todo_manager_library.Services.InMemoryData;

public class InMemoryDataService : IDataService
{
    IEnumerable<T> IDataService.GetList<T>(Guid listId)
    {
        throw new NotImplementedException();
    }

    bool IDataService.SaveItem<T>(T item)
    {
        throw new NotImplementedException();
    }

    T IDataService.AddItem<T>(T item)
    {
        throw new NotImplementedException();
    }

    T IDataService.RemoveItem<T>(T item)
    {
        throw new NotImplementedException();
    }

    T IDataService.GetItemById<T>(Guid id)
    {
        throw new NotImplementedException();
    }
}