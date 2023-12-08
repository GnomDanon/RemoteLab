
namespace DB.Entities
{
    public class Service
    {
        public int Id { get; private set; }
        public Stand Stand { get; set; }
        public ServiceType ServiceType { get; set; }
        public DateTime TimeStartService { get; set; }
        public DateTime TimeStopService { get; set; }
        public int DockerPort { get; set; }
    }
}
