
namespace DB.Entities
{
    public class Scheduler
    {
        public int Id { get; private set; }
        public Group Group { get; set; }
        public DateTime SessionStartTime { get; set; }
        public DateTime SessionEndTime { get; set; }
        public DayOfWeek? SessionDayOfWeek { get; set; }
        public DateTime? StartPeriodDatetime { get; set; }
        public DateTime? EndPeriodDatetime { get; set;}
        public bool IsActive { get; set; }
    }
}
