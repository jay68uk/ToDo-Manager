namespace todo_manager_library.AppModels;

internal record ScheduledTaskAppModel : BaseTaskAppModel
{
    public int CountSchedule { get; set; }
    public DayOfWeek DayOfWeekSchedule { get; set; }
}