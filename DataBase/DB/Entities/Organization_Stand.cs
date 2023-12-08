
namespace DB.Entities
{
    public class Organization_Stand
    {
        public int Id { get; private set; }
        public Organization Organization { get; set; }
        public Stand Stand { get; set; }
    }
}
