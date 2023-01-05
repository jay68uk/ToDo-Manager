using System.Text.Json.Serialization;

namespace todo_manager_library.DtoModels;

internal record BaseTaskDtoModel
{
    [JsonPropertyName("taskId")] public Guid Id { get; set; }
    [JsonPropertyName("taskName")] public string? Name { get; set; }
    [JsonPropertyName("rollover")] public bool Rollover { get; set; }
    [JsonPropertyName("listId")] public Guid ListId { get; set; }
}