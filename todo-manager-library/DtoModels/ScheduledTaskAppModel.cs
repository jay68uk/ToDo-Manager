using System.Text.Json.Serialization;

namespace todo_manager_library.DtoModels;

internal record ScheduledTaskDtoModel : BaseTaskDtoModel
{
    [JsonPropertyName("countSchedule")] public int CountSchedule { get; set; }

    [JsonPropertyName("dayOfWeekSchedule")]
    public DayOfWeek DayOfWeekSchedule { get; set; }
}