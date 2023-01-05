using System.Text.Json.Serialization;

namespace todo_manager_library.DtoModels;

internal record ListDtoModel<T>
{
    [JsonPropertyName("listId")] public Guid? Id { get; set; }
    [JsonPropertyName("listName")] public string? Name { get; set; }
    [JsonPropertyName("listDate")] public DateTime? Date { get; set; }
    [JsonPropertyName("tasks")] public IEnumerable<T>? Tasks { get; set; }
}