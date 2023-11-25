
namespace DB.Entities
{
    public class Organization
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public string? Stands { get; set; }
        public DateTime CreateTime { get; private set; } = DateTime.UtcNow;
    }
}
