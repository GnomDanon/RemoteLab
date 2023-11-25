
namespace DB.Entities
{
    public class Permission
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public bool IsAdmin { get; set; }
    }
}
