
namespace DB.Entities
{
    public class Stand
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string VideostreamName { get; set; }
        public string? AnsibleScript {  get; set; }
        public Equipment Equipment { get; set; }
    }
}
