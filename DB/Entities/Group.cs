
namespace DB.Entities
{
    public class Group
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public string? Description { get; set; }
    }
}
