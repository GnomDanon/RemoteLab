
namespace DB.Entities
{
    public class Shedule_Stand
    {
        public int Id { get; private set; }
        public Stand Stand { get; set; }
        public Scheduler Scheduler { get; set; }
    }
}
