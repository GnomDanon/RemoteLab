
namespace DB.Entities
{
    public class User
    {
        public int Id { get; private set; }
        public string Email { get; set; }
        public string Salt { get; set; }
        public string HashedPassword { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Organization? Organization { get; set; }
        public Role Role { get; set; }
        public Group? Group { get; set; }
    }
}
