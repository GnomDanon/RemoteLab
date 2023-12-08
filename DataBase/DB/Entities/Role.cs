
namespace DB.Entities
{
    public class Role
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public Permission? Permission { get; set; }
    }
}
