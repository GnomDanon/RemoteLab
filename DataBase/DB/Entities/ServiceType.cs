
namespace DB.Entities
{
    public class ServiceType
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime DefaultTimeout { get; set; }
        public string DickerFilename { get; set; }
    }
}
